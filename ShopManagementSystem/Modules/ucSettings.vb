Imports System.Drawing
Imports System.Windows.Forms
Public Class ucSettings
    Implements IScreen

    Public Sub LoadData() Implements IScreen.LoadData
        lblSubtitle.Text = "Signed in as " & AppSession.User.FullName & " (" & AppSession.User.Role & ")"
        grpShop.Visible = AppSession.IsAdmin
        If AppSession.IsAdmin Then txtShopName.Text = Db.GetSetting("ShopName", "My Shop")
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Try
            If txtCurrent.Text = "" OrElse txtNew.Text = "" OrElse txtConfirm.Text = "" Then
                Ui.Warn("Please fill in all the password fields.")
                Return
            End If
            Dim stored = Convert.ToString(Db.Scalar("SELECT PasswordHash FROM Users WHERE UserID=@id", Db.P("@id", AppSession.User.UserID)))
            If Not PasswordHelper.VerifyPassword(txtCurrent.Text, stored) Then
                Ui.Warn("Your current password is incorrect.")
                Return
            End If
            Dim problem = Validator.PasswordProblem(txtNew.Text)
            If problem <> "" Then
                Ui.Warn(problem)
                Return
            End If
            If txtNew.Text <> txtConfirm.Text Then
                Ui.Warn("The new passwords do not match.")
                Return
            End If
            Db.Exec("UPDATE Users SET PasswordHash=@h WHERE UserID=@id", Db.P("@h", PasswordHelper.HashPassword(txtNew.Text)), Db.P("@id", AppSession.User.UserID))
            txtCurrent.Clear()
            txtNew.Clear()
            txtConfirm.Clear()
            Ui.Info("Password updated.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnSaveShop_Click(sender As Object, e As EventArgs) Handles btnSaveShop.Click
        Try
            If txtShopName.Text.Trim() = "" Then
                Ui.Warn("The shop name cannot be empty.")
                Return
            End If
            Db.SetSetting("ShopName", txtShopName.Text.Trim())
            Ui.Info("Shop details saved.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub
End Class
