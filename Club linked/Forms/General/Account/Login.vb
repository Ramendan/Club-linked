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
        gbLogin.Visible = True
        gbRegister.Visible = False
    End Sub

    Private Sub btPassword_MouseHover(sender As Object, e As EventArgs) Handles btShowPassword.MouseHover
        tbPassword.PasswordChar = ""
    End Sub

    Private Sub btShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles btShowPassword.MouseLeave
        tbPassword.PasswordChar = "*"
    End Sub

    Private Sub btShowConfirmPassword_MouseHover(sender As Object, e As EventArgs) Handles btShowConfirmPassword.MouseHover
        tbConfirmPassword.PasswordChar = ""
    End Sub

    Private Sub btShowConfirmPassword_MouseLeave(sender As Object, e As EventArgs) Handles btShowConfirmPassword.MouseLeave
        tbConfirmPassword.PasswordChar = "*"
    End Sub

    Private Sub btShowPasswordLogin_MouseHover(sender As Object, e As EventArgs) Handles btShowPasswordLogin.MouseHover
        tbPasswordlogin.PasswordChar = ""
    End Sub

    Private Sub btShowPasswordLogin_MouseLeave(sender As Object, e As EventArgs) Handles btShowPasswordLogin.MouseLeave
        tbPasswordlogin.PasswordChar = "*"
    End Sub
End Class