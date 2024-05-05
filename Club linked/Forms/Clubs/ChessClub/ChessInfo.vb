Public Class ChessInfo
    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        If Not String.IsNullOrEmpty(Main.ID) Then  ' Check for empty ID

            Try
                Main.con.Open()

                Main.cmd.CommandText = $"UPDATE Accounts SET chess = 'member' WHERE userID = {Main.ID}"

                Main.cmd.ExecuteNonQuery()

                MsgBox("Joined Chess club")
                btnJoin.Text = "Already in"
                btnLeave.Text = "Leave"
                btnJoin.Enabled = False
                btnLeave.Enabled = True
                btnJoin.BackColor = Color.FromArgb(32, 30, 45)
                btnLeave.BackColor = Color.FromArgb(235, 42, 83)
                lblCount.Text = $"There are {GetClubMemberCount() + 1} people who are members of the chess club."

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
                btnLeave.Text = "Already left"
                btnJoin.Text = "Join"
                btnLeave.Enabled = False
                btnJoin.Enabled = True
                btnLeave.BackColor = Color.FromArgb(32, 30, 45)
                btnJoin.BackColor = Color.FromArgb(235, 42, 83)
                lblCount.Text = $"There are {GetClubMemberCount()} people who are members of the chess club."

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

    Function GetClubMemberCount() As Integer
        Dim count As Integer = 0

        Try
            Main.con.Open()

            Main.cmd.CommandText = "SELECT COUNT(*) FROM Accounts WHERE chess IS NOT NULL"

            count = CInt(Main.cmd.ExecuteScalar())

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()
            End If
        End Try

        Return count
    End Function

    Private Sub ChessInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCount.Text = $"There are {GetClubMemberCount()} people who are members of the chess club."
    End Sub

    Private Sub lblCount_Click(sender As Object, e As EventArgs) Handles lblCount.Click

    End Sub
End Class