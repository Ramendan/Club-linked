Public Class AdminReports
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub AdminReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.DatabaseDataSet1.Accounts)

    End Sub
End Class