Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class ucInventory
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvInventory)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        btnUpdateStock.Visible = AppSession.CanManage
        dgvInventory.DataSource = Db.Query("SELECT p.ProductID AS ID, p.ProductName AS Product, IFNULL(c.CategoryName,'') AS Category, p.QuantityInStock AS Stock, p.ReorderLevel AS `Reorder Level`, " &
                        "CASE WHEN p.QuantityInStock <= 0 THEN 'Out of Stock' WHEN p.QuantityInStock <= p.ReorderLevel THEN 'Low Stock' ELSE 'In Stock' END AS Status " &
                        "FROM Products p LEFT JOIN Categories c ON c.CategoryID = p.CategoryID ORDER BY p.ProductName")
        dgvInventory.Columns("ID").Visible = False
        dgvInventory.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvInventory.Columns("Reorder Level").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub dgvInventory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvInventory.CellFormatting
        Ui.ColorStatusCell(dgvInventory, e)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Run(AddressOf LoadData)
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        Dim id As Integer = Ui.SelectedId(dgvInventory)
        If id = 0 Then Return
        If Ui.Run(Sub() AdjustStock(id)) Then LoadData()
    End Sub

    Private Sub AdjustStock(id As Integer)
        Dim dt = Db.Query("SELECT ProductName, QuantityInStock FROM Products WHERE ProductID=@id", Db.P("@id", id))
        If dt.Rows.Count = 0 Then Return
        Dim name As String = Convert.ToString(dt.Rows(0)("ProductName"))
        Dim current As Integer = Convert.ToInt32(dt.Rows(0)("QuantityInStock"))

        Dim r = FieldDialog.Ask(Me, "Adjust Stock - " & name & " (now " & current & ")", New List(Of FieldDef) From {
            New FieldDef("change", "Quantity change (use a negative number to remove stock)", "int", True, 0) With {.Min = -100000D, .Max = 100000D},
            New FieldDef("reason", "Reason", "combo", True, "Restock") With {.Options = Ui.Items("Restock", "Stock count correction", "Damaged / expired", "Customer return", "Other")}
        })
        If r Is Nothing Then Return
        Dim change As Integer = CInt(r("change"))
        If change = 0 Then Return

        Db.InTransaction(
            Sub(cn, tx)
                Dim rows = Db.ExecTx(cn, tx, "UPDATE Products SET QuantityInStock = QuantityInStock + @d WHERE ProductID=@id AND QuantityInStock + @d >= 0", Db.P("@d", change), Db.P("@id", id))
                If rows = 0 Then Throw New InvalidOperationException("Stock cannot go below zero.")
                Db.ExecTx(cn, tx, "INSERT INTO StockMovements (ProductID, UserID, QuantityChange, Reason) VALUES (@p,@u,@q,@r)",
                          Db.P("@p", id), Db.P("@u", AppSession.User.UserID), Db.P("@q", change), Db.P("@r", CStr(r("reason"))))
            End Sub)
    End Sub
End Class
