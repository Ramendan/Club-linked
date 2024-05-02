Public Class Login
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub btnShow_signUp_Click(sender As Object, e As EventArgs) Handles btnShow_signUp.Click
        gbLogin.Visible = False
        gbRegister.Visible = True
    End Sub

    Private Sub btnShow_login_Click(sender As Object, e As EventArgs) Handles btnShow_login.Click
        gbRegister.Visible = False
        gbLogin.Visible = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbLogin.Visible = False
        gbRegister.Visible = True
    End Sub
End Class