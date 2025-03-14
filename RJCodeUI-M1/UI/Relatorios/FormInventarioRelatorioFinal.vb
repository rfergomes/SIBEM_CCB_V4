Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms

Public Class FormInventarioRelatorioFinal
    Private InventarioBLL As InventariosBLL
    Private InventarioDetalheBLL As InventarioDetalhesBLL
    Private Inventario As List(Of InventariosDTO)
    Private InventarioDetalhes As List(Of InventarioDetalhesDTO)
    Private SQLite As ConnectionFactory
    Private MySQL As ConnectionFactory
    Private BensEncontrados As Boolean

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        SQLite = New ConnectionFactory()
        MySQL = New ConnectionFactory(DatabaseType.MySQL)
        InventarioBLL = New InventariosBLL(SQLite)
        InventarioDetalheBLL = New InventarioDetalhesBLL(SQLite)
    End Sub

    Public Sub New(Optional Bens_Encontrados As Boolean = False)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        SQLite = New ConnectionFactory()
        MySQL = New ConnectionFactory(DatabaseType.MySQL)
        InventarioBLL = New InventariosBLL(SQLite)
        InventarioDetalheBLL = New InventarioDetalhesBLL(SQLite)
        BensEncontrados = Bens_Encontrados
    End Sub

    Private Sub FormInventarioRelatorioFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim newPageSettings As New PageSettings With {
                .Margins = New Margins(5, 5, 8, 8)
            }

            ' Buscar Inventário Ativo
            Inventario = InventarioBLL.BuscarListaPorId(VarGlob.Id_Inventario_Ativo)
            If Inventario Is Nothing OrElse Not Inventario.Any() Then
                RJMessageBox.Show("Nenhum dado encontrado para o inventário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Buscar Detalhes do Inventário
            If BensEncontrados Then
                InventarioDetalhes = InventarioDetalheBLL.BuscarTodos()
                InventarioDetalhes = InventarioDetalhes.Select(Function(d)
                                                                   If d.Acao = "OK" Then
                                                                       d.Acao = "LOCALIZADOS"
                                                                   End If
                                                                   Return d
                                                               End Function).ToList()
            Else
                InventarioDetalhes = InventarioDetalheBLL.BuscarTodos(Consultas:="LISTA PENDENTES TODOS")
            End If

            If InventarioDetalhes Is Nothing OrElse Not InventarioDetalhes.Any() Then
                RJMessageBox.Show("Nenhum detalhe encontrado para o inventário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Calcular Resultado
            Dim Invent As InventariosDTO = Inventario.FirstOrDefault(Function(t) t.Id = VarGlob.Id_Inventario_Ativo)
            If Invent Is Nothing Then
                MessageBox.Show("Inventário ativo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim Resultado As String = If(Invent.Bens_Final > 0,
                                          (Invent.Bens_Lidos / Invent.Bens_Final).ToString("P0"),
                                          "N/A")

            ' Configurar ReportViewer
            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(New ReportDataSource("DtsInventarios", Inventario))
                .LocalReport.DataSources.Add(New ReportDataSource("InventarioDetalhes", InventarioDetalhes))
                .LocalReport.SetParameters(New ReportParameter("administracao", $"{VarGlob.SistemaAtivo.Adm_Regional} / {VarGlob.SistemaAtivo.Adm_Local}"))
                .LocalReport.SetParameters(New ReportParameter("cnpj", $"CNPJ: {VarGlob.SistemaAtivo.CNPJ} - IE: ISENTO "))
                .LocalReport.SetParameters(New ReportParameter("Resultado", Resultado))
                .SetPageSettings(newPageSettings)
                .LocalReport.DisplayName = "Inventario_" & Invent.Id & "_" & Invent.Igreja
                .RefreshReport()
            End With
        Catch ex As Exception
            RJMessageBox.Show($"Ocorreu um erro ao carregar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class