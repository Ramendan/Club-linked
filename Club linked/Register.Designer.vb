<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.EmailTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DisplayNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RePasswordTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailL = New System.Windows.Forms.Label()
        Me.DisplayNameL = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.RePasswordL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EmailTB
        '
        Me.EmailTB.Animated = True
        Me.EmailTB.AutoRoundedCorners = True
        Me.EmailTB.BorderRadius = 29
        Me.EmailTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTB.DefaultText = ""
        Me.EmailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTB.Location = New System.Drawing.Point(246, 46)
        Me.EmailTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTB.PlaceholderText = ""
        Me.EmailTB.SelectedText = ""
        Me.EmailTB.Size = New System.Drawing.Size(286, 60)
        Me.EmailTB.TabIndex = 0
        '
        'DisplayNameTB
        '
        Me.DisplayNameTB.Animated = True
        Me.DisplayNameTB.AutoRoundedCorners = True
        Me.DisplayNameTB.BorderRadius = 29
        Me.DisplayNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DisplayNameTB.DefaultText = ""
        Me.DisplayNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DisplayNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DisplayNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DisplayNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DisplayNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayNameTB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DisplayNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayNameTB.Location = New System.Drawing.Point(246, 158)
        Me.DisplayNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DisplayNameTB.Name = "DisplayNameTB"
        Me.DisplayNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DisplayNameTB.PlaceholderText = ""
        Me.DisplayNameTB.SelectedText = ""
        Me.DisplayNameTB.Size = New System.Drawing.Size(286, 60)
        Me.DisplayNameTB.TabIndex = 1
        '
        'PasswordTB
        '
        Me.PasswordTB.Animated = True
        Me.PasswordTB.AutoRoundedCorners = True
        Me.PasswordTB.BorderRadius = 29
        Me.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTB.DefaultText = ""
        Me.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTB.Location = New System.Drawing.Point(246, 267)
        Me.PasswordTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTB.PlaceholderText = ""
        Me.PasswordTB.SelectedText = ""
        Me.PasswordTB.Size = New System.Drawing.Size(286, 60)
        Me.PasswordTB.TabIndex = 2
        '
        'RePasswordTB
        '
        Me.RePasswordTB.Animated = True
        Me.RePasswordTB.AutoRoundedCorners = True
        Me.RePasswordTB.BorderRadius = 29
        Me.RePasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RePasswordTB.DefaultText = ""
        Me.RePasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RePasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RePasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RePasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RePasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RePasswordTB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RePasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RePasswordTB.Location = New System.Drawing.Point(246, 376)
        Me.RePasswordTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RePasswordTB.Name = "RePasswordTB"
        Me.RePasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RePasswordTB.PlaceholderText = ""
        Me.RePasswordTB.SelectedText = ""
        Me.RePasswordTB.Size = New System.Drawing.Size(286, 60)
        Me.RePasswordTB.TabIndex = 3
        '
        'EmailL
        '
        Me.EmailL.AutoSize = True
        Me.EmailL.Location = New System.Drawing.Point(357, 21)
        Me.EmailL.Name = "EmailL"
        Me.EmailL.Size = New System.Drawing.Size(48, 20)
        Me.EmailL.TabIndex = 4
        Me.EmailL.Text = "Email"
        '
        'DisplayNameL
        '
        Me.DisplayNameL.AutoSize = True
        Me.DisplayNameL.Location = New System.Drawing.Point(335, 123)
        Me.DisplayNameL.Name = "DisplayNameL"
        Me.DisplayNameL.Size = New System.Drawing.Size(106, 20)
        Me.DisplayNameL.TabIndex = 5
        Me.DisplayNameL.Text = "Display Name"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(348, 233)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(78, 20)
        Me.Password.TabIndex = 6
        Me.Password.Text = "Password"
        '
        'RePasswordL
        '
        Me.RePasswordL.AutoSize = True
        Me.RePasswordL.Location = New System.Drawing.Point(317, 341)
        Me.RePasswordL.Name = "RePasswordL"
        Me.RePasswordL.Size = New System.Drawing.Size(146, 20)
        Me.RePasswordL.TabIndex = 7
        Me.RePasswordL.Text = "Re-Enter password"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RePasswordL)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.DisplayNameL)
        Me.Controls.Add(Me.EmailL)
        Me.Controls.Add(Me.RePasswordTB)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.DisplayNameTB)
        Me.Controls.Add(Me.EmailTB)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmailTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DisplayNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RePasswordTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailL As Label
    Friend WithEvents DisplayNameL As Label
    Friend WithEvents Password As Label
    Friend WithEvents RePasswordL As Label
End Class
