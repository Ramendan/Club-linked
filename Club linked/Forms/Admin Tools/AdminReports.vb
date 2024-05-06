Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class AdminReports

    Dim i As Integer
    Dim selected_name As String

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub AdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data(DataGridView1, "SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts")
        disp_data(DataGridView2, "SELECT * FROM Reports")

    End Sub

    Public Sub disp_data(myDataGridView As DataGridView, mycmd As String)

        Try
            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If

            Main.con.Open()
            Main.cmd = Main.con.CreateCommand()
            Main.cmd.CommandType = CommandType.Text
            Main.cmd.CommandText = mycmd
            Main.cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(Main.cmd)
            da.Fill(dt)
            myDataGridView.DataSource = dt
            Main.con.Close()

        Catch ex As Exception
            MsgBox($"Error: {ex}")
        End Try

        If Main.con.State = ConnectionState.Open Then
            Main.con.Close()
        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged

        If rbNameSearch.Checked Then
            disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts WHERE username LIKE '{tbSearch.Text}%'")

        ElseIf rbIDSearch.Checked Then

            Dim searchID As Integer
            If Integer.TryParse(tbSearch.Text, searchID) Then
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts WHERE userID LIKE '{tbSearch.Text}%'")
            Else
                MsgBox($"Please enter an integer, {tbSearch.Text} is not a valid value")
            End If

        End If

    End Sub

    Private Sub tbSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles tbSearch.MouseClick
        tbSearch.Text = ""
    End Sub

    Private Sub btnBan_Click(sender As Object, e As EventArgs) Handles btnBan.Click

        Try

            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If

            If Not i = 0 Then
                Main.con.Open()
                Main.cmd = Main.con.CreateCommand()
                Main.cmd.CommandType = CommandType.Text
                Main.cmd.CommandText = $"update Accounts set status = 'Banned' where userID = {i}"
                MsgBox($"Banning user {selected_name} ID:{i}")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status FROM Accounts where userID = {i}")
            Else
                MsgBox("Please select a user to ban")
            End If
        Catch ex As Exception
            MsgBox($"Error: {ex}")

        Finally
            Main.con.Close()
        End Try


    End Sub

    Private Sub btnUnban_Click(sender As Object, e As EventArgs) Handles btnUnban.Click

        Try

            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If

            If Not i = 0 Then
                Main.con.Open()
                Main.cmd = Main.con.CreateCommand()
                Main.cmd.CommandType = CommandType.Text
                Main.cmd.CommandText = $"update Accounts set status = NULL where userID = {i}"
                MsgBox($"Banning user {selected_name} ID:{i}")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status FROM Accounts where userID = {i}")
            Else
                MsgBox("Please select a user to unban")
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex}")

        Finally
            Main.con.Close()
        End Try

    End Sub

    Private Sub btnrbShowAll_Click(sender As Object, e As EventArgs) Handles btnrbShowAll.Click
        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try

            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If
            Main.con.Open()

            i = DataGridView1.SelectedCells.Item(0).Value.ToString() ' 'i' is the selected userID
            selected_name = DataGridView1.SelectedCells.Item(1).Value
            lablelSelectedID.Text = "Selected ID: " + i.ToString()
        Catch ex As Exception
            MsgBox($"Error: {ex}")
        End Try

    End Sub
End Class