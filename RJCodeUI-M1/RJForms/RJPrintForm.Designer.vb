<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RJPrintForm
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlPrintMenu = New System.Windows.Forms.Panel()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.btnLandscape = New FontAwesome.Sharp.IconButton()
        Me.btnPortrait = New FontAwesome.Sharp.IconButton()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.pnlDocument = New System.Windows.Forms.Panel()
        Me.pbContent = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me._pnlClientArea.SuspendLayout()
        Me.pnlPrintMenu.SuspendLayout()
        Me.pnlDocument.SuspendLayout()
        CType(Me.pbContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.pnlDocument)
        Me._pnlClientArea.Controls.Add(Me.pnlPrintMenu)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'pnlPrintMenu
        '
        Me.pnlPrintMenu.Controls.Add(Me.btnCancel)
        Me.pnlPrintMenu.Controls.Add(Me.btnLandscape)
        Me.pnlPrintMenu.Controls.Add(Me.btnPortrait)
        Me.pnlPrintMenu.Controls.Add(Me.btnPrint)
        Me.pnlPrintMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPrintMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrintMenu.Name = "pnlPrintMenu"
        Me.pnlPrintMenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.pnlPrintMenu.Size = New System.Drawing.Size(941, 25)
        Me.pnlPrintMenu.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.btnCancel.IconColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 20
        Me.btnCancel.Location = New System.Drawing.Point(115, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(35, 25)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLandscape
        '
        Me.btnLandscape.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLandscape.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLandscape.FlatAppearance.BorderSize = 0
        Me.btnLandscape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLandscape.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btnLandscape.IconColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLandscape.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLandscape.IconSize = 20
        Me.btnLandscape.Location = New System.Drawing.Point(80, 0)
        Me.btnLandscape.Name = "btnLandscape"
        Me.btnLandscape.Rotation = -90.0R
        Me.btnLandscape.Size = New System.Drawing.Size(35, 25)
        Me.btnLandscape.TabIndex = 0
        Me.btnLandscape.UseVisualStyleBackColor = True
        '
        'btnPortrait
        '
        Me.btnPortrait.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPortrait.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPortrait.FlatAppearance.BorderSize = 0
        Me.btnPortrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPortrait.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btnPortrait.IconColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnPortrait.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPortrait.IconSize = 20
        Me.btnPortrait.Location = New System.Drawing.Point(45, 0)
        Me.btnPortrait.Name = "btnPortrait"
        Me.btnPortrait.Size = New System.Drawing.Size(35, 25)
        Me.btnPortrait.TabIndex = 1
        Me.btnPortrait.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 20
        Me.btnPrint.Location = New System.Drawing.Point(10, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(35, 25)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'pnlDocument
        '
        Me.pnlDocument.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlDocument.BackColor = System.Drawing.Color.White
        Me.pnlDocument.Controls.Add(Me.pbContent)
        Me.pnlDocument.Controls.Add(Me.pnlHeader)
        Me.pnlDocument.Location = New System.Drawing.Point(53, 88)
        Me.pnlDocument.Name = "pnlDocument"
        Me.pnlDocument.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlDocument.Size = New System.Drawing.Size(794, 445)
        Me.pnlDocument.TabIndex = 2
        '
        'pbContent
        '
        Me.pbContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbContent.Location = New System.Drawing.Point(20, 100)
        Me.pbContent.Name = "pbContent"
        Me.pbContent.Size = New System.Drawing.Size(754, 322)
        Me.pbContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbContent.TabIndex = 1
        Me.pbContent.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblCompany)
        Me.pnlHeader.Controls.Add(Me.lblDate)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(20, 20)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(754, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(28, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(77, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Doc Title"
        '
        'lblCompany
        '
        Me.lblCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompany.AutoSize = True
        Me.lblCompany.ForeColor = System.Drawing.Color.White
        Me.lblCompany.Location = New System.Drawing.Point(624, 10)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(118, 16)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "RJ Code Advance"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(329, 30)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(415, 20)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'printDoc
        '
        '
        'RJPrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Print"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.Parking
        Me.Name = "RJPrintForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Print"
        Me._pnlClientArea.ResumeLayout(False)
        Me.pnlPrintMenu.ResumeLayout(False)
        Me.pnlDocument.ResumeLayout(False)
        CType(Me.pbContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlPrintMenu As System.Windows.Forms.Panel
    Private WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Private WithEvents btnLandscape As FontAwesome.Sharp.IconButton
    Private WithEvents btnPortrait As FontAwesome.Sharp.IconButton
    Private WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Private WithEvents pnlDocument As System.Windows.Forms.Panel
    Private WithEvents pbContent As System.Windows.Forms.PictureBox
    Private WithEvents pnlHeader As System.Windows.Forms.Panel
    Private WithEvents lblTitle As System.Windows.Forms.Label
    Private WithEvents lblCompany As System.Windows.Forms.Label
    Private WithEvents lblDate As System.Windows.Forms.Label
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents printDoc As System.Drawing.Printing.PrintDocument
End Class
