<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucReports
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
        dgvReport = New System.Windows.Forms.DataGridView()
        pnlExport = New System.Windows.Forms.Panel()
        btnExportPDF = New System.Windows.Forms.Button()
        btnPrintReceipt = New System.Windows.Forms.Button()
        pnlChart = New System.Windows.Forms.Panel()
        chtReport = New BarChart()
        pnlTotal = New System.Windows.Forms.Panel()
        lblTotalSales = New System.Windows.Forms.Label()
        lblTotalCaption = New System.Windows.Forms.Label()
        pnlFilters = New System.Windows.Forms.Panel()
        lblSelectReport = New System.Windows.Forms.Label()
        cmbReportType = New System.Windows.Forms.ComboBox()
        lblFrom = New System.Windows.Forms.Label()
        dtpFrom = New System.Windows.Forms.DateTimePicker()
        lblTo = New System.Windows.Forms.Label()
        dtpTo = New System.Windows.Forms.DateTimePicker()
        btnGenerate = New System.Windows.Forms.Button()
        pnlHeader = New System.Windows.Forms.Panel()
        lblReportsTitle = New System.Windows.Forms.Label()
        lblSubtitle = New System.Windows.Forms.Label()
        pnlBody.SuspendLayout()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        pnlExport.SuspendLayout()
        pnlChart.SuspendLayout()
        pnlTotal.SuspendLayout()
        pnlFilters.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlBody.Controls.Add(dgvReport)
        pnlBody.Controls.Add(pnlExport)
        pnlBody.Controls.Add(pnlChart)
        pnlBody.Controls.Add(pnlFilters)
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.Location = New System.Drawing.Point(0, 84)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New System.Windows.Forms.Padding(24, 4, 24, 16)
        pnlBody.Size = New System.Drawing.Size(1000, 556)
        pnlBody.TabIndex = 0
        ' 
        ' dgvReport
        ' 
        dgvReport.ColumnHeadersHeight = 34
        dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        dgvReport.Location = New System.Drawing.Point(24, 306)
        dgvReport.Name = "dgvReport"
        dgvReport.RowHeadersWidth = 62
        dgvReport.Size = New System.Drawing.Size(952, 176)
        dgvReport.TabIndex = 0
        ' 
        ' pnlExport
        ' 
        pnlExport.Controls.Add(btnExportPDF)
        pnlExport.Controls.Add(btnPrintReceipt)
        pnlExport.Dock = System.Windows.Forms.DockStyle.Bottom
        pnlExport.Location = New System.Drawing.Point(24, 482)
        pnlExport.Name = "pnlExport"
        pnlExport.Size = New System.Drawing.Size(952, 58)
        pnlExport.TabIndex = 1
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.BackColor = Drawing.Color.Purple
        btnExportPDF.Cursor = System.Windows.Forms.Cursors.Hand
        btnExportPDF.FlatAppearance.BorderSize = 0
        btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnExportPDF.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnExportPDF.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnExportPDF.Location = New System.Drawing.Point(0, 12)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New System.Drawing.Size(161, 38)
        btnExportPDF.TabIndex = 0
        btnExportPDF.Text = "Export to PDF"
        btnExportPDF.UseVisualStyleBackColor = False
        ' 
        ' btnPrintReceipt
        ' 
        btnPrintReceipt.BackColor = Drawing.Color.FromArgb(CByte(30), CByte(100), CByte(220))
        btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        btnPrintReceipt.FlatAppearance.BorderSize = 0
        btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnPrintReceipt.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnPrintReceipt.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnPrintReceipt.Location = New System.Drawing.Point(195, 12)
        btnPrintReceipt.Name = "btnPrintReceipt"
        btnPrintReceipt.Size = New System.Drawing.Size(170, 38)
        btnPrintReceipt.TabIndex = 1
        btnPrintReceipt.Text = ChrW(55358) & ChrW(56830) & "  Print Receipt"
        btnPrintReceipt.UseVisualStyleBackColor = False
        ' 
        ' pnlChart
        ' 
        pnlChart.Controls.Add(chtReport)
        pnlChart.Controls.Add(pnlTotal)
        pnlChart.Dock = System.Windows.Forms.DockStyle.Top
        pnlChart.Location = New System.Drawing.Point(24, 56)
        pnlChart.Name = "pnlChart"
        pnlChart.Size = New System.Drawing.Size(952, 250)
        pnlChart.TabIndex = 2
        ' 
        ' chtReport
        ' 
        chtReport.BackColor = Drawing.Color.White
        chtReport.ChartTitle = ""
        chtReport.Dock = System.Windows.Forms.DockStyle.Fill
        chtReport.Font = New System.Drawing.Font("Segoe UI", 8.5F)
        chtReport.Location = New System.Drawing.Point(0, 0)
        chtReport.Name = "chtReport"
        chtReport.Size = New System.Drawing.Size(652, 250)
        chtReport.TabIndex = 0
        ' 
        ' pnlTotal
        ' 
        pnlTotal.BackColor = Drawing.Color.FromArgb(CByte(226), CByte(240), CByte(217))
        pnlTotal.Controls.Add(lblTotalSales)
        pnlTotal.Controls.Add(lblTotalCaption)
        pnlTotal.Dock = System.Windows.Forms.DockStyle.Right
        pnlTotal.Location = New System.Drawing.Point(652, 0)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Size = New System.Drawing.Size(300, 250)
        pnlTotal.TabIndex = 1
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.BackColor = Drawing.SystemColors.Highlight
        lblTotalSales.Dock = System.Windows.Forms.DockStyle.Fill
        lblTotalSales.Font = New System.Drawing.Font("Segoe UI", 20F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTotalSales.ForeColor = Drawing.Color.Purple
        lblTotalSales.Location = New System.Drawing.Point(0, 41)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New System.Drawing.Size(300, 209)
        lblTotalSales.TabIndex = 0
        lblTotalSales.Text = "KSh 0.00"
        lblTotalSales.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblTotalCaption
        ' 
        lblTotalCaption.BackColor = Drawing.SystemColors.Highlight
        lblTotalCaption.Dock = System.Windows.Forms.DockStyle.Top
        lblTotalCaption.Font = New System.Drawing.Font("Segoe UI", 13F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblTotalCaption.Location = New System.Drawing.Point(0, 0)
        lblTotalCaption.Name = "lblTotalCaption"
        lblTotalCaption.Size = New System.Drawing.Size(300, 41)
        lblTotalCaption.TabIndex = 1
        lblTotalCaption.Text = "Total Sales"
        lblTotalCaption.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' pnlFilters
        ' 
        pnlFilters.Controls.Add(lblSelectReport)
        pnlFilters.Controls.Add(cmbReportType)
        pnlFilters.Controls.Add(lblFrom)
        pnlFilters.Controls.Add(dtpFrom)
        pnlFilters.Controls.Add(lblTo)
        pnlFilters.Controls.Add(dtpTo)
        pnlFilters.Controls.Add(btnGenerate)
        pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
        pnlFilters.Location = New System.Drawing.Point(24, 4)
        pnlFilters.Name = "pnlFilters"
        pnlFilters.Size = New System.Drawing.Size(952, 52)
        pnlFilters.TabIndex = 3
        ' 
        ' lblSelectReport
        ' 
        lblSelectReport.AutoSize = True
        lblSelectReport.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblSelectReport.Location = New System.Drawing.Point(16, 9)
        lblSelectReport.Name = "lblSelectReport"
        lblSelectReport.Size = New System.Drawing.Size(145, 28)
        lblSelectReport.TabIndex = 0
        lblSelectReport.Text = "Select Report:"
        ' 
        ' cmbReportType
        ' 
        cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbReportType.FormattingEnabled = True
        cmbReportType.Items.AddRange(New Object() {"Sales Report", "Inventory Report", "Customer Report"})
        cmbReportType.Location = New System.Drawing.Point(177, 8)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New System.Drawing.Size(170, 36)
        cmbReportType.TabIndex = 1
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblFrom.Location = New System.Drawing.Point(388, 12)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New System.Drawing.Size(65, 28)
        lblFrom.TabIndex = 2
        lblFrom.Text = "From:"
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpFrom.Location = New System.Drawing.Point(459, 8)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New System.Drawing.Size(120, 34)
        dtpFrom.TabIndex = 3
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTo.Location = New System.Drawing.Point(598, 11)
        lblTo.Name = "lblTo"
        lblTo.Size = New System.Drawing.Size(39, 28)
        lblTo.TabIndex = 4
        lblTo.Text = "To:"
        ' 
        ' dtpTo
        ' 
        dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpTo.Location = New System.Drawing.Point(652, 7)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New System.Drawing.Size(120, 34)
        dtpTo.TabIndex = 5
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Drawing.Color.Purple
        btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnGenerate.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnGenerate.Location = New System.Drawing.Point(839, 9)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New System.Drawing.Size(110, 38)
        btnGenerate.TabIndex = 6
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        pnlHeader.Controls.Add(lblReportsTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(1000, 84)
        pnlHeader.TabIndex = 1
        ' 
        ' lblReportsTitle
        ' 
        lblReportsTitle.AutoSize = True
        lblReportsTitle.Font = New System.Drawing.Font("Segoe UI", 17F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblReportsTitle.Location = New System.Drawing.Point(24, 10)
        lblReportsTitle.Name = "lblReportsTitle"
        lblReportsTitle.Size = New System.Drawing.Size(144, 46)
        lblReportsTitle.TabIndex = 0
        lblReportsTitle.Text = "Reports"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(110), CByte(50))
        lblSubtitle.Location = New System.Drawing.Point(27, 50)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New System.Drawing.Size(199, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "View business reports"
        ' 
        ' ucReports
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(144F, 144F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        Name = "ucReports"
        Size = New System.Drawing.Size(1000, 640)
        pnlBody.ResumeLayout(False)
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        pnlExport.ResumeLayout(False)
        pnlChart.ResumeLayout(False)
        pnlTotal.ResumeLayout(False)
        pnlFilters.ResumeLayout(False)
        pnlFilters.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents pnlExport As System.Windows.Forms.Panel
    Friend WithEvents btnExportPDF As System.Windows.Forms.Button
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents pnlChart As System.Windows.Forms.Panel
    Friend WithEvents chtReport As ShopManagementSystem.BarChart
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents lblTotalCaption As System.Windows.Forms.Label
    Friend WithEvents pnlFilters As System.Windows.Forms.Panel
    Friend WithEvents lblSelectReport As System.Windows.Forms.Label
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblReportsTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label

End Class
