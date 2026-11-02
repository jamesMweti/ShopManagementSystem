Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports MySqlConnector

Public Class ucCustomers
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvCustomers)
    End Sub

    Private Sub UpdateButtons()
        Dim has As Boolean = dgvCustomers.CurrentRow IsNot Nothing
        btnEdit.Enabled = has
        btnDelete.Enabled = has
    End Sub

    Private Sub dgvCustomers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCustomers.SelectionChanged
        UpdateButtons()
    End Sub

    Private Sub dgvCustomers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCustomers.CellFormatting
        Ui.ColorStatusCell(dgvCustomers, e)
    End Sub

    Private Sub dgvCustomers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellDoubleClick
        If e.RowIndex >= 0 AndAlso btnEdit.Visible Then btnEdit.PerformClick()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If Ui.Run(AddressOf AddRecord) Then LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id As Integer = Ui.SelectedId(dgvCustomers)
        If id = 0 Then Return
        If Ui.Run(Sub() EditRecord(id)) Then LoadData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Ui.SelectedId(dgvCustomers)
        If id = 0 Then Return
        If Not Ui.Confirm("Delete the selected record? This cannot be undone.") Then Return
        If Ui.Run(Sub() DeleteRecord(id)) Then LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Run(AddressOf LoadData)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        dgvCustomers.DataSource = Db.Query("SELECT CustomerID AS ID, FullName AS Name, IFNULL(PhoneNumber,'') AS Phone, IFNULL(Email,'') AS Email FROM Customers ORDER BY FullName")
        dgvCustomers.Columns("ID").FillWeight = 30
        UpdateButtons()
    End Sub

    Private Function BuildFields(row As DataRow) As List(Of FieldDef)
        Return New List(Of FieldDef) From {
            New FieldDef("name", "Full name", "text", True, Ui.RowValue(row, "FullName")) With {.MaxLength = 100},
            New FieldDef("phone", "Phone number", "phone", False, Ui.RowValue(row, "PhoneNumber")) With {.MaxLength = 30},
            New FieldDef("email", "Email", "email", False, Ui.RowValue(row, "Email"))
        }
    End Function

    Private Sub CheckDuplicate(phone As String, email As String, id As Integer)
        If phone <> "" AndAlso Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Customers WHERE PhoneNumber=@p AND CustomerID<>@id", Db.P("@p", phone), Db.P("@id", id))) > 0 Then
            Throw New InvalidOperationException("A customer with that phone number already exists.")
        End If
        If email <> "" AndAlso Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Customers WHERE Email=@e AND CustomerID<>@id", Db.P("@e", email), Db.P("@id", id))) > 0 Then
            Throw New InvalidOperationException("A customer with that email already exists.")
        End If
    End Sub

    Private Sub AddRecord()
        Dim r = FieldDialog.Ask(Me, "Add Customer", BuildFields(Nothing))
        If r Is Nothing Then Return
        CheckDuplicate(CStr(r("phone")), CStr(r("email")), 0)
        Db.Exec("INSERT INTO Customers (FullName, PhoneNumber, Email) VALUES (@n,@p,@e)", Db.P("@n", r("name")), Db.P("@p", r("phone")), Db.P("@e", r("email")))
    End Sub

    Private Sub EditRecord(id As Integer)
        Dim dt = Db.Query("SELECT * FROM Customers WHERE CustomerID=@id", Db.P("@id", id))
        If dt.Rows.Count = 0 Then Return
        Dim r = FieldDialog.Ask(Me, "Edit Customer", BuildFields(dt.Rows(0)))
        If r Is Nothing Then Return
        CheckDuplicate(CStr(r("phone")), CStr(r("email")), id)
        Db.Exec("UPDATE Customers SET FullName=@n, PhoneNumber=@p, Email=@e WHERE CustomerID=@id", Db.P("@n", r("name")), Db.P("@p", r("phone")), Db.P("@e", r("email")), Db.P("@id", id))
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Dim n = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Sales WHERE CustomerID=@id", Db.P("@id", id)))
        If n > 0 AndAlso Not Ui.Confirm("This customer has " & n & " recorded sale(s). Those sales will be kept but shown as 'Walk-in Customer'. Delete anyway?") Then Return
        Db.Exec("DELETE FROM Customers WHERE CustomerID=@id", Db.P("@id", id))
    End Sub
End Class
