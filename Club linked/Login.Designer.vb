<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.LEmailLogin = New System.Windows.Forms.Label()
        Me.LPasswordLogin = New System.Windows.Forms.Label()
        Me.BLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.TBEmailLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TBPasswordLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'LEmailLogin
        '
        Me.LEmailLogin.AutoSize = True
        Me.LEmailLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmailLogin.Location = New System.Drawing.Point(204, 36)
        Me.LEmailLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LEmailLogin.Name = "LEmailLogin"
        Me.LEmailLogin.Size = New System.Drawing.Size(89, 33)
        Me.LEmailLogin.TabIndex = 3
        Me.LEmailLogin.Text = "Email"
        '
        'LPasswordLogin
        '
        Me.LPasswordLogin.AutoSize = True
        Me.LPasswordLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPasswordLogin.Location = New System.Drawing.Point(178, 137)
        Me.LPasswordLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LPasswordLogin.Name = "LPasswordLogin"
        Me.LPasswordLogin.Size = New System.Drawing.Size(143, 33)
        Me.LPasswordLogin.TabIndex = 4
        Me.LPasswordLogin.Text = "Password"
        '
        'BLogin
        '
        Me.BLogin.Animated = True
        Me.BLogin.AutoRoundedCorners = True
        Me.BLogin.BorderRadius = 33
        Me.BLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Location = New System.Drawing.Point(100, 249)
        Me.BLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(294, 69)
        Me.BLogin.TabIndex = 5
        Me.BLogin.Text = "Login"
        '
        'TBEmailLogin
        '
        Me.TBEmailLogin.Animated = True
        Me.TBEmailLogin.AutoRoundedCorners = True
        Me.TBEmailLogin.BorderRadius = 29
        Me.TBEmailLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBEmailLogin.DefaultText = ""
        Me.TBEmailLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBEmailLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBEmailLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBEmailLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBEmailLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBEmailLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TBEmailLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBEmailLogin.Location = New System.Drawing.Point(100, 74)
        Me.TBEmailLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBEmailLogin.Name = "TBEmailLogin"
        Me.TBEmailLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBEmailLogin.PlaceholderText = ""
        Me.TBEmailLogin.SelectedText = ""
        Me.TBEmailLogin.Size = New System.Drawing.Size(294, 60)
        Me.TBEmailLogin.TabIndex = 7
        '
        'TBPasswordLogin
        '
        Me.TBPasswordLogin.Animated = True
        Me.TBPasswordLogin.AutoRoundedCorners = True
        Me.TBPasswordLogin.BorderRadius = 29
        Me.TBPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBPasswordLogin.DefaultText = ""
        Me.TBPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBPasswordLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TBPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBPasswordLogin.Location = New System.Drawing.Point(100, 175)
        Me.TBPasswordLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBPasswordLogin.Name = "TBPasswordLogin"
        Me.TBPasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBPasswordLogin.PlaceholderText = ""
        Me.TBPasswordLogin.SelectedText = ""
        Me.TBPasswordLogin.Size = New System.Drawing.Size(294, 60)
        Me.TBPasswordLogin.TabIndex = 8
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(512, 429)
        Me.Controls.Add(Me.TBPasswordLogin)
        Me.Controls.Add(Me.TBEmailLogin)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.LPasswordLogin)
        Me.Controls.Add(Me.LEmailLogin)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LEmailLogin As Label
    Friend WithEvents LPasswordLogin As Label
    Friend WithEvents BLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TBEmailLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TBPasswordLogin As Guna.UI2.WinForms.Guna2TextBox
End Class
