Public Class Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False
        PanelToolsSubmenu.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs)
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs)
        showSubmenu(PanelPlaylistSubmenu)
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        showSubmenu(PanelToolsSubmenu)
    End Sub

#Region "Buttons Submenu"
    Private Sub button2_Click(sender As Object, e As EventArgs)

        openChildForm(New Subform())
        '...
        'your codes
        '...
        hideSubmenu()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs)
        openChildForm(New Data_Subform())
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub
#End Region

    Private Sub btnEqualizer_Click(sender As Object, e As EventArgs) Handles btnEqualizer.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        '...
        'your codes
        '...
        hideSubmenu()
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub PanelPlaylistSubmenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelPlaylistSubmenu.Paint

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click

    End Sub

    Private Sub panelLogo_Paint(sender As Object, e As PaintEventArgs) Handles panelLogo.Paint

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    Private Sub PanelSideMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelSideMenu.Paint

    End Sub

    Private Sub PanelToolsSubmenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelToolsSubmenu.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

    End Sub

    Private Sub PanelMediaSubmenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMediaSubmenu.Paint

    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

    End Sub
End Class
