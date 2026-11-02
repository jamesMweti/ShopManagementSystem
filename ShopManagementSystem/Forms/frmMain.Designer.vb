<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        pnlContent = New System.Windows.Forms.Panel()
        pnlSidebar = New System.Windows.Forms.Panel()
        flpNav = New System.Windows.Forms.FlowLayoutPanel()
        btnDashboard = New System.Windows.Forms.Button()
        btnProducts = New System.Windows.Forms.Button()
        btnCategories = New System.Windows.Forms.Button()
        btnCustomers = New System.Windows.Forms.Button()
        btnSuppliers = New System.Windows.Forms.Button()
        btnSales = New System.Windows.Forms.Button()
        btnInventory = New System.Windows.Forms.Button()
        btnUsers = New System.Windows.Forms.Button()
        btnReports = New System.Windows.Forms.Button()
        btnSettings = New System.Windows.Forms.Button()
        btnLogout = New System.Windows.Forms.Button()
        btnQuit = New System.Windows.Forms.Button()
        pnlBrand = New System.Windows.Forms.Panel()
        lblBrand = New System.Windows.Forms.Label()
        pnlSidebar.SuspendLayout()
        flpNav.SuspendLayout()
        pnlBrand.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        pnlContent.Location = New System.Drawing.Point(210, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New System.Drawing.Size(1070, 760)
        pnlContent.TabIndex = 0
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Drawing.Color.FromArgb(CByte(0), CByte(77), CByte(38))
        pnlSidebar.Controls.Add(flpNav)
        pnlSidebar.Controls.Add(pnlBrand)
        pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        pnlSidebar.Location = New System.Drawing.Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New System.Drawing.Size(210, 760)
        pnlSidebar.TabIndex = 1
        ' 
        ' flpNav
        ' 
        flpNav.BackColor = Drawing.Color.Purple
        flpNav.Controls.Add(btnDashboard)
        flpNav.Controls.Add(btnProducts)
        flpNav.Controls.Add(btnCategories)
        flpNav.Controls.Add(btnCustomers)
        flpNav.Controls.Add(btnSuppliers)
        flpNav.Controls.Add(btnSales)
        flpNav.Controls.Add(btnInventory)
        flpNav.Controls.Add(btnUsers)
        flpNav.Controls.Add(btnReports)
        flpNav.Controls.Add(btnSettings)
        flpNav.Controls.Add(btnLogout)
        flpNav.Controls.Add(btnQuit)
        flpNav.Dock = System.Windows.Forms.DockStyle.Fill
        flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        flpNav.Location = New System.Drawing.Point(0, 137)
        flpNav.Name = "flpNav"
        flpNav.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        flpNav.Size = New System.Drawing.Size(210, 623)
        flpNav.TabIndex = 0
        flpNav.WrapContents = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Drawing.Color.Purple
        btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnDashboard.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnDashboard.ForeColor = Drawing.Color.DarkGray
        btnDashboard.Location = New System.Drawing.Point(0, 6)
        btnDashboard.Margin = New System.Windows.Forms.Padding(0)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New System.Drawing.Size(210, 42)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnProducts
        ' 
        btnProducts.BackColor = Drawing.Color.Purple
        btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnProducts.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnProducts.ForeColor = Drawing.Color.DarkGray
        btnProducts.Location = New System.Drawing.Point(0, 48)
        btnProducts.Margin = New System.Windows.Forms.Padding(0)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New System.Drawing.Size(210, 42)
        btnProducts.TabIndex = 1
        btnProducts.Text = "Products"
        btnProducts.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnProducts.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.BackColor = Drawing.Color.Purple
        btnCategories.Cursor = System.Windows.Forms.Cursors.Hand
        btnCategories.FlatAppearance.BorderSize = 0
        btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCategories.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnCategories.ForeColor = Drawing.Color.DarkGray
        btnCategories.Location = New System.Drawing.Point(0, 90)
        btnCategories.Margin = New System.Windows.Forms.Padding(0)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New System.Drawing.Size(210, 42)
        btnCategories.TabIndex = 2
        btnCategories.Text = "Categories"
        btnCategories.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnCategories.UseVisualStyleBackColor = False
        ' 
        ' btnCustomers
        ' 
        btnCustomers.BackColor = Drawing.Color.Purple
        btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        btnCustomers.FlatAppearance.BorderSize = 0
        btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCustomers.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnCustomers.ForeColor = Drawing.Color.DarkGray
        btnCustomers.Location = New System.Drawing.Point(0, 132)
        btnCustomers.Margin = New System.Windows.Forms.Padding(0)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New System.Drawing.Size(210, 42)
        btnCustomers.TabIndex = 3
        btnCustomers.Text = "Customers"
        btnCustomers.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnCustomers.UseVisualStyleBackColor = False
        ' 
        ' btnSuppliers
        ' 
        btnSuppliers.BackColor = Drawing.Color.Purple
        btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand
        btnSuppliers.FlatAppearance.BorderSize = 0
        btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSuppliers.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnSuppliers.ForeColor = Drawing.Color.DarkGray
        btnSuppliers.Location = New System.Drawing.Point(0, 174)
        btnSuppliers.Margin = New System.Windows.Forms.Padding(0)
        btnSuppliers.Name = "btnSuppliers"
        btnSuppliers.Size = New System.Drawing.Size(210, 42)
        btnSuppliers.TabIndex = 4
        btnSuppliers.Text = "Suppliers"
        btnSuppliers.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnSuppliers.UseVisualStyleBackColor = False
        ' 
        ' btnSales
        ' 
        btnSales.BackColor = Drawing.Color.Purple
        btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        btnSales.FlatAppearance.BorderSize = 0
        btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSales.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnSales.ForeColor = Drawing.Color.DarkGray
        btnSales.Location = New System.Drawing.Point(0, 216)
        btnSales.Margin = New System.Windows.Forms.Padding(0)
        btnSales.Name = "btnSales"
        btnSales.Size = New System.Drawing.Size(210, 42)
        btnSales.TabIndex = 5
        btnSales.Text = "Sales"
        btnSales.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnSales.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Drawing.Color.Purple
        btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        btnInventory.FlatAppearance.BorderSize = 0
        btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnInventory.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnInventory.ForeColor = Drawing.Color.DarkGray
        btnInventory.Location = New System.Drawing.Point(0, 258)
        btnInventory.Margin = New System.Windows.Forms.Padding(0)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New System.Drawing.Size(210, 42)
        btnInventory.TabIndex = 6
        btnInventory.Text = "Inventory"
        btnInventory.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnUsers
        ' 
        btnUsers.BackColor = Drawing.Color.Purple
        btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnUsers.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnUsers.ForeColor = Drawing.Color.DarkGray
        btnUsers.Location = New System.Drawing.Point(0, 300)
        btnUsers.Margin = New System.Windows.Forms.Padding(0)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New System.Drawing.Size(210, 42)
        btnUsers.TabIndex = 8
        btnUsers.Text = "Users"
        btnUsers.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Drawing.Color.Purple
        btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnReports.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnReports.ForeColor = Drawing.Color.DarkGray
        btnReports.Location = New System.Drawing.Point(0, 342)
        btnReports.Margin = New System.Windows.Forms.Padding(0)
        btnReports.Name = "btnReports"
        btnReports.Size = New System.Drawing.Size(210, 42)
        btnReports.TabIndex = 7
        btnReports.Text = "Reports"
        btnReports.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Drawing.Color.Purple
        btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSettings.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnSettings.ForeColor = Drawing.Color.DarkGray
        btnSettings.Location = New System.Drawing.Point(0, 384)
        btnSettings.Margin = New System.Windows.Forms.Padding(0)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New System.Drawing.Size(210, 42)
        btnSettings.TabIndex = 9
        btnSettings.Text = "⚙   Settings"
        btnSettings.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Drawing.Color.Purple
        btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnLogout.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnLogout.ForeColor = Drawing.Color.DarkGray
        btnLogout.Location = New System.Drawing.Point(0, 426)
        btnLogout.Margin = New System.Windows.Forms.Padding(0)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New System.Drawing.Size(210, 42)
        btnLogout.TabIndex = 10
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnQuit
        ' 
        btnQuit.BackColor = Drawing.Color.Purple
        btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        btnQuit.FlatAppearance.BorderSize = 0
        btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnQuit.Font = New System.Drawing.Font("OCR A Extended", 10F, Drawing.FontStyle.Bold)
        btnQuit.ForeColor = Drawing.Color.DarkGray
        btnQuit.Location = New System.Drawing.Point(0, 468)
        btnQuit.Margin = New System.Windows.Forms.Padding(0)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New System.Drawing.Size(210, 42)
        btnQuit.TabIndex = 11
        btnQuit.Text = "Quit"
        btnQuit.TextAlign = Drawing.ContentAlignment.MiddleLeft
        btnQuit.UseVisualStyleBackColor = False
        ' 
        ' pnlBrand
        ' 
        pnlBrand.BackColor = Drawing.Color.Purple
        pnlBrand.Controls.Add(lblBrand)
        pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
        pnlBrand.Location = New System.Drawing.Point(0, 0)
        pnlBrand.Name = "pnlBrand"
        pnlBrand.Size = New System.Drawing.Size(210, 137)
        pnlBrand.TabIndex = 1
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.BackColor = Drawing.Color.Purple
        lblBrand.Font = New System.Drawing.Font("MV Boli", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblBrand.ForeColor = Drawing.Color.DarkGray
        lblBrand.Location = New System.Drawing.Point(14, 12)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New System.Drawing.Size(165, 93)
        lblBrand.TabIndex = 0
        lblBrand.Text = "Shop" & vbCrLf & "Management" & vbCrLf & "System"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ClientSize = New System.Drawing.Size(1280, 760)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        MinimumSize = New System.Drawing.Size(1050, 640)
        Name = "frmMain"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Shop Management System"
        pnlSidebar.ResumeLayout(False)
        flpNav.ResumeLayout(False)
        pnlBrand.ResumeLayout(False)
        pnlBrand.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents flpNav As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnCategories As System.Windows.Forms.Button
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents btnSuppliers As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
