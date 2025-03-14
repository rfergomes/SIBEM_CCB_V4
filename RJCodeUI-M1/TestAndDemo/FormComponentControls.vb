Public Class FormComponentControls

    Private Sub btnDropdownMenu_Click(sender As Object, e As EventArgs) Handles btnDropdownMenu.Click
        dmExample.Show(btnDropdownMenu, DropdownMenuPosition.BottomRight)
    End Sub

    Private Sub lblInfo1_Click(sender As Object, e As EventArgs) Handles lblInfo1.Click
        Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.component?view=net-5.0#definition")
    End Sub

    Private Sub lblInfo2_Click(sender As Object, e As EventArgs) Handles lblInfo2.Click
        Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.contextmenustrip.-ctor?view=net-5.0")
    End Sub

    Private Sub lblInfo3_Click(sender As Object, e As EventArgs) Handles lblInfo3.Click
        Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.timer.-ctor?view=net-5.0#System_Windows_Forms_Timer__ctor_System_ComponentModel_IContainer_")
    End Sub

    Private Sub lblInfo4_Click(sender As Object, e As EventArgs) Handles lblInfo4.Click
        Process.Start("https://stackoverflow.com/a/4603934/12778930")
    End Sub

End Class