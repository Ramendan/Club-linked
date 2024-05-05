Imports System.Data.SqlClient

Public Class labelSelectedID

    Dim i As Integer
    Dim selected_name As String

    Private Sub Admin_Privileges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedItem = "All"
        disp_data(DataGridView1, "SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts")
        lblCount.Text = $"There are {GetClubMemberCount("")} people who are users of club linked,{Environment.NewLine}{GetClubMemberCount("Admin")} of them are app admins and {GetClubMemberCount("Club")} are club admins"

    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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

        Finally
            Main.con.Close()

        End Try

    End Sub

    Function GetClubMemberCount(Type As String) As Integer
        Dim count As Integer = 0

        Try
            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If

            Main.con.Open()

            If Type = "Admin" Then
                Main.cmd.CommandText = "SELECT COUNT(*) FROM Accounts where status = 'Admin'"
            ElseIf Type = "Club" Then
                Main.cmd.CommandText = "SELECT COUNT(*) FROM Accounts where chess = 'Admin' OR programming = 'Admin' OR music = 'Admin' OR reading = 'Admin'"
            Else
                Main.cmd.CommandText = "SELECT COUNT(*) FROM Accounts"
            End If
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
    Private Sub tbSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles tbSearch.MouseClick
        tbSearch.Text = ""
    End Sub

    Private Sub btnSearchUsr_Click(sender As Object, e As EventArgs) Handles btnSearchUsr.Click

        If rbNameSearch.Checked Then
            disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts WHERE username = '{tbSearch.Text}'")

        ElseIf rbIDSearch.Checked Then

            Dim searchID As Integer
            If Integer.TryParse(tbSearch.Text, searchID) Then
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts WHERE userID = '{tbSearch.Text}'")
            Else
                MsgBox($"Please enter an integer, {tbSearch.Text} is not a valid value")
            End If

        End If

    End Sub

    Private Sub rbShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbShowAll.CheckedChanged
        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts")
    End Sub

    Private Sub rbAdminOnly_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdminOnly.CheckedChanged
        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts WHERE status = 'Admin'")
    End Sub

    Private Sub rbClubAdminSearch_CheckedChanged(sender As Object, e As EventArgs) Handles rbClubAdminSearch.CheckedChanged

        disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts WHERE chess = 'Admin' OR programming = 'Admin' OR music = 'Admin' OR reading = 'Admin'")
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

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click

        Try

            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If

            Main.con.Open()
            Main.cmd = Main.con.CreateCommand()
            Main.cmd.CommandType = CommandType.Text


            If ListBox1.SelectedItem = "All" Then

                Main.cmd.CommandText = $"update Accounts set status = 'Admin' where userID = {i}"
                MsgBox($"Giving user {selected_name} ID:{i} global admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Programming" Then

                Main.cmd.CommandText = $"update Accounts set Programming = 'Admin' where userID = {i}"
                MsgBox($"Giving user {selected_name} ID:{i} Programming admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Chess" Then

                Main.cmd.CommandText = $"update Accounts set Chess = 'Admin' where userID = {i}"
                MsgBox($"Giving user {selected_name} ID:{i} Chess admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Music" Then

                Main.cmd.CommandText = $"update Accounts set Music = 'Admin' where userID = {i}"
                MsgBox($"Giving user {selected_name} ID:{i} Music admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Reading" Then

                Main.cmd.CommandText = $"update Accounts set Reading = 'Admin' where userID = {i}"
                MsgBox($"Giving user {selected_name} ID:{i} Reading admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            Else

                Main.cmd.CommandText = $"update Accounts set status = 'Admin' where userID = {i}"
                MsgBox($"Giving user {selected_name} ID:{i} global admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            End If

            Main.con.Close()
        Catch ex As Exception
            MsgBox($"Error: {ex}")

        Finally
            Main.con.Close()
            lblCount.Text = $"There are {GetClubMemberCount("")} people who are users of club linked,{Environment.NewLine}{GetClubMemberCount("Admin")} of them are app admins and {GetClubMemberCount("Club")} are club admins"
        End Try

    End Sub

    Private Sub btnRevoke_Click(sender As Object, e As EventArgs) Handles btnRevoke.Click

        Try

            If Main.con.State = ConnectionState.Open Then
                Main.con.Close()

            End If

            Main.con.Open()
            Main.cmd = Main.con.CreateCommand()
            Main.cmd.CommandType = CommandType.Text


            If ListBox1.SelectedItem = "All" Then

                Main.cmd.CommandText = $"update Accounts set status = '' where userID = {i}"
                MsgBox($"Revoking user {selected_name} ID:{i} global admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Programming" Then

                Main.cmd.CommandText = $"update Accounts set Programming = '' where userID = {i}"
                MsgBox($"Revoking user {selected_name} ID:{i} Programming admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Chess" Then

                Main.cmd.CommandText = $"update Accounts set Chess = '' where userID = {i}"
                MsgBox($"Revoking user {selected_name} ID:{i} Chess admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Music" Then

                Main.cmd.CommandText = $"update Accounts set Music = '' where userID = {i}"
                MsgBox($"Revoking user {selected_name} ID:{i} Music admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            ElseIf ListBox1.SelectedItem = "Reading" Then

                Main.cmd.CommandText = $"update Accounts set Reading = '' where userID = {i}"
                MsgBox($"Revoking user {selected_name} ID:{i} Reading admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            Else

                Main.cmd.CommandText = $"update Accounts set status = '' where userID = {i}"
                MsgBox($"Revoking user {selected_name} ID:{i} global admin")
                Main.cmd.ExecuteNonQuery()
                disp_data(DataGridView1, $"SELECT userID AS ID, username AS Name, status AS Status, chess AS Chess, programming AS Programming, music As Music, reading as Reading FROM Accounts where userID = {i}")

            End If

            Main.con.Close()
        Catch ex As Exception
            MsgBox($"Error: {ex}")

        Finally
            Main.con.Close()
            lblCount.Text = $"There are {GetClubMemberCount("")} people who are users of club linked,{Environment.NewLine}{GetClubMemberCount("Admin")} of them are app admins and {GetClubMemberCount("Club")} are club admins"
        End Try


    End Sub
End Class