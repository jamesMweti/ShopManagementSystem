<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignUp
    Inherits System.Windows.Forms.Form

    'Form/UserControl overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer. Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlForm = New System.Windows.Forms.Panel()
        lblCreateAccount = New System.Windows.Forms.Label()
        lblJoin = New System.Windows.Forms.Label()
        txtFullName = New System.Windows.Forms.TextBox()
        txtEmail = New System.Windows.Forms.TextBox()
        txtUsername = New System.Windows.Forms.TextBox()
        txtPassword = New System.Windows.Forms.TextBox()
        txtConfirmPassword = New System.Windows.Forms.TextBox()
        btnSignUp = New System.Windows.Forms.Button()
        lblHaveAccount = New System.Windows.Forms.Label()
        lnkLogin = New System.Windows.Forms.LinkLabel()
        pnlBrand = New System.Windows.Forms.Panel()
        lblLogo = New System.Windows.Forms.Label()
        lblSystemName = New System.Windows.Forms.Label()
        lblTagline = New System.Windows.Forms.Label()
        pnlForm.SuspendLayout()
        pnlBrand.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlForm
        ' 
        pnlForm.Controls.Add(lblCreateAccount)
        pnlForm.Controls.Add(lblJoin)
        pnlForm.Controls.Add(txtFullName)
        pnlForm.Controls.Add(txtEmail)
        pnlForm.Controls.Add(txtUsername)
        pnlForm.Controls.Add(txtPassword)
        pnlForm.Controls.Add(txtConfirmPassword)
        pnlForm.Controls.Add(btnSignUp)
        pnlForm.Controls.Add(lblHaveAccount)
        pnlForm.Controls.Add(lnkLogin)
        pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        pnlForm.Location = New System.Drawing.Point(365, 0)
        pnlForm.Name = "pnlForm"
        pnlForm.Size = New System.Drawing.Size(679, 580)
        pnlForm.TabIndex = 0
        ' 
        ' lblCreateAccount
        ' 
        lblCreateAccount.AutoSize = True
        lblCreateAccount.Font = New System.Drawing.Font("Showcard Gothic", 22F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblCreateAccount.Location = New System.Drawing.Point(188, 42)
        lblCreateAccount.Name = "lblCreateAccount"
        lblCreateAccount.Size = New System.Drawing.Size(399, 54)
        lblCreateAccount.TabIndex = 0
        lblCreateAccount.Text = "Create Account"
        ' 
        ' lblJoin
        ' 
        lblJoin.AutoSize = True
        lblJoin.Font = New System.Drawing.Font("Ink Free", 10.999999F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblJoin.Location = New System.Drawing.Point(192, 94)
        lblJoin.Name = "lblJoin"
        lblJoin.Size = New System.Drawing.Size(360, 27)
        lblJoin.TabIndex = 1
        lblJoin.Text = "Join our shop management system"
        ' 
        ' txtFullName
        ' 
        txtFullName.AccessibleName = "Full Name"
        txtFullName.Font = New System.Drawing.Font("Segoe Print", 12F)
        txtFullName.Location = New System.Drawing.Point(192, 137)
        txtFullName.MaxLength = 100
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "Full Name"
        txtFullName.Size = New System.Drawing.Size(340, 50)
        txtFullName.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.AccessibleName = "Email Address"
        txtEmail.Font = New System.Drawing.Font("Segoe Print", 12F)
        txtEmail.Location = New System.Drawing.Point(192, 189)
        txtEmail.MaxLength = 150
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email Address"
        txtEmail.Size = New System.Drawing.Size(340, 50)
        txtEmail.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.AccessibleName = "Username"
        txtUsername.Font = New System.Drawing.Font("Segoe Print", 12F)
        txtUsername.Location = New System.Drawing.Point(192, 241)
        txtUsername.MaxLength = 50
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New System.Drawing.Size(340, 50)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.AccessibleName = "Password (8+ chars, letters and digits)"
        txtPassword.Font = New System.Drawing.Font("Segoe Print", 12F)
        txtPassword.Location = New System.Drawing.Point(192, 293)
        txtPassword.MaxLength = 100
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password (8+ chars, letters and digits)"
        txtPassword.Size = New System.Drawing.Size(340, 50)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.AccessibleName = "Confirm Password"
        txtConfirmPassword.Font = New System.Drawing.Font("Segoe Print", 12F)
        txtConfirmPassword.Location = New System.Drawing.Point(192, 345)
        txtConfirmPassword.MaxLength = 100
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Confirm Password"
        txtConfirmPassword.Size = New System.Drawing.Size(340, 50)
        txtConfirmPassword.TabIndex = 6
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Drawing.Color.FromArgb(CByte(64), CByte(64), CByte(0))
        btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        btnSignUp.FlatAppearance.BorderSize = 0
        btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSignUp.Font = New System.Drawing.Font("Segoe Print", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnSignUp.Location = New System.Drawing.Point(192, 407)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New System.Drawing.Size(340, 44)
        btnSignUp.TabIndex = 7
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' lblHaveAccount
        ' 
        lblHaveAccount.AutoSize = True
        lblHaveAccount.Font = New System.Drawing.Font("Segoe Print", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblHaveAccount.Location = New System.Drawing.Point(201, 482)
        lblHaveAccount.Name = "lblHaveAccount"
        lblHaveAccount.Size = New System.Drawing.Size(276, 35)
        lblHaveAccount.TabIndex = 8
        lblHaveAccount.Text = "Already have an account?"
        ' 
        ' lnkLogin
        ' 
        lnkLogin.AutoSize = True
        lnkLogin.Font = New System.Drawing.Font("Segoe Print", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lnkLogin.LinkColor = Drawing.Color.FromArgb(CByte(128), CByte(64), CByte(64))
        lnkLogin.Location = New System.Drawing.Point(483, 482)
        lnkLogin.Name = "lnkLogin"
        lnkLogin.Size = New System.Drawing.Size(69, 35)
        lnkLogin.TabIndex = 9
        lnkLogin.TabStop = True
        lnkLogin.Text = "Login"
        ' 
        ' pnlBrand
        ' 
        pnlBrand.BackColor = Drawing.Color.Purple
        pnlBrand.Controls.Add(lblLogo)
        pnlBrand.Controls.Add(lblSystemName)
        pnlBrand.Controls.Add(lblTagline)
        pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
        pnlBrand.Location = New System.Drawing.Point(0, 0)
        pnlBrand.Name = "pnlBrand"
        pnlBrand.Size = New System.Drawing.Size(365, 580)
        pnlBrand.TabIndex = 1
        ' 
        ' lblLogo
        ' 
        lblLogo.Font = New System.Drawing.Font("Segoe UI Emoji", 60F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(204), CByte(0))
        lblLogo.Location = New System.Drawing.Point(0, 80)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New System.Drawing.Size(340, 130)
        lblLogo.TabIndex = 0
        lblLogo.Text = ChrW(55357) & ChrW(57042)
        lblLogo.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblSystemName
        ' 
        lblSystemName.Font = New System.Drawing.Font("Segoe UI Black", 26F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSystemName.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lblSystemName.Location = New System.Drawing.Point(0, 215)
        lblSystemName.Name = "lblSystemName"
        lblSystemName.Size = New System.Drawing.Size(340, 150)
        lblSystemName.TabIndex = 1
        lblSystemName.Text = "Shop" & vbCrLf & "Management" & vbCrLf & "System"
        lblSystemName.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblTagline
        ' 
        lblTagline.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(204), CByte(0))
        lblTagline.Location = New System.Drawing.Point(0, 370)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New System.Drawing.Size(340, 30)
        lblTagline.TabIndex = 2
        lblTagline.Text = "Manage • Sell • Grow"
        lblTagline.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' frmSignUp
        ' 
        AcceptButton = btnSignUp
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ClientSize = New System.Drawing.Size(1044, 580)
        Controls.Add(pnlForm)
        Controls.Add(pnlBrand)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSignUp"
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Text = "Shop Management System - Sign Up"
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        pnlBrand.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblCreateAccount As System.Windows.Forms.Label
    Friend WithEvents lblJoin As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSignUp As System.Windows.Forms.Button
    Friend WithEvents lblHaveAccount As System.Windows.Forms.Label
    Friend WithEvents lnkLogin As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblSystemName As System.Windows.Forms.Label
    Friend WithEvents lblTagline As System.Windows.Forms.Label

End Class
