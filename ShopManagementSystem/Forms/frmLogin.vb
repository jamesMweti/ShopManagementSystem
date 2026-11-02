Imports System.Drawing
Imports System.Windows.Forms
Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim u As String = txtUsername.Text.Trim()
        Dim p As String = txtPassword.Text
        If u = "" OrElse p = "" Then
            Ui.Warn("Please enter both your username and password.")
            Return
        End If
        Try
            Dim dt = Db.Query("SELECT UserID, FullName, Username, PasswordHash, Role, Status FROM Users WHERE Username=@u", Db.P("@u", u))
            If dt.Rows.Count = 0 OrElse Not PasswordHelper.VerifyPassword(p, Convert.ToString(dt.Rows(0)("PasswordHash"))) Then
                Ui.Warn("Invalid username or password.")
                txtPassword.Clear()
                txtPassword.Focus()
                Return
            End If
            Dim row = dt.Rows(0)
            If Convert.ToString(row("Status")) <> "Active" Then
                Ui.Warn("This account is inactive. Please contact an administrator.")
                Return
            End If
            AppSession.SignIn(Convert.ToInt32(row("UserID")), Convert.ToString(row("FullName")), Convert.ToString(row("Username")), Convert.ToString(row("Role")))
            DialogResult = DialogResult.OK
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
        Using f As New frmSignUp()
            f.ShowDialog(Me)
            If f.CreatedUsername <> "" Then
                txtUsername.Text = f.CreatedUsername
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        End Using
    End Sub

End Class
