<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        lblWelcome = New System.Windows.Forms.Label()
        lblInstruction = New System.Windows.Forms.Label()
        txtUsername = New System.Windows.Forms.TextBox()
        txtPassword = New System.Windows.Forms.TextBox()
        btnLogin = New System.Windows.Forms.Button()
        lblNoAccount = New System.Windows.Forms.Label()
        lnkSignUp = New System.Windows.Forms.LinkLabel()
        pnlBrand = New System.Windows.Forms.Panel()
        lblLogo = New System.Windows.Forms.Label()
        lblTagline = New System.Windows.Forms.Label()
        lblSystemName = New System.Windows.Forms.Label()
        pnlForm.SuspendLayout()
        pnlBrand.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlForm
        ' 
        pnlForm.Controls.Add(lblWelcome)
        pnlForm.Controls.Add(lblInstruction)
        pnlForm.Controls.Add(txtUsername)
        pnlForm.Controls.Add(txtPassword)
        pnlForm.Controls.Add(btnLogin)
        pnlForm.Controls.Add(lblNoAccount)
        pnlForm.Controls.Add(lnkSignUp)
        pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        pnlForm.Location = New System.Drawing.Point(391, 0)
        pnlForm.Name = "pnlForm"
        pnlForm.Size = New System.Drawing.Size(549, 501)
        pnlForm.TabIndex = 0
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New System.Drawing.Font("Showcard Gothic", 24F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New System.Drawing.Point(66, 70)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New System.Drawing.Size(425, 60)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome Back!"
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Font = New System.Drawing.Font("MV Boli", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblInstruction.Location = New System.Drawing.Point(70, 126)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New System.Drawing.Size(266, 31)
        lblInstruction.TabIndex = 1
        lblInstruction.Text = "Login to your account"
        ' 
        ' txtUsername
        ' 
        txtUsername.AccessibleName = "Username"
        txtUsername.Font = New System.Drawing.Font("Segoe Print", 12F, Drawing.FontStyle.Bold)
        txtUsername.Location = New System.Drawing.Point(70, 180)
        txtUsername.MaxLength = 50
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New System.Drawing.Size(340, 50)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.AccessibleName = "Password"
        txtPassword.Font = New System.Drawing.Font("Segoe Print", 12F, Drawing.FontStyle.Bold)
        txtPassword.Location = New System.Drawing.Point(70, 232)
        txtPassword.MaxLength = 100
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New System.Drawing.Size(340, 50)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Drawing.Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnLogin.Font = New System.Drawing.Font("Segoe Print", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnLogin.Location = New System.Drawing.Point(70, 296)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New System.Drawing.Size(340, 44)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblNoAccount
        ' 
        lblNoAccount.AutoSize = True
        lblNoAccount.Font = New System.Drawing.Font("Segoe Print", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblNoAccount.Location = New System.Drawing.Point(40, 372)
        lblNoAccount.Name = "lblNoAccount"
        lblNoAccount.Size = New System.Drawing.Size(251, 35)
        lblNoAccount.TabIndex = 5
        lblNoAccount.Text = "Don't have an account?"
        ' 
        ' lnkSignUp
        ' 
        lnkSignUp.AutoSize = True
        lnkSignUp.Font = New System.Drawing.Font("Segoe Print", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lnkSignUp.LinkColor = Drawing.Color.FromArgb(CByte(128), CByte(64), CByte(64))
        lnkSignUp.Location = New System.Drawing.Point(297, 376)
        lnkSignUp.Name = "lnkSignUp"
        lnkSignUp.Size = New System.Drawing.Size(95, 35)
        lnkSignUp.TabIndex = 6
        lnkSignUp.TabStop = True
        lnkSignUp.Text = "Sign Up"
        ' 
        ' pnlBrand
        ' 
        pnlBrand.BackColor = Drawing.Color.RebeccaPurple
        pnlBrand.Controls.Add(lblSystemName)
        pnlBrand.Controls.Add(lblLogo)
        pnlBrand.Controls.Add(lblTagline)
        pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
        pnlBrand.Location = New System.Drawing.Point(0, 0)
        pnlBrand.Name = "pnlBrand"
        pnlBrand.Size = New System.Drawing.Size(391, 501)
        pnlBrand.TabIndex = 1
        ' 
        ' lblLogo
        ' 
        lblLogo.Font = New System.Drawing.Font("Segoe UI Emoji", 60F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(204), CByte(0))
        lblLogo.Location = New System.Drawing.Point(12, 5)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New System.Drawing.Size(340, 152)
        lblLogo.TabIndex = 0
        lblLogo.Text = ChrW(55357) & ChrW(57042)
        lblLogo.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblTagline
        ' 
        lblTagline.Font = New System.Drawing.Font("Mistral", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(204), CByte(0))
        lblTagline.Location = New System.Drawing.Point(12, 381)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New System.Drawing.Size(340, 30)
        lblTagline.TabIndex = 2
        lblTagline.Text = "Manage your shop easier"
        lblTagline.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblSystemName
        ' 
        lblSystemName.Font = New System.Drawing.Font("Lucida Sans Typewriter", 20F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSystemName.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lblSystemName.Location = New System.Drawing.Point(3, 157)
        lblSystemName.Name = "lblSystemName"
        lblSystemName.Size = New System.Drawing.Size(385, 197)
        lblSystemName.TabIndex = 3
        lblSystemName.Text = "Shop" & vbCrLf & "Management" & vbCrLf & "System"
        lblSystemName.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ClientSize = New System.Drawing.Size(940, 501)
        Controls.Add(pnlForm)
        Controls.Add(pnlBrand)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Shop Management System - Login"
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        pnlBrand.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblNoAccount As System.Windows.Forms.Label
    Friend WithEvents lnkSignUp As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblTagline As System.Windows.Forms.Label
    Friend WithEvents lblSystemName As System.Windows.Forms.Label

End Class
