<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits PROJETOBASE.RJChildForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.BtnReset = New PROJETOBASE.RJButton()
        Me.CmbSetor = New PROJETOBASE.RJComboBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.CmbAno = New PROJETOBASE.RJComboBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me.LblTitulo = New PROJETOBASE.RJLabel()
        Me.RjPanel3 = New PROJETOBASE.RJPanel()
        Me.LblSetores = New PROJETOBASE.RJLabel()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.RjPanel4 = New PROJETOBASE.RJPanel()
        Me.LblIgrejasAtivas = New PROJETOBASE.RJLabel()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.RjPanel5 = New PROJETOBASE.RJPanel()
        Me.LblIgrejasInativas = New PROJETOBASE.RJLabel()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.RjPanel6 = New PROJETOBASE.RJPanel()
        Me.LblDepartamentos = New PROJETOBASE.RJLabel()
        Me.RjLabel11 = New PROJETOBASE.RJLabel()
        Me.RjPanel7 = New PROJETOBASE.RJPanel()
        Me.LblRealizadosTotal = New PROJETOBASE.RJLabel()
        Me.LblRealizadosPercent = New PROJETOBASE.RJLabel()
        Me.RjLabel13 = New PROJETOBASE.RJLabel()
        Me.ChartIgrejasPorSetor = New PROJETOBASE.RJChart()
        Me.chartInventarios = New PROJETOBASE.RJChart()
        Me.PanelMargin = New System.Windows.Forms.Panel()
        Me.LblCliqueAqui = New PROJETOBASE.RJLabel()
        Me.RjLabel17 = New PROJETOBASE.RJLabel()
        Me.DgvUltimosInventarios = New PROJETOBASE.RJDataGridView()
        Me.RjPanel8 = New PROJETOBASE.RJPanel()
        Me.RjLabel15 = New PROJETOBASE.RJLabel()
        Me.ChartInventariosPorSetor = New PROJETOBASE.RJChart()
        Me.DgvSituacaoPorSetor = New PROJETOBASE.RJDataGridView()
        Me.RjPanel9 = New PROJETOBASE.RJPanel()
        Me.RjLabel16 = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        Me.RjPanel2.SuspendLayout()
        Me.RjPanel3.SuspendLayout()
        Me.RjPanel4.SuspendLayout()
        Me.RjPanel5.SuspendLayout()
        Me.RjPanel6.SuspendLayout()
        Me.RjPanel7.SuspendLayout()
        CType(Me.ChartIgrejasPorSetor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMargin.SuspendLayout()
        CType(Me.DgvUltimosInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RjPanel8.SuspendLayout()
        CType(Me.ChartInventariosPorSetor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSituacaoPorSetor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RjPanel9.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.PanelMargin)
        Me._pnlClientArea.Controls.Add(Me.RjPanel9)
        Me._pnlClientArea.Controls.Add(Me.RjPanel8)
        Me._pnlClientArea.Controls.Add(Me.DgvSituacaoPorSetor)
        Me._pnlClientArea.Controls.Add(Me.DgvUltimosInventarios)
        Me._pnlClientArea.Controls.Add(Me.ChartInventariosPorSetor)
        Me._pnlClientArea.Controls.Add(Me.chartInventarios)
        Me._pnlClientArea.Controls.Add(Me.ChartIgrejasPorSetor)
        Me._pnlClientArea.Controls.Add(Me.RjPanel7)
        Me._pnlClientArea.Controls.Add(Me.RjPanel6)
        Me._pnlClientArea.Controls.Add(Me.RjPanel5)
        Me._pnlClientArea.Controls.Add(Me.RjPanel4)
        Me._pnlClientArea.Controls.Add(Me.RjPanel3)
        Me._pnlClientArea.Controls.Add(Me.RjPanel2)
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 746)
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.BtnReset)
        Me.RjPanel1.Controls.Add(Me.CmbSetor)
        Me.RjPanel1.Controls.Add(Me.RjLabel3)
        Me.RjPanel1.Controls.Add(Me.CmbAno)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Location = New System.Drawing.Point(13, 8)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(192, 121)
        Me.RjPanel1.TabIndex = 0
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnReset.BorderRadius = 0
        Me.BtnReset.BorderSize = 0
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnReset.FlatAppearance.BorderSize = 0
        Me.BtnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnReset.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward
        Me.BtnReset.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnReset.IconSize = 20
        Me.BtnReset.Location = New System.Drawing.Point(164, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(21, 21)
        Me.BtnReset.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnReset.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnReset.TabIndex = 11
        Me.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'CmbSetor
        '
        Me.CmbSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CmbSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CmbSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CmbSetor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CmbSetor.BorderRadius = 0
        Me.CmbSetor.BorderSize = 1
        Me.CmbSetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbSetor.Customizable = False
        Me.CmbSetor.DataSource = Nothing
        Me.CmbSetor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbSetor.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CmbSetor.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CmbSetor.Location = New System.Drawing.Point(9, 79)
        Me.CmbSetor.Name = "CmbSetor"
        Me.CmbSetor.Padding = New System.Windows.Forms.Padding(1)
        Me.CmbSetor.SelectedIndex = -1
        Me.CmbSetor.SelectedItem = Nothing
        Me.CmbSetor.SelectedValue = Nothing
        Me.CmbSetor.Size = New System.Drawing.Size(175, 32)
        Me.CmbSetor.Style = PROJETOBASE.ControlStyle.Glass
        Me.CmbSetor.TabIndex = 3
        Me.CmbSetor.Texts = ""
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(6, 60)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(130, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 2
        Me.RjLabel3.Text = "Selecione o Setor:"
        '
        'CmbAno
        '
        Me.CmbAno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CmbAno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CmbAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CmbAno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CmbAno.BorderRadius = 0
        Me.CmbAno.BorderSize = 1
        Me.CmbAno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbAno.Customizable = False
        Me.CmbAno.DataSource = Nothing
        Me.CmbAno.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CmbAno.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CmbAno.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CmbAno.Items.AddRange(New Object() {"Hoy", "Ultimos 7 dias", "Este mes", "Ultimos 30 dias", "Este año", "Personalizado"})
        Me.CmbAno.Location = New System.Drawing.Point(9, 25)
        Me.CmbAno.Name = "CmbAno"
        Me.CmbAno.Padding = New System.Windows.Forms.Padding(1)
        Me.CmbAno.SelectedIndex = -1
        Me.CmbAno.SelectedItem = Nothing
        Me.CmbAno.SelectedValue = Nothing
        Me.CmbAno.Size = New System.Drawing.Size(175, 32)
        Me.CmbAno.Style = PROJETOBASE.ControlStyle.Glass
        Me.CmbAno.TabIndex = 1
        Me.CmbAno.Texts = ""
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(6, 6)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(119, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 0
        Me.RjLabel2.Text = "Selecione o Ano:"
        '
        'RjPanel2
        '
        Me.RjPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel2.BorderRadius = 0
        Me.RjPanel2.Controls.Add(Me.LblTitulo)
        Me.RjPanel2.Customizable = False
        Me.RjPanel2.Location = New System.Drawing.Point(211, 8)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(724, 35)
        Me.RjPanel2.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblTitulo.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblTitulo.LinkLabel = False
        Me.LblTitulo.Location = New System.Drawing.Point(6, 8)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(713, 18)
        Me.LblTitulo.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Análise de Inventários para o ano de 2024"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjPanel3
        '
        Me.RjPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel3.BorderRadius = 0
        Me.RjPanel3.Controls.Add(Me.LblSetores)
        Me.RjPanel3.Controls.Add(Me.RjLabel4)
        Me.RjPanel3.Customizable = False
        Me.RjPanel3.Location = New System.Drawing.Point(211, 49)
        Me.RjPanel3.Name = "RjPanel3"
        Me.RjPanel3.Size = New System.Drawing.Size(140, 80)
        Me.RjPanel3.TabIndex = 2
        '
        'LblSetores
        '
        Me.LblSetores.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblSetores.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblSetores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblSetores.LinkLabel = False
        Me.LblSetores.Location = New System.Drawing.Point(3, 38)
        Me.LblSetores.Name = "LblSetores"
        Me.LblSetores.Size = New System.Drawing.Size(134, 23)
        Me.LblSetores.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblSetores.TabIndex = 1
        Me.LblSetores.Text = "0"
        Me.LblSetores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(6, 6)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(66, 18)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel4.TabIndex = 0
        Me.RjLabel4.Text = "Setores"
        '
        'RjPanel4
        '
        Me.RjPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel4.BorderRadius = 0
        Me.RjPanel4.Controls.Add(Me.LblIgrejasAtivas)
        Me.RjPanel4.Controls.Add(Me.RjLabel7)
        Me.RjPanel4.Customizable = False
        Me.RjPanel4.Location = New System.Drawing.Point(357, 49)
        Me.RjPanel4.Name = "RjPanel4"
        Me.RjPanel4.Size = New System.Drawing.Size(140, 80)
        Me.RjPanel4.TabIndex = 3
        '
        'LblIgrejasAtivas
        '
        Me.LblIgrejasAtivas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblIgrejasAtivas.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblIgrejasAtivas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblIgrejasAtivas.LinkLabel = False
        Me.LblIgrejasAtivas.Location = New System.Drawing.Point(46, 38)
        Me.LblIgrejasAtivas.Name = "LblIgrejasAtivas"
        Me.LblIgrejasAtivas.Size = New System.Drawing.Size(49, 23)
        Me.LblIgrejasAtivas.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblIgrejasAtivas.TabIndex = 3
        Me.LblIgrejasAtivas.Text = "0"
        Me.LblIgrejasAtivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(6, 6)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(109, 18)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel7.TabIndex = 2
        Me.RjLabel7.Text = "Igrejas Ativas"
        '
        'RjPanel5
        '
        Me.RjPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel5.BorderRadius = 0
        Me.RjPanel5.Controls.Add(Me.LblIgrejasInativas)
        Me.RjPanel5.Controls.Add(Me.RjLabel9)
        Me.RjPanel5.Customizable = False
        Me.RjPanel5.Location = New System.Drawing.Point(503, 49)
        Me.RjPanel5.Name = "RjPanel5"
        Me.RjPanel5.Size = New System.Drawing.Size(140, 80)
        Me.RjPanel5.TabIndex = 3
        '
        'LblIgrejasInativas
        '
        Me.LblIgrejasInativas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblIgrejasInativas.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblIgrejasInativas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblIgrejasInativas.LinkLabel = False
        Me.LblIgrejasInativas.Location = New System.Drawing.Point(3, 38)
        Me.LblIgrejasInativas.Name = "LblIgrejasInativas"
        Me.LblIgrejasInativas.Size = New System.Drawing.Size(134, 23)
        Me.LblIgrejasInativas.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblIgrejasInativas.TabIndex = 3
        Me.LblIgrejasInativas.Text = "0"
        Me.LblIgrejasInativas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(4, 6)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(122, 18)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel9.TabIndex = 2
        Me.RjLabel9.Text = "Igrejas Inativas"
        '
        'RjPanel6
        '
        Me.RjPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel6.BorderRadius = 0
        Me.RjPanel6.Controls.Add(Me.LblDepartamentos)
        Me.RjPanel6.Controls.Add(Me.RjLabel11)
        Me.RjPanel6.Customizable = False
        Me.RjPanel6.Location = New System.Drawing.Point(649, 49)
        Me.RjPanel6.Name = "RjPanel6"
        Me.RjPanel6.Size = New System.Drawing.Size(140, 80)
        Me.RjPanel6.TabIndex = 3
        '
        'LblDepartamentos
        '
        Me.LblDepartamentos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblDepartamentos.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblDepartamentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblDepartamentos.LinkLabel = False
        Me.LblDepartamentos.Location = New System.Drawing.Point(39, 38)
        Me.LblDepartamentos.Name = "LblDepartamentos"
        Me.LblDepartamentos.Size = New System.Drawing.Size(62, 23)
        Me.LblDepartamentos.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblDepartamentos.TabIndex = 3
        Me.LblDepartamentos.Text = "0"
        Me.LblDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel11
        '
        Me.RjLabel11.AutoSize = True
        Me.RjLabel11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel11.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel11.LinkLabel = False
        Me.RjLabel11.Location = New System.Drawing.Point(6, 6)
        Me.RjLabel11.Name = "RjLabel11"
        Me.RjLabel11.Size = New System.Drawing.Size(124, 18)
        Me.RjLabel11.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel11.TabIndex = 2
        Me.RjLabel11.Text = "Departamentos"
        '
        'RjPanel7
        '
        Me.RjPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel7.BorderRadius = 0
        Me.RjPanel7.Controls.Add(Me.LblRealizadosTotal)
        Me.RjPanel7.Controls.Add(Me.LblRealizadosPercent)
        Me.RjPanel7.Controls.Add(Me.RjLabel13)
        Me.RjPanel7.Customizable = False
        Me.RjPanel7.Location = New System.Drawing.Point(795, 49)
        Me.RjPanel7.Name = "RjPanel7"
        Me.RjPanel7.Size = New System.Drawing.Size(140, 80)
        Me.RjPanel7.TabIndex = 3
        '
        'LblRealizadosTotal
        '
        Me.LblRealizadosTotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblRealizadosTotal.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblRealizadosTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblRealizadosTotal.LinkLabel = False
        Me.LblRealizadosTotal.Location = New System.Drawing.Point(4, 38)
        Me.LblRealizadosTotal.Name = "LblRealizadosTotal"
        Me.LblRealizadosTotal.Size = New System.Drawing.Size(64, 23)
        Me.LblRealizadosTotal.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblRealizadosTotal.TabIndex = 3
        Me.LblRealizadosTotal.Text = "0"
        Me.LblRealizadosTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRealizadosPercent
        '
        Me.LblRealizadosPercent.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblRealizadosPercent.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.LblRealizadosPercent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblRealizadosPercent.LinkLabel = False
        Me.LblRealizadosPercent.Location = New System.Drawing.Point(73, 38)
        Me.LblRealizadosPercent.Name = "LblRealizadosPercent"
        Me.LblRealizadosPercent.Size = New System.Drawing.Size(64, 23)
        Me.LblRealizadosPercent.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblRealizadosPercent.TabIndex = 3
        Me.LblRealizadosPercent.Text = "%"
        Me.LblRealizadosPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel13
        '
        Me.RjLabel13.AutoSize = True
        Me.RjLabel13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel13.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel13.LinkLabel = False
        Me.RjLabel13.Location = New System.Drawing.Point(6, 6)
        Me.RjLabel13.Name = "RjLabel13"
        Me.RjLabel13.Size = New System.Drawing.Size(91, 18)
        Me.RjLabel13.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel13.TabIndex = 2
        Me.RjLabel13.Text = "Inventários"
        '
        'ChartIgrejasPorSetor
        '
        Me.ChartIgrejasPorSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        ChartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea3.AxisX.LineWidth = 2
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea3.AxisX.MajorTickMark.LineWidth = 2
        ChartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        ChartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea3.AxisY.LineWidth = 2
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea3.AxisY.MajorTickMark.LineWidth = 2
        ChartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.ChartIgrejasPorSetor.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Legend3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.ChartIgrejasPorSetor.Legends.Add(Legend3)
        Me.ChartIgrejasPorSetor.Location = New System.Drawing.Point(13, 135)
        Me.ChartIgrejasPorSetor.Name = "ChartIgrejasPorSetor"
        Me.ChartIgrejasPorSetor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series4.CustomProperties = "PieLabelStyle=Disabled"
        Series4.LabelForeColor = System.Drawing.Color.White
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.ChartIgrejasPorSetor.Series.Add(Series4)
        Me.ChartIgrejasPorSetor.Size = New System.Drawing.Size(380, 255)
        Me.ChartIgrejasPorSetor.TabIndex = 5
        Me.ChartIgrejasPorSetor.Text = "Igrejas por Setor"
        Title3.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Title3.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(86, Byte), Integer))
        Title3.Name = "Title1"
        Title3.Text = "Igrejas por Setor"
        Me.ChartIgrejasPorSetor.Titles.Add(Title3)
        '
        'chartInventarios
        '
        Me.chartInventarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartInventarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        ChartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea2.AxisX.LineWidth = 2
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea2.AxisX.MajorTickMark.LineWidth = 2
        ChartArea2.AxisX.Minimum = 1.0R
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        ChartArea2.AxisY.LabelStyle.Format = "${0:0,}K"
        ChartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea2.AxisY.LineWidth = 2
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea2.AxisY.MajorTickMark.LineWidth = 2
        ChartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.chartInventarios.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.chartInventarios.Legends.Add(Legend2)
        Me.chartInventarios.Location = New System.Drawing.Point(13, 662)
        Me.chartInventarios.Name = "chartInventarios"
        Series2.ChartArea = "ChartArea1"
        Series2.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Series2.Legend = "Legend1"
        Series2.LegendText = "Realizados em 2024"
        Series2.Name = "Series1"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Series3.Legend = "Legend1"
        Series3.LegendText = "Realizados em 2023"
        Series3.Name = "Series2"
        Me.chartInventarios.Series.Add(Series2)
        Me.chartInventarios.Series.Add(Series3)
        Me.chartInventarios.Size = New System.Drawing.Size(919, 93)
        Me.chartInventarios.TabIndex = 6
        Me.chartInventarios.Text = "RjChart1"
        Title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Title2.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(86, Byte), Integer))
        Title2.Name = "Title1"
        Title2.Text = "Inventários"
        Me.chartInventarios.Titles.Add(Title2)
        '
        'PanelMargin
        '
        Me.PanelMargin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMargin.BackColor = System.Drawing.Color.Transparent
        Me.PanelMargin.Controls.Add(Me.LblCliqueAqui)
        Me.PanelMargin.Controls.Add(Me.RjLabel17)
        Me.PanelMargin.Location = New System.Drawing.Point(13, 726)
        Me.PanelMargin.Name = "PanelMargin"
        Me.PanelMargin.Size = New System.Drawing.Size(922, 26)
        Me.PanelMargin.TabIndex = 8
        '
        'LblCliqueAqui
        '
        Me.LblCliqueAqui.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCliqueAqui.BackColor = System.Drawing.Color.Transparent
        Me.LblCliqueAqui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCliqueAqui.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.LblCliqueAqui.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblCliqueAqui.LinkLabel = True
        Me.LblCliqueAqui.Location = New System.Drawing.Point(594, 4)
        Me.LblCliqueAqui.Name = "LblCliqueAqui"
        Me.LblCliqueAqui.Size = New System.Drawing.Size(53, 18)
        Me.LblCliqueAqui.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblCliqueAqui.TabIndex = 2
        Me.LblCliqueAqui.Text = "aqui"
        Me.LblCliqueAqui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RjLabel17
        '
        Me.RjLabel17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjLabel17.BackColor = System.Drawing.Color.Transparent
        Me.RjLabel17.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel17.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel17.LinkLabel = False
        Me.RjLabel17.Location = New System.Drawing.Point(9, 4)
        Me.RjLabel17.Name = "RjLabel17"
        Me.RjLabel17.Size = New System.Drawing.Size(587, 18)
        Me.RjLabel17.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel17.TabIndex = 1
        Me.RjLabel17.Text = "Para uma melhor esperiência no análise dos dados, recomendamos que realize a sinc" &
    "ronização dos dados, clicando"
        Me.RjLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvUltimosInventarios
        '
        Me.DgvUltimosInventarios.AllowUserToAddRows = False
        Me.DgvUltimosInventarios.AllowUserToDeleteRows = False
        Me.DgvUltimosInventarios.AllowUserToResizeRows = False
        Me.DgvUltimosInventarios.AlternatingRowsColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvUltimosInventarios.AlternatingRowsColorApply = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvUltimosInventarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvUltimosInventarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvUltimosInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUltimosInventarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvUltimosInventarios.BorderRadius = 0
        Me.DgvUltimosInventarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUltimosInventarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvUltimosInventarios.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvUltimosInventarios.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvUltimosInventarios.ColumnHeaderHeight = 30
        Me.DgvUltimosInventarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUltimosInventarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvUltimosInventarios.ColumnHeadersHeight = 30
        Me.DgvUltimosInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvUltimosInventarios.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvUltimosInventarios.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUltimosInventarios.Customizable = True
        Me.DgvUltimosInventarios.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvUltimosInventarios.EnableHeadersVisualStyles = False
        Me.DgvUltimosInventarios.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvUltimosInventarios.Location = New System.Drawing.Point(402, 162)
        Me.DgvUltimosInventarios.MultiSelect = False
        Me.DgvUltimosInventarios.Name = "DgvUltimosInventarios"
        Me.DgvUltimosInventarios.ReadOnly = True
        Me.DgvUltimosInventarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvUltimosInventarios.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvUltimosInventarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUltimosInventarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvUltimosInventarios.RowHeadersVisible = False
        Me.DgvUltimosInventarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvUltimosInventarios.RowHeight = 25
        Me.DgvUltimosInventarios.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DgvUltimosInventarios.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvUltimosInventarios.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvUltimosInventarios.RowTemplate.Height = 25
        Me.DgvUltimosInventarios.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvUltimosInventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUltimosInventarios.SelectionTextColor = System.Drawing.Color.White
        Me.DgvUltimosInventarios.Size = New System.Drawing.Size(533, 228)
        Me.DgvUltimosInventarios.TabIndex = 9
        '
        'RjPanel8
        '
        Me.RjPanel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel8.BorderRadius = 0
        Me.RjPanel8.Controls.Add(Me.RjLabel15)
        Me.RjPanel8.Customizable = False
        Me.RjPanel8.Location = New System.Drawing.Point(402, 135)
        Me.RjPanel8.Name = "RjPanel8"
        Me.RjPanel8.Size = New System.Drawing.Size(533, 30)
        Me.RjPanel8.TabIndex = 10
        '
        'RjLabel15
        '
        Me.RjLabel15.AutoSize = True
        Me.RjLabel15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel15.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel15.LinkLabel = False
        Me.RjLabel15.Location = New System.Drawing.Point(150, 6)
        Me.RjLabel15.Name = "RjLabel15"
        Me.RjLabel15.Size = New System.Drawing.Size(236, 18)
        Me.RjLabel15.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel15.TabIndex = 3
        Me.RjLabel15.Text = "Últimos Inventários Realizados"
        '
        'ChartInventariosPorSetor
        '
        Me.ChartInventariosPorSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea1.AxisX.LineWidth = 2
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.LineWidth = 2
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        ChartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea1.AxisY.LineWidth = 2
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(144, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.LineWidth = 2
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.ChartInventariosPorSetor.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ChartInventariosPorSetor.Legends.Add(Legend1)
        Me.ChartInventariosPorSetor.Location = New System.Drawing.Point(13, 398)
        Me.ChartInventariosPorSetor.Name = "ChartInventariosPorSetor"
        Me.ChartInventariosPorSetor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.CustomProperties = "PieLabelStyle=Disabled"
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartInventariosPorSetor.Series.Add(Series1)
        Me.ChartInventariosPorSetor.Size = New System.Drawing.Size(380, 255)
        Me.ChartInventariosPorSetor.TabIndex = 5
        Me.ChartInventariosPorSetor.Text = "RjChart2"
        Title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Title1.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(86, Byte), Integer))
        Title1.Name = "Title1"
        Title1.Text = "Inventários por Setor"
        Me.ChartInventariosPorSetor.Titles.Add(Title1)
        '
        'DgvSituacaoPorSetor
        '
        Me.DgvSituacaoPorSetor.AllowUserToAddRows = False
        Me.DgvSituacaoPorSetor.AllowUserToDeleteRows = False
        Me.DgvSituacaoPorSetor.AllowUserToResizeRows = False
        Me.DgvSituacaoPorSetor.AlternatingRowsColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvSituacaoPorSetor.AlternatingRowsColorApply = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvSituacaoPorSetor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSituacaoPorSetor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSituacaoPorSetor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSituacaoPorSetor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvSituacaoPorSetor.BorderRadius = 0
        Me.DgvSituacaoPorSetor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSituacaoPorSetor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvSituacaoPorSetor.ColumnHeaderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvSituacaoPorSetor.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvSituacaoPorSetor.ColumnHeaderHeight = 30
        Me.DgvSituacaoPorSetor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSituacaoPorSetor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSituacaoPorSetor.ColumnHeadersHeight = 30
        Me.DgvSituacaoPorSetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSituacaoPorSetor.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvSituacaoPorSetor.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSituacaoPorSetor.Customizable = True
        Me.DgvSituacaoPorSetor.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DgvSituacaoPorSetor.EnableHeadersVisualStyles = False
        Me.DgvSituacaoPorSetor.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvSituacaoPorSetor.Location = New System.Drawing.Point(402, 425)
        Me.DgvSituacaoPorSetor.MultiSelect = False
        Me.DgvSituacaoPorSetor.Name = "DgvSituacaoPorSetor"
        Me.DgvSituacaoPorSetor.ReadOnly = True
        Me.DgvSituacaoPorSetor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvSituacaoPorSetor.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvSituacaoPorSetor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSituacaoPorSetor.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvSituacaoPorSetor.RowHeadersVisible = False
        Me.DgvSituacaoPorSetor.RowHeadersWidth = 25
        Me.DgvSituacaoPorSetor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvSituacaoPorSetor.RowHeight = 25
        Me.DgvSituacaoPorSetor.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvSituacaoPorSetor.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvSituacaoPorSetor.RowsTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DgvSituacaoPorSetor.RowTemplate.Height = 25
        Me.DgvSituacaoPorSetor.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.DgvSituacaoPorSetor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSituacaoPorSetor.SelectionTextColor = System.Drawing.Color.White
        Me.DgvSituacaoPorSetor.Size = New System.Drawing.Size(533, 228)
        Me.DgvSituacaoPorSetor.TabIndex = 9
        '
        'RjPanel9
        '
        Me.RjPanel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel9.BorderRadius = 0
        Me.RjPanel9.Controls.Add(Me.RjLabel16)
        Me.RjPanel9.Customizable = False
        Me.RjPanel9.Location = New System.Drawing.Point(402, 398)
        Me.RjPanel9.Name = "RjPanel9"
        Me.RjPanel9.Size = New System.Drawing.Size(533, 29)
        Me.RjPanel9.TabIndex = 10
        '
        'RjLabel16
        '
        Me.RjLabel16.AutoSize = True
        Me.RjLabel16.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel16.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel16.LinkLabel = False
        Me.RjLabel16.Location = New System.Drawing.Point(194, 6)
        Me.RjLabel16.Name = "RjLabel16"
        Me.RjLabel16.Size = New System.Drawing.Size(148, 18)
        Me.RjLabel16.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel16.TabIndex = 3
        Me.RjLabel16.Text = "Situação por Setor"
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Dashboard"
        Me.ClientSize = New System.Drawing.Size(960, 788)
        Me.FormIcon = FontAwesome.Sharp.IconChar.PieChart
        Me.Name = "FormDashboard"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Dashboard"
        Me._pnlClientArea.ResumeLayout(False)
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        Me.RjPanel2.ResumeLayout(False)
        Me.RjPanel3.ResumeLayout(False)
        Me.RjPanel3.PerformLayout()
        Me.RjPanel4.ResumeLayout(False)
        Me.RjPanel4.PerformLayout()
        Me.RjPanel5.ResumeLayout(False)
        Me.RjPanel5.PerformLayout()
        Me.RjPanel6.ResumeLayout(False)
        Me.RjPanel6.PerformLayout()
        Me.RjPanel7.ResumeLayout(False)
        Me.RjPanel7.PerformLayout()
        CType(Me.ChartIgrejasPorSetor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMargin.ResumeLayout(False)
        CType(Me.DgvUltimosInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RjPanel8.ResumeLayout(False)
        Me.RjPanel8.PerformLayout()
        CType(Me.ChartInventariosPorSetor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSituacaoPorSetor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RjPanel9.ResumeLayout(False)
        Me.RjPanel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMargin As System.Windows.Forms.Panel
    Friend WithEvents chartInventarios As PROJETOBASE.RJChart
    Friend WithEvents ChartIgrejasPorSetor As PROJETOBASE.RJChart
    Friend WithEvents RjPanel7 As PROJETOBASE.RJPanel
    Friend WithEvents LblRealizadosPercent As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel13 As PROJETOBASE.RJLabel
    Friend WithEvents RjPanel6 As PROJETOBASE.RJPanel
    Friend WithEvents RjLabel11 As PROJETOBASE.RJLabel
    Friend WithEvents RjPanel5 As PROJETOBASE.RJPanel
    Friend WithEvents LblIgrejasInativas As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel9 As PROJETOBASE.RJLabel
    Friend WithEvents RjPanel4 As PROJETOBASE.RJPanel
    Friend WithEvents LblIgrejasAtivas As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel7 As PROJETOBASE.RJLabel
    Friend WithEvents RjPanel3 As PROJETOBASE.RJPanel
    Friend WithEvents LblSetores As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel4 As PROJETOBASE.RJLabel
    Friend WithEvents RjPanel2 As PROJETOBASE.RJPanel
    Friend WithEvents LblTitulo As PROJETOBASE.RJLabel
    Friend WithEvents RjPanel1 As PROJETOBASE.RJPanel
    Friend WithEvents CmbSetor As PROJETOBASE.RJComboBox
    Friend WithEvents RjLabel3 As PROJETOBASE.RJLabel
    Friend WithEvents CmbAno As PROJETOBASE.RJComboBox
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents LblRealizadosTotal As RJLabel
    Friend WithEvents LblDepartamentos As RJLabel
    Friend WithEvents DgvUltimosInventarios As RJDataGridView
    Friend WithEvents RjPanel8 As RJPanel
    Friend WithEvents RjLabel15 As RJLabel
    Friend WithEvents RjPanel9 As RJPanel
    Friend WithEvents RjLabel16 As RJLabel
    Friend WithEvents DgvSituacaoPorSetor As RJDataGridView
    Friend WithEvents ChartInventariosPorSetor As RJChart
    Friend WithEvents RjLabel17 As RJLabel
    Friend WithEvents LblCliqueAqui As RJLabel
    Friend WithEvents BtnReset As RJButton
End Class
