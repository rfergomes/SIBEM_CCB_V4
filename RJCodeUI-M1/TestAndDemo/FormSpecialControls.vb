Public Class FormSpecialControls
    Inherits RJChildForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RjProgressBar1.Value < RjProgressBar1.Maximum Then
            RjProgressBar1.Value += 1
            RjProgressBar2.Value += 1
        Else
            Timer1.[Stop]()
        End If
    End Sub

    Private Sub RjButton2_Click(sender As Object, e As EventArgs) Handles RjButton2.Click
        RjProgressBar1.Value = 0
        RjProgressBar2.Value = 0
        Timer1.Start()
    End Sub

    Private Sub FormSpecialControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rjProgressBar2.ForeBackColor = Me.BackColor
    End Sub
End Class