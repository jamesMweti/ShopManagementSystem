Imports System.Drawing
Imports System.Windows.Forms

''' <summary>Describes one input in a FieldDialog. Kind: text, email, phone, password, newpassword, memo, int, decimal, combo.</summary>
Public Class FieldDef
    Public Property Name As String
    Public Property Label As String
    Public Property Kind As String
    Public Property Required As Boolean
    Public Property Value As Object
    Public Property Options As List(Of ComboItem)
    Public Property Min As Decimal = 0
    Public Property Max As Decimal = 10000000
    Public Property MaxLength As Integer = 150

    Public Sub New(name As String, label As String, Optional kind As String = "text", Optional required As Boolean = False, Optional value As Object = Nothing)
        Me.Name = name
        Me.Label = label
        Me.Kind = kind
        Me.Required = required
        Me.Value = value
    End Sub
End Class

''' <summary>A reusable modal form that builds itself from a list of FieldDefs, validates, and returns the values.</summary>
Public Class FieldDialog
    Inherits Form

    Private ReadOnly _fields As List(Of FieldDef)
    Private ReadOnly _inputs As New Dictionary(Of String, Control)
    Public ReadOnly Property Result As New Dictionary(Of String, Object)

    Public Shared Function Ask(owner As IWin32Window, title As String, fields As List(Of FieldDef)) As Dictionary(Of String, Object)
        Using d As New FieldDialog(title, fields)
            If d.ShowDialog(owner) = DialogResult.OK Then Return d.Result
        End Using
        Return Nothing
    End Function

    Public Sub New(title As String, fields As List(Of FieldDef))
        _fields = fields
        Text = title
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterParent
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        Font = New Font("Segoe UI", 10)
        BackColor = Color.White

        Dim y As Integer = 16
        For Each f In fields
            Dim lbl As New Label()
            lbl.Text = f.Label & If(f.Required, " *", "")
            lbl.AutoSize = False
            Dim needed As Size = TextRenderer.MeasureText(lbl.Text, Font, New Size(380, 0), TextFormatFlags.WordBreak)
            lbl.SetBounds(20, y, 380, needed.Height + 4)
            Controls.Add(lbl)

            Dim ctl As Control = BuildInput(f)
            ctl.Left = 20
            ctl.Top = y + lbl.Height + 4
            ctl.Width = 380
            Controls.Add(ctl)
            _inputs(f.Name) = ctl
            y += lbl.Height + 4 + ctl.Height + 12
        Next

        Dim btnOk = Ui.MakeButton("Save", Theme.Green, 120)
        btnOk.Location = New Point(160, y + 6)
        AddHandler btnOk.Click, AddressOf OnOk
        Dim btnCancel = Ui.MakeButton("Cancel", Color.Gray, 120)
        btnCancel.Location = New Point(290, y + 6)
        btnCancel.DialogResult = DialogResult.Cancel
        Controls.Add(btnOk)
        Controls.Add(btnCancel)
        AcceptButton = btnOk
        CancelButton = btnCancel
        ClientSize = New Size(420, y + 62)
    End Sub

    Private Function BuildInput(f As FieldDef) As Control
        Select Case f.Kind
            Case "int", "decimal"
                Dim n As New NumericUpDown()
                n.DecimalPlaces = If(f.Kind = "decimal", 2, 0)
                n.Minimum = f.Min
                n.Maximum = f.Max
                n.ThousandsSeparator = True
                Dim v As Decimal = 0
                If f.Value IsNot Nothing AndAlso Not IsDBNull(f.Value) Then v = Convert.ToDecimal(f.Value)
                n.Value = Math.Min(Math.Max(v, n.Minimum), n.Maximum)
                Return n
            Case "combo"
                Dim cb As New ComboBox()
                cb.DropDownStyle = ComboBoxStyle.DropDownList
                If f.Options IsNot Nothing Then
                    For Each it In f.Options
                        cb.Items.Add(it)
                    Next
                    Dim wanted As String = If(f.Value Is Nothing OrElse IsDBNull(f.Value), "", Convert.ToString(f.Value))
                    For Each it As ComboItem In cb.Items
                        Dim itv As String = If(it.Value Is Nothing, "", Convert.ToString(it.Value))
                        If itv = wanted Then
                            cb.SelectedItem = it
                            Exit For
                        End If
                    Next
                    If cb.SelectedItem Is Nothing AndAlso Not f.Required AndAlso cb.Items.Count > 0 Then cb.SelectedIndex = 0
                End If
                Return cb
            Case Else
                Dim t As New TextBox()
                t.MaxLength = f.MaxLength
                If f.Kind = "password" OrElse f.Kind = "newpassword" Then t.UseSystemPasswordChar = True
                If f.Kind = "memo" Then
                    t.Multiline = True
                    t.Height = 70
                    t.ScrollBars = ScrollBars.Vertical
                End If
                If f.Value IsNot Nothing AndAlso Not IsDBNull(f.Value) Then t.Text = Convert.ToString(f.Value)
                Return t
        End Select
    End Function

    Private Sub OnOk(sender As Object, e As EventArgs)
        If Collect() Then DialogResult = DialogResult.OK
    End Sub

    Private Function Fail(message As String, c As Control) As Boolean
        Ui.Warn(message)
        c.Focus()
        Return False
    End Function

    Private Function Collect() As Boolean
        Result.Clear()
        For Each f In _fields
            Dim c = _inputs(f.Name)
            Select Case f.Kind
                Case "int"
                    Result(f.Name) = CInt(DirectCast(c, NumericUpDown).Value)
                Case "decimal"
                    Result(f.Name) = DirectCast(c, NumericUpDown).Value
                Case "combo"
                    Dim cb = DirectCast(c, ComboBox)
                    If cb.SelectedItem Is Nothing Then
                        If f.Required Then Return Fail("Please select a value for '" & f.Label & "'.", c)
                        Result(f.Name) = Nothing
                    Else
                        Dim it = DirectCast(cb.SelectedItem, ComboItem)
                        If f.Required AndAlso it.Value Is Nothing Then Return Fail("Please select a value for '" & f.Label & "'.", c)
                        Result(f.Name) = it.Value
                    End If
                Case Else
                    Dim isPw As Boolean = (f.Kind = "password" OrElse f.Kind = "newpassword")
                    Dim t As String = If(isPw, c.Text, c.Text.Trim())
                    If f.Required AndAlso t.Length = 0 Then Return Fail(f.Label & " is required.", c)
                    If t.Length > 0 Then
                        If f.Kind = "email" AndAlso Not Validator.IsEmail(t) Then Return Fail("Please enter a valid email address.", c)
                        If f.Kind = "phone" AndAlso Not Validator.IsPhone(t) Then Return Fail("Please enter a valid phone number (7-15 digits).", c)
                        If f.Kind = "newpassword" Then
                            Dim problem As String = Validator.PasswordProblem(t)
                            If problem <> "" Then Return Fail(problem, c)
                        End If
                    End If
                    If f.Kind = "email" Then t = t.ToLowerInvariant()
                    Result(f.Name) = t
            End Select
        Next
        Return True
    End Function
End Class
