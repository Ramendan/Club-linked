Public Class Admin_Privileges
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Admin_Privileges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllAccountdata.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter1.Fill(Me.AllAccountdata.Accounts)
        'TODO: This line of code loads data into the 'UsersInfo.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.UsersInfo.Accounts)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Accounts' table. You can move, or remove it, as needed.

    End Sub
End Class