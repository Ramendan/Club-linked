Public Class AdminAnnouncements

    Private Sub btnOpenDatabase_Click(sender As Object, e As EventArgs) Handles btnOpenDatabase.Click
        gbCreator.Visible = False
        gbAnnouncementDatabase.Visible = True
    End Sub

    Private Sub AdminAnnouncements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbCreator.Visible = True
        gbAnnouncementDatabase.Visible = False
    End Sub

    Private Sub btnCreator_Click(sender As Object, e As EventArgs) Handles btnCreator.Click
        gbCreator.Visible = True
        gbAnnouncementDatabase.Visible = False
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub
End Class