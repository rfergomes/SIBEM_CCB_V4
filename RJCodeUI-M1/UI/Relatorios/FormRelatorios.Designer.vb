<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRelatorios
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnGerarRelatorio = New PROJETOBASE.RJButton()
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.DtpFim = New PROJETOBASE.RJDatePicker()
        Me.DtpInicio = New PROJETOBASE.RJDatePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboSetor = New PROJETOBASE.RJComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtSetor = New PROJETOBASE.RJRadioButton()
        Me.RbtMes = New PROJETOBASE.RJRadioButton()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.BtnLimparFiltros = New PROJETOBASE.RJButton()
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.RjPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pnlClientArea.Controls.Add(Me.RjPanel2)
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PROJETOBASE.RelInventariosPorSetor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(657, 518)
        Me.ReportViewer1.TabIndex = 1
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'BtnGerarRelatorio
        '
        Me.BtnGerarRelatorio.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnGerarRelatorio.BorderRadius = 0
        Me.BtnGerarRelatorio.BorderSize = 1
        Me.BtnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGerarRelatorio.Design = PROJETOBASE.ButtonDesign.Edit
        Me.BtnGerarRelatorio.FlatAppearance.BorderSize = 0
        Me.BtnGerarRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnGerarRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGerarRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGerarRelatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnGerarRelatorio.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.BtnGerarRelatorio.IconColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnGerarRelatorio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnGerarRelatorio.IconSize = 24
        Me.BtnGerarRelatorio.Location = New System.Drawing.Point(13, 267)
        Me.BtnGerarRelatorio.Name = "BtnGerarRelatorio"
        Me.BtnGerarRelatorio.Size = New System.Drawing.Size(134, 30)
        Me.BtnGerarRelatorio.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnGerarRelatorio.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnGerarRelatorio.TabIndex = 2
        Me.BtnGerarRelatorio.Text = "Gerar Relatório"
        Me.BtnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGerarRelatorio.UseVisualStyleBackColor = False
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FloralWhite
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.GroupBox3)
        Me.RjPanel1.Controls.Add(Me.GroupBox2)
        Me.RjPanel1.Controls.Add(Me.GroupBox1)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Controls.Add(Me.BtnLimparFiltros)
        Me.RjPanel1.Controls.Add(Me.BtnGerarRelatorio)
        Me.RjPanel1.Customizable = True
        Me.RjPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RjPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(301, 518)
        Me.RjPanel1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RjLabel3)
        Me.GroupBox3.Controls.Add(Me.DtpFim)
        Me.GroupBox3.Controls.Add(Me.DtpInicio)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 61)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Período"
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(131, 29)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(15, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 8
        Me.RjLabel3.Text = "á"
        '
        'DtpFim
        '
        Me.DtpFim.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DtpFim.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DtpFim.BorderSize = 1
        Me.DtpFim.CustomFormat = Nothing
        Me.DtpFim.Customizable = True
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFim.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DtpFim.Location = New System.Drawing.Point(148, 21)
        Me.DtpFim.MinimumSize = New System.Drawing.Size(120, 25)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Padding = New System.Windows.Forms.Padding(2)
        Me.DtpFim.Size = New System.Drawing.Size(120, 32)
        Me.DtpFim.Style = PROJETOBASE.ControlStyle.Glass
        Me.DtpFim.TabIndex = 0
        Me.DtpFim.Value = New Date(2025, 3, 18, 20, 10, 33, 824)
        '
        'DtpInicio
        '
        Me.DtpInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DtpInicio.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DtpInicio.BorderSize = 1
        Me.DtpInicio.CustomFormat = Nothing
        Me.DtpInicio.Customizable = True
        Me.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpInicio.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DtpInicio.Location = New System.Drawing.Point(8, 21)
        Me.DtpInicio.MinimumSize = New System.Drawing.Size(120, 25)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.Padding = New System.Windows.Forms.Padding(2)
        Me.DtpInicio.Size = New System.Drawing.Size(120, 32)
        Me.DtpInicio.Style = PROJETOBASE.ControlStyle.Glass
        Me.DtpInicio.TabIndex = 0
        Me.DtpInicio.Value = New Date(2025, 3, 18, 20, 10, 33, 824)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboSetor)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 61)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setor"
        '
        'CboSetor
        '
        Me.CboSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboSetor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.BorderRadius = 0
        Me.CboSetor.BorderSize = 1
        Me.CboSetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboSetor.Customizable = False
        Me.CboSetor.DataSource = Nothing
        Me.CboSetor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboSetor.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.Location = New System.Drawing.Point(8, 21)
        Me.CboSetor.Name = "CboSetor"
        Me.CboSetor.Padding = New System.Windows.Forms.Padding(2)
        Me.CboSetor.SelectedIndex = -1
        Me.CboSetor.SelectedItem = Nothing
        Me.CboSetor.SelectedValue = Nothing
        Me.CboSetor.Size = New System.Drawing.Size(260, 32)
        Me.CboSetor.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboSetor.TabIndex = 8
        Me.CboSetor.Texts = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtSetor)
        Me.GroupBox1.Controls.Add(Me.RbtMes)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 61)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agrupar"
        '
        'RbtSetor
        '
        Me.RbtSetor.AutoSize = True
        Me.RbtSetor.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtSetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtSetor.Customizable = False
        Me.RbtSetor.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtSetor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtSetor.Location = New System.Drawing.Point(36, 27)
        Me.RbtSetor.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtSetor.Name = "RbtSetor"
        Me.RbtSetor.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtSetor.Size = New System.Drawing.Size(97, 21)
        Me.RbtSetor.TabIndex = 3
        Me.RbtSetor.TabStop = True
        Me.RbtSetor.Text = "Por Setor"
        Me.RbtSetor.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtSetor.UseVisualStyleBackColor = True
        '
        'RbtMes
        '
        Me.RbtMes.AutoSize = True
        Me.RbtMes.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtMes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtMes.Customizable = False
        Me.RbtMes.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtMes.Location = New System.Drawing.Point(169, 27)
        Me.RbtMes.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtMes.Name = "RbtMes"
        Me.RbtMes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtMes.Size = New System.Drawing.Size(87, 21)
        Me.RbtMes.TabIndex = 3
        Me.RbtMes.TabStop = True
        Me.RbtMes.Text = "Por Mês"
        Me.RbtMes.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RbtMes.UseVisualStyleBackColor = True
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(60, 12)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(181, 26)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel2.TabIndex = 4
        Me.RjLabel2.Text = "Filtrar Relatório"
        '
        'BtnLimparFiltros
        '
        Me.BtnLimparFiltros.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnLimparFiltros.BorderRadius = 0
        Me.BtnLimparFiltros.BorderSize = 1
        Me.BtnLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimparFiltros.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnLimparFiltros.FlatAppearance.BorderSize = 0
        Me.BtnLimparFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnLimparFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLimparFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimparFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimparFiltros.ForeColor = System.Drawing.Color.DarkSalmon
        Me.BtnLimparFiltros.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward
        Me.BtnLimparFiltros.IconColor = System.Drawing.Color.DarkSalmon
        Me.BtnLimparFiltros.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLimparFiltros.IconSize = 24
        Me.BtnLimparFiltros.Location = New System.Drawing.Point(156, 267)
        Me.BtnLimparFiltros.Name = "BtnLimparFiltros"
        Me.BtnLimparFiltros.Size = New System.Drawing.Size(134, 30)
        Me.BtnLimparFiltros.SkinBorderColor = System.Drawing.Color.DarkSalmon
        Me.BtnLimparFiltros.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnLimparFiltros.TabIndex = 2
        Me.BtnLimparFiltros.Text = "Limpar Filtros"
        Me.BtnLimparFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimparFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimparFiltros.UseVisualStyleBackColor = False
        '
        'RjPanel2
        '
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel2.BorderRadius = 0
        Me.RjPanel2.Controls.Add(Me.ReportViewer1)
        Me.RjPanel2.Customizable = False
        Me.RjPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RjPanel2.Location = New System.Drawing.Point(301, 0)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(657, 518)
        Me.RjPanel2.TabIndex = 4
        '
        'FormRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Relatórios"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.Name = "FormRelatorios"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Relatórios"
        Me._pnlClientArea.ResumeLayout(False)
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.RjPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BtnGerarRelatorio As RJButton
    Friend WithEvents RjPanel2 As RJPanel
    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents RbtMes As RJRadioButton
    Friend WithEvents RbtSetor As RJRadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnLimparFiltros As RJButton
    Friend WithEvents DtpInicio As RJDatePicker
    Friend WithEvents DtpFim As RJDatePicker
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents CboSetor As RJComboBox
End Class
