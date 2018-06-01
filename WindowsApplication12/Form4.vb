Public Class Form4

    Private Sub btnfinish_Click(sender As System.Object, e As System.EventArgs) Handles btnfinish.Click
        MsgBox("Booking successful, Thank you for booking with us again")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class