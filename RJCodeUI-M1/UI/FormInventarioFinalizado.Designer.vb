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
        Me.GpbSincronizar = New System.Windows.Forms.GroupBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.ChkSincronizar = New PROJETOBASE.RJCheckBox()
        Me._pnlClientArea.SuspendLayout()
        Me.GpbSincronizar.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.White
        Me._pnlClientArea.Controls.Add(Me.GpbSincronizar)
        Me._pnlClientArea.Controls.Add(Me.BtnFinalizar)
        Me._pnlClientArea.Controls.Add(Me.ChkBensEncontrados)
        Me._pnlClientArea.Controls.Add(Me.ChkAbrirRelatorio)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(398, 300)
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
        Me.ChkAbrirRelatorio.Location = New System.Drawing.Point(97, 35)
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
        Me.BtnFinalizar.BorderRadius = 5
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
        Me.BtnFinalizar.Location = New System.Drawing.Point(97, 244)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(204, 30)
        Me.BtnFinalizar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnFinalizar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnFinalizar.TabIndex = 1
        Me.BtnFinalizar.Text = "Gerar Relatório"
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
        Me.ChkBensEncontrados.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ChkBensEncontrados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkBensEncontrados.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ChkBensEncontrados.Location = New System.Drawing.Point(97, 62)
        Me.ChkBensEncontrados.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkBensEncontrados.Name = "ChkBensEncontrados"
        Me.ChkBensEncontrados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkBensEncontrados.Size = New System.Drawing.Size(204, 21)
        Me.ChkBensEncontrados.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkBensEncontrados.TabIndex = 0
        Me.ChkBensEncontrados.Text = "Incluir Bens Localizados"
        Me.ChkBensEncontrados.UseVisualStyleBackColor = True
        '
        'GpbSincronizar
        '
        Me.GpbSincronizar.Controls.Add(Me.RjLabel1)
        Me.GpbSincronizar.Controls.Add(Me.ChkSincronizar)
        Me.GpbSincronizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbSincronizar.ForeColor = System.Drawing.Color.Red
        Me.GpbSincronizar.Location = New System.Drawing.Point(45, 103)
        Me.GpbSincronizar.Name = "GpbSincronizar"
        Me.GpbSincronizar.Size = New System.Drawing.Size(308, 114)
        Me.GpbSincronizar.TabIndex = 4
        Me.GpbSincronizar.TabStop = False
        Me.GpbSincronizar.Text = "Atenção"
        Me.GpbSincronizar.Visible = False
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Bold)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(14, 21)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(282, 48)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel1.TabIndex = 3
        Me.RjLabel1.Text = "Este inventário foi reaberto." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se quiser compartilhar as alterações, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "marque a o" &
    "pção sincronizar"
        Me.RjLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkSincronizar
        '
        Me.ChkSincronizar.AutoSize = True
        Me.ChkSincronizar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkSincronizar.BorderSize = 2
        Me.ChkSincronizar.Check = False
        Me.ChkSincronizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkSincronizar.Customizable = True
        Me.ChkSincronizar.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ChkSincronizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkSincronizar.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkSincronizar.Location = New System.Drawing.Point(97, 80)
        Me.ChkSincronizar.MinimumSize = New System.Drawing.Size(0, 21)
        Me.ChkSincronizar.Name = "ChkSincronizar"
        Me.ChkSincronizar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ChkSincronizar.Size = New System.Drawing.Size(115, 21)
        Me.ChkSincronizar.Style = PROJETOBASE.ControlStyle.Glass
        Me.ChkSincronizar.TabIndex = 2
        Me.ChkSincronizar.Text = "Sincronizar"
        Me.ChkSincronizar.UseVisualStyleBackColor = True
        '
        'FormInventarioFinalizado
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Gerar Relatório"
        Me.ClientSize = New System.Drawing.Size(400, 342)
        Me.DisableFormOptions = True
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.Name = "FormInventarioFinalizado"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Gerar Relatório"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.GpbSincronizar.ResumeLayout(False)
        Me.GpbSincronizar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFinalizar As RJButton
    Friend WithEvents ChkAbrirRelatorio As RJCheckBox
    Friend WithEvents ChkBensEncontrados As RJCheckBox
    Friend WithEvents GpbSincronizar As GroupBox
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents ChkSincronizar As RJCheckBox
End Class
