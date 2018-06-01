Public Class Form2

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        lstboxFTD.Items.Add("FROM:  " & ComboBox1from.Text)
        lstboxFTD.Items.Add("TO:  " & ComboBox2To.Text)
        lstboxFTD.Items.Add(DateTimePicker1.Text)


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Form4.lstDetails.Items.AddRange(lstboxFTD.Items)
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lstboxFTD.Items.Remove(lstboxFTD.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        lstboxFTD.Items.Clear()
    End Sub
End Class