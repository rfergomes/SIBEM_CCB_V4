<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventarioCelular
    Inherits RJChildForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventarioCelular))
        Me.BtnLocalizar = New PROJETOBASE.RJButton()
        Me.TxtArquivo = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.BtnLimpar = New PROJETOBASE.RJButton()
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.Card3 = New PROJETOBASE.RJPanel()
        Me.LblOutraCO = New PROJETOBASE.RJLabel()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.PicStatus = New PROJETOBASE.RJCircularPictureBox()
        Me.BtnImportar = New PROJETOBASE.RJButton()
        Me.Card4 = New PROJETOBASE.RJPanel()
        Me.LblErros = New PROJETOBASE.RJLabel()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.Card1 = New PROJETOBASE.RJPanel()
        Me.LblOK = New PROJETOBASE.RJLabel()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.Card2 = New PROJETOBASE.RJPanel()
        Me.LblRepetidos = New PROJETOBASE.RJLabel()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.CboColunas = New PROJETOBASE.RJComboBox()
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me.RjProgressBar1 = New PROJETOBASE.RJProgressBar()
        Me.LblTotalLista = New PROJETOBASE.RJLabel()
        Me.DgvDados = New PROJETOBASE.RJDataGridView()
        Me.RjPanel3 = New PROJETOBASE.RJPanel()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.LblInventario = New PROJETOBASE.RJLabel()
        Me.LblIgreja = New PROJETOBASE.RJLabel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.DpwMenuExportar = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.ToolStripMenuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuCelula = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuLinha = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuTudo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuTxt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        Me.Card3.SuspendLayout()
        CType(Me.PicStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Card4.SuspendLayout()
        Me.Card1.SuspendLayout()
        Me.Card2.SuspendLayout()
        Me.RjPanel2.SuspendLayout()
        CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RjPanel3.SuspendLayout()
        Me.DpwMenuExportar.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.LblIgreja)
        Me._pnlClientArea.Controls.Add(Me.LblInventario)
        Me._pnlClientArea.Controls.Add(Me.RjLabel5)
        Me._pnlClientArea.Controls.Add(Me.RjPanel3)
        Me._pnlClientArea.Controls.Add(Me.RjPanel2)
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(936, 495)
        '
        'BtnLocalizar
        '
        Me.BtnLocalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLocalizar.BorderRadius = 0
        Me.BtnLocalizar.BorderSize = 1
        Me.BtnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLocalizar.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnLocalizar.FlatAppearance.BorderSize = 0
        Me.BtnLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocalizar.ForeColor = System.Drawing.Color.White
        Me.BtnLocalizar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.BtnLocalizar.IconColor = System.Drawing.Color.White
        Me.BtnLocalizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLocalizar.IconSize = 24
        Me.BtnLocalizar.Location = New System.Drawing.Point(16, 23)
        Me.BtnLocalizar.Name = "BtnLocalizar"
        Me.BtnLocalizar.Size = New System.Drawing.Size(57, 31)
        Me.BtnLocalizar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLocalizar.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnLocalizar.TabIndex = 5
        Me.BtnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLocalizar.UseVisualStyleBackColor = False
        '
        'TxtArquivo
        '
        Me.TxtArquivo._Customizable = False
        Me.TxtArquivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtArquivo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtArquivo.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtArquivo.BorderRadius = 0
        Me.TxtArquivo.BorderSize = 2
        Me.TxtArquivo.Enabled = False
        Me.TxtArquivo.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtArquivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtArquivo.Location = New System.Drawing.Point(69, 23)
        Me.TxtArquivo.MultiLine = False
        Me.TxtArquivo.Name = "TxtArquivo"
        Me.TxtArquivo.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtArquivo.PasswordChar = False
        Me.TxtArquivo.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtArquivo.PlaceHolderText = Nothing
        Me.TxtArquivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtArquivo.Size = New System.Drawing.Size(771, 31)
        Me.TxtArquivo.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtArquivo.TabIndex = 4
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(13, 4)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(118, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 3
        Me.RjLabel1.Text = "Localizar Arquivo"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLimpar.BorderRadius = 0
        Me.BtnLimpar.BorderSize = 2
        Me.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnLimpar.FlatAppearance.BorderSize = 0
        Me.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLimpar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.BtnLimpar.IconColor = System.Drawing.Color.White
        Me.BtnLimpar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLimpar.IconSize = 24
        Me.BtnLimpar.Location = New System.Drawing.Point(840, 23)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(31, 31)
        Me.BtnLimpar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLimpar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnLimpar.TabIndex = 6
        Me.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.Card3)
        Me.RjPanel1.Controls.Add(Me.PicStatus)
        Me.RjPanel1.Controls.Add(Me.BtnImportar)
        Me.RjPanel1.Controls.Add(Me.Card4)
        Me.RjPanel1.Controls.Add(Me.Card1)
        Me.RjPanel1.Controls.Add(Me.Card2)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Controls.Add(Me.CboColunas)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Location = New System.Drawing.Point(26, 429)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(887, 55)
        Me.RjPanel1.TabIndex = 11
        '
        'Card3
        '
        Me.Card3.BackColor = System.Drawing.Color.White
        Me.Card3.BorderRadius = 10
        Me.Card3.Controls.Add(Me.LblOutraCO)
        Me.Card3.Controls.Add(Me.RjLabel8)
        Me.Card3.Customizable = True
        Me.Card3.Location = New System.Drawing.Point(663, 3)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(101, 49)
        Me.Card3.TabIndex = 5
        Me.Card3.Visible = False
        '
        'LblOutraCO
        '
        Me.LblOutraCO.BackColor = System.Drawing.Color.Transparent
        Me.LblOutraCO.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblOutraCO.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblOutraCO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblOutraCO.LinkLabel = False
        Me.LblOutraCO.Location = New System.Drawing.Point(0, 20)
        Me.LblOutraCO.Name = "LblOutraCO"
        Me.LblOutraCO.Size = New System.Drawing.Size(101, 26)
        Me.LblOutraCO.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblOutraCO.TabIndex = 6
        Me.LblOutraCO.Text = "0"
        Me.LblOutraCO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(7, 4)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(86, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel8.TabIndex = 5
        Me.RjLabel8.Text = "OUTRA C.O."
        '
        'PicStatus
        '
        Me.PicStatus.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round
        Me.PicStatus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.PicStatus.BorderColor2 = System.Drawing.Color.HotPink
        Me.PicStatus.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.PicStatus.BorderSize = 0
        Me.PicStatus.Customizable = True
        Me.PicStatus.GradientAngle = 50.0!
        Me.PicStatus.GradientColor = False
        Me.PicStatus.Location = New System.Drawing.Point(258, 1)
        Me.PicStatus.Name = "PicStatus"
        Me.PicStatus.Size = New System.Drawing.Size(53, 53)
        Me.PicStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStatus.TabIndex = 4
        Me.PicStatus.TabStop = False
        '
        'BtnImportar
        '
        Me.BtnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnImportar.BorderRadius = 0
        Me.BtnImportar.BorderSize = 1
        Me.BtnImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImportar.Design = PROJETOBASE.ButtonDesign.Normal
        Me.BtnImportar.FlatAppearance.BorderSize = 0
        Me.BtnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.ForeColor = System.Drawing.Color.White
        Me.BtnImportar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnImportar.IconColor = System.Drawing.Color.White
        Me.BtnImportar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnImportar.IconSize = 24
        Me.BtnImportar.Location = New System.Drawing.Point(326, 6)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(95, 43)
        Me.BtnImportar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnImportar.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnImportar.TabIndex = 3
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.UseVisualStyleBackColor = False
        Me.BtnImportar.Visible = False
        '
        'Card4
        '
        Me.Card4.BackColor = System.Drawing.Color.White
        Me.Card4.BorderRadius = 10
        Me.Card4.Controls.Add(Me.LblErros)
        Me.Card4.Controls.Add(Me.RjLabel6)
        Me.Card4.Customizable = True
        Me.Card4.Location = New System.Drawing.Point(776, 3)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(101, 49)
        Me.Card4.TabIndex = 2
        Me.Card4.Visible = False
        '
        'LblErros
        '
        Me.LblErros.BackColor = System.Drawing.Color.Transparent
        Me.LblErros.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblErros.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblErros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblErros.LinkLabel = False
        Me.LblErros.Location = New System.Drawing.Point(0, 20)
        Me.LblErros.Name = "LblErros"
        Me.LblErros.Size = New System.Drawing.Size(101, 26)
        Me.LblErros.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblErros.TabIndex = 6
        Me.LblErros.Text = "0"
        Me.LblErros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(25, 4)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(50, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel6.TabIndex = 5
        Me.RjLabel6.Text = "ERROS"
        '
        'Card1
        '
        Me.Card1.BackColor = System.Drawing.Color.White
        Me.Card1.BorderRadius = 10
        Me.Card1.Controls.Add(Me.LblOK)
        Me.Card1.Controls.Add(Me.RjLabel3)
        Me.Card1.Customizable = True
        Me.Card1.Location = New System.Drawing.Point(437, 3)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(101, 49)
        Me.Card1.TabIndex = 2
        Me.Card1.Visible = False
        '
        'LblOK
        '
        Me.LblOK.BackColor = System.Drawing.Color.Transparent
        Me.LblOK.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblOK.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblOK.LinkLabel = False
        Me.LblOK.Location = New System.Drawing.Point(3, 20)
        Me.LblOK.Name = "LblOK"
        Me.LblOK.Size = New System.Drawing.Size(94, 23)
        Me.LblOK.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblOK.TabIndex = 4
        Me.LblOK.Text = "0"
        Me.LblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(3, 4)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(94, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 3
        Me.RjLabel3.Text = "IMPORTADOS"
        '
        'Card2
        '
        Me.Card2.BackColor = System.Drawing.Color.White
        Me.Card2.BorderRadius = 10
        Me.Card2.Controls.Add(Me.LblRepetidos)
        Me.Card2.Controls.Add(Me.RjLabel4)
        Me.Card2.Customizable = True
        Me.Card2.Location = New System.Drawing.Point(550, 3)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(101, 49)
        Me.Card2.TabIndex = 2
        Me.Card2.Visible = False
        '
        'LblRepetidos
        '
        Me.LblRepetidos.BackColor = System.Drawing.Color.Transparent
        Me.LblRepetidos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblRepetidos.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblRepetidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblRepetidos.LinkLabel = False
        Me.LblRepetidos.Location = New System.Drawing.Point(3, 20)
        Me.LblRepetidos.Name = "LblRepetidos"
        Me.LblRepetidos.Size = New System.Drawing.Size(95, 26)
        Me.LblRepetidos.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblRepetidos.TabIndex = 5
        Me.LblRepetidos.Text = "0"
        Me.LblRepetidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(10, 4)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(81, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 4
        Me.RjLabel4.Text = "REPETIDOS"
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(3, 1)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(227, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 1
        Me.RjLabel2.Text = "Selecione a Coluna para Importar"
        '
        'CboColunas
        '
        Me.CboColunas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboColunas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboColunas.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboColunas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboColunas.BorderRadius = 0
        Me.CboColunas.BorderSize = 1
        Me.CboColunas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboColunas.Customizable = False
        Me.CboColunas.DataSource = Nothing
        Me.CboColunas.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboColunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboColunas.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboColunas.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboColunas.Location = New System.Drawing.Point(4, 20)
        Me.CboColunas.Name = "CboColunas"
        Me.CboColunas.Padding = New System.Windows.Forms.Padding(2)
        Me.CboColunas.SelectedIndex = -1
        Me.CboColunas.SelectedItem = Nothing
        Me.CboColunas.SelectedValue = Nothing
        Me.CboColunas.Size = New System.Drawing.Size(226, 32)
        Me.CboColunas.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboColunas.TabIndex = 0
        Me.CboColunas.Texts = ""
        '
        'RjPanel2
        '
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel2.BorderRadius = 0
        Me.RjPanel2.Controls.Add(Me.RjProgressBar1)
        Me.RjPanel2.Controls.Add(Me.LblTotalLista)
        Me.RjPanel2.Controls.Add(Me.DgvDados)
        Me.RjPanel2.Customizable = False
        Me.RjPanel2.Location = New System.Drawing.Point(26, 139)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(887, 284)
        Me.RjPanel2.TabIndex = 12
        '
        'RjProgressBar1
        '
        Me.RjProgressBar1.ChannelColor = System.Drawing.Color.SteelBlue
        Me.RjProgressBar1.ChannelHeight = 6
        Me.RjProgressBar1.Customizable = True
        Me.RjProgressBar1.ForeBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar1.ForeColor = System.Drawing.Color.White
        Me.RjProgressBar1.Location = New System.Drawing.Point(3, 259)
        Me.RjProgressBar1.Name = "RjProgressBar1"
        Me.RjProgressBar1.ShowMaximun = False
        Me.RjProgressBar1.ShowValue = PROJETOBASE.TextPosition.Center
        Me.RjProgressBar1.Size = New System.Drawing.Size(669, 23)
        Me.RjProgressBar1.SliderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar1.SliderHeight = 6
        Me.RjProgressBar1.SymbolAfter = "%"
        Me.RjProgressBar1.SymbolBefore = "Processado "
        Me.RjProgressBar1.TabIndex = 13
        Me.RjProgressBar1.Visible = False
        '
        'LblTotalLista
        '
        Me.LblTotalLista.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblTotalLista.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblTotalLista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblTotalLista.LinkLabel = False
        Me.LblTotalLista.Location = New System.Drawing.Point(678, 259)
        Me.LblTotalLista.Name = "LblTotalLista"
        Me.LblTotalLista.Size = New System.Drawing.Size(206, 23)
        Me.LblTotalLista.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblTotalLista.TabIndex = 12
        Me.LblTotalLista.Text = "-"
        Me.LblTotalLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgvDados
        '
        Me.DgvDados.AllowUserToAddRows = False
        Me.DgvDados.AllowUserToDeleteRows = False
        Me.DgvDados.AllowUserToResizeRows = False
        Me.DgvDados.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvDados.AlternatingRowsColorApply = False
        Me.DgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvDados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DgvDados.BorderRadius = 0
        Me.DgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDados.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvDados.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDados.ColumnHeaderHeight = 40
        Me.DgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDados.ColumnHeadersHeight = 40
        Me.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvDados.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvDados.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvDados.Customizable = True
        Me.DgvDados.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DgvDados.EnableHeadersVisualStyles = False
        Me.DgvDados.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvDados.Location = New System.Drawing.Point(4, 3)
        Me.DgvDados.Name = "DgvDados"
        Me.DgvDados.ReadOnly = True
        Me.DgvDados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvDados.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OldLace
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDados.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDados.RowHeadersVisible = False
        Me.DgvDados.RowHeadersWidth = 25
        Me.DgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDados.RowHeight = 26
        Me.DgvDados.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OldLace
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray
        Me.DgvDados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDados.RowsTextColor = System.Drawing.Color.Gray
        Me.DgvDados.RowTemplate.Height = 26
        Me.DgvDados.SelectionBackColor = System.Drawing.Color.OldLace
        Me.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDados.SelectionTextColor = System.Drawing.Color.Gray
        Me.DgvDados.Size = New System.Drawing.Size(880, 253)
        Me.DgvDados.TabIndex = 11
        '
        'RjPanel3
        '
        Me.RjPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel3.BorderRadius = 0
        Me.RjPanel3.Controls.Add(Me.TxtArquivo)
        Me.RjPanel3.Controls.Add(Me.RjLabel1)
        Me.RjPanel3.Controls.Add(Me.BtnLocalizar)
        Me.RjPanel3.Controls.Add(Me.BtnLimpar)
        Me.RjPanel3.Customizable = False
        Me.RjPanel3.Location = New System.Drawing.Point(26, 62)
        Me.RjPanel3.Name = "RjPanel3"
        Me.RjPanel3.Size = New System.Drawing.Size(887, 71)
        Me.RjPanel3.TabIndex = 13
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(96, 12)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(124, 18)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel5.TabIndex = 14
        Me.RjLabel5.Text = "INVENTÁRIO"
        Me.RjLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInventario
        '
        Me.LblInventario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInventario.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.LblInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblInventario.LinkLabel = False
        Me.LblInventario.Location = New System.Drawing.Point(109, 36)
        Me.LblInventario.Name = "LblInventario"
        Me.LblInventario.Size = New System.Drawing.Size(98, 18)
        Me.LblInventario.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblInventario.TabIndex = 15
        Me.LblInventario.Text = "0"
        Me.LblInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIgreja
        '
        Me.LblIgreja.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblIgreja.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.LblIgreja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblIgreja.LinkLabel = False
        Me.LblIgreja.Location = New System.Drawing.Point(240, 0)
        Me.LblIgreja.Name = "LblIgreja"
        Me.LblIgreja.Size = New System.Drawing.Size(673, 56)
        Me.LblIgreja.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblIgreja.TabIndex = 16
        Me.LblIgreja.Text = "Casa de Oração"
        Me.LblIgreja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.Transparent
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 0
        Me.RjButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjButton1.Design = PROJETOBASE.ButtonDesign.Custom
        Me.RjButton1.Enabled = False
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.IconChar = FontAwesome.Sharp.IconChar.MobileRetro
        Me.RjButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton1.IconSize = 50
        Me.RjButton1.Location = New System.Drawing.Point(26, 3)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(48, 56)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Glass
        Me.RjButton1.TabIndex = 17
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'DpwMenuExportar
        '
        Me.DpwMenuExportar.ActiveMenuItem = False
        Me.DpwMenuExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DpwMenuExportar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuCopiar, Me.ToolStripMenuTxt, Me.ToolStripMenuExcel, Me.ToolStripMenuPdf})
        Me.DpwMenuExportar.Name = "DpwMenuExportar"
        Me.DpwMenuExportar.OwnerIsMenuButton = False
        Me.DpwMenuExportar.Size = New System.Drawing.Size(199, 92)
        '
        'ToolStripMenuCopiar
        '
        Me.ToolStripMenuCopiar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuCelula, Me.ToolStripMenuLinha, Me.ToolStripMenuTudo})
        Me.ToolStripMenuCopiar.Image = CType(resources.GetObject("ToolStripMenuCopiar.Image"), System.Drawing.Image)
        Me.ToolStripMenuCopiar.Name = "ToolStripMenuCopiar"
        Me.ToolStripMenuCopiar.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuCopiar.Text = "Copiar"
        '
        'ToolStripMenuCelula
        '
        Me.ToolStripMenuCelula.Image = CType(resources.GetObject("ToolStripMenuCelula.Image"), System.Drawing.Image)
        Me.ToolStripMenuCelula.Name = "ToolStripMenuCelula"
        Me.ToolStripMenuCelula.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuCelula.Text = "Celula"
        '
        'ToolStripMenuLinha
        '
        Me.ToolStripMenuLinha.Image = CType(resources.GetObject("ToolStripMenuLinha.Image"), System.Drawing.Image)
        Me.ToolStripMenuLinha.Name = "ToolStripMenuLinha"
        Me.ToolStripMenuLinha.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuLinha.Text = "Linha"
        '
        'ToolStripMenuTudo
        '
        Me.ToolStripMenuTudo.Image = CType(resources.GetObject("ToolStripMenuTudo.Image"), System.Drawing.Image)
        Me.ToolStripMenuTudo.Name = "ToolStripMenuTudo"
        Me.ToolStripMenuTudo.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuTudo.Text = "Tudo"
        '
        'ToolStripMenuTxt
        '
        Me.ToolStripMenuTxt.Image = CType(resources.GetObject("ToolStripMenuTxt.Image"), System.Drawing.Image)
        Me.ToolStripMenuTxt.Name = "ToolStripMenuTxt"
        Me.ToolStripMenuTxt.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuTxt.Text = "Exportar para TXT"
        '
        'ToolStripMenuExcel
        '
        Me.ToolStripMenuExcel.Image = CType(resources.GetObject("ToolStripMenuExcel.Image"), System.Drawing.Image)
        Me.ToolStripMenuExcel.Name = "ToolStripMenuExcel"
        Me.ToolStripMenuExcel.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuExcel.Text = "Exportat para Excel"
        '
        'ToolStripMenuPdf
        '
        Me.ToolStripMenuPdf.Image = CType(resources.GetObject("ToolStripMenuPdf.Image"), System.Drawing.Image)
        Me.ToolStripMenuPdf.Name = "ToolStripMenuPdf"
        Me.ToolStripMenuPdf.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuPdf.Text = "Exportar para PDF"
        '
        'FormInventarioCelular
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "importar "
        Me.ClientSize = New System.Drawing.Size(938, 537)
        Me.Name = "FormInventarioCelular"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "importar "
        Me.Controls.SetChildIndex(Me._pnlClientArea, 0)
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        Me.Card3.ResumeLayout(False)
        Me.Card3.PerformLayout()
        CType(Me.PicStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Card4.ResumeLayout(False)
        Me.Card4.PerformLayout()
        Me.Card1.ResumeLayout(False)
        Me.Card1.PerformLayout()
        Me.Card2.ResumeLayout(False)
        Me.Card2.PerformLayout()
        Me.RjPanel2.ResumeLayout(False)
        CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RjPanel3.ResumeLayout(False)
        Me.RjPanel3.PerformLayout()
        Me.DpwMenuExportar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLocalizar As RJButton
    Friend WithEvents TxtArquivo As RJTextBox
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents BtnLimpar As RJButton
    Friend WithEvents RjPanel2 As RJPanel
    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents DgvDados As RJDataGridView
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents CboColunas As RJComboBox
    Friend WithEvents LblTotalLista As RJLabel
    Friend WithEvents Card4 As RJPanel
    Friend WithEvents Card2 As RJPanel
    Friend WithEvents Card1 As RJPanel
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents RjProgressBar1 As RJProgressBar
    Friend WithEvents BtnImportar As RJButton
    Friend WithEvents RjPanel3 As RJPanel
    Friend WithEvents LblInventario As RJLabel
    Friend WithEvents RjLabel5 As RJLabel
    Friend WithEvents LblIgreja As RJLabel
    Friend WithEvents PicStatus As RJCircularPictureBox
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents LblErros As RJLabel
    Friend WithEvents LblOK As RJLabel
    Friend WithEvents LblRepetidos As RJLabel
    Friend WithEvents Card3 As RJPanel
    Friend WithEvents LblOutraCO As RJLabel
    Friend WithEvents RjLabel8 As RJLabel
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents DpwMenuExportar As RJDropdownMenu
    Friend WithEvents ToolStripMenuTxt As ToolStripMenuItem
    Friend WithEvents ToolStripMenuExcel As ToolStripMenuItem
    Friend WithEvents ToolStripMenuPdf As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCopiar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCelula As ToolStripMenuItem
    Friend WithEvents ToolStripMenuLinha As ToolStripMenuItem
    Friend WithEvents ToolStripMenuTudo As ToolStripMenuItem
End Class
