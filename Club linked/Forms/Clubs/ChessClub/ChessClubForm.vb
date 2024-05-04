Public Class ChessClubForm

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
        buttonToHighlight.BackColor = Color.FromArgb(235, 42, 83)

    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        openChildForm(New ChessMembers)
        highlight(btnMembers)
    End Sub


    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        openChildForm(New ChessEvents)
        highlight(btnEvents)
    End Sub

    Private Sub btnAnnouncments_Click(sender As Object, e As EventArgs) Handles btnAnnouncments.Click
        openChildForm(New ChessAnnouncement)
        highlight(btnAnnouncments)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        openChildForm(New ChessInfo)
        highlight(btnInfo)
    End Sub
End Class