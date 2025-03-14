<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComponentControls
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComponentControls))
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInfo1 = New PROJETOBASE.RJLabel()
        Me.lblInfo2 = New PROJETOBASE.RJLabel()
        Me.lblInfo3 = New PROJETOBASE.RJLabel()
        Me.lblInfo4 = New PROJETOBASE.RJLabel()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.btnDropdownMenu = New PROJETOBASE.RJButton()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.btnDragControl = New PROJETOBASE.RJButton()
        Me.dragControlExample = New PROJETOBASE.RJDragControl(Me.components)
        Me.dmExample = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Submenu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Submenu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Submenu1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Submenu2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dmExample.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.btnDragControl)
        Me._pnlClientArea.Controls.Add(Me.RjLabel5)
        Me._pnlClientArea.Controls.Add(Me.RjLabel6)
        Me._pnlClientArea.Controls.Add(Me.btnDropdownMenu)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.lblInfo4)
        Me._pnlClientArea.Controls.Add(Me.lblInfo3)
        Me._pnlClientArea.Controls.Add(Me.lblInfo2)
        Me._pnlClientArea.Controls.Add(Me.lblInfo1)
        Me._pnlClientArea.Controls.Add(Me.pictureBox1)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(25, 14)
        Me.RjLabel1.MaximumSize = New System.Drawing.Size(900, 0)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(878, 64)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = resources.GetString("RjLabel1.Text")
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(25, 131)
        Me.RjLabel2.MaximumSize = New System.Drawing.Size(900, 0)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(896, 160)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 1
        Me.RjLabel2.Text = resources.GetString("RjLabel2.Text")
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(639, 41)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(264, 73)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInfo1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblInfo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblInfo1.LinkLabel = True
        Me.lblInfo1.Location = New System.Drawing.Point(25, 296)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(47, 16)
        Me.lblInfo1.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblInfo1.TabIndex = 5
        Me.lblInfo1.Text = "Info 1"
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInfo2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblInfo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblInfo2.LinkLabel = True
        Me.lblInfo2.Location = New System.Drawing.Point(78, 296)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(47, 16)
        Me.lblInfo2.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblInfo2.TabIndex = 6
        Me.lblInfo2.Text = "Info 2"
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInfo3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblInfo3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblInfo3.LinkLabel = True
        Me.lblInfo3.Location = New System.Drawing.Point(131, 296)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(47, 16)
        Me.lblInfo3.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblInfo3.TabIndex = 7
        Me.lblInfo3.Text = "Info 3"
        '
        'lblInfo4
        '
        Me.lblInfo4.AutoSize = True
        Me.lblInfo4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInfo4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblInfo4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblInfo4.LinkLabel = True
        Me.lblInfo4.Location = New System.Drawing.Point(184, 296)
        Me.lblInfo4.Name = "lblInfo4"
        Me.lblInfo4.Size = New System.Drawing.Size(47, 16)
        Me.lblInfo4.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblInfo4.TabIndex = 8
        Me.lblInfo4.Text = "Info 4"
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(25, 345)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(606, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 10
        Me.RjLabel3.Text = "Multi-level drop-down menu, appearance is set based on application appearance set" & _
    "tings."
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(24, 322)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(196, 23)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel4.TabIndex = 9
        Me.RjLabel4.Text = "RJ Dropdown Menu"
        '
        'btnDropdownMenu
        '
        Me.btnDropdownMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDropdownMenu.BorderRadius = 0
        Me.btnDropdownMenu.BorderSize = 1
        Me.btnDropdownMenu.Design = PROJETOBASE.ButtonDesign.Normal
        Me.btnDropdownMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDropdownMenu.FlatAppearance.BorderSize = 0
        Me.btnDropdownMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnDropdownMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnDropdownMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDropdownMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDropdownMenu.ForeColor = System.Drawing.Color.White
        Me.btnDropdownMenu.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnDropdownMenu.IconColor = System.Drawing.Color.White
        Me.btnDropdownMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDropdownMenu.IconSize = 24
        Me.btnDropdownMenu.Location = New System.Drawing.Point(28, 364)
        Me.btnDropdownMenu.Name = "btnDropdownMenu"
        Me.btnDropdownMenu.Size = New System.Drawing.Size(170, 40)
        Me.btnDropdownMenu.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDropdownMenu.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnDropdownMenu.TabIndex = 11
        Me.btnDropdownMenu.Text = "Cualquier control"
        Me.btnDropdownMenu.UseVisualStyleBackColor = False
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(25, 441)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(477, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 13
        Me.RjLabel5.Text = "This component allows you to drag / move the form through a control."
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(24, 418)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(162, 23)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel6.TabIndex = 12
        Me.RjLabel6.Text = "RJ Drag Control"
        '
        'btnDragControl
        '
        Me.btnDragControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDragControl.BorderRadius = 0
        Me.btnDragControl.BorderSize = 1
        Me.btnDragControl.Design = PROJETOBASE.ButtonDesign.Normal
        Me.btnDragControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDragControl.FlatAppearance.BorderSize = 0
        Me.btnDragControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnDragControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnDragControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDragControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDragControl.ForeColor = System.Drawing.Color.White
        Me.btnDragControl.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnDragControl.IconColor = System.Drawing.Color.White
        Me.btnDragControl.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDragControl.IconSize = 24
        Me.btnDragControl.Location = New System.Drawing.Point(28, 463)
        Me.btnDragControl.Name = "btnDragControl"
        Me.btnDragControl.Size = New System.Drawing.Size(170, 40)
        Me.btnDragControl.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDragControl.Style = PROJETOBASE.ControlStyle.Solid
        Me.btnDragControl.TabIndex = 14
        Me.btnDragControl.Text = "Cualquier control"
        Me.btnDragControl.UseVisualStyleBackColor = False
        '
        'dragControlExample
        '
        Me.dragControlExample.DragControl = Me.btnDragControl
        '
        'dmExample
        '
        Me.dmExample.ActiveMenuItem = False
        Me.dmExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dmExample.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.Menu2ToolStripMenuItem, Me.Menu3ToolStripMenuItem, Me.Menu4ToolStripMenuItem})
        Me.dmExample.Name = "dmExample"
        Me.dmExample.OwnerIsMenuButton = False
        Me.dmExample.Size = New System.Drawing.Size(124, 92)
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Submenu1ToolStripMenuItem, Me.Submenu2ToolStripMenuItem})
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Menu1ToolStripMenuItem.Text = "Menu 1"
        '
        'Submenu1ToolStripMenuItem
        '
        Me.Submenu1ToolStripMenuItem.Name = "Submenu1ToolStripMenuItem"
        Me.Submenu1ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.Submenu1ToolStripMenuItem.Text = "Submenu 1"
        '
        'Submenu2ToolStripMenuItem
        '
        Me.Submenu2ToolStripMenuItem.Name = "Submenu2ToolStripMenuItem"
        Me.Submenu2ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.Submenu2ToolStripMenuItem.Text = "Submenu 2"
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        Me.Menu2ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Menu2ToolStripMenuItem.Text = "Menu 2"
        '
        'Menu3ToolStripMenuItem
        '
        Me.Menu3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Submenu1ToolStripMenuItem1, Me.Submenu2ToolStripMenuItem1})
        Me.Menu3ToolStripMenuItem.Name = "Menu3ToolStripMenuItem"
        Me.Menu3ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Menu3ToolStripMenuItem.Text = "Menu 3"
        '
        'Submenu1ToolStripMenuItem1
        '
        Me.Submenu1ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Item1ToolStripMenuItem, Me.Item2ToolStripMenuItem})
        Me.Submenu1ToolStripMenuItem1.Name = "Submenu1ToolStripMenuItem1"
        Me.Submenu1ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.Submenu1ToolStripMenuItem1.Text = "Submenu 1"
        '
        'Item1ToolStripMenuItem
        '
        Me.Item1ToolStripMenuItem.Name = "Item1ToolStripMenuItem"
        Me.Item1ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Item1ToolStripMenuItem.Text = "Item 1"
        '
        'Item2ToolStripMenuItem
        '
        Me.Item2ToolStripMenuItem.Name = "Item2ToolStripMenuItem"
        Me.Item2ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Item2ToolStripMenuItem.Text = "Item 2"
        '
        'Submenu2ToolStripMenuItem1
        '
        Me.Submenu2ToolStripMenuItem1.Name = "Submenu2ToolStripMenuItem1"
        Me.Submenu2ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.Submenu2ToolStripMenuItem1.Text = "Submenu 2"
        '
        'Menu4ToolStripMenuItem
        '
        Me.Menu4ToolStripMenuItem.Name = "Menu4ToolStripMenuItem"
        Me.Menu4ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Menu4ToolStripMenuItem.Text = "Menu 4"
        '
        'FormComponentControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Components"
        Me.ClientSize = New System.Drawing.Size(960, 560)
        Me.FormIcon = FontAwesome.Sharp.IconChar.Hive
        Me.Name = "FormComponentControls"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Components"
        Me.Controls.SetChildIndex(Me._pnlClientArea, 0)
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dmExample.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInfo4 As PROJETOBASE.RJLabel
    Friend WithEvents lblInfo3 As PROJETOBASE.RJLabel
    Friend WithEvents lblInfo2 As PROJETOBASE.RJLabel
    Friend WithEvents lblInfo1 As PROJETOBASE.RJLabel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
    Friend WithEvents btnDropdownMenu As PROJETOBASE.RJButton
    Friend WithEvents RjLabel3 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel4 As PROJETOBASE.RJLabel
    Friend WithEvents btnDragControl As PROJETOBASE.RJButton
    Friend WithEvents RjLabel5 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel6 As PROJETOBASE.RJLabel
    Friend WithEvents dragControlExample As PROJETOBASE.RJDragControl
    Friend WithEvents dmExample As PROJETOBASE.RJDropdownMenu
    Friend WithEvents Menu1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Submenu1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Submenu2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Submenu1ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Item1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Item2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Submenu2ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
