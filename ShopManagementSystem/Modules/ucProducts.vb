Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports MySqlConnector

Public Class ucProducts
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvProducts)
    End Sub

    Private Sub UpdateButtons()
        Dim has As Boolean = dgvProducts.CurrentRow IsNot Nothing
        btnEdit.Enabled = has
        btnDelete.Enabled = has
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        UpdateButtons()
    End Sub

    Private Sub dgvProducts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProducts.CellFormatting
        Ui.ColorStatusCell(dgvProducts, e)
    End Sub

    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
        If e.RowIndex >= 0 AndAlso btnEdit.Visible Then btnEdit.PerformClick()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If Ui.Run(AddressOf AddRecord) Then LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id As Integer = Ui.SelectedId(dgvProducts)
        If id = 0 Then Return
        If Ui.Run(Sub() EditRecord(id)) Then LoadData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Ui.SelectedId(dgvProducts)
        If id = 0 Then Return
        If Not Ui.Confirm("Delete the selected record? This cannot be undone.") Then Return
        If Ui.Run(Sub() DeleteRecord(id)) Then LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Run(AddressOf LoadData)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        ' Cashiers can view products but not change them.
        Dim canManage As Boolean = AppSession.CanManage
        btnAddProduct.Visible = canManage
        btnEdit.Visible = canManage
        btnDelete.Visible = canManage

        dgvProducts.DataSource = Db.Query("SELECT p.ProductID AS ID, p.ProductName AS `Product Name`, IFNULL(c.CategoryName, '') AS Category, " &
                        "p.UnitPrice AS `Price (KSh)`, p.QuantityInStock AS Stock, " &
                        "CASE WHEN p.QuantityInStock <= 0 THEN 'Out of Stock' WHEN p.QuantityInStock <= p.ReorderLevel THEN 'Low Stock' ELSE 'In Stock' END AS Status " &
                        "FROM Products p LEFT JOIN Categories c ON c.CategoryID = p.CategoryID ORDER BY p.ProductName")
        dgvProducts.Columns("ID").FillWeight = 30
        dgvProducts.Columns("Price (KSh)").DefaultCellStyle.Format = "N2"
        dgvProducts.Columns("Price (KSh)").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvProducts.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        UpdateButtons()
    End Sub

    Private Function BuildFields(row As DataRow) As List(Of FieldDef)
        Dim cats = Ui.ToItems(Db.Query("SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName"), "CategoryID", "CategoryName", "(None)")
        Dim sups = Ui.ToItems(Db.Query("SELECT SupplierID, SupplierName FROM Suppliers ORDER BY SupplierName"), "SupplierID", "SupplierName", "(None)")
        Return New List(Of FieldDef) From {
            New FieldDef("name", "Product name", "text", True, Ui.RowValue(row, "ProductName")),
            New FieldDef("cat", "Category", "combo", False, Ui.RowValue(row, "CategoryID")) With {.Options = cats},
            New FieldDef("sup", "Supplier", "combo", False, Ui.RowValue(row, "SupplierID")) With {.Options = sups},
            New FieldDef("price", "Unit price (KSh)", "decimal", True, Ui.RowValue(row, "UnitPrice")) With {.Min = 0.01D},
            New FieldDef("qty", "Quantity in stock", "int", True, Ui.RowValue(row, "QuantityInStock")) With {.Max = 1000000D},
            New FieldDef("reorder", "Low-stock level (reorder at or below)", "int", True, If(row Is Nothing, 10, Ui.RowValue(row, "ReorderLevel"))) With {.Max = 1000000D}
        }
    End Function

    Private Sub CheckUniqueName(name As String, id As Integer)
        Dim n = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Products WHERE ProductName=@n AND ProductID<>@id", Db.P("@n", name), Db.P("@id", id)))
        If n > 0 Then Throw New InvalidOperationException("A product with that name already exists.")
    End Sub

    Private Sub AddRecord()
        Dim r = FieldDialog.Ask(Me, "Add Product", BuildFields(Nothing))
        If r Is Nothing Then Return
        CheckUniqueName(CStr(r("name")), 0)
        Dim qty As Integer = CInt(r("qty"))
        Db.InTransaction(
            Sub(cn, tx)
                Dim pid = Db.InsertTx(cn, tx, "INSERT INTO Products (ProductName, CategoryID, SupplierID, UnitPrice, QuantityInStock, ReorderLevel) VALUES (@n,@c,@s,@p,@q,@r)",
                                      Db.P("@n", r("name")), Db.P("@c", r("cat")), Db.P("@s", r("sup")), Db.P("@p", r("price")), Db.P("@q", qty), Db.P("@r", r("reorder")))
                If qty > 0 Then
                    Db.ExecTx(cn, tx, "INSERT INTO StockMovements (ProductID, UserID, QuantityChange, Reason) VALUES (@p,@u,@q,'Opening stock')",
                              Db.P("@p", pid), Db.P("@u", AppSession.User.UserID), Db.P("@q", qty))
                End If
            End Sub)
    End Sub

    Private Sub EditRecord(id As Integer)
        Dim dt = Db.Query("SELECT * FROM Products WHERE ProductID=@id", Db.P("@id", id))
        If dt.Rows.Count = 0 Then Return
        Dim row = dt.Rows(0)
        Dim r = FieldDialog.Ask(Me, "Edit Product", BuildFields(row))
        If r Is Nothing Then Return
        CheckUniqueName(CStr(r("name")), id)
        Dim oldQty As Integer = Convert.ToInt32(row("QuantityInStock"))
        Dim newQty As Integer = CInt(r("qty"))
        Db.InTransaction(
            Sub(cn, tx)
                Db.ExecTx(cn, tx, "UPDATE Products SET ProductName=@n, CategoryID=@c, SupplierID=@s, UnitPrice=@p, QuantityInStock=@q, ReorderLevel=@r WHERE ProductID=@id",
                          Db.P("@n", r("name")), Db.P("@c", r("cat")), Db.P("@s", r("sup")), Db.P("@p", r("price")), Db.P("@q", newQty), Db.P("@r", r("reorder")), Db.P("@id", id))
                If newQty <> oldQty Then
                    Db.ExecTx(cn, tx, "INSERT INTO StockMovements (ProductID, UserID, QuantityChange, Reason) VALUES (@p,@u,@q,'Edited on Products screen')",
                              Db.P("@p", id), Db.P("@u", AppSession.User.UserID), Db.P("@q", newQty - oldQty))
                End If
            End Sub)
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Db.Exec("DELETE FROM Products WHERE ProductID=@id", Db.P("@id", id))
    End Sub
End Class
