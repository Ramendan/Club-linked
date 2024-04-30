Public Class Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
