<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormToken
    Inherits RJChildForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormToken))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelTeste = New PROJETOBASE.RJLabel()
        Me.RjProgressBar1 = New PROJETOBASE.RJProgressBar()
        Me.BtnSair = New PROJETOBASE.RJButton()
        Me.BtnSolicitarToken = New PROJETOBASE.RJButton()
        Me.BtnValidar = New PROJETOBASE.RJButton()
        Me.TxtToken = New PROJETOBASE.RJTextBox()
        Me.LblMensagem = New PROJETOBASE.RJLabel()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnCancelar = New PROJETOBASE.RJButton()
        Me.BtnSolicitar = New PROJETOBASE.RJButton()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.TxtSetor = New PROJETOBASE.RJTextBox()
        Me.TxtCidade = New PROJETOBASE.RJTextBox()
        Me.TxtComun = New PROJETOBASE.RJTextBox()
        Me.TxtTelefone = New PROJETOBASE.RJTextBox()
        Me.TxtEmail = New PROJETOBASE.RJTextBox()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.TxtNome = New PROJETOBASE.RJTextBox()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.RjPictureBox1 = New PROJETOBASE.RJPictureBox()
        Me.RjPictureBox2 = New PROJETOBASE.RJPictureBox()
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me._pnlClientArea.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RjPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Controls.Add(Me.TabControl1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(738, 263)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Location = New System.Drawing.Point(254, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(484, 263)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.LabelTeste)
        Me.TabPage1.Controls.Add(Me.RjProgressBar1)
        Me.TabPage1.Controls.Add(Me.BtnSair)
        Me.TabPage1.Controls.Add(Me.BtnSolicitarToken)
        Me.TabPage1.Controls.Add(Me.BtnValidar)
        Me.TabPage1.Controls.Add(Me.TxtToken)
        Me.TabPage1.Controls.Add(Me.LblMensagem)
        Me.TabPage1.Controls.Add(Me.RjLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(476, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Validar Token"
        '
        'LabelTeste
        '
        Me.LabelTeste.AutoSize = True
        Me.LabelTeste.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LabelTeste.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LabelTeste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LabelTeste.LinkLabel = False
        Me.LabelTeste.Location = New System.Drawing.Point(6, 193)
        Me.LabelTeste.Name = "LabelTeste"
        Me.LabelTeste.Size = New System.Drawing.Size(0, 16)
        Me.LabelTeste.Style = PROJETOBASE.LabelStyle.Normal
        Me.LabelTeste.TabIndex = 11
        Me.LabelTeste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjProgressBar1
        '
        Me.RjProgressBar1.ChannelColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar1.ChannelHeight = 6
        Me.RjProgressBar1.Customizable = True
        Me.RjProgressBar1.ForeBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar1.ForeColor = System.Drawing.Color.White
        Me.RjProgressBar1.Location = New System.Drawing.Point(16, 129)
        Me.RjProgressBar1.Name = "RjProgressBar1"
        Me.RjProgressBar1.ShowMaximun = True
        Me.RjProgressBar1.ShowValue = PROJETOBASE.TextPosition.Center
        Me.RjProgressBar1.Size = New System.Drawing.Size(445, 38)
        Me.RjProgressBar1.SliderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RjProgressBar1.SliderHeight = 6
        Me.RjProgressBar1.SymbolAfter = "%"
        Me.RjProgressBar1.SymbolBefore = ""
        Me.RjProgressBar1.TabIndex = 10
        Me.RjProgressBar1.Visible = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Transparent
        Me.BtnSair.BorderRadius = 5
        Me.BtnSair.BorderSize = 1
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSair.FlatAppearance.BorderSize = 0
        Me.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.BtnSair.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSair.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSair.IconSize = 24
        Me.BtnSair.Location = New System.Drawing.Point(366, 186)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(95, 30)
        Me.BtnSair.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSair.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSair.TabIndex = 9
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnSolicitarToken
        '
        Me.BtnSolicitarToken.BackColor = System.Drawing.Color.Transparent
        Me.BtnSolicitarToken.BorderRadius = 5
        Me.BtnSolicitarToken.BorderSize = 1
        Me.BtnSolicitarToken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSolicitarToken.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSolicitarToken.FlatAppearance.BorderSize = 0
        Me.BtnSolicitarToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnSolicitarToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSolicitarToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSolicitarToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSolicitarToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSolicitarToken.IconChar = FontAwesome.Sharp.IconChar.Bullhorn
        Me.BtnSolicitarToken.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSolicitarToken.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSolicitarToken.IconSize = 24
        Me.BtnSolicitarToken.Location = New System.Drawing.Point(228, 186)
        Me.BtnSolicitarToken.Name = "BtnSolicitarToken"
        Me.BtnSolicitarToken.Size = New System.Drawing.Size(132, 30)
        Me.BtnSolicitarToken.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSolicitarToken.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSolicitarToken.TabIndex = 9
        Me.BtnSolicitarToken.Text = "Solicitar Token"
        Me.BtnSolicitarToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSolicitarToken.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSolicitarToken.UseVisualStyleBackColor = False
        '
        'BtnValidar
        '
        Me.BtnValidar.BackColor = System.Drawing.Color.Transparent
        Me.BtnValidar.BorderRadius = 5
        Me.BtnValidar.BorderSize = 1
        Me.BtnValidar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnValidar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnValidar.Enabled = False
        Me.BtnValidar.FlatAppearance.BorderSize = 0
        Me.BtnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnValidar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.BtnValidar.IconColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnValidar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnValidar.IconSize = 24
        Me.BtnValidar.Location = New System.Drawing.Point(127, 186)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(95, 30)
        Me.BtnValidar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnValidar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnValidar.TabIndex = 8
        Me.BtnValidar.Text = "Validar"
        Me.BtnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnValidar.UseVisualStyleBackColor = False
        '
        'TxtToken
        '
        Me.TxtToken._Customizable = False
        Me.TxtToken.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtToken.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtToken.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtToken.BorderRadius = 0
        Me.TxtToken.BorderSize = 2
        Me.TxtToken.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.TxtToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtToken.Location = New System.Drawing.Point(16, 129)
        Me.TxtToken.MaxLength = 64
        Me.TxtToken.MultiLine = False
        Me.TxtToken.Name = "TxtToken"
        Me.TxtToken.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtToken.PasswordChar = False
        Me.TxtToken.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtToken.PlaceHolderText = "Digite seu token"
        Me.TxtToken.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtToken.Size = New System.Drawing.Size(445, 38)
        Me.TxtToken.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtToken.TabIndex = 0
        '
        'LblMensagem
        '
        Me.LblMensagem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensagem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblMensagem.LinkLabel = False
        Me.LblMensagem.Location = New System.Drawing.Point(6, 32)
        Me.LblMensagem.Name = "LblMensagem"
        Me.LblMensagem.Size = New System.Drawing.Size(464, 94)
        Me.LblMensagem.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblMensagem.TabIndex = 6
        Me.LblMensagem.Text = resources.GetString("LblMensagem.Text")
        Me.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RjLabel1
        '
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(6, 3)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(464, 29)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel1.TabIndex = 5
        Me.RjLabel1.Text = "VALIDAR TOKEN"
        Me.RjLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnSolicitar)
        Me.TabPage2.Controls.Add(Me.RjLabel4)
        Me.TabPage2.Controls.Add(Me.TxtSetor)
        Me.TabPage2.Controls.Add(Me.TxtCidade)
        Me.TabPage2.Controls.Add(Me.TxtComun)
        Me.TabPage2.Controls.Add(Me.TxtTelefone)
        Me.TabPage2.Controls.Add(Me.TxtEmail)
        Me.TabPage2.Controls.Add(Me.RjLabel9)
        Me.TabPage2.Controls.Add(Me.TxtNome)
        Me.TabPage2.Controls.Add(Me.RjLabel8)
        Me.TabPage2.Controls.Add(Me.RjLabel7)
        Me.TabPage2.Controls.Add(Me.RjLabel5)
        Me.TabPage2.Controls.Add(Me.RjLabel6)
        Me.TabPage2.Controls.Add(Me.RjLabel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(476, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Solicitar Token"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.BorderRadius = 5
        Me.BtnCancelar.BorderSize = 1
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Design = PROJETOBASE.ButtonDesign.Cancel
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtnCancelar.IconColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCancelar.IconSize = 24
        Me.BtnCancelar.Location = New System.Drawing.Point(375, 177)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 30)
        Me.BtnCancelar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSolicitar
        '
        Me.BtnSolicitar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSolicitar.BorderRadius = 5
        Me.BtnSolicitar.BorderSize = 1
        Me.BtnSolicitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSolicitar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSolicitar.FlatAppearance.BorderSize = 0
        Me.BtnSolicitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnSolicitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSolicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSolicitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSolicitar.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.BtnSolicitar.IconColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSolicitar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSolicitar.IconSize = 24
        Me.BtnSolicitar.Location = New System.Drawing.Point(282, 177)
        Me.BtnSolicitar.Name = "BtnSolicitar"
        Me.BtnSolicitar.Size = New System.Drawing.Size(87, 30)
        Me.BtnSolicitar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSolicitar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSolicitar.TabIndex = 6
        Me.BtnSolicitar.Text = "Solicitar"
        Me.BtnSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSolicitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSolicitar.UseVisualStyleBackColor = False
        '
        'RjLabel4
        '
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(3, 0)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(470, 29)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel4.TabIndex = 6
        Me.RjLabel4.Text = "SOLICITAR TOKEN"
        Me.RjLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSetor
        '
        Me.TxtSetor._Customizable = False
        Me.TxtSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtSetor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSetor.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtSetor.BorderRadius = 0
        Me.TxtSetor.BorderSize = 2
        Me.TxtSetor.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtSetor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSetor.Location = New System.Drawing.Point(203, 176)
        Me.TxtSetor.MultiLine = False
        Me.TxtSetor.Name = "TxtSetor"
        Me.TxtSetor.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtSetor.PasswordChar = False
        Me.TxtSetor.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtSetor.PlaceHolderText = Nothing
        Me.TxtSetor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSetor.Size = New System.Drawing.Size(73, 31)
        Me.TxtSetor.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtSetor.TabIndex = 5
        Me.TxtSetor.Tag = "Setor"
        '
        'TxtCidade
        '
        Me.TxtCidade._Customizable = False
        Me.TxtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCidade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCidade.BorderRadius = 0
        Me.TxtCidade.BorderSize = 2
        Me.TxtCidade.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(6, 176)
        Me.TxtCidade.MultiLine = False
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCidade.PasswordChar = False
        Me.TxtCidade.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCidade.PlaceHolderText = "Digite sua Cidade"
        Me.TxtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCidade.Size = New System.Drawing.Size(191, 31)
        Me.TxtCidade.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCidade.TabIndex = 4
        Me.TxtCidade.Tag = "Cidade"
        '
        'TxtComun
        '
        Me.TxtComun._Customizable = False
        Me.TxtComun.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtComun.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtComun.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtComun.BorderRadius = 0
        Me.TxtComun.BorderSize = 2
        Me.TxtComun.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtComun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtComun.Location = New System.Drawing.Point(282, 118)
        Me.TxtComun.MultiLine = False
        Me.TxtComun.Name = "TxtComun"
        Me.TxtComun.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtComun.PasswordChar = False
        Me.TxtComun.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtComun.PlaceHolderText = "Nome da sua Comum"
        Me.TxtComun.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtComun.Size = New System.Drawing.Size(188, 31)
        Me.TxtComun.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtComun.TabIndex = 3
        Me.TxtComun.Tag = "Comum"
        '
        'TxtTelefone
        '
        Me.TxtTelefone._Customizable = False
        Me.TxtTelefone.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtTelefone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtTelefone.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtTelefone.BorderRadius = 0
        Me.TxtTelefone.BorderSize = 2
        Me.TxtTelefone.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtTelefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtTelefone.Location = New System.Drawing.Point(282, 60)
        Me.TxtTelefone.MultiLine = False
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtTelefone.PasswordChar = False
        Me.TxtTelefone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtTelefone.PlaceHolderText = "(00) 0.0000-0000"
        Me.TxtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTelefone.Size = New System.Drawing.Size(188, 31)
        Me.TxtTelefone.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtTelefone.TabIndex = 1
        Me.TxtTelefone.Tag = "Telefone"
        '
        'TxtEmail
        '
        Me.TxtEmail._Customizable = False
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtEmail.BorderRadius = 0
        Me.TxtEmail.BorderSize = 2
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEmail.Location = New System.Drawing.Point(6, 118)
        Me.TxtEmail.MultiLine = False
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtEmail.PasswordChar = False
        Me.TxtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtEmail.PlaceHolderText = "Digite seu e-mail"
        Me.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtEmail.Size = New System.Drawing.Size(270, 31)
        Me.TxtEmail.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtEmail.TabIndex = 2
        Me.TxtEmail.Tag = "E-mail"
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(200, 157)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(43, 16)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel9.TabIndex = 7
        Me.RjLabel9.Text = "Setor"
        '
        'TxtNome
        '
        Me.TxtNome._Customizable = False
        Me.TxtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtNome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNome.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtNome.BorderRadius = 0
        Me.TxtNome.BorderSize = 2
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNome.Location = New System.Drawing.Point(6, 60)
        Me.TxtNome.MultiLine = False
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtNome.PasswordChar = False
        Me.TxtNome.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtNome.PlaceHolderText = "Digite seu nome Completo"
        Me.TxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtNome.Size = New System.Drawing.Size(270, 31)
        Me.TxtNome.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtNome.TabIndex = 0
        Me.TxtNome.Tag = "Nome"
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(3, 157)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel8.TabIndex = 7
        Me.RjLabel8.Text = "Cidade"
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(279, 99)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(145, 16)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel7.TabIndex = 7
        Me.RjLabel7.Text = "Comum Congregação"
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(279, 41)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(136, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 7
        Me.RjLabel5.Text = "Telefone/WhatsApp"
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(5, 99)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(47, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel6.TabIndex = 1
        Me.RjLabel6.Text = "E-mail"
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(5, 41)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(109, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 1
        Me.RjLabel3.Text = "Nome Completo"
        '
        'RjPictureBox1
        '
        Me.RjPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjPictureBox1.BorderRadius = 0
        Me.RjPictureBox1.BorderSize = 0
        Me.RjPictureBox1.Customizable = True
        Me.RjPictureBox1.Image = CType(resources.GetObject("RjPictureBox1.Image"), System.Drawing.Image)
        Me.RjPictureBox1.Location = New System.Drawing.Point(18, 30)
        Me.RjPictureBox1.Name = "RjPictureBox1"
        Me.RjPictureBox1.Size = New System.Drawing.Size(210, 78)
        Me.RjPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjPictureBox1.TabIndex = 10
        Me.RjPictureBox1.TabStop = False
        '
        'RjPictureBox2
        '
        Me.RjPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjPictureBox2.BorderRadius = 0
        Me.RjPictureBox2.BorderSize = 0
        Me.RjPictureBox2.Customizable = True
        Me.RjPictureBox2.Image = CType(resources.GetObject("RjPictureBox2.Image"), System.Drawing.Image)
        Me.RjPictureBox2.Location = New System.Drawing.Point(18, 143)
        Me.RjPictureBox2.Name = "RjPictureBox2"
        Me.RjPictureBox2.Size = New System.Drawing.Size(210, 89)
        Me.RjPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjPictureBox2.TabIndex = 10
        Me.RjPictureBox2.TabStop = False
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.RjPictureBox1)
        Me.RjPanel1.Controls.Add(Me.RjPictureBox2)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RjPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(246, 263)
        Me.RjPanel1.TabIndex = 11
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormToken
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.CancelButton = Me.btnClose
        Me.Caption = "Token"
        Me.ClientSize = New System.Drawing.Size(740, 305)
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.FormIcon = FontAwesome.Sharp.IconChar.Key
        Me.Name = "FormToken"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Resizable = False
        Me.Text = "Token"
        Me._pnlClientArea.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RjPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSolicitarToken As RJButton
    Friend WithEvents BtnValidar As RJButton
    Friend WithEvents TxtToken As RJTextBox
    Friend WithEvents LblMensagem As RJLabel
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnSair As RJButton
    Friend WithEvents RjPictureBox1 As RJPictureBox
    Friend WithEvents RjPictureBox2 As RJPictureBox
    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents TxtNome As RJTextBox
    Friend WithEvents RjLabel8 As RJLabel
    Friend WithEvents RjLabel7 As RJLabel
    Friend WithEvents RjLabel5 As RJLabel
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents TxtCidade As RJTextBox
    Friend WithEvents TxtComun As RJTextBox
    Friend WithEvents TxtTelefone As RJTextBox
    Friend WithEvents TxtEmail As RJTextBox
    Friend WithEvents BtnCancelar As RJButton
    Friend WithEvents BtnSolicitar As RJButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TxtSetor As RJTextBox
    Friend WithEvents RjLabel9 As RJLabel
    Friend WithEvents RjProgressBar1 As RJProgressBar
    Friend WithEvents LabelTeste As RJLabel
End Class
