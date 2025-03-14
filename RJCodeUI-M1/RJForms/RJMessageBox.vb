Imports PROJETOBASE.Private_

Public MustInherit Class RJMessageBox

    ''' <summary>
    ''' In this abstract class, simply implement static methods to show the custom message box form (<RJMessageForm/>)  and return a DialogResult.
    ''' I tried to integrate most of the show methods from the classic messagebox( <MessageBox.Show/> )which has 21 overloads of this method.
    ''' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox.show?view=net-5.0
    ''' More information about the DialogResult property.
    ''' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.button.dialogresult?view=net-5.0
    ''' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.dialogresult?view=net-5.0
    ''' </summary>      
    ''' <returns>DialogResult</returns>

    Public Shared Function Show(text As String) As DialogResult
        'Displays a message box with the specified text

        Dim result As DialogResult 'Gets or sets the result of the form dialog box.

        'Instantiate the RJMessageForm using USING to properly dispose of the form when it has finished its purpose.
        Using msgForm = New RJMessageForm(text,
                                          "Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) 'Send text parameter and set default values.
            result = msgForm.ShowDialog() 'Show as modal form
        End Using

        Return result 'Return Dialog Result
    End Function

    Public Shared Function Show(text As String, caption As String) As DialogResult
        'Displays a message box with the specified text and title.

        Dim result As DialogResult 'Gets or sets the result of the form dialog box.

        'Instantiate the RJMessageForm using USING to properly dispose of the form when it has finished its purpose.
        Using msgForm = New RJMessageForm(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) 'Set text message and caption to display and other defaults.
            result = msgForm.ShowDialog() 'Show as modal form
        End Using

        Return result 'Return Dialog Result
    End Function

    Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        'Displays a message box with specified text, title, and buttons

        Dim result As DialogResult 'Gets or sets the result of the form dialog box.

        'Instantiate the RJMessageForm using USING to properly dispose of the form when it has finished its purpose.
        Using msgForm = New RJMessageForm(text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) 'Set text messages, caption and buttons to display and other default values.
            result = msgForm.ShowDialog() 'Show as modal form
        End Using

        Return result 'Return Dialog Result
    End Function

    Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        'Displays a message box with specified text, title, buttons and icons

        Dim result As DialogResult 'Gets or sets the result of the form dialog box.

        'Instantiate the RJMessageForm using USING to properly dispose of the form when it has finished its purpose.
        Using msgForm = New RJMessageForm(text, caption, buttons, icon, MessageBoxDefaultButton.Button1) 'Set text message, title, buttons and icons to display and other defaults.
            result = msgForm.ShowDialog() 'Show as modal form
        End Using

        Return result 'Return Dialog Result
    End Function

    Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        'Displays a message box with the specified text, title, buttons, icon, and default button.

        Dim result As DialogResult 'Gets or sets the result of the form dialog box.

        'Instantiate the RJMessageForm using USING to properly dispose of the form when it has finished its purpose.
        Using msgForm = New RJMessageForm(text, caption, buttons, icon, defaultButton) 'Send text message, title, buttons, icon and default button to display
            result = msgForm.ShowDialog() 'Show as modal form
        End Using

        Return result 'Return Dialog Result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String) As DialogResult
        'Displays a message box in front of the specified object and with the specified text

        Dim result As DialogResult 'Gets or sets the result of the form dialog box.

        'Instantiate the RJMessageForm using USING to properly dispose of the form when it has finished its purpose.
        Using msgForm = New RJMessageForm(text, "Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            result = msgForm.ShowDialog(owner) 'Show as modal form
        End Using

        Return result 'Return Dialog Result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String) As DialogResult
        Dim result As DialogResult

        Using msgForm = New RJMessageForm(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            result = msgForm.ShowDialog(owner)
        End Using

        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Dim result As DialogResult

        Using msgForm = New RJMessageForm(text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            result = msgForm.ShowDialog(owner)
        End Using

        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Dim result As DialogResult

        Using msgForm = New RJMessageForm(text, caption, buttons, icon, MessageBoxDefaultButton.Button1)
            result = msgForm.ShowDialog(owner)
        End Using

        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Dim result As DialogResult

        Using msgForm = New RJMessageForm(text, caption, buttons, icon, defaultButton)
            result = msgForm.ShowDialog(owner)
        End Using

        Return result
    End Function
End Class
