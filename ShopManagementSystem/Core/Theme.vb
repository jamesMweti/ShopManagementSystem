Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports MySqlConnector

Public Module Theme
    Public ReadOnly Green As Color = Color.FromArgb(0, 110, 50)
    Public ReadOnly LightGreen As Color = Color.FromArgb(226, 240, 217)
    Public ReadOnly Gold As Color = Color.FromArgb(255, 204, 0)
    Public ReadOnly Danger As Color = Color.FromArgb(214, 40, 40)
    Public ReadOnly Blue As Color = Color.FromArgb(30, 100, 220)
    Public ReadOnly Muted As Color = Color.FromArgb(95, 105, 100)
End Module

''' <summary>An item for ComboBoxes: shows Text, carries a Value (e.g. a database ID).</summary>
Public Class ComboItem
    Public ReadOnly Property Text As String
    Public ReadOnly Property Value As Object

    Public Sub New(text As String, value As Object)
        Me.Text = text
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class

Public Module Validator
    Public Function IsEmail(s As String) As Boolean
        Return Regex.IsMatch(s, "^[^@\s]+@[^@\s]+\.[^@\s]+$")
    End Function

    Public Function IsPhone(s As String) As Boolean
        Return Regex.IsMatch(s, "^\+?[0-9\s\-]{7,15}$")
    End Function

    ''' <summary>Returns an empty string when the password is acceptable, otherwise the reason it is not.</summary>
    Public Function PasswordProblem(pw As String) As String
        If pw.Length < 8 Then Return "Password must be at least 8 characters long."
        If Not Regex.IsMatch(pw, "[A-Za-z]") OrElse Not Regex.IsMatch(pw, "[0-9]") Then Return "Password must contain at least one letter and one digit."
        Return ""
    End Function
End Module

Public Module Ui
    Public Const AppTitle As String = "Shop Management System"

    Public Function MakeButton(text As String, back As Color, Optional width As Integer = 110, Optional fore As Color = Nothing) As Button
        Dim b As New Button()
        b.Text = text
        b.BackColor = back
        b.ForeColor = If(fore.IsEmpty, Color.White, fore)
        b.FlatStyle = FlatStyle.Flat
        b.FlatAppearance.BorderSize = 0
        b.Size = New Size(width, 38)
        b.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        b.Cursor = Cursors.Hand
        b.UseVisualStyleBackColor = False
        b.Margin = New Padding(0, 0, 10, 0)
        Return b
    End Function

    Public Sub StyleGrid(g As DataGridView)
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.AllowUserToResizeRows = False
        g.ReadOnly = True
        g.MultiSelect = False
        g.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        g.RowHeadersVisible = False
        g.BackgroundColor = Color.White
        g.BorderStyle = BorderStyle.FixedSingle
        g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        g.GridColor = Color.FromArgb(225, 225, 225)
        g.EnableHeadersVisualStyles = False
        g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 241)
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        g.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 242, 241)
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        g.ColumnHeadersHeight = 36
        g.RowTemplate.Height = 30
        g.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        g.DefaultCellStyle.SelectionBackColor = Color.RebeccaPurple
        g.DefaultCellStyle.SelectionForeColor = Color.Lavender
    End Sub

    Public Function Money(value As Object) As String
        Return "KSh " & Convert.ToDecimal(value).ToString("N2")
    End Function

    Public Sub Info(message As String)
        MessageBox.Show(message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub Warn(message As String)
        MessageBox.Show(message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Function Confirm(message As String) As Boolean
        Return MessageBox.Show(message, AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Sub ShowError(ex As Exception)
        Dim msg As String = ex.Message
        Dim mex = TryCast(ex, MySqlException)
        If mex IsNot Nothing Then
            Select Case mex.Number
                Case 1451
                    msg = "This record is linked to other records (for example sales or stock history), so it can't be deleted."
                Case 1062
                    msg = "A record with the same unique value already exists."
                Case Else
                    msg = "Database error: " & mex.Message
            End Select
        End If
        MessageBox.Show(msg, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ToItems(dt As DataTable, idCol As String, textCol As String, Optional noneText As String = Nothing) As List(Of ComboItem)
        Dim list As New List(Of ComboItem)
        If noneText IsNot Nothing Then list.Add(New ComboItem(noneText, Nothing))
        For Each r As DataRow In dt.Rows
            list.Add(New ComboItem(Convert.ToString(r(textCol)), r(idCol)))
        Next
        Return list
    End Function

    Public Function Items(ParamArray values() As String) As List(Of ComboItem)
        Dim list As New List(Of ComboItem)
        For Each v In values
            list.Add(New ComboItem(v, v))
        Next
        Return list
    End Function

    ''' <summary>Runs an action; shows a friendly message and returns False if it fails.</summary>
    Public Function Run(action As Action) As Boolean
        Try
            action()
            Return True
        Catch ex As Exception
            ShowError(ex)
            Return False
        End Try
    End Function

    ''' <summary>The ID (first column) of the selected grid row, or 0 when nothing is selected.</summary>
    Public Function SelectedId(g As DataGridView) As Integer
        If g.CurrentRow Is Nothing Then Return 0
        Return Convert.ToInt32(g.CurrentRow.Cells(0).Value)
    End Function

    ''' <summary>Colours a "Status" cell: green = In Stock/Active, amber = Low Stock, red = Out of Stock/Inactive.</summary>
    Public Sub ColorStatusCell(g As DataGridView, e As DataGridViewCellFormattingEventArgs)
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
        If g.Columns(e.ColumnIndex).Name <> "Status" Then Return
        Select Case Convert.ToString(e.Value)
            Case "In Stock", "Active"
                e.CellStyle.ForeColor = Color.FromArgb(0, 128, 60)
            Case "Low Stock"
                e.CellStyle.ForeColor = Color.FromArgb(200, 130, 0)
            Case "Out of Stock", "Inactive"
                e.CellStyle.ForeColor = Theme.Danger
        End Select
    End Sub

    ''' <summary>Reads a column from a DataRow, or Nothing when the row is Nothing (used when adding a new record).</summary>
    Public Function RowValue(row As DataRow, col As String) As Object
        If row Is Nothing Then Return Nothing
        Return row(col)
    End Function
End Module
