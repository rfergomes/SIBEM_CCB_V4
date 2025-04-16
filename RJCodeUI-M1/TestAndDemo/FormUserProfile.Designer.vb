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
        Me.components = New System.ComponentModel.Container()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.BtnRemoverFoto = New PROJETOBASE.RJButton()
        Me.BtnTrocarFoto = New PROJETOBASE.RJButton()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.TxtNome = New PROJETOBASE.RJTextBox()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.TxtEmail = New PROJETOBASE.RJTextBox()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.TxtConfirmaNovaSenha = New PROJETOBASE.RJTextBox()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.TxtNovaSenha = New PROJETOBASE.RJTextBox()
        Me.RjLabel10 = New PROJETOBASE.RJLabel()
        Me.TxtSenhaAtual = New PROJETOBASE.RJTextBox()
        Me.RjLabel11 = New PROJETOBASE.RJLabel()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.ImgFoto = New PROJETOBASE.RJCircularPictureBox()
        Me.TxtTelefone = New PROJETOBASE.RJTextBox()
        Me.TxtComum = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.TxtCidade = New PROJETOBASE.RJTextBox()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.TxtAdm = New PROJETOBASE.RJTextBox()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.PnlTipo = New PROJETOBASE.RJPanel()
        Me.LblTipo = New PROJETOBASE.RJLabel()
        Me.TxtId_Admlc = New PROJETOBASE.RJTextBox()
        Me.LblTipoBanco = New PROJETOBASE.RJLabel()
        Me.RjLabel12 = New PROJETOBASE.RJLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtId = New PROJETOBASE.RJTextBox()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTipo.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.TxtId)
        Me._pnlClientArea.Controls.Add(Me.RjLabel12)
        Me._pnlClientArea.Controls.Add(Me.LblTipoBanco)
        Me._pnlClientArea.Controls.Add(Me.TxtId_Admlc)
        Me._pnlClientArea.Controls.Add(Me.PnlTipo)
        Me._pnlClientArea.Controls.Add(Me.TxtTelefone)
        Me._pnlClientArea.Controls.Add(Me.ImgFoto)
        Me._pnlClientArea.Controls.Add(Me.BtnSalvar)
        Me._pnlClientArea.Controls.Add(Me.RjLabel11)
        Me._pnlClientArea.Controls.Add(Me.RjLabel8)
        Me._pnlClientArea.Controls.Add(Me.TxtConfirmaNovaSenha)
        Me._pnlClientArea.Controls.Add(Me.RjLabel9)
        Me._pnlClientArea.Controls.Add(Me.TxtNovaSenha)
        Me._pnlClientArea.Controls.Add(Me.RjLabel5)
        Me._pnlClientArea.Controls.Add(Me.RjLabel10)
        Me._pnlClientArea.Controls.Add(Me.TxtCidade)
        Me._pnlClientArea.Controls.Add(Me.TxtSenhaAtual)
        Me._pnlClientArea.Controls.Add(Me.RjLabel6)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.RjLabel7)
        Me._pnlClientArea.Controls.Add(Me.TxtAdm)
        Me._pnlClientArea.Controls.Add(Me.TxtComum)
        Me._pnlClientArea.Controls.Add(Me.TxtEmail)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.TxtNome)
        Me._pnlClientArea.Controls.Add(Me.BtnTrocarFoto)
        Me._pnlClientArea.Controls.Add(Me.BtnRemoverFoto)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 519)
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(412, 24)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(245, 26)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "Meu Perfil de Usuário"
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(40, 267)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(84, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 2
        Me.RjLabel2.Text = "Trocar Foto"
        '
        'BtnRemoverFoto
        '
        Me.BtnRemoverFoto.BackColor = System.Drawing.Color.Crimson
        Me.BtnRemoverFoto.BorderRadius = 0
        Me.BtnRemoverFoto.BorderSize = 1
        Me.BtnRemoverFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoverFoto.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnRemoverFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnRemoverFoto.FlatAppearance.BorderSize = 0
        Me.BtnRemoverFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnRemoverFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoverFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoverFoto.ForeColor = System.Drawing.Color.White
        Me.BtnRemoverFoto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.BtnRemoverFoto.IconColor = System.Drawing.Color.White
        Me.BtnRemoverFoto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRemoverFoto.IconSize = 15
        Me.BtnRemoverFoto.Location = New System.Drawing.Point(168, 267)
        Me.BtnRemoverFoto.Name = "BtnRemoverFoto"
        Me.BtnRemoverFoto.Size = New System.Drawing.Size(25, 25)
        Me.BtnRemoverFoto.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnRemoverFoto.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnRemoverFoto.TabIndex = 2
        Me.BtnRemoverFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRemoverFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemoverFoto.UseVisualStyleBackColor = False
        '
        'BtnTrocarFoto
        '
        Me.BtnTrocarFoto.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnTrocarFoto.BorderRadius = 0
        Me.BtnTrocarFoto.BorderSize = 1
        Me.BtnTrocarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTrocarFoto.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnTrocarFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnTrocarFoto.FlatAppearance.BorderSize = 0
        Me.BtnTrocarFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnTrocarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnTrocarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrocarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrocarFoto.ForeColor = System.Drawing.Color.White
        Me.BtnTrocarFoto.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.BtnTrocarFoto.IconColor = System.Drawing.Color.White
        Me.BtnTrocarFoto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTrocarFoto.IconSize = 15
        Me.BtnTrocarFoto.Location = New System.Drawing.Point(137, 267)
        Me.BtnTrocarFoto.Name = "BtnTrocarFoto"
        Me.BtnTrocarFoto.Size = New System.Drawing.Size(25, 25)
        Me.BtnTrocarFoto.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnTrocarFoto.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnTrocarFoto.TabIndex = 1
        Me.BtnTrocarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTrocarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTrocarFoto.UseVisualStyleBackColor = False
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(264, 82)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(43, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 8
        Me.RjLabel4.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome._Customizable = False
        Me.TxtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtNome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNome.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtNome.BorderRadius = 10
        Me.TxtNome.BorderSize = 2
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNome.Location = New System.Drawing.Point(267, 101)
        Me.TxtNome.MultiLine = False
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtNome.PasswordChar = False
        Me.TxtNome.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtNome.PlaceHolderText = Nothing
        Me.TxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtNome.Size = New System.Drawing.Size(250, 31)
        Me.TxtNome.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtNome.TabIndex = 3
        Me.TxtNome.Tag = "NOME"
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(264, 150)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(53, 16)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel7.TabIndex = 14
        Me.RjLabel7.Text = "E-mail:"
        '
        'TxtEmail
        '
        Me.TxtEmail._Customizable = False
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtEmail.BorderRadius = 10
        Me.TxtEmail.BorderSize = 2
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEmail.Location = New System.Drawing.Point(267, 169)
        Me.TxtEmail.MultiLine = False
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtEmail.PasswordChar = False
        Me.TxtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtEmail.PlaceHolderText = Nothing
        Me.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtEmail.Size = New System.Drawing.Size(250, 31)
        Me.TxtEmail.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtEmail.TabIndex = 5
        Me.TxtEmail.Tag = "E-MAIL"
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(570, 357)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(148, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel8.TabIndex = 20
        Me.RjLabel8.Text = "Confirma Nova Senha"
        '
        'TxtConfirmaNovaSenha
        '
        Me.TxtConfirmaNovaSenha._Customizable = False
        Me.TxtConfirmaNovaSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtConfirmaNovaSenha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtConfirmaNovaSenha.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtConfirmaNovaSenha.BorderRadius = 10
        Me.TxtConfirmaNovaSenha.BorderSize = 2
        Me.TxtConfirmaNovaSenha.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtConfirmaNovaSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtConfirmaNovaSenha.Location = New System.Drawing.Point(573, 376)
        Me.TxtConfirmaNovaSenha.MultiLine = False
        Me.TxtConfirmaNovaSenha.Name = "TxtConfirmaNovaSenha"
        Me.TxtConfirmaNovaSenha.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtConfirmaNovaSenha.PasswordChar = True
        Me.TxtConfirmaNovaSenha.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtConfirmaNovaSenha.PlaceHolderText = Nothing
        Me.TxtConfirmaNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtConfirmaNovaSenha.Size = New System.Drawing.Size(250, 31)
        Me.TxtConfirmaNovaSenha.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtConfirmaNovaSenha.TabIndex = 12
        Me.TxtConfirmaNovaSenha.Tag = "CONFIRMAR SENHA NOVA"
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(264, 357)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(86, 16)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel9.TabIndex = 18
        Me.RjLabel9.Text = "Nova Senha"
        '
        'TxtNovaSenha
        '
        Me.TxtNovaSenha._Customizable = False
        Me.TxtNovaSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtNovaSenha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNovaSenha.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtNovaSenha.BorderRadius = 10
        Me.TxtNovaSenha.BorderSize = 2
        Me.TxtNovaSenha.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtNovaSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNovaSenha.Location = New System.Drawing.Point(267, 376)
        Me.TxtNovaSenha.MultiLine = False
        Me.TxtNovaSenha.Name = "TxtNovaSenha"
        Me.TxtNovaSenha.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtNovaSenha.PasswordChar = True
        Me.TxtNovaSenha.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtNovaSenha.PlaceHolderText = Nothing
        Me.TxtNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtNovaSenha.Size = New System.Drawing.Size(250, 31)
        Me.TxtNovaSenha.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtNovaSenha.TabIndex = 11
        Me.TxtNovaSenha.Tag = "SENHA NOVA"
        '
        'RjLabel10
        '
        Me.RjLabel10.AutoSize = True
        Me.RjLabel10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel10.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel10.LinkLabel = False
        Me.RjLabel10.Location = New System.Drawing.Point(570, 289)
        Me.RjLabel10.Name = "RjLabel10"
        Me.RjLabel10.Size = New System.Drawing.Size(87, 16)
        Me.RjLabel10.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel10.TabIndex = 16
        Me.RjLabel10.Text = "Senha Atual"
        '
        'TxtSenhaAtual
        '
        Me.TxtSenhaAtual._Customizable = False
        Me.TxtSenhaAtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtSenhaAtual.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSenhaAtual.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtSenhaAtual.BorderRadius = 10
        Me.TxtSenhaAtual.BorderSize = 2
        Me.TxtSenhaAtual.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSenhaAtual.Location = New System.Drawing.Point(573, 308)
        Me.TxtSenhaAtual.MultiLine = False
        Me.TxtSenhaAtual.Name = "TxtSenhaAtual"
        Me.TxtSenhaAtual.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtSenhaAtual.PasswordChar = True
        Me.TxtSenhaAtual.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtSenhaAtual.PlaceHolderText = Nothing
        Me.TxtSenhaAtual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSenhaAtual.Size = New System.Drawing.Size(250, 31)
        Me.TxtSenhaAtual.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtSenhaAtual.TabIndex = 10
        Me.TxtSenhaAtual.Tag = "SENHA ATUAL"
        '
        'RjLabel11
        '
        Me.RjLabel11.AutoSize = True
        Me.RjLabel11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel11.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel11.LinkLabel = False
        Me.RjLabel11.Location = New System.Drawing.Point(570, 82)
        Me.RjLabel11.Name = "RjLabel11"
        Me.RjLabel11.Size = New System.Drawing.Size(63, 16)
        Me.RjLabel11.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel11.TabIndex = 21
        Me.RjLabel11.Text = "Telefone"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 10
        Me.BtnSalvar.BorderSize = 3
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSalvar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(438, 447)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(195, 40)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSalvar.TabIndex = 13
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'ImgFoto
        '
        Me.ImgFoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.ImgFoto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ImgFoto.BorderColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ImgFoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.ImgFoto.BorderSize = 2
        Me.ImgFoto.Customizable = True
        Me.ImgFoto.GradientAngle = 50.0!
        Me.ImgFoto.GradientColor = True
        Me.ImgFoto.Location = New System.Drawing.Point(43, 82)
        Me.ImgFoto.Name = "ImgFoto"
        Me.ImgFoto.Size = New System.Drawing.Size(169, 169)
        Me.ImgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFoto.TabIndex = 65
        Me.ImgFoto.TabStop = False
        '
        'TxtTelefone
        '
        Me.TxtTelefone._Customizable = False
        Me.TxtTelefone.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtTelefone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtTelefone.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtTelefone.BorderRadius = 10
        Me.TxtTelefone.BorderSize = 2
        Me.TxtTelefone.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtTelefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtTelefone.Location = New System.Drawing.Point(573, 101)
        Me.TxtTelefone.MultiLine = False
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtTelefone.PasswordChar = False
        Me.TxtTelefone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtTelefone.PlaceHolderText = Nothing
        Me.TxtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTelefone.Size = New System.Drawing.Size(250, 31)
        Me.TxtTelefone.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtTelefone.TabIndex = 4
        Me.TxtTelefone.Tag = "TELEFONE"
        '
        'TxtComum
        '
        Me.TxtComum._Customizable = False
        Me.TxtComum.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtComum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtComum.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtComum.BorderRadius = 10
        Me.TxtComum.BorderSize = 2
        Me.TxtComum.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtComum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtComum.Location = New System.Drawing.Point(573, 169)
        Me.TxtComum.MultiLine = False
        Me.TxtComum.Name = "TxtComum"
        Me.TxtComum.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtComum.PasswordChar = False
        Me.TxtComum.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtComum.PlaceHolderText = Nothing
        Me.TxtComum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtComum.Size = New System.Drawing.Size(250, 31)
        Me.TxtComum.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtComum.TabIndex = 6
        Me.TxtComum.Tag = "COMUM CONGREGAÇÃO"
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(570, 150)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(145, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 14
        Me.RjLabel3.Text = "Comum Congregação"
        '
        'TxtCidade
        '
        Me.TxtCidade._Customizable = False
        Me.TxtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCidade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCidade.BorderRadius = 10
        Me.TxtCidade.BorderSize = 2
        Me.TxtCidade.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(267, 240)
        Me.TxtCidade.MultiLine = False
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCidade.PasswordChar = False
        Me.TxtCidade.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCidade.PlaceHolderText = Nothing
        Me.TxtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCidade.Size = New System.Drawing.Size(250, 31)
        Me.TxtCidade.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCidade.TabIndex = 7
        Me.TxtCidade.Tag = "CIDADE"
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(264, 221)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 16
        Me.RjLabel5.Text = "Cidade"
        '
        'TxtAdm
        '
        Me.TxtAdm._Customizable = False
        Me.TxtAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtAdm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtAdm.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtAdm.BorderRadius = 10
        Me.TxtAdm.BorderSize = 2
        Me.TxtAdm.Enabled = False
        Me.TxtAdm.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtAdm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtAdm.Location = New System.Drawing.Point(267, 308)
        Me.TxtAdm.MultiLine = False
        Me.TxtAdm.Name = "TxtAdm"
        Me.TxtAdm.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtAdm.PasswordChar = False
        Me.TxtAdm.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtAdm.PlaceHolderText = Nothing
        Me.TxtAdm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtAdm.Size = New System.Drawing.Size(250, 31)
        Me.TxtAdm.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtAdm.TabIndex = 9
        Me.TxtAdm.Tag = "ADMINISTRAÇÃO"
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(570, 221)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(134, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel6.TabIndex = 14
        Me.RjLabel6.Text = "Cód. Administração"
        '
        'PnlTipo
        '
        Me.PnlTipo.BackColor = System.Drawing.Color.Tan
        Me.PnlTipo.BorderRadius = 10
        Me.PnlTipo.Controls.Add(Me.LblTipo)
        Me.PnlTipo.Customizable = True
        Me.PnlTipo.Location = New System.Drawing.Point(11, 308)
        Me.PnlTipo.Name = "PnlTipo"
        Me.PnlTipo.Size = New System.Drawing.Size(250, 27)
        Me.PnlTipo.TabIndex = 67
        '
        'LblTipo
        '
        Me.LblTipo.BackColor = System.Drawing.Color.Transparent
        Me.LblTipo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTipo.LinkLabel = False
        Me.LblTipo.Location = New System.Drawing.Point(13, 4)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(223, 18)
        Me.LblTipo.Style = PROJETOBASE.LabelStyle.BarText
        Me.LblTipo.TabIndex = 68
        Me.LblTipo.Text = "Tipo"
        Me.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtId_Admlc
        '
        Me.TxtId_Admlc._Customizable = False
        Me.TxtId_Admlc.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtId_Admlc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtId_Admlc.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtId_Admlc.BorderRadius = 10
        Me.TxtId_Admlc.BorderSize = 2
        Me.TxtId_Admlc.Enabled = False
        Me.TxtId_Admlc.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtId_Admlc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtId_Admlc.Location = New System.Drawing.Point(573, 240)
        Me.TxtId_Admlc.MultiLine = False
        Me.TxtId_Admlc.Name = "TxtId_Admlc"
        Me.TxtId_Admlc.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtId_Admlc.PasswordChar = False
        Me.TxtId_Admlc.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtId_Admlc.PlaceHolderText = Nothing
        Me.TxtId_Admlc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtId_Admlc.Size = New System.Drawing.Size(250, 31)
        Me.TxtId_Admlc.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtId_Admlc.TabIndex = 8
        Me.TxtId_Admlc.Tag = "CÓDIGO DA ADMINISTRAÇÃO"
        '
        'LblTipoBanco
        '
        Me.LblTipoBanco.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoBanco.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblTipoBanco.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblTipoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblTipoBanco.LinkLabel = False
        Me.LblTipoBanco.Location = New System.Drawing.Point(130, 370)
        Me.LblTipoBanco.Name = "LblTipoBanco"
        Me.LblTipoBanco.Size = New System.Drawing.Size(100, 18)
        Me.LblTipoBanco.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblTipoBanco.TabIndex = 70
        Me.LblTipoBanco.Text = "Tipo"
        Me.LblTipoBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTipoBanco.Visible = False
        '
        'RjLabel12
        '
        Me.RjLabel12.AutoSize = True
        Me.RjLabel12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel12.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel12.LinkLabel = False
        Me.RjLabel12.Location = New System.Drawing.Point(264, 289)
        Me.RjLabel12.Name = "RjLabel12"
        Me.RjLabel12.Size = New System.Drawing.Size(99, 16)
        Me.RjLabel12.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel12.TabIndex = 71
        Me.RjLabel12.Text = "Administração"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TxtId
        '
        Me.TxtId._Customizable = False
        Me.TxtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtId.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtId.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtId.BorderRadius = 10
        Me.TxtId.BorderSize = 2
        Me.TxtId.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtId.Location = New System.Drawing.Point(37, 357)
        Me.TxtId.MultiLine = False
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtId.PasswordChar = False
        Me.TxtId.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtId.PlaceHolderText = Nothing
        Me.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtId.Size = New System.Drawing.Size(87, 31)
        Me.TxtId.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtId.TabIndex = 72
        Me.TxtId.Tag = "ID"
        Me.TxtId.Visible = False
        '
        'FormUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Perfil do Usuário"
        Me.ClientSize = New System.Drawing.Size(960, 561)
        Me.FormIcon = FontAwesome.Sharp.IconChar.User
        Me.Name = "FormUserProfile"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Perfil do Usuário"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTipo.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnTrocarFoto As PROJETOBASE.RJButton
    Friend WithEvents BtnRemoverFoto As PROJETOBASE.RJButton
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
    Friend WithEvents BtnSalvar As PROJETOBASE.RJButton
    Friend WithEvents RjLabel11 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel8 As PROJETOBASE.RJLabel
    Friend WithEvents TxtConfirmaNovaSenha As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel9 As PROJETOBASE.RJLabel
    Friend WithEvents TxtNovaSenha As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel10 As PROJETOBASE.RJLabel
    Friend WithEvents TxtSenhaAtual As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel7 As PROJETOBASE.RJLabel
    Friend WithEvents TxtEmail As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel4 As PROJETOBASE.RJLabel
    Friend WithEvents TxtNome As PROJETOBASE.RJTextBox
    Friend WithEvents ImgFoto As RJCircularPictureBox
    Friend WithEvents TxtTelefone As RJTextBox
    Friend WithEvents RjLabel5 As RJLabel
    Friend WithEvents TxtCidade As RJTextBox
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents TxtAdm As RJTextBox
    Friend WithEvents TxtComum As RJTextBox
    Friend WithEvents PnlTipo As RJPanel
    Friend WithEvents LblTipo As RJLabel
    Friend WithEvents TxtId_Admlc As RJTextBox
    Friend WithEvents LblTipoBanco As RJLabel
    Friend WithEvents RjLabel12 As RJLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TxtId As RJTextBox
End Class
