<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjPictureBox1 = New PROJETOBASE.RJPictureBox()
        Me.RjPictureBox2 = New PROJETOBASE.RJPictureBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.RjPictureBox2)
        Me._pnlClientArea.Controls.Add(Me.RjPictureBox1)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(772, 640)
        '
        'RjLabel1
        '
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(30, 114)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(716, 521)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = resources.GetString("RjLabel1.Text")
        '
        'RjPictureBox1
        '
        Me.RjPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RjPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjPictureBox1.BorderRadius = 0
        Me.RjPictureBox1.BorderSize = 0
        Me.RjPictureBox1.Customizable = True
        Me.RjPictureBox1.Image = CType(resources.GetObject("RjPictureBox1.Image"), System.Drawing.Image)
        Me.RjPictureBox1.Location = New System.Drawing.Point(589, 15)
        Me.RjPictureBox1.Name = "RjPictureBox1"
        Me.RjPictureBox1.Size = New System.Drawing.Size(148, 77)
        Me.RjPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjPictureBox1.TabIndex = 1
        Me.RjPictureBox1.TabStop = False
        '
        'RjPictureBox2
        '
        Me.RjPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RjPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjPictureBox2.BorderRadius = 0
        Me.RjPictureBox2.BorderSize = 0
        Me.RjPictureBox2.Customizable = True
        Me.RjPictureBox2.Image = Global.PROJETOBASE.My.Resources.Resources.SIBEM_Logo_Cinza_Claro
        Me.RjPictureBox2.Location = New System.Drawing.Point(33, 15)
        Me.RjPictureBox2.Name = "RjPictureBox2"
        Me.RjPictureBox2.Size = New System.Drawing.Size(230, 77)
        Me.RjPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjPictureBox2.TabIndex = 1
        Me.RjPictureBox2.TabStop = False
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(269, 66)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(107, 26)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel2.TabIndex = 2
        Me.RjLabel2.Text = "Versão 4"
        '
        'FormInfo
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Sobre"
        Me.ClientSize = New System.Drawing.Size(774, 682)
        Me.Name = "FormInfo"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Sobre"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.RjPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents RjPictureBox1 As RJPictureBox
    Friend WithEvents RjPictureBox2 As RJPictureBox
    Friend WithEvents RjLabel2 As RJLabel
End Class
