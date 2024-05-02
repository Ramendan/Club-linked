<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgrammingClubForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.TabPanel = New System.Windows.Forms.Panel()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnAdmins = New System.Windows.Forms.Button()
        Me.btnAnnouncments = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(0, 48)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(960, 402)
        Me.PanelChildForm.TabIndex = 5
        '
        'TabPanel
        '
        Me.TabPanel.Controls.Add(Me.btnMembers)
        Me.TabPanel.Controls.Add(Me.btnAdmins)
        Me.TabPanel.Controls.Add(Me.btnAnnouncments)
        Me.TabPanel.Controls.Add(Me.btnEvents)
        Me.TabPanel.Controls.Add(Me.btnStatus)
        Me.TabPanel.Controls.Add(Me.btnClose)
        Me.TabPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabPanel.Location = New System.Drawing.Point(0, 0)
        Me.TabPanel.Name = "TabPanel"
        Me.TabPanel.Size = New System.Drawing.Size(960, 48)
        Me.TabPanel.TabIndex = 4
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMembers.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.ForeColor = System.Drawing.Color.LightGray
        Me.btnMembers.Location = New System.Drawing.Point(687, 0)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(151, 48)
        Me.btnMembers.TabIndex = 37
        Me.btnMembers.Text = "Show Members"
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnAdmins
        '
        Me.btnAdmins.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAdmins.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdmins.FlatAppearance.BorderSize = 0
        Me.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmins.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmins.ForeColor = System.Drawing.Color.LightGray
        Me.btnAdmins.Location = New System.Drawing.Point(536, 0)
        Me.btnAdmins.Name = "btnAdmins"
        Me.btnAdmins.Size = New System.Drawing.Size(151, 48)
        Me.btnAdmins.TabIndex = 36
        Me.btnAdmins.Text = "Show Admins"
        Me.btnAdmins.UseVisualStyleBackColor = False
        '
        'btnAnnouncments
        '
        Me.btnAnnouncments.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAnnouncments.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnnouncments.FlatAppearance.BorderSize = 0
        Me.btnAnnouncments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnouncments.ForeColor = System.Drawing.Color.LightGray
        Me.btnAnnouncments.Location = New System.Drawing.Point(385, 0)
        Me.btnAnnouncments.Name = "btnAnnouncments"
        Me.btnAnnouncments.Size = New System.Drawing.Size(151, 48)
        Me.btnAnnouncments.TabIndex = 35
        Me.btnAnnouncments.Text = "Announcments"
        Me.btnAnnouncments.UseVisualStyleBackColor = False
        '
        'btnEvents
        '
        Me.btnEvents.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEvents.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEvents.FlatAppearance.BorderSize = 0
        Me.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvents.ForeColor = System.Drawing.Color.LightGray
        Me.btnEvents.Location = New System.Drawing.Point(234, 0)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(151, 48)
        Me.btnEvents.TabIndex = 34
        Me.btnEvents.Text = "Event Calender"
        Me.btnEvents.UseVisualStyleBackColor = False
        '
        'btnStatus
        '
        Me.btnStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnStatus.FlatAppearance.BorderSize = 0
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.ForeColor = System.Drawing.Color.LightGray
        Me.btnStatus.Location = New System.Drawing.Point(83, 0)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(151, 48)
        Me.btnStatus.TabIndex = 33
        Me.btnStatus.Text = "Club Status"
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 48)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ProgrammingClubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 450)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.TabPanel)
        Me.Name = "ProgrammingClubForm"
        Me.Text = "Form1"
        Me.TabPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents TabPanel As Panel
    Private WithEvents btnClose As Button
    Private WithEvents btnMembers As Button
    Private WithEvents btnAdmins As Button
    Private WithEvents btnAnnouncments As Button
    Private WithEvents btnEvents As Button
    Private WithEvents btnStatus As Button
End Class
