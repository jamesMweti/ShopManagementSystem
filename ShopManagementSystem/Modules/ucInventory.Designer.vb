<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucInventory
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
        dgvInventory = New System.Windows.Forms.DataGridView()
        pnlButtons = New System.Windows.Forms.Panel()
        btnRefresh = New System.Windows.Forms.Button()
        btnUpdateStock = New System.Windows.Forms.Button()
        pnlHeader = New System.Windows.Forms.Panel()
        lblInventoryTitle = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        pnlBody.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        pnlButtons.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(dgvInventory)
        pnlBody.Controls.Add(pnlButtons)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1000, 556)
        pnlBody.TabIndex = 0
        ' 
        ' dgvInventory
        ' 
        dgvInventory.ColumnHeadersHeight = 34
        dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        dgvInventory.Location = New System.Drawing.Point(24, 4)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersWidth = 62
        dgvInventory.Size = New System.Drawing.Size(952, 478)
        dgvInventory.TabIndex = 0
        ' 
        ' pnlButtons
        ' 
        pnlButtons.Controls.Add(btnRefresh)
        pnlButtons.Controls.Add(btnUpdateStock)
        pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        pnlButtons.Location = New System.Drawing.Point(24, 482)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New System.Drawing.Size(952, 58)
        pnlButtons.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Drawing.Color.FromArgb(CByte(30), CByte(100), CByte(220))
        btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnRefresh.Location = New System.Drawing.Point(0, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New System.Drawing.Size(115, 38)
        btnRefresh.TabIndex = 0
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateStock
        ' 
        btnUpdateStock.BackColor = Drawing.Color.Purple
        btnUpdateStock.Cursor = System.Windows.Forms.Cursors.Hand
        btnUpdateStock.FlatAppearance.BorderSize = 0
        btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnUpdateStock.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnUpdateStock.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnUpdateStock.Location = New System.Drawing.Point(125, 12)
        btnUpdateStock.Name = "btnUpdateStock"
        btnUpdateStock.Size = New System.Drawing.Size(160, 38)
        btnUpdateStock.TabIndex = 1
        btnUpdateStock.Text = "±  Adjust Stock"
        btnUpdateStock.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlHeader.Controls.Add(lblInventoryTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1000, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblInventoryTitle
        ' 
        lblInventoryTitle.AutoSize = True
        lblInventoryTitle.Font = New System.Drawing.Font("Segoe Print", 14F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblInventoryTitle.Location = New System.Drawing.Point(24, 10)
        lblInventoryTitle.Name = "lblInventoryTitle"
        lblInventoryTitle.Size = New System.Drawing.Size(307, 50)
        lblInventoryTitle.TabIndex = 0
        lblInventoryTitle.Text = "STOCK INVENTORY"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe Print", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(192), CByte(64), CByte(0))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(312, 31)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Monitor and manage stock levels"
        ' 
        ' ucInventory
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucInventory"
        Size = New System.Drawing.Size(1000, 640)
        pnlBody.ResumeLayout(False)
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnUpdateStock As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblInventoryTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label

End Class
