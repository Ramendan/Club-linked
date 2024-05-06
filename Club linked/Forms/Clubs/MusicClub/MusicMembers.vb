Imports System.Data.SqlClient

Public Class MusicMembers
    Private Sub MusicMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        disp_data(DataGridView1, "SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE music IS NOT NULL")
        lblCount.Text = $"There are {GetClubMemberCount()} people who are members of the music club."

    End Sub
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

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged

        If rbNameSearch.Checked Then
            disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE music IS NOT NULL AND username LIKE '{tbSearch.Text}%'")

        ElseIf rbIDSearch.Checked Then

            Dim searchID As Integer
            If Integer.TryParse(tbSearch.Text, searchID) Then
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE music IS NOT NULL AND userID LIKE '{tbSearch.Text}%'")
            Else
                MsgBox($"Please enter an integer, {tbSearch.Text} is not a valid value")
            End If
            disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, music AS Role FROM Accounts WHERE music LIKE '{tbSearch.Text}%'")

        End If

    End Sub

    Private Sub tbSearch_Click(sender As Object, e As EventArgs) Handles tbSearch.Click
        tbSearch.Text = ""

    End Sub

    Function GetClubMemberCount() As Integer
        Dim count As Integer = 0

        Try
            Main.con.Open()

            Main.cmd.CommandText = "SELECT COUNT(*) FROM Accounts WHERE music IS NOT NULL"

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

    Private Sub btnrbShowAll_Click(sender As Object, e As EventArgs) Handles btnrbShowAll.Click
        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, music AS Role FROM Accounts WHERE music IS NOT NULL")
    End Sub

    Private Sub btnrbClubAdminSearch_Click(sender As Object, e As EventArgs) Handles btnrbClubAdminSearch.Click
        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, music AS Role FROM Accounts WHERE music = 'Admin'")
    End Sub

End Class