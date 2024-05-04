<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Events
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(65, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(104, 31)
        Me.label1.TabIndex = 26
        Me.label1.Text = "Events"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.Location = New System.Drawing.Point(34, 21)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(197, 17)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(603, 356)
        Me.DataGridView1.TabIndex = 33
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(197, 386)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(603, 31)
        Me.txtSearch.TabIndex = 34
        Me.txtSearch.Text = "Enter your search here..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 447)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(20, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 217)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(172, 24)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Only from clubs im in"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(16, 49)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(147, 24)
        Me.CheckBox2.TabIndex = 36
        Me.CheckBox2.Text = "Hide past events"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(20, 386)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(172, 40)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search for event"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Events"
        Me.Text = "Events"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
