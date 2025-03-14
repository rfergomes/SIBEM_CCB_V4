Public Class FormDataControls
    Inherits RJChildForm

    Private analysis As Models.SalesAnalysis = New Models.SalesAnalysis()

    Public Sub New()
        InitializeComponent()
        LoadDatagridviewData()
        LoadChartData()
    End Sub

    Private Sub LoadDatagridviewData()
        rjDataGridView1.Rows.Add("Amethyst", " Johns", "19")
        rjDataGridView1.Rows.Add("Leandra", " Copeland", "21")
        rjDataGridView1.Rows.Add("Susan", " Keith", "45")
        rjDataGridView1.Rows.Add("Odysseus", " Matthews", "28")
        rjDataGridView1.Rows.Add("Bianca ", "Goodman", "36")
        rjDataGridView2.Rows.Add("Amethyst", " Johns", "19")
        rjDataGridView2.Rows.Add("Leandra", " Copeland", "21")
        rjDataGridView2.Rows.Add("Susan", " Keith", "45")
        rjDataGridView2.Rows.Add("Odysseus", " Matthews", "28")
        rjDataGridView2.Rows.Add("Bianca ", "Goodman", "36")
        Dim list = New Models.Product().GetProductsList().Take(5).ToList()
        rjDataGridView3.DataSource = list
    End Sub

    Private Sub LoadChartData()
        Dim salesRevenue2 = New List(Of Models.SalesAnalysis.SalesRevenue)()
        Dim salesRevenue3 = New List(Of Models.SalesAnalysis.SalesRevenue)()
        Dim sum As Boolean = False

        For Each item In analysis.SalesRevenueList

            If sum = True Then
                salesRevenue2.Add(New Models.SalesAnalysis.SalesRevenue With {
                    .DateOrTime = item.DateOrTime,
                    .Revenue = item.Revenue + 450000
                })
                sum = False
            Else
                salesRevenue2.Add(New Models.SalesAnalysis.SalesRevenue With {
                    .DateOrTime = item.DateOrTime,
                    .Revenue = item.Revenue - 450000
                })
                sum = True
            End If
        Next

        For Each item In analysis.SalesRevenueList
            salesRevenue3.Add(New Models.SalesAnalysis.SalesRevenue With {
                .DateOrTime = item.DateOrTime,
                .Revenue = item.Revenue - 250000
            })
        Next

        rjChart1.Series(0).Points.DataBind(analysis.SalesRevenueList, "DateOrTime", "Revenue", "")
        rjChart1.Series(1).Points.DataBind(salesRevenue2, "DateOrTime", "Revenue", "")
        rjChart1.Series(2).Points.DataBind(salesRevenue3, "DateOrTime", "Revenue", "")
        rjChart2.Series(0).Points.DataBind(analysis.SalesByCategoryList, "Item", "UnitSold", "")
    End Sub
End Class