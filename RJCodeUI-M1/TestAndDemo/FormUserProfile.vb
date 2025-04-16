Imports System.IO
Imports Microsoft.ReportingServices.ReportProcessing.ReportObjectModel

Public Class FormUserProfile
    Inherits RJChildForm

    Private MySQL As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private ReadOnly usuarioBLL As UsuarioBLL
    Private Usuario As UsuarioDTO
    Private NovaFoto As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(user As UsuarioDTO)
        InitializeComponent()
        usuarioBLL = New UsuarioBLL(MySQL)
        Usuario = If(user IsNot Nothing, getUser(user.Id), Nothing)
        ' Verifica se o usuário é nulo e, em caso afirmativo, inicializa um usuário padrão
        If Usuario Is Nothing Then
            Usuario = New UsuarioDTO With {
                .Id = 0,
                .Nome = "SIBEM - CONGREGACAO CRISTA NO BRASIL",
                .Email = "@cps.congregacao.org.br",
                .Telefone = "(19) 3201-3170",
                .Senha = String.Empty,
                .Adm_Local = "PATRIMÔNIO - ATIVO IMOBILIZADO",
                .Cidade = "CAMPINAS",
                .Tipo = "user",
                .Id_Admlc = 99999,
                .Igreja = "BONFIM",
                .Foto = "\Imagens\userProfile.png"
            }
        End If

        ' Preenche os campos com os valores do objeto UsuarioDTO
        TxtId.Text = Usuario.Id
        TxtNome.Text = Usuario.Nome
        TxtTelefone.Text = Usuario.Telefone
        TxtEmail.Text = Usuario.Email
        TxtComum.Text = Usuario.Igreja
        TxtCidade.Text = Usuario.Cidade
        TxtId_Admlc.Text = Usuario.Id_Admlc
        TxtAdm.Text = Usuario.Adm_Local
        LblTipoBanco.Text = Usuario.Tipo

        If Usuario.Tipo = "admin" Then
            LblTipo.Text = "Administrador"
            PnlTipo.BackColor = Color.SteelBlue
        ElseIf Usuario.Tipo = "super" Then
            LblTipo.Text = "Super Usuário"
            PnlTipo.BackColor = Color.MediumAquamarine
        Else
            LblTipo.Text = "Usuário Padrão"
            PnlTipo.BackColor = Color.Tan
        End If

        Dim Foto As String = Application.StartupPath & Usuario.Foto
        If IO.File.Exists(Foto) Then
            ImgFoto.Image = Image.FromFile(Foto)
        Else
            ' Se a imagem não existir, use uma imagem padrão
            ImgFoto.Image = My.Resources.userProfile
        End If

    End Sub

    Private Sub BtnTrocarFoto_Click(sender As Object, e As EventArgs) Handles BtnTrocarFoto.Click
        Dim defaultImagePath As String = Application.StartupPath & "\Imagens\"
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ImgFoto.Image = Image.FromFile(openFileDialog.FileName)
            Try
                File.Copy(openFileDialog.FileName, defaultImagePath & openFileDialog.SafeFileName, True) ' Substitui a imagem
                NovaFoto = "\Imagens\" & openFileDialog.SafeFileName
            Catch ex As Exception
                RJMessageBox.Show("Erro ao copiar a imagem: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnRemoverFoto_Click(sender As Object, e As EventArgs) Handles BtnRemoverFoto.Click
        ImgFoto.Image = My.Resources.userProfile
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        ' Validação de campos obrigatórios
        Dim camposObrigatorios As RJTextBox() = {TxtNome, TxtTelefone, TxtEmail, TxtComum, TxtCidade}

        If Not ValidarCampos(camposObrigatorios) Then Return

        ' Valida a senha caso tenha sido informada
        If Not ValidarSenha() Then Return

        ' Criando o objeto usuário
        Dim NewUser As New UsuarioDTO With {
            .Nome = TxtNome.Text.ToString.ToUpper,
            .Telefone = TxtTelefone.Text.ToString,
            .Email = TxtEmail.Text.ToString,
            .Senha = If(Not String.IsNullOrWhiteSpace(TxtNovaSenha.Text), TxtNovaSenha.Text, Usuario.Senha),
            .Igreja = TxtComum.Text.ToString.ToUpper,
            .Cidade = TxtCidade.Text.ToString.ToUpper,
            .Tipo = LblTipoBanco.Text,
            .Id_Admlc = TxtId_Admlc.Text,
            .Foto = If(Not String.IsNullOrEmpty(NovaFoto), NovaFoto, Usuario.Foto),
            .Id = Usuario.Id
        }

        ' Tenta atualizar o usuário
        Try
            If TxtId.Text = 0 Then
                RJMessageBox.Show("Este usuário não pode ser alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            usuarioBLL.UpdateUser(NewUser)
            RJMessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            RJMessageBox.Show($"Erro ao atualizar o usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Função para validar vários campos ao mesmo tempo
    Private Function ValidarCampos(campos As RJTextBox()) As Boolean
        For Each campo As RJTextBox In campos
            If Not ValidarControle(campo, ErrorProvider1) Then
                Return False
            End If
        Next
        Return True
    End Function

    ' Função para validar senha somente se o usuário digitá-la
    Private Function ValidarSenha() As Boolean

        If String.IsNullOrWhiteSpace(TxtNovaSenha.Text) Then Return True

        If Not ValidarControle(TxtSenhaAtual, ErrorProvider1) OrElse
            Not ValidarControle(TxtNovaSenha, ErrorProvider1) OrElse
            Not ValidarControle(TxtConfirmaNovaSenha, ErrorProvider1) Then
            Return False
        End If

        If String.IsNullOrEmpty(TxtSenhaAtual.Text) Then
            RJMessageBox.Show("Campo senha atual não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If

        If TxtSenhaAtual.Text <> Usuario.Senha Then
            RJMessageBox.Show("Senha atual incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If TxtNovaSenha.Text <> TxtConfirmaNovaSenha.Text Then
            RJMessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function GetUser(IdUser As String) As UsuarioDTO
        Dim Usuarios As List(Of UsuarioDTO) = usuarioBLL.GetUserById(IdUser)
        Dim User As UsuarioDTO = Usuarios.FirstOrDefault(Function(u) u.Id = IdUser)
        If Usuarios Is Nothing OrElse Usuarios.Count = 0 Then
            RJMessageBox.Show("Usuário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If
        Return User
    End Function
End Class