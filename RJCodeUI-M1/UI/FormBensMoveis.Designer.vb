<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBensMoveis
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me.BtnLimpaFiltro = New PROJETOBASE.RJButton()
        Me.BtnImportar = New PROJETOBASE.RJButton()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.TxtDependencia = New PROJETOBASE.RJTextBox()
        Me.TxtBem = New PROJETOBASE.RJTextBox()
        Me.TxtIgreja = New PROJETOBASE.RJTextBox()
        Me.RjLabel28 = New PROJETOBASE.RJLabel()
        Me.CboSetor = New PROJETOBASE.RJComboBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarraProgresso = New PROJETOBASE.RJProgressBar()
        Me.DgvBensMoveis = New PROJETOBASE.RJDataGridView()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel2.SuspendLayout()
        CType(Me.DgvBensMoveis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.BarraProgresso)
        Me._pnlClientArea.Controls.Add(Me.RjPanel2)
        Me._pnlClientArea.Controls.Add(Me.lblNumberItems)
        Me._pnlClientArea.Controls.Add(Me.DgvBensMoveis)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjPanel2
        '
        Me.RjPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel2.BorderRadius = 10
        Me.RjPanel2.Controls.Add(Me.BtnLimpaFiltro)
        Me.RjPanel2.Controls.Add(Me.BtnImportar)
        Me.RjPanel2.Controls.Add(Me.RjLabel3)
        Me.RjPanel2.Controls.Add(Me.RjLabel1)
        Me.RjPanel2.Controls.Add(Me.TxtDependencia)
        Me.RjPanel2.Controls.Add(Me.TxtBem)
        Me.RjPanel2.Controls.Add(Me.TxtIgreja)
        Me.RjPanel2.Controls.Add(Me.RjLabel28)
        Me.RjPanel2.Controls.Add(Me.CboSetor)
        Me.RjPanel2.Controls.Add(Me.RjLabel2)
        Me.RjPanel2.Customizable = False
        Me.RjPanel2.Location = New System.Drawing.Point(14, 15)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(930, 65)
        Me.RjPanel2.TabIndex = 19
        '
        'BtnLimpaFiltro
        '
        Me.BtnLimpaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpaFiltro.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpaFiltro.BorderRadius = 8
        Me.BtnLimpaFiltro.BorderSize = 2
        Me.BtnLimpaFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpaFiltro.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnLimpaFiltro.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnLimpaFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnLimpaFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnLimpaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpaFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpaFiltro.ForeColor = System.Drawing.Color.White
        Me.BtnLimpaFiltro.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.BtnLimpaFiltro.IconColor = System.Drawing.Color.OrangeRed
        Me.BtnLimpaFiltro.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLimpaFiltro.IconSize = 24
        Me.BtnLimpaFiltro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLimpaFiltro.Location = New System.Drawing.Point(784, 25)
        Me.BtnLimpaFiltro.Name = "BtnLimpaFiltro"
        Me.BtnLimpaFiltro.Size = New System.Drawing.Size(18, 31)
        Me.BtnLimpaFiltro.SkinBorderColor = System.Drawing.Color.Transparent
        Me.BtnLimpaFiltro.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnLimpaFiltro.TabIndex = 38
        Me.BtnLimpaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpaFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpaFiltro.UseVisualStyleBackColor = False
        '
        'BtnImportar
        '
        Me.BtnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnImportar.BorderRadius = 15
        Me.BtnImportar.BorderSize = 1
        Me.BtnImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImportar.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnImportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnImportar.FlatAppearance.BorderSize = 0
        Me.BtnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.ForeColor = System.Drawing.Color.White
        Me.BtnImportar.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.BtnImportar.IconColor = System.Drawing.Color.White
        Me.BtnImportar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnImportar.IconSize = 24
        Me.BtnImportar.Location = New System.Drawing.Point(832, 5)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(90, 52)
        Me.BtnImportar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnImportar.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnImportar.TabIndex = 7
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnImportar.UseVisualStyleBackColor = False
        '
        'RjLabel3
        '
        Me.RjLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(605, 5)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(109, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 97
        Me.RjLabel3.Text = "DEPENDÊNCIA"
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(203, 5)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(125, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 97
        Me.RjLabel1.Text = "IGREJA/CÓDIGO"
        '
        'TxtDependencia
        '
        Me.TxtDependencia._Customizable = False
        Me.TxtDependencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDependencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtDependencia.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtDependencia.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtDependencia.BorderRadius = 10
        Me.TxtDependencia.BorderSize = 1
        Me.TxtDependencia.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtDependencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtDependencia.Location = New System.Drawing.Point(604, 24)
        Me.TxtDependencia.MultiLine = False
        Me.TxtDependencia.Name = "TxtDependencia"
        Me.TxtDependencia.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtDependencia.PasswordChar = False
        Me.TxtDependencia.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtDependencia.PlaceHolderText = ""
        Me.TxtDependencia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtDependencia.Size = New System.Drawing.Size(164, 31)
        Me.TxtDependencia.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtDependencia.TabIndex = 96
        '
        'TxtBem
        '
        Me.TxtBem._Customizable = False
        Me.TxtBem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBem.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtBem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBem.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtBem.BorderRadius = 10
        Me.TxtBem.BorderSize = 1
        Me.TxtBem.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtBem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBem.Location = New System.Drawing.Point(373, 24)
        Me.TxtBem.MultiLine = False
        Me.TxtBem.Name = "TxtBem"
        Me.TxtBem.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtBem.PasswordChar = False
        Me.TxtBem.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtBem.PlaceHolderText = ""
        Me.TxtBem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBem.Size = New System.Drawing.Size(224, 31)
        Me.TxtBem.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtBem.TabIndex = 96
        '
        'TxtIgreja
        '
        Me.TxtIgreja._Customizable = False
        Me.TxtIgreja.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtIgreja.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtIgreja.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtIgreja.BorderRadius = 10
        Me.TxtIgreja.BorderSize = 1
        Me.TxtIgreja.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtIgreja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtIgreja.Location = New System.Drawing.Point(202, 24)
        Me.TxtIgreja.MultiLine = False
        Me.TxtIgreja.Name = "TxtIgreja"
        Me.TxtIgreja.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtIgreja.PasswordChar = False
        Me.TxtIgreja.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtIgreja.PlaceHolderText = ""
        Me.TxtIgreja.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtIgreja.Size = New System.Drawing.Size(164, 31)
        Me.TxtIgreja.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtIgreja.TabIndex = 96
        '
        'RjLabel28
        '
        Me.RjLabel28.AutoSize = True
        Me.RjLabel28.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel28.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.RjLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel28.LinkLabel = False
        Me.RjLabel28.Location = New System.Drawing.Point(12, 5)
        Me.RjLabel28.Name = "RjLabel28"
        Me.RjLabel28.Size = New System.Drawing.Size(53, 16)
        Me.RjLabel28.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel28.TabIndex = 84
        Me.RjLabel28.Text = "SETOR"
        '
        'CboSetor
        '
        Me.CboSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboSetor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.BorderRadius = 10
        Me.CboSetor.BorderSize = 1
        Me.CboSetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboSetor.Customizable = False
        Me.CboSetor.DataSource = Nothing
        Me.CboSetor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboSetor.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.Location = New System.Drawing.Point(11, 24)
        Me.CboSetor.Name = "CboSetor"
        Me.CboSetor.Padding = New System.Windows.Forms.Padding(2)
        Me.CboSetor.SelectedIndex = -1
        Me.CboSetor.SelectedItem = Nothing
        Me.CboSetor.SelectedValue = Nothing
        Me.CboSetor.Size = New System.Drawing.Size(185, 32)
        Me.CboSetor.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboSetor.TabIndex = 83
        Me.CboSetor.Texts = ""
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(374, 5)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(38, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 97
        Me.RjLabel2.Text = "BEM"
        '
        'lblNumberItems
        '
        Me.lblNumberItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberItems.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNumberItems.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblNumberItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblNumberItems.LinkLabel = False
        Me.lblNumberItems.Location = New System.Drawing.Point(762, 495)
        Me.lblNumberItems.Name = "lblNumberItems"
        Me.lblNumberItems.Size = New System.Drawing.Size(174, 14)
        Me.lblNumberItems.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblNumberItems.TabIndex = 30
        Me.lblNumberItems.Text = "0"
        Me.lblNumberItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BarraProgresso
        '
        Me.BarraProgresso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarraProgresso.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BarraProgresso.ChannelColor = System.Drawing.Color.LightSteelBlue
        Me.BarraProgresso.ChannelHeight = 20
        Me.BarraProgresso.Customizable = True
        Me.BarraProgresso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgresso.ForeBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BarraProgresso.ForeColor = System.Drawing.Color.White
        Me.BarraProgresso.Location = New System.Drawing.Point(15, 240)
        Me.BarraProgresso.Name = "BarraProgresso"
        Me.BarraProgresso.ShowMaximun = False
        Me.BarraProgresso.ShowValue = PROJETOBASE.TextPosition.Center
        Me.BarraProgresso.Size = New System.Drawing.Size(929, 39)
        Me.BarraProgresso.SliderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BarraProgresso.SliderHeight = 20
        Me.BarraProgresso.SymbolAfter = "%"
        Me.BarraProgresso.SymbolBefore = ""
        Me.BarraProgresso.TabIndex = 72
        Me.BarraProgresso.Value = 80
        Me.BarraProgresso.Visible = False
        '
        'DgvBensMoveis
        '
        Me.DgvBensMoveis.AllowUserToAddRows = False
        Me.DgvBensMoveis.AllowUserToResizeRows = False
        Me.DgvBensMoveis.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvBensMoveis.AlternatingRowsColorApply = False
        Me.DgvBensMoveis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBensMoveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBensMoveis.BackgroundColor = System.Drawing.Color.White
        Me.DgvBensMoveis.BorderRadius = 10
        Me.DgvBensMoveis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvBensMoveis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvBensMoveis.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvBensMoveis.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvBensMoveis.ColumnHeaderHeight = 40
        Me.DgvBensMoveis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBensMoveis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBensMoveis.ColumnHeadersHeight = 40
        Me.DgvBensMoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvBensMoveis.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvBensMoveis.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBensMoveis.Customizable = True
        Me.DgvBensMoveis.DgvBackColor = System.Drawing.Color.White
        Me.DgvBensMoveis.EnableHeadersVisualStyles = False
        Me.DgvBensMoveis.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvBensMoveis.Location = New System.Drawing.Point(14, 97)
        Me.DgvBensMoveis.MultiSelect = False
        Me.DgvBensMoveis.Name = "DgvBensMoveis"
        Me.DgvBensMoveis.ReadOnly = True
        Me.DgvBensMoveis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvBensMoveis.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBensMoveis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBensMoveis.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBensMoveis.RowHeadersVisible = False
        Me.DgvBensMoveis.RowHeadersWidth = 25
        Me.DgvBensMoveis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBensMoveis.RowHeight = 25
        Me.DgvBensMoveis.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvBensMoveis.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvBensMoveis.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvBensMoveis.RowTemplate.Height = 25
        Me.DgvBensMoveis.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvBensMoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBensMoveis.SelectionTextColor = System.Drawing.Color.White
        Me.DgvBensMoveis.Size = New System.Drawing.Size(930, 395)
        Me.DgvBensMoveis.TabIndex = 73
        '
        'FormBensMoveis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Bens Móveis"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.Chair
        Me.Name = "FormBensMoveis"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Bens Móveis"
        Me._pnlClientArea.ResumeLayout(False)
        Me.RjPanel2.ResumeLayout(False)
        Me.RjPanel2.PerformLayout()
        CType(Me.DgvBensMoveis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjPanel2 As RJPanel
    Friend WithEvents RjLabel28 As RJLabel
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents TxtDependencia As RJTextBox
    Friend WithEvents TxtBem As RJTextBox
    Friend WithEvents TxtIgreja As RJTextBox
    Friend WithEvents BtnLimpaFiltro As RJButton
    Friend WithEvents lblNumberItems As RJLabel
    Friend WithEvents BtnImportar As RJButton
    Friend WithEvents CboSetor As RJComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BarraProgresso As RJProgressBar
    Friend WithEvents DgvBensMoveis As RJDataGridView
End Class
