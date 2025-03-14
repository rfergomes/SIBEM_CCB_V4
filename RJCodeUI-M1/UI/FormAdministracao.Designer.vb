<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministracao
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
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.CboAdm = New PROJETOBASE.RJComboBox()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.BtnCancelar = New PROJETOBASE.RJButton()
        Me._pnlClientArea.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.BtnCancelar)
        Me._pnlClientArea.Controls.Add(Me.BtnSalvar)
        Me._pnlClientArea.Controls.Add(Me.CboAdm)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(578, 254)
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(180, 10)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(242, 26)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Title
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "Trocar Administração"
        '
        'RjLabel2
        '
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(98, 48)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(383, 72)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Description
        Me.RjLabel2.TabIndex = 1
        Me.RjLabel2.Text = "Veja abaixo a lista de Administrações que você tem permissão de acesso." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seleci" &
    "one a administração e clique em Salvar."
        Me.RjLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboAdm
        '
        Me.CboAdm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboAdm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboAdm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboAdm.BorderRadius = 0
        Me.CboAdm.BorderSize = 1
        Me.CboAdm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboAdm.Customizable = False
        Me.CboAdm.DataSource = Nothing
        Me.CboAdm.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboAdm.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboAdm.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboAdm.Location = New System.Drawing.Point(101, 135)
        Me.CboAdm.Name = "CboAdm"
        Me.CboAdm.Padding = New System.Windows.Forms.Padding(2)
        Me.CboAdm.SelectedIndex = -1
        Me.CboAdm.SelectedItem = Nothing
        Me.CboAdm.SelectedValue = Nothing
        Me.CboAdm.Size = New System.Drawing.Size(380, 32)
        Me.CboAdm.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboAdm.TabIndex = 2
        Me.CboAdm.Texts = ""
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 0
        Me.BtnSalvar.BorderSize = 1
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.Confirm
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSalvar.IconColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(159, 199)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(95, 30)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSalvar.TabIndex = 3
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnCancelar.BorderRadius = 0
        Me.BtnCancelar.BorderSize = 1
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Design = PROJETOBASE.ButtonDesign.Cancel
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtnCancelar.IconColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCancelar.IconSize = 24
        Me.BtnCancelar.Location = New System.Drawing.Point(318, 199)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 30)
        Me.BtnCancelar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCancelar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'FormAdministracao
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Trocar Administração"
        Me.ClientSize = New System.Drawing.Size(580, 296)
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.Name = "FormAdministracao"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Trocar Administração"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents BtnCancelar As RJButton
    Friend WithEvents BtnSalvar As RJButton
    Friend WithEvents CboAdm As RJComboBox
    Friend WithEvents RjLabel2 As RJLabel
End Class
