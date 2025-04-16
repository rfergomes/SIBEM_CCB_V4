Public Class LoginFormDemo
    Inherits RJBaseForm
    Dim SQLite As New ConnectionFactory()
    Dim MySQL As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private usuarioBLL As New UsuarioBLL(SQLite)

    ''' <summary>
    ''' This class inherits from the <RJBaseForm /> class
    ''' The PARTIAL class is who should inherit from RJBaseForm (Found in LoginFormDemo.Designer.vb):
    '''     Partial class login
    '''             Inherit RJBaseForm
    ''' It is optional that this class inherits from RJBaseForm
    ''' </summary>
    ''' 

#Region "-> Constructor"

    Public Sub New()

        InitializeComponent()

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        AddControlBox() 'Add control box buttons (Close and minimize)
        ApplyAppearanceSettings() 'Apply appearance settings.

        'Add a line
        Dim line = New Control()
        line.Size = New Size(lblDescription.Width - 10, 1)
        line.BackColor = Color.LightGray
        line.Location = New Point(lblDescription.Left + 5, lblTitle.Bottom + 15)
        RjImageColorOverlay1.Controls.Add(line)
        usuarioBLL = New UsuarioBLL(MySQL)
    End Sub
#End Region

#Region "-> Private methods"

    Private Sub AddControlBox()
        'Add control buttons (close and minimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.btnClose.Height = 20
        Me.btnClose.Location = New Point(Me.Width - btnClose.Width, 0)
        Me.btnMinimize.Height = 20
        Me.btnMinimize.Location = New Point(Me.btnClose.Location.X - btnMinimize.Width, 0)
    End Sub

    Private Sub ApplyAppearanceSettings()
        'Apply the appearance properties of the configuration.

        Me.PrimaryForm = True 'Set as primary form.
        Me.Resizable = False 'Set that the form cannot be resized from the edges.
        Me.BorderSize = 0 'Remove the border.
        Me.BackColor = UIAppearance.BackgroundColor 'Set the background color

        If UIAppearance.Theme = UITheme.Light Then 'if the theme is CLEAR, set the maximize, minimize and close buttons to black.
            Me.btnClose.Image = My.Resources.CloseDark
            Me.btnMaximize.Image = My.Resources.MaximizeDark
            Me.btnMinimize.Image = My.Resources.MinimizeDark
        End If
    End Sub

    Private Sub Login()
        Dim user = New UsuarioDTO()
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            lblMessage.Text = "* Digite seu E-mail"
            lblMessage.Visible = True
            Return
        Else
            user.Email = Me.txtUser.Text
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblMessage.Text = "* Digite sua senha"
            lblMessage.Visible = True
            Return
        Else
            user.Senha = txtPassword.Text
        End If

        'Method to login
        Dim login As UsuarioDTO = usuarioBLL.Login(user.Email, user.Senha)
        If login IsNot Nothing Then
            VarGlob.UsuarioLogado = login
            Me.Hide()
            Dim mainForm = New MainFormDemo(login)
            mainForm.Show()

            'Redisplay the login form and clear the fields if the main form is closed.
            AddHandler mainForm.FormClosed, AddressOf MainForm_Logout
        Else
            VarGlob.UsuarioLogado = Nothing
            lblMessage.Text = "* Usuário ou sennha incorreta"
            lblMessage.Visible = True
        End If
    End Sub

    Private Sub Logout()
        'Method for when the session is closed from the main form.
        txtPassword.Clear()
        txtUser.Clear()
        lblMessage.Visible = False
        lblCaption.Select()
        Me.Show() 'Redisplay the login form.
    End Sub
#End Region

#Region "-> Overrides"

    Protected Overrides Sub CloseWindow()
        'Override the method (To remove the message box if you want to exit the app) and simply exit the application, This is optional.
        Application.Exit() 'Exit application.
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub MainForm_Logout(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Logout()
    End Sub

    Private Sub biYoutube_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biYoutube.Click
        Process.Start("https://youtube.com/rfergomes")
    End Sub

    Private Sub biWebPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biWebPage.Click
        Process.Start("https://sibem.online/")
    End Sub

    Private Sub biGitHub_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biGitHub.Click
        Process.Start("https://github.com/rfergomes/SIBEM_CCB_V4")
    End Sub

    Private Sub biFacebook_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFacebook.Click
        Process.Start("https://www.facebook.com/rfergomes")
    End Sub
#End Region

End Class
