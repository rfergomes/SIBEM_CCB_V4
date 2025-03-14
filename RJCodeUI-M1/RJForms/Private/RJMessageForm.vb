Imports FontAwesome.Sharp

Namespace Private_
    Public Class RJMessageForm

        ''' <summary>
        ''' More information about the DialogResult property.
        ''' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.button.dialogresult?view=net-5.0
        ''' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.dialogresult?view=net-5.0
        ''' </summary>
        ''' 

#Region "-> Fields"

        Private button1 As Button 'Number 1 button
        Private button2 As Button 'Number 2 button
        Private button3 As Button 'Number 3 button
#End Region

#Region "-> Constructor"

        Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) 'Parameters required for a message box
            InitializeComponent() 'This form was created with the form designer.
            Me.FormBorderStyle = FormBorderStyle.None 'Remove form border
            Me.lblCaption.Text = caption 'Set caption
            Me.lblMessageText.Text = text 'Set the message text
            CreateIcon(icon) 'Create message box icon
            CreateButtons(buttons, defaultButton) 'Create message box icon
            ApplyAppearanceSettings() 'Apply settings
        End Sub
#End Region

#Region "-> Private methods"

        Private Sub ApplyAppearanceSettings()
            'Apply theme settings

            Me.pnlTittleBar.BackColor = UIAppearance.PrimaryStyleColor 'Set title bar background color
            Me.BackColor = RJColors.DefaultFormBorderColor 'Set the border color of the form
            If UIAppearance.Theme = UITheme.Light Then 'Light Topic
                'Set background color
                Me.pnlMessageText.BackColor = RJColors.LightBackground
                Me.pnlIcon.BackColor = RJColors.LightBackground
                'Set button panel background color
                Me.pnlButtons.BackColor = RJColors.LightActiveBackground
                'Set text color.
                Me.lblMessageText.ForeColor = UIAppearance.TextColor

            Else 'Dark Theme
                'Set background color
                Me.pnlMessageText.BackColor = RJColors.DarkBackground
                Me.pnlIcon.BackColor = RJColors.DarkBackground
                'Set button panel background color
                Me.pnlButtons.BackColor = ColorEditor.Darken(RJColors.DarkBackground, 3)
                'Set text color.
                Me.lblMessageText.ForeColor = ColorEditor.Lighten(UIAppearance.TextColor, 12)
            End If

            Me.lblMessageText.MaximumSize = New Size(600, 0) 'Set 600 pixels as maximum width of the text message label
            'Set the size of the message box
            Me.Size = New Size(width:=Me.lblMessageText.Width + Me.pnlIcon.Width + 50,
                               height:=Me.lblMessageText.Height + Me.pnlTittleBar.Height + Me.pnlButtons.Height + 5)
        End Sub

        Private Sub CreateIcon(icon As MessageBoxIcon)
            'Set message box icon
            Select Case icon
                Case MessageBoxIcon.Error 'Error
                    Me.pbIcon.IconChar = IconChar.TimesCircle
                    Me.pbIcon.IconColor = Color.FromArgb(241, 98, 96)

                Case MessageBoxIcon.Information 'Information
                    Me.pbIcon.IconChar = IconChar.InfoCircle
                    Me.pbIcon.IconColor = Color.FromArgb(20, 161, 228)

                Case MessageBoxIcon.Question 'Question
                    Me.pbIcon.IconChar = IconChar.QuestionCircle
                    Me.pbIcon.IconColor = Color.CornflowerBlue

                Case MessageBoxIcon.Exclamation 'Exclamation
                    Me.pbIcon.IconChar = IconChar.ExclamationTriangle
                    Me.pbIcon.IconColor = Color.FromArgb(255, 177, 17)

                Case MessageBoxIcon.None 'None
                    Me.pbIcon.IconChar = IconChar.CommentDots
                    Me.pbIcon.IconColor = Color.FromArgb(236, 93, 123)
            End Select
        End Sub

        Private Sub CreateButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
            'Set the buttons for the message box and specify the default button for the message box.
            Select Case buttons
                Case MessageBoxButtons.OK
                    button1 = OKButton(143, 13)
                Case MessageBoxButtons.OKCancel
                    button1 = OKButton(79, 13)
                    button2 = CancelButton1(205, 13)
                Case MessageBoxButtons.YesNo
                    button1 = YesButton(79, 13)
                    button2 = NoButton(205, 13)
                Case MessageBoxButtons.YesNoCancel
                    button1 = YesButton(20, 13)
                    button2 = NoButton(146, 13)
                    button3 = CancelButton1(272, 13)
                Case MessageBoxButtons.RetryCancel
                    button1 = RetryButton(79, 13)
                    button2 = CancelButton1(205, 13)
                Case MessageBoxButtons.AbortRetryIgnore
                    button1 = AbortButton(20, 13)
                    button2 = RetryButton(146, 13)
                    button3 = IgnoreButton(272, 13)
            End Select

            ActivateButton(defaultButton) 'Specify the default button for the message box.
        End Sub

        Private Sub ActivateButton(defaultButton As MessageBoxDefaultButton)
            'Focus the default button and the user can directly press the Enter key to perform the button action
            Select Case defaultButton
                Case MessageBoxDefaultButton.Button1 'Focus Button 1
                    button1.Select()
                    button1.ForeColor = Color.White
                    button1.Text = button1.Text

                Case MessageBoxDefaultButton.Button2 'Focus Button 2
                    If button2 IsNot Nothing Then
                        button2.Select()
                        button2.Text = button2.Text
                        button2.ForeColor = Color.White
                    Else 'If button 2 does not exist, focus button 1
                        button1.Select()
                        button1.ForeColor = Color.White
                        button1.Text = button1.Text
                    End If

                Case MessageBoxDefaultButton.Button3 'Focus Button 3
                    If button3 IsNot Nothing Then
                        button3.Select()
                        button3.ForeColor = Color.White
                        button3.Text = button3.Text
                    Else 'If button 3 does not exist, focus button 1
                        button1.Select()
                        button1.ForeColor = Color.White
                        button1.Text = button1.Text
                    End If
            End Select
        End Sub

        '-> Message box buttons

        Private Function OKButton(locationX As Integer, locationY As Integer) As Button
            'Create OK button
            Dim btnOk As Button
            btnOk = New Button()
            btnOk.Anchor = AnchorStyles.None
            btnOk.BackColor = UIAppearance.StyleColor
            btnOk.FlatAppearance.BorderSize = 0
            btnOk.FlatStyle = FlatStyle.Flat
            btnOk.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnOk.ForeColor = Color.WhiteSmoke
            btnOk.Location = New Point(locationX, locationY)
            btnOk.Name = "btnOk"
            btnOk.Size = New Size(110, 35)
            btnOk.Text = "Ok"
            btnOk.UseVisualStyleBackColor = False
            btnOk.DialogResult = DialogResult.OK 'Set DialogResult
            pnlButtons.Controls.Add(btnOk) 'Add button
            Return btnOk
        End Function

        Private Function CancelButton1(locationX As Integer, locationY As Integer) As Button
            'Create Cancel button
            Dim btnCancel As Button
            btnCancel = New Button()
            btnCancel.Anchor = AnchorStyles.None
            btnCancel.BackColor = RJColors.Cancel
            btnCancel.FlatAppearance.BorderSize = 0
            btnCancel.FlatStyle = FlatStyle.Flat
            btnCancel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnCancel.ForeColor = Color.WhiteSmoke
            btnCancel.Location = New Point(locationX, locationY)
            btnCancel.Name = "btnCancel"
            btnCancel.Size = New Size(110, 35)
            btnCancel.Text = "Cancelar"
            btnCancel.UseVisualStyleBackColor = False
            btnCancel.DialogResult = DialogResult.Cancel 'Set DialogResult
            pnlButtons.Controls.Add(btnCancel) 'Add button
            Return btnCancel
        End Function

        Private Function YesButton(locationX As Integer, locationY As Integer) As Button
            'Create button Yes.
            Dim btnYes As Button
            btnYes = New Button()
            btnYes.Anchor = AnchorStyles.None
            btnYes.BackColor = RJColors.Confirm
            btnYes.FlatAppearance.BorderSize = 0
            btnYes.FlatStyle = FlatStyle.Flat
            btnYes.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnYes.ForeColor = Color.WhiteSmoke
            btnYes.Location = New Point(locationX, locationY)
            btnYes.Name = "btnYes"
            btnYes.Size = New Size(110, 35)
            btnYes.Text = "Sim"
            btnYes.UseVisualStyleBackColor = False
            btnYes.DialogResult = DialogResult.Yes ' Set DialogResult
            pnlButtons.Controls.Add(btnYes) 'Add button
            Return btnYes
        End Function

        Private Function NoButton(locationX As Integer, locationY As Integer) As Button
            'Create button No.
            Dim btnNo As Button
            btnNo = New Button()
            btnNo.Anchor = AnchorStyles.None
            btnNo.BackColor = RJColors.Delete
            btnNo.FlatAppearance.BorderSize = 0
            btnNo.FlatStyle = FlatStyle.Flat
            btnNo.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnNo.ForeColor = Color.WhiteSmoke
            btnNo.Location = New Point(locationX, locationY)
            btnNo.Name = "btnNo"
            btnNo.Size = New Size(110, 35)
            btnNo.Text = "Não"
            btnNo.UseVisualStyleBackColor = False
            btnNo.DialogResult = DialogResult.No 'Set DialogResult
            pnlButtons.Controls.Add(btnNo) 'Add button
            Return btnNo
        End Function

        Private Function RetryButton(locationX As Integer, locationY As Integer) As Button
            'Create Retry button.
            Dim btnRetry As Button
            btnRetry = New Button()
            btnRetry.Anchor = AnchorStyles.None
            btnRetry.BackColor = UIAppearance.StyleColor
            btnRetry.FlatAppearance.BorderSize = 0
            btnRetry.FlatStyle = FlatStyle.Flat
            btnRetry.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnRetry.ForeColor = Color.WhiteSmoke
            btnRetry.Location = New Point(locationX, locationY)
            btnRetry.Name = "btnRetry"
            btnRetry.Size = New Size(110, 35)
            btnRetry.Text = "Tentar"
            btnRetry.UseVisualStyleBackColor = False
            btnRetry.DialogResult = DialogResult.Retry 'Set DialogResult
            pnlButtons.Controls.Add(btnRetry) 'Add button
            Return btnRetry
        End Function

        Private Function AbortButton(locationX As Integer, locationY As Integer) As Button
            'Create Abort button
            Dim btnAbort As Button
            btnAbort = New Button()
            btnAbort.Anchor = AnchorStyles.None
            btnAbort.BackColor = RJColors.Delete
            btnAbort.FlatAppearance.BorderSize = 0
            btnAbort.FlatStyle = FlatStyle.Flat
            btnAbort.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnAbort.ForeColor = Color.WhiteSmoke
            btnAbort.Location = New Point(locationX, locationY)
            btnAbort.Name = "btnAbort"
            btnAbort.Size = New Size(110, 35)
            btnAbort.Text = "Abortar"
            btnAbort.UseVisualStyleBackColor = False
            btnAbort.DialogResult = DialogResult.Abort 'Set DialogResult
            pnlButtons.Controls.Add(btnAbort) 'Add button
            Return btnAbort
        End Function

        Private Function IgnoreButton(locationX As Integer, locationY As Integer) As Button
            'Create ignore button
            Dim btnIgnore As Button
            btnIgnore = New Button()
            btnIgnore.Anchor = AnchorStyles.None
            btnIgnore.BackColor = RJColors.Cancel
            btnIgnore.FlatAppearance.BorderSize = 0
            btnIgnore.FlatStyle = FlatStyle.Flat
            btnIgnore.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            btnIgnore.ForeColor = Color.WhiteSmoke
            btnIgnore.Location = New Point(locationX, locationY)
            btnIgnore.Name = "btnIgnore"
            btnIgnore.Size = New Size(110, 35)
            btnIgnore.Text = "Ignorar"
            btnIgnore.UseVisualStyleBackColor = False
            btnIgnore.DialogResult = DialogResult.Ignore 'Set DialogResult
            pnlButtons.Controls.Add(btnIgnore) 'Add button
            Return btnIgnore
        End Function
#End Region

#Region "-> Event methods"

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Me.Close() 'Close message box
        End Sub
#End Region

    End Class
End Namespace