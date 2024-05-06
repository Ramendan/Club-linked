Public Class Events
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tbSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles tbSearch.MouseClick
        tbSearch.Text = ""
    End Sub
End Class