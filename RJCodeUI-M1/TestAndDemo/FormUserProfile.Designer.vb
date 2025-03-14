<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserProfile
    Inherits PROJETOBASE.RJChildForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose( disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.RjButton2 = New PROJETOBASE.RJButton()
        Me.txtUsername = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.txtFirstName = New PROJETOBASE.RJTextBox()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.txtPhoneNumber = New PROJETOBASE.RJTextBox()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.txtEmail = New PROJETOBASE.RJTextBox()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.txtConfirmNewPassword = New PROJETOBASE.RJTextBox()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.txtNewPassword = New PROJETOBASE.RJTextBox()
        Me.RjLabel10 = New PROJETOBASE.RJLabel()
        Me.txtCurrentPassword = New PROJETOBASE.RJTextBox()
        Me.RjLabel11 = New PROJETOBASE.RJLabel()
        Me.dpBirthdate = New PROJETOBASE.RJDatePicker()
        Me.RjButton3 = New PROJETOBASE.RJButton()
        Me.pbPhoto = New PROJETOBASE.RJCircularPictureBox()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.pbPhoto)
        Me._pnlClientArea.Controls.Add(Me.RjButton3)
        Me._pnlClientArea.Controls.Add(Me.dpBirthdate)
        Me._pnlClientArea.Controls.Add(Me.RjLabel11)
        Me._pnlClientArea.Controls.Add(Me.RjLabel8)
        Me._pnlClientArea.Controls.Add(Me.txtConfirmNewPassword)
        Me._pnlClientArea.Controls.Add(Me.RjLabel9)
        Me._pnlClientArea.Controls.Add(Me.txtNewPassword)
        Me._pnlClientArea.Controls.Add(Me.RjLabel10)
        Me._pnlClientArea.Controls.Add(Me.txtCurrentPassword)
        Me._pnlClientArea.Controls.Add(Me.RjLabel7)
        Me._pnlClientArea.Controls.Add(Me.txtEmail)
        Me._pnlClientArea.Controls.Add(Me.RjLabel5)
        Me._pnlClientArea.Controls.Add(Me.txtPhoneNumber)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.txtFirstName)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.txtUsername)
        Me._pnlClientArea.Controls.Add(Me.RjButton2)
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(40, 34)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(183, 18)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "Meu Perfil de Usuário"
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(40, 267)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(84, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 2
        Me.RjLabel2.Text = "Trocar Foto"
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.Crimson
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 1
        Me.RjButton1.Design = PROJETOBASE.ButtonDesign.Custom
        Me.RjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.RjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.RjButton1.IconColor = System.Drawing.Color.White
        Me.RjButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton1.IconSize = 15
        Me.RjButton1.Location = New System.Drawing.Point(168, 267)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(25, 25)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 3
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'RjButton2
        '
        Me.RjButton2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.RjButton2.BorderRadius = 0
        Me.RjButton2.BorderSize = 1
        Me.RjButton2.Design = PROJETOBASE.ButtonDesign.Custom
        Me.RjButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton2.FlatAppearance.BorderSize = 0
        Me.RjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.RjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.RjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton2.ForeColor = System.Drawing.Color.White
        Me.RjButton2.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.RjButton2.IconColor = System.Drawing.Color.White
        Me.RjButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton2.IconSize = 15
        Me.RjButton2.Location = New System.Drawing.Point(137, 267)
        Me.RjButton2.Name = "RjButton2"
        Me.RjButton2.Size = New System.Drawing.Size(25, 25)
        Me.RjButton2.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton2.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton2.TabIndex = 4
        Me.RjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton2.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername._Customizable = False
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtUsername.BorderRadius = 10
        Me.txtUsername.BorderSize = 2
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(267, 101)
        Me.txtUsername.MultiLine = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtUsername.PasswordChar = False
        Me.txtUsername.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtUsername.PlaceHolderText = Nothing
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.Size = New System.Drawing.Size(250, 31)
        Me.txtUsername.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtUsername.TabIndex = 5
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(264, 82)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(55, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 6
        Me.RjLabel3.Text = "Usuário"
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(264, 156)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(43, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 8
        Me.RjLabel4.Text = "Nome"
        '
        'txtFirstName
        '
        Me.txtFirstName._Customizable = False
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtFirstName.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtFirstName.BorderRadius = 10
        Me.txtFirstName.BorderSize = 2
        Me.txtFirstName.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(267, 175)
        Me.txtFirstName.MultiLine = False
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtFirstName.PasswordChar = False
        Me.txtFirstName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtFirstName.PlaceHolderText = Nothing
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.Size = New System.Drawing.Size(250, 31)
        Me.txtFirstName.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtFirstName.TabIndex = 7
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(264, 233)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(63, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 12
        Me.RjLabel5.Text = "Telefone"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber._Customizable = False
        Me.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPhoneNumber.BorderRadius = 10
        Me.txtPhoneNumber.BorderSize = 2
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(267, 252)
        Me.txtPhoneNumber.MultiLine = False
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPhoneNumber.PasswordChar = False
        Me.txtPhoneNumber.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtPhoneNumber.PlaceHolderText = Nothing
        Me.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneNumber.Size = New System.Drawing.Size(250, 31)
        Me.txtPhoneNumber.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtPhoneNumber.TabIndex = 11
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(264, 303)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(53, 16)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel7.TabIndex = 14
        Me.RjLabel7.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail._Customizable = False
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtEmail.BorderRadius = 10
        Me.txtEmail.BorderSize = 2
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(267, 322)
        Me.txtEmail.MultiLine = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtEmail.PasswordChar = False
        Me.txtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtEmail.PlaceHolderText = Nothing
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.Size = New System.Drawing.Size(250, 31)
        Me.txtEmail.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtEmail.TabIndex = 13
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(571, 303)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(148, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel8.TabIndex = 20
        Me.RjLabel8.Text = "Confirma Nova Senha"
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword._Customizable = False
        Me.txtConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtConfirmNewPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtConfirmNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtConfirmNewPassword.BorderRadius = 10
        Me.txtConfirmNewPassword.BorderSize = 2
        Me.txtConfirmNewPassword.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtConfirmNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(574, 322)
        Me.txtConfirmNewPassword.MultiLine = False
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtConfirmNewPassword.PasswordChar = False
        Me.txtConfirmNewPassword.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtConfirmNewPassword.PlaceHolderText = Nothing
        Me.txtConfirmNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(250, 31)
        Me.txtConfirmNewPassword.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtConfirmNewPassword.TabIndex = 19
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(571, 229)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(86, 16)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel9.TabIndex = 18
        Me.RjLabel9.Text = "Nova Senha"
        '
        'txtNewPassword
        '
        Me.txtNewPassword._Customizable = False
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtNewPassword.BorderRadius = 10
        Me.txtNewPassword.BorderSize = 2
        Me.txtNewPassword.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(574, 248)
        Me.txtNewPassword.MultiLine = False
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtNewPassword.PasswordChar = False
        Me.txtNewPassword.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtNewPassword.PlaceHolderText = Nothing
        Me.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPassword.Size = New System.Drawing.Size(250, 31)
        Me.txtNewPassword.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtNewPassword.TabIndex = 17
        '
        'RjLabel10
        '
        Me.RjLabel10.AutoSize = True
        Me.RjLabel10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel10.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel10.LinkLabel = False
        Me.RjLabel10.Location = New System.Drawing.Point(570, 156)
        Me.RjLabel10.Name = "RjLabel10"
        Me.RjLabel10.Size = New System.Drawing.Size(87, 16)
        Me.RjLabel10.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel10.TabIndex = 16
        Me.RjLabel10.Text = "Senha Atual"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword._Customizable = False
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCurrentPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtCurrentPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtCurrentPassword.BorderRadius = 10
        Me.txtCurrentPassword.BorderSize = 2
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(573, 175)
        Me.txtCurrentPassword.MultiLine = False
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtCurrentPassword.PasswordChar = False
        Me.txtCurrentPassword.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtCurrentPassword.PlaceHolderText = Nothing
        Me.txtCurrentPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCurrentPassword.Size = New System.Drawing.Size(250, 31)
        Me.txtCurrentPassword.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtCurrentPassword.TabIndex = 15
        '
        'RjLabel11
        '
        Me.RjLabel11.AutoSize = True
        Me.RjLabel11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel11.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel11.LinkLabel = False
        Me.RjLabel11.Location = New System.Drawing.Point(570, 82)
        Me.RjLabel11.Name = "RjLabel11"
        Me.RjLabel11.Size = New System.Drawing.Size(136, 16)
        Me.RjLabel11.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel11.TabIndex = 21
        Me.RjLabel11.Text = "Data de Aniversário"
        '
        'dpBirthdate
        '
        Me.dpBirthdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dpBirthdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.dpBirthdate.BorderRadius = 10
        Me.dpBirthdate.BorderSize = 2
        Me.dpBirthdate.CustomFormat = "MMMM,dd,yyyy"
        Me.dpBirthdate.Customizable = False
        Me.dpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpBirthdate.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.dpBirthdate.Location = New System.Drawing.Point(574, 102)
        Me.dpBirthdate.MinimumSize = New System.Drawing.Size(120, 25)
        Me.dpBirthdate.Name = "dpBirthdate"
        Me.dpBirthdate.Padding = New System.Windows.Forms.Padding(3)
        Me.dpBirthdate.Size = New System.Drawing.Size(249, 32)
        Me.dpBirthdate.Style = PROJETOBASE.ControlStyle.Glass
        Me.dpBirthdate.TabIndex = 22
        Me.dpBirthdate.Value = New Date(2021, 3, 16, 19, 10, 3, 469)
        '
        'RjButton3
        '
        Me.RjButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RjButton3.BorderRadius = 10
        Me.RjButton3.BorderSize = 3
        Me.RjButton3.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.RjButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.RjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.RjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton3.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.RjButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton3.IconSize = 24
        Me.RjButton3.Location = New System.Drawing.Point(444, 413)
        Me.RjButton3.Name = "RjButton3"
        Me.RjButton3.Size = New System.Drawing.Size(195, 40)
        Me.RjButton3.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton3.Style = PROJETOBASE.ControlStyle.Glass
        Me.RjButton3.TabIndex = 23
        Me.RjButton3.Text = "Salvar"
        Me.RjButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton3.UseVisualStyleBackColor = False
        '
        'pbPhoto
        '
        Me.pbPhoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.pbPhoto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbPhoto.BorderColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbPhoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.pbPhoto.BorderSize = 2
        Me.pbPhoto.Customizable = True
        Me.pbPhoto.GradientAngle = 50.0!
        Me.pbPhoto.GradientColor = True
        Me.pbPhoto.Location = New System.Drawing.Point(43, 82)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(169, 169)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 65
        Me.pbPhoto.TabStop = False
        '
        'FormUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Dados do Usuário"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.User
        Me.Name = "FormUserProfile"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Dados do Usuário"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RjButton2 As PROJETOBASE.RJButton
    Friend WithEvents RjButton1 As PROJETOBASE.RJButton
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
    Friend WithEvents RjButton3 As PROJETOBASE.RJButton
    Friend WithEvents dpBirthdate As PROJETOBASE.RJDatePicker
    Friend WithEvents RjLabel11 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel8 As PROJETOBASE.RJLabel
    Friend WithEvents txtConfirmNewPassword As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel9 As PROJETOBASE.RJLabel
    Friend WithEvents txtNewPassword As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel10 As PROJETOBASE.RJLabel
    Friend WithEvents txtCurrentPassword As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel7 As PROJETOBASE.RJLabel
    Friend WithEvents txtEmail As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel5 As PROJETOBASE.RJLabel
    Friend WithEvents txtPhoneNumber As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel4 As PROJETOBASE.RJLabel
    Friend WithEvents txtFirstName As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel3 As PROJETOBASE.RJLabel
    Friend WithEvents txtUsername As PROJETOBASE.RJTextBox
    Friend WithEvents pbPhoto As RJCircularPictureBox
End Class
