Imports System.Drawing
Imports System.Windows.Forms
Public Class frmSignUp

    Public CreatedUsername As String = ""

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim().ToLowerInvariant()
        Dim username As String = txtUsername.Text.Trim()
        Dim pw As String = txtPassword.Text

        If fullName = "" OrElse email = "" OrElse username = "" OrElse pw = "" OrElse txtConfirmPassword.Text = "" Then
            Ui.Warn("Please fill in all the fields.")
            Return
        End If
        If Not Validator.IsEmail(email) Then
            Ui.Warn("Please enter a valid email address.")
            txtEmail.Focus()
            Return
        End If
        If username.Length < 3 OrElse username.Contains(" ") Then
            Ui.Warn("Username must be at least 3 characters and contain no spaces.")
            txtUsername.Focus()
            Return
        End If
        Dim problem As String = Validator.PasswordProblem(pw)
        If problem <> "" Then
            Ui.Warn(problem)
            txtPassword.Focus()
            Return
        End If
        If pw <> txtConfirmPassword.Text Then
            Ui.Warn("The passwords do not match.")
            txtConfirmPassword.Focus()
            Return
        End If

        Try
            If Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Users WHERE Username=@u", Db.P("@u", username))) > 0 Then
                Ui.Warn("That username is already taken.")
                txtUsername.Focus()
                Return
            End If
            If Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Users WHERE Email=@e", Db.P("@e", email))) > 0 Then
                Ui.Warn("An account with that email already exists.")
                txtEmail.Focus()
                Return
            End If
            Db.Exec("INSERT INTO Users (FullName, Username, Email, PasswordHash, Role, Status) VALUES (@n,@u,@e,@h,'Cashier','Active')",
                    Db.P("@n", fullName), Db.P("@u", username), Db.P("@e", email), Db.P("@h", PasswordHelper.HashPassword(pw)))
            CreatedUsername = username
            Ui.Info("Account created successfully. You can now log in." & vbCrLf & "(New accounts get the Cashier role; an administrator can change it.)")
            Close()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Close()
    End Sub

End Class
