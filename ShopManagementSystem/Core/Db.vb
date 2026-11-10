Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Text.Json
Imports MySqlConnector

Public Class DbConfig
    Public Property Server As String = "localhost"
    Public Property Port As Integer = 3306
    Public Property User As String = "root"
    Public Property Password As String = "Germ.s#41"
    Public Property Database As String = "shop_management_db"
End Class

''' <summary>All database access. Every query is parameterised.</summary>
Public Module Db
    Private ReadOnly ConfigFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShopManagementSystem")
    Private ReadOnly ConfigFile As String = Path.Combine(ConfigFolder, "dbconfig.json")
    Public Config As DbConfig = LoadConfig()

    Private Function LoadConfig() As DbConfig
        Try
            If File.Exists(ConfigFile) Then
                Dim c = JsonSerializer.Deserialize(Of DbConfig)(File.ReadAllText(ConfigFile))
                If c IsNot Nothing Then Return c
            End If
        Catch
        End Try
        Return New DbConfig()
    End Function

    Public Sub SaveConfig()
        Directory.CreateDirectory(ConfigFolder)
        File.WriteAllText(ConfigFile, JsonSerializer.Serialize(Config))
    End Sub

    Public Function BuildConnectionString(includeDatabase As Boolean) As String
        Dim b As New MySqlConnectionStringBuilder()
        b.Server = Config.Server
        b.Port = CUInt(Config.Port)
        b.UserID = Config.User
        b.Password = Config.Password
        b.ConnectionTimeout = 8UI
        If includeDatabase Then b.Database = Config.Database
        Return b.ConnectionString
    End Function

    Public Function Open() As MySqlConnection
        Dim cn As New MySqlConnection(BuildConnectionString(True))
        cn.Open()
        Return cn
    End Function

    ' ---------- Parameter + simple command helpers ----------
    Public Function P(name As String, value As Object) As MySqlParameter
        Return New MySqlParameter(name, If(value, DBNull.Value))
    End Function

    Public Function Query(sql As String, ParamArray args() As MySqlParameter) As DataTable
        Using cn = Open()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddRange(args)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function Exec(sql As String, ParamArray args() As MySqlParameter) As Integer
        Using cn = Open()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddRange(args)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function Scalar(sql As String, ParamArray args() As MySqlParameter) As Object
        Using cn = Open()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddRange(args)
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    ' ---------- Transactions ----------
    Public Sub InTransaction(work As Action(Of MySqlConnection, MySqlTransaction))
        Using cn = Open()
            Using tx = cn.BeginTransaction()
                Try
                    work(cn, tx)
                    tx.Commit()
                Catch
                    tx.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Public Function Cmd(cn As MySqlConnection, tx As MySqlTransaction, sql As String, ParamArray args() As MySqlParameter) As MySqlCommand
        Dim c As New MySqlCommand(sql, cn, tx)
        c.Parameters.AddRange(args)
        Return c
    End Function

    Public Function ExecTx(cn As MySqlConnection, tx As MySqlTransaction, sql As String, ParamArray args() As MySqlParameter) As Integer
        Using c = Cmd(cn, tx, sql, args)
            Return c.ExecuteNonQuery()
        End Using
    End Function

    Public Function InsertTx(cn As MySqlConnection, tx As MySqlTransaction, sql As String, ParamArray args() As MySqlParameter) As Long
        Using c = Cmd(cn, tx, sql, args)
            c.ExecuteNonQuery()
            Return c.LastInsertedId
        End Using
    End Function

    ' ---------- Settings table ----------
    Public Function GetSetting(key As String, fallback As String) As String
        Dim v = Scalar("SELECT SettingValue FROM Settings WHERE SettingKey=@k", P("@k", key))
        If v Is Nothing OrElse IsDBNull(v) Then Return fallback
        Return Convert.ToString(v)
    End Function

    Public Sub SetSetting(key As String, value As String)
        Exec("INSERT INTO Settings (SettingKey, SettingValue) VALUES (@k,@v) ON DUPLICATE KEY UPDATE SettingValue=@v", P("@k", key), P("@v", value))
    End Sub

    ' ---------- Create database + tables on first run ----------
    Public Sub EnsureDatabase()
        Dim dbName = Config.Database.Replace("`", "")
        Using cn As New MySqlConnection(BuildConnectionString(False))
            cn.Open()
            RunText(cn, "CREATE DATABASE IF NOT EXISTS `" & dbName & "` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci")
            RunText(cn, "USE `" & dbName & "`")
            For Each stmt In SchemaStatements()
                RunText(cn, stmt)
            Next
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Users", cn)
                If Convert.ToInt32(cmd.ExecuteScalar()) = 0 Then Seed(cn)
            End Using
        End Using
    End Sub

    Private Sub RunText(cn As MySqlConnection, sql As String)
        Using cmd As New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function SchemaStatements() As List(Of String)
        Dim asm = Assembly.GetExecutingAssembly()
        Dim resName = asm.GetManifestResourceNames().First(Function(n) n.EndsWith("schema.sql", StringComparison.OrdinalIgnoreCase))
        Dim text As String
        Using s = asm.GetManifestResourceStream(resName)
            Using r As New StreamReader(s)
                text = r.ReadToEnd()
            End Using
        End Using

        Dim sb As New StringBuilder()
        For Each line In text.Split(ControlChars.Lf)
            If line.TrimStart().StartsWith("--") Then Continue For
            sb.AppendLine(line)
        Next

        Dim result As New List(Of String)
        For Each part In sb.ToString().Split(";"c)
            Dim s = part.Trim()
            If s.Length = 0 Then Continue For
            ' The app creates/selects the configured database itself.
            If s.StartsWith("CREATE DATABASE", StringComparison.OrdinalIgnoreCase) Then Continue For
            If s.StartsWith("USE ", StringComparison.OrdinalIgnoreCase) Then Continue For
            result.Add(s)
        Next
        Return result
    End Function

    ' First run only: default administrator + a little sample data so the screens are not empty.
    Private Sub Seed(cn As MySqlConnection)
        Using cmd As New MySqlCommand("INSERT INTO Users (FullName, Username, Email, PasswordHash, Role, Status) VALUES ('System Administrator','admin','admin@shop.local',@h,'Administrator','Active')", cn)
            cmd.Parameters.AddWithValue("@h", PasswordHelper.HashPassword("Admin@123"))
            cmd.ExecuteNonQuery()
        End Using
        RunText(cn, "INSERT IGNORE INTO Categories (CategoryName, Description) VALUES ('Style','Bags, shoes and fashion'),('Electronics','Audio and gadgets'),('Study','Books and stationery'),('Tech','Computer accessories')")
        RunText(cn, "INSERT INTO Suppliers (SupplierName, PhoneNumber, Email) VALUES ('Nairobi Wholesalers','0711000111','sales@nairobiwholesalers.example'),('Campus Supplies Ltd','0722000222','info@campussupplies.example')")
        RunText(cn, "INSERT INTO Customers (FullName, PhoneNumber, Email) VALUES ('James Mwangi','0712345678','james@example.com'),('Grace Wanjiku','0723456789','grace@example.com'),('Peter Otieno','0734567890','peter@example.com')")
        RunText(cn, "INSERT INTO Products (ProductName, CategoryID, UnitPrice, QuantityInStock, ReorderLevel) VALUES " &
                    "('Campus Backpack',(SELECT CategoryID FROM Categories WHERE CategoryName='Style'),1200,50,10)," &
                    "('Headphones',(SELECT CategoryID FROM Categories WHERE CategoryName='Electronics'),1300,40,10)," &
                    "('Calculator',(SELECT CategoryID FROM Categories WHERE CategoryName='Study'),900,60,10)," &
                    "('Book',(SELECT CategoryID FROM Categories WHERE CategoryName='Study'),250,120,20)," &
                    "('Mouse',(SELECT CategoryID FROM Categories WHERE CategoryName='Tech'),800,70,10)," &
                    "('Sneakers',(SELECT CategoryID FROM Categories WHERE CategoryName='Style'),1800,45,10)")
        RunText(cn, "INSERT INTO StockMovements (ProductID, UserID, QuantityChange, Reason) SELECT ProductID, NULL, QuantityInStock, 'Opening stock' FROM Products")
    End Sub
End Module
