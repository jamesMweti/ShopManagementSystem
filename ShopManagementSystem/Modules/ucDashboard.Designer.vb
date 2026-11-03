<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDashboard
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
        pnlChart = New System.Windows.Forms.Panel()
        chtSalesOverview = New BarChart()
        pnlTopProducts = New System.Windows.Forms.Panel()
        dgvTopProducts = New System.Windows.Forms.DataGridView()
        lblTopTitle = New System.Windows.Forms.Label()
        flpCards = New System.Windows.Forms.FlowLayoutPanel()
        pnlTotalSales = New System.Windows.Forms.Panel()
        lblTotalSalesCaption = New System.Windows.Forms.Label()
        lblTotalSalesValue = New System.Windows.Forms.Label()
        pnlProducts = New System.Windows.Forms.Panel()
        lblProductsCaption = New System.Windows.Forms.Label()
        lblProductsValue = New System.Windows.Forms.Label()
        pnlCustomers = New System.Windows.Forms.Panel()
        lblCustomersCaption = New System.Windows.Forms.Label()
        lblCustomersValue = New System.Windows.Forms.Label()
        pnlLowStock = New System.Windows.Forms.Panel()
        lblLowStockCaption = New System.Windows.Forms.Label()
        lblLowStockValue = New System.Windows.Forms.Label()
        pnlHeader = New System.Windows.Forms.Panel()
        lblWelcome = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        lblDate = New System.Windows.Forms.Label()
        pnlBody.SuspendLayout()
        pnlChart.SuspendLayout()
        pnlTopProducts.SuspendLayout()
        CType(dgvTopProducts, ComponentModel.ISupportInitialize).BeginInit()
        flpCards.SuspendLayout()
        pnlTotalSales.SuspendLayout()
        pnlProducts.SuspendLayout()
        pnlCustomers.SuspendLayout()
        pnlLowStock.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(pnlChart)
        pnlBody.Controls.Add(pnlTopProducts)
        pnlBody.Controls.Add(flpCards)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1225, 671)
        pnlBody.TabIndex = 0
        ' 
        ' pnlChart
        ' 
        pnlChart.Controls.Add(chtSalesOverview)
        pnlChart.Dock = System.Windows.Forms.DockStyle.Fill
        pnlChart.Location = New System.Drawing.Point(24, 128)
        pnlChart.Name = "pnlChart"
        pnlChart.Size = New System.Drawing.Size(837, 527)
        pnlChart.TabIndex = 0
        ' 
        ' chtSalesOverview
        ' 
        chtSalesOverview.BackColor = Drawing.Color.White
        chtSalesOverview.ChartTitle = "Sales Overview (last 7 days)"
        chtSalesOverview.Dock = System.Windows.Forms.DockStyle.Fill
        chtSalesOverview.Font = New System.Drawing.Font("Segoe UI", 8.5F)
        chtSalesOverview.Location = New System.Drawing.Point(0, 0)
        chtSalesOverview.Name = "chtSalesOverview"
        chtSalesOverview.Size = New System.Drawing.Size(837, 527)
        chtSalesOverview.TabIndex = 0
        ' 
        ' pnlTopProducts
        ' 
        pnlTopProducts.BackColor = Drawing.Color.Maroon
        pnlTopProducts.Controls.Add(dgvTopProducts)
        pnlTopProducts.Controls.Add(lblTopTitle)
        pnlTopProducts.Dock = System.Windows.Forms.DockStyle.Right
        pnlTopProducts.Location = New System.Drawing.Point(861, 128)
        pnlTopProducts.Name = "pnlTopProducts"
        pnlTopProducts.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        pnlTopProducts.Size = New System.Drawing.Size(340, 527)
        pnlTopProducts.TabIndex = 1
        ' 
        ' dgvTopProducts
        ' 
        dgvTopProducts.BackgroundColor = Drawing.Color.Maroon
        dgvTopProducts.ColumnHeadersHeight = 34
        dgvTopProducts.Dock = System.Windows.Forms.DockStyle.Fill
        dgvTopProducts.Location = New System.Drawing.Point(16, 32)
        dgvTopProducts.Name = "dgvTopProducts"
        dgvTopProducts.RowHeadersWidth = 62
        dgvTopProducts.Size = New System.Drawing.Size(324, 495)
        dgvTopProducts.TabIndex = 0
        ' 
        ' lblTopTitle
        ' 
        lblTopTitle.Dock = System.Windows.Forms.DockStyle.Top
        lblTopTitle.Font = New System.Drawing.Font("Segoe UI", 11F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTopTitle.ForeColor = Drawing.SystemColors.ActiveCaption
        lblTopTitle.Location = New System.Drawing.Point(16, 0)
        lblTopTitle.Name = "lblTopTitle"
        lblTopTitle.Size = New System.Drawing.Size(324, 32)
        lblTopTitle.TabIndex = 1
        lblTopTitle.Text = "Top Selling Products"
        ' 
        ' flpCards
        ' 
        flpCards.Controls.Add(pnlTotalSales)
        flpCards.Controls.Add(pnlProducts)
        flpCards.Controls.Add(pnlCustomers)
        flpCards.Controls.Add(pnlLowStock)
        flpCards.Dock = System.Windows.Forms.DockStyle.Top
        flpCards.Location = New System.Drawing.Point(24, 4)
        flpCards.Name = "flpCards"
        flpCards.Padding = New System.Windows.Forms.Padding(0, 4, 0, 10)
        flpCards.Size = New System.Drawing.Size(1177, 124)
        flpCards.TabIndex = 2
        flpCards.WrapContents = False
        ' 
        ' pnlTotalSales
        ' 
        pnlTotalSales.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(224), CByte(192))
        pnlTotalSales.Controls.Add(lblTotalSalesCaption)
        pnlTotalSales.Controls.Add(lblTotalSalesValue)
        pnlTotalSales.Location = New System.Drawing.Point(0, 4)
        pnlTotalSales.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        pnlTotalSales.Name = "pnlTotalSales"
        pnlTotalSales.Size = New System.Drawing.Size(286, 104)
        pnlTotalSales.TabIndex = 0
        ' 
        ' lblTotalSalesCaption
        ' 
        lblTotalSalesCaption.AutoSize = True
        lblTotalSalesCaption.Font = New System.Drawing.Font("Century Gothic", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTotalSalesCaption.ForeColor = Drawing.Color.Black
        lblTotalSalesCaption.Location = New System.Drawing.Point(16, 14)
        lblTotalSalesCaption.Name = "lblTotalSalesCaption"
        lblTotalSalesCaption.Size = New System.Drawing.Size(111, 23)
        lblTotalSalesCaption.TabIndex = 0
        lblTotalSalesCaption.Text = "Total Sales"
        ' 
        ' lblTotalSalesValue
        ' 
        lblTotalSalesValue.AutoSize = True
        lblTotalSalesValue.Font = New System.Drawing.Font("Yu Gothic", 16F, Drawing.FontStyle.Bold)
        lblTotalSalesValue.Location = New System.Drawing.Point(14, 44)
        lblTotalSalesValue.Name = "lblTotalSalesValue"
        lblTotalSalesValue.Size = New System.Drawing.Size(36, 42)
        lblTotalSalesValue.TabIndex = 1
        lblTotalSalesValue.Text = "0"
        ' 
        ' pnlProducts
        ' 
        pnlProducts.BackColor = Drawing.Color.Gray
        pnlProducts.Controls.Add(lblProductsCaption)
        pnlProducts.Controls.Add(lblProductsValue)
        pnlProducts.Location = New System.Drawing.Point(302, 4)
        pnlProducts.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        pnlProducts.Name = "pnlProducts"
        pnlProducts.Size = New System.Drawing.Size(291, 104)
        pnlProducts.TabIndex = 1
        ' 
        ' lblProductsCaption
        ' 
        lblProductsCaption.AutoSize = True
        lblProductsCaption.Font = New System.Drawing.Font("Century Gothic", 10F, Drawing.FontStyle.Bold)
        lblProductsCaption.ForeColor = Drawing.Color.Black
        lblProductsCaption.Location = New System.Drawing.Point(16, 14)
        lblProductsCaption.Name = "lblProductsCaption"
        lblProductsCaption.Size = New System.Drawing.Size(93, 23)
        lblProductsCaption.TabIndex = 0
        lblProductsCaption.Text = "Products"
        ' 
        ' lblProductsValue
        ' 
        lblProductsValue.AutoSize = True
        lblProductsValue.Font = New System.Drawing.Font("Yu Gothic", 16F, Drawing.FontStyle.Bold)
        lblProductsValue.Location = New System.Drawing.Point(14, 44)
        lblProductsValue.Name = "lblProductsValue"
        lblProductsValue.Size = New System.Drawing.Size(36, 42)
        lblProductsValue.TabIndex = 1
        lblProductsValue.Text = "0"
        ' 
        ' pnlCustomers
        ' 
        pnlCustomers.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(255))
        pnlCustomers.Controls.Add(lblCustomersCaption)
        pnlCustomers.Controls.Add(lblCustomersValue)
        pnlCustomers.Location = New System.Drawing.Point(609, 4)
        pnlCustomers.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        pnlCustomers.Name = "pnlCustomers"
        pnlCustomers.Size = New System.Drawing.Size(282, 104)
        pnlCustomers.TabIndex = 2
        ' 
        ' lblCustomersCaption
        ' 
        lblCustomersCaption.AutoSize = True
        lblCustomersCaption.Font = New System.Drawing.Font("Century Gothic", 10F, Drawing.FontStyle.Bold)
        lblCustomersCaption.ForeColor = Drawing.Color.Black
        lblCustomersCaption.Location = New System.Drawing.Point(16, 14)
        lblCustomersCaption.Name = "lblCustomersCaption"
        lblCustomersCaption.Size = New System.Drawing.Size(113, 23)
        lblCustomersCaption.TabIndex = 0
        lblCustomersCaption.Text = "Customers"
        ' 
        ' lblCustomersValue
        ' 
        lblCustomersValue.AutoSize = True
        lblCustomersValue.Font = New System.Drawing.Font("Yu Gothic", 20F, Drawing.FontStyle.Bold)
        lblCustomersValue.Location = New System.Drawing.Point(14, 44)
        lblCustomersValue.Name = "lblCustomersValue"
        lblCustomersValue.Size = New System.Drawing.Size(45, 52)
        lblCustomersValue.TabIndex = 1
        lblCustomersValue.Text = "0"
        ' 
        ' pnlLowStock
        ' 
        pnlLowStock.BackColor = Drawing.Color.Red
        pnlLowStock.Controls.Add(lblLowStockCaption)
        pnlLowStock.Controls.Add(lblLowStockValue)
        pnlLowStock.ForeColor = Drawing.SystemColors.ActiveCaptionText
        pnlLowStock.Location = New System.Drawing.Point(907, 4)
        pnlLowStock.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        pnlLowStock.Name = "pnlLowStock"
        pnlLowStock.Size = New System.Drawing.Size(254, 104)
        pnlLowStock.TabIndex = 3
        ' 
        ' lblLowStockCaption
        ' 
        lblLowStockCaption.AutoSize = True
        lblLowStockCaption.Font = New System.Drawing.Font("Century Gothic", 10F, Drawing.FontStyle.Bold)
        lblLowStockCaption.ForeColor = Drawing.Color.Black
        lblLowStockCaption.Location = New System.Drawing.Point(16, 14)
        lblLowStockCaption.Name = "lblLowStockCaption"
        lblLowStockCaption.Size = New System.Drawing.Size(108, 23)
        lblLowStockCaption.TabIndex = 0
        lblLowStockCaption.Text = "Low Stock"
        ' 
        ' lblLowStockValue
        ' 
        lblLowStockValue.AutoSize = True
        lblLowStockValue.Font = New System.Drawing.Font("Yu Gothic", 20F, Drawing.FontStyle.Bold)
        lblLowStockValue.Location = New System.Drawing.Point(14, 44)
        lblLowStockValue.Name = "lblLowStockValue"
        lblLowStockValue.Size = New System.Drawing.Size(45, 52)
        lblLowStockValue.TabIndex = 1
        lblLowStockValue.Text = "0"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblWelcome)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblDate)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1225, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New System.Drawing.Font("Segoe Print", 14F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New System.Drawing.Point(24, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New System.Drawing.Size(183, 50)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "WELCOME!"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe Print", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(192), CByte(64), CByte(0))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(413, 31)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "An overview of the happenings in your shop"
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        lblDate.AutoSize = True
        lblDate.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblDate.Location = New System.Drawing.Point(1025, 28)
        lblDate.Name = "lblDate"
        lblDate.Size = New System.Drawing.Size(53, 28)
        lblDate.TabIndex = 2
        lblDate.Text = "Date"
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucDashboard"
        Size = New System.Drawing.Size(1225, 755)
        pnlBody.ResumeLayout(False)
        pnlChart.ResumeLayout(False)
        pnlTopProducts.ResumeLayout(False)
        CType(dgvTopProducts, ComponentModel.ISupportInitialize).EndInit()
        flpCards.ResumeLayout(False)
        pnlTotalSales.ResumeLayout(False)
        pnlTotalSales.PerformLayout()
        pnlProducts.ResumeLayout(False)
        pnlProducts.PerformLayout()
        pnlCustomers.ResumeLayout(False)
        pnlCustomers.PerformLayout()
        pnlLowStock.ResumeLayout(False)
        pnlLowStock.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents pnlChart As System.Windows.Forms.Panel
    Friend WithEvents chtSalesOverview As ShopManagementSystem.BarChart
    Friend WithEvents pnlTopProducts As System.Windows.Forms.Panel
    Friend WithEvents dgvTopProducts As System.Windows.Forms.DataGridView
    Friend WithEvents lblTopTitle As System.Windows.Forms.Label
    Friend WithEvents flpCards As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlTotalSales As System.Windows.Forms.Panel
    Friend WithEvents lblTotalSalesCaption As System.Windows.Forms.Label
    Friend WithEvents lblTotalSalesValue As System.Windows.Forms.Label
    Friend WithEvents pnlProducts As System.Windows.Forms.Panel
    Friend WithEvents lblProductsCaption As System.Windows.Forms.Label
    Friend WithEvents lblProductsValue As System.Windows.Forms.Label
    Friend WithEvents pnlCustomers As System.Windows.Forms.Panel
    Friend WithEvents lblCustomersCaption As System.Windows.Forms.Label
    Friend WithEvents lblCustomersValue As System.Windows.Forms.Label
    Friend WithEvents pnlLowStock As System.Windows.Forms.Panel
    Friend WithEvents lblLowStockCaption As System.Windows.Forms.Label
    Friend WithEvents lblLowStockValue As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label

End Class
