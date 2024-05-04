Public Class Admin_Privileges
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Admin_Privileges_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AccountsTableAdapter1.Fill(Me.AllAccountdata.Accounts)
        Me.AccountsTableAdapter.Fill(Me.UsersInfo.Accounts)

    End Sub
End Class