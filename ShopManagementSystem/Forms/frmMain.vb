Imports System.Drawing
Imports System.Windows.Forms
''' <summary>Main window: the green sidebar (buttons you can edit in the designer) + a content area that shows one screen at a time.</summary>
Public Class frmMain

    Public LoggedOut As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide sidebar buttons the signed-in role may not use. Button names are "btn" + screen name.
        For Each c As Control In flpNav.Controls
            Dim b = TryCast(c, Button)
            If b IsNot Nothing Then b.Visible = AppSession.CanAccess(b.Name.Substring(3))
        Next
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Navigate("Dashboard")
    End Sub

    Private Sub NavButton_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnProducts.Click, btnCategories.Click, btnCustomers.Click, btnSuppliers.Click, btnSales.Click, btnInventory.Click, btnReports.Click, btnUsers.Click, btnSettings.Click, btnLogout.Click
        Navigate(DirectCast(sender, Button).Name.Substring(3))
    End Sub

    Private Sub Navigate(key As String)
        If key = "Logout" Then
            If Ui.Confirm("Are you sure you want to log out?") Then
                LoggedOut = True
                AppSession.SignOut()
                Close()
            End If
            Return
        End If

        Dim screen As UserControl = CreateScreen(key)
        If screen Is Nothing Then Return
        screen.Dock = DockStyle.Fill

        pnlContent.SuspendLayout()
        For Each c As Control In pnlContent.Controls.Cast(Of Control).ToList()
            pnlContent.Controls.Remove(c)
            c.Dispose()
        Next
        pnlContent.Controls.Add(screen)
        pnlContent.ResumeLayout()

        ' Highlight the active button
        For Each c As Control In flpNav.Controls
            Dim b = TryCast(c, Button)
            If b Is Nothing Then Continue For
            Dim active As Boolean = (b.Name = "btn" & key)
            b.BackColor = If(active, Theme.Gold, Color.RebeccaPurple)
            b.ForeColor = If(active, Color.RebeccaPurple, Color.White)
        Next
        Text = "Shop Management System - " & key

        Ui.Run(Sub() DirectCast(screen, IScreen).LoadData())
    End Sub

    Private Function CreateScreen(key As String) As UserControl
        Select Case key
            Case "Dashboard" : Return New ucDashboard()
            Case "Products" : Return New ucProducts()
            Case "Categories" : Return New ucCategories()
            Case "Customers" : Return New ucCustomers()
            Case "Suppliers" : Return New ucSuppliers()
            Case "Sales" : Return New ucSales()
            Case "Inventory" : Return New ucInventory()
            Case "Reports" : Return New ucReports()
            Case "Users" : Return New ucUsers()
            Case "Settings" : Return New ucSettings()
        End Select
        Return Nothing
    End Function

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not LoggedOut AndAlso e.CloseReason = CloseReason.UserClosing Then
            If Not Ui.Confirm("Exit Shop Management System?") Then e.Cancel = True
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult.Yes = answer Then
            Application.Exit()
        End If

    End Sub
End Class
