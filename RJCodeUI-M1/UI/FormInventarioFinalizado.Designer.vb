<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventarioFinalizado
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
        Me.ChkAbrirRelatorio = New PROJETOBASE.RJCheckBox()
        Me.BtnFinalizar = New PROJETOBASE.RJButton()
        Me.ChkBensEncontrados = New PROJETOBASE.RJCheckBox()
        Me._pnlClientArea.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.BtnFinalizar)
        Me._pnlClientArea.Controls.Add(Me.ChkBensEncontrados)
        Me._pnlClientArea.Controls.Add(Me.ChkAbrirRelatorio)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(398, 162)
        '
        'ChkAbrirRelatorio
        '
        Me.ChkAbrirRelatorio.AutoSize = True
        Me.ChkAbrirRelatorio.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkAbrirRelatorio.BorderSize = 2
        Me.ChkAbrirRelatorio.Check = True
        Me.ChkAbrirRelatorio.Checked = True
        Me.ChkAbrirRelatorio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAbrirRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAbrirRelatorio.Customizable = True
        Me.ChkAbrirRelatorio.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ChkAbrirRelatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkAbrirRelatorio.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkAbrirRelatorio.Location = New System.Drawing.Point(118, 35)
        Me.ChkAbrirRelatorio.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkAbrirRelatorio.Name = "ChkAbrirRelatorio"
        Me.ChkAbrirRelatorio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkAbrirRelatorio.Size = New System.Drawing.Size(170, 21)
        Me.ChkAbrirRelatorio.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkAbrirRelatorio.TabIndex = 0
        Me.ChkAbrirRelatorio.Text = "Visualizar Relatório"
        Me.ChkAbrirRelatorio.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnFinalizar.BorderRadius = 0
        Me.BtnFinalizar.BorderSize = 2
        Me.BtnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinalizar.Design = PROJETOBASE.ButtonDesign.Normal
        Me.BtnFinalizar.FlatAppearance.BorderSize = 0
        Me.BtnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFinalizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnFinalizar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFinalizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnFinalizar.IconSize = 24
        Me.BtnFinalizar.Location = New System.Drawing.Point(152, 120)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(95, 30)
        Me.BtnFinalizar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFinalizar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnFinalizar.TabIndex = 1
        Me.BtnFinalizar.Text = "OK"
        Me.BtnFinalizar.UseVisualStyleBackColor = False
        '
        'ChkBensEncontrados
        '
        Me.ChkBensEncontrados.AutoSize = True
        Me.ChkBensEncontrados.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkBensEncontrados.BorderSize = 2
        Me.ChkBensEncontrados.Check = False
        Me.ChkBensEncontrados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkBensEncontrados.Customizable = True
        Me.ChkBensEncontrados.Enabled = False
        Me.ChkBensEncontrados.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ChkBensEncontrados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkBensEncontrados.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkBensEncontrados.Location = New System.Drawing.Point(118, 62)
        Me.ChkBensEncontrados.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkBensEncontrados.Name = "ChkBensEncontrados"
        Me.ChkBensEncontrados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkBensEncontrados.Size = New System.Drawing.Size(204, 21)
        Me.ChkBensEncontrados.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkBensEncontrados.TabIndex = 0
        Me.ChkBensEncontrados.Text = "Incluir Bens Localizados"
        Me.ChkBensEncontrados.UseVisualStyleBackColor = True
        '
        'FormInventarioFinalizado
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Gerar Relatório"
        Me.ClientSize = New System.Drawing.Size(400, 204)
        Me.DisableFormOptions = True
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.Name = "FormInventarioFinalizado"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Gerar Relatório"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFinalizar As RJButton
    Friend WithEvents ChkAbrirRelatorio As RJCheckBox
    Friend WithEvents ChkBensEncontrados As RJCheckBox
End Class
