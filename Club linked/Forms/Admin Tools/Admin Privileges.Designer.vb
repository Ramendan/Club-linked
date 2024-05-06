<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class labelSelectedID
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
        Me.components = New System.ComponentModel.Container()
        Me.label1 = New System.Windows.Forms.Label()
        Me.AccountsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllAccountdata = New Club_linked.AllAccountdata()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnRevoke = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdminOnly = New System.Windows.Forms.Button()
        Me.btnrbClubAdminSearch = New System.Windows.Forms.Button()
        Me.btnrbShowAll = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbNameSearch = New System.Windows.Forms.RadioButton()
        Me.rbIDSearch = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.AccountsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersInfo = New Club_linked.UsersInfo()
        Me.AccountsTableAdapter = New Club_linked.UsersInfoTableAdapters.AccountsTableAdapter()
        Me.AccountsTableAdapter1 = New Club_linked.AllAccountdataTableAdapters.AccountsTableAdapter()
        Me.lablelSelectedID = New System.Windows.Forms.Label()
        CType(Me.AccountsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllAccountdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AccountsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(56, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 32)
        Me.label1.TabIndex = 34
        Me.label1.Text = "Users"
        '
        'AccountsBindingSource2
        '
        Me.AccountsBindingSource2.DataMember = "Accounts"
        Me.AccountsBindingSource2.DataSource = Me.AllAccountdata
        '
        'AllAccountdata
        '
        Me.AllAccountdata.DataSetName = "AllAccountdata"
        Me.AllAccountdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAddAdmin.FlatAppearance.BorderSize = 0
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddAdmin.Location = New System.Drawing.Point(20, 18)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(166, 40)
        Me.btnAddAdmin.TabIndex = 32
        Me.btnAddAdmin.Text = "Give Admin Status"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'btnRevoke
        '
        Me.btnRevoke.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnRevoke.FlatAppearance.BorderSize = 0
        Me.btnRevoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevoke.ForeColor = System.Drawing.Color.LightGray
        Me.btnRevoke.Location = New System.Drawing.Point(20, 64)
        Me.btnRevoke.Name = "btnRevoke"
        Me.btnRevoke.Size = New System.Drawing.Size(165, 40)
        Me.btnRevoke.TabIndex = 31
        Me.btnRevoke.Text = "Revoke Admin Status"
        Me.btnRevoke.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCount)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.btnAddAdmin)
        Me.GroupBox1.Controls.Add(Me.btnRevoke)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 523)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(191, 415)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(151, 24)
        Me.lblCount.TabIndex = 42
        Me.lblCount.Text = "Member count:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(191, 18)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(614, 354)
        Me.DataGridView1.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdminOnly)
        Me.GroupBox2.Controls.Add(Me.btnrbClubAdminSearch)
        Me.GroupBox2.Controls.Add(Me.btnrbShowAll)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 109)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(166, 399)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'btnAdminOnly
        '
        Me.btnAdminOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAdminOnly.FlatAppearance.BorderSize = 0
        Me.btnAdminOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminOnly.ForeColor = System.Drawing.Color.LightGray
        Me.btnAdminOnly.Location = New System.Drawing.Point(5, 208)
        Me.btnAdminOnly.Name = "btnAdminOnly"
        Me.btnAdminOnly.Size = New System.Drawing.Size(156, 40)
        Me.btnAdminOnly.TabIndex = 48
        Me.btnAdminOnly.Text = "Show Admins"
        Me.btnAdminOnly.UseVisualStyleBackColor = False
        '
        'btnrbClubAdminSearch
        '
        Me.btnrbClubAdminSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnrbClubAdminSearch.FlatAppearance.BorderSize = 0
        Me.btnrbClubAdminSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrbClubAdminSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrbClubAdminSearch.ForeColor = System.Drawing.Color.LightGray
        Me.btnrbClubAdminSearch.Location = New System.Drawing.Point(5, 256)
        Me.btnrbClubAdminSearch.Name = "btnrbClubAdminSearch"
        Me.btnrbClubAdminSearch.Size = New System.Drawing.Size(156, 40)
        Me.btnrbClubAdminSearch.TabIndex = 47
        Me.btnrbClubAdminSearch.Text = "Show club admins"
        Me.btnrbClubAdminSearch.UseVisualStyleBackColor = False
        '
        'btnrbShowAll
        '
        Me.btnrbShowAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnrbShowAll.FlatAppearance.BorderSize = 0
        Me.btnrbShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrbShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrbShowAll.ForeColor = System.Drawing.Color.LightGray
        Me.btnrbShowAll.Location = New System.Drawing.Point(5, 160)
        Me.btnrbShowAll.Name = "btnrbShowAll"
        Me.btnrbShowAll.Size = New System.Drawing.Size(156, 40)
        Me.btnrbShowAll.TabIndex = 43
        Me.btnrbShowAll.Text = "Show all members"
        Me.btnrbShowAll.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbNameSearch)
        Me.GroupBox4.Controls.Add(Me.rbIDSearch)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 302)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 64)
        Me.GroupBox4.TabIndex = 46
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
        Me.rbIDSearch.Location = New System.Drawing.Point(6, 40)
        Me.rbIDSearch.Name = "rbIDSearch"
        Me.rbIDSearch.Size = New System.Drawing.Size(127, 17)
        Me.rbIDSearch.TabIndex = 44
        Me.rbIDSearch.Tag = "2"
        Me.rbIDSearch.Text = "Search for specific ID"
        Me.rbIDSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Change Admin in"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Items.AddRange(New Object() {"All", "Programming", "Music", "Chess", "Reading"})
        Me.ListBox1.Location = New System.Drawing.Point(5, 41)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(156, 114)
        Me.ListBox1.TabIndex = 0
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(191, 384)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(614, 24)
        Me.tbSearch.TabIndex = 34
        Me.tbSearch.Text = "Enter your search here..."
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.Location = New System.Drawing.Point(26, 30)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AccountsBindingSource1
        '
        Me.AccountsBindingSource1.DataMember = "Accounts"
        Me.AccountsBindingSource1.DataSource = Me.UsersInfo
        '
        'UsersInfo
        '
        Me.UsersInfo.DataSetName = "UsersInfo"
        Me.UsersInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'AccountsTableAdapter1
        '
        Me.AccountsTableAdapter1.ClearBeforeFill = True
        '
        'lablelSelectedID
        '
        Me.lablelSelectedID.AutoSize = True
        Me.lablelSelectedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablelSelectedID.Location = New System.Drawing.Point(216, 37)
        Me.lablelSelectedID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lablelSelectedID.Name = "lablelSelectedID"
        Me.lablelSelectedID.Size = New System.Drawing.Size(131, 26)
        Me.lablelSelectedID.TabIndex = 40
        Me.lablelSelectedID.Text = "Selected ID:"
        '
        'labelSelectedID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 692)
        Me.Controls.Add(Me.lablelSelectedID)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "labelSelectedID"
        Me.Text = "Admin_Privileges"
        CType(Me.AccountsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllAccountdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.AccountsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnAddAdmin As Button
    Private WithEvents btnRevoke As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbSearch As TextBox
    Private WithEvents btnClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsersInfo As UsersInfo
    Friend WithEvents AccountsBindingSource1 As BindingSource
    Friend WithEvents AccountsTableAdapter As UsersInfoTableAdapters.AccountsTableAdapter
    Friend WithEvents AllAccountdata As AllAccountdata
    Friend WithEvents AccountsBindingSource2 As BindingSource
    Friend WithEvents AccountsTableAdapter1 As AllAccountdataTableAdapters.AccountsTableAdapter
    Friend WithEvents lblCount As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rbIDSearch As RadioButton
    Friend WithEvents rbNameSearch As RadioButton
    Friend WithEvents lablelSelectedID As Label
    Friend WithEvents GroupBox4 As GroupBox
    Private WithEvents btnAdminOnly As Button
    Private WithEvents btnrbClubAdminSearch As Button
    Private WithEvents btnrbShowAll As Button
End Class
