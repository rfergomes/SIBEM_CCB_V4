<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDependencias
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
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.BtnCancelar = New PROJETOBASE.RJButton()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.BtnNovo = New PROJETOBASE.RJButton()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.RjLabel21 = New PROJETOBASE.RJLabel()
        Me.TxtDescricao = New PROJETOBASE.RJTextBox()
        Me.TxtId = New PROJETOBASE.RJTextBox()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.TxtPesquisar = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.DgvDependencias = New PROJETOBASE.RJDataGridView()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        CType(Me.DgvDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Controls.Add(Me.lblNumberItems)
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.TxtPesquisar)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.DgvDependencias)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjPanel1
        '
        Me.RjPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 10
        Me.RjPanel1.Controls.Add(Me.BtnCancelar)
        Me.RjPanel1.Controls.Add(Me.BtnSalvar)
        Me.RjPanel1.Controls.Add(Me.BtnNovo)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Controls.Add(Me.RjLabel21)
        Me.RjPanel1.Controls.Add(Me.TxtDescricao)
        Me.RjPanel1.Controls.Add(Me.TxtId)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Location = New System.Drawing.Point(583, 44)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(353, 442)
        Me.RjPanel1.TabIndex = 125
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BtnCancelar.BorderRadius = 10
        Me.BtnCancelar.BorderSize = 1
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Design = PROJETOBASE.ButtonDesign.Cancel
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark
        Me.BtnCancelar.IconColor = System.Drawing.Color.White
        Me.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCancelar.IconSize = 24
        Me.BtnCancelar.Location = New System.Drawing.Point(230, 200)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(97, 30)
        Me.BtnCancelar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BtnCancelar.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnCancelar.TabIndex = 104
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 10
        Me.BtnSalvar.BorderSize = 1
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.Confirm
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.BtnSalvar.IconColor = System.Drawing.Color.White
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(128, 200)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(97, 30)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnSalvar.TabIndex = 103
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnNovo
        '
        Me.BtnNovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnNovo.BorderRadius = 10
        Me.BtnNovo.BorderSize = 1
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.Design = PROJETOBASE.ButtonDesign.Normal
        Me.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnNovo.FlatAppearance.BorderSize = 0
        Me.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.White
        Me.BtnNovo.IconChar = FontAwesome.Sharp.IconChar.File
        Me.BtnNovo.IconColor = System.Drawing.Color.White
        Me.BtnNovo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNovo.IconSize = 24
        Me.BtnNovo.Location = New System.Drawing.Point(26, 200)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(97, 30)
        Me.BtnNovo.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnNovo.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnNovo.TabIndex = 102
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNovo.UseVisualStyleBackColor = False
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(36, 117)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(83, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 99
        Me.RjLabel2.Text = "DESCRIÇÃO"
        '
        'RjLabel21
        '
        Me.RjLabel21.AutoSize = True
        Me.RjLabel21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel21.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel21.LinkLabel = False
        Me.RjLabel21.Location = New System.Drawing.Point(36, 45)
        Me.RjLabel21.Name = "RjLabel21"
        Me.RjLabel21.Size = New System.Drawing.Size(59, 16)
        Me.RjLabel21.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel21.TabIndex = 99
        Me.RjLabel21.Text = "CÓDIGO"
        '
        'TxtDescricao
        '
        Me.TxtDescricao._Customizable = False
        Me.TxtDescricao.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtDescricao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtDescricao.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtDescricao.BorderRadius = 15
        Me.TxtDescricao.BorderSize = 2
        Me.TxtDescricao.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtDescricao.Location = New System.Drawing.Point(26, 136)
        Me.TxtDescricao.MultiLine = False
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtDescricao.PasswordChar = False
        Me.TxtDescricao.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtDescricao.PlaceHolderText = ""
        Me.TxtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtDescricao.Size = New System.Drawing.Size(306, 31)
        Me.TxtDescricao.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.TxtDescricao.TabIndex = 98
        '
        'TxtId
        '
        Me.TxtId._Customizable = False
        Me.TxtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtId.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtId.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtId.BorderRadius = 15
        Me.TxtId.BorderSize = 2
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtId.Location = New System.Drawing.Point(26, 64)
        Me.TxtId.MultiLine = False
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtId.PasswordChar = False
        Me.TxtId.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtId.PlaceHolderText = ""
        Me.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtId.Size = New System.Drawing.Size(129, 31)
        Me.TxtId.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.TxtId.TabIndex = 98
        '
        'lblNumberItems
        '
        Me.lblNumberItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumberItems.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNumberItems.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblNumberItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblNumberItems.LinkLabel = False
        Me.lblNumberItems.Location = New System.Drawing.Point(379, 489)
        Me.lblNumberItems.Name = "lblNumberItems"
        Me.lblNumberItems.Size = New System.Drawing.Size(174, 23)
        Me.lblNumberItems.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblNumberItems.TabIndex = 124
        Me.lblNumberItems.Text = "0"
        Me.lblNumberItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 1
        Me.RjButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjButton1.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.RjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.RjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.RjButton1.IconColor = System.Drawing.Color.White
        Me.RjButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton1.IconSize = 24
        Me.RjButton1.Location = New System.Drawing.Point(493, 7)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(57, 31)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 123
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar._Customizable = False
        Me.TxtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtPesquisar.BorderRadius = 0
        Me.TxtPesquisar.BorderSize = 1
        Me.TxtPesquisar.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.Location = New System.Drawing.Point(121, 7)
        Me.TxtPesquisar.MultiLine = False
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtPesquisar.PasswordChar = False
        Me.TxtPesquisar.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtPesquisar.PlaceHolderText = "Digite um termo para pesquisa"
        Me.TxtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtPesquisar.Size = New System.Drawing.Size(372, 31)
        Me.TxtPesquisar.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtPesquisar.TabIndex = 122
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(23, 12)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(78, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 121
        Me.RjLabel1.Text = "Pesquisar"
        '
        'DgvDependencias
        '
        Me.DgvDependencias.AllowUserToAddRows = False
        Me.DgvDependencias.AllowUserToResizeRows = False
        Me.DgvDependencias.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvDependencias.AlternatingRowsColorApply = False
        Me.DgvDependencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvDependencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDependencias.BackgroundColor = System.Drawing.Color.White
        Me.DgvDependencias.BorderRadius = 10
        Me.DgvDependencias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDependencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDependencias.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvDependencias.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDependencias.ColumnHeaderHeight = 40
        Me.DgvDependencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDependencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDependencias.ColumnHeadersHeight = 40
        Me.DgvDependencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvDependencias.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvDependencias.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDependencias.Customizable = True
        Me.DgvDependencias.DgvBackColor = System.Drawing.Color.White
        Me.DgvDependencias.EnableHeadersVisualStyles = False
        Me.DgvDependencias.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvDependencias.Location = New System.Drawing.Point(26, 44)
        Me.DgvDependencias.Name = "DgvDependencias"
        Me.DgvDependencias.ReadOnly = True
        Me.DgvDependencias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvDependencias.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvDependencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDependencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDependencias.RowHeadersVisible = False
        Me.DgvDependencias.RowHeadersWidth = 30
        Me.DgvDependencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDependencias.RowHeight = 25
        Me.DgvDependencias.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgvDependencias.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDependencias.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvDependencias.RowTemplate.Height = 25
        Me.DgvDependencias.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvDependencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDependencias.SelectionTextColor = System.Drawing.Color.WhiteSmoke
        Me.DgvDependencias.Size = New System.Drawing.Size(527, 442)
        Me.DgvDependencias.TabIndex = 120
        '
        'FormDependencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Dependências"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.LocationPin
        Me.Name = "FormDependencias"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Dependências"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        CType(Me.DgvDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents BtnCancelar As RJButton
    Friend WithEvents BtnSalvar As RJButton
    Friend WithEvents BtnNovo As RJButton
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents RjLabel21 As RJLabel
    Friend WithEvents TxtDescricao As RJTextBox
    Friend WithEvents TxtId As RJTextBox
    Friend WithEvents lblNumberItems As RJLabel
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents TxtPesquisar As RJTextBox
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents DgvDependencias As RJDataGridView
End Class
