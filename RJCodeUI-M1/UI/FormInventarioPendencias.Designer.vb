<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventarioPendencias
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnLimparFiltros = New PROJETOBASE.RJButton()
        Me.TxtPesquisar = New PROJETOBASE.RJTextBox()
        Me.RjLabel21 = New PROJETOBASE.RJLabel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtObservacoes = New PROJETOBASE.RJTextBox()
        Me.TxtBemMovel = New PROJETOBASE.RJTextBox()
        Me.RjLabel35 = New PROJETOBASE.RJLabel()
        Me.RjLabel45 = New PROJETOBASE.RJLabel()
        Me.RjLabel52 = New PROJETOBASE.RJLabel()
        Me.RjLabel50 = New PROJETOBASE.RJLabel()
        Me.LblSituacao = New PROJETOBASE.RJLabel()
        Me.RjLabel54 = New PROJETOBASE.RJLabel()
        Me.RjLabel23 = New PROJETOBASE.RJLabel()
        Me.LblLeituras = New PROJETOBASE.RJLabel()
        Me.LblEtiqueta = New PROJETOBASE.RJLabel()
        Me.CboDependencias = New PROJETOBASE.RJComboBox()
        Me.DgvBensPendentes = New PROJETOBASE.RJDataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbtBipar = New PROJETOBASE.RJRadioButton()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.ChkFixar = New PROJETOBASE.RJCheckBox()
        Me.RbtExcluir = New PROJETOBASE.RJRadioButton()
        Me.RbtAlterar = New PROJETOBASE.RJRadioButton()
        Me.RbtTransferir = New PROJETOBASE.RJRadioButton()
        Me.RbtNovo = New PROJETOBASE.RJRadioButton()
        Me.RbtImprimir = New PROJETOBASE.RJRadioButton()
        Me.LblTotalListado = New PROJETOBASE.RJLabel()
        Me.ChkTodasPendencias = New PROJETOBASE.RJCheckBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.LblInfoImprimir = New PROJETOBASE.RJLabel()
        Me.LblInfoAlterar = New PROJETOBASE.RJLabel()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.LblInfoNovo = New PROJETOBASE.RJLabel()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.LblInfoExcluir = New PROJETOBASE.RJLabel()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.LblInfoTransferir = New PROJETOBASE.RJLabel()
        Me.RjLabel10 = New PROJETOBASE.RJLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChkResolvidas = New PROJETOBASE.RJCheckBox()
        Me._pnlClientArea.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvBensPendentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.ChkResolvidas)
        Me._pnlClientArea.Controls.Add(Me.GroupBox1)
        Me._pnlClientArea.Controls.Add(Me.ChkTodasPendencias)
        Me._pnlClientArea.Controls.Add(Me.GroupBox3)
        Me._pnlClientArea.Controls.Add(Me.GroupBox2)
        Me._pnlClientArea.Controls.Add(Me.LblTotalListado)
        Me._pnlClientArea.Controls.Add(Me.RjButton1)
        Me._pnlClientArea.Controls.Add(Me.RjLabel21)
        Me._pnlClientArea.Controls.Add(Me.TxtPesquisar)
        Me._pnlClientArea.Controls.Add(Me.BtnLimparFiltros)
        Me._pnlClientArea.Controls.Add(Me.DgvBensPendentes)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'BtnLimparFiltros
        '
        Me.BtnLimparFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnLimparFiltros.BorderRadius = 5
        Me.BtnLimparFiltros.BorderSize = 0
        Me.BtnLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimparFiltros.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnLimparFiltros.FlatAppearance.BorderSize = 0
        Me.BtnLimparFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnLimparFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnLimparFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimparFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimparFiltros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BtnLimparFiltros.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward
        Me.BtnLimparFiltros.IconColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BtnLimparFiltros.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLimparFiltros.IconSize = 24
        Me.BtnLimparFiltros.Location = New System.Drawing.Point(586, 18)
        Me.BtnLimparFiltros.Name = "BtnLimparFiltros"
        Me.BtnLimparFiltros.Size = New System.Drawing.Size(28, 23)
        Me.BtnLimparFiltros.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BtnLimparFiltros.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnLimparFiltros.TabIndex = 139
        Me.BtnLimparFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimparFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimparFiltros.UseVisualStyleBackColor = False
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar._Customizable = False
        Me.TxtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtPesquisar.BorderRadius = 0
        Me.TxtPesquisar.BorderSize = 1
        Me.TxtPesquisar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TxtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.Location = New System.Drawing.Point(85, 14)
        Me.TxtPesquisar.MultiLine = False
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtPesquisar.PasswordChar = False
        Me.TxtPesquisar.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtPesquisar.PlaceHolderText = "Digite aqui..."
        Me.TxtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtPesquisar.Size = New System.Drawing.Size(264, 29)
        Me.TxtPesquisar.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.TxtPesquisar.TabIndex = 138
        '
        'RjLabel21
        '
        Me.RjLabel21.AutoSize = True
        Me.RjLabel21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel21.LinkLabel = False
        Me.RjLabel21.Location = New System.Drawing.Point(9, 24)
        Me.RjLabel21.Name = "RjLabel21"
        Me.RjLabel21.Size = New System.Drawing.Size(68, 16)
        Me.RjLabel21.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel21.TabIndex = 140
        Me.RjLabel21.Text = "Pesquisar"
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 1
        Me.RjButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjButton1.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.RjButton1.Enabled = False
        Me.RjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.RjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.RjButton1.IconColor = System.Drawing.Color.White
        Me.RjButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton1.IconSize = 24
        Me.RjButton1.Location = New System.Drawing.Point(346, 14)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(34, 29)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 151
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TxtObservacoes)
        Me.GroupBox3.Controls.Add(Me.TxtBemMovel)
        Me.GroupBox3.Controls.Add(Me.RjLabel35)
        Me.GroupBox3.Controls.Add(Me.RjLabel45)
        Me.GroupBox3.Controls.Add(Me.RjLabel52)
        Me.GroupBox3.Controls.Add(Me.RjLabel50)
        Me.GroupBox3.Controls.Add(Me.LblSituacao)
        Me.GroupBox3.Controls.Add(Me.RjLabel54)
        Me.GroupBox3.Controls.Add(Me.RjLabel23)
        Me.GroupBox3.Controls.Add(Me.LblLeituras)
        Me.GroupBox3.Controls.Add(Me.LblEtiqueta)
        Me.GroupBox3.Controls.Add(Me.CboDependencias)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Location = New System.Drawing.Point(622, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 282)
        Me.GroupBox3.TabIndex = 159
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalhes"
        '
        'TxtObservacoes
        '
        Me.TxtObservacoes._Customizable = True
        Me.TxtObservacoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtObservacoes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtObservacoes.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtObservacoes.BorderRadius = 0
        Me.TxtObservacoes.BorderSize = 1
        Me.TxtObservacoes.Enabled = False
        Me.TxtObservacoes.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TxtObservacoes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.TxtObservacoes.Location = New System.Drawing.Point(6, 217)
        Me.TxtObservacoes.MultiLine = True
        Me.TxtObservacoes.Name = "TxtObservacoes"
        Me.TxtObservacoes.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtObservacoes.PasswordChar = False
        Me.TxtObservacoes.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtObservacoes.PlaceHolderText = "Digite uma observação"
        Me.TxtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtObservacoes.Size = New System.Drawing.Size(314, 55)
        Me.TxtObservacoes.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.TxtObservacoes.TabIndex = 143
        '
        'TxtBemMovel
        '
        Me.TxtBemMovel._Customizable = True
        Me.TxtBemMovel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtBemMovel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBemMovel.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtBemMovel.BorderRadius = 0
        Me.TxtBemMovel.BorderSize = 1
        Me.TxtBemMovel.Enabled = False
        Me.TxtBemMovel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TxtBemMovel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.TxtBemMovel.Location = New System.Drawing.Point(6, 89)
        Me.TxtBemMovel.MultiLine = True
        Me.TxtBemMovel.Name = "TxtBemMovel"
        Me.TxtBemMovel.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtBemMovel.PasswordChar = False
        Me.TxtBemMovel.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtBemMovel.PlaceHolderText = "Descrição do Bem"
        Me.TxtBemMovel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBemMovel.Size = New System.Drawing.Size(314, 55)
        Me.TxtBemMovel.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.TxtBemMovel.TabIndex = 144
        Me.TxtBemMovel.Tag = "BEM MÓVEL"
        '
        'RjLabel35
        '
        Me.RjLabel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel35.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel35.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel35.LinkLabel = False
        Me.RjLabel35.Location = New System.Drawing.Point(6, 151)
        Me.RjLabel35.Name = "RjLabel35"
        Me.RjLabel35.Size = New System.Drawing.Size(227, 18)
        Me.RjLabel35.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel35.TabIndex = 76
        Me.RjLabel35.Text = "DEPENDÊNCIA"
        Me.RjLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel45
        '
        Me.RjLabel45.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel45.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel45.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel45.LinkLabel = False
        Me.RjLabel45.Location = New System.Drawing.Point(6, 71)
        Me.RjLabel45.Name = "RjLabel45"
        Me.RjLabel45.Size = New System.Drawing.Size(314, 18)
        Me.RjLabel45.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel45.TabIndex = 76
        Me.RjLabel45.Text = "BEM MÓVEL"
        Me.RjLabel45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel52
        '
        Me.RjLabel52.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel52.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel52.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel52.LinkLabel = False
        Me.RjLabel52.Location = New System.Drawing.Point(6, 23)
        Me.RjLabel52.Name = "RjLabel52"
        Me.RjLabel52.Size = New System.Drawing.Size(183, 18)
        Me.RjLabel52.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel52.TabIndex = 76
        Me.RjLabel52.Text = "SITUAÇÃO"
        Me.RjLabel52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel50
        '
        Me.RjLabel50.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel50.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel50.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel50.LinkLabel = False
        Me.RjLabel50.Location = New System.Drawing.Point(6, 199)
        Me.RjLabel50.Name = "RjLabel50"
        Me.RjLabel50.Size = New System.Drawing.Size(314, 18)
        Me.RjLabel50.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel50.TabIndex = 76
        Me.RjLabel50.Text = "OBSERVAÇÃO"
        Me.RjLabel50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSituacao
        '
        Me.LblSituacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSituacao.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblSituacao.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblSituacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblSituacao.LinkLabel = False
        Me.LblSituacao.Location = New System.Drawing.Point(6, 41)
        Me.LblSituacao.Name = "LblSituacao"
        Me.LblSituacao.Size = New System.Drawing.Size(183, 23)
        Me.LblSituacao.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblSituacao.TabIndex = 77
        Me.LblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel54
        '
        Me.RjLabel54.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel54.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel54.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel54.LinkLabel = False
        Me.RjLabel54.Location = New System.Drawing.Point(239, 151)
        Me.RjLabel54.Name = "RjLabel54"
        Me.RjLabel54.Size = New System.Drawing.Size(81, 18)
        Me.RjLabel54.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel54.TabIndex = 76
        Me.RjLabel54.Text = "LEITURAS"
        Me.RjLabel54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel23
        '
        Me.RjLabel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel23.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel23.LinkLabel = False
        Me.RjLabel23.Location = New System.Drawing.Point(195, 23)
        Me.RjLabel23.Name = "RjLabel23"
        Me.RjLabel23.Size = New System.Drawing.Size(125, 18)
        Me.RjLabel23.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel23.TabIndex = 76
        Me.RjLabel23.Text = "ETIQUETA"
        Me.RjLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLeituras
        '
        Me.LblLeituras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblLeituras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblLeituras.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblLeituras.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblLeituras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblLeituras.LinkLabel = False
        Me.LblLeituras.Location = New System.Drawing.Point(239, 169)
        Me.LblLeituras.Name = "LblLeituras"
        Me.LblLeituras.Size = New System.Drawing.Size(81, 23)
        Me.LblLeituras.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblLeituras.TabIndex = 77
        Me.LblLeituras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEtiqueta
        '
        Me.LblEtiqueta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEtiqueta.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblEtiqueta.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblEtiqueta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblEtiqueta.LinkLabel = False
        Me.LblEtiqueta.Location = New System.Drawing.Point(195, 41)
        Me.LblEtiqueta.Name = "LblEtiqueta"
        Me.LblEtiqueta.Size = New System.Drawing.Size(125, 23)
        Me.LblEtiqueta.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblEtiqueta.TabIndex = 77
        Me.LblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboDependencias
        '
        Me.CboDependencias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboDependencias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboDependencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboDependencias.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboDependencias.BorderRadius = 0
        Me.CboDependencias.BorderSize = 1
        Me.CboDependencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboDependencias.Customizable = False
        Me.CboDependencias.DataSource = Nothing
        Me.CboDependencias.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboDependencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboDependencias.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboDependencias.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboDependencias.Location = New System.Drawing.Point(6, 167)
        Me.CboDependencias.Name = "CboDependencias"
        Me.CboDependencias.Padding = New System.Windows.Forms.Padding(2)
        Me.CboDependencias.SelectedIndex = -1
        Me.CboDependencias.SelectedItem = Nothing
        Me.CboDependencias.SelectedValue = Nothing
        Me.CboDependencias.Size = New System.Drawing.Size(227, 25)
        Me.CboDependencias.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboDependencias.TabIndex = 78
        Me.CboDependencias.Tag = "DEPENDEÊNCIA"
        Me.CboDependencias.Texts = ""
        '
        'DgvBensPendentes
        '
        Me.DgvBensPendentes.AllowUserToAddRows = False
        Me.DgvBensPendentes.AllowUserToDeleteRows = False
        Me.DgvBensPendentes.AllowUserToOrderColumns = True
        Me.DgvBensPendentes.AllowUserToResizeRows = False
        Me.DgvBensPendentes.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvBensPendentes.AlternatingRowsColorApply = False
        Me.DgvBensPendentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBensPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBensPendentes.BackgroundColor = System.Drawing.Color.White
        Me.DgvBensPendentes.BorderRadius = 5
        Me.DgvBensPendentes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvBensPendentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvBensPendentes.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvBensPendentes.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvBensPendentes.ColumnHeaderHeight = 40
        Me.DgvBensPendentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBensPendentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvBensPendentes.ColumnHeadersHeight = 40
        Me.DgvBensPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvBensPendentes.ColumnHeaderTextColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBensPendentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        Me.DgvBensPendentes.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBensPendentes.Customizable = True
        Me.DgvBensPendentes.DgvBackColor = System.Drawing.Color.White
        Me.DgvBensPendentes.EnableHeadersVisualStyles = False
        Me.DgvBensPendentes.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvBensPendentes.Location = New System.Drawing.Point(7, 58)
        Me.DgvBensPendentes.MultiSelect = False
        Me.DgvBensPendentes.Name = "DgvBensPendentes"
        Me.DgvBensPendentes.ReadOnly = True
        Me.DgvBensPendentes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvBensPendentes.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBensPendentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBensPendentes.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvBensPendentes.RowHeadersVisible = False
        Me.DgvBensPendentes.RowHeadersWidth = 25
        Me.DgvBensPendentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBensPendentes.RowHeight = 25
        Me.DgvBensPendentes.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBensPendentes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvBensPendentes.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvBensPendentes.RowTemplate.Height = 25
        Me.DgvBensPendentes.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvBensPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBensPendentes.SelectionTextColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBensPendentes.Size = New System.Drawing.Size(611, 436)
        Me.DgvBensPendentes.TabIndex = 156
        '
        'Column5
        '
        Me.Column5.HeaderText = "ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "BEM MÓVEL"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RbtBipar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.ChkFixar)
        Me.GroupBox2.Controls.Add(Me.RbtExcluir)
        Me.GroupBox2.Controls.Add(Me.RbtAlterar)
        Me.GroupBox2.Controls.Add(Me.RbtTransferir)
        Me.GroupBox2.Controls.Add(Me.RbtNovo)
        Me.GroupBox2.Controls.Add(Me.RbtImprimir)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(624, 391)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 124)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ações"
        '
        'RbtBipar
        '
        Me.RbtBipar.AutoSize = True
        Me.RbtBipar.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtBipar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtBipar.Customizable = False
        Me.RbtBipar.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtBipar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtBipar.Location = New System.Drawing.Point(205, 23)
        Me.RbtBipar.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtBipar.Name = "RbtBipar"
        Me.RbtBipar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtBipar.Size = New System.Drawing.Size(118, 21)
        Me.RbtBipar.TabIndex = 2
        Me.RbtBipar.TabStop = True
        Me.RbtBipar.Text = "Encontrado"
        Me.RbtBipar.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtBipar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 0
        Me.BtnSalvar.BorderSize = 1
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSalvar.Enabled = False
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSalvar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(150, 87)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(98, 31)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSalvar.TabIndex = 7
        Me.BtnSalvar.Text = "SALVAR"
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'ChkFixar
        '
        Me.ChkFixar.AutoSize = True
        Me.ChkFixar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkFixar.BorderSize = 1
        Me.ChkFixar.Check = False
        Me.ChkFixar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkFixar.Customizable = False
        Me.ChkFixar.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.ChkFixar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkFixar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkFixar.Location = New System.Drawing.Point(77, 94)
        Me.ChkFixar.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkFixar.Name = "ChkFixar"
        Me.ChkFixar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkFixar.Size = New System.Drawing.Size(67, 21)
        Me.ChkFixar.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkFixar.TabIndex = 6
        Me.ChkFixar.Text = "Fixar"
        Me.ChkFixar.UseVisualStyleBackColor = True
        '
        'RbtExcluir
        '
        Me.RbtExcluir.AutoSize = True
        Me.RbtExcluir.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtExcluir.Customizable = False
        Me.RbtExcluir.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtExcluir.Location = New System.Drawing.Point(205, 50)
        Me.RbtExcluir.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtExcluir.Name = "RbtExcluir"
        Me.RbtExcluir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtExcluir.Size = New System.Drawing.Size(84, 21)
        Me.RbtExcluir.TabIndex = 5
        Me.RbtExcluir.TabStop = True
        Me.RbtExcluir.Text = "Excluir"
        Me.RbtExcluir.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtExcluir.UseVisualStyleBackColor = True
        '
        'RbtAlterar
        '
        Me.RbtAlterar.AutoSize = True
        Me.RbtAlterar.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtAlterar.Customizable = False
        Me.RbtAlterar.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtAlterar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtAlterar.Location = New System.Drawing.Point(7, 50)
        Me.RbtAlterar.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtAlterar.Name = "RbtAlterar"
        Me.RbtAlterar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtAlterar.Size = New System.Drawing.Size(85, 21)
        Me.RbtAlterar.TabIndex = 3
        Me.RbtAlterar.TabStop = True
        Me.RbtAlterar.Text = "Alterar"
        Me.RbtAlterar.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtAlterar.UseVisualStyleBackColor = True
        '
        'RbtTransferir
        '
        Me.RbtTransferir.AutoSize = True
        Me.RbtTransferir.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtTransferir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtTransferir.Customizable = False
        Me.RbtTransferir.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtTransferir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtTransferir.Location = New System.Drawing.Point(93, 50)
        Me.RbtTransferir.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtTransferir.Name = "RbtTransferir"
        Me.RbtTransferir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtTransferir.Size = New System.Drawing.Size(105, 21)
        Me.RbtTransferir.TabIndex = 4
        Me.RbtTransferir.TabStop = True
        Me.RbtTransferir.Text = "Transferir"
        Me.RbtTransferir.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtTransferir.UseVisualStyleBackColor = True
        '
        'RbtNovo
        '
        Me.RbtNovo.AutoSize = True
        Me.RbtNovo.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtNovo.Customizable = False
        Me.RbtNovo.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtNovo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtNovo.Location = New System.Drawing.Point(7, 23)
        Me.RbtNovo.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtNovo.Name = "RbtNovo"
        Me.RbtNovo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtNovo.Size = New System.Drawing.Size(72, 21)
        Me.RbtNovo.TabIndex = 0
        Me.RbtNovo.TabStop = True
        Me.RbtNovo.Text = "Novo"
        Me.RbtNovo.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtNovo.UseVisualStyleBackColor = True
        '
        'RbtImprimir
        '
        Me.RbtImprimir.AutoSize = True
        Me.RbtImprimir.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtImprimir.Customizable = False
        Me.RbtImprimir.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtImprimir.Location = New System.Drawing.Point(93, 23)
        Me.RbtImprimir.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtImprimir.Name = "RbtImprimir"
        Me.RbtImprimir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtImprimir.Size = New System.Drawing.Size(98, 21)
        Me.RbtImprimir.TabIndex = 1
        Me.RbtImprimir.TabStop = True
        Me.RbtImprimir.Text = "Imprimir"
        Me.RbtImprimir.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtImprimir.UseVisualStyleBackColor = True
        '
        'LblTotalListado
        '
        Me.LblTotalListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalListado.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblTotalListado.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblTotalListado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblTotalListado.LinkLabel = False
        Me.LblTotalListado.Location = New System.Drawing.Point(398, 497)
        Me.LblTotalListado.Name = "LblTotalListado"
        Me.LblTotalListado.Size = New System.Drawing.Size(220, 18)
        Me.LblTotalListado.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblTotalListado.TabIndex = 157
        Me.LblTotalListado.Text = "0"
        Me.LblTotalListado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkTodasPendencias
        '
        Me.ChkTodasPendencias.AutoSize = True
        Me.ChkTodasPendencias.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkTodasPendencias.BorderSize = 1
        Me.ChkTodasPendencias.Check = False
        Me.ChkTodasPendencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkTodasPendencias.Customizable = False
        Me.ChkTodasPendencias.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.ChkTodasPendencias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkTodasPendencias.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkTodasPendencias.Location = New System.Drawing.Point(401, 31)
        Me.ChkTodasPendencias.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkTodasPendencias.Name = "ChkTodasPendencias"
        Me.ChkTodasPendencias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkTodasPendencias.Size = New System.Drawing.Size(154, 21)
        Me.ChkTodasPendencias.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkTodasPendencias.TabIndex = 161
        Me.ChkTodasPendencias.Text = "Todas Pendencias"
        Me.ChkTodasPendencias.UseVisualStyleBackColor = True
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(106, 17)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(67, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel1.TabIndex = 78
        Me.RjLabel1.Text = "IMPRIMIR"
        Me.RjLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblInfoImprimir
        '
        Me.LblInfoImprimir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblInfoImprimir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblInfoImprimir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfoImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.LblInfoImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblInfoImprimir.LinkLabel = False
        Me.LblInfoImprimir.Location = New System.Drawing.Point(106, 33)
        Me.LblInfoImprimir.Name = "LblInfoImprimir"
        Me.LblInfoImprimir.Size = New System.Drawing.Size(67, 20)
        Me.LblInfoImprimir.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblInfoImprimir.TabIndex = 78
        Me.LblInfoImprimir.Text = "0"
        Me.LblInfoImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblInfoAlterar
        '
        Me.LblInfoAlterar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblInfoAlterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblInfoAlterar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfoAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.LblInfoAlterar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblInfoAlterar.LinkLabel = False
        Me.LblInfoAlterar.Location = New System.Drawing.Point(179, 34)
        Me.LblInfoAlterar.Name = "LblInfoAlterar"
        Me.LblInfoAlterar.Size = New System.Drawing.Size(70, 20)
        Me.LblInfoAlterar.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblInfoAlterar.TabIndex = 162
        Me.LblInfoAlterar.Text = "0"
        Me.LblInfoAlterar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(179, 18)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(70, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel4.TabIndex = 163
        Me.RjLabel4.Text = "ALTERAR"
        Me.RjLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblInfoNovo
        '
        Me.LblInfoNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblInfoNovo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblInfoNovo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfoNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.LblInfoNovo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblInfoNovo.LinkLabel = False
        Me.LblInfoNovo.Location = New System.Drawing.Point(9, 33)
        Me.LblInfoNovo.Name = "LblInfoNovo"
        Me.LblInfoNovo.Size = New System.Drawing.Size(91, 20)
        Me.LblInfoNovo.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblInfoNovo.TabIndex = 164
        Me.LblInfoNovo.Text = "0"
        Me.LblInfoNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(9, 17)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(91, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel6.TabIndex = 165
        Me.RjLabel6.Text = "CADASTRAR"
        Me.RjLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblInfoExcluir
        '
        Me.LblInfoExcluir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblInfoExcluir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblInfoExcluir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfoExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.LblInfoExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblInfoExcluir.LinkLabel = False
        Me.LblInfoExcluir.Location = New System.Drawing.Point(255, 34)
        Me.LblInfoExcluir.Name = "LblInfoExcluir"
        Me.LblInfoExcluir.Size = New System.Drawing.Size(63, 20)
        Me.LblInfoExcluir.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblInfoExcluir.TabIndex = 166
        Me.LblInfoExcluir.Text = "0"
        Me.LblInfoExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(255, 18)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(63, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel8.TabIndex = 167
        Me.RjLabel8.Text = "EXCLUIR"
        Me.RjLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblInfoTransferir
        '
        Me.LblInfoTransferir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblInfoTransferir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblInfoTransferir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblInfoTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.LblInfoTransferir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblInfoTransferir.LinkLabel = False
        Me.LblInfoTransferir.Location = New System.Drawing.Point(179, 64)
        Me.LblInfoTransferir.Name = "LblInfoTransferir"
        Me.LblInfoTransferir.Size = New System.Drawing.Size(69, 20)
        Me.LblInfoTransferir.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblInfoTransferir.TabIndex = 168
        Me.LblInfoTransferir.Text = "0"
        Me.LblInfoTransferir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RjLabel10
        '
        Me.RjLabel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel10.LinkLabel = False
        Me.RjLabel10.Location = New System.Drawing.Point(78, 64)
        Me.RjLabel10.Name = "RjLabel10"
        Me.RjLabel10.Size = New System.Drawing.Size(101, 20)
        Me.RjLabel10.Style = PROJETOBASE.LabelStyle.BarText
        Me.RjLabel10.TabIndex = 169
        Me.RjLabel10.Text = "TRANSFERIR"
        Me.RjLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RjLabel1)
        Me.GroupBox1.Controls.Add(Me.LblInfoTransferir)
        Me.GroupBox1.Controls.Add(Me.LblInfoImprimir)
        Me.GroupBox1.Controls.Add(Me.RjLabel4)
        Me.GroupBox1.Controls.Add(Me.LblInfoExcluir)
        Me.GroupBox1.Controls.Add(Me.RjLabel10)
        Me.GroupBox1.Controls.Add(Me.LblInfoAlterar)
        Me.GroupBox1.Controls.Add(Me.RjLabel6)
        Me.GroupBox1.Controls.Add(Me.LblInfoNovo)
        Me.GroupBox1.Controls.Add(Me.RjLabel8)
        Me.GroupBox1.Location = New System.Drawing.Point(622, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 97)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ChkResolvidas
        '
        Me.ChkResolvidas.AutoSize = True
        Me.ChkResolvidas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkResolvidas.BorderSize = 1
        Me.ChkResolvidas.Check = False
        Me.ChkResolvidas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkResolvidas.Customizable = False
        Me.ChkResolvidas.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.ChkResolvidas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkResolvidas.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkResolvidas.Location = New System.Drawing.Point(401, 6)
        Me.ChkResolvidas.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkResolvidas.Name = "ChkResolvidas"
        Me.ChkResolvidas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkResolvidas.Size = New System.Drawing.Size(104, 21)
        Me.ChkResolvidas.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkResolvidas.TabIndex = 171
        Me.ChkResolvidas.Text = "Resolvidos"
        Me.ChkResolvidas.UseVisualStyleBackColor = True
        '
        'FormInventarioPendencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.CancelButton = Me.btnClose
        Me.Caption = "Pendências"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.DisplayMinimizeButton = False
        Me.FormIcon = FontAwesome.Sharp.IconChar.ClipboardQuestion
        Me.Name = "FormInventarioPendencias"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Pendências"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvBensPendentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RjLabel21 As RJLabel
    Friend WithEvents TxtPesquisar As RJTextBox
    Friend WithEvents BtnLimparFiltros As RJButton
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RjLabel45 As RJLabel
    Friend WithEvents RjLabel52 As RJLabel
    Friend WithEvents RjLabel50 As RJLabel
    Friend WithEvents RjLabel35 As RJLabel
    Friend WithEvents LblSituacao As RJLabel
    Friend WithEvents RjLabel54 As RJLabel
    Friend WithEvents RjLabel23 As RJLabel
    Friend WithEvents DgvBensPendentes As RJDataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSalvar As RJButton
    Friend WithEvents ChkFixar As RJCheckBox
    Friend WithEvents RbtExcluir As RJRadioButton
    Friend WithEvents RbtAlterar As RJRadioButton
    Friend WithEvents RbtTransferir As RJRadioButton
    Friend WithEvents RbtNovo As RJRadioButton
    Friend WithEvents RbtImprimir As RJRadioButton
    Friend WithEvents LblTotalListado As RJLabel
    Friend WithEvents ChkTodasPendencias As RJCheckBox
    Friend WithEvents LblInfoImprimir As RJLabel
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents LblInfoExcluir As RJLabel
    Friend WithEvents RjLabel8 As RJLabel
    Friend WithEvents LblInfoNovo As RJLabel
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents LblInfoAlterar As RJLabel
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents LblInfoTransferir As RJLabel
    Friend WithEvents RjLabel10 As RJLabel
    Friend WithEvents TxtObservacoes As RJTextBox
    Friend WithEvents CboDependencias As RJComboBox
    Friend WithEvents LblEtiqueta As RJLabel
    Friend WithEvents LblLeituras As RJLabel
    Friend WithEvents TxtBemMovel As RJTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents RbtBipar As RJRadioButton
    Friend WithEvents ChkResolvidas As RJCheckBox
End Class
