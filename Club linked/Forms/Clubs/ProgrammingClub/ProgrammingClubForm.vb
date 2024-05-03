Public Class ProgrammingClubForm
    Private Sub ProgrammingClubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private currentForm As Form = Nothing
    Private Sub button5_Click(sender As Object, e As EventArgs)
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

        openChildForm(New ProgrammingTab1)
        highlight(btnMembers)
    End Sub


    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        ' openChildForm(New ProgrammingTab2)
        highlight(btnEvents)
    End Sub

    Private Sub btnAnnouncments_Click(sender As Object, e As EventArgs) Handles btnAnnouncments.Click
        highlight(btnAnnouncments)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        highlight(btnInfo)
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        highlight(btnStatus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class