<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventarioEtiquetas
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
        Me.TxtEtiquetas = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.LblIgreja = New PROJETOBASE.RJLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpar = New PROJETOBASE.RJButton()
        Me.BtnFiltrar = New PROJETOBASE.RJButton()
        Me.RbtAmbas = New PROJETOBASE.RJRadioButton()
        Me.RbtAlterar = New PROJETOBASE.RJRadioButton()
        Me.RbtImprimir = New PROJETOBASE.RJRadioButton()
        Me.BtnCopiarSiga = New PROJETOBASE.RJButton()
        Me.BtnCopiar = New PROJETOBASE.RJButton()
        Me.BtnTXT = New PROJETOBASE.RJButton()
        Me.LblEtiquetasTotal = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.LblEtiquetasTotal)
        Me._pnlClientArea.Controls.Add(Me.BtnTXT)
        Me._pnlClientArea.Controls.Add(Me.BtnCopiar)
        Me._pnlClientArea.Controls.Add(Me.BtnCopiarSiga)
        Me._pnlClientArea.Controls.Add(Me.GroupBox1)
        Me._pnlClientArea.Controls.Add(Me.LblIgreja)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.TxtEtiquetas)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(658, 418)
        '
        'TxtEtiquetas
        '
        Me.TxtEtiquetas._Customizable = True
        Me.TxtEtiquetas.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtEtiquetas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEtiquetas.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtEtiquetas.BorderRadius = 5
        Me.TxtEtiquetas.BorderSize = 2
        Me.TxtEtiquetas.Enabled = False
        Me.TxtEtiquetas.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtEtiquetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.TxtEtiquetas.Location = New System.Drawing.Point(38, 141)
        Me.TxtEtiquetas.MultiLine = True
        Me.TxtEtiquetas.Name = "TxtEtiquetas"
        Me.TxtEtiquetas.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtEtiquetas.PasswordChar = False
        Me.TxtEtiquetas.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtEtiquetas.PlaceHolderText = Nothing
        Me.TxtEtiquetas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtEtiquetas.Size = New System.Drawing.Size(583, 196)
        Me.TxtEtiquetas.Style = PROJETOBASE.TextBoxStyle.FlaringBorder
        Me.TxtEtiquetas.TabIndex = 0
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(180, 8)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(298, 23)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel1.TabIndex = 1
        Me.RjLabel1.Text = "ETIQUETAS PARA IMPRESSÃO"
        Me.RjLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIgreja
        '
        Me.LblIgreja.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblIgreja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblIgreja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LblIgreja.LinkLabel = False
        Me.LblIgreja.Location = New System.Drawing.Point(38, 44)
        Me.LblIgreja.Name = "LblIgreja"
        Me.LblIgreja.Size = New System.Drawing.Size(583, 24)
        Me.LblIgreja.Style = PROJETOBASE.LabelStyle.Title2
        Me.LblIgreja.TabIndex = 2
        Me.LblIgreja.Text = "Casa de Oração"
        Me.LblIgreja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnLimpar)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.RbtAmbas)
        Me.GroupBox1.Controls.Add(Me.RbtAlterar)
        Me.GroupBox1.Controls.Add(Me.RbtImprimir)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(38, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 54)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleciona um tipo de Ação para seleção"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnLimpar.BorderRadius = 5
        Me.BtnLimpar.BorderSize = 1
        Me.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpar.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnLimpar.FlatAppearance.BorderSize = 0
        Me.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLimpar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.BtnLimpar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLimpar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLimpar.IconSize = 24
        Me.BtnLimpar.Location = New System.Drawing.Point(496, 16)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(81, 30)
        Me.BtnLimpar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLimpar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnLimpar.TabIndex = 1
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnFiltrar.BorderRadius = 5
        Me.BtnFiltrar.BorderSize = 1
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.BtnFiltrar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFiltrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnFiltrar.IconSize = 24
        Me.BtnFiltrar.Location = New System.Drawing.Point(416, 16)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(74, 30)
        Me.BtnFiltrar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFiltrar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnFiltrar.TabIndex = 1
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFiltrar.UseVisualStyleBackColor = False
        '
        'RbtAmbas
        '
        Me.RbtAmbas.AutoSize = True
        Me.RbtAmbas.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtAmbas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtAmbas.Customizable = True
        Me.RbtAmbas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbtAmbas.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtAmbas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtAmbas.Location = New System.Drawing.Point(207, 21)
        Me.RbtAmbas.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtAmbas.Name = "RbtAmbas"
        Me.RbtAmbas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtAmbas.Size = New System.Drawing.Size(152, 21)
        Me.RbtAmbas.TabIndex = 0
        Me.RbtAmbas.TabStop = True
        Me.RbtAmbas.Text = "AS DUAS OPÇÕES"
        Me.RbtAmbas.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.RbtAmbas.UseVisualStyleBackColor = True
        '
        'RbtAlterar
        '
        Me.RbtAlterar.AutoSize = True
        Me.RbtAlterar.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtAlterar.Customizable = True
        Me.RbtAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbtAlterar.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtAlterar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtAlterar.Location = New System.Drawing.Point(110, 21)
        Me.RbtAlterar.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtAlterar.Name = "RbtAlterar"
        Me.RbtAlterar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtAlterar.Size = New System.Drawing.Size(91, 21)
        Me.RbtAlterar.TabIndex = 0
        Me.RbtAlterar.TabStop = True
        Me.RbtAlterar.Text = "ALTERAR"
        Me.RbtAlterar.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.RbtAlterar.UseVisualStyleBackColor = True
        '
        'RbtImprimir
        '
        Me.RbtImprimir.AutoSize = True
        Me.RbtImprimir.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbtImprimir.Customizable = True
        Me.RbtImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbtImprimir.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RbtImprimir.Location = New System.Drawing.Point(6, 21)
        Me.RbtImprimir.MinimumSize = New System.Drawing.Size(0, 21)
        Me.RbtImprimir.Name = "RbtImprimir"
        Me.RbtImprimir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtImprimir.Size = New System.Drawing.Size(95, 21)
        Me.RbtImprimir.TabIndex = 0
        Me.RbtImprimir.TabStop = True
        Me.RbtImprimir.Text = "IMPRIMIR"
        Me.RbtImprimir.UnCheckedColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.RbtImprimir.UseVisualStyleBackColor = True
        '
        'BtnCopiarSiga
        '
        Me.BtnCopiarSiga.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnCopiarSiga.BorderRadius = 5
        Me.BtnCopiarSiga.BorderSize = 1
        Me.BtnCopiarSiga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCopiarSiga.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnCopiarSiga.Enabled = False
        Me.BtnCopiarSiga.FlatAppearance.BorderSize = 0
        Me.BtnCopiarSiga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnCopiarSiga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnCopiarSiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiarSiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiarSiga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnCopiarSiga.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        Me.BtnCopiarSiga.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnCopiarSiga.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCopiarSiga.IconSize = 24
        Me.BtnCopiarSiga.Location = New System.Drawing.Point(222, 365)
        Me.BtnCopiarSiga.Name = "BtnCopiarSiga"
        Me.BtnCopiarSiga.Size = New System.Drawing.Size(186, 30)
        Me.BtnCopiarSiga.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnCopiarSiga.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnCopiarSiga.TabIndex = 4
        Me.BtnCopiarSiga.Text = "Copiar e abrir SIGA"
        Me.BtnCopiarSiga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarSiga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopiarSiga.UseVisualStyleBackColor = False
        '
        'BtnCopiar
        '
        Me.BtnCopiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnCopiar.BorderRadius = 5
        Me.BtnCopiar.BorderSize = 1
        Me.BtnCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCopiar.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnCopiar.Enabled = False
        Me.BtnCopiar.FlatAppearance.BorderSize = 0
        Me.BtnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnCopiar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck
        Me.BtnCopiar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnCopiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCopiar.IconSize = 24
        Me.BtnCopiar.Location = New System.Drawing.Point(99, 365)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(101, 30)
        Me.BtnCopiar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnCopiar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnCopiar.TabIndex = 4
        Me.BtnCopiar.Text = "Copiar"
        Me.BtnCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopiar.UseVisualStyleBackColor = False
        '
        'BtnTXT
        '
        Me.BtnTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnTXT.BorderRadius = 5
        Me.BtnTXT.BorderSize = 1
        Me.BtnTXT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTXT.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.BtnTXT.Enabled = False
        Me.BtnTXT.FlatAppearance.BorderSize = 0
        Me.BtnTXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnTXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnTXT.IconChar = FontAwesome.Sharp.IconChar.FileCsv
        Me.BtnTXT.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnTXT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTXT.IconSize = 24
        Me.BtnTXT.Location = New System.Drawing.Point(430, 365)
        Me.BtnTXT.Name = "BtnTXT"
        Me.BtnTXT.Size = New System.Drawing.Size(129, 30)
        Me.BtnTXT.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnTXT.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnTXT.TabIndex = 5
        Me.BtnTXT.Text = "Gerar TXT"
        Me.BtnTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTXT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTXT.UseVisualStyleBackColor = False
        '
        'LblEtiquetasTotal
        '
        Me.LblEtiquetasTotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblEtiquetasTotal.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.LblEtiquetasTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblEtiquetasTotal.LinkLabel = False
        Me.LblEtiquetasTotal.Location = New System.Drawing.Point(489, 340)
        Me.LblEtiquetasTotal.Name = "LblEtiquetasTotal"
        Me.LblEtiquetasTotal.Size = New System.Drawing.Size(132, 16)
        Me.LblEtiquetasTotal.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblEtiquetasTotal.TabIndex = 6
        Me.LblEtiquetasTotal.Text = "-"
        Me.LblEtiquetasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormInventarioEtiquetas
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.CancelButton = Me.btnClose
        Me.Caption = "Selecionar Etiquetas"
        Me.ClientSize = New System.Drawing.Size(660, 460)
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.FormIcon = FontAwesome.Sharp.IconChar.Tags
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInventarioEtiquetas"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar Etiquetas"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtEtiquetas As RJTextBox
    Friend WithEvents LblIgreja As RJLabel
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbtAmbas As RJRadioButton
    Friend WithEvents RbtAlterar As RJRadioButton
    Friend WithEvents RbtImprimir As RJRadioButton
    Friend WithEvents BtnFiltrar As RJButton
    Friend WithEvents BtnLimpar As RJButton
    Friend WithEvents BtnCopiar As RJButton
    Friend WithEvents BtnCopiarSiga As RJButton
    Friend WithEvents BtnTXT As RJButton
    Friend WithEvents LblEtiquetasTotal As RJLabel
End Class
