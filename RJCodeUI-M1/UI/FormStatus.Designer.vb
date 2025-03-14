<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStatus
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
        Me.btnCancelar = New PROJETOBASE.RJButton()
        Me.btnSalvar = New PROJETOBASE.RJButton()
        Me.btnNovo = New PROJETOBASE.RJButton()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.RjLabel21 = New PROJETOBASE.RJLabel()
        Me.txtDescricao = New PROJETOBASE.RJTextBox()
        Me.txtCodigo = New PROJETOBASE.RJTextBox()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.txtPesquisar = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.dgvStatus = New PROJETOBASE.RJDataGridView()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Controls.Add(Me.lblNumberItems)
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.txtPesquisar)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.dgvStatus)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjPanel1
        '
        Me.RjPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 15
        Me.RjPanel1.Controls.Add(Me.btnCancelar)
        Me.RjPanel1.Controls.Add(Me.btnSalvar)
        Me.RjPanel1.Controls.Add(Me.btnNovo)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Controls.Add(Me.RjLabel21)
        Me.RjPanel1.Controls.Add(Me.txtDescricao)
        Me.RjPanel1.Controls.Add(Me.txtCodigo)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Location = New System.Drawing.Point(583, 44)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(353, 442)
        Me.RjPanel1.TabIndex = 125
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCancelar.BorderRadius = 10
        Me.btnCancelar.BorderSize = 1
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Design = PROJETOBASE.ButtonDesign.Cancel
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark
        Me.btnCancelar.IconColor = System.Drawing.Color.White
        Me.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancelar.IconSize = 24
        Me.btnCancelar.Location = New System.Drawing.Point(230, 200)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 30)
        Me.btnCancelar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCancelar.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnCancelar.TabIndex = 104
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSalvar.BorderRadius = 10
        Me.btnSalvar.BorderSize = 1
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Design = PROJETOBASE.ButtonDesign.Confirm
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnSalvar.IconColor = System.Drawing.Color.White
        Me.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalvar.IconSize = 24
        Me.btnSalvar.Location = New System.Drawing.Point(128, 200)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(97, 30)
        Me.btnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSalvar.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnSalvar.TabIndex = 103
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnNovo.BorderRadius = 10
        Me.btnNovo.BorderSize = 1
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Design = PROJETOBASE.ButtonDesign.Normal
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btnNovo.IconColor = System.Drawing.Color.White
        Me.btnNovo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNovo.IconSize = 24
        Me.btnNovo.Location = New System.Drawing.Point(26, 200)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 30)
        Me.btnNovo.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnNovo.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnNovo.TabIndex = 102
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
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
        'txtDescricao
        '
        Me.txtDescricao._Customizable = False
        Me.txtDescricao.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtDescricao.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDescricao.BorderRadius = 15
        Me.txtDescricao.BorderSize = 2
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtDescricao.Location = New System.Drawing.Point(26, 136)
        Me.txtDescricao.MultiLine = False
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtDescricao.PasswordChar = False
        Me.txtDescricao.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtDescricao.PlaceHolderText = ""
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescricao.Size = New System.Drawing.Size(306, 31)
        Me.txtDescricao.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.txtDescricao.TabIndex = 98
        '
        'txtCodigo
        '
        Me.txtCodigo._Customizable = False
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtCodigo.BorderRadius = 15
        Me.txtCodigo.BorderSize = 2
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(26, 64)
        Me.txtCodigo.MultiLine = False
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtCodigo.PasswordChar = False
        Me.txtCodigo.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtCodigo.PlaceHolderText = ""
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.Size = New System.Drawing.Size(129, 31)
        Me.txtCodigo.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.txtCodigo.TabIndex = 98
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
        'txtPesquisar
        '
        Me.txtPesquisar._Customizable = False
        Me.txtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPesquisar.BorderRadius = 0
        Me.txtPesquisar.BorderSize = 1
        Me.txtPesquisar.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPesquisar.Location = New System.Drawing.Point(121, 7)
        Me.txtPesquisar.MultiLine = False
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPesquisar.PasswordChar = False
        Me.txtPesquisar.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtPesquisar.PlaceHolderText = "Digite um termo para pesquisa"
        Me.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPesquisar.Size = New System.Drawing.Size(372, 31)
        Me.txtPesquisar.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtPesquisar.TabIndex = 122
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
        'dgvStatus
        '
        Me.dgvStatus.AllowUserToAddRows = False
        Me.dgvStatus.AllowUserToResizeRows = False
        Me.dgvStatus.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.dgvStatus.AlternatingRowsColorApply = False
        Me.dgvStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStatus.BackgroundColor = System.Drawing.Color.White
        Me.dgvStatus.BorderRadius = 10
        Me.dgvStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStatus.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.dgvStatus.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStatus.ColumnHeaderHeight = 40
        Me.dgvStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStatus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStatus.ColumnHeadersHeight = 40
        Me.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStatus.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.dgvStatus.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStatus.Customizable = True
        Me.dgvStatus.DgvBackColor = System.Drawing.Color.White
        Me.dgvStatus.EnableHeadersVisualStyles = False
        Me.dgvStatus.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvStatus.Location = New System.Drawing.Point(26, 44)
        Me.dgvStatus.Name = "dgvStatus"
        Me.dgvStatus.ReadOnly = True
        Me.dgvStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvStatus.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStatus.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStatus.RowHeadersVisible = False
        Me.dgvStatus.RowHeadersWidth = 30
        Me.dgvStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStatus.RowHeight = 25
        Me.dgvStatus.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStatus.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStatus.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.dgvStatus.RowTemplate.Height = 25
        Me.dgvStatus.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStatus.SelectionTextColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStatus.Size = New System.Drawing.Size(527, 442)
        Me.dgvStatus.TabIndex = 120
        '
        'FormStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Status"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.CircleExclamation
        Me.Name = "FormStatus"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Status"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents btnCancelar As RJButton
    Friend WithEvents btnSalvar As RJButton
    Friend WithEvents btnNovo As RJButton
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents RjLabel21 As RJLabel
    Friend WithEvents txtDescricao As RJTextBox
    Friend WithEvents txtCodigo As RJTextBox
    Friend WithEvents lblNumberItems As RJLabel
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents txtPesquisar As RJTextBox
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents dgvStatus As RJDataGridView
End Class
