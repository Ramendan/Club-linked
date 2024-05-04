Public Class Login
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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

    Private Sub btnLoginShowPass_MouseHover(sender As Object, e As EventArgs) Handles btnLoginShowPass.MouseHover
        tbPassword_login.PasswordChar = ""
    End Sub

    Private Sub btnLoginShowPass_MouseLeave(sender As Object, e As EventArgs) Handles btnLoginShowPass.MouseLeave
        tbPassword_login.PasswordChar = "*"
        btnHideLoginPass.Visible = True
    End Sub

    Private Sub btnConfirmShowPass_MouseHover(sender As Object, e As EventArgs) Handles btnConfirmShowPass.MouseHover
        tbConfirmPass.PasswordChar = ""
    End Sub

    Private Sub btnConfirmShowPass_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirmShowPass.MouseLeave
        tbConfirmPass.PasswordChar = "*"
        btnHideConfirmPass.Visible = True
    End Sub

    Private Sub btnRigShowPass_MouseHover(sender As Object, e As EventArgs) Handles btnRigShowPass.MouseHover
        tbRegiserPass.PasswordChar = ""
    End Sub

    Private Sub btnRigShowPass_MouseLeave(sender As Object, e As EventArgs) Handles btnRigShowPass.MouseLeave
        tbRegiserPass.PasswordChar = "*"
        btnHideRegisterPass.Visible = True
    End Sub
    Private Sub btnHideRegisterPass_MouseHover(sender As Object, e As EventArgs) Handles btnHideRegisterPass.MouseHover
        btnHideRegisterPass.Visible = False
    End Sub
    Private Sub btnHideConfirmPass_MouseHover(sender As Object, e As EventArgs) Handles btnHideConfirmPass.MouseHover
        btnHideConfirmPass.Visible = False
    End Sub
    Private Sub btnHideLoginPass_MouseHover(sender As Object, e As EventArgs) Handles btnHideLoginPass.MouseHover
        btnHideLoginPass.Visible = False
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        If tbRegiserPass.Text = tbConfirmPass.Text Then

            Main.cmd = Main.con.CreateCommand()
            Main.cmd.CommandType = CommandType.Text
            Main.cmd.CommandText = "Insert into Accounts (userID, username, password) values ('" + tbID.Text + "','" + tbName.Text + "','" + tbRegiserPass.Text + "')"
            Main.cmd.ExecuteNonQuery()

            MsgBox($"Welcome {tbName.Text}")
        ElseIf len(tbRegiserPass.Text) <= 5 Then
            MsgBox("Passwords do not match")
        End If

    End Sub
End Class