Public Class ChessInfo
    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        If Not String.IsNullOrEmpty(Main.ID) Then  ' Check for empty ID

            Try
                Main.con.Open()

                Main.cmd.CommandText = $"UPDATE Accounts SET chess = 'member' WHERE userID = {Main.ID}"

                Main.cmd.ExecuteNonQuery()

                MsgBox("Joined Chess club")

                btnJoin.BackColor = Color.FromArgb(32, 30, 45)
                btnLeave.BackColor = Color.FromArgb(235, 42, 83)

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If Main.con.State = ConnectionState.Open Then
                    Main.con.Close()
                End If
            End Try

        Else
            MsgBox("Please sign in")
        End If

    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        If Not String.IsNullOrEmpty(Main.ID) Then  ' Check for empty ID

            Try
                Main.con.Open()

                Main.cmd.CommandText = $"UPDATE Accounts SET chess = '' WHERE userID = {Main.ID}"

                Main.cmd.ExecuteNonQuery()

                MsgBox("Left Chess club")

                btnLeave.BackColor = Color.FromArgb(32, 30, 45)
                btnJoin.BackColor = Color.FromArgb(235, 42, 83)

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If Main.con.State = ConnectionState.Open Then
                    Main.con.Close()
                End If
            End Try

        Else
            MsgBox("Please sign in")
        End If

    End Sub
End Class