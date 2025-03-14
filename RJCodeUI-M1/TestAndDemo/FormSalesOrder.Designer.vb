<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesOrder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbCategory = New PROJETOBASE.RJComboBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.btnRemove = New PROJETOBASE.RJButton()
        Me.btnEdit = New PROJETOBASE.RJButton()
        Me.btnAdd = New PROJETOBASE.RJButton()
        Me.RjDataGridView1 = New PROJETOBASE.RJDataGridView()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.RjTextBox1 = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.cbPeriod = New PROJETOBASE.RJComboBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.btnNextPage = New PROJETOBASE.RJButton()
        Me.RjButton2 = New PROJETOBASE.RJButton()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.RjDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.lblNumberItems)
        Me._pnlClientArea.Controls.Add(Me.RjButton2)
        Me._pnlClientArea.Controls.Add(Me.btnNextPage)
        Me._pnlClientArea.Controls.Add(Me.cbPeriod)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.cbCategory)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.btnRemove)
        Me._pnlClientArea.Controls.Add(Me.btnEdit)
        Me._pnlClientArea.Controls.Add(Me.btnAdd)
        Me._pnlClientArea.Controls.Add(Me.RjDataGridView1)
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.RjTextBox1)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'cbCategory
        '
        Me.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.cbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cbCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.cbCategory.BorderRadius = 0
        Me.cbCategory.BorderSize = 1
        Me.cbCategory.Customizable = False
        Me.cbCategory.DataSource = Nothing
        Me.cbCategory.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cbCategory.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.cbCategory.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cbCategory.Location = New System.Drawing.Point(241, 33)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Padding = New System.Windows.Forms.Padding(1)
        Me.cbCategory.SelectedIndex = -1
        Me.cbCategory.Size = New System.Drawing.Size(200, 32)
        Me.cbCategory.Style = PROJETOBASE.ControlStyle.Glass
        Me.cbCategory.TabIndex = 24
        Me.cbCategory.Texts = ""
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(238, 14)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(73, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 23
        Me.RjLabel2.Text = "Category:"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRemove.BorderRadius = 10
        Me.btnRemove.BorderSize = 1
        Me.btnRemove.Design = PROJETOBASE.ButtonDesign.Delete
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnRemove.IconColor = System.Drawing.Color.White
        Me.btnRemove.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRemove.IconSize = 24
        Me.btnRemove.Location = New System.Drawing.Point(387, 456)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(170, 40)
        Me.btnRemove.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRemove.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnRemove.TabIndex = 22
        Me.btnRemove.Text = "Delete"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnEdit.BorderRadius = 10
        Me.btnEdit.BorderSize = 1
        Me.btnEdit.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEdit.IconColor = System.Drawing.Color.White
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 24
        Me.btnEdit.Location = New System.Drawing.Point(211, 456)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(170, 40)
        Me.btnEdit.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnEdit.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.BorderSize = 0
        Me.btnAdd.Design = PROJETOBASE.ButtonDesign.Custom
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAdd.IconColor = System.Drawing.Color.White
        Me.btnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdd.IconSize = 24
        Me.btnAdd.Location = New System.Drawing.Point(35, 456)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 40)
        Me.btnAdd.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnAdd.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add new"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'RjDataGridView1
        '
        Me.RjDataGridView1.AllowUserToResizeRows = False
        Me.RjDataGridView1.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.RjDataGridView1.AlternatingRowsColorApply = False
        Me.RjDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RjDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.RjDataGridView1.BorderRadius = 13
        Me.RjDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RjDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RjDataGridView1.ColumnHeaderColor = System.Drawing.Color.MediumPurple
        Me.RjDataGridView1.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjDataGridView1.ColumnHeaderHeight = 40
        Me.RjDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RjDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RjDataGridView1.ColumnHeadersHeight = 40
        Me.RjDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.RjDataGridView1.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.RjDataGridView1.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RjDataGridView1.Customizable = False
        Me.RjDataGridView1.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.RjDataGridView1.EnableHeadersVisualStyles = False
        Me.RjDataGridView1.GridColor = System.Drawing.Color.Gainsboro
        Me.RjDataGridView1.Location = New System.Drawing.Point(35, 72)
        Me.RjDataGridView1.Name = "RjDataGridView1"
        Me.RjDataGridView1.ReadOnly = True
        Me.RjDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RjDataGridView1.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.RjDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RjDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RjDataGridView1.RowHeadersVisible = False
        Me.RjDataGridView1.RowHeadersWidth = 30
        Me.RjDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.RjDataGridView1.RowHeight = 40
        Me.RjDataGridView1.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray
        Me.RjDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.RjDataGridView1.RowsTextColor = System.Drawing.Color.Gray
        Me.RjDataGridView1.RowTemplate.Height = 40
        Me.RjDataGridView1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RjDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RjDataGridView1.SelectionTextColor = System.Drawing.Color.Gray
        Me.RjDataGridView1.Size = New System.Drawing.Size(891, 364)
        Me.RjDataGridView1.TabIndex = 19
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 1
        Me.RjButton1.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.RjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.RjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.RjButton1.IconColor = System.Drawing.Color.White
        Me.RjButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton1.IconSize = 24
        Me.RjButton1.Location = New System.Drawing.Point(869, 32)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(57, 31)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 18
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'RjTextBox1
        '
        Me.RjTextBox1._Customizable = False
        Me.RjTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RjTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RjTextBox1.BorderRadius = 0
        Me.RjTextBox1.BorderSize = 1
        Me.RjTextBox1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjTextBox1.Location = New System.Drawing.Point(447, 32)
        Me.RjTextBox1.MultiLine = False
        Me.RjTextBox1.Name = "RjTextBox1"
        Me.RjTextBox1.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox1.PasswordChar = False
        Me.RjTextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox1.PlaceHolderText = Nothing
        Me.RjTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RjTextBox1.Size = New System.Drawing.Size(425, 31)
        Me.RjTextBox1.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.RjTextBox1.TabIndex = 17
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(444, 13)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(59, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 16
        Me.RjLabel1.Text = "Search:"
        '
        'cbPeriod
        '
        Me.cbPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.cbPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.cbPeriod.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cbPeriod.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.cbPeriod.BorderRadius = 0
        Me.cbPeriod.BorderSize = 1
        Me.cbPeriod.Customizable = False
        Me.cbPeriod.DataSource = Nothing
        Me.cbPeriod.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cbPeriod.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.cbPeriod.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cbPeriod.Items.AddRange(New Object() {"Today", "This Week", "Last 7 Days", "This Month", "Last 30 Days", "This Year", "Custom"})
        Me.cbPeriod.Location = New System.Drawing.Point(35, 33)
        Me.cbPeriod.Name = "cbPeriod"
        Me.cbPeriod.Padding = New System.Windows.Forms.Padding(1)
        Me.cbPeriod.SelectedIndex = -1
        Me.cbPeriod.Size = New System.Drawing.Size(200, 32)
        Me.cbPeriod.Style = PROJETOBASE.ControlStyle.Glass
        Me.cbPeriod.TabIndex = 26
        Me.cbPeriod.Texts = ""
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(32, 14)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(53, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 25
        Me.RjLabel3.Text = "Period:"
        '
        'btnNextPage
        '
        Me.btnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNextPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnNextPage.BorderRadius = 0
        Me.btnNextPage.BorderSize = 1
        Me.btnNextPage.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnNextPage.FlatAppearance.BorderSize = 0
        Me.btnNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPage.ForeColor = System.Drawing.Color.White
        Me.btnNextPage.IconChar = FontAwesome.Sharp.IconChar.ForwardStep
        Me.btnNextPage.IconColor = System.Drawing.Color.White
        Me.btnNextPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNextPage.IconSize = 20
        Me.btnNextPage.Location = New System.Drawing.Point(886, 442)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(40, 25)
        Me.btnNextPage.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnNextPage.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnNextPage.TabIndex = 27
        Me.btnNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNextPage.UseVisualStyleBackColor = False
        '
        'RjButton2
        '
        Me.RjButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton2.BorderRadius = 0
        Me.RjButton2.BorderSize = 1
        Me.RjButton2.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.RjButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton2.FlatAppearance.BorderSize = 0
        Me.RjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.RjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.RjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton2.ForeColor = System.Drawing.Color.White
        Me.RjButton2.IconChar = FontAwesome.Sharp.IconChar.BackwardStep
        Me.RjButton2.IconColor = System.Drawing.Color.White
        Me.RjButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton2.IconSize = 20
        Me.RjButton2.Location = New System.Drawing.Point(840, 442)
        Me.RjButton2.Name = "RjButton2"
        Me.RjButton2.Size = New System.Drawing.Size(40, 25)
        Me.RjButton2.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton2.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton2.TabIndex = 28
        Me.RjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton2.UseVisualStyleBackColor = False
        '
        'lblNumberItems
        '
        Me.lblNumberItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberItems.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNumberItems.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblNumberItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblNumberItems.LinkLabel = False
        Me.lblNumberItems.Location = New System.Drawing.Point(660, 442)
        Me.lblNumberItems.Name = "lblNumberItems"
        Me.lblNumberItems.Size = New System.Drawing.Size(174, 23)
        Me.lblNumberItems.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblNumberItems.TabIndex = 29
        Me.lblNumberItems.Text = "0"
        Me.lblNumberItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Sales"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.BasketShopping
        Me.Name = "FormSalesOrder"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Sales"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.RjDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbCategory As PROJETOBASE.RJComboBox
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents btnRemove As PROJETOBASE.RJButton
    Friend WithEvents btnEdit As PROJETOBASE.RJButton
    Friend WithEvents btnAdd As PROJETOBASE.RJButton
    Friend WithEvents RjDataGridView1 As PROJETOBASE.RJDataGridView
    Friend WithEvents RjButton1 As PROJETOBASE.RJButton
    Friend WithEvents RjTextBox1 As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
    Friend WithEvents cbPeriod As PROJETOBASE.RJComboBox
    Friend WithEvents RjLabel3 As PROJETOBASE.RJLabel
    Friend WithEvents lblNumberItems As PROJETOBASE.RJLabel
    Friend WithEvents RjButton2 As PROJETOBASE.RJButton
    Friend WithEvents btnNextPage As PROJETOBASE.RJButton
End Class
