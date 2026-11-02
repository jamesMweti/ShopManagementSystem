<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucProducts
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
        dgvProducts = New System.Windows.Forms.DataGridView()
        pnlButtons = New System.Windows.Forms.Panel()
        btnEdit = New System.Windows.Forms.Button()
        btnDelete = New System.Windows.Forms.Button()
        btnRefresh = New System.Windows.Forms.Button()
        pnlHeader = New System.Windows.Forms.Panel()
        lblProductsTitle = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        btnAddProduct = New System.Windows.Forms.Button()
        pnlBody.SuspendLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        pnlButtons.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(dgvProducts)
        pnlBody.Controls.Add(pnlButtons)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1126, 556)
        pnlBody.TabIndex = 0
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeight = 34
        dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        dgvProducts.Location = New System.Drawing.Point(24, 4)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.Size = New System.Drawing.Size(1078, 478)
        dgvProducts.TabIndex = 0
        ' 
        ' pnlButtons
        ' 
        pnlButtons.Controls.Add(btnEdit)
        pnlButtons.Controls.Add(btnDelete)
        pnlButtons.Controls.Add(btnRefresh)
        pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        pnlButtons.Location = New System.Drawing.Point(24, 482)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New System.Drawing.Size(1078, 58)
        pnlButtons.TabIndex = 1
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Drawing.Color.Purple
        btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnEdit.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnEdit.Location = New System.Drawing.Point(0, 12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New System.Drawing.Size(100, 38)
        btnEdit.TabIndex = 0
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Drawing.Color.FromArgb(CByte(214), CByte(40), CByte(40))
        btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnDelete.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnDelete.Location = New System.Drawing.Point(110, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New System.Drawing.Size(110, 38)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Drawing.Color.FromArgb(CByte(30), CByte(100), CByte(220))
        btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnRefresh.Location = New System.Drawing.Point(230, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New System.Drawing.Size(115, 38)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlHeader.Controls.Add(lblProductsTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(btnAddProduct)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1126, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblProductsTitle
        ' 
        lblProductsTitle.AutoSize = True
        lblProductsTitle.Font = New System.Drawing.Font("Segoe UI", 17F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblProductsTitle.Location = New System.Drawing.Point(24, 10)
        lblProductsTitle.Name = "lblProductsTitle"
        lblProductsTitle.Size = New System.Drawing.Size(383, 46)
        lblProductsTitle.TabIndex = 0
        lblProductsTitle.Text = "Products Management"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(110), CByte(50))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(298, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Add, update or remove products"
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        btnAddProduct.BackColor = Drawing.Color.Purple
        btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        btnAddProduct.FlatAppearance.BorderSize = 0
        btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAddProduct.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnAddProduct.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnAddProduct.Location = New System.Drawing.Point(942, 29)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New System.Drawing.Size(160, 38)
        btnAddProduct.TabIndex = 2
        btnAddProduct.Text = "+  Add Product"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' ucProducts
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucProducts"
        Size = New System.Drawing.Size(1126, 640)
        pnlBody.ResumeLayout(False)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblProductsTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button

End Class
