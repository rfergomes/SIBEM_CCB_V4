<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductMaintenance
    Inherits RJChildForm

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
        Me.btnSave = New PROJETOBASE.RJButton()
        Me.txtStock = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.txtUnitPrice = New PROJETOBASE.RJTextBox()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.txtProduct = New PROJETOBASE.RJTextBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.txtID = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.lblTitle = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.btnSave)
        Me._pnlClientArea.Controls.Add(Me.txtStock)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.txtUnitPrice)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.txtProduct)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.txtID)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.lblTitle)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(613, 228)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSave.BorderRadius = 20
        Me.btnSave.BorderSize = 1
        Me.btnSave.Design = PROJETOBASE.ButtonDesign.Normal
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSave.IconColor = System.Drawing.Color.White
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 24
        Me.btnSave.Location = New System.Drawing.Point(202, 166)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(183, 40)
        Me.btnSave.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSave.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtStock
        '
        Me.txtStock._Customizable = False
        Me.txtStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtStock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtStock.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtStock.BorderRadius = 0
        Me.txtStock.BorderSize = 2
        Me.txtStock.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtStock.Location = New System.Drawing.Point(391, 109)
        Me.txtStock.MultiLine = False
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtStock.PasswordChar = False
        Me.txtStock.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtStock.PlaceHolderText = Nothing
        Me.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStock.Size = New System.Drawing.Size(194, 31)
        Me.txtStock.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.txtStock.TabIndex = 18
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(333, 118)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(52, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 17
        Me.RjLabel3.Text = "Stock:"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice._Customizable = False
        Me.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUnitPrice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtUnitPrice.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtUnitPrice.BorderRadius = 0
        Me.txtUnitPrice.BorderSize = 2
        Me.txtUnitPrice.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtUnitPrice.Location = New System.Drawing.Point(101, 109)
        Me.txtUnitPrice.MultiLine = False
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtUnitPrice.PasswordChar = False
        Me.txtUnitPrice.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtUnitPrice.PlaceHolderText = Nothing
        Me.txtUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUnitPrice.Size = New System.Drawing.Size(194, 31)
        Me.txtUnitPrice.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.txtUnitPrice.TabIndex = 16
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(18, 118)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(77, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 15
        Me.RjLabel4.Text = "Unit price:"
        '
        'txtProduct
        '
        Me.txtProduct._Customizable = False
        Me.txtProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtProduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtProduct.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtProduct.BorderRadius = 0
        Me.txtProduct.BorderSize = 2
        Me.txtProduct.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtProduct.Location = New System.Drawing.Point(391, 54)
        Me.txtProduct.MultiLine = False
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtProduct.PasswordChar = False
        Me.txtProduct.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtProduct.PlaceHolderText = Nothing
        Me.txtProduct.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProduct.Size = New System.Drawing.Size(194, 31)
        Me.txtProduct.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.txtProduct.TabIndex = 14
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(320, 62)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(65, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 13
        Me.RjLabel2.Text = "Product:"
        '
        'txtID
        '
        Me.txtID._Customizable = False
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtID.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtID.BorderRadius = 0
        Me.txtID.BorderSize = 2
        Me.txtID.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(101, 54)
        Me.txtID.MultiLine = False
        Me.txtID.Name = "txtID"
        Me.txtID.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtID.PasswordChar = False
        Me.txtID.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtID.PlaceHolderText = Nothing
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.Size = New System.Drawing.Size(194, 31)
        Me.txtID.Style = PROJETOBASE.TextBoxStyle.MatteLine
        Me.txtID.TabIndex = 12
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(67, 62)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(28, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 11
        Me.RjLabel1.Text = "ID:"
        '
        'lblTitle
        '
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTitle.LinkLabel = False
        Me.lblTitle.Location = New System.Drawing.Point(95, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(374, 25)
        Me.lblTitle.Style = PROJETOBASE.LabelStyle.Title
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormProductMaintenance
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Product maintenance"
        Me.ClientSize = New System.Drawing.Size(615, 270)
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.FormIcon = FontAwesome.Sharp.IconChar.Tag
        Me.Name = "FormProductMaintenance"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Product maintenance"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As PROJETOBASE.RJButton
    Friend WithEvents txtStock As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel3 As PROJETOBASE.RJLabel
    Friend WithEvents txtUnitPrice As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel4 As PROJETOBASE.RJLabel
    Friend WithEvents txtProduct As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents txtID As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
    Friend WithEvents lblTitle As PROJETOBASE.RJLabel
End Class
