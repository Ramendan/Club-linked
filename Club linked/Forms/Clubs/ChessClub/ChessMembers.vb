Imports System.Data.SqlClient

Public Class ChessMembers

    Public Sub disp_data(myDataGridView As DataGridView, mycmd As String)
        Try

            Main.con.Open()
            Main.cmd = Main.con.CreateCommand()
            Main.cmd.CommandType = CommandType.Text
            Main.cmd.CommandText = mycmd
            Main.cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(Main.cmd)
            da.Fill(dt)
            myDataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox($"Error: {ex}")

        Finally
            Main.con.Close()

        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        disp_data(DataGridView1, "SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess IS NOT NULL")

    End Sub

    Private Sub ChessMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        disp_data(DataGridView1, "SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess IS NOT NULL")

    End Sub
End Class