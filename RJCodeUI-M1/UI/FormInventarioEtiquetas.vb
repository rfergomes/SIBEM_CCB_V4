'Última Atualização:    04/11/2024
'Data:                  03/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima


Imports System.IO

Public Class FormInventarioEtiquetas
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private InventarioBLL As InventariosBLL
    Private Inventario As InventariosDTO

    Sub New(Id_Inventario As String)
        InitializeComponent()
        ' Busca informações do inventário e inicializa os componentes da interface.
        Inventario = New InventariosBLL(SQLite).BuscarPorId(Id_Inventario)
        LblIgreja.Text = Inventario.Igreja
    End Sub

    Private Sub FormInventarioEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar estado da interface se necessário.
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        ' Filtra os dados e gera o CSV
        Dim CsvDados As String = FiltrarDados()

        ' Verifica a contagem de etiquetas usando o número de itens filtrados
        Dim Cont As Integer = CsvDados.Count(Function(c) c = ","c) + 1 ' Conta etiquetas baseado nas vírgulas no CSV

        ' Exibe a contagem e o CSV no TextBox
        If Cont >= 1 Then
            LblEtiquetasTotal.Text = $"{Cont} Etiqueta(s)"
            TxtEtiquetas.Text = CsvDados
            SetButtonStates(True)
        End If
    End Sub

    ' Método de filtro separado para reutilização e clareza
    Private Function FiltrarDados() As String
        Dim InventarioDetalheBll As New InventarioDetalhesBLL(SQLite)
        Dim InventarioDetalhe As List(Of InventarioDetalhesDTO) = InventarioDetalheBll.BuscarTodos()
        Dim acoesPermitidas = DefinirAcoesPermitidas()

        If Not acoesPermitidas.Any() Then
            BtnLimpar_Click(Nothing, Nothing)
            Return String.Empty
        End If

        ' Filtra e ordena os dados e cria o CSV
        Dim DadosFiltrado As List(Of InventarioDetalhesDTO) = InventarioDetalhe.
        Where(Function(item) acoesPermitidas.Contains(item.Acao) AndAlso item.Id_Bem.ToString().Length = 12).
        OrderBy(Function(item) item.Id_Bem).
        ToList()

        ' Retorna o CSV em uma única string
        Return String.Join(",", DadosFiltrado.Select(Function(detalhe) detalhe.Id_Bem.ToString()))
    End Function

    ' Define ações permitidas com base na seleção dos botões de rádio
    Private Function DefinirAcoesPermitidas() As List(Of String)
        Dim acoesPermitidas As New List(Of String)
        If RbtImprimir.Checked Then
            acoesPermitidas.Add("IMPRIMIR")
        ElseIf RbtAlterar.Checked Then
            acoesPermitidas.Add("ALTERAR")
        ElseIf RbtAmbas.Checked Then
            acoesPermitidas.AddRange({"IMPRIMIR", "ALTERAR"})
        End If
        Return acoesPermitidas
    End Function

    ' Método para definir o estado dos botões em um único local
    Private Sub SetButtonStates(state As Boolean)
        BtnCopiar.Enabled = state
        BtnCopiarSiga.Enabled = state
        BtnTXT.Enabled = state
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        RbtImprimir.Checked = False
        RbtAlterar.Checked = False
        RbtAmbas.Checked = False
        TxtEtiquetas.Enabled = False
        TxtEtiquetas.Text = String.Empty
        SetButtonStates(False)
        LblEtiquetasTotal.Text = "-"
    End Sub

    ' Método para copiar o conteúdo do TextBox para a área de transferência
    Private Sub CopiarTextoParaClipboard()
        If Not String.IsNullOrEmpty(TxtEtiquetas.Text) Then
            Clipboard.Clear()
            Clipboard.SetText(TxtEtiquetas.Text)
            RJMessageBox.Show("Texto copiado para a área de transferência.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RJMessageBox.Show("O TextBox está vazio. Nada para copiar.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        CopiarTextoParaClipboard()
    End Sub

    Private Sub BtnCopiarSiga_Click(sender As Object, e As EventArgs) Handles BtnCopiarSiga.Click
        CopiarTextoParaClipboard()
        Try
            Dim URL As String = "https://siga.congregacao.org.br/PTR/PTR00701.aspx?f_inicio=S"
            Dim NewProcess As New Diagnostics.ProcessStartInfo(URL) With {
                .UseShellExecute = True
            }
            Process.Start(NewProcess)
        Catch ex As Exception
            RJMessageBox.Show(ex.Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub BtnTXT_Click(sender As Object, e As EventArgs) Handles BtnTXT.Click
        Dim pastaDownloads As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        Dim caminhoArquivo As String = Path.Combine(pastaDownloads, $"{Inventario.Id}_{Inventario.Igreja}.txt")
        Try
            File.WriteAllText(caminhoArquivo, TxtEtiquetas.Text)
            RJMessageBox.Show($"Arquivo salvo com sucesso em {caminhoArquivo}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            RJMessageBox.Show(ex.Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
