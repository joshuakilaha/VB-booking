
Public Class Form1

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim login = DetailsTableAdapter.UserPasswordSting(txtusername.Text, txtPassword.Text)


        If txtusername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Fill in the information")
            txtusername.Clear()
            txtPassword.Clear()

        ElseIf login Is Nothing Then
            MsgBox("Wrong password or username!!! TRY AGAIN", MsgBoxStyle.Critical)
            txtusername.Clear()
            txtPassword.Clear()

        Else
          
            MsgBox("welcome", MsgBoxStyle.Information)
            Me.Hide()
            Form2.Show()
            txtusername.Clear()
            txtPassword.Clear()

        End If

    End Sub

    Private Sub btnSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignup.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString()
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet.details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.LoginDataSet.details)

        Timer1.Start()
    End Sub
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        System.Diagnostics.Process.Start("https://mcben267.wordpress.com")
    End Sub

End Class
