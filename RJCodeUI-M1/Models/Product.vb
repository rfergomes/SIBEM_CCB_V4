Namespace Models
    Public Class Product

        ''' <summary>
        ''' This class was created for testing purposes only,
        ''' the data may be inaccurate and meaningless.
        ''' </summary>
        '''  

        Public Property Id As Integer
        Public Property Item As String
        Public Property Stock As Integer
        Public Property UnitPrice As Double

        Public Sub New()
        End Sub

        Public Function GetProductsList() As List(Of Product)
            Dim list = New List(Of Product)()
            list.Add(New Product With {
                .Id = 1,
                .Item = "Baby Food",
                .Stock = 989,
                .UnitPrice = 19.98
            })
            list.Add(New Product With {
                .Id = 2,
                .Item = "Beverages",
                .Stock = 1589,
                .UnitPrice = 21.9
            })
            list.Add(New Product With {
                .Id = 3,
                .Item = "Cereal",
                .Stock = 1515,
                .UnitPrice = 9.56
            })
            list.Add(New Product With {
                .Id = 4,
                .Item = "Clothes",
                .Stock = 478,
                .UnitPrice = 54.65
            })
            list.Add(New Product With {
                .Id = 5,
                .Item = "Cosmetics",
                .Stock = 3659,
                .UnitPrice = 19.98
            })
            list.Add(New Product With {
                .Id = 6,
                .Item = "Fruits",
                .Stock = 456,
                .UnitPrice = 3.5
            })
            list.Add(New Product With {
                .Id = 7,
                .Item = "House Hold",
                .Stock = 2548,
                .UnitPrice = 11.55
            })
            list.Add(New Product With {
                .Id = 8,
                .Item = "Meat",
                .Stock = 325,
                .UnitPrice = 21.9
            })
            list.Add(New Product With {
                .Id = 9,
                .Item = "Office Supplies",
                .Stock = 6548,
                .UnitPrice = 8.69
            })
            list.Add(New Product With {
                .Id = 10,
                .Item = "Personal Care",
                .Stock = 2987,
                .UnitPrice = 17.45
            })
            list.Add(New Product With {
                .Id = 11,
                .Item = "Snacks",
                .Stock = 278,
                .UnitPrice = 3.9
            })
            list.Add(New Product With {
                .Id = 12,
                .Item = "Vegetables",
                .Stock = 198,
                .UnitPrice = 2.8
            })
            Return list
        End Function
    End Class
End Namespace