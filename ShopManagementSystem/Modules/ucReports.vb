Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Printing

Public Class ucReports
    Implements IScreen

    ' Current report (used for the PDF export)
    Private _table As DataTable
    Private _reportName As String = ""
    Private _periodText As String = ""
    Private _summaryText As String = ""
    Private _rowIndex As Integer
    Private _firstPage As Boolean

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvReport)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        dtpFrom.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
        dtpTo.Value = Date.Today
        cmbReportType.SelectedIndex = 0
        Generate()
    End Sub

    Private Sub cmbReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportType.SelectedIndexChanged
        ' The inventory report is a snapshot of today's stock, so the date range does not apply to it.
        Dim useDates As Boolean = (cmbReportType.SelectedItem IsNot Nothing AndAlso cmbReportType.SelectedItem.ToString() <> "Inventory Report")
        dtpFrom.Enabled = useDates
        dtpTo.Enabled = useDates
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Ui.Run(AddressOf Generate)
    End Sub

    Private Sub Generate()
        If dtpTo.Value.Date < dtpFrom.Value.Date Then
            Ui.Warn("The 'To' date must not be earlier than the 'From' date.")
            Return
        End If
        ' The end date includes the whole day: we query up to (but excluding) the next midnight.
        Dim fromDate As Date = dtpFrom.Value.Date
        Dim toExclusive As Date = dtpTo.Value.Date.AddDays(1)
        Dim labels As New List(Of String)
        Dim values As New List(Of Decimal)
        Dim total As Decimal = 0
        _reportName = cmbReportType.SelectedItem.ToString()
        _periodText = "Period: " & dtpFrom.Value.ToString("dd/MM/yyyy") & " to " & dtpTo.Value.ToString("dd/MM/yyyy")

        Select Case _reportName
            Case "Sales Report"
                _table = Db.Query("SELECT s.SaleID AS `Sale #`, DATE_FORMAT(s.SaleDate,'%Y-%m-%d %H:%i') AS `Date`, IFNULL(c.FullName,'Walk-in Customer') AS Customer, " &
                                  "u.FullName AS Cashier, s.Subtotal, s.DiscountPercent AS `Discount %`, s.Total " &
                                  "FROM Sales s LEFT JOIN Customers c ON c.CustomerID = s.CustomerID JOIN Users u ON u.UserID = s.UserID " &
                                  "WHERE s.SaleDate >= @f AND s.SaleDate < @t ORDER BY s.SaleDate", Db.P("@f", fromDate), Db.P("@t", toExclusive))
                Dim byDay As New SortedDictionary(Of String, Decimal)
                For Each r As DataRow In _table.Rows
                    total += Convert.ToDecimal(r("Total"))
                    Dim day As String = Convert.ToString(r("Date")).Substring(0, 10)
                    If Not byDay.ContainsKey(day) Then byDay(day) = 0
                    byDay(day) += Convert.ToDecimal(r("Total"))
                Next
                For Each kv In byDay
                    labels.Add(kv.Key.Substring(5))
                    values.Add(kv.Value)
                Next
                chtReport.ChartTitle = "Sales Report"
                lblTotalCaption.Text = "Total Sales"

            Case "Inventory Report"
                _table = Db.Query("SELECT p.ProductName AS Product, IFNULL(c.CategoryName,'') AS Category, p.QuantityInStock AS Stock, p.ReorderLevel AS `Reorder Level`, " &
                                  "CASE WHEN p.QuantityInStock <= 0 THEN 'Out of Stock' WHEN p.QuantityInStock <= p.ReorderLevel THEN 'Low Stock' ELSE 'In Stock' END AS Status, " &
                                  "p.UnitPrice AS `Unit Price`, p.UnitPrice * p.QuantityInStock AS `Stock Value` " &
                                  "FROM Products p LEFT JOIN Categories c ON c.CategoryID = p.CategoryID ORDER BY p.ProductName")
                For Each r As DataRow In _table.Rows
                    total += Convert.ToDecimal(r("Stock Value"))
                Next
                For Each r As DataRow In _table.Rows.Cast(Of DataRow)().Take(12)
                    labels.Add(Convert.ToString(r("Product")))
                    values.Add(Convert.ToDecimal(r("Stock")))
                Next
                _periodText = "Stock position as of " & Date.Today.ToString("dd/MM/yyyy")
                chtReport.ChartTitle = "Stock levels (first 12 products)"
                lblTotalCaption.Text = "Total Stock Value"

            Case Else
                _table = Db.Query("SELECT c.FullName AS Customer, IFNULL(c.PhoneNumber,'') AS Phone, COUNT(s.SaleID) AS Purchases, IFNULL(SUM(s.Total),0) AS `Total Spent` " &
                                  "FROM Customers c LEFT JOIN Sales s ON s.CustomerID = c.CustomerID AND s.SaleDate >= @f AND s.SaleDate < @t " &
                                  "GROUP BY c.CustomerID, c.FullName, c.PhoneNumber ORDER BY `Total Spent` DESC, c.FullName", Db.P("@f", fromDate), Db.P("@t", toExclusive))
                For Each r As DataRow In _table.Rows
                    total += Convert.ToDecimal(r("Total Spent"))
                Next
                For Each r As DataRow In _table.Rows.Cast(Of DataRow)().Take(10)
                    labels.Add(Convert.ToString(r("Customer")))
                    values.Add(Convert.ToDecimal(r("Total Spent")))
                Next
                chtReport.ChartTitle = "Top customers by spending"
                lblTotalCaption.Text = "Total Spent by Customers"
        End Select

        dgvReport.DataSource = _table
        For Each c As DataGridViewColumn In dgvReport.Columns
            Dim t As Type = _table.Columns(c.Name).DataType
            If t = GetType(Decimal) Then
                c.DefaultCellStyle.Format = "N2"
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ElseIf t = GetType(Integer) OrElse t = GetType(Long) Then
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
        chtReport.SetData(labels, values)
        lblTotalSales.Text = Ui.Money(total)
        _summaryText = lblTotalCaption.Text & ": " & Ui.Money(total) & "     Rows: " & _table.Rows.Count
    End Sub

    ' Reprint the receipt of the sale selected in the Sales Report.
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        If _reportName <> "Sales Report" OrElse dgvReport.CurrentRow Is Nothing Then
            Ui.Info("Generate a Sales Report and select a sale to print its receipt.")
            Return
        End If
        Dim saleId As Long = Convert.ToInt64(dgvReport.CurrentRow.Cells(0).Value)
        Ui.Run(Sub()
                   Using f As New frmReceipt()
                       f.LoadSale(saleId)
                       f.ShowDialog(Me)
                   End Using
               End Sub)
    End Sub

    ' ---------------- PDF export (uses the built-in "Microsoft Print to PDF" printer) ----------------
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Ui.Run(AddressOf ExportPdf)
    End Sub

    Private Sub ExportPdf()
        If _table Is Nothing OrElse _table.Rows.Count = 0 Then
            Ui.Info("Generate a report that contains data first.")
            Return
        End If
        Using sfd As New SaveFileDialog()
            sfd.Filter = "PDF file (*.pdf)|*.pdf"
            sfd.FileName = _reportName.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmm") & ".pdf"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Dim doc As New PrintDocument()
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
            If Not doc.PrinterSettings.IsValid Then
                Ui.Warn("The 'Microsoft Print to PDF' printer was not found on this computer, so the PDF could not be created." & vbCrLf &
                        "Turn it on in Windows Optional Features, or install any PDF printer.")
                Return
            End If
            doc.PrinterSettings.PrintToFile = True
            doc.PrinterSettings.PrintFileName = sfd.FileName
            doc.DocumentName = _reportName
            _rowIndex = 0
            _firstPage = True
            AddHandler doc.PrintPage, AddressOf OnPrintPage
            doc.Print()
            Ui.Info("Report saved to:" & vbCrLf & sfd.FileName)
        End Using
    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g = e.Graphics
        Dim m = e.MarginBounds
        Dim y As Single = m.Top
        Using fTitle As New Font("Segoe UI", 16, FontStyle.Bold),
              fSub As New Font("Segoe UI", 10),
              fHead As New Font("Segoe UI", 9, FontStyle.Bold),
              fBody As New Font("Segoe UI", 9)

            If _firstPage Then
                g.DrawString(Db.GetSetting("ShopName", "Shop Management System"), fTitle, Brushes.Black, m.Left, y)
                y += 34
                g.DrawString(_reportName & "  -  " & _periodText, fSub, Brushes.Black, m.Left, y)
                y += 22
                g.DrawString(_summaryText, fSub, Brushes.Black, m.Left, y)
                y += 34
                _firstPage = False
            End If

            Dim colCount As Integer = _table.Columns.Count
            Dim colW As Single = m.Width / colCount
            Dim rowH As Single = 22

            ' header row
            Using headBrush As New SolidBrush(Theme.Purple)
                g.FillRectangle(headBrush, m.Left, y, m.Width, rowH)
            End Using
            For c As Integer = 0 To colCount - 1
                g.DrawString(_table.Columns(c).ColumnName, fHead, Brushes.White, New RectangleF(m.Left + c * colW + 3, y + 3, colW - 6, rowH), CellFormat(False))
            Next
            y += rowH

            ' body rows
            While _rowIndex < _table.Rows.Count
                If y + rowH > m.Bottom Then Exit While
                If _rowIndex Mod 2 = 1 Then g.FillRectangle(Brushes.WhiteSmoke, m.Left, y, m.Width, rowH)
                For c As Integer = 0 To colCount - 1
                    Dim v As Object = _table.Rows(_rowIndex)(c)
                    Dim txt As String
                    If TypeOf v Is Decimal Then
                        txt = DirectCast(v, Decimal).ToString("N2")
                    Else
                        txt = Convert.ToString(v)
                    End If
                    Dim numeric As Boolean = (TypeOf v Is Decimal OrElse TypeOf v Is Integer OrElse TypeOf v Is Long)
                    g.DrawString(txt, fBody, Brushes.Black, New RectangleF(m.Left + c * colW + 3, y + 3, colW - 6, rowH), CellFormat(numeric))
                Next
                y += rowH
                _rowIndex += 1
            End While
        End Using
        e.HasMorePages = (_rowIndex < _table.Rows.Count)
    End Sub

    Private Shared Function CellFormat(rightAlign As Boolean) As StringFormat
        Dim sf As New StringFormat()
        sf.Trimming = StringTrimming.EllipsisCharacter
        sf.FormatFlags = StringFormatFlags.NoWrap
        sf.Alignment = If(rightAlign, StringAlignment.Far, StringAlignment.Near)
        Return sf
    End Function
End Class
