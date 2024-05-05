Imports System.Data.SqlClient

Public Class Main

    Public Shared con As New SqlConnection
    Public Shared cmd As New SqlCommand
    Public Shared rdr As SqlDataReader
    Public Shared Username As String
    Public Shared ID As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\Database.mdf;Integrated Security=True"
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tooth\Source\Repos\Ramendan\Club-linked\Club linked\Database\Database.mdf;Integrated Security=True"

        hideSubmenu()

    End Sub

    Private Sub hideSubmenu()

        AdminPanel.Visible = False
        ClubsPanel.Visible = False
        HelpPanel.Visible = False
        GeneralPanel.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then

            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub


    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        hideSubmenu()
        showSubmenu(HelpPanel)
    End Sub

    Private currentForm As Form = Nothing
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        hideSubmenu()
        showSubmenu(GeneralPanel)

    End Sub

    Private Sub btnClubs_Click(sender As Object, e As EventArgs) Handles btnClubs.Click
        hideSubmenu()
        showSubmenu(ClubsPanel)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdminTools.Click
        hideSubmenu()
        showSubmenu(AdminPanel)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        openChildForm(New Login)
    End Sub

    Private Sub btnShowSideMenu_Click(sender As Object, e As EventArgs) Handles btnShowSideMenu.Click

        If PanelSideMenu.Visible = False Then
            btnShowSideMenu.Text = "<"
            PanelSideMenu.Visible = True
        Else
            btnShowSideMenu.Text = ">"
            PanelSideMenu.Visible = False
        End If

    End Sub
    Private Sub btnAdminPrivileges_Click(sender As Object, e As EventArgs) Handles btnAdminPrivileges.Click
        openChildForm(New Admin_Privileges)

    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        openChildForm(New Events)
    End Sub

    Private Sub btnAdmin_Click_1(sender As Object, e As EventArgs) Handles btnAdminAnnouncments.Click
        openChildForm(New AdminAnnouncements)
    End Sub

    Private Sub btnAnnouncement_Click(sender As Object, e As EventArgs) Handles btnAnnouncement.Click
        openChildForm(New Announcments)
    End Sub

    Private Sub btnProgrammingClub_Click(sender As Object, e As EventArgs) Handles btnProgrammingClub.Click
        openChildForm(New ProgrammingClubForm)
    End Sub

    Private Sub btnMusicClub_Click(sender As Object, e As EventArgs) Handles btnMusicClub.Click
        openChildForm(New MusicClubForm)
    End Sub

    Private Sub btnReadingClub_Click(sender As Object, e As EventArgs) Handles btnReadingClub.Click
        openChildForm(New ReadingClubForm)
    End Sub

    Private Sub btnChessClub_Click(sender As Object, e As EventArgs) Handles btnChessClub.Click
        openChildForm(New ChessClubForm)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        openChildForm(New About)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        openChildForm(New Report)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        openChildForm(New Settings)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        openChildForm(New AdminReports)
    End Sub
End Class
