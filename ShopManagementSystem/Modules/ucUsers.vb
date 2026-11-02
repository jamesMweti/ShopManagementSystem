Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports MySqlConnector

Public Class ucUsers
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvUsers)
    End Sub

    Private Sub UpdateButtons()
        Dim has As Boolean = dgvUsers.CurrentRow IsNot Nothing
        btnEdit.Enabled = has
        btnDelete.Enabled = has
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        UpdateButtons()
    End Sub

    Private Sub dgvUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsers.CellFormatting
        Ui.ColorStatusCell(dgvUsers, e)
    End Sub

    Private Sub dgvUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellDoubleClick
        If e.RowIndex >= 0 AndAlso btnEdit.Visible Then btnEdit.PerformClick()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If Ui.Run(AddressOf AddRecord) Then LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id As Integer = Ui.SelectedId(dgvUsers)
        If id = 0 Then Return
        If Ui.Run(Sub() EditRecord(id)) Then LoadData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Ui.SelectedId(dgvUsers)
        If id = 0 Then Return
        If Not Ui.Confirm("Delete the selected record? This cannot be undone.") Then Return
        If Ui.Run(Sub() DeleteRecord(id)) Then LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Ui.Run(AddressOf LoadData)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        ' The password hash is deliberately never selected.
        dgvUsers.DataSource = Db.Query("SELECT UserID AS ID, FullName AS `Full Name`, Username, Email, Role, Status FROM Users ORDER BY FullName")
        dgvUsers.Columns("ID").FillWeight = 30
        UpdateButtons()
    End Sub

    Private Function BuildFields(row As DataRow) As List(Of FieldDef)
        Dim list As New List(Of FieldDef)
        list.Add(New FieldDef("name", "Full name", "text", True, Ui.RowValue(row, "FullName")) With {.MaxLength = 100})
        list.Add(New FieldDef("email", "Email", "email", True, Ui.RowValue(row, "Email")))
        list.Add(New FieldDef("username", "Username", "text", True, Ui.RowValue(row, "Username")) With {.MaxLength = 50})
        If row Is Nothing Then list.Add(New FieldDef("password", "Password (8+ characters, letters and digits)", "newpassword", True))
        list.Add(New FieldDef("role", "Role", "combo", True, If(row Is Nothing, "Cashier", Ui.RowValue(row, "Role"))) With {.Options = Ui.Items("Administrator", "Staff", "Cashier")})
        list.Add(New FieldDef("status", "Status", "combo", True, If(row Is Nothing, "Active", Ui.RowValue(row, "Status"))) With {.Options = Ui.Items("Active", "Inactive")})
        Return list
    End Function

    Private Sub CheckUnique(username As String, email As String, id As Integer)
        If username.Length < 3 OrElse username.Contains(" ") Then Throw New InvalidOperationException("Username must be at least 3 characters with no spaces.")
        If Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Users WHERE Username=@u AND UserID<>@id", Db.P("@u", username), Db.P("@id", id))) > 0 Then
            Throw New InvalidOperationException("That username is already taken.")
        End If
        If Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Users WHERE Email=@e AND UserID<>@id", Db.P("@e", email), Db.P("@id", id))) > 0 Then
            Throw New InvalidOperationException("That email is already used by another account.")
        End If
    End Sub

    Private Sub EnsureAdminRemains(id As Integer, newRole As String, newStatus As String)
        If newRole = "Administrator" AndAlso newStatus = "Active" Then Return
        Dim others = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Users WHERE Role='Administrator' AND Status='Active' AND UserID<>@id", Db.P("@id", id)))
        If others = 0 Then Throw New InvalidOperationException("At least one active administrator must remain.")
    End Sub

    Private Sub AddRecord()
        Dim r = FieldDialog.Ask(Me, "Add User", BuildFields(Nothing))
        If r Is Nothing Then Return
        CheckUnique(CStr(r("username")), CStr(r("email")), 0)
        Db.Exec("INSERT INTO Users (FullName, Username, Email, PasswordHash, Role, Status) VALUES (@n,@u,@e,@h,@r,@s)",
                Db.P("@n", r("name")), Db.P("@u", r("username")), Db.P("@e", r("email")), Db.P("@h", PasswordHelper.HashPassword(CStr(r("password")))),
                Db.P("@r", r("role")), Db.P("@s", r("status")))
    End Sub

    Private Sub EditRecord(id As Integer)
        Dim dt = Db.Query("SELECT * FROM Users WHERE UserID=@id", Db.P("@id", id))
        If dt.Rows.Count = 0 Then Return
        Dim r = FieldDialog.Ask(Me, "Edit User", BuildFields(dt.Rows(0)))
        If r Is Nothing Then Return
        CheckUnique(CStr(r("username")), CStr(r("email")), id)
        EnsureAdminRemains(id, CStr(r("role")), CStr(r("status")))
        Db.Exec("UPDATE Users SET FullName=@n, Username=@u, Email=@e, Role=@r, Status=@s WHERE UserID=@id",
                Db.P("@n", r("name")), Db.P("@u", r("username")), Db.P("@e", r("email")), Db.P("@r", r("role")), Db.P("@s", r("status")), Db.P("@id", id))
        If id = AppSession.User.UserID Then AppSession.SignIn(id, CStr(r("name")), CStr(r("username")), CStr(r("role")))
    End Sub

    Private Sub DeleteRecord(id As Integer)
        If id = AppSession.User.UserID Then Throw New InvalidOperationException("You cannot delete your own account.")
        EnsureAdminRemains(id, "", "")
        Try
            Db.Exec("DELETE FROM Users WHERE UserID=@id", Db.P("@id", id))
        Catch ex As MySqlException When ex.Number = 1451
            Throw New InvalidOperationException("This user has recorded sales and can't be deleted. Set the status to Inactive instead.")
        End Try
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim id As Integer = Ui.SelectedId(dgvUsers)
        If id = 0 Then Return
        Ui.Run(Sub() ResetPassword(id))
    End Sub

    Private Sub ResetPassword(id As Integer)
        Dim r = FieldDialog.Ask(Me, "Reset Password", New List(Of FieldDef) From {
            New FieldDef("pw", "New password (8+ characters, letters and digits)", "newpassword", True)
        })
        If r Is Nothing Then Return
        Db.Exec("UPDATE Users SET PasswordHash=@h WHERE UserID=@id", Db.P("@h", PasswordHelper.HashPassword(CStr(r("pw")))), Db.P("@id", id))
        Ui.Info("Password updated.")
    End Sub
End Class
