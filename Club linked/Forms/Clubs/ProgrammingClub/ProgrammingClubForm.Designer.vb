﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnAnnouncments = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.TabPanel.Controls.Add(Me.btnEvents)
        Me.TabPanel.Controls.Add(Me.btnAnnouncments)
        Me.TabPanel.Controls.Add(Me.btnInfo)
        Me.TabPanel.Controls.Add(Me.Button1)
        Me.TabPanel.Controls.Add(Me.Panel1)
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
        Me.btnMembers.Location = New System.Drawing.Point(529, 0)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(151, 48)
        Me.btnMembers.TabIndex = 37
        Me.btnMembers.Text = "Show Members"
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.LightGray
        Me.btnInfo.Location = New System.Drawing.Point(76, 0)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(151, 48)
        Me.btnInfo.TabIndex = 36
        Me.btnInfo.Text = "Show Info"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnAnnouncments
        '
        Me.btnAnnouncments.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAnnouncments.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnnouncments.FlatAppearance.BorderSize = 0
        Me.btnAnnouncments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnouncments.ForeColor = System.Drawing.Color.LightGray
        Me.btnAnnouncments.Location = New System.Drawing.Point(227, 0)
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
        Me.btnEvents.Location = New System.Drawing.Point(378, 0)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(151, 48)
        Me.btnEvents.TabIndex = 34
        Me.btnEvents.Text = "Event Calender"
        Me.btnEvents.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(36, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 48)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(36, 48)
        Me.Panel1.TabIndex = 41
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
    Private WithEvents btnMembers As Button
    Private WithEvents btnInfo As Button
    Private WithEvents btnAnnouncments As Button
    Private WithEvents btnEvents As Button
    Private WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
