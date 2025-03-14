Public Class FormUserProfile
    Inherits RJChildForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(user As UsuarioDTO)
        InitializeComponent()

        ' Verifica se o usuário é nulo e, em caso afirmativo, inicializa um usuário padrão
        If user Is Nothing Then
            user = New UsuarioDTO With {
                .Usuario = "SIBEM",
                .Nome = "CCB SIBEM",
                .DtNasc = DateTime.MinValue, ' Usa DateTime.MinValue ou outra data padrão
                .Email = "sibem@gmail.com",
                .Telefone = "(00) 0.0000-0000",
                .Senha = "123456"
            }
        End If

        ' Preenche os campos com os valores do objeto UsuarioDTO
        txtUsername.Text = user.Usuario
        txtFirstName.Text = user.Nome
        txtEmail.Text = user.Email
        txtPhoneNumber.Text = user.Telefone
        txtCurrentPassword.Text = user.Senha

        ' Trata a conversão da data de nascimento
        If user.DtNasc <> DateTime.MinValue Then
            dpBirthdate.Value = user.DtNasc ' Define a data se válida
        Else
            dpBirthdate.Value = DateTime.Today ' Ou outra data padrão
        End If

        ' Preencher a imagem se existir
        ' Se Foto for do tipo Image ou Byte[], adapte conforme necessário
        ' If user.Foto IsNot Nothing Then
        '     pbPhoto.Image = user.Foto
        ' End If
    End Sub

End Class