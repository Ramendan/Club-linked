<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New Club_linked.DatabaseDataSet1()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnBan = New System.Windows.Forms.Button()
        Me.btnUnban = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbNameSearch = New System.Windows.Forms.RadioButton()
        Me.rbIDSearch = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.button5 = New System.Windows.Forms.Button()
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsTableAdapter = New Club_linked.DatabaseDataSet1TableAdapters.AccountsTableAdapter()
        Me.lablelSelectedID = New System.Windows.Forms.Label()
        Me.btnrbShowAll = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet1"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(56, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 32)
        Me.label1.TabIndex = 37
        Me.label1.Text = "Reports"
        '
        'btnBan
        '
        Me.btnBan.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBan.FlatAppearance.BorderSize = 0
        Me.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBan.ForeColor = System.Drawing.Color.LightGray
        Me.btnBan.Location = New System.Drawing.Point(20, 55)
        Me.btnBan.Name = "btnBan"
        Me.btnBan.Size = New System.Drawing.Size(150, 40)
        Me.btnBan.TabIndex = 32
        Me.btnBan.Text = "Ban user"
        Me.btnBan.UseVisualStyleBackColor = False
        '
        'btnUnban
        '
        Me.btnUnban.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUnban.FlatAppearance.BorderSize = 0
        Me.btnUnban.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnban.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnban.ForeColor = System.Drawing.Color.LightGray
        Me.btnUnban.Location = New System.Drawing.Point(20, 101)
        Me.btnUnban.Name = "btnUnban"
        Me.btnUnban.Size = New System.Drawing.Size(150, 40)
        Me.btnUnban.TabIndex = 31
        Me.btnUnban.Text = "Unban user"
        Me.btnUnban.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnrbShowAll)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.btnBan)
        Me.GroupBox1.Controls.Add(Me.btnUnban)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1097, 447)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(191, 376)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(887, 24)
        Me.tbSearch.TabIndex = 47
        Me.tbSearch.Text = "Enter your search here..."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbNameSearch)
        Me.GroupBox4.Controls.Add(Me.rbIDSearch)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 64)
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
        Me.rbIDSearch.Location = New System.Drawing.Point(6, 41)
        Me.rbIDSearch.Name = "rbIDSearch"
        Me.rbIDSearch.Size = New System.Drawing.Size(127, 17)
        Me.rbIDSearch.TabIndex = 44
        Me.rbIDSearch.Tag = "2"
        Me.rbIDSearch.Text = "Search for specific ID"
        Me.rbIDSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 26)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Reports"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "All users"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(530, 55)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(548, 317)
        Me.DataGridView2.TabIndex = 36
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.LightGray
        Me.button5.Location = New System.Drawing.Point(26, 30)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 38
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'lablelSelectedID
        '
        Me.lablelSelectedID.AutoSize = True
        Me.lablelSelectedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablelSelectedID.Location = New System.Drawing.Point(177, 38)
        Me.lablelSelectedID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lablelSelectedID.Name = "lablelSelectedID"
        Me.lablelSelectedID.Size = New System.Drawing.Size(131, 26)
        Me.lablelSelectedID.TabIndex = 41
        Me.lablelSelectedID.Text = "Selected ID:"
        '
        'btnrbShowAll
        '
        Me.btnrbShowAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnrbShowAll.FlatAppearance.BorderSize = 0
        Me.btnrbShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrbShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrbShowAll.ForeColor = System.Drawing.Color.LightGray
        Me.btnrbShowAll.Location = New System.Drawing.Point(20, 147)
        Me.btnrbShowAll.Name = "btnrbShowAll"
        Me.btnrbShowAll.Size = New System.Drawing.Size(150, 40)
        Me.btnrbShowAll.TabIndex = 49
        Me.btnrbShowAll.Text = "Show all members"
        Me.btnrbShowAll.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(191, 55)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(334, 316)
        Me.DataGridView1.TabIndex = 50
        '
        'AdminReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1145, 538)
        Me.Controls.Add(Me.lablelSelectedID)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button5)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Name = "AdminReports"
        Me.Text = "AdminReports"
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As Label
    Private WithEvents btnBan As Button
    Private WithEvents btnUnban As Button
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents button5 As Button
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseDataSet1 As DatabaseDataSet1
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents AccountsTableAdapter As DatabaseDataSet1TableAdapters.AccountsTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbNameSearch As RadioButton
    Friend WithEvents rbIDSearch As RadioButton
    Friend WithEvents lablelSelectedID As Label
    Private WithEvents btnrbShowAll As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
