<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSales
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
        dgvSaleItems = New System.Windows.Forms.DataGridView()
        colProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        pnlItemButtons = New System.Windows.Forms.Panel()
        btnAddItem = New System.Windows.Forms.Button()
        btnRemoveItem = New System.Windows.Forms.Button()
        pnlSummary = New System.Windows.Forms.Panel()
        pnlTotals = New System.Windows.Forms.Panel()
        lblSubtotalCaption = New System.Windows.Forms.Label()
        lblSubtotal = New System.Windows.Forms.Label()
        lblDiscountCaption = New System.Windows.Forms.Label()
        nudDiscount = New System.Windows.Forms.NumericUpDown()
        lblTotalCaption = New System.Windows.Forms.Label()
        btnCompleteSale = New System.Windows.Forms.Button()
        pnlCustomer = New System.Windows.Forms.Panel()
        lblCustomer = New System.Windows.Forms.Label()
        cmbCustomer = New System.Windows.Forms.ComboBox()
        pnlHeader = New System.Windows.Forms.Panel()
        lblNewSale = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        lblDate = New System.Windows.Forms.Label()
        dtpSaleDate = New System.Windows.Forms.DateTimePicker()
        lblTotal = New System.Windows.Forms.Label()
        pnlBody.SuspendLayout()
        CType(dgvSaleItems, ComponentModel.ISupportInitialize).BeginInit()
        pnlItemButtons.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlTotals.SuspendLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).BeginInit()
        pnlCustomer.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(dgvSaleItems)
        pnlBody.Controls.Add(pnlItemButtons)
        pnlBody.Controls.Add(pnlSummary)
        pnlBody.Controls.Add(pnlCustomer)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1000, 556)
        pnlBody.TabIndex = 0
        ' 
        ' dgvSaleItems
        ' 
        dgvSaleItems.ColumnHeadersHeight = 34
        dgvSaleItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {colProductID, colStock, colProduct, colPrice, colQty, colTotal})
        dgvSaleItems.Dock = System.Windows.Forms.DockStyle.Fill
        dgvSaleItems.Location = New System.Drawing.Point(24, 54)
        dgvSaleItems.Name = "dgvSaleItems"
        dgvSaleItems.RowHeadersWidth = 62
        dgvSaleItems.Size = New System.Drawing.Size(526, 428)
        dgvSaleItems.TabIndex = 0
        ' 
        ' colProductID
        ' 
        colProductID.FillWeight = 20F
        colProductID.HeaderText = "ID"
        colProductID.MinimumWidth = 8
        colProductID.Name = "colProductID"
        colProductID.Visible = False
        colProductID.Width = 150
        ' 
        ' colStock
        ' 
        colStock.FillWeight = 20F
        colStock.HeaderText = "Stock"
        colStock.MinimumWidth = 8
        colStock.Name = "colStock"
        colStock.Visible = False
        colStock.Width = 150
        ' 
        ' colProduct
        ' 
        colProduct.FillWeight = 120F
        colProduct.HeaderText = "Product"
        colProduct.MinimumWidth = 8
        colProduct.Name = "colProduct"
        colProduct.ReadOnly = True
        colProduct.Width = 150
        ' 
        ' colPrice
        ' 
        colPrice.FillWeight = 60F
        colPrice.HeaderText = "Price (KSh)"
        colPrice.MinimumWidth = 8
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        colPrice.Width = 150
        ' 
        ' colQty
        ' 
        colQty.FillWeight = 50F
        colQty.HeaderText = "Qty (click to edit)"
        colQty.MinimumWidth = 8
        colQty.Name = "colQty"
        colQty.Width = 150
        ' 
        ' colTotal
        ' 
        colTotal.FillWeight = 60F
        colTotal.HeaderText = "Total"
        colTotal.MinimumWidth = 8
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        colTotal.Width = 150
        ' 
        ' pnlItemButtons
        ' 
        pnlItemButtons.Controls.Add(btnAddItem)
        pnlItemButtons.Controls.Add(btnRemoveItem)
        pnlItemButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        pnlItemButtons.Location = New System.Drawing.Point(24, 482)
        pnlItemButtons.Name = "pnlItemButtons"
        pnlItemButtons.Size = New System.Drawing.Size(526, 58)
        pnlItemButtons.TabIndex = 1
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Drawing.Color.Purple
        btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAddItem.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnAddItem.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnAddItem.Location = New System.Drawing.Point(0, 12)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New System.Drawing.Size(149, 38)
        btnAddItem.TabIndex = 0
        btnAddItem.Text = "+  Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.BackColor = Drawing.Color.FromArgb(CByte(214), CByte(40), CByte(40))
        btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        btnRemoveItem.FlatAppearance.BorderSize = 0
        btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnRemoveItem.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnRemoveItem.Location = New System.Drawing.Point(189, 12)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New System.Drawing.Size(160, 38)
        btnRemoveItem.TabIndex = 1
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = False
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Controls.Add(pnlTotals)
        pnlSummary.Dock = System.Windows.Forms.DockStyle.Right
        pnlSummary.Location = New System.Drawing.Point(550, 54)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        pnlSummary.Size = New System.Drawing.Size(426, 486)
        pnlSummary.TabIndex = 2
        ' 
        ' pnlTotals
        ' 
        pnlTotals.BackColor = Drawing.Color.FromArgb(CByte(226), CByte(240), CByte(217))
        pnlTotals.Controls.Add(lblTotal)
        pnlTotals.Controls.Add(lblSubtotalCaption)
        pnlTotals.Controls.Add(lblSubtotal)
        pnlTotals.Controls.Add(lblDiscountCaption)
        pnlTotals.Controls.Add(nudDiscount)
        pnlTotals.Controls.Add(lblTotalCaption)
        pnlTotals.Controls.Add(btnCompleteSale)
        pnlTotals.Dock = System.Windows.Forms.DockStyle.Top
        pnlTotals.Location = New System.Drawing.Point(16, 0)
        pnlTotals.Name = "pnlTotals"
        pnlTotals.Size = New System.Drawing.Size(410, 326)
        pnlTotals.TabIndex = 0
        ' 
        ' lblSubtotalCaption
        ' 
        lblSubtotalCaption.AutoSize = True
        lblSubtotalCaption.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtotalCaption.Location = New System.Drawing.Point(16, 52)
        lblSubtotalCaption.Name = "lblSubtotalCaption"
        lblSubtotalCaption.Size = New System.Drawing.Size(117, 32)
        lblSubtotalCaption.TabIndex = 0
        lblSubtotalCaption.Text = "Subtotal:"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtotal.Location = New System.Drawing.Point(120, 54)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New System.Drawing.Size(170, 30)
        lblSubtotal.TabIndex = 1
        lblSubtotal.Text = "KSh 0.00"
        lblSubtotal.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' lblDiscountCaption
        ' 
        lblDiscountCaption.AutoSize = True
        lblDiscountCaption.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblDiscountCaption.Location = New System.Drawing.Point(16, 111)
        lblDiscountCaption.Name = "lblDiscountCaption"
        lblDiscountCaption.Size = New System.Drawing.Size(169, 32)
        lblDiscountCaption.TabIndex = 2
        lblDiscountCaption.Text = "Discount (%):"
        ' 
        ' nudDiscount
        ' 
        nudDiscount.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        nudDiscount.Location = New System.Drawing.Point(190, 107)
        nudDiscount.Name = "nudDiscount"
        nudDiscount.Size = New System.Drawing.Size(100, 39)
        nudDiscount.TabIndex = 3
        ' 
        ' lblTotalCaption
        ' 
        lblTotalCaption.AutoSize = True
        lblTotalCaption.Font = New System.Drawing.Font("Segoe UI", 16F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTotalCaption.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(110), CByte(50))
        lblTotalCaption.Location = New System.Drawing.Point(16, 175)
        lblTotalCaption.Name = "lblTotalCaption"
        lblTotalCaption.Size = New System.Drawing.Size(103, 45)
        lblTotalCaption.TabIndex = 4
        lblTotalCaption.Text = "Total:"
        ' 
        ' btnCompleteSale
        ' 
        btnCompleteSale.BackColor = Drawing.Color.Purple
        btnCompleteSale.Cursor = System.Windows.Forms.Cursors.Hand
        btnCompleteSale.FlatAppearance.BorderSize = 0
        btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCompleteSale.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnCompleteSale.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnCompleteSale.Location = New System.Drawing.Point(16, 252)
        btnCompleteSale.Name = "btnCompleteSale"
        btnCompleteSale.Size = New System.Drawing.Size(288, 52)
        btnCompleteSale.TabIndex = 6
        btnCompleteSale.Text = "Complete Sale"
        btnCompleteSale.UseVisualStyleBackColor = False
        ' 
        ' pnlCustomer
        ' 
        pnlCustomer.Controls.Add(lblCustomer)
        pnlCustomer.Controls.Add(cmbCustomer)
        pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top
        pnlCustomer.Location = New System.Drawing.Point(24, 4)
        pnlCustomer.Name = "pnlCustomer"
        pnlCustomer.Size = New System.Drawing.Size(952, 50)
        pnlCustomer.TabIndex = 3
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblCustomer.Location = New System.Drawing.Point(0, 14)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New System.Drawing.Size(108, 28)
        lblCustomer.TabIndex = 0
        lblCustomer.Text = "Customer:"
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New System.Drawing.Point(114, 8)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New System.Drawing.Size(280, 36)
        cmbCustomer.TabIndex = 1
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblNewSale)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblDate)
        pnlHeader.Controls.Add(dtpSaleDate)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1000, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblNewSale
        ' 
        lblNewSale.AutoSize = True
        lblNewSale.Font = New System.Drawing.Font("Segoe UI", 17F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblNewSale.Location = New System.Drawing.Point(24, 10)
        lblNewSale.Name = "lblNewSale"
        lblNewSale.Size = New System.Drawing.Size(166, 46)
        lblNewSale.TabIndex = 0
        lblNewSale.Text = "New Sale"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(110), CByte(50))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(261, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Process a customer purchase"
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        lblDate.AutoSize = True
        lblDate.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblDate.Location = New System.Drawing.Point(780, 30)
        lblDate.Name = "lblDate"
        lblDate.Size = New System.Drawing.Size(57, 28)
        lblDate.TabIndex = 2
        lblDate.Text = "Date:"
        ' 
        ' dtpSaleDate
        ' 
        dtpSaleDate.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpSaleDate.Location = New System.Drawing.Point(836, 26)
        dtpSaleDate.Name = "dtpSaleDate"
        dtpSaleDate.Size = New System.Drawing.Size(140, 34)
        dtpSaleDate.TabIndex = 3
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New System.Drawing.Font("Segoe UI", 14F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Drawing.Color.Green
        lblTotal.Location = New System.Drawing.Point(125, 180)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New System.Drawing.Size(128, 38)
        lblTotal.TabIndex = 7
        lblTotal.Text = "Ksh 0.00"
        ' 
        ' ucSales
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucSales"
        Size = New System.Drawing.Size(1000, 640)
        pnlBody.ResumeLayout(False)
        CType(dgvSaleItems, ComponentModel.ISupportInitialize).EndInit()
        pnlItemButtons.ResumeLayout(False)
        pnlSummary.ResumeLayout(False)
        pnlTotals.ResumeLayout(False)
        pnlTotals.PerformLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).EndInit()
        pnlCustomer.ResumeLayout(False)
        pnlCustomer.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgvSaleItems As System.Windows.Forms.DataGridView
    Friend WithEvents colProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlItemButtons As System.Windows.Forms.Panel
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents pnlSummary As System.Windows.Forms.Panel
    Friend WithEvents pnlTotals As System.Windows.Forms.Panel
    Friend WithEvents lblSubtotalCaption As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscountCaption As System.Windows.Forms.Label
    Friend WithEvents nudDiscount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTotalCaption As System.Windows.Forms.Label
    Friend WithEvents btnCompleteSale As System.Windows.Forms.Button
    Friend WithEvents pnlCustomer As System.Windows.Forms.Panel
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblNewSale As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
