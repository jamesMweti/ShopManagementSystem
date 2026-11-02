Imports System.Windows.Forms

Public Module Program

    <STAThread>
    Public Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' 1) Connect to MySQL (creating the database and tables on first run).
        Do
            Try
                Db.EnsureDatabase()
                Exit Do
            Catch ex As Exception
                Dim answer = MessageBox.Show("Could not connect to the MySQL database:" & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf &
                                             "Make sure MySQL Server is installed and running, then check the connection settings." & vbCrLf & vbCrLf &
                                             "Edit the connection settings now?",
                                             Ui.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If answer <> DialogResult.Yes Then Return
                ConfigureDatabase()
            End Try
        Loop

        ' 2) Login -> main window. Logging out returns to the login screen.
        Do
            Dim loggedIn As Boolean
            Using lf As New frmLogin()
                loggedIn = (lf.ShowDialog() = DialogResult.OK)
            End Using
            If Not loggedIn Then Exit Do

            Dim mf As New frmMain()
            Application.Run(mf)
            If Not mf.LoggedOut Then Exit Do
        Loop
    End Sub

    Private Sub ConfigureDatabase()
        Dim c = Db.Config
        Dim r = FieldDialog.Ask(Nothing, "MySQL Connection Settings", New List(Of FieldDef) From {
            New FieldDef("server", "Server / host", "text", True, c.Server),
            New FieldDef("port", "Port", "int", True, c.Port) With {.Min = 1, .Max = 65535},
            New FieldDef("user", "MySQL user name", "text", True, c.User),
            New FieldDef("password", "MySQL password", "password", False, c.Password),
            New FieldDef("database", "Database name", "text", True, c.Database)
        })
        If r Is Nothing Then Return
        c.Server = CStr(r("server"))
        c.Port = CInt(r("port"))
        c.User = CStr(r("user"))
        c.Password = CStr(r("password"))
        c.Database = CStr(r("database"))
        Db.SaveConfig()
    End Sub

End Module
