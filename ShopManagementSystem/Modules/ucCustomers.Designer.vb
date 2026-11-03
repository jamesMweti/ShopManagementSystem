<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCustomers
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
        dgvCustomers = New System.Windows.Forms.DataGridView()
        pnlButtons = New System.Windows.Forms.Panel()
        btnEdit = New System.Windows.Forms.Button()
        btnDelete = New System.Windows.Forms.Button()
        btnRefresh = New System.Windows.Forms.Button()
        pnlHeader = New System.Windows.Forms.Panel()
        lblCustomersTitle = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        btnAddCustomer = New System.Windows.Forms.Button()
        pnlBody.SuspendLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        pnlButtons.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(dgvCustomers)
        pnlBody.Controls.Add(pnlButtons)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1000, 556)
        pnlBody.TabIndex = 0
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.ColumnHeadersHeight = 34
        dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        dgvCustomers.Location = New System.Drawing.Point(24, 4)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.RowHeadersWidth = 62
        dgvCustomers.Size = New System.Drawing.Size(952, 478)
        dgvCustomers.TabIndex = 0
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
        pnlHeader.Controls.Add(lblCustomersTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(btnAddCustomer)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1000, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblCustomersTitle
        ' 
        lblCustomersTitle.AutoSize = True
        lblCustomersTitle.Font = New System.Drawing.Font("Segoe Print", 14F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblCustomersTitle.Location = New System.Drawing.Point(15, 10)
        lblCustomersTitle.Name = "lblCustomersTitle"
        lblCustomersTitle.Size = New System.Drawing.Size(420, 50)
        lblCustomersTitle.TabIndex = 0
        lblCustomersTitle.Text = "CUSTOMER MANAGEMENT"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe Print", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(192), CByte(64), CByte(0))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(230, 31)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage your customers"
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        btnAddCustomer.BackColor = Drawing.Color.Purple
        btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        btnAddCustomer.FlatAppearance.BorderSize = 0
        btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAddCustomer.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnAddCustomer.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnAddCustomer.Location = New System.Drawing.Point(816, 22)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New System.Drawing.Size(160, 38)
        btnAddCustomer.TabIndex = 2
        btnAddCustomer.Text = "+  Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' ucCustomers
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucCustomers"
        Size = New System.Drawing.Size(1000, 640)
        pnlBody.ResumeLayout(False)
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblCustomersTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button

End Class
