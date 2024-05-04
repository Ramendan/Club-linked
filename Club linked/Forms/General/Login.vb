Imports System.Data.SqlClient

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
        gbLogin.Visible = True
        gbRegister.Visible = False
        btnLogout.Visible = False
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

        If Len(tbRegiserPass.Text) >= 6 Then
            If tbRegiserPass.Text = tbConfirmPass.Text Then

                Main.cmd = Main.con.CreateCommand()
                Main.cmd.CommandType = CommandType.Text
                Main.cmd.CommandText = $"Insert into Accounts (userID, username, password) values ('{tbID.Text}','{tbName.Text}','{tbRegiserPass.Text}')"
                Main.cmd.ExecuteNonQuery()

                MsgBox($"Welcome {tbName.Text}")
                btnLogout.Visible = True
                gbRegister.Visible = False
                Main.Username = tbName.Text
                Main.ID = tbID.Text
                Label8.Text = $"Currently signed in as: {Main.Username}"

            Else
                MsgBox("Passwords do not match")
            End If
        Else
            MsgBox("Password is less than 6 charctars long")
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Len(tbID_login.Text) > 0 And Len(tbPassword_login.Text) > 0 Then

            Try
                Main.con.Open()

                Main.cmd = Main.con.CreateCommand()
                Main.cmd.CommandText = "SELECT * FROM Accounts WHERE userID = @userID AND password = @password"
                Main.cmd.Parameters.AddWithValue("@userID", tbID_login.Text)
                Main.cmd.Parameters.AddWithValue("@password", tbPassword_login.Text)

                Dim reader As SqlDataReader = Main.cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()

                    MsgBox($"Welcome back, {reader("username").ToString()}!")
                    Main.Username = reader("username").ToString()
                    Main.ID = reader("userID").ToString()
                    Label8.Text = $"Currently signed in as: {Main.Username}"
                    btnLogout.Visible = True
                    gbLogin.Visible = False
                Else
                    MsgBox("Invalid ID or password")
                End If

                reader.Close()
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            Finally
                If Main.con.State = ConnectionState.Open Then
                    Main.con.Close()
                End If
            End Try

        Else
            MsgBox("Please enter ID and password")
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Main.Username = ""
        Main.ID = ""
        MsgBox("Logged out")
        gbLogin.Visible = True
        btnLogout.Visible = False
    End Sub
End Class