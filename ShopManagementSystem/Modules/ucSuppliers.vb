Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports MySqlConnector

Public Class ucSuppliers
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvSuppliers)
    End Sub

    Private Sub UpdateButtons()
        Dim has As Boolean = dgvSuppliers.CurrentRow IsNot Nothing
        btnEdit.Enabled = has
        btnDelete.Enabled = has
    End Sub

    Private Sub dgvSuppliers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSuppliers.SelectionChanged
        UpdateButtons()
    End Sub

    Private Sub dgvSuppliers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSuppliers.CellFormatting
        Ui.ColorStatusCell(dgvSuppliers, e)
    End Sub

    Private Sub dgvSuppliers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellDoubleClick
        If e.RowIndex >= 0 AndAlso btnEdit.Visible Then btnEdit.PerformClick()
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        If Ui.Run(AddressOf AddRecord) Then LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id As Integer = Ui.SelectedId(dgvSuppliers)
        If id = 0 Then Return
        If Ui.Run(Sub() EditRecord(id)) Then LoadData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Ui.SelectedId(dgvSuppliers)
        If id = 0 Then Return
        If Not Ui.Confirm("Delete the selected record? This cannot be undone.") Then Return
        If Ui.Run(Sub() DeleteRecord(id)) Then LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Run(AddressOf LoadData)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        Dim canManage As Boolean = AppSession.CanManage
        btnAddSupplier.Visible = canManage
        btnEdit.Visible = canManage
        btnDelete.Visible = canManage

        dgvSuppliers.DataSource = Db.Query("SELECT s.SupplierID AS ID, s.SupplierName AS Supplier, IFNULL(s.PhoneNumber,'') AS Phone, IFNULL(s.Email,'') AS Email, COUNT(p.ProductID) AS Products " &
                        "FROM Suppliers s LEFT JOIN Products p ON p.SupplierID = s.SupplierID GROUP BY s.SupplierID, s.SupplierName, s.PhoneNumber, s.Email ORDER BY s.SupplierName")
        dgvSuppliers.Columns("ID").FillWeight = 30
        UpdateButtons()
    End Sub

    Private Function BuildFields(row As DataRow) As List(Of FieldDef)
        Return New List(Of FieldDef) From {
            New FieldDef("name", "Supplier name", "text", True, Ui.RowValue(row, "SupplierName")) With {.MaxLength = 100},
            New FieldDef("phone", "Phone number", "phone", False, Ui.RowValue(row, "PhoneNumber")) With {.MaxLength = 30},
            New FieldDef("email", "Email", "email", False, Ui.RowValue(row, "Email"))
        }
    End Function

    Private Sub AddRecord()
        Dim r = FieldDialog.Ask(Me, "Add Supplier", BuildFields(Nothing))
        If r Is Nothing Then Return
        Db.Exec("INSERT INTO Suppliers (SupplierName, PhoneNumber, Email) VALUES (@n,@p,@e)", Db.P("@n", r("name")), Db.P("@p", r("phone")), Db.P("@e", r("email")))
    End Sub

    Private Sub EditRecord(id As Integer)
        Dim dt = Db.Query("SELECT * FROM Suppliers WHERE SupplierID=@id", Db.P("@id", id))
        If dt.Rows.Count = 0 Then Return
        Dim r = FieldDialog.Ask(Me, "Edit Supplier", BuildFields(dt.Rows(0)))
        If r Is Nothing Then Return
        Db.Exec("UPDATE Suppliers SET SupplierName=@n, PhoneNumber=@p, Email=@e WHERE SupplierID=@id", Db.P("@n", r("name")), Db.P("@p", r("phone")), Db.P("@e", r("email")), Db.P("@id", id))
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Db.Exec("DELETE FROM Suppliers WHERE SupplierID=@id", Db.P("@id", id))
    End Sub
End Class
