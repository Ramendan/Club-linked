<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseClubForm
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
        Me.button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.TabPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(0, 48)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(814, 429)
        Me.PanelChildForm.TabIndex = 3
        '
        'TabPanel
        '
        Me.TabPanel.Controls.Add(Me.button5)
        Me.TabPanel.Controls.Add(Me.Button4)
        Me.TabPanel.Controls.Add(Me.Button3)
        Me.TabPanel.Controls.Add(Me.Button2)
        Me.TabPanel.Controls.Add(Me.Button1)
        Me.TabPanel.Controls.Add(Me.btnAddAdmin)
        Me.TabPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabPanel.Location = New System.Drawing.Point(0, 0)
        Me.TabPanel.Name = "TabPanel"
        Me.TabPanel.Size = New System.Drawing.Size(814, 48)
        Me.TabPanel.TabIndex = 2
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.LightGray
        Me.button5.Location = New System.Drawing.Point(25, 11)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 38
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.LightGray
        Me.Button4.Location = New System.Drawing.Point(64, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 48)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Show Members"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.LightGray
        Me.Button3.Location = New System.Drawing.Point(214, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 48)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Show Admins"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightGray
        Me.Button2.Location = New System.Drawing.Point(364, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 48)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "View Latest Announcments"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(514, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 48)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Show Event Calender"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAddAdmin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddAdmin.FlatAppearance.BorderSize = 0
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddAdmin.Location = New System.Drawing.Point(664, 0)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(150, 48)
        Me.btnAddAdmin.TabIndex = 33
        Me.btnAddAdmin.Text = "Your Club Status"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'BaseClubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 477)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.TabPanel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BaseClubForm"
        Me.Text = "Base"
        Me.TabPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents TabPanel As Panel
    Private WithEvents button5 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button1 As Button
    Private WithEvents btnAddAdmin As Button
End Class
