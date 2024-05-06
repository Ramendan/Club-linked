<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnShow_signUp = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lLogin = New System.Windows.Forms.Label()
        Me.tbID_login = New System.Windows.Forms.TextBox()
        Me.tbPassword_login = New System.Windows.Forms.TextBox()
        Me.lUsername_login = New System.Windows.Forms.Label()
        Me.lPassword_login = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.btnHideLoginPass = New System.Windows.Forms.Button()
        Me.btnLoginShowPass = New System.Windows.Forms.Button()
        Me.gbRegister = New System.Windows.Forms.GroupBox()
        Me.btnHideConfirmPass = New System.Windows.Forms.Button()
        Me.btnHideRegisterPass = New System.Windows.Forms.Button()
        Me.btnConfirmShowPass = New System.Windows.Forms.Button()
        Me.btnRigShowPass = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbConfirmPass = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShow_login = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRegiserPass = New System.Windows.Forms.TextBox()
        Me.ttID = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbLogin.SuspendLayout()
        Me.gbRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow_signUp
        '
        Me.btnShow_signUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnShow_signUp.FlatAppearance.BorderSize = 0
        Me.btnShow_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow_signUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow_signUp.ForeColor = System.Drawing.Color.LightGray
        Me.btnShow_signUp.Location = New System.Drawing.Point(212, 374)
        Me.btnShow_signUp.Name = "btnShow_signUp"
        Me.btnShow_signUp.Size = New System.Drawing.Size(150, 40)
        Me.btnShow_signUp.TabIndex = 30
        Me.btnShow_signUp.Text = "Sign up"
        Me.btnShow_signUp.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.LightGray
        Me.btnLogin.Location = New System.Drawing.Point(45, 313)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(317, 40)
        Me.btnLogin.TabIndex = 29
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
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
        'lLogin
        '
        Me.lLogin.AutoSize = True
        Me.lLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lLogin.Location = New System.Drawing.Point(160, 16)
        Me.lLogin.Name = "lLogin"
        Me.lLogin.Size = New System.Drawing.Size(85, 31)
        Me.lLogin.TabIndex = 26
        Me.lLogin.Text = "Login"
        '
        'tbID_login
        '
        Me.tbID_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID_login.Location = New System.Drawing.Point(45, 142)
        Me.tbID_login.Name = "tbID_login"
        Me.tbID_login.Size = New System.Drawing.Size(317, 40)
        Me.tbID_login.TabIndex = 31
        '
        'tbPassword_login
        '
        Me.tbPassword_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword_login.Location = New System.Drawing.Point(45, 245)
        Me.tbPassword_login.Name = "tbPassword_login"
        Me.tbPassword_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword_login.Size = New System.Drawing.Size(317, 40)
        Me.tbPassword_login.TabIndex = 32
        '
        'lUsername_login
        '
        Me.lUsername_login.AutoSize = True
        Me.lUsername_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lUsername_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lUsername_login.Location = New System.Drawing.Point(149, 95)
        Me.lUsername_login.Name = "lUsername_login"
        Me.lUsername_login.Size = New System.Drawing.Size(107, 31)
        Me.lUsername_login.TabIndex = 33
        Me.lUsername_login.Text = "User ID"
        '
        'lPassword_login
        '
        Me.lPassword_login.AutoSize = True
        Me.lPassword_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lPassword_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lPassword_login.Location = New System.Drawing.Point(136, 198)
        Me.lPassword_login.Name = "lPassword_login"
        Me.lPassword_login.Size = New System.Drawing.Size(134, 31)
        Me.lPassword_login.TabIndex = 34
        Me.lPassword_login.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "New user?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.Label9)
        Me.gbLogin.Controls.Add(Me.btnHideLoginPass)
        Me.gbLogin.Controls.Add(Me.btnLoginShowPass)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.Label1)
        Me.gbLogin.Controls.Add(Me.lLogin)
        Me.gbLogin.Controls.Add(Me.btnShow_signUp)
        Me.gbLogin.Controls.Add(Me.lPassword_login)
        Me.gbLogin.Controls.Add(Me.tbID_login)
        Me.gbLogin.Controls.Add(Me.lUsername_login)
        Me.gbLogin.Controls.Add(Me.tbPassword_login)
        Me.gbLogin.Location = New System.Drawing.Point(34, 63)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(411, 463)
        Me.gbLogin.TabIndex = 36
        Me.gbLogin.TabStop = False
        '
        'btnHideLoginPass
        '
        Me.btnHideLoginPass.BackColor = System.Drawing.Color.White
        Me.btnHideLoginPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideLoginPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnHideLoginPass.Image = CType(resources.GetObject("btnHideLoginPass.Image"), System.Drawing.Image)
        Me.btnHideLoginPass.Location = New System.Drawing.Point(307, 246)
        Me.btnHideLoginPass.Name = "btnHideLoginPass"
        Me.btnHideLoginPass.Size = New System.Drawing.Size(52, 30)
        Me.btnHideLoginPass.TabIndex = 44
        Me.btnHideLoginPass.UseVisualStyleBackColor = False
        '
        'btnLoginShowPass
        '
        Me.btnLoginShowPass.BackColor = System.Drawing.Color.White
        Me.btnLoginShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginShowPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnLoginShowPass.Image = CType(resources.GetObject("btnLoginShowPass.Image"), System.Drawing.Image)
        Me.btnLoginShowPass.Location = New System.Drawing.Point(307, 246)
        Me.btnLoginShowPass.Name = "btnLoginShowPass"
        Me.btnLoginShowPass.Size = New System.Drawing.Size(52, 30)
        Me.btnLoginShowPass.TabIndex = 42
        Me.btnLoginShowPass.UseVisualStyleBackColor = False
        '
        'gbRegister
        '
        Me.gbRegister.Controls.Add(Me.btnHideConfirmPass)
        Me.gbRegister.Controls.Add(Me.btnHideRegisterPass)
        Me.gbRegister.Controls.Add(Me.btnConfirmShowPass)
        Me.gbRegister.Controls.Add(Me.btnRigShowPass)
        Me.gbRegister.Controls.Add(Me.Label7)
        Me.gbRegister.Controls.Add(Me.tbConfirmPass)
        Me.gbRegister.Controls.Add(Me.tbID)
        Me.gbRegister.Controls.Add(Me.Label6)
        Me.gbRegister.Controls.Add(Me.btnSignUp)
        Me.gbRegister.Controls.Add(Me.Label2)
        Me.gbRegister.Controls.Add(Me.Label3)
        Me.gbRegister.Controls.Add(Me.btnShow_login)
        Me.gbRegister.Controls.Add(Me.Label4)
        Me.gbRegister.Controls.Add(Me.tbName)
        Me.gbRegister.Controls.Add(Me.Label5)
        Me.gbRegister.Controls.Add(Me.tbRegiserPass)
        Me.gbRegister.Location = New System.Drawing.Point(34, 63)
        Me.gbRegister.Name = "gbRegister"
        Me.gbRegister.Size = New System.Drawing.Size(761, 463)
        Me.gbRegister.TabIndex = 37
        Me.gbRegister.TabStop = False
        '
        'btnHideConfirmPass
        '
        Me.btnHideConfirmPass.BackColor = System.Drawing.Color.White
        Me.btnHideConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideConfirmPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnHideConfirmPass.Image = CType(resources.GetObject("btnHideConfirmPass.Image"), System.Drawing.Image)
        Me.btnHideConfirmPass.Location = New System.Drawing.Point(661, 246)
        Me.btnHideConfirmPass.Name = "btnHideConfirmPass"
        Me.btnHideConfirmPass.Size = New System.Drawing.Size(52, 30)
        Me.btnHideConfirmPass.TabIndex = 43
        Me.btnHideConfirmPass.UseVisualStyleBackColor = False
        '
        'btnHideRegisterPass
        '
        Me.btnHideRegisterPass.BackColor = System.Drawing.Color.White
        Me.btnHideRegisterPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideRegisterPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnHideRegisterPass.Image = CType(resources.GetObject("btnHideRegisterPass.Image"), System.Drawing.Image)
        Me.btnHideRegisterPass.Location = New System.Drawing.Point(307, 246)
        Me.btnHideRegisterPass.Name = "btnHideRegisterPass"
        Me.btnHideRegisterPass.Size = New System.Drawing.Size(52, 30)
        Me.btnHideRegisterPass.TabIndex = 42
        Me.btnHideRegisterPass.UseVisualStyleBackColor = False
        '
        'btnConfirmShowPass
        '
        Me.btnConfirmShowPass.BackColor = System.Drawing.Color.White
        Me.btnConfirmShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmShowPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnConfirmShowPass.Image = CType(resources.GetObject("btnConfirmShowPass.Image"), System.Drawing.Image)
        Me.btnConfirmShowPass.Location = New System.Drawing.Point(661, 246)
        Me.btnConfirmShowPass.Name = "btnConfirmShowPass"
        Me.btnConfirmShowPass.Size = New System.Drawing.Size(52, 30)
        Me.btnConfirmShowPass.TabIndex = 41
        Me.btnConfirmShowPass.UseVisualStyleBackColor = False
        '
        'btnRigShowPass
        '
        Me.btnRigShowPass.BackColor = System.Drawing.Color.White
        Me.btnRigShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRigShowPass.ForeColor = System.Drawing.Color.Transparent
        Me.btnRigShowPass.Image = CType(resources.GetObject("btnRigShowPass.Image"), System.Drawing.Image)
        Me.btnRigShowPass.Location = New System.Drawing.Point(308, 246)
        Me.btnRigShowPass.Name = "btnRigShowPass"
        Me.btnRigShowPass.Size = New System.Drawing.Size(52, 30)
        Me.btnRigShowPass.TabIndex = 40
        Me.btnRigShowPass.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(438, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 31)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Confirm Password"
        '
        'tbConfirmPass
        '
        Me.tbConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmPass.Location = New System.Drawing.Point(398, 245)
        Me.tbConfirmPass.Name = "tbConfirmPass"
        Me.tbConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmPass.Size = New System.Drawing.Size(317, 40)
        Me.tbConfirmPass.TabIndex = 38
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(398, 142)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(317, 40)
        Me.tbID.TabIndex = 36
        Me.ttID.SetToolTip(Me.tbID, "Example: 210000")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(481, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 31)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "College ID"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.LightGray
        Me.btnSignUp.Location = New System.Drawing.Point(166, 313)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(420, 40)
        Me.btnSignUp.TabIndex = 29
        Me.btnSignUp.Text = "Sign up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(168, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(262, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Already have an account?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(317, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 31)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Register"
        '
        'btnShow_login
        '
        Me.btnShow_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnShow_login.FlatAppearance.BorderSize = 0
        Me.btnShow_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow_login.ForeColor = System.Drawing.Color.LightGray
        Me.btnShow_login.Location = New System.Drawing.Point(436, 374)
        Me.btnShow_login.Name = "btnShow_login"
        Me.btnShow_login.Size = New System.Drawing.Size(150, 40)
        Me.btnShow_login.TabIndex = 30
        Me.btnShow_login.Text = "Login"
        Me.btnShow_login.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(136, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 31)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Password"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(45, 142)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(317, 40)
        Me.tbName.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(159, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 31)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Name"
        '
        'tbRegiserPass
        '
        Me.tbRegiserPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRegiserPass.Location = New System.Drawing.Point(45, 245)
        Me.tbRegiserPass.Name = "tbRegiserPass"
        Me.tbRegiserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbRegiserPass.Size = New System.Drawing.Size(317, 40)
        Me.tbRegiserPass.TabIndex = 32
        '
        'ttID
        '
        Me.ttID.ToolTipTitle = "ID must be a number"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.LightGray
        Me.btnLogout.Location = New System.Drawing.Point(645, 13)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(150, 40)
        Me.btnLogout.TabIndex = 44
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(73, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 31)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Login"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(41, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 72)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Admin login:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID: 210608" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password: 123123" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1091, 941)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.gbRegister)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.gbRegister.ResumeLayout(False)
        Me.gbRegister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnShow_signUp As Button
    Private WithEvents btnLogin As Button
    Private WithEvents btnClose As Button
    Private WithEvents lLogin As Label
    Friend WithEvents tbID_login As TextBox
    Friend WithEvents tbPassword_login As TextBox
    Private WithEvents lUsername_login As Label
    Private WithEvents lPassword_login As Label
    Private WithEvents Label1 As Label
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents gbRegister As GroupBox
    Private WithEvents btnSignUp As Button
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents btnShow_login As Button
    Private WithEvents Label4 As Label
    Friend WithEvents tbName As TextBox
    Private WithEvents Label5 As Label
    Friend WithEvents tbRegiserPass As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents tbConfirmPass As TextBox
    Friend WithEvents tbID As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents btnRigShowPass As Button
    Friend WithEvents btnConfirmShowPass As Button
    Friend WithEvents btnLoginShowPass As Button
    Friend WithEvents btnHideRegisterPass As Button
    Friend WithEvents btnHideConfirmPass As Button
    Friend WithEvents btnHideLoginPass As Button
    Friend WithEvents ttID As ToolTip
    Private WithEvents btnLogout As Button
    Private WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
