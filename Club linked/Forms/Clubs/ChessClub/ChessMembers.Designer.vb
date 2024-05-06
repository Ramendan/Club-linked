<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChessMembers
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearchMember = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbNameSearch = New System.Windows.Forms.RadioButton()
        Me.rbIDSearch = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbShowAll = New System.Windows.Forms.RadioButton()
        Me.rbClubAdminSearch = New System.Windows.Forms.RadioButton()
        Me.rbAdminOnly = New System.Windows.Forms.RadioButton()
        Me.rbRoleSearch = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnSearchMember)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 447)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(187, 25)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(614, 24)
        Me.tbSearch.TabIndex = 34
        Me.tbSearch.Text = "Enter your search here..."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(187, 71)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(613, 354)
        Me.DataGridView1.TabIndex = 33
        '
        'btnSearchMember
        '
        Me.btnSearchMember.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearchMember.FlatAppearance.BorderSize = 0
        Me.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchMember.ForeColor = System.Drawing.Color.LightGray
        Me.btnSearchMember.Location = New System.Drawing.Point(21, 18)
        Me.btnSearchMember.Name = "btnSearchMember"
        Me.btnSearchMember.Size = New System.Drawing.Size(150, 40)
        Me.btnSearchMember.TabIndex = 29
        Me.btnSearchMember.Text = "Search for a member"
        Me.btnSearchMember.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(268, 27)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(151, 24)
        Me.lblCount.TabIndex = 41
        Me.lblCount.Text = "Member count:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(48, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(198, 32)
        Me.label1.TabIndex = 40
        Me.label1.Text = "Club Members"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbRoleSearch)
        Me.GroupBox4.Controls.Add(Me.rbNameSearch)
        Me.GroupBox4.Controls.Add(Me.rbIDSearch)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 97)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        '
        'rbNameSearch
        '
        Me.rbNameSearch.AutoSize = True
        Me.rbNameSearch.Checked = True
        Me.rbNameSearch.Location = New System.Drawing.Point(6, 13)
        Me.rbNameSearch.Name = "rbNameSearch"
        Me.rbNameSearch.Size = New System.Drawing.Size(142, 17)
        Me.rbNameSearch.TabIndex = 43
        Me.rbNameSearch.TabStop = True
        Me.rbNameSearch.Tag = "2"
        Me.rbNameSearch.Text = "Search for specific name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbNameSearch.UseVisualStyleBackColor = True
        '
        'rbIDSearch
        '
        Me.rbIDSearch.AutoSize = True
        Me.rbIDSearch.Location = New System.Drawing.Point(6, 38)
        Me.rbIDSearch.Name = "rbIDSearch"
        Me.rbIDSearch.Size = New System.Drawing.Size(127, 17)
        Me.rbIDSearch.TabIndex = 44
        Me.rbIDSearch.Tag = "2"
        Me.rbIDSearch.Text = "Search for specific ID"
        Me.rbIDSearch.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbShowAll)
        Me.GroupBox3.Controls.Add(Me.rbClubAdminSearch)
        Me.GroupBox3.Controls.Add(Me.rbAdminOnly)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 82)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'rbShowAll
        '
        Me.rbShowAll.AutoSize = True
        Me.rbShowAll.Checked = True
        Me.rbShowAll.Location = New System.Drawing.Point(7, 15)
        Me.rbShowAll.Name = "rbShowAll"
        Me.rbShowAll.Size = New System.Drawing.Size(110, 17)
        Me.rbShowAll.TabIndex = 45
        Me.rbShowAll.TabStop = True
        Me.rbShowAll.Tag = "1"
        Me.rbShowAll.Text = "Show all members"
        Me.rbShowAll.UseVisualStyleBackColor = True
        '
        'rbClubAdminSearch
        '
        Me.rbClubAdminSearch.AutoSize = True
        Me.rbClubAdminSearch.Location = New System.Drawing.Point(6, 59)
        Me.rbClubAdminSearch.Name = "rbClubAdminSearch"
        Me.rbClubAdminSearch.Size = New System.Drawing.Size(133, 17)
        Me.rbClubAdminSearch.TabIndex = 42
        Me.rbClubAdminSearch.Tag = "1"
        Me.rbClubAdminSearch.Text = "Only show club admins"
        Me.rbClubAdminSearch.UseVisualStyleBackColor = True
        '
        'rbAdminOnly
        '
        Me.rbAdminOnly.AutoSize = True
        Me.rbAdminOnly.Location = New System.Drawing.Point(6, 36)
        Me.rbAdminOnly.Name = "rbAdminOnly"
        Me.rbAdminOnly.Size = New System.Drawing.Size(111, 17)
        Me.rbAdminOnly.TabIndex = 41
        Me.rbAdminOnly.Tag = "1"
        Me.rbAdminOnly.Text = "Only show Admins"
        Me.rbAdminOnly.UseVisualStyleBackColor = True
        '
        'rbRoleSearch
        '
        Me.rbRoleSearch.AutoSize = True
        Me.rbRoleSearch.Location = New System.Drawing.Point(7, 63)
        Me.rbRoleSearch.Name = "rbRoleSearch"
        Me.rbRoleSearch.Size = New System.Drawing.Size(133, 17)
        Me.rbRoleSearch.TabIndex = 45
        Me.rbRoleSearch.TabStop = True
        Me.rbRoleSearch.Tag = "1"
        Me.rbRoleSearch.Text = "Search for specific role"
        Me.rbRoleSearch.UseVisualStyleBackColor = True
        '
        'ChessMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(921, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.label1)
        Me.Name = "ChessMembers"
        Me.Text = "ChessMembers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents btnSearchMember As Button
    Friend WithEvents lblCount As Label
    Private WithEvents label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbNameSearch As RadioButton
    Friend WithEvents rbIDSearch As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbShowAll As RadioButton
    Friend WithEvents rbClubAdminSearch As RadioButton
    Friend WithEvents rbAdminOnly As RadioButton
    Friend WithEvents rbRoleSearch As RadioButton
End Class
