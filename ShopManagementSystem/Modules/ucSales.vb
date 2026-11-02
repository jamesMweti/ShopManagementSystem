Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class ucSales
    Implements IScreen

    Private Class CartLine
        Public ProductID As Integer
        Public Name As String
        Public Qty As Integer
        Public Price As Decimal
    End Class

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvSaleItems)
        dgvSaleItems.ReadOnly = False   ' only the Qty column is editable (the others are ReadOnly in the designer)
        dgvSaleItems.Columns("colPrice").DefaultCellStyle.Format = "N2"
        dgvSaleItems.Columns("colTotal").DefaultCellStyle.Format = "N2"
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        dtpSaleDate.MaxDate = Date.Today
        dtpSaleDate.Value = Date.Today
        Dim list = Ui.ToItems(Db.Query("SELECT CustomerID, FullName FROM Customers ORDER BY FullName"), "CustomerID", "FullName", "Walk-in Customer")
        cmbCustomer.Items.Clear()
        For Each it In list
            cmbCustomer.Items.Add(it)
        Next
        cmbCustomer.SelectedIndex = 0
        ClearCart()
    End Sub

    Private Sub ClearCart()
        dgvSaleItems.Rows.Clear()
        nudDiscount.Value = 0
        Recalculate()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Ui.Run(AddressOf AddItem)
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If dgvSaleItems.CurrentRow Is Nothing Then
            Ui.Info("Select an item to remove.")
            Return
        End If
        dgvSaleItems.Rows.Remove(dgvSaleItems.CurrentRow)
        Recalculate()
    End Sub

    Private Sub nudDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscount.ValueChanged
        Recalculate()
    End Sub

    Private Sub btnCompleteSale_Click(sender As Object, e As EventArgs) Handles btnCompleteSale.Click
        Ui.Run(AddressOf CompleteSale)
    End Sub

    ' When the cashier edits a quantity, check it and recalculate the line and the totals.
    Private Sub dgvSaleItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleItems.CellEndEdit
        If e.RowIndex < 0 Then Return
        Dim row = dgvSaleItems.Rows(e.RowIndex)
        Dim stock As Integer = Convert.ToInt32(row.Cells("colStock").Value)
        Dim qty As Integer
        If Not Integer.TryParse(Convert.ToString(row.Cells("colQty").Value), qty) OrElse qty < 1 Then
            Ui.Warn("Quantity must be a whole number of at least 1.")
            qty = 1
        End If
        If qty > stock Then
            Ui.Warn("Only " & stock & " in stock.")
            qty = stock
        End If
        row.Cells("colQty").Value = qty
        row.Cells("colTotal").Value = qty * Convert.ToDecimal(row.Cells("colPrice").Value)
        Recalculate()
    End Sub

    Private Sub AddItem()
        Dim prods = Db.Query("SELECT ProductID, ProductName, UnitPrice, QuantityInStock FROM Products WHERE QuantityInStock > 0 ORDER BY ProductName")
        If prods.Rows.Count = 0 Then
            Ui.Info("There are no products in stock to sell.")
            Return
        End If
        Dim items As New List(Of ComboItem)
        For Each pr As DataRow In prods.Rows
            Dim label As String = Convert.ToString(pr("ProductName")) & "  -  KSh " & Convert.ToDecimal(pr("UnitPrice")).ToString("N2") & "  (" & Convert.ToString(pr("QuantityInStock")) & " in stock)"
            items.Add(New ComboItem(label, pr("ProductID")))
        Next
        Dim r = FieldDialog.Ask(Me, "Add Item", New List(Of FieldDef) From {
            New FieldDef("product", "Product", "combo", True) With {.Options = items},
            New FieldDef("qty", "Quantity", "int", True, 1) With {.Min = 1D, .Max = 100000D}
        })
        If r Is Nothing Then Return

        Dim pid As Integer = Convert.ToInt32(r("product"))
        Dim qty As Integer = CInt(r("qty"))
        Dim prow As DataRow = prods.Select("ProductID = " & pid)(0)
        Dim stock As Integer = Convert.ToInt32(prow("QuantityInStock"))

        ' Already in the cart? Add to the existing line.
        For Each row As DataGridViewRow In dgvSaleItems.Rows
            If Convert.ToInt32(row.Cells("colProductID").Value) = pid Then
                Dim newQty As Integer = Convert.ToInt32(row.Cells("colQty").Value) + qty
                If newQty > stock Then
                    Ui.Warn("Only " & stock & " in stock for " & Convert.ToString(prow("ProductName")) & ".")
                    Return
                End If
                row.Cells("colQty").Value = newQty
                row.Cells("colTotal").Value = newQty * Convert.ToDecimal(row.Cells("colPrice").Value)
                Recalculate()
                Return
            End If
        Next

        If qty > stock Then
            Ui.Warn("Only " & stock & " in stock for " & Convert.ToString(prow("ProductName")) & ".")
            Return
        End If
        Dim price As Decimal = Convert.ToDecimal(prow("UnitPrice"))
        ' Column order: ProductID, Stock, Product, Price, Qty, Total
        dgvSaleItems.Rows.Add(pid, stock, Convert.ToString(prow("ProductName")), price, qty, price * qty)
        Recalculate()
    End Sub

    Private Function Subtotal() As Decimal
        Dim sum As Decimal = 0
        For Each row As DataGridViewRow In dgvSaleItems.Rows
            sum += Convert.ToInt32(row.Cells("colQty").Value) * Convert.ToDecimal(row.Cells("colPrice").Value)
        Next
        Return sum
    End Function

    Private Function FinalTotal(sub1 As Decimal) As Decimal
        Return Math.Round(sub1 - sub1 * nudDiscount.Value / 100D, 2)
    End Function

    Private Sub Recalculate()
        Dim s As Decimal = Subtotal()
        lblSubtotal.Text = Ui.Money(s)
        lblTotal.Text = Ui.Money(FinalTotal(s))
    End Sub

    Private Sub CompleteSale()
        If dgvSaleItems.Rows.Count = 0 Then
            Ui.Warn("Add at least one item before completing the sale.")
            Return
        End If

        Dim lines As New List(Of CartLine)
        For Each row As DataGridViewRow In dgvSaleItems.Rows
            lines.Add(New CartLine With {
                .ProductID = Convert.ToInt32(row.Cells("colProductID").Value),
                .Name = Convert.ToString(row.Cells("colProduct").Value),
                .Qty = Convert.ToInt32(row.Cells("colQty").Value),
                .Price = Convert.ToDecimal(row.Cells("colPrice").Value)})
        Next

        Dim sub1 As Decimal = Subtotal()
        Dim disc As Decimal = nudDiscount.Value
        Dim total As Decimal = FinalTotal(sub1)
        Dim customerId As Object = DirectCast(cmbCustomer.SelectedItem, ComboItem).Value
        Dim saleDate As Date = dtpSaleDate.Value.Date + DateTime.Now.TimeOfDay
        Dim saleId As Long = 0

        ' One transaction: the sale, its lines and the stock reduction are saved together or not at all.
        Db.InTransaction(
            Sub(cn, tx)
                saleId = Db.InsertTx(cn, tx, "INSERT INTO Sales (CustomerID, UserID, SaleDate, Subtotal, DiscountPercent, Total) VALUES (@c,@u,@d,@s,@disc,@t)",
                                     Db.P("@c", customerId), Db.P("@u", AppSession.User.UserID), Db.P("@d", saleDate), Db.P("@s", sub1), Db.P("@disc", disc), Db.P("@t", total))
                For Each ln In lines
                    Dim updated = Db.ExecTx(cn, tx, "UPDATE Products SET QuantityInStock = QuantityInStock - @q WHERE ProductID=@p AND QuantityInStock >= @q",
                                            Db.P("@q", ln.Qty), Db.P("@p", ln.ProductID))
                    If updated = 0 Then Throw New InvalidOperationException("Not enough stock left for " & ln.Name & ". The sale was not saved.")
                    Db.ExecTx(cn, tx, "INSERT INTO SaleItems (SaleID, ProductID, Quantity, UnitPrice, LineTotal) VALUES (@s,@p,@q,@u,@l)",
                              Db.P("@s", saleId), Db.P("@p", ln.ProductID), Db.P("@q", ln.Qty), Db.P("@u", ln.Price), Db.P("@l", ln.Qty * ln.Price))
                    Db.ExecTx(cn, tx, "INSERT INTO StockMovements (ProductID, UserID, QuantityChange, Reason) VALUES (@p,@u,@q,@r)",
                              Db.P("@p", ln.ProductID), Db.P("@u", AppSession.User.UserID), Db.P("@q", -ln.Qty), Db.P("@r", "Sale #" & saleId))
                Next
            End Sub)

        If Ui.Confirm("Sale #" & saleId & " completed." & vbCrLf & "Total: " & Ui.Money(total) & vbCrLf & vbCrLf & "Generate a receipt?") Then
            Using f As New frmReceipt()
                f.LoadSale(saleId)
                f.ShowDialog(Me)
            End Using
        End If
        LoadData()
    End Sub
End Class
