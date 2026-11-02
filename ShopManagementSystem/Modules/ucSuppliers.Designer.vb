<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSuppliers
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
        dgvSuppliers = New System.Windows.Forms.DataGridView()
        pnlButtons = New System.Windows.Forms.Panel()
        btnEdit = New System.Windows.Forms.Button()
        btnDelete = New System.Windows.Forms.Button()
        btnRefresh = New System.Windows.Forms.Button()
        pnlHeader = New System.Windows.Forms.Panel()
        lblSuppliersTitle = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        btnAddSupplier = New System.Windows.Forms.Button()
        pnlBody.SuspendLayout()
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).BeginInit()
        pnlButtons.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(dgvSuppliers)
        pnlBody.Controls.Add(pnlButtons)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1000, 556)
        pnlBody.TabIndex = 0
        ' 
        ' dgvSuppliers
        ' 
        dgvSuppliers.ColumnHeadersHeight = 34
        dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        dgvSuppliers.Location = New System.Drawing.Point(24, 4)
        dgvSuppliers.Name = "dgvSuppliers"
        dgvSuppliers.RowHeadersWidth = 62
        dgvSuppliers.Size = New System.Drawing.Size(952, 478)
        dgvSuppliers.TabIndex = 0
        ' 
        ' pnlButtons
        ' 
        pnlButtons.Controls.Add(btnEdit)
        pnlButtons.Controls.Add(btnDelete)
        pnlButtons.Controls.Add(btnRefresh)
        pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        pnlButtons.Location = New System.Drawing.Point(24, 482)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New System.Drawing.Size(952, 58)
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
        pnlHeader.Controls.Add(lblSuppliersTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(btnAddSupplier)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1000, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblSuppliersTitle
        ' 
        lblSuppliersTitle.AutoSize = True
        lblSuppliersTitle.Font = New System.Drawing.Font("Segoe UI", 17F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSuppliersTitle.Location = New System.Drawing.Point(24, 10)
        lblSuppliersTitle.Name = "lblSuppliersTitle"
        lblSuppliersTitle.Size = New System.Drawing.Size(169, 46)
        lblSuppliersTitle.TabIndex = 0
        lblSuppliersTitle.Text = "Suppliers"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(110), CByte(50))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(299, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage who you buy stock from"
        ' 
        ' btnAddSupplier
        ' 
        btnAddSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        btnAddSupplier.BackColor = Drawing.Color.Purple
        btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        btnAddSupplier.FlatAppearance.BorderSize = 0
        btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAddSupplier.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnAddSupplier.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnAddSupplier.Location = New System.Drawing.Point(816, 22)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New System.Drawing.Size(160, 38)
        btnAddSupplier.TabIndex = 2
        btnAddSupplier.Text = "+  Add Supplier"
        btnAddSupplier.UseVisualStyleBackColor = False
        ' 
        ' ucSuppliers
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucSuppliers"
        Size = New System.Drawing.Size(1000, 640)
        pnlBody.ResumeLayout(False)
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgvSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSuppliersTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnAddSupplier As System.Windows.Forms.Button

End Class
