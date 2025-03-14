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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelatorios))
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.BackgroundImage = CType(resources.GetObject("_pnlClientArea.BackgroundImage"), System.Drawing.Image)
        Me._pnlClientArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 518)
        '
        'RjLabel1
        '
        Me.RjLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 26.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(34, 28)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(889, 42)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "Em Desenvolvimento"
        Me.RjLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjLabel1 As RJLabel
End Class
