Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class ucDashboard
    Implements IScreen

    Public Sub New()
        InitializeComponent()
        Ui.StyleGrid(dgvTopProducts)
    End Sub

    Public Sub LoadData() Implements IScreen.LoadData
        lblWelcome.Text = "Welcome, " & AppSession.User.FullName & "!"
        lblDate.Text = "📅  " & Date.Today.ToString("ddd, MMM d, yyyy")

        lblTotalSalesValue.Text = Ui.Money(Db.Scalar("SELECT IFNULL(SUM(Total),0) FROM Sales"))
        lblProductsValue.Text = Convert.ToString(Db.Scalar("SELECT COUNT(*) FROM Products"))
        lblCustomersValue.Text = Convert.ToString(Db.Scalar("SELECT COUNT(*) FROM Customers"))
        lblLowStockValue.Text = Convert.ToString(Db.Scalar("SELECT COUNT(*) FROM Products WHERE QuantityInStock <= ReorderLevel"))

        ' Sales for the last 7 days (days without sales show as 0)
        Dim startDay As Date = Date.Today.AddDays(-6)
        Dim dt = Db.Query("SELECT DATE_FORMAT(SaleDate,'%Y-%m-%d') AS D, SUM(Total) AS T FROM Sales WHERE SaleDate >= @s GROUP BY DATE_FORMAT(SaleDate,'%Y-%m-%d')", Db.P("@s", startDay))
        Dim map As New Dictionary(Of String, Decimal)
        For Each r As DataRow In dt.Rows
            map(Convert.ToString(r("D"))) = Convert.ToDecimal(r("T"))
        Next
        Dim labels As New List(Of String)
        Dim values As New List(Of Decimal)
        For i As Integer = 0 To 6
            Dim d As Date = startDay.AddDays(i)
            Dim v As Decimal = 0
            map.TryGetValue(d.ToString("yyyy-MM-dd"), v)
            labels.Add(d.ToString("ddd"))
            values.Add(v)
        Next
        chtSalesOverview.SetData(labels, values)

        ' Top 5 products by quantity sold
        Dim top = Db.Query("SELECT p.ProductName AS Product, SUM(si.Quantity) AS Sold FROM SaleItems si JOIN Products p ON p.ProductID = si.ProductID GROUP BY p.ProductID, p.ProductName ORDER BY Sold DESC LIMIT 5")
        Dim ranked As New DataTable()
        ranked.Columns.Add("#", GetType(Integer))
        ranked.Columns.Add("Product", GetType(String))
        ranked.Columns.Add("Sold", GetType(Integer))
        Dim n As Integer = 1
        For Each r As DataRow In top.Rows
            ranked.Rows.Add(n, Convert.ToString(r("Product")), Convert.ToInt32(r("Sold")))
            n += 1
        Next
        dgvTopProducts.DataSource = ranked
        dgvTopProducts.Columns("#").FillWeight = 20
    End Sub

End Class
