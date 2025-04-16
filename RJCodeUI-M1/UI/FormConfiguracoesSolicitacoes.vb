Imports System.Text
Imports System.Web
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports Org.BouncyCastle.Asn1.Cmp

Public Class FormConfiguracoesSolicitacoes
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private MySQL_SYS As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private Id_Usuario As String = String.Empty
    Private SemAdm As Boolean = False

    Public Sub New(IdUsuario As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Id_Usuario = IdUsuario
        Iniciar()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        BtnSalvar.Enabled = True
        BtnEditar.Enabled = False
        TxtNome.Enabled = True
        TxtAdmlc.Enabled = True
        TxtEmail.Enabled = True
        TxtTelefone.Enabled = True
        TxtComum.Enabled = True
        TxtCidade.Enabled = True
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim UsuarioBLL As New UsuarioBLL(MySQL_SYS)
        If Not ValidarControle(TxtNome, ErrorProvider1) Then Return
        If Not ValidarControle(TxtAdmlc, ErrorProvider1) Then Return
        If Not ValidarControle(TxtEmail, ErrorProvider1) Then Return
        If Not ValidarControle(TxtTelefone, ErrorProvider1) Then Return
        If Not ValidarControle(TxtComum, ErrorProvider1) Then Return
        If Not ValidarControle(TxtCidade, ErrorProvider1) Then Return

        Try
            Dim Usuarios As List(Of UsuarioDTO) = UsuarioBLL.GetUserById(Id_Usuario)
            If Usuarios IsNot Nothing AndAlso Usuarios.Count > 0 Then
                Dim Usuario As UsuarioDTO = Usuarios.FirstOrDefault()
                With Usuario
                    .Nome = TxtNome.Text.ToUpper
                    .Id_Admlc = TxtAdmlc.Text
                    .Email = TxtEmail.Text.ToLower
                    .Telefone = TxtTelefone.Text
                    .Igreja = TxtComum.Text.ToUpper
                    .Cidade = TxtCidade.Text.ToUpper
                End With
                UsuarioBLL.UpdateUser(Usuario)
                RJMessageBox.Show("Dados do usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            RJMessageBox.Show($"Não foi possível salvar os dados do usuário!{vbNewLine}{ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        BtnSalvar.Enabled = False
        BtnEditar.Enabled = True
        TxtNome.Enabled = False
        TxtAdmlc.Enabled = False
        TxtEmail.Enabled = False
        TxtTelefone.Enabled = False
        TxtComum.Enabled = False
        TxtCidade.Enabled = False
        Iniciar()
    End Sub

    Private Sub Iniciar()
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        Dim UsuarioBLL As New UsuarioBLL(MySQL_SYS)
        Dim Usuarios As List(Of UsuarioDTO) = UsuarioBLL.GetUserById(Id_Usuario)

        If Usuarios IsNot Nothing AndAlso Usuarios.Count > 0 Then
            Dim Usuario As UsuarioDTO = Usuarios.FirstOrDefault()

            TxtCodigo.Text = Usuario.Id
            TxtNome.Text = Usuario.Nome
            TxtAdmlc.Text = Usuario.Id_Admlc
            TxtEmail.Text = Usuario.Email
            TxtTelefone.Text = Usuario.Telefone
            TxtComum.Text = Usuario.Igreja
            TxtCidade.Text = Usuario.Cidade
            BtnLiberar.Enabled = False
            BtnBloquear.Enabled = False
            BtnWhatsApp.Visible = False
            If VarGlob.UsuarioLogado.Tipo = "admin" Then
                BtnEditar.Visible = True
                BtnSalvar.Visible = True
                BtnEditar.Enabled = True
            Else
                BtnEditar.Visible = False
                BtnSalvar.Visible = False
            End If
        End If
        DgvTokensLoad()
        LoadAdms()
    End Sub


    Private Sub DgvTokensConfig()
        With DgvTokens
            .ColumnHeaderColor = Color.FromArgb(0, 122, 204)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 30
            .Columns("id").Visible = False
            .Columns("Id_Usuario").Visible = False
            .Columns("token").HeaderText = "Tokens"
            .Columns("token").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("id_admlc").Visible = False
            .Columns("adm_local").HeaderText = "Administração"
            .Columns("adm_local").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dispositivo").HeaderText = "Dispositivo"
            .Columns("dispositivo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("ativo").Visible = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204)
            .EnableHeadersVisualStyles = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AllowUserToOrderColumns = False

        End With
    End Sub

    Private Sub DgvTokensLoad()
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        Dim Dados As List(Of TokenOnDTO) = TokenBLL.BuscarTodos()
        Dim Tokens As List(Of TokenOnDTO) = Dados.Where(Function(x) x.Id_Usuario = Id_Usuario).ToList()
        With DgvTokens
            .DataSource = Nothing
            .Columns.Clear()
            .AutoGenerateColumns = True
            .DataSource = Tokens
            DgvTokensConfig()
            .AllowUserToOrderColumns = True
            .ClearSelection()
        End With
        LblTotalTokens.Text = DgvTokens.Rows.Count & " tokens"
    End Sub

    Private Sub DgvTokens_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTokens.CellClick
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        If DgvTokens.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DgvTokens.SelectedRows(0)
            Dim Tokens As List(Of TokenOnDTO) = TokenBLL.BuscarPorToken(row.Cells("token").Value)
            If Tokens IsNot Nothing Then
                Dim Token As TokenOnDTO = Tokens.FirstOrDefault()
                If Token.Ativo = 1 Then
                    BtnLiberar.Enabled = False
                    BtnBloquear.Enabled = True
                    BtnWhatsApp.Visible = True
                    BtnEmail.Visible = True
                    LoadAdms(row.Cells("id_admlc").Value)
                Else
                    BtnLiberar.Enabled = True
                    BtnBloquear.Enabled = False
                    BtnWhatsApp.Visible = False
                    BtnEmail.Visible = False
                    LoadAdms(TxtCidade.Text)
                End If
            End If

            TxtToken.Text = row.Cells("token").Value
            TxtAdmLocal.Text = row.Cells("id_admlc").Value
            TxtAdm_Local.Text = row.Cells("adm_local").Value
            TxtDispositivo.Text = row.Cells("dispositivo").Value

        End If

    End Sub


    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadAdms()
    End Sub

    Private Sub LoadAdms(Optional Pesquisar As String = "")
        Dim Pesquisa As String = If(Pesquisar <> "", Pesquisar, TxtPesquisar.Text)
        Dim ListaAdministracoes As New AdmlcOnBLL(MySQL_SYS)
        Dim Dados As List(Of AdmlcOnDTO) = ListaAdministracoes.BuscarTodos(Pesquisa)

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
            .ColumnHeaderColor = Color.FromArgb(0, 122, 204)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 30
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
            If TxtAdmLocal.Text = "0" OrElse Not String.IsNullOrEmpty(TxtAdmLocal.Text) Then
                TxtAdmLocal.Text = row.Cells("id").Value
            End If
        End If
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        Dim Tokens As List(Of TokenOnDTO) = TokenBLL.BuscarPorToken(TxtToken.Text)

        If Tokens IsNot Nothing Then
            If Not ValidarControle(TxtAdmLocal, ErrorProvider1) Then Return
            If Not ValidarControle(TxtDispositivo, ErrorProvider1) Then
                TxtDispositivo.Enabled = True
                TxtDispositivo.Focus()
                Return
            End If

            Try
                Dim Token As TokenOnDTO = Tokens.FirstOrDefault(Function(t) t.Token = TxtToken.Text)
                If Token IsNot Nothing AndAlso Token.Ativo = 0 Then
                    Token.Ativo = 1
                    Token.Id_Admlc = TxtAdmLocal.Text
                    Token.Dispositivo = TxtDispositivo.Text.ToUpper
                    TokenBLL.Atualizar(Token)
                    LimparCamposToken()
                    DgvTokensLoad()
                    Iniciar()
                    RJMessageBox.Show("Token liberado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    RJMessageBox.Show("Token já está liberado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Catch ex As Exception
                BtnWhatsApp.Visible = False
                RJMessageBox.Show($"Falha ao liberar o acesso: {vbNewLine}{ex.Message}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            RJMessageBox.Show("Token não existe na base de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnBloquear_Click(sender As Object, e As EventArgs) Handles BtnBloquear.Click
        Dim TokenBLL As New TokenOnBLL(MySQL_SYS)
        Dim Tokens As List(Of TokenOnDTO) = TokenBLL.BuscarPorToken(TxtToken.Text)
        Try
            Dim Token As TokenOnDTO = Tokens.FirstOrDefault()
            If Token IsNot Nothing AndAlso Token.Ativo = 1 Then
                Token.Ativo = 0
                TokenBLL.Atualizar(Token)
            End If
            BtnWhatsApp.Visible = False
            BtnEmail.Visible = False
            RJMessageBox.Show($"Acesso revogado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            RJMessageBox.Show($"Falha ao revogar o acesso: {vbNewLine}{ex.Message}", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub LimparCamposToken()
        TxtToken.Text = String.Empty
        TxtToken.Enabled = False
        TxtAdmLocal.Text = String.Empty
        TxtAdmLocal.Enabled = False
        TxtAdm_Local.Text = String.Empty
        TxtDispositivo.Text = String.Empty
        TxtDispositivo.Enabled = False
        TxtPesquisar.Text = String.Empty
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

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        Try
            Dim Mensagem As String = $"<p>A Paz de Deus irmão {TxtNome.Text}!<br></p>" &
              $"<p></p>" &
              $"<p>Segue abaixo código token para acesso ao sistema de inventários SIBEM </p><br />" &
              $"<h3>{TxtToken.Text}</h3><br />" &
              $"<p>Copie e cole este código no campo indicado no sistema quando necessário.</p>" &
              $"<p>Este token está atribuido ao equipamento <strong>{TxtDispositivo.Text}<strong> da Administração <strong>{TxtAdm_Local.Text}</strong>.</p>" &
              $"<p>Para utilizar em outro equipamento, solicite um novo token do equipamento desejado.</p><br />" &
              "<p>Att,</p><p>SIBEM - Sistema para Inventário de Bens Móveis</p><p>CCB - Administração Campinas</p>"

            EmailHelper.EnviarEmail("Token para acesso ao Sistema SIBEM", Mensagem, TxtEmail.Text.ToLower)
            RJMessageBox.Show("E-mail enviado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            RJMessageBox.Show($"Falha ao enviar email {vbNewLine}{ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "Métodos e  Funções Auxiliares"


    Private Function SomenteNumeros(ByVal texto As String) As String
        ' Remove tudo que não for número (0-9)
        Return Regex.Replace(texto, "[^\d]", "")
    End Function









#End Region
End Class