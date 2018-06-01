Public Class Form3
    Dim value As Integer = 15000
    Dim value1 As Integer = 10000
    Dim value2 As Integer = 8000


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        
        If (ComboBox2Airline.Text = "Kenya Airways") Then
            value = value * txtpassengers.Text

            lstComputing.Items.Add("Passengers" & txtpassengers.Text)
            lstComputing.Items.Add("Airline: " & ComboBox2Airline.Text)
            lstComputing.Items.Add("Total price= " & value)
            txtpassengers.Clear()
            txtcost.Text = "ksh " & value

        ElseIf (ComboBox2Airline.Text = "FLY 540") Then
            value1 = value1 * txtpassengers.Text

            lstComputing.Items.Add("Passengers" & txtpassengers.Text)
            lstComputing.Items.Add("Airline: " & ComboBox2Airline.Text)
            lstComputing.Items.Add("Total price= " & value1)
            txtpassengers.Clear()
            txtcost.Text = "ksh " & value1

        ElseIf (ComboBox2Airline.Text = "Skieline") Then
            value2 = value2 * txtpassengers.Text

            lstComputing.Items.Add("Passengers " & txtpassengers.Text)
            lstComputing.Items.Add("Airline: " & ComboBox2Airline.Text)
            lstComputing.Items.Add("Total price= " & value2)
            txtpassengers.Clear()
            txtcost.Text = "ksh " & value2

        Else
            MsgBox("Select an airline")


        End If

    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click

        Form4.lstDetails.Items.AddRange(lstComputing.Items)

        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lstComputing.Items.Remove(lstComputing.SelectedItem)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        lstComputing.Items.Clear()
    End Sub
End Class