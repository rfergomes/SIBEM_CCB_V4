Namespace Models
    Public Class SalesAnalysis

        ''' <summary>
        ''' This class was created for testing purposes only,
        ''' the data may be inaccurate and meaningless.
        ''' </summary>
        '''  

        Private order As SalesOrder

        Public Structure SalesRevenue
            Public Property DateOrTime As String
            Public Property Revenue As Double
        End Structure

        Public Structure SalesByCategory
            Public Property Item As String
            Public Property UnitSold As Double
        End Structure

        Public Structure BestProduct
            Public Property Item As String
            Public Property UnitSold As Double
        End Structure

        Public Structure NumberSales
            Public Property DateOrTime As String
            Public Property UnitSold As Double
        End Structure

        Public Property NumberCustomers As Integer
        Public Property TotalNumberSales As Integer
        Public Property Revenue As Double
        Public Property Profit As Double
        Public Property Cost As Double
        Public Property SalesRevenueList As List(Of SalesRevenue)
        Public Property SalesByCategoryList As List(Of SalesByCategory)
        Public Property Top5ProductsList As List(Of BestProduct)
        Public Property NumberSalesList As List(Of NumberSales)

        Public Sub New()
            order = New SalesOrder()
            GetTotalNumberSales()
            GetRevenue()
            GetCost()
            GetProfit()
            GetCustomers()
            GetSalesRevenue()
            GetNumberSales()
            GetSalesByCategory()
            GetTop5Products()
        End Sub

        Private Sub GetCustomers()
            NumberCustomers = New Customer().GetCustomerList().Count
        End Sub

        Private Sub GetTotalNumberSales()
            TotalNumberSales = order.GetSalesList().Count
        End Sub

        Private Sub GetRevenue()
            Revenue = Math.Round(order.GetSalesList().Sum(Function(sale) sale.TotalRevenue), 2)
        End Sub

        Private Sub GetCost()
            Cost = Math.Round(Revenue - (Revenue * 0.3), 2)
        End Sub

        Private Sub GetProfit()
            Profit = Math.Round(Revenue - Cost, 2)
        End Sub

        Public Sub GetSalesRevenue()
            SalesRevenueList = (From salesList In order.GetSalesList()
                                Group salesList By keyDateGroup = salesList.OrderDate.ToString("MMMM")
                                Into sales = Group Select New SalesRevenue With {
                .DateOrTime = keyDateGroup,
                .Revenue = Math.Round(sales.Sum(Function(item) item.TotalRevenue), 2)
            }).ToList()
        End Sub

        Private Sub GetNumberSales()
            NumberSalesList = (From salesList In order.GetSalesList()
                               Group salesList By keyDateGroup = salesList.OrderDate.ToString("MMMM")
                               Into sales = Group Select New NumberSales With {
                .DateOrTime = keyDateGroup,
                .UnitSold = sales.Sum(Function(item) item.UnitSold)
            }).ToList()
        End Sub

        Private Sub GetSalesByCategory()
            SalesByCategoryList = (From salesList In order.GetSalesList()
                                   Group salesList.UnitSold By keyItemGroup = salesList.ItemType
                                   Into sales = Group Select New SalesByCategory With {
                .Item = keyItemGroup,
                .UnitSold = sales.Sum()
            }).ToList()
        End Sub

        Private Sub GetTop5Products()
            Top5ProductsList = (From salesList In order.GetSalesList()
                                Group salesList.UnitSold By keyItemGroup = salesList.ItemType
                                Into sales = Group Select New BestProduct With {
                .Item = keyItemGroup,
                .UnitSold = sales.Sum()
            }).Take(5).ToList()
        End Sub
    End Class
End Namespace

