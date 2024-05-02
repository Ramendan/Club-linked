<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAnnouncements
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Announcment1 = New System.Windows.Forms.RichTextBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnOpenDatabase = New System.Windows.Forms.Button()
        Me.gbCreator = New System.Windows.Forms.GroupBox()
        Me.gbAnnouncementDatabase = New System.Windows.Forms.GroupBox()
        Me.btnCreator = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.gbCreator.SuspendLayout()
        Me.gbAnnouncementDatabase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(32, 297)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 84)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Send now"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Announcment1
        '
        Me.Announcment1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Announcment1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Announcment1.Location = New System.Drawing.Point(32, 77)
        Me.Announcment1.Margin = New System.Windows.Forms.Padding(4)
        Me.Announcment1.Name = "Announcment1"
        Me.Announcment1.ReadOnly = True
        Me.Announcment1.Size = New System.Drawing.Size(834, 212)
        Me.Announcment1.TabIndex = 41
        Me.Announcment1.Text = "Announcment text here"
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.LightGray
        Me.button5.Location = New System.Drawing.Point(69, 19)
        Me.button5.Margin = New System.Windows.Forms.Padding(4)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(33, 31)
        Me.button5.TabIndex = 39
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(336, 37)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(249, 39)
        Me.label1.TabIndex = 38
        Me.label1.Text = "Announcments"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(32, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 34)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "Title here"
        '
        'btnOpenDatabase
        '
        Me.btnOpenDatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnOpenDatabase.FlatAppearance.BorderSize = 0
        Me.btnOpenDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenDatabase.ForeColor = System.Drawing.Color.LightGray
        Me.btnOpenDatabase.Location = New System.Drawing.Point(324, 297)
        Me.btnOpenDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenDatabase.Name = "btnOpenDatabase"
        Me.btnOpenDatabase.Size = New System.Drawing.Size(225, 84)
        Me.btnOpenDatabase.TabIndex = 46
        Me.btnOpenDatabase.Text = "Open announcment database"
        Me.btnOpenDatabase.UseVisualStyleBackColor = False
        '
        'gbCreator
        '
        Me.gbCreator.Controls.Add(Me.btnOpenDatabase)
        Me.gbCreator.Controls.Add(Me.TextBox1)
        Me.gbCreator.Controls.Add(Me.Button1)
        Me.gbCreator.Controls.Add(Me.Announcment1)
        Me.gbCreator.Location = New System.Drawing.Point(37, 107)
        Me.gbCreator.Name = "gbCreator"
        Me.gbCreator.Size = New System.Drawing.Size(901, 418)
        Me.gbCreator.TabIndex = 47
        Me.gbCreator.TabStop = False
        '
        'gbAnnouncementDatabase
        '
        Me.gbAnnouncementDatabase.Controls.Add(Me.btnCreator)
        Me.gbAnnouncementDatabase.Controls.Add(Me.Button3)
        Me.gbAnnouncementDatabase.Controls.Add(Me.txtSearch)
        Me.gbAnnouncementDatabase.Controls.Add(Me.DataGridView1)
        Me.gbAnnouncementDatabase.Controls.Add(Me.btnNext)
        Me.gbAnnouncementDatabase.Controls.Add(Me.btnPrev)
        Me.gbAnnouncementDatabase.Controls.Add(Me.btnSearch)
        Me.gbAnnouncementDatabase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbAnnouncementDatabase.Location = New System.Drawing.Point(31, 129)
        Me.gbAnnouncementDatabase.Name = "gbAnnouncementDatabase"
        Me.gbAnnouncementDatabase.Size = New System.Drawing.Size(910, 376)
        Me.gbAnnouncementDatabase.TabIndex = 48
        Me.gbAnnouncementDatabase.TabStop = False
        '
        'btnCreator
        '
        Me.btnCreator.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnCreator.FlatAppearance.BorderSize = 0
        Me.btnCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreator.ForeColor = System.Drawing.Color.LightGray
        Me.btnCreator.Location = New System.Drawing.Point(26, 199)
        Me.btnCreator.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreator.Name = "btnCreator"
        Me.btnCreator.Size = New System.Drawing.Size(200, 49)
        Me.btnCreator.TabIndex = 36
        Me.btnCreator.Text = "Return to creator"
        Me.btnCreator.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.LightGray
        Me.Button3.Location = New System.Drawing.Point(25, 82)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 49)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(255, 330)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(636, 28)
        Me.txtSearch.TabIndex = 34
        Me.txtSearch.Text = "Enter your search here..."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(255, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(636, 288)
        Me.DataGridView1.TabIndex = 33
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.LightGray
        Me.btnNext.Location = New System.Drawing.Point(26, 22)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 49)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.LightGray
        Me.btnPrev.Location = New System.Drawing.Point(25, 142)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(200, 49)
        Me.btnPrev.TabIndex = 31
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(34, 309)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(200, 49)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search for event"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'AdminAnnouncements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(967, 551)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.gbCreator)
        Me.Controls.Add(Me.gbAnnouncementDatabase)
        Me.Name = "AdminAnnouncements"
        Me.Text = "AdminAnnouncements"
        Me.gbCreator.ResumeLayout(False)
        Me.gbCreator.PerformLayout()
        Me.gbAnnouncementDatabase.ResumeLayout(False)
        Me.gbAnnouncementDatabase.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button1 As Button
    Friend WithEvents Announcment1 As RichTextBox
    Private WithEvents button5 As Button
    Private WithEvents label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents btnOpenDatabase As Button
    Friend WithEvents gbCreator As GroupBox
    Friend WithEvents gbAnnouncementDatabase As GroupBox
    Private WithEvents Button3 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents btnNext As Button
    Private WithEvents btnPrev As Button
    Private WithEvents btnSearch As Button
    Private WithEvents btnCreator As Button
End Class
