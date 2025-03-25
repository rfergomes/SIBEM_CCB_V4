<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIgrejas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.TxtPesquisar = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.DgvIgrejas = New PROJETOBASE.RJDataGridView()
        Me.BtnNovo = New PROJETOBASE.RJButton()
        Me.BtnEditar = New PROJETOBASE.RJButton()
        Me.DgvInventarios = New PROJETOBASE.RJDataGridView()
        Me.LblInventariosTotalItens = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.DgvIgrejas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.DgvInventarios)
        Me._pnlClientArea.Controls.Add(Me.BtnEditar)
        Me._pnlClientArea.Controls.Add(Me.BtnNovo)
        Me._pnlClientArea.Controls.Add(Me.DgvIgrejas)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.TxtPesquisar)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.LblInventariosTotalItens)
        Me._pnlClientArea.Controls.Add(Me.lblNumberItems)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjButton1
        '
        Me.RjButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.RjButton1.Location = New System.Drawing.Point(563, 26)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(57, 31)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 104
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar._Customizable = False
        Me.TxtPesquisar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtPesquisar.BorderRadius = 0
        Me.TxtPesquisar.BorderSize = 1
        Me.TxtPesquisar.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.Location = New System.Drawing.Point(318, 26)
        Me.TxtPesquisar.MultiLine = False
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtPesquisar.PasswordChar = False
        Me.TxtPesquisar.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtPesquisar.PlaceHolderText = "Digite um termo para pesquisa"
        Me.TxtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtPesquisar.Size = New System.Drawing.Size(245, 31)
        Me.TxtPesquisar.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtPesquisar.TabIndex = 103
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(315, 7)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(69, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 102
        Me.RjLabel1.Text = "Pesquisar"
        '
        'lblNumberItems
        '
        Me.lblNumberItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberItems.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNumberItems.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblNumberItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblNumberItems.LinkLabel = False
        Me.lblNumberItems.Location = New System.Drawing.Point(554, 493)
        Me.lblNumberItems.Name = "lblNumberItems"
        Me.lblNumberItems.Size = New System.Drawing.Size(73, 18)
        Me.lblNumberItems.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblNumberItems.TabIndex = 108
        Me.lblNumberItems.Text = "0"
        Me.lblNumberItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(25, 27)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(261, 23)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Title2
        Me.RjLabel4.TabIndex = 110
        Me.RjLabel4.Text = "LISTA CASAS DE ORAÇÃO"
        '
        'DgvIgrejas
        '
        Me.DgvIgrejas.AllowUserToAddRows = False
        Me.DgvIgrejas.AllowUserToOrderColumns = True
        Me.DgvIgrejas.AllowUserToResizeRows = False
        Me.DgvIgrejas.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvIgrejas.AlternatingRowsColorApply = True
        Me.DgvIgrejas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvIgrejas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvIgrejas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvIgrejas.BorderRadius = 10
        Me.DgvIgrejas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvIgrejas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvIgrejas.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvIgrejas.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvIgrejas.ColumnHeaderHeight = 40
        Me.DgvIgrejas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIgrejas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvIgrejas.ColumnHeadersHeight = 40
        Me.DgvIgrejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvIgrejas.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvIgrejas.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvIgrejas.Customizable = True
        Me.DgvIgrejas.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvIgrejas.EnableHeadersVisualStyles = False
        Me.DgvIgrejas.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvIgrejas.Location = New System.Drawing.Point(14, 63)
        Me.DgvIgrejas.Name = "DgvIgrejas"
        Me.DgvIgrejas.ReadOnly = True
        Me.DgvIgrejas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvIgrejas.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvIgrejas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvIgrejas.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvIgrejas.RowHeadersVisible = False
        Me.DgvIgrejas.RowHeadersWidth = 25
        Me.DgvIgrejas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvIgrejas.RowHeight = 25
        Me.DgvIgrejas.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgvIgrejas.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvIgrejas.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvIgrejas.RowTemplate.Height = 25
        Me.DgvIgrejas.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvIgrejas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvIgrejas.SelectionTextColor = System.Drawing.Color.WhiteSmoke
        Me.DgvIgrejas.Size = New System.Drawing.Size(613, 427)
        Me.DgvIgrejas.TabIndex = 111
        '
        'BtnNovo
        '
        Me.BtnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnNovo.BorderRadius = 5
        Me.BtnNovo.BorderSize = 1
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnNovo.FlatAppearance.BorderSize = 0
        Me.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.White
        Me.BtnNovo.IconChar = FontAwesome.Sharp.IconChar.FileText
        Me.BtnNovo.IconColor = System.Drawing.Color.White
        Me.BtnNovo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNovo.IconSize = 24
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNovo.Location = New System.Drawing.Point(679, 27)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(95, 30)
        Me.BtnNovo.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnNovo.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnNovo.TabIndex = 0
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNovo.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BtnEditar.BorderRadius = 5
        Me.BtnEditar.BorderSize = 1
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil
        Me.BtnEditar.IconColor = System.Drawing.Color.White
        Me.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEditar.IconSize = 24
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(793, 27)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(95, 30)
        Me.BtnEditar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnEditar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnEditar.TabIndex = 0
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'DgvInventarios
        '
        Me.DgvInventarios.AllowUserToAddRows = False
        Me.DgvInventarios.AllowUserToDeleteRows = False
        Me.DgvInventarios.AllowUserToOrderColumns = True
        Me.DgvInventarios.AllowUserToResizeRows = False
        Me.DgvInventarios.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvInventarios.AlternatingRowsColorApply = False
        Me.DgvInventarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvInventarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvInventarios.BorderRadius = 10
        Me.DgvInventarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvInventarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvInventarios.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvInventarios.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvInventarios.ColumnHeaderHeight = 40
        Me.DgvInventarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvInventarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvInventarios.ColumnHeadersHeight = 40
        Me.DgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvInventarios.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvInventarios.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvInventarios.Customizable = True
        Me.DgvInventarios.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvInventarios.EnableHeadersVisualStyles = False
        Me.DgvInventarios.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvInventarios.Location = New System.Drawing.Point(633, 63)
        Me.DgvInventarios.Name = "DgvInventarios"
        Me.DgvInventarios.ReadOnly = True
        Me.DgvInventarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvInventarios.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvInventarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvInventarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvInventarios.RowHeadersVisible = False
        Me.DgvInventarios.RowHeadersWidth = 25
        Me.DgvInventarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvInventarios.RowHeight = 25
        Me.DgvInventarios.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgvInventarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvInventarios.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvInventarios.RowTemplate.Height = 25
        Me.DgvInventarios.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvInventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvInventarios.SelectionTextColor = System.Drawing.Color.WhiteSmoke
        Me.DgvInventarios.Size = New System.Drawing.Size(313, 427)
        Me.DgvInventarios.TabIndex = 112
        '
        'LblInventariosTotalItens
        '
        Me.LblInventariosTotalItens.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInventariosTotalItens.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInventariosTotalItens.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblInventariosTotalItens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblInventariosTotalItens.LinkLabel = False
        Me.LblInventariosTotalItens.Location = New System.Drawing.Point(873, 493)
        Me.LblInventariosTotalItens.Name = "LblInventariosTotalItens"
        Me.LblInventariosTotalItens.Size = New System.Drawing.Size(73, 18)
        Me.LblInventariosTotalItens.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblInventariosTotalItens.TabIndex = 108
        Me.LblInventariosTotalItens.Text = "0"
        Me.LblInventariosTotalItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormIgrejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Casas de Oração"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.Building
        Me.Name = "FormIgrejas"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Casas de Oração"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.DgvIgrejas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents TxtPesquisar As RJTextBox
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents lblNumberItems As RJLabel
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents DgvIgrejas As RJDataGridView
    Friend WithEvents BtnNovo As RJButton
    Friend WithEvents BtnEditar As RJButton
    Friend WithEvents DgvInventarios As RJDataGridView
    Friend WithEvents LblInventariosTotalItens As RJLabel
End Class
