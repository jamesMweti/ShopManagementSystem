<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSettings
    Inherits System.Windows.Forms.UserControl

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
        pnlBody = New System.Windows.Forms.Panel()
        grpPassword = New System.Windows.Forms.GroupBox()
        lblCurrent = New System.Windows.Forms.Label()
        txtCurrent = New System.Windows.Forms.TextBox()
        lblNew = New System.Windows.Forms.Label()
        txtNew = New System.Windows.Forms.TextBox()
        lblConfirm = New System.Windows.Forms.Label()
        txtConfirm = New System.Windows.Forms.TextBox()
        btnChangePassword = New System.Windows.Forms.Button()
        grpShop = New System.Windows.Forms.GroupBox()
        lblShopName = New System.Windows.Forms.Label()
        txtShopName = New System.Windows.Forms.TextBox()
        btnSaveShop = New System.Windows.Forms.Button()
        pnlHeader = New System.Windows.Forms.Panel()
        lblSettingsTitle = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        pnlBody.SuspendLayout()
        grpPassword.SuspendLayout()
        grpShop.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(grpPassword)
        pnlBody.Controls.Add(grpShop)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1000, 556)
        pnlBody.TabIndex = 0
        ' 
        ' grpPassword
        ' 
        grpPassword.Controls.Add(lblCurrent)
        grpPassword.Controls.Add(txtCurrent)
        grpPassword.Controls.Add(lblNew)
        grpPassword.Controls.Add(txtNew)
        grpPassword.Controls.Add(lblConfirm)
        grpPassword.Controls.Add(txtConfirm)
        grpPassword.Controls.Add(btnChangePassword)
        grpPassword.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        grpPassword.Location = New System.Drawing.Point(24, 12)
        grpPassword.Name = "grpPassword"
        grpPassword.Size = New System.Drawing.Size(400, 290)
        grpPassword.TabIndex = 0
        grpPassword.TabStop = False
        grpPassword.Text = "Change my password"
        ' 
        ' lblCurrent
        ' 
        lblCurrent.AutoSize = True
        lblCurrent.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblCurrent.Location = New System.Drawing.Point(16, 30)
        lblCurrent.Name = "lblCurrent"
        lblCurrent.Size = New System.Drawing.Size(161, 25)
        lblCurrent.TabIndex = 0
        lblCurrent.Text = "Current password"
        ' 
        ' txtCurrent
        ' 
        txtCurrent.Font = New System.Drawing.Font("Segoe UI", 10.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        txtCurrent.Location = New System.Drawing.Point(16, 54)
        txtCurrent.MaxLength = 100
        txtCurrent.Name = "txtCurrent"
        txtCurrent.Size = New System.Drawing.Size(366, 35)
        txtCurrent.TabIndex = 1
        txtCurrent.UseSystemPasswordChar = True
        ' 
        ' lblNew
        ' 
        lblNew.AutoSize = True
        lblNew.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblNew.Location = New System.Drawing.Point(16, 90)
        lblNew.Name = "lblNew"
        lblNew.Size = New System.Drawing.Size(374, 25)
        lblNew.TabIndex = 2
        lblNew.Text = "New password (8+ chars, letters and digits)"
        ' 
        ' txtNew
        ' 
        txtNew.Font = New System.Drawing.Font("Segoe UI", 10.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        txtNew.Location = New System.Drawing.Point(16, 114)
        txtNew.MaxLength = 100
        txtNew.Name = "txtNew"
        txtNew.Size = New System.Drawing.Size(366, 35)
        txtNew.TabIndex = 3
        txtNew.UseSystemPasswordChar = True
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblConfirm.Location = New System.Drawing.Point(16, 150)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New System.Drawing.Size(205, 25)
        lblConfirm.TabIndex = 4
        lblConfirm.Text = "Confirm new password"
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Font = New System.Drawing.Font("Segoe UI", 10.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        txtConfirm.Location = New System.Drawing.Point(16, 174)
        txtConfirm.MaxLength = 100
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New System.Drawing.Size(366, 35)
        txtConfirm.TabIndex = 5
        txtConfirm.UseSystemPasswordChar = True
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Drawing.Color.Purple
        btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        btnChangePassword.FlatAppearance.BorderSize = 0
        btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnChangePassword.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnChangePassword.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnChangePassword.Location = New System.Drawing.Point(16, 226)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New System.Drawing.Size(200, 38)
        btnChangePassword.TabIndex = 6
        btnChangePassword.Text = "Update Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' grpShop
        ' 
        grpShop.Controls.Add(lblShopName)
        grpShop.Controls.Add(txtShopName)
        grpShop.Controls.Add(btnSaveShop)
        grpShop.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        grpShop.Location = New System.Drawing.Point(454, 12)
        grpShop.Name = "grpShop"
        grpShop.Size = New System.Drawing.Size(400, 140)
        grpShop.TabIndex = 1
        grpShop.TabStop = False
        grpShop.Text = "Shop details"
        ' 
        ' lblShopName
        ' 
        lblShopName.AutoSize = True
        lblShopName.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblShopName.Location = New System.Drawing.Point(16, 30)
        lblShopName.Name = "lblShopName"
        lblShopName.Size = New System.Drawing.Size(309, 25)
        lblShopName.TabIndex = 0
        lblShopName.Text = "Shop name (shown on PDF reports)"
        ' 
        ' txtShopName
        ' 
        txtShopName.Font = New System.Drawing.Font("Segoe UI", 10.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        txtShopName.Location = New System.Drawing.Point(16, 54)
        txtShopName.MaxLength = 100
        txtShopName.Name = "txtShopName"
        txtShopName.Size = New System.Drawing.Size(366, 35)
        txtShopName.TabIndex = 1
        ' 
        ' btnSaveShop
        ' 
        btnSaveShop.BackColor = Drawing.Color.Purple
        btnSaveShop.Cursor = System.Windows.Forms.Cursors.Hand
        btnSaveShop.FlatAppearance.BorderSize = 0
        btnSaveShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSaveShop.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnSaveShop.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnSaveShop.Location = New System.Drawing.Point(16, 92)
        btnSaveShop.Name = "btnSaveShop"
        btnSaveShop.Size = New System.Drawing.Size(120, 38)
        btnSaveShop.TabIndex = 2
        btnSaveShop.Text = "Save"
        btnSaveShop.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlHeader.Controls.Add(lblSettingsTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1000, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblSettingsTitle
        ' 
        lblSettingsTitle.AutoSize = True
        lblSettingsTitle.Font = New System.Drawing.Font("Segoe UI", 17F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSettingsTitle.Location = New System.Drawing.Point(24, 10)
        lblSettingsTitle.Name = "lblSettingsTitle"
        lblSettingsTitle.Size = New System.Drawing.Size(216, 46)
        lblSettingsTitle.TabIndex = 0
        lblSettingsTitle.Text = "⚙  Settings"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(110), CByte(50))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(243, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Account and shop settings"
        ' 
        ' ucSettings
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucSettings"
        Size = New System.Drawing.Size(1000, 640)
        pnlBody.ResumeLayout(False)
        grpPassword.ResumeLayout(False)
        grpPassword.PerformLayout()
        grpShop.ResumeLayout(False)
        grpShop.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents grpPassword As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents grpShop As System.Windows.Forms.GroupBox
    Friend WithEvents lblShopName As System.Windows.Forms.Label
    Friend WithEvents txtShopName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveShop As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSettingsTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label

End Class
