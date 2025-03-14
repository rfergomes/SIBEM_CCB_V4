Imports System.Text
Imports System.Web
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class FormConfiguracoesSolicitacoes
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private MySQL_SYS As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private Id_Solicitacao As String = String.Empty
    Private SemAdm As Boolean = False

    Public Sub New(Id_Solicitante As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Id_Solicitacao = Id_Solicitante
        Iniciar()
    End Sub

    Private Sub FormConfiguracoesSolicitacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Iniciar()
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        Dim TokenSolicitacaoBLL As New TokenSolicitacaoOnBLL(MySQL_SYS)

        Dim Solicitacao As TokenSolicitacaoOnDTO = TokenSolicitacaoBLL.BuscarPorId(Id_Solicitacao)

        If Solicitacao IsNot Nothing Then
            TxtCodigo.Text = Solicitacao.Id
            TxtNome.Text = Solicitacao.Nome
            TxtEmail.Text = Solicitacao.Email
            TxtTelefone.Text = Solicitacao.Telefone
            TxtComum.Text = Solicitacao.Igreja
            TxtCidade.Text = Solicitacao.Cidade
            TxtSetor.Text = Solicitacao.Setor
            TxtAdmlc.Text = Solicitacao.AdmLc
            TxtStatus.Text = Solicitacao.Status

            Dim Dados As List(Of TokenOnDTO) = TokenBLL.BuscarTodos()
            Dim Token As TokenOnDTO = Dados.FirstOrDefault(Function(x) x.Id_solicitacao = TxtCodigo.Text)

            If Token IsNot Nothing Then
                TxtToken.Text = Token.Token
                TxtToken.Enabled = True
                BtnWhatsApp.Visible = True
            Else
                TxtToken.Text = ""
                TxtToken.Enabled = False
                BtnWhatsApp.Visible = False
            End If
        End If

        If String.IsNullOrEmpty(Solicitacao.AdmLc) AndAlso Solicitacao.Status = 0 Then
            Me.Width = 935
            RjPanel2.Visible = True
            LblConsultarAdm.Visible = True
            lblNumberItems.Visible = True
            BtnLiberar.Enabled = True
            BtnBloquear.Enabled = False
        Else
            Me.Width = 541
            RjPanel2.Visible = False
            LblConsultarAdm.Visible = False
            lblNumberItems.Visible = False
            BtnLiberar.Enabled = False
            BtnBloquear.Enabled = True
        End If
        If String.IsNullOrEmpty(TxtAdmlc.Text) Then Me.SemAdm = True
        LoadAdms()
    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadAdms()
    End Sub

    Private Sub LoadAdms()
        Dim ListaAdministracoes As New AdmlcOnBLL(MySQL_SYS)
        Dim Dados As List(Of AdmlcOnDTO) = ListaAdministracoes.BuscarTodos(TxtPesquisar.Text)

        With DgvAdmlc
            .DataSource = Nothing
            .Columns.Clear()
            .AutoGenerateColumns = True
            .DataSource = Dados
            ConfigurarColunasDataGridView()
            .AllowUserToOrderColumns = True
            .ClearSelection()
        End With
        lblNumberItems.Text = DgvAdmlc.Rows.Count
    End Sub

    Private Sub ConfigurarColunasDataGridView()
        ' Configuração das colunas do DataGridView
        With DgvAdmlc
            .Columns("razao_social").Visible = False
            .Columns("cnpj").Visible = False
            .Columns("cidade").Visible = False
            .Columns("uf").Visible = False
            .Columns("id_status").Visible = False
            .Columns("id_admrg").Visible = False
            .Columns("id").HeaderText = "Código"
            .Columns("adm_local").HeaderText = "Administração"
            .Columns("adm_local").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End With
    End Sub

    Private Sub DgvAdmlc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAdmlc.CellClick
        If DgvAdmlc.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DgvAdmlc.SelectedRows(0)
            If SemAdm Then
                TxtAdmlc.Text = row.Cells("id").Value
            End If
        End If
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        Dim TokenSolicitacaoBLL As New TokenSolicitacaoOnBLL(MySQL_SYS)

        If Not String.IsNullOrEmpty(TxtAdmlc.Text) Then
            Dim NovoToken As New TokenOnDTO With {
                .Id_Admlc = TxtAdmlc.Text,
                .Id_solicitacao = TxtCodigo.Text,
                .status = 0,
                .Token = GerarTokenSHA256(TxtEmail.Text)
            }

            Dim ConsultaSolicitante As TokenSolicitacaoOnDTO = TokenSolicitacaoBLL.BuscarPorId(TxtCodigo.Text)
            ConsultaSolicitante.AdmLc = TxtAdmlc.Text

            Try
                TokenBLL.Inserir(NovoToken)
                TokenSolicitacaoBLL.Atualizar(ConsultaSolicitante)
                Iniciar()
                RJMessageBox.Show("Acesso Liberado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                RJMessageBox.Show($"Falha ao liberar o acesso: {vbNewLine}{ex.Message}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            RJMessageBox.Show("Selecione uma Administração", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnWhatsApp_Click(sender As Object, e As EventArgs) Handles BtnWhatsApp.Click
        Dim Mensagem As String = HttpUtility.UrlEncode($"*A Paz de Deus!*{vbNewLine}Segue token para *acesso* ao sistema de inventários *SIBEM CCB*{vbNewLine}{vbNewLine}{TxtToken.Text}")
        ' URL do site que você deseja abrir
        Dim url As String = $"https://wa.me/55{SomenteNumeros(TxtTelefone.Text)}/?text={Mensagem}"

        Try
            ' Abre o site no navegador padrão
            Process.Start(url)
        Catch ex As Exception
            ' Trata erros caso o navegador não consiga abrir
            MessageBox.Show("Não foi possível abrir o site. Verifique sua conexão com a internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Métodos e  Funções Auxiliares"

    Function GerarTokenSHA256(ByVal input As String) As String
        Try
            ' Combina o input com um timestamp para garantir unicidade
            Dim dataParaHash As String = input & DateTime.UtcNow.ToString("yyyyMMddHHmmssfff")

            ' Converte o valor para bytes
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(dataParaHash)

            ' Instancia o algoritmo SHA256
            Using sha256 As SHA256 = SHA256.Create()
                ' Calcula o hash
                Dim hashBytes As Byte() = sha256.ComputeHash(inputBytes)

                ' Converte o hash para uma string hexadecimal
                Dim sb As New StringBuilder()
                For Each b As Byte In hashBytes
                    sb.Append(b.ToString("x2")) ' Converte para hexadecimal
                Next

                Return sb.ToString()
            End Using
        Catch ex As Exception
            ' Trata possíveis erros e retorna uma mensagem padrão
            Return "Erro ao gerar token: " & ex.Message
        End Try
    End Function

    Private Function SomenteNumeros(ByVal texto As String) As String
        ' Remove tudo que não for número (0-9)
        Return Regex.Replace(texto, "[^\d]", "")
    End Function
#End Region
End Class