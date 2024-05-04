<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.gbCreator = New System.Windows.Forms.GroupBox()
        Me.cbReason = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Announcment1 = New System.Windows.Forms.RichTextBox()
        Me.lLogin = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbCreator.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCreator
        '
        Me.gbCreator.Controls.Add(Me.Label2)
        Me.gbCreator.Controls.Add(Me.Label1)
        Me.gbCreator.Controls.Add(Me.cbReason)
        Me.gbCreator.Controls.Add(Me.TextBox1)
        Me.gbCreator.Controls.Add(Me.Button1)
        Me.gbCreator.Controls.Add(Me.Announcment1)
        Me.gbCreator.Location = New System.Drawing.Point(62, 55)
        Me.gbCreator.Margin = New System.Windows.Forms.Padding(2)
        Me.gbCreator.Name = "gbCreator"
        Me.gbCreator.Padding = New System.Windows.Forms.Padding(2)
        Me.gbCreator.Size = New System.Drawing.Size(676, 350)
        Me.gbCreator.TabIndex = 48
        Me.gbCreator.TabStop = False
        '
        'cbReason
        '
        Me.cbReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReason.FormattingEnabled = True
        Me.cbReason.Items.AddRange(New Object() {"Report spam", "Report user", "Report bug", "Give suggestion", "More (write in the text box).."})
        Me.cbReason.Location = New System.Drawing.Point(140, 22)
        Me.cbReason.Name = "cbReason"
        Me.cbReason.Size = New System.Drawing.Size(511, 32)
        Me.cbReason.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(140, 59)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(511, 29)
        Me.TextBox1.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(25, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 68)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Send now"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Announcment1
        '
        Me.Announcment1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Announcment1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Announcment1.Location = New System.Drawing.Point(25, 100)
        Me.Announcment1.Name = "Announcment1"
        Me.Announcment1.ReadOnly = True
        Me.Announcment1.Size = New System.Drawing.Size(626, 161)
        Me.Announcment1.TabIndex = 41
        Me.Announcment1.Text = "Report text here"
        '
        'lLogin
        '
        Me.lLogin.AutoSize = True
        Me.lLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lLogin.Location = New System.Drawing.Point(65, 22)
        Me.lLogin.Name = "lLogin"
        Me.lLogin.Size = New System.Drawing.Size(102, 31)
        Me.lLogin.TabIndex = 49
        Me.lLogin.Text = "Report"
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
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Reason"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Other reason"
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lLogin)
        Me.Controls.Add(Me.gbCreator)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.gbCreator.ResumeLayout(False)
        Me.gbCreator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbCreator As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents Button1 As Button
    Friend WithEvents Announcment1 As RichTextBox
    Private WithEvents lLogin As Label
    Friend WithEvents cbReason As ComboBox
    Private WithEvents btnClose As Button
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
End Class
