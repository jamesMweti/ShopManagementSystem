Imports System.Security.Cryptography

Public Class UserInfo
    Public Property UserID As Integer
    Public Property FullName As String
    Public Property Username As String
    Public Property Role As String
End Class

''' <summary>Secure password hashing (PBKDF2-SHA256 with a random salt). Passwords are never stored as plain text.</summary>
Public Module PasswordHelper
    Private Const Iterations As Integer = 100000

    Public Function HashPassword(password As String) As String
        Dim salt = RandomNumberGenerator.GetBytes(16)
        Dim hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32)
        Return Iterations.ToString() & "." & Convert.ToBase64String(salt) & "." & Convert.ToBase64String(hash)
    End Function

    Public Function VerifyPassword(password As String, stored As String) As Boolean
        Try
            Dim parts = stored.Split("."c)
            If parts.Length <> 3 Then Return False
            Dim iters = Integer.Parse(parts(0))
            Dim salt = Convert.FromBase64String(parts(1))
            Dim expected = Convert.FromBase64String(parts(2))
            Dim actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, iters, HashAlgorithmName.SHA256, expected.Length)
            Return CryptographicOperations.FixedTimeEquals(actual, expected)
        Catch
            Return False
        End Try
    End Function
End Module

''' <summary>Holds the logged-in user and role-based access rules.</summary>
Public Module AppSession
    Public User As UserInfo

    Public Sub SignIn(id As Integer, fullName As String, username As String, role As String)
        User = New UserInfo With {.UserID = id, .FullName = fullName, .Username = username, .Role = role}
    End Sub

    Public Sub SignOut()
        User = Nothing
    End Sub

    Public ReadOnly Property IsAdmin As Boolean
        Get
            Return User IsNot Nothing AndAlso User.Role = "Administrator"
        End Get
    End Property

    ' Administrators and Staff can add/edit/delete; Cashiers can only view products/inventory and make sales.
    Public ReadOnly Property CanManage As Boolean
        Get
            Return User IsNot Nothing AndAlso (User.Role = "Administrator" OrElse User.Role = "Staff")
        End Get
    End Property

    Public Function CanAccess(key As String) As Boolean
        If User Is Nothing Then Return False
        Select Case User.Role
            Case "Administrator"
                Return True
            Case "Staff"
                Return key <> "Users"
            Case Else
                Dim allowed As String() = {"Dashboard", "Products", "Customers", "Sales", "Inventory", "Settings", "Logout", "Quit"}
                Return Array.IndexOf(allowed, key) >= 0
        End Select
    End Function
End Module
