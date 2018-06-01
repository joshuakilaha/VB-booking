Imports System.Data.OleDb
Imports System.Data
Public Class Form5

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignup.Click

        If txtusername.Text = "" Or txtPassword.Text = "" Or txtconfirmpassword.Text = "" Then
            MsgBox("plz fill the info")
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DatabaseDl.mdb")
                Dim insert As String = "Insert into Table1 values('" & txtusername.Text & "','" & txtPassword.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("create success")
                Me.Close()
            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub
End Class

 