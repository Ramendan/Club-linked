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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lPASSWORD_login = New System.Windows.Forms.Label()
        Me.lEMAIL_login = New System.Windows.Forms.Label()
        Me.bLOGIN = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.llSignUp_LOGIN = New System.Windows.Forms.LinkLabel()
        Me.lLOGIN = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lLOGIN)
        Me.Panel1.Controls.Add(Me.llSignUp_LOGIN)
        Me.Panel1.Controls.Add(Me.lPASSWORD_login)
        Me.Panel1.Controls.Add(Me.lEMAIL_login)
        Me.Panel1.Controls.Add(Me.bLOGIN)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(84, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 414)
        Me.Panel1.TabIndex = 0
        '
        'lPASSWORD_login
        '
        Me.lPASSWORD_login.AutoSize = True
        Me.lPASSWORD_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPASSWORD_login.Location = New System.Drawing.Point(153, 211)
        Me.lPASSWORD_login.Name = "lPASSWORD_login"
        Me.lPASSWORD_login.Size = New System.Drawing.Size(111, 20)
        Me.lPASSWORD_login.TabIndex = 4
        Me.lPASSWORD_login.Text = "PASSWORD"
        '
        'lEMAIL_login
        '
        Me.lEMAIL_login.AutoSize = True
        Me.lEMAIL_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEMAIL_login.Location = New System.Drawing.Point(174, 112)
        Me.lEMAIL_login.Name = "lEMAIL_login"
        Me.lEMAIL_login.Size = New System.Drawing.Size(63, 20)
        Me.lEMAIL_login.TabIndex = 3
        Me.lEMAIL_login.Text = "EMAIL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'bLOGIN
        '
        Me.bLOGIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLOGIN.Location = New System.Drawing.Point(322, 320)
        Me.bLOGIN.Name = "bLOGIN"
        Me.bLOGIN.Size = New System.Drawing.Size(75, 35)
        Me.bLOGIN.TabIndex = 2
        Me.bLOGIN.Text = "LOGIN"
        Me.bLOGIN.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 234)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 20)
        Me.TextBox1.TabIndex = 0
        '
        'llSignUp_LOGIN
        '
        Me.llSignUp_LOGIN.AutoSize = True
        Me.llSignUp_LOGIN.Location = New System.Drawing.Point(205, 290)
        Me.llSignUp_LOGIN.Name = "llSignUp_LOGIN"
        Me.llSignUp_LOGIN.Size = New System.Drawing.Size(48, 13)
        Me.llSignUp_LOGIN.TabIndex = 5
        Me.llSignUp_LOGIN.TabStop = True
        Me.llSignUp_LOGIN.Text = "Sign Up!"
        '
        'lLOGIN
        '
        Me.lLOGIN.AutoSize = True
        Me.lLOGIN.Location = New System.Drawing.Point(129, 290)
        Me.lLOGIN.Name = "lLOGIN"
        Me.lLOGIN.Size = New System.Drawing.Size(70, 13)
        Me.lLOGIN.TabIndex = 6
        Me.lLOGIN.Text = "No Account?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(640, 594)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lPASSWORD_login As Label
    Friend WithEvents lEMAIL_login As Label
    Friend WithEvents bLOGIN As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lLOGIN As Label
    Friend WithEvents llSignUp_LOGIN As LinkLabel
End Class
