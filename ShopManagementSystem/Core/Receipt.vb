Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing

''' <summary>Builds a 80 mm style sales receipt for a saved sale (used for preview, printing and PDF).</summary>
Public Module Receipt

    Public Function BuildDocument(saleId As Long) As PrintDocument
        Dim head = Db.Query("SELECT s.SaleID, s.SaleDate, s.Subtotal, s.DiscountPercent, s.Total, IFNULL(c.FullName,'Walk-in Customer') AS Customer, u.FullName AS Cashier " &
                            "FROM Sales s LEFT JOIN Customers c ON c.CustomerID = s.CustomerID JOIN Users u ON u.UserID = s.UserID WHERE s.SaleID=@id", Db.P("@id", saleId))
        If head.Rows.Count = 0 Then Throw New InvalidOperationException("Sale #" & saleId & " was not found.")
        Dim items = Db.Query("SELECT p.ProductName, si.Quantity, si.UnitPrice, si.LineTotal FROM SaleItems si JOIN Products p ON p.ProductID = si.ProductID WHERE si.SaleID=@id ORDER BY si.SaleItemID", Db.P("@id", saleId))
        Dim shop As String = Db.GetSetting("ShopName", "Shop Management System")

        Dim doc As New PrintDocument()
        doc.DocumentName = "Receipt #" & saleId
        ' Paper sizes are in hundredths of an inch: 315 = about 80 mm wide.
        doc.DefaultPageSettings.PaperSize = New PaperSize("Receipt", 315, 480 + items.Rows.Count * 36)
        doc.DefaultPageSettings.Margins = New Margins(12, 12, 12, 12)
        AddHandler doc.PrintPage, Sub(s, e) DrawReceipt(e, shop, head.Rows(0), items)
        Return doc
    End Function

    Private Sub DrawReceipt(e As PrintPageEventArgs, shop As String, h As DataRow, items As DataTable)
        Dim g = e.Graphics
        Dim m = e.MarginBounds
        Dim y As Single = m.Top

        Using fTitle As New Font("Segoe UI", 12, FontStyle.Bold),
              fBold As New Font("Segoe UI", 8.5F, FontStyle.Bold),
              fText As New Font("Segoe UI", 8.5F),
              fTotal As New Font("Segoe UI", 11, FontStyle.Bold),
              dashed As New Pen(Color.Black),
              centre As New StringFormat(),
              rightFmt As New StringFormat(),
              leftFmt As New StringFormat()

            dashed.DashStyle = Drawing2D.DashStyle.Dash
            centre.Alignment = StringAlignment.Center
            rightFmt.Alignment = StringAlignment.Far
            leftFmt.Trimming = StringTrimming.EllipsisCharacter
            leftFmt.FormatFlags = StringFormatFlags.NoWrap

            Dim centred = Sub(text As String, f As Font)
                              g.DrawString(text, f, Brushes.Black, New RectangleF(m.Left, y, m.Width, 40), centre)
                              y += f.GetHeight(g) + 3
                          End Sub
            Dim pair = Sub(l As String, r As String, f As Font)
                           g.DrawString(l, f, Brushes.Black, New RectangleF(m.Left, y, m.Width - 70, 30), leftFmt)
                           g.DrawString(r, f, Brushes.Black, New RectangleF(m.Left, y, m.Width, 30), rightFmt)
                           y += f.GetHeight(g) + 3
                       End Sub
            Dim divider = Sub()
                              y += 2
                              g.DrawLine(dashed, m.Left, y, m.Right, y)
                              y += 6
                          End Sub

            centred(shop, fTitle)
            centred("SALES RECEIPT", fBold)
            divider()
            pair("Receipt #:", Convert.ToString(h("SaleID")), fText)
            pair("Date:", Convert.ToDateTime(h("SaleDate")).ToString("dd/MM/yyyy HH:mm"), fText)
            pair("Cashier:", Convert.ToString(h("Cashier")), fText)
            pair("Customer:", Convert.ToString(h("Customer")), fText)
            divider()

            For Each r As DataRow In items.Rows
                Dim qty As Integer = Convert.ToInt32(r("Quantity"))
                pair(Convert.ToString(r("ProductName")), "", fBold)
                pair("   " & qty & " x " & Convert.ToDecimal(r("UnitPrice")).ToString("N2"), Convert.ToDecimal(r("LineTotal")).ToString("N2"), fText)
            Next
            divider()

            Dim subtotal As Decimal = Convert.ToDecimal(h("Subtotal"))
            Dim total As Decimal = Convert.ToDecimal(h("Total"))
            Dim pct As Decimal = Convert.ToDecimal(h("DiscountPercent"))
            pair("Subtotal:", "KSh " & subtotal.ToString("N2"), fText)
            If pct > 0 Then pair("Discount (" & pct.ToString("0.##") & "%):", "-KSh " & (subtotal - total).ToString("N2"), fText)
            y += 2
            pair("TOTAL:", "KSh " & total.ToString("N2"), fTotal)
            divider()
            centred("Thank you for shopping with us!", fText)
            centred("Please keep this receipt.", fText)
        End Using
        e.HasMorePages = False
    End Sub
End Module
