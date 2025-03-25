Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms

Public Class FormInventarioRelatorioFinal
    Private admBLL As SistemaBLL
    Private ReadOnly InventarioBLL As InventariosBLL
    Private ReadOnly InventarioDetalheBLL As InventarioDetalhesBLL
    Private Inventario As List(Of InventariosDTO)
    Private Administracao As SistemaDTO
    Private InventarioDetalhes As List(Of InventarioDetalhesDTO)
    Private ReadOnly SQLite As ConnectionFactory
    Private ReadOnly BensEncontrados As Boolean

    Public Sub New(Optional Bens_Encontrados As Boolean = False)
        ' Inicialização dos componentes do formulário
        InitializeComponent()

        ' Instanciação das classes de conexão e regras de negócio
        SQLite = New ConnectionFactory()
        admBLL = New SistemaBLL(SQLite)
        InventarioBLL = New InventariosBLL(SQLite)
        InventarioDetalheBLL = New InventarioDetalhesBLL(SQLite)
        BensEncontrados = Bens_Encontrados
    End Sub

    Private Sub FormInventarioRelatorioFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Configuração da página de impressão
            Dim newPageSettings As New PageSettings With {
                .Margins = New Margins(8, 8, 10, 10)
            }

            ' Buscar Administração e converter para DataTable com um único registro
            Administracao = admBLL.BuscarAtivo()
            Dim dtAdm As New DataTable()

            ' Adicionar colunas ao DataTable de acordo com as propriedades do objeto Administracao
            dtAdm.Columns.Add("Adm_Regional", GetType(String))
            dtAdm.Columns.Add("Adm_Local", GetType(String))
            dtAdm.Columns.Add("CNPJ", GetType(String))

            ' Adicionar a única linha ao DataTable
            dtAdm.Rows.Add(Administracao.Adm_Regional, Administracao.Adm_Local, Administracao.CNPJ)

            ' Buscar Inventário Ativo e converter para DataTable
            Inventario = InventarioBLL.BuscarListaPorId(VarGlob.Id_Inventario_Ativo)
            If ListaVazia(Inventario, "Nenhum dado encontrado para o inventário.") Then Exit Sub
            Dim dtInventario As DataTable = FuncoesGerais.ConvertToDataTable(Inventario)

            ' Buscar Detalhes do Inventário
            If BensEncontrados Then
                InventarioDetalhes = InventarioDetalheBLL.BuscarTodos()

                ' Atualizar a propriedade "Acao" diretamente na lista existente
                For Each detalhe In InventarioDetalhes
                    If detalhe.Acao = "OK" Then detalhe.Acao = "LOCALIZADOS"
                Next
            Else
                InventarioDetalhes = InventarioDetalheBLL.BuscarTodos(Consultas:="LISTA PENDENTES TODOS")
            End If

            If ListaVazia(InventarioDetalhes, "Nenhum detalhe encontrado para o inventário.") Then Exit Sub
            Dim dtInventarioDetalhes As DataTable = FuncoesGerais.ConvertToDataTable(InventarioDetalhes)

            ' Obter inventário ativo
            Dim Invent As InventariosDTO = Inventario.FirstOrDefault(Function(t) t.Id = VarGlob.Id_Inventario_Ativo)
            If Invent Is Nothing Then
                MessageBox.Show("Inventário ativo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Configurar ReportViewer
            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .SetPageSettings(newPageSettings)
                .LocalReport.DataSources.Add(New ReportDataSource("DtsSistema", dtAdm))
                .LocalReport.DataSources.Add(New ReportDataSource("DtsInventarios", dtInventario))
                .LocalReport.DataSources.Add(New ReportDataSource("InventarioDetalhes", dtInventarioDetalhes))
                .LocalReport.DisplayName = $"SIBEM - Inventario_{Invent.Id}_{Invent.Igreja}"
                .RefreshReport()
            End With

        Catch ex As Exception
            RJMessageBox.Show($"Ocorreu um erro ao carregar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Função auxiliar para verificar se uma lista está vazia e exibir mensagem.
    ''' </summary>
    Private Function ListaVazia(Of T)(lista As List(Of T), mensagem As String) As Boolean
        If lista Is Nothing OrElse Not lista.Any() Then
            RJMessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

End Class
