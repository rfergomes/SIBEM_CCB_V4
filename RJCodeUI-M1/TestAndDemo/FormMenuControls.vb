Public Class FormMenuControls
    Inherits RJChildForm

    Private Sub btnAnyControl_Click(sender As Object, e As EventArgs) Handles btnAnyControl.Click
        RjDropdownMenu1.Show(btnAnyControl, DropdownMenuPosition.TopRight)
    End Sub
End Class