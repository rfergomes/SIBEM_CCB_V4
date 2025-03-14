Namespace Private_
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RJMessageForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RJMessageForm))
            Me.pnlMessageText = New System.Windows.Forms.Panel()
            Me.lblMessageText = New System.Windows.Forms.Label()
            Me.pnlIcon = New System.Windows.Forms.Panel()
            Me.pbIcon = New FontAwesome.Sharp.IconPictureBox()
            Me.pnlButtons = New System.Windows.Forms.Panel()
            Me.pnlTittleBar = New System.Windows.Forms.Panel()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.lblCaption = New System.Windows.Forms.Label()
            Me.RjDragControl1 = New PROJETOBASE.RJDragControl(Me.components)
            Me.pnlMessageText.SuspendLayout()
            Me.pnlIcon.SuspendLayout()
            CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTittleBar.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlMessageText
            '
            Me.pnlMessageText.AutoScroll = True
            Me.pnlMessageText.BackColor = System.Drawing.SystemColors.Control
            Me.pnlMessageText.Controls.Add(Me.lblMessageText)
            Me.pnlMessageText.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMessageText.Location = New System.Drawing.Point(51, 41)
            Me.pnlMessageText.Margin = New System.Windows.Forms.Padding(0)
            Me.pnlMessageText.Name = "pnlMessageText"
            Me.pnlMessageText.Size = New System.Drawing.Size(353, 63)
            Me.pnlMessageText.TabIndex = 20
            '
            'lblMessageText
            '
            Me.lblMessageText.AutoSize = True
            Me.lblMessageText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMessageText.ForeColor = System.Drawing.SystemColors.GrayText
            Me.lblMessageText.Location = New System.Drawing.Point(0, 0)
            Me.lblMessageText.MaximumSize = New System.Drawing.Size(345, 0)
            Me.lblMessageText.Name = "lblMessageText"
            Me.lblMessageText.Padding = New System.Windows.Forms.Padding(5, 22, 0, 22)
            Me.lblMessageText.Size = New System.Drawing.Size(54, 61)
            Me.lblMessageText.TabIndex = 1
            Me.lblMessageText.Text = "lblText"
            '
            'pnlIcon
            '
            Me.pnlIcon.BackColor = System.Drawing.Color.WhiteSmoke
            Me.pnlIcon.Controls.Add(Me.pbIcon)
            Me.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlIcon.Location = New System.Drawing.Point(1, 41)
            Me.pnlIcon.Name = "pnlIcon"
            Me.pnlIcon.Size = New System.Drawing.Size(50, 63)
            Me.pnlIcon.TabIndex = 21
            '
            'pbIcon
            '
            Me.pbIcon.BackColor = System.Drawing.Color.WhiteSmoke
            Me.pbIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.pbIcon.IconChar = FontAwesome.Sharp.IconChar.CommentDots
            Me.pbIcon.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.pbIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
            Me.pbIcon.IconSize = 40
            Me.pbIcon.Location = New System.Drawing.Point(7, 20)
            Me.pbIcon.Name = "pbIcon"
            Me.pbIcon.Size = New System.Drawing.Size(40, 40)
            Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.pbIcon.TabIndex = 5
            Me.pbIcon.TabStop = False
            '
            'pnlButtons
            '
            Me.pnlButtons.BackColor = System.Drawing.SystemColors.ControlLight
            Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlButtons.Location = New System.Drawing.Point(1, 104)
            Me.pnlButtons.Name = "pnlButtons"
            Me.pnlButtons.Size = New System.Drawing.Size(403, 60)
            Me.pnlButtons.TabIndex = 19
            '
            'pnlTittleBar
            '
            Me.pnlTittleBar.BackColor = System.Drawing.Color.SeaGreen
            Me.pnlTittleBar.Controls.Add(Me.btnExit)
            Me.pnlTittleBar.Controls.Add(Me.lblCaption)
            Me.pnlTittleBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTittleBar.Location = New System.Drawing.Point(1, 1)
            Me.pnlTittleBar.Name = "pnlTittleBar"
            Me.pnlTittleBar.Size = New System.Drawing.Size(403, 40)
            Me.pnlTittleBar.TabIndex = 18
            '
            'btnExit
            '
            Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnExit.FlatAppearance.BorderSize = 0
            Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
            Me.btnExit.Location = New System.Drawing.Point(363, 0)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(40, 40)
            Me.btnExit.TabIndex = 4
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'lblCaption
            '
            Me.lblCaption.AutoSize = True
            Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCaption.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.lblCaption.Location = New System.Drawing.Point(13, 11)
            Me.lblCaption.Name = "lblCaption"
            Me.lblCaption.Size = New System.Drawing.Size(56, 17)
            Me.lblCaption.TabIndex = 0
            Me.lblCaption.Text = "Caption"
            '
            'RjDragControl1
            '
            Me.RjDragControl1.DragControl = Me.pnlTittleBar
            '
            'RJMessageForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(405, 165)
            Me.Controls.Add(Me.pnlMessageText)
            Me.Controls.Add(Me.pnlIcon)
            Me.Controls.Add(Me.pnlButtons)
            Me.Controls.Add(Me.pnlTittleBar)
            Me.MaximumSize = New System.Drawing.Size(800, 650)
            Me.MinimumSize = New System.Drawing.Size(405, 165)
            Me.Name = "RJMessageForm"
            Me.Padding = New System.Windows.Forms.Padding(1)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "RJMessageForm"
            Me.pnlMessageText.ResumeLayout(False)
            Me.pnlMessageText.PerformLayout()
            Me.pnlIcon.ResumeLayout(False)
            Me.pnlIcon.PerformLayout()
            CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTittleBar.ResumeLayout(False)
            Me.pnlTittleBar.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents pnlMessageText As System.Windows.Forms.Panel
        Private WithEvents lblMessageText As System.Windows.Forms.Label
        Private WithEvents pnlIcon As System.Windows.Forms.Panel
        Private WithEvents pbIcon As FontAwesome.Sharp.IconPictureBox
        Private WithEvents pnlButtons As System.Windows.Forms.Panel
        Private WithEvents pnlTittleBar As System.Windows.Forms.Panel
        Public WithEvents btnExit As System.Windows.Forms.Button
        Private WithEvents lblCaption As System.Windows.Forms.Label
        Friend WithEvents RjDragControl1 As PROJETOBASE.RJDragControl
    End Class
End Namespace