Imports System.Data.SqlClient

Public Class ChessMembers
    Private Sub ChessMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        disp_data(DataGridView1, "SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess IS NOT NULL")
        lblCount.Text = $"There are {GetClubMemberCount()} people who are members of the chess club."

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

    Private Sub btnSearchMember_Click(sender As Object, e As EventArgs) Handles btnSearchMember.Click

        If rbRoleSearch.Checked Then
            disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess = '{tbSearch.Text}'")

        ElseIf rbNameSearch.Checked Then
            disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess IS NOT NULL AND username = '{tbSearch.Text}'")

        ElseIf rbIDSearch.Checked Then

            Dim searchID As Integer
            If Integer.TryParse(tbSearch.Text, searchID) Then
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess IS NOT NULL AND userID = '{tbSearch.Text}'")
            Else
                MsgBox($"Please enter an integer, {tbSearch.Text} is not a valid value")
            End If

        End If

    End Sub

    Private Sub tbSearch_Click(sender As Object, e As EventArgs) Handles tbSearch.Click
        tbSearch.Text = ""

    End Sub

    Private Sub rbAdminOnly_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdminOnly.CheckedChanged

        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess = 'Admin'")

    End Sub

    Private Sub rbShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbShowAll.CheckedChanged

        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, chess AS Role FROM Accounts WHERE chess = 'member'")

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

End Class