Imports PROJETOBASE.Models

Public Class FormDashboard_Cópia
    Inherits RJChildForm

    Private analysis As SalesAnalysis = New SalesAnalysis()

    Public Sub New()
        InitializeComponent()
        Dim categories = New List(Of SalesAnalysis.SalesByCategory)()
        categories.AddRange(analysis.SalesByCategoryList)
        categories.Add(New SalesAnalysis.SalesByCategory With {
            .Item = "All"
        })
        cbCategory.DataSource = categories
        cbCategory.DisplayMember = "Item"
        cbCategory.SelectedIndex = categories.Count - 1
        cbPeriod.SelectedIndex = 4

        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        lblNumberSales.Text = analysis.TotalNumberSales.ToString()
        lblRevenue.Text = analysis.Revenue.ToString("C0")
        lblProfit.Text = analysis.Profit.ToString("C0")
        lblCost.Text = analysis.Cost.ToString("C0")
        lblNumberCustomers.Text = analysis.NumberCustomers.ToString()
        chartRevenue.Series(0).Points.DataBind(analysis.SalesRevenueList, "DateOrTime", "Revenue", "")
        chartSalesByCategory.Series(0).Points.DataBind(analysis.SalesByCategoryList, "Item", "UnitSold", "")
        chartNumberSales.Series(0).Points.DataBind(analysis.NumberSalesList, "DateOrTime", "UnitSold", "")
        chartNumberSales.Series(1).Points.DataBind(analysis.NumberSalesList, "DateOrTime", "UnitSold", "")
        chartTop5Products.Series(0).Points.DataBind(analysis.Top5ProductsList, "Item", "UnitSold", "")
    End Sub
End Class