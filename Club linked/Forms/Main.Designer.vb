<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PanelToolsSubmenu = New System.Windows.Forms.Panel()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.btnEqualizer = New System.Windows.Forms.Button()
        Me.PanelPlaylistSubmenu = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.btnPlaylist = New System.Windows.Forms.Button()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelToolsSubmenu.SuspendLayout()
        Me.PanelPlaylistSubmenu.SuspendLayout()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(233, 145)
        Me.panelLogo.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(42, 15)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(146, 116)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'button5
        '
        Me.button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.ForeColor = System.Drawing.Color.Silver
        Me.button5.Location = New System.Drawing.Point(0, 120)
        Me.button5.Name = "button5"
        Me.button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button5.Size = New System.Drawing.Size(233, 40)
        Me.button5.TabIndex = 3
        Me.button5.Text = "Open recent media"
        Me.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.ForeColor = System.Drawing.Color.Silver
        Me.button4.Location = New System.Drawing.Point(0, 80)
        Me.button4.Name = "button4"
        Me.button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button4.Size = New System.Drawing.Size(233, 40)
        Me.button4.TabIndex = 2
        Me.button4.Text = "Open Disk"
        Me.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.ForeColor = System.Drawing.Color.Silver
        Me.button3.Location = New System.Drawing.Point(0, 40)
        Me.button3.Name = "button3"
        Me.button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button3.Size = New System.Drawing.Size(233, 40)
        Me.button3.TabIndex = 1
        Me.button3.Text = "Open folder"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.Silver
        Me.button2.Location = New System.Drawing.Point(0, 0)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button2.Size = New System.Drawing.Size(233, 40)
        Me.button2.TabIndex = 0
        Me.button2.Text = "Open files"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.UseVisualStyleBackColor = True
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.btnHelp)
        Me.PanelSideMenu.Controls.Add(Me.PanelToolsSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnTools)
        Me.PanelSideMenu.Controls.Add(Me.btnEqualizer)
        Me.PanelSideMenu.Controls.Add(Me.PanelPlaylistSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnPlaylist)
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnMedia)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 561)
        Me.PanelSideMenu.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Silver
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 830)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(233, 45)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "  Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.Silver
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 785)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(233, 45)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "  Help"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PanelToolsSubmenu
        '
        Me.PanelToolsSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelToolsSubmenu.Controls.Add(Me.button10)
        Me.PanelToolsSubmenu.Controls.Add(Me.button12)
        Me.PanelToolsSubmenu.Controls.Add(Me.button13)
        Me.PanelToolsSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolsSubmenu.Location = New System.Drawing.Point(0, 655)
        Me.PanelToolsSubmenu.Name = "PanelToolsSubmenu"
        Me.PanelToolsSubmenu.Size = New System.Drawing.Size(233, 130)
        Me.PanelToolsSubmenu.TabIndex = 7
        '
        'button10
        '
        Me.button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.button10.FlatAppearance.BorderSize = 0
        Me.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button10.ForeColor = System.Drawing.Color.Silver
        Me.button10.Location = New System.Drawing.Point(0, 80)
        Me.button10.Name = "button10"
        Me.button10.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button10.Size = New System.Drawing.Size(233, 40)
        Me.button10.TabIndex = 2
        Me.button10.Text = "Preferences"
        Me.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button10.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.ForeColor = System.Drawing.Color.Silver
        Me.button12.Location = New System.Drawing.Point(0, 40)
        Me.button12.Name = "button12"
        Me.button12.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button12.Size = New System.Drawing.Size(233, 40)
        Me.button12.TabIndex = 1
        Me.button12.Text = "Effects and filters"
        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.ForeColor = System.Drawing.Color.Silver
        Me.button13.Location = New System.Drawing.Point(0, 0)
        Me.button13.Name = "button13"
        Me.button13.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button13.Size = New System.Drawing.Size(233, 40)
        Me.button13.TabIndex = 0
        Me.button13.Text = "Media converter"
        Me.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button13.UseVisualStyleBackColor = True
        '
        'btnTools
        '
        Me.btnTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTools.FlatAppearance.BorderSize = 0
        Me.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTools.ForeColor = System.Drawing.Color.Silver
        Me.btnTools.Image = CType(resources.GetObject("btnTools.Image"), System.Drawing.Image)
        Me.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.Location = New System.Drawing.Point(0, 610)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTools.Size = New System.Drawing.Size(233, 45)
        Me.btnTools.TabIndex = 6
        Me.btnTools.Text = "  Tools"
        Me.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTools.UseVisualStyleBackColor = True
        '
        'btnEqualizer
        '
        Me.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEqualizer.FlatAppearance.BorderSize = 0
        Me.btnEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqualizer.ForeColor = System.Drawing.Color.Silver
        Me.btnEqualizer.Image = CType(resources.GetObject("btnEqualizer.Image"), System.Drawing.Image)
        Me.btnEqualizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEqualizer.Location = New System.Drawing.Point(0, 565)
        Me.btnEqualizer.Name = "btnEqualizer"
        Me.btnEqualizer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEqualizer.Size = New System.Drawing.Size(233, 45)
        Me.btnEqualizer.TabIndex = 5
        Me.btnEqualizer.Text = "  Equalizer"
        Me.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEqualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEqualizer.UseVisualStyleBackColor = True
        '
        'PanelPlaylistSubmenu
        '
        Me.PanelPlaylistSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button1)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button6)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button7)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button8)
        Me.PanelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPlaylistSubmenu.Location = New System.Drawing.Point(0, 400)
        Me.PanelPlaylistSubmenu.Name = "PanelPlaylistSubmenu"
        Me.PanelPlaylistSubmenu.Size = New System.Drawing.Size(233, 165)
        Me.PanelPlaylistSubmenu.TabIndex = 4
        '
        'button1
        '
        Me.button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.Silver
        Me.button1.Location = New System.Drawing.Point(0, 120)
        Me.button1.Name = "button1"
        Me.button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button1.Size = New System.Drawing.Size(233, 40)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Export playlist"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.button6.FlatAppearance.BorderSize = 0
        Me.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.ForeColor = System.Drawing.Color.Silver
        Me.button6.Location = New System.Drawing.Point(0, 80)
        Me.button6.Name = "button6"
        Me.button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button6.Size = New System.Drawing.Size(233, 40)
        Me.button6.TabIndex = 2
        Me.button6.Text = "Import playlist"
        Me.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button6.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.button7.FlatAppearance.BorderSize = 0
        Me.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.ForeColor = System.Drawing.Color.Silver
        Me.button7.Location = New System.Drawing.Point(0, 40)
        Me.button7.Name = "button7"
        Me.button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button7.Size = New System.Drawing.Size(233, 40)
        Me.button7.TabIndex = 1
        Me.button7.Text = "Managing playlist"
        Me.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button7.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.button8.FlatAppearance.BorderSize = 0
        Me.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button8.ForeColor = System.Drawing.Color.Silver
        Me.button8.Location = New System.Drawing.Point(0, 0)
        Me.button8.Name = "button8"
        Me.button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button8.Size = New System.Drawing.Size(233, 40)
        Me.button8.TabIndex = 0
        Me.button8.Text = "New playlist"
        Me.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button8.UseVisualStyleBackColor = True
        '
        'btnPlaylist
        '
        Me.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlaylist.FlatAppearance.BorderSize = 0
        Me.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaylist.ForeColor = System.Drawing.Color.Silver
        Me.btnPlaylist.Image = CType(resources.GetObject("btnPlaylist.Image"), System.Drawing.Image)
        Me.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlaylist.Location = New System.Drawing.Point(0, 355)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnPlaylist.Size = New System.Drawing.Size(233, 45)
        Me.btnPlaylist.TabIndex = 3
        Me.btnPlaylist.Text = "  Playlist management"
        Me.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlaylist.UseVisualStyleBackColor = True
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelMediaSubmenu.Controls.Add(Me.button5)
        Me.PanelMediaSubmenu.Controls.Add(Me.button4)
        Me.PanelMediaSubmenu.Controls.Add(Me.button3)
        Me.PanelMediaSubmenu.Controls.Add(Me.button2)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 190)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(233, 165)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'btnMedia
        '
        Me.btnMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedia.FlatAppearance.BorderSize = 0
        Me.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedia.ForeColor = System.Drawing.Color.Silver
        Me.btnMedia.Image = CType(resources.GetObject("btnMedia.Image"), System.Drawing.Image)
        Me.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.Location = New System.Drawing.Point(0, 145)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMedia.Size = New System.Drawing.Size(233, 45)
        Me.btnMedia.TabIndex = 1
        Me.btnMedia.Text = "  Media"
        Me.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMedia.UseVisualStyleBackColor = True
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(684, 561)
        Me.PanelChildForm.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelToolsSubmenu.ResumeLayout(False)
        Me.PanelPlaylistSubmenu.ResumeLayout(False)
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnExit As Button
    Private WithEvents btnHelp As Button
    Private WithEvents PanelToolsSubmenu As Panel
    Private WithEvents button10 As Button
    Private WithEvents button12 As Button
    Private WithEvents button13 As Button
    Private WithEvents btnTools As Button
    Private WithEvents btnEqualizer As Button
    Private WithEvents PanelPlaylistSubmenu As Panel
    Private WithEvents button1 As Button
    Private WithEvents button6 As Button
    Private WithEvents button7 As Button
    Private WithEvents button8 As Button
    Private WithEvents btnPlaylist As Button
    Private WithEvents PanelMediaSubmenu As Panel
    Private WithEvents btnMedia As Button
    Friend WithEvents PanelChildForm As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
