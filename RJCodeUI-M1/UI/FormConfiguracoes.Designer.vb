<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfiguracoes
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfiguracoes))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.ChkAtivo = New PROJETOBASE.RJCheckBox()
        Me.DgvServidores = New PROJETOBASE.RJDataGridView()
        Me.DdmAcoes = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTeste = New PROJETOBASE.RJButton()
        Me.BtnCancelar = New PROJETOBASE.RJButton()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.TxtBanco = New PROJETOBASE.RJTextBox()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.TxtSenha = New PROJETOBASE.RJTextBox()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.TxtUsuario = New PROJETOBASE.RJTextBox()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.TxtPorta = New PROJETOBASE.RJTextBox()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.TxtServidor = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjPictureBox1 = New PROJETOBASE.RJPictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me.Pnl_Tokens = New PROJETOBASE.RJPanel()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.TxtPesquisar = New PROJETOBASE.RJTextBox()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.BtnConsultar = New PROJETOBASE.RJButton()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.DgvUsuarios = New PROJETOBASE.RJDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        CType(Me.DgvServidores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DdmAcoes.SuspendLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RjPanel2.SuspendLayout()
        Me.Pnl_Tokens.SuspendLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjPanel2)
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 408)
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.ChkAtivo)
        Me.RjPanel1.Controls.Add(Me.DgvServidores)
        Me.RjPanel1.Controls.Add(Me.BtnTeste)
        Me.RjPanel1.Controls.Add(Me.BtnCancelar)
        Me.RjPanel1.Controls.Add(Me.BtnSalvar)
        Me.RjPanel1.Controls.Add(Me.TxtBanco)
        Me.RjPanel1.Controls.Add(Me.RjLabel7)
        Me.RjPanel1.Controls.Add(Me.TxtSenha)
        Me.RjPanel1.Controls.Add(Me.RjLabel6)
        Me.RjPanel1.Controls.Add(Me.TxtUsuario)
        Me.RjPanel1.Controls.Add(Me.RjLabel5)
        Me.RjPanel1.Controls.Add(Me.TxtPorta)
        Me.RjPanel1.Controls.Add(Me.RjLabel4)
        Me.RjPanel1.Controls.Add(Me.TxtServidor)
        Me.RjPanel1.Controls.Add(Me.RjLabel3)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Controls.Add(Me.RjLabel1)
        Me.RjPanel1.Controls.Add(Me.RjPictureBox1)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RjPanel1.Location = New System.Drawing.Point(538, 0)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(420, 408)
        Me.RjPanel1.TabIndex = 0
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkAtivo.BorderSize = 1
        Me.ChkAtivo.Check = False
        Me.ChkAtivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAtivo.Customizable = True
        Me.ChkAtivo.Enabled = False
        Me.ChkAtivo.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.ChkAtivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkAtivo.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkAtivo.Location = New System.Drawing.Point(13, 266)
        Me.ChkAtivo.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkAtivo.Size = New System.Drawing.Size(70, 21)
        Me.ChkAtivo.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkAtivo.TabIndex = 6
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'DgvServidores
        '
        Me.DgvServidores.AllowUserToAddRows = False
        Me.DgvServidores.AllowUserToDeleteRows = False
        Me.DgvServidores.AllowUserToOrderColumns = True
        Me.DgvServidores.AllowUserToResizeRows = False
        Me.DgvServidores.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvServidores.AlternatingRowsColorApply = True
        Me.DgvServidores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvServidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvServidores.BackgroundColor = System.Drawing.Color.White
        Me.DgvServidores.BorderRadius = 8
        Me.DgvServidores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvServidores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvServidores.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvServidores.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvServidores.ColumnHeaderHeight = 40
        Me.DgvServidores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvServidores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DgvServidores.ColumnHeadersHeight = 40
        Me.DgvServidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvServidores.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvServidores.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvServidores.ContextMenuStrip = Me.DdmAcoes
        Me.DgvServidores.Customizable = True
        Me.DgvServidores.DgvBackColor = System.Drawing.Color.White
        Me.DgvServidores.EnableHeadersVisualStyles = False
        Me.DgvServidores.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvServidores.Location = New System.Drawing.Point(11, 342)
        Me.DgvServidores.MultiSelect = False
        Me.DgvServidores.Name = "DgvServidores"
        Me.DgvServidores.ReadOnly = True
        Me.DgvServidores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvServidores.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvServidores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvServidores.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DgvServidores.RowHeadersVisible = False
        Me.DgvServidores.RowHeadersWidth = 25
        Me.DgvServidores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvServidores.RowHeight = 25
        Me.DgvServidores.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.DgvServidores.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DgvServidores.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvServidores.RowTemplate.Height = 25
        Me.DgvServidores.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvServidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvServidores.SelectionTextColor = System.Drawing.Color.White
        Me.DgvServidores.Size = New System.Drawing.Size(401, 58)
        Me.DgvServidores.TabIndex = 10
        '
        'DdmAcoes
        '
        Me.DdmAcoes.ActiveMenuItem = False
        Me.DdmAcoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DdmAcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.DdmAcoes.Name = "DdmAcoes"
        Me.DdmAcoes.OwnerIsMenuButton = False
        Me.DdmAcoes.Size = New System.Drawing.Size(118, 70)
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Image = CType(resources.GetObject("NovoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = CType(resources.GetObject("ExcluirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'BtnTeste
        '
        Me.BtnTeste.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnTeste.BorderRadius = 0
        Me.BtnTeste.BorderSize = 1
        Me.BtnTeste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTeste.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnTeste.Enabled = False
        Me.BtnTeste.FlatAppearance.BorderSize = 0
        Me.BtnTeste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnTeste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTeste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTeste.ForeColor = System.Drawing.Color.ForestGreen
        Me.BtnTeste.IconChar = FontAwesome.Sharp.IconChar.NetworkWired
        Me.BtnTeste.IconColor = System.Drawing.Color.ForestGreen
        Me.BtnTeste.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTeste.IconSize = 24
        Me.BtnTeste.Location = New System.Drawing.Point(12, 296)
        Me.BtnTeste.Name = "BtnTeste"
        Me.BtnTeste.Size = New System.Drawing.Size(145, 30)
        Me.BtnTeste.SkinBorderColor = System.Drawing.Color.ForestGreen
        Me.BtnTeste.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnTeste.TabIndex = 7
        Me.BtnTeste.Text = "Testar Conexão"
        Me.BtnTeste.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTeste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTeste.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnCancelar.BorderRadius = 0
        Me.BtnCancelar.BorderSize = 1
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Design = PROJETOBASE.ButtonDesign.Cancel
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtnCancelar.IconColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCancelar.IconSize = 24
        Me.BtnCancelar.Location = New System.Drawing.Point(305, 296)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.BtnCancelar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 0
        Me.BtnSalvar.BorderSize = 1
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSalvar.Enabled = False
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSalvar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(178, 296)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(106, 30)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSalvar.TabIndex = 8
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'TxtBanco
        '
        Me.TxtBanco._Customizable = False
        Me.TxtBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtBanco.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBanco.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtBanco.BorderRadius = 0
        Me.TxtBanco.BorderSize = 2
        Me.TxtBanco.Enabled = False
        Me.TxtBanco.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBanco.Location = New System.Drawing.Point(12, 173)
        Me.TxtBanco.MultiLine = False
        Me.TxtBanco.Name = "TxtBanco"
        Me.TxtBanco.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtBanco.PasswordChar = False
        Me.TxtBanco.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtBanco.PlaceHolderText = "Nome do Banco"
        Me.TxtBanco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBanco.Size = New System.Drawing.Size(284, 31)
        Me.TxtBanco.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.TxtBanco.TabIndex = 2
        Me.TxtBanco.Tag = "Banco"
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(9, 154)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(47, 16)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel7.TabIndex = 4
        Me.RjLabel7.Text = "Banco"
        '
        'TxtSenha
        '
        Me.TxtSenha._Customizable = False
        Me.TxtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtSenha.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSenha.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtSenha.BorderRadius = 0
        Me.TxtSenha.BorderSize = 2
        Me.TxtSenha.Enabled = False
        Me.TxtSenha.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSenha.Location = New System.Drawing.Point(217, 229)
        Me.TxtSenha.MultiLine = False
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtSenha.PasswordChar = False
        Me.TxtSenha.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtSenha.PlaceHolderText = "Senha de acesso"
        Me.TxtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSenha.Size = New System.Drawing.Size(195, 31)
        Me.TxtSenha.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.TxtSenha.TabIndex = 5
        Me.TxtSenha.Tag = "Senha"
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(214, 210)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(48, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel6.TabIndex = 4
        Me.RjLabel6.Text = "Senha"
        '
        'TxtUsuario
        '
        Me.TxtUsuario._Customizable = False
        Me.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtUsuario.BorderRadius = 0
        Me.TxtUsuario.BorderSize = 2
        Me.TxtUsuario.Enabled = False
        Me.TxtUsuario.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtUsuario.Location = New System.Drawing.Point(12, 229)
        Me.TxtUsuario.MultiLine = False
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtUsuario.PasswordChar = False
        Me.TxtUsuario.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtUsuario.PlaceHolderText = "Nome do Usuário"
        Me.TxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtUsuario.Size = New System.Drawing.Size(199, 31)
        Me.TxtUsuario.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.TxtUsuario.TabIndex = 4
        Me.TxtUsuario.Tag = "Usuário"
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(9, 210)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(55, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 4
        Me.RjLabel5.Text = "Usuário"
        '
        'TxtPorta
        '
        Me.TxtPorta._Customizable = False
        Me.TxtPorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtPorta.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPorta.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtPorta.BorderRadius = 0
        Me.TxtPorta.BorderSize = 2
        Me.TxtPorta.Enabled = False
        Me.TxtPorta.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtPorta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPorta.Location = New System.Drawing.Point(302, 173)
        Me.TxtPorta.MultiLine = False
        Me.TxtPorta.Name = "TxtPorta"
        Me.TxtPorta.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtPorta.PasswordChar = False
        Me.TxtPorta.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtPorta.PlaceHolderText = "Porta Nº"
        Me.TxtPorta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtPorta.Size = New System.Drawing.Size(110, 31)
        Me.TxtPorta.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.TxtPorta.TabIndex = 3
        Me.TxtPorta.Tag = "Porta"
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(299, 154)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(42, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 4
        Me.RjLabel4.Text = "Porta"
        '
        'TxtServidor
        '
        Me.TxtServidor._Customizable = False
        Me.TxtServidor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtServidor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtServidor.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtServidor.BorderRadius = 0
        Me.TxtServidor.BorderSize = 2
        Me.TxtServidor.Enabled = False
        Me.TxtServidor.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtServidor.Location = New System.Drawing.Point(12, 116)
        Me.TxtServidor.MultiLine = False
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtServidor.PasswordChar = False
        Me.TxtServidor.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtServidor.PlaceHolderText = "URL do Servidor"
        Me.TxtServidor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtServidor.Size = New System.Drawing.Size(400, 31)
        Me.TxtServidor.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.TxtServidor.TabIndex = 1
        Me.TxtServidor.Tag = "Servidor/Host"
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(9, 97)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(97, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 2
        Me.RjLabel3.Text = "Servidor/Host"
        '
        'RjLabel2
        '
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(79, 32)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(302, 50)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Description
        Me.RjLabel2.TabIndex = 1
        Me.RjLabel2.Text = "Credenciais do Servidor Remoto, onde os dados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "são armazenados em nuvem e disponi" &
    "bilizados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aos demais usuários da Administração."
        Me.RjLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(113, 9)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(209, 18)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "Servidor MySQL  Remoto"
        '
        'RjPictureBox1
        '
        Me.RjPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjPictureBox1.BorderRadius = 0
        Me.RjPictureBox1.BorderSize = 0
        Me.RjPictureBox1.Customizable = True
        Me.RjPictureBox1.Image = CType(resources.GetObject("RjPictureBox1.Image"), System.Drawing.Image)
        Me.RjPictureBox1.Location = New System.Drawing.Point(3, 29)
        Me.RjPictureBox1.Name = "RjPictureBox1"
        Me.RjPictureBox1.Size = New System.Drawing.Size(79, 65)
        Me.RjPictureBox1.TabIndex = 9
        Me.RjPictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RjPanel2
        '
        Me.RjPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel2.BorderRadius = 0
        Me.RjPanel2.Controls.Add(Me.Pnl_Tokens)
        Me.RjPanel2.Customizable = False
        Me.RjPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(532, 408)
        Me.RjPanel2.TabIndex = 1
        '
        'Pnl_Tokens
        '
        Me.Pnl_Tokens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_Tokens.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Pnl_Tokens.BorderRadius = 0
        Me.Pnl_Tokens.Controls.Add(Me.lblNumberItems)
        Me.Pnl_Tokens.Controls.Add(Me.RjButton1)
        Me.Pnl_Tokens.Controls.Add(Me.TxtPesquisar)
        Me.Pnl_Tokens.Controls.Add(Me.RjLabel9)
        Me.Pnl_Tokens.Controls.Add(Me.BtnConsultar)
        Me.Pnl_Tokens.Controls.Add(Me.RjLabel8)
        Me.Pnl_Tokens.Controls.Add(Me.DgvUsuarios)
        Me.Pnl_Tokens.Customizable = False
        Me.Pnl_Tokens.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_Tokens.Name = "Pnl_Tokens"
        Me.Pnl_Tokens.Size = New System.Drawing.Size(526, 402)
        Me.Pnl_Tokens.TabIndex = 0
        '
        'lblNumberItems
        '
        Me.lblNumberItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberItems.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNumberItems.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblNumberItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblNumberItems.LinkLabel = False
        Me.lblNumberItems.Location = New System.Drawing.Point(337, 326)
        Me.lblNumberItems.Name = "lblNumberItems"
        Me.lblNumberItems.Size = New System.Drawing.Size(174, 23)
        Me.lblNumberItems.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblNumberItems.TabIndex = 125
        Me.lblNumberItems.Text = "0"
        Me.lblNumberItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.RjButton1.Location = New System.Drawing.Point(454, 48)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(57, 31)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 107
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
        Me.TxtPesquisar.Location = New System.Drawing.Point(17, 48)
        Me.TxtPesquisar.MultiLine = False
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtPesquisar.PasswordChar = False
        Me.TxtPesquisar.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtPesquisar.PlaceHolderText = "Digite um termo para pesquisa"
        Me.TxtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtPesquisar.Size = New System.Drawing.Size(437, 31)
        Me.TxtPesquisar.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtPesquisar.TabIndex = 106
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(14, 29)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(69, 16)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel9.TabIndex = 105
        Me.RjLabel9.Text = "Pesquisar"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnConsultar.AutoSize = True
        Me.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnConsultar.BorderRadius = 5
        Me.BtnConsultar.BorderSize = 1
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnConsultar.Enabled = False
        Me.BtnConsultar.FlatAppearance.BorderSize = 0
        Me.BtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnConsultar.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtnConsultar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnConsultar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnConsultar.IconSize = 28
        Me.BtnConsultar.Location = New System.Drawing.Point(17, 339)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(187, 34)
        Me.BtnConsultar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnConsultar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnConsultar.TabIndex = 2
        Me.BtnConsultar.Text = "Consultar Solicitação"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConsultar.UseVisualStyleBackColor = False
        Me.BtnConsultar.Visible = False
        '
        'RjLabel8
        '
        Me.RjLabel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(166, 6)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(194, 18)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.RjLabel8.TabIndex = 1
        Me.RjLabel8.Text = "Usuários do sistema"
        Me.RjLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        Me.DgvUsuarios.AllowUserToDeleteRows = False
        Me.DgvUsuarios.AllowUserToResizeRows = False
        Me.DgvUsuarios.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvUsuarios.AlternatingRowsColorApply = False
        Me.DgvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DgvUsuarios.BorderRadius = 13
        Me.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvUsuarios.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvUsuarios.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvUsuarios.ColumnHeaderHeight = 40
        Me.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvUsuarios.ColumnHeadersHeight = 40
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvUsuarios.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DgvUsuarios.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuarios.Customizable = True
        Me.DgvUsuarios.DgvBackColor = System.Drawing.Color.White
        Me.DgvUsuarios.EnableHeadersVisualStyles = False
        Me.DgvUsuarios.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvUsuarios.Location = New System.Drawing.Point(17, 94)
        Me.DgvUsuarios.MultiSelect = False
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvUsuarios.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvUsuarios.RowHeadersVisible = False
        Me.DgvUsuarios.RowHeadersWidth = 25
        Me.DgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvUsuarios.RowHeight = 26
        Me.DgvUsuarios.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.DgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DgvUsuarios.RowsTextColor = System.Drawing.Color.Gray
        Me.DgvUsuarios.RowTemplate.Height = 26
        Me.DgvUsuarios.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuarios.SelectionTextColor = System.Drawing.Color.White
        Me.DgvUsuarios.Size = New System.Drawing.Size(494, 229)
        Me.DgvUsuarios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 56
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Comum"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 91
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Setor"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 77
        '
        'FormConfiguracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "FormConfiguracoes"
        Me.ClientSize = New System.Drawing.Size(960, 450)
        Me.Name = "FormConfiguracoes"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "FormConfiguracoes"
        Me.Controls.SetChildIndex(Me._pnlClientArea, 0)
        Me._pnlClientArea.ResumeLayout(False)
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        CType(Me.DgvServidores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DdmAcoes.ResumeLayout(False)
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RjPanel2.ResumeLayout(False)
        Me.Pnl_Tokens.ResumeLayout(False)
        Me.Pnl_Tokens.PerformLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents TxtServidor As RJTextBox
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents TxtSenha As RJTextBox
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents TxtUsuario As RJTextBox
    Friend WithEvents RjLabel5 As RJLabel
    Friend WithEvents TxtPorta As RJTextBox
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents BtnTeste As RJButton
    Friend WithEvents BtnSalvar As RJButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TxtBanco As RJTextBox
    Friend WithEvents RjLabel7 As RJLabel
    Friend WithEvents DgvServidores As RJDataGridView
    Friend WithEvents BtnCancelar As RJButton
    Friend WithEvents DdmAcoes As RJDropdownMenu
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RjPictureBox1 As RJPictureBox
    Friend WithEvents ChkAtivo As RJCheckBox
    Friend WithEvents RjPanel2 As RJPanel
    Friend WithEvents Pnl_Tokens As RJPanel
    Friend WithEvents RjLabel8 As RJLabel
    Friend WithEvents DgvUsuarios As RJDataGridView
    Friend WithEvents BtnConsultar As RJButton
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents TxtPesquisar As RJTextBox
    Friend WithEvents RjLabel9 As RJLabel
    Friend WithEvents lblNumberItems As RJLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
