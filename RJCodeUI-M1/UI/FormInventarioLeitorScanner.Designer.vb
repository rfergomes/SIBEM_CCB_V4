<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventarioLeitorScanner
    Inherits PROJETOBASE.RJChildForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventarioLeitorScanner))
        Me.RjPictureBox1 = New PROJETOBASE.RJPictureBox()
        Me.DgvLidos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEtiqueta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DpwMenuExportar = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.ToolStripMenuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuCelula = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuLinha = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuTudo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuTxt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvLidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DpwMenuExportar.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.Label1)
        Me._pnlClientArea.Controls.Add(Me.TxtEtiqueta)
        Me._pnlClientArea.Controls.Add(Me.DgvLidos)
        Me._pnlClientArea.Controls.Add(Me.RjPictureBox1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(580, 376)
        '
        'RjPictureBox1
        '
        Me.RjPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RjPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjPictureBox1.BorderRadius = 5
        Me.RjPictureBox1.BorderSize = 0
        Me.RjPictureBox1.Customizable = True
        Me.RjPictureBox1.Image = CType(resources.GetObject("RjPictureBox1.Image"), System.Drawing.Image)
        Me.RjPictureBox1.Location = New System.Drawing.Point(119, 11)
        Me.RjPictureBox1.Name = "RjPictureBox1"
        Me.RjPictureBox1.Size = New System.Drawing.Size(342, 116)
        Me.RjPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjPictureBox1.TabIndex = 1
        Me.RjPictureBox1.TabStop = False
        '
        'DgvLidos
        '
        Me.DgvLidos.AllowUserToAddRows = False
        Me.DgvLidos.AllowUserToDeleteRows = False
        Me.DgvLidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DgvLidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvLidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DgvLidos.Location = New System.Drawing.Point(3, 133)
        Me.DgvLidos.MultiSelect = False
        Me.DgvLidos.Name = "DgvLidos"
        Me.DgvLidos.ReadOnly = True
        Me.DgvLidos.RowHeadersVisible = False
        Me.DgvLidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvLidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLidos.Size = New System.Drawing.Size(574, 215)
        Me.DgvLidos.TabIndex = 2
        Me.DgvLidos.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Etiqueta"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 81
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Bem Móvel"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column3
        '
        Me.Column3.HeaderText = "Situação"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'TxtEtiqueta
        '
        Me.TxtEtiqueta.BackColor = System.Drawing.Color.White
        Me.TxtEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEtiqueta.Location = New System.Drawing.Point(137, 69)
        Me.TxtEtiqueta.MaxLength = 12
        Me.TxtEtiqueta.Name = "TxtEtiqueta"
        Me.TxtEtiqueta.Size = New System.Drawing.Size(307, 34)
        Me.TxtEtiqueta.TabIndex = 0
        Me.TxtEtiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(517, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "-"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DpwMenuExportar
        '
        Me.DpwMenuExportar.ActiveMenuItem = False
        Me.DpwMenuExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DpwMenuExportar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuCopiar, Me.ToolStripMenuTxt, Me.ToolStripMenuExcel, Me.ToolStripMenuPdf})
        Me.DpwMenuExportar.Name = "DpwMenuExportar"
        Me.DpwMenuExportar.OwnerIsMenuButton = False
        Me.DpwMenuExportar.Size = New System.Drawing.Size(199, 114)
        '
        'ToolStripMenuCopiar
        '
        Me.ToolStripMenuCopiar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuCelula, Me.ToolStripMenuLinha, Me.ToolStripMenuTudo})
        Me.ToolStripMenuCopiar.Image = CType(resources.GetObject("ToolStripMenuCopiar.Image"), System.Drawing.Image)
        Me.ToolStripMenuCopiar.Name = "ToolStripMenuCopiar"
        Me.ToolStripMenuCopiar.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuCopiar.Text = "Copiar"
        '
        'ToolStripMenuCelula
        '
        Me.ToolStripMenuCelula.Image = CType(resources.GetObject("ToolStripMenuCelula.Image"), System.Drawing.Image)
        Me.ToolStripMenuCelula.Name = "ToolStripMenuCelula"
        Me.ToolStripMenuCelula.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuCelula.Text = "Celula"
        '
        'ToolStripMenuLinha
        '
        Me.ToolStripMenuLinha.Image = CType(resources.GetObject("ToolStripMenuLinha.Image"), System.Drawing.Image)
        Me.ToolStripMenuLinha.Name = "ToolStripMenuLinha"
        Me.ToolStripMenuLinha.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuLinha.Text = "Linha"
        '
        'ToolStripMenuTudo
        '
        Me.ToolStripMenuTudo.Image = CType(resources.GetObject("ToolStripMenuTudo.Image"), System.Drawing.Image)
        Me.ToolStripMenuTudo.Name = "ToolStripMenuTudo"
        Me.ToolStripMenuTudo.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuTudo.Text = "Tudo"
        '
        'ToolStripMenuTxt
        '
        Me.ToolStripMenuTxt.Image = CType(resources.GetObject("ToolStripMenuTxt.Image"), System.Drawing.Image)
        Me.ToolStripMenuTxt.Name = "ToolStripMenuTxt"
        Me.ToolStripMenuTxt.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuTxt.Text = "Exportar para TXT"
        '
        'ToolStripMenuExcel
        '
        Me.ToolStripMenuExcel.Image = CType(resources.GetObject("ToolStripMenuExcel.Image"), System.Drawing.Image)
        Me.ToolStripMenuExcel.Name = "ToolStripMenuExcel"
        Me.ToolStripMenuExcel.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuExcel.Text = "Exportat para Excel"
        '
        'ToolStripMenuPdf
        '
        Me.ToolStripMenuPdf.Image = CType(resources.GetObject("ToolStripMenuPdf.Image"), System.Drawing.Image)
        Me.ToolStripMenuPdf.Name = "ToolStripMenuPdf"
        Me.ToolStripMenuPdf.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuPdf.Text = "Exportar para PDF"
        '
        'FormInventarioLeitorScanner
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.CancelButton = Me.btnClose
        Me.Caption = "Leitor"
        Me.ClientSize = New System.Drawing.Size(582, 418)
        Me.FormIcon = FontAwesome.Sharp.IconChar.Barcode
        Me.Name = "FormInventarioLeitorScanner"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Leitor"
        Me.Controls.SetChildIndex(Me._pnlClientArea, 0)
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvLidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DpwMenuExportar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RjPictureBox1 As RJPictureBox
    Friend WithEvents DgvLidos As DataGridView
    Friend WithEvents TxtEtiqueta As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DpwMenuExportar As RJDropdownMenu
    Friend WithEvents ToolStripMenuCopiar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCelula As ToolStripMenuItem
    Friend WithEvents ToolStripMenuLinha As ToolStripMenuItem
    Friend WithEvents ToolStripMenuTudo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuTxt As ToolStripMenuItem
    Friend WithEvents ToolStripMenuExcel As ToolStripMenuItem
    Friend WithEvents ToolStripMenuPdf As ToolStripMenuItem
End Class
