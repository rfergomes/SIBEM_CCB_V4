Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class FormRelatorios
    Private admBLL As SistemaBLL
    Private ReadOnly InventarioBLL As InventariosBLL
    Private Inventario As DataTable
    Private Administracao As SistemaDTO
    Private SetoresBLL As SetoresBLL
    Private ReadOnly SQLite As ConnectionFactory

    Public Sub New()
        InitializeComponent()
        SQLite = New ConnectionFactory()
        admBLL = New SistemaBLL(SQLite)
        InventarioBLL = New InventariosBLL(SQLite)
        SetoresBLL = New SetoresBLL(SQLite)
    End Sub

    Private Sub FormRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Reset()
        ReportViewer1.RefreshReport()
        PopularComboBoxSetores()
        DtpInicio.Value = New Date(Year(Now()), 1, 1)
        DtpFim.Value = Now
    End Sub

    Private Sub BtnGerarRelatorio_Click(sender As Object, e As EventArgs) Handles BtnGerarRelatorio.Click
        If Not RbtMes.Checked AndAlso Not RbtSetor.Checked Then
            RJMessageBox.Show("Selecione um tipo de agrupamento de relatório. Por Setor ou Por Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DtpFim.Value < DtpInicio.Value Then
            RJMessageBox.Show("Data final não pode ser maior que a data inicial", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        With ReportViewer1
            .Clear()
            .Reset()
            .LocalReport.DataSources.Clear() ' 🛠️ Evita acumular dados antigos
            .Refresh()
        End With

        ' Define o caminho do relatório
        ReportViewer1.LocalReport.ReportPath = If(RbtSetor.Checked, "Relatorios/RelInventariosPorSetor.rdlc", "Relatorios/RelInventariosPorMes.rdlc")

        Dim DataInicio As DateTime = DtpInicio.Value
        Dim dataFim As DateTime = DtpFim.Value
        Dim Setor As String = If(CboSetor.Text <> "Selecione um setor", CboSetor.SelectedValue, "")
        Try
            ' Obtém os dados
            Dim dtSistema As DataTable = getSistema()
            Dim dtInventario As DataTable = getInventarios(DataInicio, dataFim, Setor)

            ' Garante que há dados antes de prosseguir
            If dtSistema Is Nothing OrElse dtSistema.Rows.Count = 0 OrElse dtInventario Is Nothing OrElse dtInventario.Rows.Count = 0 Then
                Exit Sub
            End If

            ' Configuração da página de impressão
            Dim newPageSettings As New PageSettings With {
                .Margins = New Margins(1.5, 1.5, 20, 20),
                .Landscape = False
            }

            Dim SubTitulo As String = If(RbtSetor.Checked, " por Setor", " por Mês")

            ' Adiciona as fontes de dados ao relatório
            With ReportViewer1
                .SetPageSettings(newPageSettings)
                .LocalReport.DataSources.Add(New ReportDataSource("DtSrcSistema", dtSistema))
                .LocalReport.DataSources.Add(New ReportDataSource("DtSrcInventarios", dtInventario))
                .LocalReport.DisplayName = $"SIBEM - Relatório Anual de Inventários{SubTitulo}"
                .RefreshReport()
            End With

        Catch ex As Exception
            RJMessageBox.Show($"Ocorreu um erro ao carregar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopularComboBoxSetores()
        Try
            ' Obtém os dados dos setores do banco de dados
            Dim dtSetores As DataTable = SetoresBLL.BuscarListaDt()

            ' Verifica se há dados antes de popular o ComboBox
            If dtSetores Is Nothing OrElse dtSetores.Rows.Count = 0 Then
                RJMessageBox.Show("Nenhum setor encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Define a origem dos dados
            With CboSetor
                .DataSource = dtSetores
                .DisplayMember = "descricao" ' Nome da coluna que será exibida no ComboBox
                .ValueMember = "cod_setor" ' Nome da coluna que representa o valor real
                .SelectedIndex = -1 ' Nenhum item selecionado inicialmente
                .SelectedValue = ""
                .Text = "Selecione um setor" ' Texto padrão
            End With

        Catch ex As Exception
            RJMessageBox.Show($"Erro ao carregar setores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''' <summary>
    ''' Obtém os dados do sistema e os retorna como DataTable
    ''' </summary>
    Private Function getSistema() As DataTable
        Administracao = admBLL.BuscarAtivo()
        If Administracao Is Nothing Then
            RJMessageBox.Show("Não foi possível obter os dados do sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        ' Cria e popula DataTable
        Dim dtAdm As New DataTable()
        dtAdm.Columns.Add("Adm_Regional", GetType(String))
        dtAdm.Columns.Add("Adm_Local", GetType(String))
        dtAdm.Columns.Add("CNPJ", GetType(String))
        dtAdm.Rows.Add(Administracao.Adm_Regional, Administracao.Adm_Local, Administracao.CNPJ)

        Return dtAdm
    End Function

    ''' <summary>
    ''' Obtém os dados dos inventários e os retorna como DataTable
    ''' </summary>
    Private Function getInventarios(DataInicio As Date, DataFim As Date, Optional Setor As String = "") As DataTable
        Inventario = InventarioBLL.BuscarListaDt(DataInicio, DataFim, Setor)
        If Inventario Is Nothing OrElse Inventario.Rows.Count <= 0 Then
            RJMessageBox.Show("Sem dados para os filtros selecionados.", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If

        Return Inventario
    End Function

    ''' <summary>
    ''' Restaura os filtros e limpa o ReportViewer
    ''' </summary>
    Private Sub Reset()
        RbtSetor.Checked = True
        RbtMes.Checked = False
        CboSetor.SelectedIndex = -1
        CboSetor.SelectedValue = Nothing
        CboSetor.Text = "Selecione um setor"
        DtpInicio.Value = New Date(Year(Now()), 1, 1)
        DtpFim.Value = Now

        With ReportViewer1
            .Clear()
            .Reset()
            .LocalReport.DataSources.Clear()
            .LocalReport.ReportPath = ""
            .RefreshReport()
        End With
    End Sub

    Private Sub BtnLimparFiltros_Click(sender As Object, e As EventArgs) Handles BtnLimparFiltros.Click
        Reset()
    End Sub
End Class
