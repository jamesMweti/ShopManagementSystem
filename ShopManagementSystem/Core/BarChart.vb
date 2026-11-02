Imports System.Drawing
Imports System.Windows.Forms

''' <summary>A small self-drawn column chart (no extra libraries needed).</summary>
Public Class BarChart
    Inherits Control

    Public Property ChartTitle As String = ""
    Private _labels As New List(Of String)
    Private _values As New List(Of Decimal)

    Public Sub New()
        DoubleBuffered = True
        ResizeRedraw = True
        BackColor = Color.White
        Font = New Font("Segoe UI", 8.5F)
    End Sub

    Public Sub SetData(labels As IEnumerable(Of String), values As IEnumerable(Of Decimal))
        _labels = labels.ToList()
        _values = values.ToList()
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim top As Integer = 8
        If ChartTitle <> "" Then
            Using f As New Font("Segoe UI", 11, FontStyle.Bold)
                g.DrawString(ChartTitle, f, Brushes.Black, 4, 2)
            End Using
            top = 34
        End If

        Dim plot As New Rectangle(46, top, Width - 56, Height - top - 26)
        If plot.Width < 20 OrElse plot.Height < 20 Then Return

        If _values.Count = 0 Then
            Using sf As New StringFormat()
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
                g.DrawString("No data to display", Font, Brushes.Gray, New RectangleF(plot.X, plot.Y, plot.Width, plot.Height), sf)
            End Using
            Return
        End If

        Dim maxV As Decimal = NiceMax(_values.Max())

        Using gridPen As New Pen(Color.FromArgb(225, 225, 225))
            For i As Integer = 0 To 5
                Dim y As Integer = plot.Bottom - CInt(plot.Height * i / 5)
                g.DrawLine(gridPen, plot.Left, y, plot.Right, y)
                Dim txt As String = FormatTick(maxV * i / 5D)
                Dim sz = g.MeasureString(txt, Font)
                g.DrawString(txt, Font, Brushes.Black, plot.Left - sz.Width - 2, y - sz.Height / 2)
            Next
        End Using

        Dim slot As Double = plot.Width / _values.Count
        Dim barW As Integer = Math.Max(4, CInt(slot * 0.6))
        Using br As New SolidBrush(Theme.Green)
            Using sf As New StringFormat()
                sf.Alignment = StringAlignment.Center
                sf.Trimming = StringTrimming.EllipsisCharacter
                sf.FormatFlags = StringFormatFlags.NoWrap
                For i As Integer = 0 To _values.Count - 1
                    Dim h As Integer = CInt(plot.Height * (CDbl(_values(i)) / CDbl(maxV)))
                    Dim x As Integer = CInt(plot.Left + slot * i + (slot - barW) / 2)
                    g.FillRectangle(br, x, plot.Bottom - h, barW, h)
                    g.DrawString(_labels(i), Font, Brushes.Black, New RectangleF(CSng(plot.Left + slot * i), plot.Bottom + 3, CSng(slot), 20), sf)
                Next
            End Using
        End Using
    End Sub

    Private Shared Function NiceMax(v As Decimal) As Decimal
        If v <= 0 Then Return 1D
        Dim p As Double = Math.Pow(10, Math.Floor(Math.Log10(CDbl(v))))
        Dim f As Double = CDbl(v) / p
        Dim nf As Double = If(f <= 1, 1, If(f <= 2, 2, If(f <= 5, 5, 10)))
        Return CDec(nf * p)
    End Function

    Private Shared Function FormatTick(v As Decimal) As String
        If v >= 1000 Then Return (v / 1000D).ToString("0.#") & "k"
        Return v.ToString("0.##")
    End Function
End Class
