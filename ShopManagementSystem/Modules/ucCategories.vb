Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports MySqlConnector

Public Class ucCategories
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvCategories)
    End Sub

    Private Sub UpdateButtons()
        Dim has As Boolean = dgvCategories.CurrentRow IsNot Nothing
        btnEdit.Enabled = has
        btnDelete.Enabled = has
    End Sub

    Private Sub dgvCategories_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCategories.SelectionChanged
        UpdateButtons()
    End Sub

    Private Sub dgvCategories_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCategories.CellFormatting
        Ui.ColorStatusCell(dgvCategories, e)
    End Sub

    Private Sub dgvCategories_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellDoubleClick
        If e.RowIndex >= 0 AndAlso btnEdit.Visible Then btnEdit.PerformClick()
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        If Ui.Run(AddressOf AddRecord) Then LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id As Integer = Ui.SelectedId(dgvCategories)
        If id = 0 Then Return
        If Ui.Run(Sub() EditRecord(id)) Then LoadData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Ui.SelectedId(dgvCategories)
        If id = 0 Then Return
        If Not Ui.Confirm("Delete the selected record? This cannot be undone.") Then Return
        If Ui.Run(Sub() DeleteRecord(id)) Then LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Run(AddressOf LoadData)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        Dim canManage As Boolean = AppSession.CanManage
        btnAddCategory.Visible = canManage
        btnEdit.Visible = canManage
        btnDelete.Visible = canManage

        dgvCategories.DataSource = Db.Query("SELECT c.CategoryID AS ID, c.CategoryName AS Category, IFNULL(c.Description,'') AS Description, COUNT(p.ProductID) AS Products " &
                        "FROM Categories c LEFT JOIN Products p ON p.CategoryID = c.CategoryID GROUP BY c.CategoryID, c.CategoryName, c.Description ORDER BY c.CategoryName")
        dgvCategories.Columns("ID").FillWeight = 30
        UpdateButtons()
    End Sub

    Private Function BuildFields(row As DataRow) As List(Of FieldDef)
        Return New List(Of FieldDef) From {
            New FieldDef("name", "Category name", "text", True, Ui.RowValue(row, "CategoryName")) With {.MaxLength = 100},
            New FieldDef("desc", "Description", "memo", False, Ui.RowValue(row, "Description")) With {.MaxLength = 255}
        }
    End Function

    Private Sub CheckUnique(name As String, id As Integer)
        If Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Categories WHERE CategoryName=@n AND CategoryID<>@id", Db.P("@n", name), Db.P("@id", id))) > 0 Then
            Throw New InvalidOperationException("A category with that name already exists.")
        End If
    End Sub

    Private Sub AddRecord()
        Dim r = FieldDialog.Ask(Me, "Add Category", BuildFields(Nothing))
        If r Is Nothing Then Return
        CheckUnique(CStr(r("name")), 0)
        Db.Exec("INSERT INTO Categories (CategoryName, Description) VALUES (@n,@d)", Db.P("@n", r("name")), Db.P("@d", r("desc")))
    End Sub

    Private Sub EditRecord(id As Integer)
        Dim dt = Db.Query("SELECT * FROM Categories WHERE CategoryID=@id", Db.P("@id", id))
        If dt.Rows.Count = 0 Then Return
        Dim r = FieldDialog.Ask(Me, "Edit Category", BuildFields(dt.Rows(0)))
        If r Is Nothing Then Return
        CheckUnique(CStr(r("name")), id)
        Db.Exec("UPDATE Categories SET CategoryName=@n, Description=@d WHERE CategoryID=@id", Db.P("@n", r("name")), Db.P("@d", r("desc")), Db.P("@id", id))
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Dim n = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Products WHERE CategoryID=@id", Db.P("@id", id)))
        If n > 0 AndAlso Not Ui.Confirm(n & " product(s) use this category. They will become uncategorised. Continue?") Then Return
        Db.Exec("DELETE FROM Categories WHERE CategoryID=@id", Db.P("@id", id))
    End Sub
End Class
