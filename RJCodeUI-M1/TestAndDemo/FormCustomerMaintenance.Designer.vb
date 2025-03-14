<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerMaintenance
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
        Me.lblTitle = New PROJETOBASE.RJLabel()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.txtNames = New PROJETOBASE.RJTextBox()
        Me.txtEmail = New PROJETOBASE.RJTextBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.txtAddress = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.txtPhone = New PROJETOBASE.RJTextBox()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.btnSave = New PROJETOBASE.RJButton()
        Me._pnlClientArea.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.btnSave)
        Me._pnlClientArea.Controls.Add(Me.txtAddress)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.txtPhone)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.txtEmail)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.txtNames)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.lblTitle)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(517, 291)
        '
        'lblTitle
        '
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblTitle.LinkLabel = False
        Me.lblTitle.Location = New System.Drawing.Point(59, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(374, 25)
        Me.lblTitle.Style = PROJETOBASE.LabelStyle.Title
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(41, 56)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(57, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 1
        Me.RjLabel1.Text = "Names:"
        '
        'txtNames
        '
        Me.txtNames._Customizable = False
        Me.txtNames.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNames.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtNames.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtNames.BorderRadius = 10
        Me.txtNames.BorderSize = 2
        Me.txtNames.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtNames.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtNames.Location = New System.Drawing.Point(44, 75)
        Me.txtNames.MultiLine = False
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtNames.PasswordChar = False
        Me.txtNames.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtNames.PlaceHolderText = Nothing
        Me.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNames.Size = New System.Drawing.Size(194, 31)
        Me.txtNames.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtNames.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail._Customizable = False
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtEmail.BorderRadius = 10
        Me.txtEmail.BorderSize = 2
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(276, 75)
        Me.txtEmail.MultiLine = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtEmail.PasswordChar = False
        Me.txtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtEmail.PlaceHolderText = Nothing
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.Size = New System.Drawing.Size(194, 31)
        Me.txtEmail.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtEmail.TabIndex = 4
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(273, 56)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(47, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 3
        Me.RjLabel2.Text = "Email:"
        '
        'txtAddress
        '
        Me.txtAddress._Customizable = False
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtAddress.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtAddress.BorderRadius = 10
        Me.txtAddress.BorderSize = 2
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(275, 146)
        Me.txtAddress.MultiLine = False
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtAddress.PasswordChar = False
        Me.txtAddress.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtAddress.PlaceHolderText = Nothing
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.Size = New System.Drawing.Size(194, 31)
        Me.txtAddress.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtAddress.TabIndex = 8
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(272, 127)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(112, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 7
        Me.RjLabel3.Text = "Street address:"
        '
        'txtPhone
        '
        Me.txtPhone._Customizable = False
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPhone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtPhone.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txtPhone.BorderRadius = 10
        Me.txtPhone.BorderSize = 2
        Me.txtPhone.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(43, 146)
        Me.txtPhone.MultiLine = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPhone.PasswordChar = False
        Me.txtPhone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.txtPhone.PlaceHolderText = Nothing
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.Size = New System.Drawing.Size(194, 31)
        Me.txtPhone.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.txtPhone.TabIndex = 6
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(40, 127)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(107, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 5
        Me.RjLabel4.Text = "Phone number:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSave.BorderRadius = 10
        Me.btnSave.BorderSize = 0
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
        Me.btnSave.Location = New System.Drawing.Point(158, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(183, 40)
        Me.btnSave.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSave.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FormCustomerMaintenance
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Customer maintenance"
        Me.ClientSize = New System.Drawing.Size(519, 333)
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.FormIcon = FontAwesome.Sharp.IconChar.UserCheck
        Me.Name = "FormCustomerMaintenance"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer maintenance"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As PROJETOBASE.RJLabel
    Friend WithEvents btnSave As PROJETOBASE.RJButton
    Friend WithEvents txtAddress As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel3 As PROJETOBASE.RJLabel
    Friend WithEvents txtPhone As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel4 As PROJETOBASE.RJLabel
    Friend WithEvents txtEmail As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents txtNames As PROJETOBASE.RJTextBox
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
End Class
