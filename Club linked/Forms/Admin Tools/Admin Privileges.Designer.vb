<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Privileges
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnRevoke = New System.Windows.Forms.Button()
        Me.btnSearchUsr = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtSearchUsr = New System.Windows.Forms.TextBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.AccountsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersInfo = New Club_linked.UsersInfo()
        Me.AccountsTableAdapter = New Club_linked.UsersInfoTableAdapters.AccountsTableAdapter()
        Me.AllAccountdata = New Club_linked.AllAccountdata()
        Me.AccountsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsTableAdapter1 = New Club_linked.AllAccountdataTableAdapters.AccountsTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programming = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reading = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.music = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AccountsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllAccountdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.status, Me.programming, Me.chess, Me.reading, Me.music})
        Me.DataGridView1.DataSource = Me.AccountsBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(191, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(613, 354)
        Me.DataGridView1.TabIndex = 33
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
        Me.btnAddAdmin.Size = New System.Drawing.Size(150, 40)
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
        Me.btnRevoke.Location = New System.Drawing.Point(20, 69)
        Me.btnRevoke.Name = "btnRevoke"
        Me.btnRevoke.Size = New System.Drawing.Size(150, 40)
        Me.btnRevoke.TabIndex = 31
        Me.btnRevoke.Text = "Revoke Admin Status"
        Me.btnRevoke.UseVisualStyleBackColor = False
        '
        'btnSearchUsr
        '
        Me.btnSearchUsr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchUsr.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearchUsr.FlatAppearance.BorderSize = 0
        Me.btnSearchUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUsr.ForeColor = System.Drawing.Color.LightGray
        Me.btnSearchUsr.Location = New System.Drawing.Point(20, 384)
        Me.btnSearchUsr.Name = "btnSearchUsr"
        Me.btnSearchUsr.Size = New System.Drawing.Size(150, 40)
        Me.btnSearchUsr.TabIndex = 29
        Me.btnSearchUsr.Text = "Search for user"
        Me.btnSearchUsr.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtSearchUsr)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnAddAdmin)
        Me.GroupBox1.Controls.Add(Me.btnRevoke)
        Me.GroupBox1.Controls.Add(Me.btnSearchUsr)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 447)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 120)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(150, 252)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select"
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
        Me.ListBox1.Size = New System.Drawing.Size(141, 114)
        Me.ListBox1.TabIndex = 0
        '
        'txtSearchUsr
        '
        Me.txtSearchUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchUsr.Location = New System.Drawing.Point(191, 384)
        Me.txtSearchUsr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchUsr.Name = "txtSearchUsr"
        Me.txtSearchUsr.Size = New System.Drawing.Size(614, 24)
        Me.txtSearchUsr.TabIndex = 34
        Me.txtSearchUsr.Text = "Enter your search here..."
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
        Me.button5.TabIndex = 35
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
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
        'AllAccountdata
        '
        Me.AllAccountdata.DataSetName = "AllAccountdata"
        Me.AllAccountdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsBindingSource2
        '
        Me.AccountsBindingSource2.DataMember = "Accounts"
        Me.AccountsBindingSource2.DataSource = Me.AllAccountdata
        '
        'AccountsTableAdapter1
        '
        Me.AccountsTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "userID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        '
        'programming
        '
        Me.programming.DataPropertyName = "programming"
        Me.programming.HeaderText = "programming"
        Me.programming.Name = "programming"
        '
        'chess
        '
        Me.chess.DataPropertyName = "chess"
        Me.chess.HeaderText = "chess"
        Me.chess.Name = "chess"
        '
        'reading
        '
        Me.reading.DataPropertyName = "reading"
        Me.reading.HeaderText = "reading"
        Me.reading.Name = "reading"
        '
        'music
        '
        Me.music.DataPropertyName = "music"
        Me.music.HeaderText = "music"
        Me.music.Name = "music"
        '
        'Admin_Privileges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 538)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button5)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin_Privileges"
        Me.Text = "Admin_Privileges"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AccountsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllAccountdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents btnAddAdmin As Button
    Private WithEvents btnRevoke As Button
    Private WithEvents btnSearchUsr As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearchUsr As TextBox
    Private WithEvents button5 As Button
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents programming As DataGridViewTextBoxColumn
    Friend WithEvents chess As DataGridViewTextBoxColumn
    Friend WithEvents reading As DataGridViewTextBoxColumn
    Friend WithEvents music As DataGridViewTextBoxColumn
End Class
