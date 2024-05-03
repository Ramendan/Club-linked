Public Class MusicClubForm
    Private currentForm As Form = Nothing
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub openChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub highlight(ByVal buttonToHighlight As Button)

        btnEvents.BackColor = Color.FromArgb(32, 30, 45)
        btnAnnouncments.BackColor = Color.FromArgb(32, 30, 45)
        btnInfo.BackColor = Color.FromArgb(32, 30, 45)
        btnMembers.BackColor = Color.FromArgb(32, 30, 45)
        btnStatus.BackColor = Color.FromArgb(32, 30, 45)
        buttonToHighlight.BackColor = Color.FromArgb(235, 42, 83)

    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        openChildForm(New MusicMembers)
        highlight(btnMembers)
    End Sub


    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click

        highlight(btnEvents)
    End Sub

    Private Sub btnAnnouncments_Click(sender As Object, e As EventArgs) Handles btnAnnouncments.Click
        openChildForm(New MusicAnnouncements)
        highlight(btnAnnouncments)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        openChildForm(New MusicInfo)
        highlight(btnInfo)
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        highlight(btnStatus)
        'openChildForm(New test)
    End Sub
End Class