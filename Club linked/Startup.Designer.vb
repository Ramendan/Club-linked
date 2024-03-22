<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
        Me.BTlogin = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TBusername = New System.Windows.Forms.Label()
        Me.TBpass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTlogin
        '
        Me.BTlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTlogin.Location = New System.Drawing.Point(96, 168)
        Me.BTlogin.Name = "BTlogin"
        Me.BTlogin.Size = New System.Drawing.Size(143, 51)
        Me.BTlogin.TabIndex = 0
        Me.BTlogin.Text = "Login"
        Me.BTlogin.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(83, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 29)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(83, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 29)
        Me.TextBox2.TabIndex = 2
        '
        'TBusername
        '
        Me.TBusername.AutoSize = True
        Me.TBusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBusername.Location = New System.Drawing.Point(119, 23)
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(97, 24)
        Me.TBusername.TabIndex = 3
        Me.TBusername.Text = "Username"
        '
        'TBpass
        '
        Me.TBpass.AutoSize = True
        Me.TBpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBpass.Location = New System.Drawing.Point(119, 89)
        Me.TBpass.Name = "TBpass"
        Me.TBpass.Size = New System.Drawing.Size(92, 24)
        Me.TBpass.TabIndex = 4
        Me.TBpass.Text = "Password"
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(341, 279)
        Me.Controls.Add(Me.TBpass)
        Me.Controls.Add(Me.TBusername)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTlogin)
        Me.Name = "Startup"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTlogin As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TBusername As Label
    Friend WithEvents TBpass As Label
End Class
