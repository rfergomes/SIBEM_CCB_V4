<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventarioResponsaveis
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
        Me.TxtInventariantes = New PROJETOBASE.RJTextBox()
        Me.RjLabel11 = New PROJETOBASE.RJLabel()
        Me.TxtResponsaveis = New PROJETOBASE.RJTextBox()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.BtanCancelar = New PROJETOBASE.RJButton()
        Me._pnlClientArea.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.BtanCancelar)
        Me._pnlClientArea.Controls.Add(Me.BtnSalvar)
        Me._pnlClientArea.Controls.Add(Me.TxtInventariantes)
        Me._pnlClientArea.Controls.Add(Me.RjLabel11)
        Me._pnlClientArea.Controls.Add(Me.TxtResponsaveis)
        Me._pnlClientArea.Controls.Add(Me.RjLabel9)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(423, 422)
        '
        'TxtInventariantes
        '
        Me.TxtInventariantes._Customizable = True
        Me.TxtInventariantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtInventariantes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtInventariantes.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtInventariantes.BorderRadius = 0
        Me.TxtInventariantes.BorderSize = 2
        Me.TxtInventariantes.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.TxtInventariantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtInventariantes.Location = New System.Drawing.Point(13, 222)
        Me.TxtInventariantes.MultiLine = True
        Me.TxtInventariantes.Name = "TxtInventariantes"
        Me.TxtInventariantes.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtInventariantes.PasswordChar = False
        Me.TxtInventariantes.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtInventariantes.PlaceHolderText = "Informar o nome dos Irmãos que estão inventariando a Casa de Oração"
        Me.TxtInventariantes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtInventariantes.Size = New System.Drawing.Size(395, 150)
        Me.TxtInventariantes.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtInventariantes.TabIndex = 128
        Me.TxtInventariantes.Tag = "INVENTARIANTES"
        '
        'RjLabel11
        '
        Me.RjLabel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel11.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel11.LinkLabel = False
        Me.RjLabel11.Location = New System.Drawing.Point(13, 200)
        Me.RjLabel11.Name = "RjLabel11"
        Me.RjLabel11.Size = New System.Drawing.Size(395, 23)
        Me.RjLabel11.Style = PROJETOBASE.LabelStyle.BarCaption
        Me.RjLabel11.TabIndex = 125
        Me.RjLabel11.Text = "INVENTARIANTES"
        Me.RjLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtResponsaveis
        '
        Me.TxtResponsaveis._Customizable = True
        Me.TxtResponsaveis.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtResponsaveis.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtResponsaveis.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtResponsaveis.BorderRadius = 0
        Me.TxtResponsaveis.BorderSize = 2
        Me.TxtResponsaveis.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.TxtResponsaveis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtResponsaveis.Location = New System.Drawing.Point(13, 36)
        Me.TxtResponsaveis.MultiLine = True
        Me.TxtResponsaveis.Name = "TxtResponsaveis"
        Me.TxtResponsaveis.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtResponsaveis.PasswordChar = False
        Me.TxtResponsaveis.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtResponsaveis.PlaceHolderText = "Informar o Nome dos Responsáveis presentes da Casa de Oração"
        Me.TxtResponsaveis.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtResponsaveis.Size = New System.Drawing.Size(395, 150)
        Me.TxtResponsaveis.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtResponsaveis.TabIndex = 127
        Me.TxtResponsaveis.Tag = "RESPONSÁVEIS"
        '
        'RjLabel9
        '
        Me.RjLabel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(13, 14)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(395, 23)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.BarCaption
        Me.RjLabel9.TabIndex = 126
        Me.RjLabel9.Text = "RESPONSÁVEIS"
        Me.RjLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 0
        Me.BtnSalvar.BorderSize = 1
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSalvar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(212, 378)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(95, 30)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSalvar.TabIndex = 130
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtanCancelar
        '
        Me.BtanCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtanCancelar.BorderRadius = 0
        Me.BtanCancelar.BorderSize = 1
        Me.BtanCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtanCancelar.Design = PROJETOBASE.ButtonDesign.Cancel
        Me.BtanCancelar.FlatAppearance.BorderSize = 0
        Me.BtanCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtanCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtanCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtanCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtanCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtanCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtanCancelar.IconColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtanCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtanCancelar.IconSize = 24
        Me.BtanCancelar.Location = New System.Drawing.Point(313, 378)
        Me.BtanCancelar.Name = "BtanCancelar"
        Me.BtanCancelar.Size = New System.Drawing.Size(95, 30)
        Me.BtanCancelar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtanCancelar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtanCancelar.TabIndex = 130
        Me.BtanCancelar.Text = "Cancelar"
        Me.BtanCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtanCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtanCancelar.UseVisualStyleBackColor = False
        '
        'FormInventarioResponsaveis
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Responsáveis e Inventariantes"
        Me.ClientSize = New System.Drawing.Size(425, 464)
        Me.Name = "FormInventarioResponsaveis"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Responsáveis e Inventariantes"
        Me._pnlClientArea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSalvar As RJButton
    Friend WithEvents TxtInventariantes As RJTextBox
    Friend WithEvents RjLabel11 As RJLabel
    Friend WithEvents TxtResponsaveis As RJTextBox
    Friend WithEvents RjLabel9 As RJLabel
    Friend WithEvents BtanCancelar As RJButton
End Class
