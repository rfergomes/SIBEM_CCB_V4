<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFormDemo
    Inherits PROJETOBASE.RJBaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFormDemo))
        Me.RjImageColorOverlay1 = New PROJETOBASE.RJImageColorOverlay()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblCaption = New PROJETOBASE.RJLabel()
        Me.txtUser = New PROJETOBASE.RJTextBox()
        Me.txtPassword = New PROJETOBASE.RJTextBox()
        Me.RjMenuIcon1 = New PROJETOBASE.RJMenuIcon()
        Me.RjMenuIcon2 = New PROJETOBASE.RJMenuIcon()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnLogin = New PROJETOBASE.RJButton()
        Me.lblForgotPass = New PROJETOBASE.RJLabel()
        Me.biFacebook = New PROJETOBASE.RJMenuIcon()
        Me.biGitHub = New PROJETOBASE.RJMenuIcon()
        Me.biWebPage = New PROJETOBASE.RJMenuIcon()
        Me.biYoutube = New PROJETOBASE.RJMenuIcon()
        Me.RjDragControl1 = New PROJETOBASE.RJDragControl(Me.components)
        Me.RjDragControl2 = New PROJETOBASE.RJDragControl(Me.components)
        Me.RjImageColorOverlay1.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjMenuIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjMenuIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biFacebook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biGitHub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biWebPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biYoutube, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RjImageColorOverlay1
        '
        Me.RjImageColorOverlay1.BackgroundImage = CType(resources.GetObject("RjImageColorOverlay1.BackgroundImage"), System.Drawing.Image)
        Me.RjImageColorOverlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RjImageColorOverlay1.BorderRadius = 0
        Me.RjImageColorOverlay1.Controls.Add(Me.lblVersion)
        Me.RjImageColorOverlay1.Controls.Add(Me.lblDescription)
        Me.RjImageColorOverlay1.Controls.Add(Me.lblTitle)
        Me.RjImageColorOverlay1.Controls.Add(Me.pbLogo)
        Me.RjImageColorOverlay1.Controls.Add(Me.lblWelcome)
        Me.RjImageColorOverlay1.Customizable = True
        Me.RjImageColorOverlay1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RjImageColorOverlay1.Image = CType(resources.GetObject("RjImageColorOverlay1.Image"), System.Drawing.Image)
        Me.RjImageColorOverlay1.ImageMode = System.Windows.Forms.ImageLayout.Stretch
        Me.RjImageColorOverlay1.Location = New System.Drawing.Point(0, 0)
        Me.RjImageColorOverlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.RjImageColorOverlay1.Name = "RjImageColorOverlay1"
        Me.RjImageColorOverlay1.Opacity = 80
        Me.RjImageColorOverlay1.OverlayColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjImageColorOverlay1.Size = New System.Drawing.Size(370, 470)
        Me.RjImageColorOverlay1.TabIndex = 0
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.LightGray
        Me.lblVersion.Location = New System.Drawing.Point(15, 439)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(101, 13)
        Me.lblVersion.TabIndex = 9
        Me.lblVersion.Text = "By Rodrigo Lima"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.LightGray
        Me.lblDescription.Location = New System.Drawing.Point(84, 291)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(203, 16)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Patrimônio - Ativo Imobilizado"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitle.Location = New System.Drawing.Point(33, 222)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(304, 50)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Uso Exclusivo da " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Congregação Cristã no Brasil"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = Global.PROJETOBASE.My.Resources.Resources.SIBEM_Logo_Branco
        Me.pbLogo.Location = New System.Drawing.Point(54, 20)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(263, 71)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 6
        Me.pbLogo.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.LightGray
        Me.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblWelcome.Location = New System.Drawing.Point(95, 159)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(183, 16)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "S E J A   B E M   V I N D O"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblCaption.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lblCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblCaption.LinkLabel = False
        Me.lblCaption.Location = New System.Drawing.Point(390, 20)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(63, 23)
        Me.lblCaption.Style = PROJETOBASE.LabelStyle.Title2
        Me.lblCaption.TabIndex = 1
        Me.lblCaption.Text = "Login"
        '
        'txtUser
        '
        Me.txtUser._Customizable = False
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUser.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtUser.BorderRadius = 0
        Me.txtUser.BorderSize = 2
        Me.txtUser.Font = New System.Drawing.Font("Verdana", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUser.Location = New System.Drawing.Point(428, 130)
        Me.txtUser.MultiLine = False
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtUser.PasswordChar = False
        Me.txtUser.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtUser.PlaceHolderText = "Usuário"
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.Size = New System.Drawing.Size(250, 32)
        Me.txtUser.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.txtUser.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword._Customizable = False
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPassword.BorderRadius = 0
        Me.txtPassword.BorderSize = 2
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(428, 185)
        Me.txtPassword.MultiLine = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPassword.PasswordChar = True
        Me.txtPassword.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtPassword.PlaceHolderText = "Senha"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.Size = New System.Drawing.Size(250, 32)
        Me.txtPassword.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.txtPassword.TabIndex = 3
        '
        'RjMenuIcon1
        '
        Me.RjMenuIcon1.BackColor = System.Drawing.Color.Transparent
        Me.RjMenuIcon1.BackIcon = True
        Me.RjMenuIcon1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjMenuIcon1.Customizable = False
        Me.RjMenuIcon1.DropdownMenu = Nothing
        Me.RjMenuIcon1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjMenuIcon1.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.RjMenuIcon1.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjMenuIcon1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjMenuIcon1.IconSize = 25
        Me.RjMenuIcon1.Location = New System.Drawing.Point(397, 193)
        Me.RjMenuIcon1.Name = "RjMenuIcon1"
        Me.RjMenuIcon1.Size = New System.Drawing.Size(25, 25)
        Me.RjMenuIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RjMenuIcon1.TabIndex = 4
        Me.RjMenuIcon1.TabStop = False
        '
        'RjMenuIcon2
        '
        Me.RjMenuIcon2.BackColor = System.Drawing.Color.Transparent
        Me.RjMenuIcon2.BackIcon = True
        Me.RjMenuIcon2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjMenuIcon2.Customizable = False
        Me.RjMenuIcon2.DropdownMenu = Nothing
        Me.RjMenuIcon2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjMenuIcon2.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.RjMenuIcon2.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjMenuIcon2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjMenuIcon2.IconSize = 25
        Me.RjMenuIcon2.Location = New System.Drawing.Point(397, 138)
        Me.RjMenuIcon2.Name = "RjMenuIcon2"
        Me.RjMenuIcon2.Size = New System.Drawing.Size(25, 25)
        Me.RjMenuIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RjMenuIcon2.TabIndex = 5
        Me.RjMenuIcon2.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.IndianRed
        Me.lblMessage.Location = New System.Drawing.Point(425, 231)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(75, 16)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Mensagem"
        Me.lblMessage.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.BorderRadius = 20
        Me.btnLogin.BorderSize = 2
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Design = PROJETOBASE.ButtonDesign.Normal
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnLogin.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogin.IconSize = 24
        Me.btnLogin.Location = New System.Drawing.Point(428, 267)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(250, 40)
        Me.btnLogin.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLogin.Style = PROJETOBASE.ControlStyle.Glass
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblForgotPass.LinkLabel = True
        Me.lblForgotPass.Location = New System.Drawing.Point(483, 320)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(126, 16)
        Me.lblForgotPass.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblForgotPass.TabIndex = 8
        Me.lblForgotPass.Text = "Esquceu a senha?"
        '
        'biFacebook
        '
        Me.biFacebook.BackColor = System.Drawing.Color.Transparent
        Me.biFacebook.BackIcon = True
        Me.biFacebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biFacebook.Customizable = False
        Me.biFacebook.DropdownMenu = Nothing
        Me.biFacebook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biFacebook.IconChar = FontAwesome.Sharp.IconChar.FacebookSquare
        Me.biFacebook.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biFacebook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biFacebook.IconSize = 25
        Me.biFacebook.Location = New System.Drawing.Point(679, 427)
        Me.biFacebook.Name = "biFacebook"
        Me.biFacebook.Size = New System.Drawing.Size(25, 25)
        Me.biFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biFacebook.TabIndex = 9
        Me.biFacebook.TabStop = False
        '
        'biGitHub
        '
        Me.biGitHub.BackColor = System.Drawing.Color.Transparent
        Me.biGitHub.BackIcon = True
        Me.biGitHub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biGitHub.Customizable = False
        Me.biGitHub.DropdownMenu = Nothing
        Me.biGitHub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biGitHub.IconChar = FontAwesome.Sharp.IconChar.Github
        Me.biGitHub.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biGitHub.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biGitHub.IconSize = 25
        Me.biGitHub.Location = New System.Drawing.Point(648, 427)
        Me.biGitHub.Name = "biGitHub"
        Me.biGitHub.Size = New System.Drawing.Size(25, 25)
        Me.biGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biGitHub.TabIndex = 10
        Me.biGitHub.TabStop = False
        '
        'biWebPage
        '
        Me.biWebPage.BackColor = System.Drawing.Color.Transparent
        Me.biWebPage.BackIcon = True
        Me.biWebPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biWebPage.Customizable = False
        Me.biWebPage.DropdownMenu = Nothing
        Me.biWebPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biWebPage.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.biWebPage.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biWebPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biWebPage.IconSize = 25
        Me.biWebPage.Location = New System.Drawing.Point(617, 427)
        Me.biWebPage.Name = "biWebPage"
        Me.biWebPage.Size = New System.Drawing.Size(25, 25)
        Me.biWebPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biWebPage.TabIndex = 11
        Me.biWebPage.TabStop = False
        '
        'biYoutube
        '
        Me.biYoutube.BackColor = System.Drawing.Color.Transparent
        Me.biYoutube.BackIcon = True
        Me.biYoutube.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biYoutube.Customizable = False
        Me.biYoutube.DropdownMenu = Nothing
        Me.biYoutube.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biYoutube.IconChar = FontAwesome.Sharp.IconChar.Youtube
        Me.biYoutube.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.biYoutube.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biYoutube.IconSize = 25
        Me.biYoutube.Location = New System.Drawing.Point(583, 427)
        Me.biYoutube.Name = "biYoutube"
        Me.biYoutube.Size = New System.Drawing.Size(25, 25)
        Me.biYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biYoutube.TabIndex = 12
        Me.biYoutube.TabStop = False
        '
        'RjDragControl1
        '
        Me.RjDragControl1.DragControl = Me.RjImageColorOverlay1
        '
        'RjDragControl2
        '
        Me.RjDragControl2.DragControl = Me
        '
        'LoginFormDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 470)
        Me.Controls.Add(Me.biYoutube)
        Me.Controls.Add(Me.biWebPage)
        Me.Controls.Add(Me.biGitHub)
        Me.Controls.Add(Me.biFacebook)
        Me.Controls.Add(Me.lblForgotPass)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.RjMenuIcon2)
        Me.Controls.Add(Me.RjMenuIcon1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.RjImageColorOverlay1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginFormDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.RjImageColorOverlay1.ResumeLayout(False)
        Me.RjImageColorOverlay1.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjMenuIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjMenuIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biFacebook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biGitHub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biWebPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biYoutube, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RjImageColorOverlay1 As PROJETOBASE.RJImageColorOverlay
    Friend WithEvents lblCaption As PROJETOBASE.RJLabel
    Friend WithEvents txtUser As PROJETOBASE.RJTextBox
    Friend WithEvents txtPassword As PROJETOBASE.RJTextBox
    Friend WithEvents RjMenuIcon1 As PROJETOBASE.RJMenuIcon
    Friend WithEvents RjMenuIcon2 As PROJETOBASE.RJMenuIcon
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnLogin As PROJETOBASE.RJButton
    Friend WithEvents lblForgotPass As PROJETOBASE.RJLabel
    Friend WithEvents biFacebook As PROJETOBASE.RJMenuIcon
    Friend WithEvents biGitHub As PROJETOBASE.RJMenuIcon
    Friend WithEvents biWebPage As PROJETOBASE.RJMenuIcon
    Friend WithEvents biYoutube As PROJETOBASE.RJMenuIcon
    Friend WithEvents RjDragControl1 As PROJETOBASE.RJDragControl
    Friend WithEvents RjDragControl2 As PROJETOBASE.RJDragControl
    Friend WithEvents RjRadioButton2 As PROJETOBASE.RJRadioButton
    Friend WithEvents RjRadioButton1 As PROJETOBASE.RJRadioButton
    Private WithEvents lblVersion As Label
    Private WithEvents lblDescription As Label
    Private WithEvents lblTitle As Label
    Private WithEvents pbLogo As PictureBox
    Private WithEvents lblWelcome As Label
End Class
