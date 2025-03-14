
Imports System.ComponentModel

Namespace Models

    Public Class SalesOrder

        ''' <summary>
        ''' This class was created for testing purposes only,
        ''' the data may be inaccurate and meaningless.
        ''' </summary>
        '''  

        Private _itemType As String
        Private _orderDate As DateTime
        Private _orderId As String
        Private _unitSold As Integer
        Private _unitPrice As Double
        Private _totalRevenue As Double
        Public Property Number As Integer

        <DisplayName("Product")>
        Public Property ItemType As String
            Get
                Return _itemType
            End Get
            Set(value As String)
                _itemType = value
            End Set
        End Property

        <DisplayName("Order date")>
        Public Property OrderDate As DateTime
            Get
                Return _orderDate
            End Get
            Set(value As DateTime)
                _orderDate = value
            End Set
        End Property

        <DisplayName("Order ID")>
        Public Property OrderId As String
            Get
                Return _orderId
            End Get
            Set(value As String)
                _orderId = value
            End Set
        End Property

        <DisplayName("Unit sold")>
        Public Property UnitSold As Integer
            Get
                Return _unitSold
            End Get
            Set(value As Integer)
                _unitSold = value
            End Set
        End Property

        <DisplayName("Unit price")>
        Public Property UnitPrice As Double
            Get
                Return _unitPrice
            End Get
            Set(value As Double)
                _unitPrice = value
            End Set
        End Property

        <DisplayName("Total revenue")>
        Public Property TotalRevenue As Double
            Get
                Return _totalRevenue
            End Get
            Set(value As Double)
                _totalRevenue = value
            End Set
        End Property

        Public Function GetSalesList() As List(Of SalesOrder)
            Dim list = New List(Of SalesOrder)()
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 1, 1),
                ._orderId = "329530894",
                ._unitSold = 44,
                ._unitPrice = 154.06,
                ._totalRevenue = 6730.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 1, 2),
                ._orderId = "515616118",
                ._unitSold = 44,
                ._unitPrice = 47.45,
                ._totalRevenue = 2073.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 1, 3),
                ._orderId = "386600577",
                ._unitSold = 159,
                ._unitPrice = 437.2,
                ._totalRevenue = 19101.27
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 1, 4),
                ._orderId = "256994950",
                ._unitSold = 44,
                ._unitPrice = 668.27,
                ._totalRevenue = 29196.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 1, 5),
                ._orderId = "967328870",
                ._unitSold = 44,
                ._unitPrice = 81.73,
                ._totalRevenue = 3570.78
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 1, 6),
                ._orderId = "480863702",
                ._unitSold = 44,
                ._unitPrice = 421.89,
                ._totalRevenue = 18432.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 1, 7),
                ._orderId = "131482589",
                ._unitSold = 44,
                ._unitPrice = 154.06,
                ._totalRevenue = 6730.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 1, 8),
                ._orderId = "546986377",
                ._unitSold = 44,
                ._unitPrice = 152.58,
                ._totalRevenue = 6666.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 1, 9),
                ._orderId = "812613904",
                ._unitSold = 94,
                ._unitPrice = 47.45,
                ._totalRevenue = 4444.64
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 1, 10),
                ._orderId = "936042296",
                ._unitSold = 46,
                ._unitPrice = 47.45,
                ._totalRevenue = 2168.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 1, 11),
                ._orderId = "403961122",
                ._unitSold = 99,
                ._unitPrice = 437.2,
                ._totalRevenue = 43405.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 1, 12),
                ._orderId = "521445310",
                ._unitSold = 61,
                ._unitPrice = 668.27,
                ._totalRevenue = 40831.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 1, 13),
                ._orderId = "921992242",
                ._unitSold = 68,
                ._unitPrice = 81.73,
                ._totalRevenue = 5596.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 1, 13),
                ._orderId = "607757937",
                ._unitSold = 79,
                ._unitPrice = 9.33,
                ._totalRevenue = 740.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 1, 13),
                ._orderId = "607521903",
                ._unitSold = 81,
                ._unitPrice = 421.89,
                ._totalRevenue = 34114.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 1, 13),
                ._orderId = "731972110",
                ._unitSold = 57,
                ._unitPrice = 651.21,
                ._totalRevenue = 36910.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 1, 14),
                ._orderId = "220003211",
                ._unitSold = 27,
                ._unitPrice = 152.58,
                ._totalRevenue = 4110.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 1, 15),
                ._orderId = "494525372",
                ._unitSold = 99,
                ._unitPrice = 668.27,
                ._totalRevenue = 66172.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 1, 16),
                ._orderId = "157542073",
                ._unitSold = 91,
                ._unitPrice = 668.27,
                ._totalRevenue = 60511.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 1, 17),
                ._orderId = "670613467",
                ._unitSold = 83,
                ._unitPrice = 47.45,
                ._totalRevenue = 3929.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 1, 18),
                ._orderId = "769205892",
                ._unitSold = 40,
                ._unitPrice = 9.33,
                ._totalRevenue = 370.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 1, 18),
                ._orderId = "600124156",
                ._unitSold = 89,
                ._unitPrice = 152.58,
                ._totalRevenue = 13623.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 1, 18),
                ._orderId = "531405103",
                ._unitSold = 34,
                ._unitPrice = 154.06,
                ._totalRevenue = 5290.42
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 1, 19),
                ._orderId = "861462724",
                ._unitSold = 48,
                ._unitPrice = 9.33,
                ._totalRevenue = 449.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 1, 20),
                ._orderId = "732211148",
                ._unitSold = 64,
                ._unitPrice = 152.58,
                ._totalRevenue = 9772.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 1, 21),
                ._orderId = "320368897",
                ._unitSold = 31,
                ._unitPrice = 651.21,
                ._totalRevenue = 20389.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 1, 22),
                ._orderId = "160299813",
                ._unitSold = 51,
                ._unitPrice = 205.7,
                ._totalRevenue = 10556.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 1, 23),
                ._orderId = "393693625",
                ._unitSold = 15,
                ._unitPrice = 47.45,
                ._totalRevenue = 734.05
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 1, 23),
                ._orderId = "989928519",
                ._unitSold = 7,
                ._unitPrice = 651.21,
                ._totalRevenue = 4571.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 1, 23),
                ._orderId = "126767909",
                ._unitSold = 23,
                ._unitPrice = 109.28,
                ._totalRevenue = 2509.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 1, 24),
                ._orderId = "221975171",
                ._unitSold = 62,
                ._unitPrice = 205.7,
                ._totalRevenue = 12837.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 1, 25),
                ._orderId = "161442649",
                ._unitSold = 33,
                ._unitPrice = 205.7,
                ._totalRevenue = 6833.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 1, 26),
                ._orderId = "907513463",
                ._unitSold = 23,
                ._unitPrice = 109.28,
                ._totalRevenue = 2465.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 1, 27),
                ._orderId = "611816871",
                ._unitSold = 91,
                ._unitPrice = 651.21,
                ._totalRevenue = 59019.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 1, 28),
                ._orderId = "559352862",
                ._unitSold = 380,
                ._unitPrice = 81.73,
                ._totalRevenue = 3103.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 1, 29),
                ._orderId = "151839911",
                ._unitSold = 17,
                ._unitPrice = 437.2,
                ._totalRevenue = 7253.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 1, 30),
                ._orderId = "852176702",
                ._unitSold = 69,
                ._unitPrice = 668.27,
                ._totalRevenue = 45963.61
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 1, 31),
                ._orderId = "534085166",
                ._unitSold = 65,
                ._unitPrice = 152.58,
                ._totalRevenue = 9954.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 2, 1),
                ._orderId = "942700612",
                ._unitSold = 49,
                ._unitPrice = 47.45,
                ._totalRevenue = 2332.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 2, 2),
                ._orderId = "375630986",
                ._unitSold = 64,
                ._unitPrice = 255.28,
                ._totalRevenue = 16366.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 2, 2),
                ._orderId = "211114585",
                ._unitSold = 24,
                ._unitPrice = 651.21,
                ._totalRevenue = 15316.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 2, 2),
                ._orderId = "624295365",
                ._unitSold = 17,
                ._unitPrice = 9.33,
                ._totalRevenue = 161.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 2, 2),
                ._orderId = "181045520",
                ._unitSold = 42,
                ._unitPrice = 205.7,
                ._totalRevenue = 8736.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 2, 2),
                ._orderId = "409873998",
                ._unitSold = 97,
                ._unitPrice = 437.2,
                ._totalRevenue = 42316.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 2, 3),
                ._orderId = "109966123",
                ._unitSold = 3,
                ._unitPrice = 9.33,
                ._totalRevenue = 25.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 4),
                ._orderId = "411448562",
                ._unitSold = 56,
                ._unitPrice = 154.06,
                ._totalRevenue = 8670.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 2, 5),
                ._orderId = "453089320",
                ._unitSold = 81,
                ._unitPrice = 437.2,
                ._totalRevenue = 35207.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 6),
                ._orderId = "325412309",
                ._unitSold = 56,
                ._unitPrice = 152.58,
                ._totalRevenue = 8526.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 2, 7),
                ._orderId = "901180875",
                ._unitSold = 83,
                ._unitPrice = 205.7,
                ._totalRevenue = 17077.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 7),
                ._orderId = "958840644",
                ._unitSold = 11,
                ._unitPrice = 152.58,
                ._totalRevenue = 1692.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 2, 7),
                ._orderId = "985092818",
                ._unitSold = 97,
                ._unitPrice = 47.45,
                ._totalRevenue = 4607.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 2, 8),
                ._orderId = "304750287",
                ._unitSold = 120,
                ._unitPrice = 437.2,
                ._totalRevenue = 5408.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 9),
                ._orderId = "620441138",
                ._unitSold = 12,
                ._unitPrice = 154.06,
                ._totalRevenue = 1810.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 10),
                ._orderId = "909053695",
                ._unitSold = 80,
                ._unitPrice = 152.58,
                ._totalRevenue = 12273.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 2, 11),
                ._orderId = "706399714",
                ._unitSold = 82,
                ._unitPrice = 109.28,
                ._totalRevenue = 8991.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 12),
                ._orderId = "363276517",
                ._unitSold = 4,
                ._unitPrice = 152.58,
                ._totalRevenue = 685.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 12),
                ._orderId = "285662829",
                ._unitSold = 28,
                ._unitPrice = 81.73,
                ._totalRevenue = 2316.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 12),
                ._orderId = "496897733",
                ._unitSold = 19,
                ._unitPrice = 81.73,
                ._totalRevenue = 1582.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 2, 13),
                ._orderId = "953293836",
                ._unitSold = 97,
                ._unitPrice = 651.21,
                ._totalRevenue = 63069.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 2, 14),
                ._orderId = "944635236",
                ._unitSold = 74,
                ._unitPrice = 651.21,
                ._totalRevenue = 48274.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 15),
                ._orderId = "977499377",
                ._unitSold = 26,
                ._unitPrice = 152.58,
                ._totalRevenue = 4032.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 2, 16),
                ._orderId = "448685348",
                ._unitSold = 48,
                ._unitPrice = 109.28,
                ._totalRevenue = 5267.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 2, 17),
                ._orderId = "450849997",
                ._unitSold = 54,
                ._unitPrice = 109.28,
                ._totalRevenue = 5888.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 18),
                ._orderId = "167787253",
                ._unitSold = 8,
                ._unitPrice = 154.06,
                ._totalRevenue = 1281.78
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 2, 18),
                ._orderId = "817824685",
                ._unitSold = 14,
                ._unitPrice = 255.28,
                ._totalRevenue = 3453.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 2, 18),
                ._orderId = "551725089",
                ._unitSold = 66,
                ._unitPrice = 421.89,
                ._totalRevenue = 27713.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 2, 18),
                ._orderId = "464626681",
                ._unitSold = 22,
                ._unitPrice = 668.27,
                ._totalRevenue = 14802.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 19),
                ._orderId = "551057326",
                ._unitSold = 90,
                ._unitPrice = 81.73,
                ._totalRevenue = 7325.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 20),
                ._orderId = "492689454",
                ._unitSold = 66,
                ._unitPrice = 81.73,
                ._totalRevenue = 5404.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 21),
                ._orderId = "976871955",
                ._unitSold = 70,
                ._unitPrice = 154.06,
                ._totalRevenue = 10745.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 2, 22),
                ._orderId = "207580077",
                ._unitSold = 64,
                ._unitPrice = 421.89,
                ._totalRevenue = 27055.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 22),
                ._orderId = "147047555",
                ._unitSold = 35,
                ._unitPrice = 81.73,
                ._totalRevenue = 2855.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 22),
                ._orderId = "770714795",
                ._unitSold = 5,
                ._unitPrice = 152.58,
                ._totalRevenue = 747.64
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 2, 22),
                ._orderId = "531693494",
                ._unitSold = 88,
                ._unitPrice = 47.45,
                ._totalRevenue = 4163.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 23),
                ._orderId = "211201274",
                ._unitSold = 80,
                ._unitPrice = 154.06,
                ._totalRevenue = 12332.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 24),
                ._orderId = "363832271",
                ._unitSold = 49,
                ._unitPrice = 81.73,
                ._totalRevenue = 4012.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 25),
                ._orderId = "496941077",
                ._unitSold = 48,
                ._unitPrice = 81.73,
                ._totalRevenue = 3892.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 2, 25),
                ._orderId = "314004981",
                ._unitSold = 99,
                ._unitPrice = 9.33,
                ._totalRevenue = 924.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 2, 25),
                ._orderId = "658348691",
                ._unitSold = 89,
                ._unitPrice = 9.33,
                ._totalRevenue = 826.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 2, 26),
                ._orderId = "178377473",
                ._unitSold = 47,
                ._unitPrice = 437.2,
                ._totalRevenue = 20605.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 2, 26),
                ._orderId = "489148938",
                ._unitSold = 89,
                ._unitPrice = 421.89,
                ._totalRevenue = 37531.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 2, 26),
                ._orderId = "251466166",
                ._unitSold = 33,
                ._unitPrice = 255.28,
                ._totalRevenue = 8378.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 2, 27),
                ._orderId = "717110955",
                ._unitSold = 79,
                ._unitPrice = 668.27,
                ._totalRevenue = 52940.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 2, 27),
                ._orderId = "238714301",
                ._unitSold = 97,
                ._unitPrice = 109.28,
                ._totalRevenue = 10623.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 2, 27),
                ._orderId = "683184659",
                ._unitSold = 84,
                ._unitPrice = 47.45,
                ._totalRevenue = 3974.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 27),
                ._orderId = "248121345",
                ._unitSold = 35,
                ._unitPrice = 154.06,
                ._totalRevenue = 5353.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 2, 27),
                ._orderId = "283504188",
                ._unitSold = 40,
                ._unitPrice = 152.58,
                ._totalRevenue = 6170.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 2, 27),
                ._orderId = "280749452",
                ._unitSold = 89,
                ._unitPrice = 255.28,
                ._totalRevenue = 22607.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 2, 28),
                ._orderId = "950427091",
                ._unitSold = 14,
                ._unitPrice = 651.21,
                ._totalRevenue = 8804.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 2, 28),
                ._orderId = "880999934",
                ._unitSold = 63,
                ._unitPrice = 109.28,
                ._totalRevenue = 6898.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 2, 28),
                ._orderId = "778708636",
                ._unitSold = 60,
                ._unitPrice = 81.73,
                ._totalRevenue = 4940.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 2, 28),
                ._orderId = "651621711",
                ._unitSold = 82,
                ._unitPrice = 437.2,
                ._totalRevenue = 35850.4
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 2, 29),
                ._orderId = "366630351",
                ._unitSold = 29,
                ._unitPrice = 651.21,
                ._totalRevenue = 19034.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 2, 29),
                ._orderId = "262056386",
                ._unitSold = 72,
                ._unitPrice = 47.45,
                ._totalRevenue = 3398.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 2, 29),
                ._orderId = "133276879",
                ._unitSold = 84,
                ._unitPrice = 47.45,
                ._totalRevenue = 4007.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 2, 29),
                ._orderId = "737816321",
                ._unitSold = 51,
                ._unitPrice = 154.06,
                ._totalRevenue = 7857.06
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 1),
                ._orderId = "887180173",
                ._unitSold = 52,
                ._unitPrice = 255.28,
                ._totalRevenue = 13231.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 1),
                ._orderId = "151854932",
                ._unitSold = 61,
                ._unitPrice = 154.06,
                ._totalRevenue = 9403.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 1),
                ._orderId = "536028802",
                ._unitSold = 17,
                ._unitPrice = 9.33,
                ._totalRevenue = 157.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 1),
                ._orderId = "807678210",
                ._unitSold = 88,
                ._unitPrice = 152.58,
                ._totalRevenue = 13405.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 2),
                ._orderId = "272016179",
                ._unitSold = 45,
                ._unitPrice = 81.73,
                ._totalRevenue = 3667.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 2),
                ._orderId = "331604564",
                ._unitSold = 80,
                ._unitPrice = 81.73,
                ._totalRevenue = 6549.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 2),
                ._orderId = "164569461",
                ._unitSold = 86,
                ._unitPrice = 152.58,
                ._totalRevenue = 13144.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 2),
                ._orderId = "694722020",
                ._unitSold = 25,
                ._unitPrice = 154.06,
                ._totalRevenue = 3911.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 3),
                ._orderId = "494468724",
                ._unitSold = 31,
                ._unitPrice = 205.7,
                ._totalRevenue = 6456.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 3),
                ._orderId = "423821055",
                ._unitSold = 69,
                ._unitPrice = 154.06,
                ._totalRevenue = 10665.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 3),
                ._orderId = "494745099",
                ._unitSold = 123,
                ._unitPrice = 437.2,
                ._totalRevenue = 21527.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 3),
                ._orderId = "166066348",
                ._unitSold = 16,
                ._unitPrice = 255.28,
                ._totalRevenue = 4028.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 4),
                ._orderId = "674808442",
                ._unitSold = 97,
                ._unitPrice = 9.33,
                ._totalRevenue = 902.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 4),
                ._orderId = "504270160",
                ._unitSold = 36,
                ._unitPrice = 205.7,
                ._totalRevenue = 7407.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 4),
                ._orderId = "306889617",
                ._unitSold = 43,
                ._unitPrice = 255.28,
                ._totalRevenue = 11007.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 4),
                ._orderId = "861601769",
                ._unitSold = 60,
                ._unitPrice = 205.7,
                ._totalRevenue = 12270.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 5),
                ._orderId = "699368035",
                ._unitSold = 74,
                ._unitPrice = 109.28,
                ._totalRevenue = 8084.53
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 5),
                ._orderId = "719362294",
                ._unitSold = 41,
                ._unitPrice = 81.73,
                ._totalRevenue = 3386.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 5),
                ._orderId = "191256368",
                ._unitSold = 59,
                ._unitPrice = 109.28,
                ._totalRevenue = 6408.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 5),
                ._orderId = "444604098",
                ._unitSold = 71,
                ._unitPrice = 255.28,
                ._totalRevenue = 18094.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 6),
                ._orderId = "794969689",
                ._unitSold = 81,
                ._unitPrice = 421.89,
                ._totalRevenue = 33970.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 6),
                ._orderId = "888248336",
                ._unitSold = 13,
                ._unitPrice = 81.73,
                ._totalRevenue = 1042.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 6),
                ._orderId = "139540803",
                ._unitSold = 21,
                ._unitPrice = 421.89,
                ._totalRevenue = 8771.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 6),
                ._orderId = "430081975",
                ._unitSold = 97,
                ._unitPrice = 9.33,
                ._totalRevenue = 902.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 7),
                ._orderId = "940870702",
                ._unitSold = 34,
                ._unitPrice = 205.7,
                ._totalRevenue = 7002.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 7),
                ._orderId = "432995069",
                ._unitSold = 17,
                ._unitPrice = 109.28,
                ._totalRevenue = 1877.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 7),
                ._orderId = "247776305",
                ._unitSold = 14,
                ._unitPrice = 205.7,
                ._totalRevenue = 2818.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 7),
                ._orderId = "409774005",
                ._unitSold = 1,
                ._unitPrice = 81.73,
                ._totalRevenue = 72.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 8),
                ._orderId = "783596694",
                ._unitSold = 25,
                ._unitPrice = 255.28,
                ._totalRevenue = 6458.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 8),
                ._orderId = "267888581",
                ._unitSold = 30,
                ._unitPrice = 9.33,
                ._totalRevenue = 283.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 8),
                ._orderId = "841492497",
                ._unitSold = 52,
                ._unitPrice = 421.89,
                ._totalRevenue = 21875.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 8),
                ._orderId = "951380240",
                ._unitSold = 34,
                ._unitPrice = 154.06,
                ._totalRevenue = 5253.45
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 9),
                ._orderId = "841138446",
                ._unitSold = 4,
                ._unitPrice = 651.21,
                ._totalRevenue = 2689.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 9),
                ._orderId = "960905301",
                ._unitSold = 21,
                ._unitPrice = 9.33,
                ._totalRevenue = 194.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 9),
                ._orderId = "693743550",
                ._unitSold = 30,
                ._unitPrice = 154.06,
                ._totalRevenue = 4603.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 9),
                ._orderId = "547528827",
                ._unitSold = 48,
                ._unitPrice = 255.28,
                ._totalRevenue = 12258.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 10),
                ._orderId = "248093020",
                ._unitSold = 51,
                ._unitPrice = 421.89,
                ._totalRevenue = 21486.86
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 3, 10),
                ._orderId = "606055057",
                ._unitSold = 40,
                ._unitPrice = 668.27,
                ._totalRevenue = 26824.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 10),
                ._orderId = "533006703",
                ._unitSold = 74,
                ._unitPrice = 437.2,
                ._totalRevenue = 32278.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 10),
                ._orderId = "461768949",
                ._unitSold = 65,
                ._unitPrice = 81.73,
                ._totalRevenue = 5351.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 11),
                ._orderId = "729443109",
                ._unitSold = 73,
                ._unitPrice = 154.06,
                ._totalRevenue = 11217.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 11),
                ._orderId = "716849601",
                ._unitSold = 6,
                ._unitPrice = 109.28,
                ._totalRevenue = 636.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 11),
                ._orderId = "464840400",
                ._unitSold = 55,
                ._unitPrice = 152.58,
                ._totalRevenue = 8329.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 11),
                ._orderId = "867551982",
                ._unitSold = 68,
                ._unitPrice = 109.28,
                ._totalRevenue = 7392.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 12),
                ._orderId = "462085664",
                ._unitSold = 3,
                ._unitPrice = 255.28,
                ._totalRevenue = 691.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 12),
                ._orderId = "692566382",
                ._unitSold = 46,
                ._unitPrice = 9.33,
                ._totalRevenue = 432.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 12),
                ._orderId = "714135205",
                ._unitSold = 73,
                ._unitPrice = 9.33,
                ._totalRevenue = 684.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 12),
                ._orderId = "221530139",
                ._unitSold = 45,
                ._unitPrice = 9.33,
                ._totalRevenue = 424.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 13),
                ._orderId = "890695369",
                ._unitSold = 54,
                ._unitPrice = 47.45,
                ._totalRevenue = 2566.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 13),
                ._orderId = "759279143",
                ._unitSold = 64,
                ._unitPrice = 651.21,
                ._totalRevenue = 41846.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 13),
                ._orderId = "972678697",
                ._unitSold = 61,
                ._unitPrice = 421.89,
                ._totalRevenue = 25718.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 13),
                ._orderId = "379710948",
                ._unitSold = 38,
                ._unitPrice = 81.73,
                ._totalRevenue = 3074.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 14),
                ._orderId = "373335015",
                ._unitSold = 70,
                ._unitPrice = 255.28,
                ._totalRevenue = 17823.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 14),
                ._orderId = "960085189",
                ._unitSold = 94,
                ._unitPrice = 47.45,
                ._totalRevenue = 4458.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 14),
                ._orderId = "812295901",
                ._unitSold = 53,
                ._unitPrice = 651.21,
                ._totalRevenue = 34273.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 3, 14),
                ._orderId = "718781220",
                ._unitSold = 220,
                ._unitPrice = 668.27,
                ._totalRevenue = 14641.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 15),
                ._orderId = "801590669",
                ._unitSold = 73,
                ._unitPrice = 109.28,
                ._totalRevenue = 8028.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 15),
                ._orderId = "851299941",
                ._unitSold = 74,
                ._unitPrice = 109.28,
                ._totalRevenue = 8114.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 15),
                ._orderId = "693159472",
                ._unitSold = 1,
                ._unitPrice = 109.28,
                ._totalRevenue = 159.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 15),
                ._orderId = "644670712",
                ._unitSold = 12,
                ._unitPrice = 152.58,
                ._totalRevenue = 1899.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 16),
                ._orderId = "347163522",
                ._unitSold = 23,
                ._unitPrice = 81.73,
                ._totalRevenue = 1843.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 16),
                ._orderId = "854095017",
                ._unitSold = 46,
                ._unitPrice = 47.45,
                ._totalRevenue = 2158.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 16),
                ._orderId = "669978749",
                ._unitSold = 5,
                ._unitPrice = 47.45,
                ._totalRevenue = 215.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 16),
                ._orderId = "103617227",
                ._unitSold = 15,
                ._unitPrice = 9.33,
                ._totalRevenue = 139.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 17),
                ._orderId = "466970717",
                ._unitSold = 59,
                ._unitPrice = 109.28,
                ._totalRevenue = 6411.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 17),
                ._orderId = "127468717",
                ._unitSold = 97,
                ._unitPrice = 81.73,
                ._totalRevenue = 7912.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 17),
                ._orderId = "547143447",
                ._unitSold = 8,
                ._unitPrice = 651.21,
                ._totalRevenue = 4949.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 17),
                ._orderId = "195833718",
                ._unitSold = 4,
                ._unitPrice = 255.28,
                ._totalRevenue = 1031.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 18),
                ._orderId = "280571782",
                ._unitSold = 63,
                ._unitPrice = 651.21,
                ._totalRevenue = 40895.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 18),
                ._orderId = "736967885",
                ._unitSold = 40,
                ._unitPrice = 437.2,
                ._totalRevenue = 17614.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 3, 18),
                ._orderId = "778490626",
                ._unitSold = 150,
                ._unitPrice = 668.27,
                ._totalRevenue = 10231.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 18),
                ._orderId = "821587932",
                ._unitSold = 50,
                ._unitPrice = 9.33,
                ._totalRevenue = 464.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 19),
                ._orderId = "280494105",
                ._unitSold = 33,
                ._unitPrice = 154.06,
                ._totalRevenue = 5074.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 19),
                ._orderId = "908136594",
                ._unitSold = 67,
                ._unitPrice = 421.89,
                ._totalRevenue = 28072.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 19),
                ._orderId = "427811324",
                ._unitSold = 77,
                ._unitPrice = 154.06,
                ._totalRevenue = 11913.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 3, 19),
                ._orderId = "905381858",
                ._unitSold = 250,
                ._unitPrice = 668.27,
                ._totalRevenue = 9796.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 20),
                ._orderId = "339256370",
                ._unitSold = 24,
                ._unitPrice = 109.28,
                ._totalRevenue = 2572.45
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 20),
                ._orderId = "369837844",
                ._unitSold = 21,
                ._unitPrice = 152.58,
                ._totalRevenue = 3190.45
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 20),
                ._orderId = "673130881",
                ._unitSold = 32,
                ._unitPrice = 152.58,
                ._totalRevenue = 4945.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 20),
                ._orderId = "313044536",
                ._unitSold = 57,
                ._unitPrice = 255.28,
                ._totalRevenue = 14522.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 21),
                ._orderId = "115309941",
                ._unitSold = 16,
                ._unitPrice = 152.58,
                ._totalRevenue = 2485.53
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 21),
                ._orderId = "107005393",
                ._unitSold = 41,
                ._unitPrice = 47.45,
                ._totalRevenue = 1959.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 21),
                ._orderId = "661953580",
                ._unitSold = 56,
                ._unitPrice = 109.28,
                ._totalRevenue = 6151.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 21),
                ._orderId = "127589738",
                ._unitSold = 55,
                ._unitPrice = 81.73,
                ._totalRevenue = 4490.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 22),
                ._orderId = "834460818",
                ._unitSold = 44,
                ._unitPrice = 421.89,
                ._totalRevenue = 18373.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 22),
                ._orderId = "968554103",
                ._unitSold = 55,
                ._unitPrice = 109.28,
                ._totalRevenue = 6050.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 22),
                ._orderId = "479216182",
                ._unitSold = 96,
                ._unitPrice = 421.89,
                ._totalRevenue = 40383.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 3, 22),
                ._orderId = "742443025",
                ._unitSold = 42,
                ._unitPrice = 152.58,
                ._totalRevenue = 6477.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 23),
                ._orderId = "296438443",
                ._unitSold = 16,
                ._unitPrice = 47.45,
                ._totalRevenue = 748.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 23),
                ._orderId = "186196649",
                ._unitSold = 86,
                ._unitPrice = 47.45,
                ._totalRevenue = 4071.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 23),
                ._orderId = "534633624",
                ._unitSold = 88,
                ._unitPrice = 437.2,
                ._totalRevenue = 38582.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 23),
                ._orderId = "681006705",
                ._unitSold = 39,
                ._unitPrice = 9.33,
                ._totalRevenue = 361.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 24),
                ._orderId = "351855885",
                ._unitSold = 8,
                ._unitPrice = 81.73,
                ._totalRevenue = 678.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 3, 24),
                ._orderId = "860952031",
                ._unitSold = 37,
                ._unitPrice = 47.45,
                ._totalRevenue = 1752.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 24),
                ._orderId = "285341823",
                ._unitSold = 78,
                ._unitPrice = 651.21,
                ._totalRevenue = 51061.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 24),
                ._orderId = "524363124",
                ._unitSold = 96,
                ._unitPrice = 154.06,
                ._totalRevenue = 14721.97
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 25),
                ._orderId = "770508801",
                ._unitSold = 95,
                ._unitPrice = 651.21,
                ._totalRevenue = 62073.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 25),
                ._orderId = "830923306",
                ._unitSold = 75,
                ._unitPrice = 255.28,
                ._totalRevenue = 19212.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 25),
                ._orderId = "227486360",
                ._unitSold = 71,
                ._unitPrice = 9.33,
                ._totalRevenue = 664.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 25),
                ._orderId = "562817418",
                ._unitSold = 90,
                ._unitPrice = 437.2,
                ._totalRevenue = 39505.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 26),
                ._orderId = "185177838",
                ._unitSold = 71,
                ._unitPrice = 81.73,
                ._totalRevenue = 5796.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 26),
                ._orderId = "500160586",
                ._unitSold = 75,
                ._unitPrice = 421.89,
                ._totalRevenue = 31586.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 26),
                ._orderId = "881974112",
                ._unitSold = 46,
                ._unitPrice = 255.28,
                ._totalRevenue = 11727.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 26),
                ._orderId = "393620669",
                ._unitSold = 100,
                ._unitPrice = 255.28,
                ._totalRevenue = 25420.78
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 27),
                ._orderId = "835572326",
                ._unitSold = 33,
                ._unitPrice = 205.7,
                ._totalRevenue = 6734.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 27),
                ._orderId = "867374312",
                ._unitSold = 42,
                ._unitPrice = 437.2,
                ._totalRevenue = 18314.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 27),
                ._orderId = "392952907",
                ._unitSold = 24,
                ._unitPrice = 437.2,
                ._totalRevenue = 10282.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 27),
                ._orderId = "177901113",
                ._unitSold = 37,
                ._unitPrice = 255.28,
                ._totalRevenue = 9565.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 28),
                ._orderId = "162866580",
                ._unitSold = 47,
                ._unitPrice = 154.06,
                ._totalRevenue = 7233.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 28),
                ._orderId = "277083623",
                ._unitSold = 41,
                ._unitPrice = 437.2,
                ._totalRevenue = 17732.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 3, 28),
                ._orderId = "365560901",
                ._unitSold = 64,
                ._unitPrice = 668.27,
                ._totalRevenue = 43096.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 3, 28),
                ._orderId = "435146415",
                ._unitSold = 83,
                ._unitPrice = 205.7,
                ._totalRevenue = 17173.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 29),
                ._orderId = "590768182",
                ._unitSold = 3,
                ._unitPrice = 255.28,
                ._totalRevenue = 735.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 3, 29),
                ._orderId = "775278842",
                ._unitSold = 11,
                ._unitPrice = 421.89,
                ._totalRevenue = 4611.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 3, 29),
                ._orderId = "432037627",
                ._unitSold = 84,
                ._unitPrice = 437.2,
                ._totalRevenue = 36681.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 29),
                ._orderId = "304832684",
                ._unitSold = 56,
                ._unitPrice = 154.06,
                ._totalRevenue = 8658.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 30),
                ._orderId = "612573039",
                ._unitSold = 28,
                ._unitPrice = 109.28,
                ._totalRevenue = 3092.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 30),
                ._orderId = "716202867",
                ._unitSold = 92,
                ._unitPrice = 9.33,
                ._totalRevenue = 858.27
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 3, 30),
                ._orderId = "505244338",
                ._unitSold = 19,
                ._unitPrice = 154.06,
                ._totalRevenue = 2899.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 3, 30),
                ._orderId = "630048596",
                ._unitSold = 42,
                ._unitPrice = 651.21,
                ._totalRevenue = 27585.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 3, 31),
                ._orderId = "812984693",
                ._unitSold = 91,
                ._unitPrice = 109.28,
                ._totalRevenue = 9935.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 3, 31),
                ._orderId = "645713555",
                ._unitSold = 98,
                ._unitPrice = 9.33,
                ._totalRevenue = 918.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 3, 31),
                ._orderId = "254927718",
                ._unitSold = 76,
                ._unitPrice = 255.28,
                ._totalRevenue = 19482.97
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 3, 31),
                ._orderId = "147599017",
                ._unitSold = 67,
                ._unitPrice = 81.73,
                ._totalRevenue = 5462.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 1),
                ._orderId = "885129249",
                ._unitSold = 83,
                ._unitPrice = 81.73,
                ._totalRevenue = 6758.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 1),
                ._orderId = "708215034",
                ._unitSold = 54,
                ._unitPrice = 152.58,
                ._totalRevenue = 8271.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 1),
                ._orderId = "476436126",
                ._unitSold = 69,
                ._unitPrice = 651.21,
                ._totalRevenue = 44881.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 1),
                ._orderId = "183022201",
                ._unitSold = 92,
                ._unitPrice = 421.89,
                ._totalRevenue = 38775.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 2),
                ._orderId = "980612885",
                ._unitSold = 40,
                ._unitPrice = 47.45,
                ._totalRevenue = 1897.53
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 2),
                ._orderId = "777840888",
                ._unitSold = 93,
                ._unitPrice = 81.73,
                ._totalRevenue = 7567.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 2),
                ._orderId = "733563411",
                ._unitSold = 66,
                ._unitPrice = 9.33,
                ._totalRevenue = 612.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 2),
                ._orderId = "765955483",
                ._unitSold = 21,
                ._unitPrice = 9.33,
                ._totalRevenue = 196.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 3),
                ._orderId = "364818465",
                ._unitSold = 67,
                ._unitPrice = 651.21,
                ._totalRevenue = 43930.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 3),
                ._orderId = "460379779",
                ._unitSold = 55,
                ._unitPrice = 152.58,
                ._totalRevenue = 8333.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 3),
                ._orderId = "644772422",
                ._unitSold = 13,
                ._unitPrice = 47.45,
                ._totalRevenue = 637.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 4, 3),
                ._orderId = "773315894",
                ._unitSold = 2,
                ._unitPrice = 437.2,
                ._totalRevenue = 931.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 4),
                ._orderId = "806298053",
                ._unitSold = 4,
                ._unitPrice = 47.45,
                ._totalRevenue = 173.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 4),
                ._orderId = "887927329",
                ._unitSold = 63,
                ._unitPrice = 651.21,
                ._totalRevenue = 40915.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 4),
                ._orderId = "750253188",
                ._unitSold = 540,
                ._unitPrice = 668.27,
                ._totalRevenue = 36393.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 4),
                ._orderId = "899853074",
                ._unitSold = 54,
                ._unitPrice = 205.7,
                ._totalRevenue = 11058.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 5),
                ._orderId = "681298100",
                ._unitSold = 1,
                ._unitPrice = 421.89,
                ._totalRevenue = 434.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 5),
                ._orderId = "234073007",
                ._unitSold = 63,
                ._unitPrice = 421.89,
                ._totalRevenue = 26406.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 5),
                ._orderId = "957276809",
                ._unitSold = 83,
                ._unitPrice = 205.7,
                ._totalRevenue = 17145.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 5),
                ._orderId = "773160541",
                ._unitSold = 42,
                ._unitPrice = 205.7,
                ._totalRevenue = 8721.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 4, 6),
                ._orderId = "573025262",
                ._unitSold = 98,
                ._unitPrice = 437.2,
                ._totalRevenue = 42688.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 6),
                ._orderId = "221007430",
                ._unitSold = 99,
                ._unitPrice = 651.21,
                ._totalRevenue = 64241.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 6),
                ._orderId = "579913604",
                ._unitSold = 82,
                ._unitPrice = 81.73,
                ._totalRevenue = 6683.06
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 6),
                ._orderId = "594003999",
                ._unitSold = 78,
                ._unitPrice = 9.33,
                ._totalRevenue = 731.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 7),
                ._orderId = "489784085",
                ._unitSold = 69,
                ._unitPrice = 152.58,
                ._totalRevenue = 10451.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 7),
                ._orderId = "373048341",
                ._unitSold = 21,
                ._unitPrice = 47.45,
                ._totalRevenue = 1019.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 4, 7),
                ._orderId = "759504878",
                ._unitSold = 32,
                ._unitPrice = 437.2,
                ._totalRevenue = 14104.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 7),
                ._orderId = "185941302",
                ._unitSold = 30,
                ._unitPrice = 154.06,
                ._totalRevenue = 4649.53
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 8),
                ._orderId = "106753051",
                ._unitSold = 95,
                ._unitPrice = 47.45,
                ._totalRevenue = 4486.4
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 8),
                ._orderId = "731640803",
                ._unitSold = 76,
                ._unitPrice = 9.33,
                ._totalRevenue = 711.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 8),
                ._orderId = "414887797",
                ._unitSold = 34,
                ._unitPrice = 109.28,
                ._totalRevenue = 3687.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 8),
                ._orderId = "823739278",
                ._unitSold = 16,
                ._unitPrice = 81.73,
                ._totalRevenue = 1317.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 9),
                ._orderId = "141940200",
                ._unitSold = 21,
                ._unitPrice = 205.7,
                ._totalRevenue = 4348.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 9),
                ._orderId = "769464671",
                ._unitSold = 6,
                ._unitPrice = 47.45,
                ._totalRevenue = 260.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 9),
                ._orderId = "687875735",
                ._unitSold = 66,
                ._unitPrice = 109.28,
                ._totalRevenue = 7180.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 9),
                ._orderId = "257890164",
                ._unitSold = 43,
                ._unitPrice = 109.28,
                ._totalRevenue = 4682.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 10),
                ._orderId = "312559163",
                ._unitSold = 21,
                ._unitPrice = 47.45,
                ._totalRevenue = 976.05
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 10),
                ._orderId = "207395112",
                ._unitSold = 17,
                ._unitPrice = 421.89,
                ._totalRevenue = 7075.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 10),
                ._orderId = "608414113",
                ._unitSold = 21,
                ._unitPrice = 47.45,
                ._totalRevenue = 1001.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 10),
                ._orderId = "585823476",
                ._unitSold = 70,
                ._unitPrice = 255.28,
                ._totalRevenue = 17971.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 11),
                ._orderId = "792729079",
                ._unitSold = 50,
                ._unitPrice = 255.28,
                ._totalRevenue = 12779.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 11),
                ._orderId = "556738889",
                ._unitSold = 3,
                ._unitPrice = 255.28,
                ._totalRevenue = 673.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 11),
                ._orderId = "165835034",
                ._unitSold = 31,
                ._unitPrice = 154.06,
                ._totalRevenue = 4817.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 11),
                ._orderId = "232389438",
                ._unitSold = 81,
                ._unitPrice = 152.58,
                ._totalRevenue = 12288.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 12),
                ._orderId = "876286971",
                ._unitSold = 16,
                ._unitPrice = 668.27,
                ._totalRevenue = 10979.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 12),
                ._orderId = "433627212",
                ._unitSold = 88,
                ._unitPrice = 421.89,
                ._totalRevenue = 37054.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 12),
                ._orderId = "364554107",
                ._unitSold = 85,
                ._unitPrice = 152.58,
                ._totalRevenue = 12993.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 12),
                ._orderId = "201730287",
                ._unitSold = 53,
                ._unitPrice = 109.28,
                ._totalRevenue = 5824.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 13),
                ._orderId = "521396386",
                ._unitSold = 16,
                ._unitPrice = 152.58,
                ._totalRevenue = 2490.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 13),
                ._orderId = "670878255",
                ._unitSold = 66,
                ._unitPrice = 152.58,
                ._totalRevenue = 10129.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 13),
                ._orderId = "402614009",
                ._unitSold = 13,
                ._unitPrice = 9.33,
                ._totalRevenue = 120.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 13),
                ._orderId = "936387765",
                ._unitSold = 68,
                ._unitPrice = 421.89,
                ._totalRevenue = 28701.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 4, 14),
                ._orderId = "888647449",
                ._unitSold = 94,
                ._unitPrice = 437.2,
                ._totalRevenue = 41022.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 14),
                ._orderId = "626523101",
                ._unitSold = 10,
                ._unitPrice = 421.89,
                ._totalRevenue = 4062.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 14),
                ._orderId = "686583554",
                ._unitSold = 42,
                ._unitPrice = 47.45,
                ._totalRevenue = 1986.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 14),
                ._orderId = "469839179",
                ._unitSold = 47,
                ._unitPrice = 9.33,
                ._totalRevenue = 439.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 15),
                ._orderId = "945717132",
                ._unitSold = 76,
                ._unitPrice = 255.28,
                ._totalRevenue = 19324.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 15),
                ._orderId = "249237573",
                ._unitSold = 38,
                ._unitPrice = 255.28,
                ._totalRevenue = 9677.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 15),
                ._orderId = "720786225",
                ._unitSold = 55,
                ._unitPrice = 152.58,
                ._totalRevenue = 8416.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 15),
                ._orderId = "238414323",
                ._unitSold = 10,
                ._unitPrice = 255.28,
                ._totalRevenue = 2427.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 16),
                ._orderId = "576264083",
                ._unitSold = 82,
                ._unitPrice = 255.28,
                ._totalRevenue = 20940.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 16),
                ._orderId = "851652705",
                ._unitSold = 18,
                ._unitPrice = 109.28,
                ._totalRevenue = 1984.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 16),
                ._orderId = "343699395",
                ._unitSold = 71,
                ._unitPrice = 651.21,
                ._totalRevenue = 46522.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 16),
                ._orderId = "151868665",
                ._unitSold = 2,
                ._unitPrice = 154.06,
                ._totalRevenue = 258.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 17),
                ._orderId = "419306790",
                ._unitSold = 11,
                ._unitPrice = 154.06,
                ._totalRevenue = 1620.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 17),
                ._orderId = "248178422",
                ._unitSold = 4,
                ._unitPrice = 154.06,
                ._totalRevenue = 562.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 17),
                ._orderId = "276595246",
                ._unitSold = 95,
                ._unitPrice = 651.21,
                ._totalRevenue = 62092.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 17),
                ._orderId = "442214143",
                ._unitSold = 980,
                ._unitPrice = 668.27,
                ._totalRevenue = 65804.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 18),
                ._orderId = "668365561",
                ._unitSold = 31,
                ._unitPrice = 47.45,
                ._totalRevenue = 1460.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 18),
                ._orderId = "235702931",
                ._unitSold = 86,
                ._unitPrice = 205.7,
                ._totalRevenue = 17669.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 18),
                ._orderId = "526834189",
                ._unitSold = 8,
                ._unitPrice = 109.28,
                ._totalRevenue = 873.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 18),
                ._orderId = "410452497",
                ._unitSold = 9,
                ._unitPrice = 47.45,
                ._totalRevenue = 412.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 19),
                ._orderId = "745783555",
                ._unitSold = 28,
                ._unitPrice = 109.28,
                ._totalRevenue = 3040.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 19),
                ._orderId = "361137616",
                ._unitSold = 75,
                ._unitPrice = 651.21,
                ._totalRevenue = 48847.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 19),
                ._orderId = "479447925",
                ._unitSold = 82,
                ._unitPrice = 421.89,
                ._totalRevenue = 34384.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 19),
                ._orderId = "990708720",
                ._unitSold = 16,
                ._unitPrice = 152.58,
                ._totalRevenue = 2412.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 20),
                ._orderId = "221062791",
                ._unitSold = 62,
                ._unitPrice = 47.45,
                ._totalRevenue = 2964.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 20),
                ._orderId = "584534299",
                ._unitSold = 55,
                ._unitPrice = 152.58,
                ._totalRevenue = 8459.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 20),
                ._orderId = "305959212",
                ._unitSold = 90,
                ._unitPrice = 205.7,
                ._totalRevenue = 18482.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 20),
                ._orderId = "131209647",
                ._unitSold = 67,
                ._unitPrice = 9.33,
                ._totalRevenue = 625.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 21),
                ._orderId = "959853875",
                ._unitSold = 9,
                ._unitPrice = 154.06,
                ._totalRevenue = 1458.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 21),
                ._orderId = "369681203",
                ._unitSold = 57,
                ._unitPrice = 668.27,
                ._totalRevenue = 38345.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 21),
                ._orderId = "627122199",
                ._unitSold = 83,
                ._unitPrice = 9.33,
                ._totalRevenue = 769.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 21),
                ._orderId = "509914386",
                ._unitSold = 39,
                ._unitPrice = 152.58,
                ._totalRevenue = 5878.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 22),
                ._orderId = "133336961",
                ._unitSold = 62,
                ._unitPrice = 81.73,
                ._totalRevenue = 5087.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 4, 22),
                ._orderId = "251529252",
                ._unitSold = 20,
                ._unitPrice = 9.33,
                ._totalRevenue = 181.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 22),
                ._orderId = "328316819",
                ._unitSold = 51,
                ._unitPrice = 47.45,
                ._totalRevenue = 2419.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 22),
                ._orderId = "481065833",
                ._unitSold = 69,
                ._unitPrice = 81.73,
                ._totalRevenue = 5659.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 23),
                ._orderId = "567614495",
                ._unitSold = 86,
                ._unitPrice = 47.45,
                ._totalRevenue = 4079.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 23),
                ._orderId = "274200570",
                ._unitSold = 9,
                ._unitPrice = 47.45,
                ._totalRevenue = 425.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 23),
                ._orderId = "918334138",
                ._unitSold = 43,
                ._unitPrice = 421.89,
                ._totalRevenue = 18284.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 23),
                ._orderId = "290455615",
                ._unitSold = 11,
                ._unitPrice = 81.73,
                ._totalRevenue = 920.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 24),
                ._orderId = "554154527",
                ._unitSold = 55,
                ._unitPrice = 651.21,
                ._totalRevenue = 35777.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 24),
                ._orderId = "208630645",
                ._unitSold = 73,
                ._unitPrice = 109.28,
                ._totalRevenue = 7976.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 24),
                ._orderId = "366653096",
                ._unitSold = 97,
                ._unitPrice = 154.06,
                ._totalRevenue = 14872.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 24),
                ._orderId = "958912742",
                ._unitSold = 24,
                ._unitPrice = 255.28,
                ._totalRevenue = 6239.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 25),
                ._orderId = "563915622",
                ._unitSold = 40,
                ._unitPrice = 205.7,
                ._totalRevenue = 8267.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 25),
                ._orderId = "207922542",
                ._unitSold = 78,
                ._unitPrice = 421.89,
                ._totalRevenue = 32717.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 4, 25),
                ._orderId = "109724509",
                ._unitSold = 88,
                ._unitPrice = 81.73,
                ._totalRevenue = 7171.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 25),
                ._orderId = "261765420",
                ._unitSold = 11,
                ._unitPrice = 205.7,
                ._totalRevenue = 2180.42
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 26),
                ._orderId = "104845464",
                ._unitSold = 50,
                ._unitPrice = 205.7,
                ._totalRevenue = 10196.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 26),
                ._orderId = "132082116",
                ._unitSold = 49,
                ._unitPrice = 651.21,
                ._totalRevenue = 31831.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 26),
                ._orderId = "640942227",
                ._unitSold = 79,
                ._unitPrice = 205.7,
                ._totalRevenue = 16256.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 26),
                ._orderId = "555142009",
                ._unitSold = 77,
                ._unitPrice = 154.06,
                ._totalRevenue = 11881.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 4, 27),
                ._orderId = "384013640",
                ._unitSold = 70,
                ._unitPrice = 154.06,
                ._totalRevenue = 10822.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 27),
                ._orderId = "556480538",
                ._unitSold = 38,
                ._unitPrice = 109.28,
                ._totalRevenue = 4165.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 27),
                ._orderId = "816204202",
                ._unitSold = 18,
                ._unitPrice = 668.27,
                ._totalRevenue = 12135.78
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 27),
                ._orderId = "732568633",
                ._unitSold = 22,
                ._unitPrice = 47.45,
                ._totalRevenue = 1040.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 28),
                ._orderId = "927666509",
                ._unitSold = 60,
                ._unitPrice = 668.27,
                ._totalRevenue = 40029.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 28),
                ._orderId = "343239343",
                ._unitSold = 10,
                ._unitPrice = 651.21,
                ._totalRevenue = 6538.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 28),
                ._orderId = "827539861",
                ._unitSold = 63,
                ._unitPrice = 421.89,
                ._totalRevenue = 26532.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 4, 28),
                ._orderId = "594540441",
                ._unitSold = 66,
                ._unitPrice = 205.7,
                ._totalRevenue = 13541.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 4, 29),
                ._orderId = "286210000",
                ._unitSold = 48,
                ._unitPrice = 152.58,
                ._totalRevenue = 7253.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 4, 29),
                ._orderId = "165380990",
                ._unitSold = 880,
                ._unitPrice = 668.27,
                ._totalRevenue = 58573.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 29),
                ._orderId = "368547379",
                ._unitSold = 2,
                ._unitPrice = 421.89,
                ._totalRevenue = 902.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 4, 29),
                ._orderId = "767401731",
                ._unitSold = 1,
                ._unitPrice = 255.28,
                ._totalRevenue = 204.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 4, 30),
                ._orderId = "643817985",
                ._unitSold = 89,
                ._unitPrice = 47.45,
                ._totalRevenue = 4224.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 4, 30),
                ._orderId = "147119653",
                ._unitSold = 48,
                ._unitPrice = 109.28,
                ._totalRevenue = 5277.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 4, 30),
                ._orderId = "286014306",
                ._unitSold = 68,
                ._unitPrice = 421.89,
                ._totalRevenue = 28874.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 4, 30),
                ._orderId = "673573338",
                ._unitSold = 42,
                ._unitPrice = 651.21,
                ._totalRevenue = 27181.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 1),
                ._orderId = "768662583",
                ._unitSold = 32,
                ._unitPrice = 154.06,
                ._totalRevenue = 4922.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 1),
                ._orderId = "905392587",
                ._unitSold = 46,
                ._unitPrice = 205.7,
                ._totalRevenue = 9546.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 1),
                ._orderId = "499690234",
                ._unitSold = 83,
                ._unitPrice = 81.73,
                ._totalRevenue = 6782.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 1),
                ._orderId = "404010903",
                ._unitSold = 47,
                ._unitPrice = 109.28,
                ._totalRevenue = 5091.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 2),
                ._orderId = "414244067",
                ._unitSold = 29,
                ._unitPrice = 47.45,
                ._totalRevenue = 1366.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 2),
                ._orderId = "542669522",
                ._unitSold = 68,
                ._unitPrice = 109.28,
                ._totalRevenue = 7459.45
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 2),
                ._orderId = "356506621",
                ._unitSold = 71,
                ._unitPrice = 437.2,
                ._totalRevenue = 30979.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 2),
                ._orderId = "845058763",
                ._unitSold = 5,
                ._unitPrice = 437.2,
                ._totalRevenue = 2282.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 5, 3),
                ._orderId = "946759974",
                ._unitSold = 62,
                ._unitPrice = 651.21,
                ._totalRevenue = 40179.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 3),
                ._orderId = "554045522",
                ._unitSold = 32,
                ._unitPrice = 47.45,
                ._totalRevenue = 1535.96
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 3),
                ._orderId = "355602824",
                ._unitSold = 96,
                ._unitPrice = 421.89,
                ._totalRevenue = 40640.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 3),
                ._orderId = "614028298",
                ._unitSold = 35,
                ._unitPrice = 154.06,
                ._totalRevenue = 5350.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 4),
                ._orderId = "247802054",
                ._unitSold = 90,
                ._unitPrice = 668.27,
                ._totalRevenue = 60070.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 4),
                ._orderId = "808890140",
                ._unitSold = 74,
                ._unitPrice = 154.06,
                ._totalRevenue = 11434.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 4),
                ._orderId = "632093942",
                ._unitSold = 95,
                ._unitPrice = 47.45,
                ._totalRevenue = 4507.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 4),
                ._orderId = "645948302",
                ._unitSold = 93,
                ._unitPrice = 152.58,
                ._totalRevenue = 14208.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 5),
                ._orderId = "531023156",
                ._unitSold = 4,
                ._unitPrice = 152.58,
                ._totalRevenue = 621.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 5),
                ._orderId = "641146934",
                ._unitSold = 85,
                ._unitPrice = 154.06,
                ._totalRevenue = 13064.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 5),
                ._orderId = "216552817",
                ._unitSold = 16,
                ._unitPrice = 668.27,
                ._totalRevenue = 10999.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 5),
                ._orderId = "551371467",
                ._unitSold = 19,
                ._unitPrice = 109.28,
                ._totalRevenue = 2103.64
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 6),
                ._orderId = "517799222",
                ._unitSold = 72,
                ._unitPrice = 205.7,
                ._totalRevenue = 14709.61
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 6),
                ._orderId = "303691565",
                ._unitSold = 79,
                ._unitPrice = 152.58,
                ._totalRevenue = 12111.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 6),
                ._orderId = "637448060",
                ._unitSold = 39,
                ._unitPrice = 81.73,
                ._totalRevenue = 3188.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 6),
                ._orderId = "226077878",
                ._unitSold = 3,
                ._unitPrice = 81.73,
                ._totalRevenue = 263.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 7),
                ._orderId = "880444610",
                ._unitSold = 20,
                ._unitPrice = 154.06,
                ._totalRevenue = 3050.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 7),
                ._orderId = "251621949",
                ._unitSold = 94,
                ._unitPrice = 421.89,
                ._totalRevenue = 39577.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 7),
                ._orderId = "890010011",
                ._unitSold = 26,
                ._unitPrice = 81.73,
                ._totalRevenue = 2120.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 7),
                ._orderId = "675548303",
                ._unitSold = 86,
                ._unitPrice = 9.33,
                ._totalRevenue = 803.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 8),
                ._orderId = "531734263",
                ._unitSold = 80,
                ._unitPrice = 668.27,
                ._totalRevenue = 5613.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 8),
                ._orderId = "645597255",
                ._unitSold = 54,
                ._unitPrice = 154.06,
                ._totalRevenue = 8363.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 8),
                ._orderId = "795315158",
                ._unitSold = 3,
                ._unitPrice = 205.7,
                ._totalRevenue = 584.19
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 8),
                ._orderId = "418973767",
                ._unitSold = 25,
                ._unitPrice = 81.73,
                ._totalRevenue = 2045.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 9),
                ._orderId = "175033080",
                ._unitSold = 50,
                ._unitPrice = 152.58,
                ._totalRevenue = 7679.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 9),
                ._orderId = "312117135",
                ._unitSold = 13,
                ._unitPrice = 109.28,
                ._totalRevenue = 1367.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 9),
                ._orderId = "585931193",
                ._unitSold = 89,
                ._unitPrice = 154.06,
                ._totalRevenue = 13735.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 9),
                ._orderId = "849630105",
                ._unitSold = 33,
                ._unitPrice = 437.2,
                ._totalRevenue = 14357.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 10),
                ._orderId = "981086671",
                ._unitSold = 42,
                ._unitPrice = 47.45,
                ._totalRevenue = 1994.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 10),
                ._orderId = "205300843",
                ._unitSold = 19,
                ._unitPrice = 437.2,
                ._totalRevenue = 8468.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 10),
                ._orderId = "430390107",
                ._unitSold = 9,
                ._unitPrice = 205.7,
                ._totalRevenue = 1752.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 10),
                ._orderId = "478919208",
                ._unitSold = 17,
                ._unitPrice = 154.06,
                ._totalRevenue = 2605.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 11),
                ._orderId = "512019383",
                ._unitSold = 68,
                ._unitPrice = 81.73,
                ._totalRevenue = 5532.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 11),
                ._orderId = "723608338",
                ._unitSold = 6,
                ._unitPrice = 668.27,
                ._totalRevenue = 4290.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 11),
                ._orderId = "407681453",
                ._unitSold = 9,
                ._unitPrice = 109.28,
                ._totalRevenue = 935.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 11),
                ._orderId = "473527753",
                ._unitSold = 62,
                ._unitPrice = 255.28,
                ._totalRevenue = 15929.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 12),
                ._orderId = "529612958",
                ._unitSold = 31,
                ._unitPrice = 668.27,
                ._totalRevenue = 20703.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 12),
                ._orderId = "654693591",
                ._unitSold = 72,
                ._unitPrice = 109.28,
                ._totalRevenue = 7908.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 12),
                ._orderId = "266820847",
                ._unitSold = 71,
                ._unitPrice = 205.7,
                ._totalRevenue = 14549.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 12),
                ._orderId = "480456435",
                ._unitSold = 66,
                ._unitPrice = 152.58,
                ._totalRevenue = 10056.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 13),
                ._orderId = "735968816",
                ._unitSold = 84,
                ._unitPrice = 205.7,
                ._totalRevenue = 17241.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 13),
                ._orderId = "584204280",
                ._unitSold = 79,
                ._unitPrice = 109.28,
                ._totalRevenue = 8615.64
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 13),
                ._orderId = "899659097",
                ._unitSold = 80,
                ._unitPrice = 437.2,
                ._totalRevenue = 34862.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 13),
                ._orderId = "156619393",
                ._unitSold = 60,
                ._unitPrice = 421.89,
                ._totalRevenue = 25372.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 14),
                ._orderId = "642140424",
                ._unitSold = 25,
                ._unitPrice = 81.73,
                ._totalRevenue = 2023.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 14),
                ._orderId = "529970014",
                ._unitSold = 88,
                ._unitPrice = 154.06,
                ._totalRevenue = 13494.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 14),
                ._orderId = "433228528",
                ._unitSold = 8,
                ._unitPrice = 9.33,
                ._totalRevenue = 75.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 14),
                ._orderId = "775171554",
                ._unitSold = 93,
                ._unitPrice = 421.89,
                ._totalRevenue = 39421.4
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 15),
                ._orderId = "859909617",
                ._unitSold = 52,
                ._unitPrice = 47.45,
                ._totalRevenue = 2476.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 15),
                ._orderId = "832713305",
                ._unitSold = 72,
                ._unitPrice = 152.58,
                ._totalRevenue = 11026.96
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 15),
                ._orderId = "703815782",
                ._unitSold = 36,
                ._unitPrice = 421.89,
                ._totalRevenue = 15124.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 15),
                ._orderId = "193775498",
                ._unitSold = 13,
                ._unitPrice = 9.33,
                ._totalRevenue = 124.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 16),
                ._orderId = "858611428",
                ._unitSold = 11,
                ._unitPrice = 152.58,
                ._totalRevenue = 1612.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 16),
                ._orderId = "739474999",
                ._unitSold = 59,
                ._unitPrice = 437.2,
                ._totalRevenue = 25969.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 16),
                ._orderId = "262770926",
                ._unitSold = 86,
                ._unitPrice = 109.28,
                ._totalRevenue = 9410.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 5, 16),
                ._orderId = "256158959",
                ._unitSold = 20,
                ._unitPrice = 651.21,
                ._totalRevenue = 12913.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 5, 17),
                ._orderId = "810871112",
                ._unitSold = 36,
                ._unitPrice = 651.21,
                ._totalRevenue = 23678.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 17),
                ._orderId = "382537782",
                ._unitSold = 333,
                ._unitPrice = 668.27,
                ._totalRevenue = 1904.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 17),
                ._orderId = "300476777",
                ._unitSold = 66,
                ._unitPrice = 255.28,
                ._totalRevenue = 16874.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 17),
                ._orderId = "671898782",
                ._unitSold = 86,
                ._unitPrice = 668.27,
                ._totalRevenue = 57705.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 18),
                ._orderId = "576455485",
                ._unitSold = 48,
                ._unitPrice = 668.27,
                ._totalRevenue = 32364.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 18),
                ._orderId = "416386401",
                ._unitSold = 68,
                ._unitPrice = 154.06,
                ._totalRevenue = 10543.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 18),
                ._orderId = "619670808",
                ._unitSold = 32,
                ._unitPrice = 81.73,
                ._totalRevenue = 2629.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 18),
                ._orderId = "671939122",
                ._unitSold = 6,
                ._unitPrice = 255.28,
                ._totalRevenue = 1462.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 19),
                ._orderId = "576654183",
                ._unitSold = 36,
                ._unitPrice = 668.27,
                ._totalRevenue = 24338.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 19),
                ._orderId = "247857415",
                ._unitSold = 54,
                ._unitPrice = 437.2,
                ._totalRevenue = 23486.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 19),
                ._orderId = "278910958",
                ._unitSold = 48,
                ._unitPrice = 668.27,
                ._totalRevenue = 32110.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 5, 19),
                ._orderId = "328856265",
                ._unitSold = 47,
                ._unitPrice = 651.21,
                ._totalRevenue = 30815.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 20),
                ._orderId = "467986953",
                ._unitSold = 66,
                ._unitPrice = 47.45,
                ._totalRevenue = 3128.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 20),
                ._orderId = "428392827",
                ._unitSold = 980,
                ._unitPrice = 668.27,
                ._totalRevenue = 65570.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 20),
                ._orderId = "806662833",
                ._unitSold = 83,
                ._unitPrice = 421.89,
                ._totalRevenue = 35071.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 20),
                ._orderId = "253407227",
                ._unitSold = 77,
                ._unitPrice = 437.2,
                ._totalRevenue = 33598.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 21),
                ._orderId = "353061807",
                ._unitSold = 77,
                ._unitPrice = 152.58,
                ._totalRevenue = 11731.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 21),
                ._orderId = "707520663",
                ._unitSold = 99,
                ._unitPrice = 81.73,
                ._totalRevenue = 8125.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 21),
                ._orderId = "875304210",
                ._unitSold = 8,
                ._unitPrice = 47.45,
                ._totalRevenue = 390.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 21),
                ._orderId = "612943828",
                ._unitSold = 26,
                ._unitPrice = 421.89,
                ._totalRevenue = 10775.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 22),
                ._orderId = "232155120",
                ._unitSold = 87,
                ._unitPrice = 81.73,
                ._totalRevenue = 7121.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 22),
                ._orderId = "423159730",
                ._unitSold = 12,
                ._unitPrice = 205.7,
                ._totalRevenue = 2513.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 22),
                ._orderId = "447601306",
                ._unitSold = 40,
                ._unitPrice = 9.33,
                ._totalRevenue = 375.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 22),
                ._orderId = "559299647",
                ._unitSold = 80,
                ._unitPrice = 255.28,
                ._totalRevenue = 20547.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 23),
                ._orderId = "607080304",
                ._unitSold = 74,
                ._unitPrice = 668.27,
                ._totalRevenue = 49505.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 23),
                ._orderId = "695557582",
                ._unitSold = 98,
                ._unitPrice = 9.33,
                ._totalRevenue = 914.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 23),
                ._orderId = "403836238",
                ._unitSold = 30,
                ._unitPrice = 109.28,
                ._totalRevenue = 3247.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 5, 23),
                ._orderId = "749282443",
                ._unitSold = 82,
                ._unitPrice = 651.21,
                ._totalRevenue = 53268.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 24),
                ._orderId = "749912869",
                ._unitSold = 47,
                ._unitPrice = 81.73,
                ._totalRevenue = 3872.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 5, 24),
                ._orderId = "560600841",
                ._unitSold = 310,
                ._unitPrice = 668.27,
                ._totalRevenue = 20723.05
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 24),
                ._orderId = "693473613",
                ._unitSold = 31,
                ._unitPrice = 47.45,
                ._totalRevenue = 1474.27
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 24),
                ._orderId = "935644042",
                ._unitSold = 67,
                ._unitPrice = 205.7,
                ._totalRevenue = 13820.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 25),
                ._orderId = "975002133",
                ._unitSold = 37,
                ._unitPrice = 81.73,
                ._totalRevenue = 2985.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 25),
                ._orderId = "248335492",
                ._unitSold = 68,
                ._unitPrice = 47.45,
                ._totalRevenue = 3248.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 25),
                ._orderId = "265929067",
                ._unitSold = 32,
                ._unitPrice = 255.28,
                ._totalRevenue = 8105.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 25),
                ._orderId = "887313640",
                ._unitSold = 47,
                ._unitPrice = 152.58,
                ._totalRevenue = 7139.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 5, 26),
                ._orderId = "782857692",
                ._unitSold = 38,
                ._unitPrice = 109.28,
                ._totalRevenue = 4199.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 26),
                ._orderId = "605825459",
                ._unitSold = 61,
                ._unitPrice = 81.73,
                ._totalRevenue = 4961.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 26),
                ._orderId = "332877862",
                ._unitSold = 48,
                ._unitPrice = 47.45,
                ._totalRevenue = 2282.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 26),
                ._orderId = "243102395",
                ._unitSold = 83,
                ._unitPrice = 9.33,
                ._totalRevenue = 770.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 27),
                ._orderId = "978349959",
                ._unitSold = 43,
                ._unitPrice = 47.45,
                ._totalRevenue = 2063.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 27),
                ._orderId = "967644727",
                ._unitSold = 64,
                ._unitPrice = 9.33,
                ._totalRevenue = 600.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 27),
                ._orderId = "786519229",
                ._unitSold = 74,
                ._unitPrice = 152.58,
                ._totalRevenue = 11249.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 27),
                ._orderId = "538957345",
                ._unitSold = 83,
                ._unitPrice = 154.06,
                ._totalRevenue = 12802.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 5, 28),
                ._orderId = "827964293",
                ._unitSold = 19,
                ._unitPrice = 9.33,
                ._totalRevenue = 176.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 28),
                ._orderId = "641801393",
                ._unitSold = 21,
                ._unitPrice = 81.73,
                ._totalRevenue = 1756.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 28),
                ._orderId = "785261380",
                ._unitSold = 51,
                ._unitPrice = 205.7,
                ._totalRevenue = 10587.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 5, 28),
                ._orderId = "622791612",
                ._unitSold = 67,
                ._unitPrice = 205.7,
                ._totalRevenue = 13849.78
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 29),
                ._orderId = "166435849",
                ._unitSold = 9,
                ._unitPrice = 81.73,
                ._totalRevenue = 752.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 29),
                ._orderId = "351182544",
                ._unitSold = 16,
                ._unitPrice = 152.58,
                ._totalRevenue = 2401.61
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 29),
                ._orderId = "345437037",
                ._unitSold = 14,
                ._unitPrice = 154.06,
                ._totalRevenue = 2081.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 5, 29),
                ._orderId = "969616687",
                ._unitSold = 100,
                ._unitPrice = 421.89,
                ._totalRevenue = 42104.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 30),
                ._orderId = "960486018",
                ._unitSold = 80,
                ._unitPrice = 255.28,
                ._totalRevenue = 20453.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 5, 30),
                ._orderId = "194225251",
                ._unitSold = 44,
                ._unitPrice = 437.2,
                ._totalRevenue = 19337.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 5, 30),
                ._orderId = "813209140",
                ._unitSold = 55,
                ._unitPrice = 154.06,
                ._totalRevenue = 8490.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 5, 30),
                ._orderId = "213865458",
                ._unitSold = 64,
                ._unitPrice = 152.58,
                ._totalRevenue = 9760.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 5, 31),
                ._orderId = "400304734",
                ._unitSold = 79,
                ._unitPrice = 81.73,
                ._totalRevenue = 6473.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 31),
                ._orderId = "296320855",
                ._unitSold = 68,
                ._unitPrice = 47.45,
                ._totalRevenue = 3217.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 5, 31),
                ._orderId = "641018617",
                ._unitSold = 5,
                ._unitPrice = 255.28,
                ._totalRevenue = 1296.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 5, 31),
                ._orderId = "989691627",
                ._unitSold = 6,
                ._unitPrice = 47.45,
                ._totalRevenue = 284.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 1),
                ._orderId = "195840156",
                ._unitSold = 23,
                ._unitPrice = 668.27,
                ._totalRevenue = 15430.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 1),
                ._orderId = "887400329",
                ._unitSold = 3,
                ._unitPrice = 152.58,
                ._totalRevenue = 506.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 1),
                ._orderId = "585917890",
                ._unitSold = 50,
                ._unitPrice = 668.27,
                ._totalRevenue = 33273.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 1),
                ._orderId = "441395747",
                ._unitSold = 77,
                ._unitPrice = 152.58,
                ._totalRevenue = 11695.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 2),
                ._orderId = "799003732",
                ._unitSold = 18,
                ._unitPrice = 47.45,
                ._totalRevenue = 861.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 2),
                ._orderId = "376456248",
                ._unitSold = 6,
                ._unitPrice = 152.58,
                ._totalRevenue = 952.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 2),
                ._orderId = "714306008",
                ._unitSold = 79,
                ._unitPrice = 152.58,
                ._totalRevenue = 12017.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 2),
                ._orderId = "447970378",
                ._unitSold = 32,
                ._unitPrice = 421.89,
                ._totalRevenue = 13690.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 3),
                ._orderId = "333281266",
                ._unitSold = 42,
                ._unitPrice = 9.33,
                ._totalRevenue = 390.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 3),
                ._orderId = "714818418",
                ._unitSold = 950,
                ._unitPrice = 668.27,
                ._totalRevenue = 63545.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 3),
                ._orderId = "142553031",
                ._unitSold = 35,
                ._unitPrice = 152.58,
                ._totalRevenue = 5286.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 3),
                ._orderId = "817740142",
                ._unitSold = 63,
                ._unitPrice = 255.28,
                ._totalRevenue = 16171.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 4),
                ._orderId = "329110324",
                ._unitSold = 99,
                ._unitPrice = 47.45,
                ._totalRevenue = 4703.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 4),
                ._orderId = "306125295",
                ._unitSold = 81,
                ._unitPrice = 421.89,
                ._totalRevenue = 34308.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 4),
                ._orderId = "487014758",
                ._unitSold = 73,
                ._unitPrice = 437.2,
                ._totalRevenue = 32107.97
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 4),
                ._orderId = "336116683",
                ._unitSold = 33,
                ._unitPrice = 109.28,
                ._totalRevenue = 3552.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 5),
                ._orderId = "254291713",
                ._unitSold = 94,
                ._unitPrice = 47.45,
                ._totalRevenue = 4471.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 5),
                ._orderId = "445178306",
                ._unitSold = 70,
                ._unitPrice = 255.28,
                ._totalRevenue = 17890.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 5),
                ._orderId = "629925000",
                ._unitSold = 77,
                ._unitPrice = 437.2,
                ._totalRevenue = 33493.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 5),
                ._orderId = "829352176",
                ._unitSold = 26,
                ._unitPrice = 47.45,
                ._totalRevenue = 1230.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 6),
                ._orderId = "860287702",
                ._unitSold = 71,
                ._unitPrice = 205.7,
                ._totalRevenue = 14610.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 6),
                ._orderId = "434355056",
                ._unitSold = 42,
                ._unitPrice = 255.28,
                ._totalRevenue = 10640.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 6),
                ._orderId = "105558288",
                ._unitSold = 59,
                ._unitPrice = 651.21,
                ._totalRevenue = 38408.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 6),
                ._orderId = "637521445",
                ._unitSold = 56,
                ._unitPrice = 152.58,
                ._totalRevenue = 8571.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 7),
                ._orderId = "884493243",
                ._unitSold = 1,
                ._unitPrice = 421.89,
                ._totalRevenue = 257.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 7),
                ._orderId = "801093709",
                ._unitSold = 3,
                ._unitPrice = 421.89,
                ._totalRevenue = 1202.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 6, 7),
                ._orderId = "603123080",
                ._unitSold = 64,
                ._unitPrice = 81.73,
                ._totalRevenue = 5211.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 7),
                ._orderId = "663065516",
                ._unitSold = 47,
                ._unitPrice = 668.27,
                ._totalRevenue = 31248.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 8),
                ._orderId = "419124829",
                ._unitSold = 72,
                ._unitPrice = 47.45,
                ._totalRevenue = 3419.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 8),
                ._orderId = "872412145",
                ._unitSold = 50,
                ._unitPrice = 109.28,
                ._totalRevenue = 5458.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 8),
                ._orderId = "402084004",
                ._unitSold = 44,
                ._unitPrice = 255.28,
                ._totalRevenue = 11352.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 8),
                ._orderId = "171131217",
                ._unitSold = 4,
                ._unitPrice = 9.33,
                ._totalRevenue = 35.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 9),
                ._orderId = "257915914",
                ._unitSold = 19,
                ._unitPrice = 154.06,
                ._totalRevenue = 2934.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 9),
                ._orderId = "547748982",
                ._unitSold = 100,
                ._unitPrice = 152.58,
                ._totalRevenue = 15183.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 9),
                ._orderId = "599622905",
                ._unitSold = 6,
                ._unitPrice = 152.58,
                ._totalRevenue = 910.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 9),
                ._orderId = "854545199",
                ._unitSold = 78,
                ._unitPrice = 9.33,
                ._totalRevenue = 724.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 10),
                ._orderId = "151807725",
                ._unitSold = 21,
                ._unitPrice = 255.28,
                ._totalRevenue = 5447.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 10),
                ._orderId = "109694898",
                ._unitSold = 102,
                ._unitPrice = 668.27,
                ._totalRevenue = 86.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 10),
                ._orderId = "159050118",
                ._unitSold = 53,
                ._unitPrice = 421.89,
                ._totalRevenue = 22440.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 10),
                ._orderId = "718327605",
                ._unitSold = 80,
                ._unitPrice = 154.06,
                ._totalRevenue = 12257.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 11),
                ._orderId = "405785882",
                ._unitSold = 99,
                ._unitPrice = 651.21,
                ._totalRevenue = 64567.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 11),
                ._orderId = "751940190",
                ._unitSold = 47,
                ._unitPrice = 154.06,
                ._totalRevenue = 7189.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 6, 11),
                ._orderId = "849312102",
                ._unitSold = 92,
                ._unitPrice = 81.73,
                ._totalRevenue = 7502.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 11),
                ._orderId = "663857305",
                ._unitSold = 90,
                ._unitPrice = 437.2,
                ._totalRevenue = 39278.05
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 12),
                ._orderId = "769651782",
                ._unitSold = 59,
                ._unitPrice = 109.28,
                ._totalRevenue = 6470.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 12),
                ._orderId = "185342633",
                ._unitSold = 59,
                ._unitPrice = 47.45,
                ._totalRevenue = 2780.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 12),
                ._orderId = "607300031",
                ._unitSold = 24,
                ._unitPrice = 437.2,
                ._totalRevenue = 10619.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 12),
                ._orderId = "444358193",
                ._unitSold = 43,
                ._unitPrice = 668.27,
                ._totalRevenue = 28862.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 13),
                ._orderId = "957547605",
                ._unitSold = 85,
                ._unitPrice = 9.33,
                ._totalRevenue = 790.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 13),
                ._orderId = "285509622",
                ._unitSold = 75,
                ._unitPrice = 651.21,
                ._totalRevenue = 48821.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 13),
                ._orderId = "858877503",
                ._unitSold = 98,
                ._unitPrice = 47.45,
                ._totalRevenue = 4647.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 13),
                ._orderId = "742141759",
                ._unitSold = 51,
                ._unitPrice = 47.45,
                ._totalRevenue = 2416.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 14),
                ._orderId = "540431916",
                ._unitSold = 47,
                ._unitPrice = 152.58,
                ._totalRevenue = 7122.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 14),
                ._orderId = "879107797",
                ._unitSold = 64,
                ._unitPrice = 651.21,
                ._totalRevenue = 41599.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 14),
                ._orderId = "108989799",
                ._unitSold = 14,
                ._unitPrice = 205.7,
                ._totalRevenue = 2793.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 14),
                ._orderId = "908627116",
                ._unitSold = 18,
                ._unitPrice = 437.2,
                ._totalRevenue = 7913.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 6, 15),
                ._orderId = "995529830",
                ._unitSold = 83,
                ._unitPrice = 81.73,
                ._totalRevenue = 6745.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 15),
                ._orderId = "327585113",
                ._unitSold = 86,
                ._unitPrice = 255.28,
                ._totalRevenue = 21874.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 15),
                ._orderId = "167161977",
                ._unitSold = 580,
                ._unitPrice = 668.27,
                ._totalRevenue = 38746.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 15),
                ._orderId = "860886800",
                ._unitSold = 44,
                ._unitPrice = 152.58,
                ._totalRevenue = 6698.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 16),
                ._orderId = "572550618",
                ._unitSold = 93,
                ._unitPrice = 651.21,
                ._totalRevenue = 60601.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 16),
                ._orderId = "780282342",
                ._unitSold = 17,
                ._unitPrice = 255.28,
                ._totalRevenue = 4439.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 16),
                ._orderId = "109228837",
                ._unitSold = 21,
                ._unitPrice = 651.21,
                ._totalRevenue = 13642.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 6, 16),
                ._orderId = "865650832",
                ._unitSold = 42,
                ._unitPrice = 81.73,
                ._totalRevenue = 3410.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 17),
                ._orderId = "940904176",
                ._unitSold = 33,
                ._unitPrice = 651.21,
                ._totalRevenue = 21548.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 17),
                ._orderId = "263080346",
                ._unitSold = 2,
                ._unitPrice = 109.28,
                ._totalRevenue = 191.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 17),
                ._orderId = "936574876",
                ._unitSold = 22,
                ._unitPrice = 651.21,
                ._totalRevenue = 14150.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 17),
                ._orderId = "703693473",
                ._unitSold = 74,
                ._unitPrice = 651.21,
                ._totalRevenue = 48130.93
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 18),
                ._orderId = "367576634",
                ._unitSold = 2,
                ._unitPrice = 9.33,
                ._totalRevenue = 275.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 18),
                ._orderId = "957553613",
                ._unitSold = 2,
                ._unitPrice = 421.89,
                ._totalRevenue = 1046.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 18),
                ._orderId = "986442506",
                ._unitSold = 91,
                ._unitPrice = 205.7,
                ._totalRevenue = 18745.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 18),
                ._orderId = "450268065",
                ._unitSold = 32,
                ._unitPrice = 205.7,
                ._totalRevenue = 6543.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 19),
                ._orderId = "118598544",
                ._unitSold = 48,
                ._unitPrice = 154.06,
                ._totalRevenue = 7394.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 19),
                ._orderId = "989119565",
                ._unitSold = 13,
                ._unitPrice = 47.45,
                ._totalRevenue = 623.97
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 19),
                ._orderId = "734945714",
                ._unitSold = 56,
                ._unitPrice = 255.28,
                ._totalRevenue = 14356.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 19),
                ._orderId = "468532407",
                ._unitSold = 80,
                ._unitPrice = 668.27,
                ._totalRevenue = 53501.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 20),
                ._orderId = "952714908",
                ._unitSold = 84,
                ._unitPrice = 154.06,
                ._totalRevenue = 12890.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 20),
                ._orderId = "509819114",
                ._unitSold = 57,
                ._unitPrice = 154.06,
                ._totalRevenue = 8719.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 20),
                ._orderId = "858020055",
                ._unitSold = 61,
                ._unitPrice = 152.58,
                ._totalRevenue = 9240.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 20),
                ._orderId = "277568137",
                ._unitSold = 74,
                ._unitPrice = 421.89,
                ._totalRevenue = 31367.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 21),
                ._orderId = "306220996",
                ._unitSold = 65,
                ._unitPrice = 154.06,
                ._totalRevenue = 9939.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 21),
                ._orderId = "236911857",
                ._unitSold = 63,
                ._unitPrice = 255.28,
                ._totalRevenue = 16179.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 21),
                ._orderId = "564646470",
                ._unitSold = 3,
                ._unitPrice = 9.33,
                ._totalRevenue = 27.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 21),
                ._orderId = "371123158",
                ._unitSold = 24,
                ._unitPrice = 668.27,
                ._totalRevenue = 16339.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 22),
                ._orderId = "979165780",
                ._unitSold = 58,
                ._unitPrice = 651.21,
                ._totalRevenue = 37561.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 6, 22),
                ._orderId = "241281497",
                ._unitSold = 94,
                ._unitPrice = 154.06,
                ._totalRevenue = 14500.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 22),
                ._orderId = "816696012",
                ._unitSold = 74,
                ._unitPrice = 651.21,
                ._totalRevenue = 47883.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 22),
                ._orderId = "580823838",
                ._unitSold = 75,
                ._unitPrice = 152.58,
                ._totalRevenue = 11498.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 23),
                ._orderId = "713696610",
                ._unitSold = 75,
                ._unitPrice = 205.7,
                ._totalRevenue = 15513.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 23),
                ._orderId = "539065062",
                ._unitSold = 2,
                ._unitPrice = 668.27,
                ._totalRevenue = 1242.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 23),
                ._orderId = "133362710",
                ._unitSold = 38,
                ._unitPrice = 205.7,
                ._totalRevenue = 7907.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 23),
                ._orderId = "469283854",
                ._unitSold = 4,
                ._unitPrice = 152.58,
                ._totalRevenue = 573.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 24),
                ._orderId = "270723140",
                ._unitSold = 18,
                ._unitPrice = 205.7,
                ._totalRevenue = 3801.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 24),
                ._orderId = "160127294",
                ._unitSold = 41,
                ._unitPrice = 255.28,
                ._totalRevenue = 10412.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 24),
                ._orderId = "621442782",
                ._unitSold = 760,
                ._unitPrice = 668.27,
                ._totalRevenue = 50681.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 24),
                ._orderId = "448621833",
                ._unitSold = 600,
                ._unitPrice = 437.2,
                ._totalRevenue = 26341.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 25),
                ._orderId = "317323625",
                ._unitSold = 20,
                ._unitPrice = 205.7,
                ._totalRevenue = 4046.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 25),
                ._orderId = "377502095",
                ._unitSold = 1,
                ._unitPrice = 47.45,
                ._totalRevenue = 54.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 25),
                ._orderId = "761439931",
                ._unitSold = 59,
                ._unitPrice = 205.7,
                ._totalRevenue = 12035.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 6, 25),
                ._orderId = "251753699",
                ._unitSold = 84,
                ._unitPrice = 152.58,
                ._totalRevenue = 12769.42
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 26),
                ._orderId = "167882096",
                ._unitSold = 89,
                ._unitPrice = 651.21,
                ._totalRevenue = 57944.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 26),
                ._orderId = "844997823",
                ._unitSold = 25,
                ._unitPrice = 109.28,
                ._totalRevenue = 2718.89
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 26),
                ._orderId = "418593108",
                ._unitSold = 990,
                ._unitPrice = 437.2,
                ._totalRevenue = 43099.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 26),
                ._orderId = "964214932",
                ._unitSold = 15,
                ._unitPrice = 205.7,
                ._totalRevenue = 3044.36
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 6, 27),
                ._orderId = "386163699",
                ._unitSold = 33,
                ._unitPrice = 421.89,
                ._totalRevenue = 13816.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 27),
                ._orderId = "805484378",
                ._unitSold = 6,
                ._unitPrice = 9.33,
                ._totalRevenue = 894.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 6, 27),
                ._orderId = "346215522",
                ._unitSold = 7,
                ._unitPrice = 9.33,
                ._totalRevenue = 160.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 27),
                ._orderId = "406275975",
                ._unitSold = 49,
                ._unitPrice = 109.28,
                ._totalRevenue = 5402.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 28),
                ._orderId = "985665738",
                ._unitSold = 93,
                ._unitPrice = 109.28,
                ._totalRevenue = 10108.4
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 28),
                ._orderId = "290878760",
                ._unitSold = 639,
                ._unitPrice = 437.2,
                ._totalRevenue = 27735.97
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 28),
                ._orderId = "850038230",
                ._unitSold = 41,
                ._unitPrice = 668.27,
                ._totalRevenue = 27111.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 6, 28),
                ._orderId = "294499957",
                ._unitSold = 79,
                ._unitPrice = 255.28,
                ._totalRevenue = 20261.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 29),
                ._orderId = "331457364",
                ._unitSold = 45,
                ._unitPrice = 668.27,
                ._totalRevenue = 29771.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 6, 29),
                ._orderId = "811546599",
                ._unitSold = 35,
                ._unitPrice = 205.7,
                ._totalRevenue = 7257.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 29),
                ._orderId = "192721068",
                ._unitSold = 93,
                ._unitPrice = 668.27,
                ._totalRevenue = 62162.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 6, 29),
                ._orderId = "568944442",
                ._unitSold = 22,
                ._unitPrice = 109.28,
                ._totalRevenue = 2358.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 6, 30),
                ._orderId = "668599021",
                ._unitSold = 22,
                ._unitPrice = 651.21,
                ._totalRevenue = 14085.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 6, 30),
                ._orderId = "506365287",
                ._unitSold = 36,
                ._unitPrice = 437.2,
                ._totalRevenue = 15721.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 6, 30),
                ._orderId = "668362987",
                ._unitSold = 230,
                ._unitPrice = 668.27,
                ._totalRevenue = 15470.45
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 6, 30),
                ._orderId = "270611131",
                ._unitSold = 87,
                ._unitPrice = 47.45,
                ._totalRevenue = 4129.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 1),
                ._orderId = "224287021",
                ._unitSold = 4,
                ._unitPrice = 255.28,
                ._totalRevenue = 939.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 1),
                ._orderId = "778763139",
                ._unitSold = 22,
                ._unitPrice = 154.06,
                ._totalRevenue = 3347.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 1),
                ._orderId = "340827071",
                ._unitSold = 72,
                ._unitPrice = 421.89,
                ._totalRevenue = 30203.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 1),
                ._orderId = "219762027",
                ._unitSold = 13,
                ._unitPrice = 81.73,
                ._totalRevenue = 1080.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 2),
                ._orderId = "452171361",
                ._unitSold = 654,
                ._unitPrice = 437.2,
                ._totalRevenue = 28020.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 2),
                ._orderId = "641129338",
                ._unitSold = 33,
                ._unitPrice = 255.28,
                ._totalRevenue = 8355.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 2),
                ._orderId = "251800048",
                ._unitSold = 21,
                ._unitPrice = 421.89,
                ._totalRevenue = 8796.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 2),
                ._orderId = "479880082",
                ._unitSold = 60,
                ._unitPrice = 255.28,
                ._totalRevenue = 15406.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 3),
                ._orderId = "647663629",
                ._unitSold = 69,
                ._unitPrice = 154.06,
                ._totalRevenue = 10653.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 3),
                ._orderId = "285884702",
                ._unitSold = 85,
                ._unitPrice = 47.45,
                ._totalRevenue = 4028.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 3),
                ._orderId = "350274455",
                ._unitSold = 29,
                ._unitPrice = 651.21,
                ._totalRevenue = 18559.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 3),
                ._orderId = "133766114",
                ._unitSold = 32,
                ._unitPrice = 651.21,
                ._totalRevenue = 20975.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 4),
                ._orderId = "739998137",
                ._unitSold = 7,
                ._unitPrice = 154.06,
                ._totalRevenue = 1152.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 4),
                ._orderId = "603426492",
                ._unitSold = 62,
                ._unitPrice = 154.06,
                ._totalRevenue = 9494.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 4),
                ._orderId = "443121373",
                ._unitSold = 83,
                ._unitPrice = 154.06,
                ._totalRevenue = 12811.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 7, 4),
                ._orderId = "277070748",
                ._unitSold = 2,
                ._unitPrice = 152.58,
                ._totalRevenue = 375.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 5),
                ._orderId = "444540584",
                ._unitSold = 83,
                ._unitPrice = 651.21,
                ._totalRevenue = 53998.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 5),
                ._orderId = "727131259",
                ._unitSold = 32,
                ._unitPrice = 154.06,
                ._totalRevenue = 4857.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 5),
                ._orderId = "535654580",
                ._unitSold = 9,
                ._unitPrice = 651.21,
                ._totalRevenue = 6179.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 5),
                ._orderId = "543723094",
                ._unitSold = 86,
                ._unitPrice = 81.73,
                ._totalRevenue = 7029.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 6),
                ._orderId = "744370782",
                ._unitSold = 47,
                ._unitPrice = 154.06,
                ._totalRevenue = 7257.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 6),
                ._orderId = "560608565",
                ._unitSold = 54,
                ._unitPrice = 651.21,
                ._totalRevenue = 35080.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 6),
                ._orderId = "360945355",
                ._unitSold = 6,
                ._unitPrice = 255.28,
                ._totalRevenue = 1549.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 6),
                ._orderId = "641489398",
                ._unitSold = 98,
                ._unitPrice = 154.06,
                ._totalRevenue = 15133.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 7, 7),
                ._orderId = "370116364",
                ._unitSold = 45,
                ._unitPrice = 152.58,
                ._totalRevenue = 6884.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 7),
                ._orderId = "941909682",
                ._unitSold = 9,
                ._unitPrice = 205.7,
                ._totalRevenue = 1771.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 7),
                ._orderId = "386371409",
                ._unitSold = 47,
                ._unitPrice = 421.89,
                ._totalRevenue = 20001.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 7),
                ._orderId = "974655807",
                ._unitSold = 1200,
                ._unitPrice = 437.2,
                ._totalRevenue = 5102.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 8),
                ._orderId = "680533778",
                ._unitSold = 39,
                ._unitPrice = 255.28,
                ._totalRevenue = 10014.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 8),
                ._orderId = "281561410",
                ._unitSold = 910,
                ._unitPrice = 437.2,
                ._totalRevenue = 39929.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 7, 8),
                ._orderId = "673803794",
                ._unitSold = 2,
                ._unitPrice = 9.33,
                ._totalRevenue = 221.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 8),
                ._orderId = "812344396",
                ._unitSold = 96,
                ._unitPrice = 47.45,
                ._totalRevenue = 4561.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 9),
                ._orderId = "751929891",
                ._unitSold = 16,
                ._unitPrice = 154.06,
                ._totalRevenue = 2494.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 9),
                ._orderId = "389678895",
                ._unitSold = 35,
                ._unitPrice = 421.89,
                ._totalRevenue = 14761.93
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 9),
                ._orderId = "133812463",
                ._unitSold = 69,
                ._unitPrice = 205.7,
                ._totalRevenue = 14267.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 9),
                ._orderId = "431083619",
                ._unitSold = 61,
                ._unitPrice = 81.73,
                ._totalRevenue = 4966.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 10),
                ._orderId = "633895957",
                ._unitSold = 28,
                ._unitPrice = 154.06,
                ._totalRevenue = 4244.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 10),
                ._orderId = "180412948",
                ._unitSold = 71,
                ._unitPrice = 205.7,
                ._totalRevenue = 14512.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 10),
                ._orderId = "502715766",
                ._unitSold = 36,
                ._unitPrice = 81.73,
                ._totalRevenue = 2959.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 10),
                ._orderId = "554707705",
                ._unitSold = 92,
                ._unitPrice = 47.45,
                ._totalRevenue = 4361.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 7, 11),
                ._orderId = "647278249",
                ._unitSold = 29,
                ._unitPrice = 109.28,
                ._totalRevenue = 3139.61
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 11),
                ._orderId = "298015153",
                ._unitSold = 82,
                ._unitPrice = 47.45,
                ._totalRevenue = 3872.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 11),
                ._orderId = "175257527",
                ._unitSold = 15,
                ._unitPrice = 421.89,
                ._totalRevenue = 6125.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 11),
                ._orderId = "798688733",
                ._unitSold = 86,
                ._unitPrice = 255.28,
                ._totalRevenue = 21954.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 12),
                ._orderId = "461823451",
                ._unitSold = 27,
                ._unitPrice = 154.06,
                ._totalRevenue = 4124.19
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 12),
                ._orderId = "781253516",
                ._unitSold = 91,
                ._unitPrice = 668.27,
                ._totalRevenue = 61019.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 12),
                ._orderId = "315254676",
                ._unitSold = 97,
                ._unitPrice = 47.45,
                ._totalRevenue = 4611.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 12),
                ._orderId = "622758996",
                ._unitSold = 71,
                ._unitPrice = 421.89,
                ._totalRevenue = 29874.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 13),
                ._orderId = "753585135",
                ._unitSold = 14,
                ._unitPrice = 205.7,
                ._totalRevenue = 2968.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 13),
                ._orderId = "308170640",
                ._unitSold = 34,
                ._unitPrice = 255.28,
                ._totalRevenue = 8666.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 13),
                ._orderId = "106578814",
                ._unitSold = 79,
                ._unitPrice = 154.06,
                ._totalRevenue = 12161.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 13),
                ._orderId = "947620856",
                ._unitSold = 9,
                ._unitPrice = 421.89,
                ._totalRevenue = 3898.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 14),
                ._orderId = "496656548",
                ._unitSold = 6,
                ._unitPrice = 154.06,
                ._totalRevenue = 868.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 14),
                ._orderId = "498585164",
                ._unitSold = 130,
                ._unitPrice = 668.27,
                ._totalRevenue = 8587.27
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 7, 14),
                ._orderId = "367050921",
                ._unitSold = 74,
                ._unitPrice = 152.58,
                ._totalRevenue = 11258.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 7, 14),
                ._orderId = "933924853",
                ._unitSold = 8,
                ._unitPrice = 9.33,
                ._totalRevenue = 743.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 15),
                ._orderId = "775076282",
                ._unitSold = 12,
                ._unitPrice = 205.7,
                ._totalRevenue = 2365.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 15),
                ._orderId = "749690568",
                ._unitSold = 90,
                ._unitPrice = 47.45,
                ._totalRevenue = 4248.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 7, 15),
                ._orderId = "821912801",
                ._unitSold = 11,
                ._unitPrice = 109.28,
                ._totalRevenue = 1220.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 15),
                ._orderId = "275269162",
                ._unitSold = 71,
                ._unitPrice = 47.45,
                ._totalRevenue = 3377.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 16),
                ._orderId = "337022197",
                ._unitSold = 12,
                ._unitPrice = 47.45,
                ._totalRevenue = 575.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 16),
                ._orderId = "494454562",
                ._unitSold = 89,
                ._unitPrice = 668.27,
                ._totalRevenue = 59796.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 7, 16),
                ._orderId = "749258840",
                ._unitSold = 12,
                ._unitPrice = 109.28,
                ._totalRevenue = 1306.99
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 16),
                ._orderId = "738199555",
                ._unitSold = 85,
                ._unitPrice = 255.28,
                ._totalRevenue = 21719.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 17),
                ._orderId = "382206475",
                ._unitSold = 22,
                ._unitPrice = 651.21,
                ._totalRevenue = 14613.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 17),
                ._orderId = "459112060",
                ._unitSold = 3,
                ._unitPrice = 651.21,
                ._totalRevenue = 2057.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 17),
                ._orderId = "642442548",
                ._unitSold = 19,
                ._unitPrice = 437.2,
                ._totalRevenue = 8223.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 7, 17),
                ._orderId = "903740775",
                ._unitSold = 8,
                ._unitPrice = 9.33,
                ._totalRevenue = 544.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 7, 18),
                ._orderId = "217140328",
                ._unitSold = 5,
                ._unitPrice = 9.33,
                ._totalRevenue = 513.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 18),
                ._orderId = "482649838",
                ._unitSold = 57,
                ._unitPrice = 255.28,
                ._totalRevenue = 14469.27
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 18),
                ._orderId = "625283706",
                ._unitSold = 42,
                ._unitPrice = 47.45,
                ._totalRevenue = 1992.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 18),
                ._orderId = "686800706",
                ._unitSold = 84,
                ._unitPrice = 437.2,
                ._totalRevenue = 36925.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 19),
                ._orderId = "410231912",
                ._unitSold = 56,
                ._unitPrice = 668.27,
                ._totalRevenue = 37383.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 19),
                ._orderId = "116699969",
                ._unitSold = 30,
                ._unitPrice = 154.06,
                ._totalRevenue = 4574.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 19),
                ._orderId = "110442054",
                ._unitSold = 11,
                ._unitPrice = 205.7,
                ._totalRevenue = 2289.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 19),
                ._orderId = "683927953",
                ._unitSold = 83,
                ._unitPrice = 47.45,
                ._totalRevenue = 3954.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 20),
                ._orderId = "581990706",
                ._unitSold = 28,
                ._unitPrice = 47.45,
                ._totalRevenue = 1346.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 20),
                ._orderId = "141259562",
                ._unitSold = 7,
                ._unitPrice = 47.45,
                ._totalRevenue = 331.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 20),
                ._orderId = "970611894",
                ._unitSold = 45,
                ._unitPrice = 437.2,
                ._totalRevenue = 19599.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 20),
                ._orderId = "125870978",
                ._unitSold = 69,
                ._unitPrice = 437.2,
                ._totalRevenue = 30053.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 7, 21),
                ._orderId = "723680436",
                ._unitSold = 20,
                ._unitPrice = 152.58,
                ._totalRevenue = 3018.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 21),
                ._orderId = "723090350",
                ._unitSold = 74,
                ._unitPrice = 255.28,
                ._totalRevenue = 18783.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 21),
                ._orderId = "270001733",
                ._unitSold = 8400,
                ._unitPrice = 437.2,
                ._totalRevenue = 36584.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 21),
                ._orderId = "653939568",
                ._unitSold = 41,
                ._unitPrice = 154.06,
                ._totalRevenue = 6324.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 22),
                ._orderId = "683458888",
                ._unitSold = 95,
                ._unitPrice = 205.7,
                ._totalRevenue = 19599.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 22),
                ._orderId = "219034612",
                ._unitSold = 61,
                ._unitPrice = 421.89,
                ._totalRevenue = 25583.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 22),
                ._orderId = "372845780",
                ._unitSold = 22,
                ._unitPrice = 421.89,
                ._totalRevenue = 9311.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 22),
                ._orderId = "532324779",
                ._unitSold = 56,
                ._unitPrice = 47.45,
                ._totalRevenue = 2650.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 7, 23),
                ._orderId = "351317298",
                ._unitSold = 15,
                ._unitPrice = 152.58,
                ._totalRevenue = 2212.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 23),
                ._orderId = "515007579",
                ._unitSold = 10,
                ._unitPrice = 47.45,
                ._totalRevenue = 494.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 23),
                ._orderId = "275632226",
                ._unitSold = 46,
                ._unitPrice = 47.45,
                ._totalRevenue = 2161.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 23),
                ._orderId = "700620734",
                ._unitSold = 81,
                ._unitPrice = 255.28,
                ._totalRevenue = 20675.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 7, 24),
                ._orderId = "875370299",
                ._unitSold = 4,
                ._unitPrice = 152.58,
                ._totalRevenue = 578.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 24),
                ._orderId = "971916091",
                ._unitSold = 4,
                ._unitPrice = 421.89,
                ._totalRevenue = 1788.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 24),
                ._orderId = "807281672",
                ._unitSold = 14,
                ._unitPrice = 421.89,
                ._totalRevenue = 6079.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 7, 24),
                ._orderId = "376547658",
                ._unitSold = 77,
                ._unitPrice = 47.45,
                ._totalRevenue = 3641.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 25),
                ._orderId = "511349046",
                ._unitSold = 84,
                ._unitPrice = 651.21,
                ._totalRevenue = 54708.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 25),
                ._orderId = "480177485",
                ._unitSold = 40,
                ._unitPrice = 421.89,
                ._totalRevenue = 17057.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 25),
                ._orderId = "436372077",
                ._unitSold = 110,
                ._unitPrice = 668.27,
                ._totalRevenue = 7016.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 25),
                ._orderId = "873522365",
                ._unitSold = 35,
                ._unitPrice = 437.2,
                ._totalRevenue = 15450.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 26),
                ._orderId = "864981782",
                ._unitSold = 62,
                ._unitPrice = 81.73,
                ._totalRevenue = 5055.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 26),
                ._orderId = "276225316",
                ._unitSold = 1,
                ._unitPrice = 154.06,
                ._totalRevenue = 98.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 26),
                ._orderId = "573378455",
                ._unitSold = 43,
                ._unitPrice = 421.89,
                ._totalRevenue = 18061.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 7, 26),
                ._orderId = "675079667",
                ._unitSold = 99,
                ._unitPrice = 109.28,
                ._totalRevenue = 10851.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 27),
                ._orderId = "677284657",
                ._unitSold = 24,
                ._unitPrice = 205.7,
                ._totalRevenue = 5010.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 7, 27),
                ._orderId = "980459678",
                ._unitSold = 87,
                ._unitPrice = 109.28,
                ._totalRevenue = 9464.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 7, 27),
                ._orderId = "889740073",
                ._unitSold = 2700,
                ._unitPrice = 437.2,
                ._totalRevenue = 11869.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 7, 27),
                ._orderId = "960269725",
                ._unitSold = 40,
                ._unitPrice = 421.89,
                ._totalRevenue = 16900.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 28),
                ._orderId = "138867890",
                ._unitSold = 30,
                ._unitPrice = 205.7,
                ._totalRevenue = 6068.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 28),
                ._orderId = "743053281",
                ._unitSold = 48,
                ._unitPrice = 154.06,
                ._totalRevenue = 7445.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 28),
                ._orderId = "299921452",
                ._unitSold = 23,
                ._unitPrice = 668.27,
                ._totalRevenue = 15223.19
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 28),
                ._orderId = "266467225",
                ._unitSold = 24,
                ._unitPrice = 154.06,
                ._totalRevenue = 3740.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 29),
                ._orderId = "841291654",
                ._unitSold = 58,
                ._unitPrice = 81.73,
                ._totalRevenue = 4700.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 29),
                ._orderId = "666424071",
                ._unitSold = 85,
                ._unitPrice = 651.21,
                ._totalRevenue = 55658.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 29),
                ._orderId = "184170186",
                ._unitSold = 89,
                ._unitPrice = 255.28,
                ._totalRevenue = 22735.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 29),
                ._orderId = "672327935",
                ._unitSold = 56,
                ._unitPrice = 81.73,
                ._totalRevenue = 4602.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 30),
                ._orderId = "977313554",
                ._unitSold = 77,
                ._unitPrice = 205.7,
                ._totalRevenue = 15742.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 7, 30),
                ._orderId = "850108611",
                ._unitSold = 9,
                ._unitPrice = 9.33,
                ._totalRevenue = 455.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 7, 30),
                ._orderId = "984673964",
                ._unitSold = 58,
                ._unitPrice = 255.28,
                ._totalRevenue = 14711.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 7, 30),
                ._orderId = "395563447",
                ._unitSold = 49,
                ._unitPrice = 668.27,
                ._totalRevenue = 32538.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 7, 31),
                ._orderId = "686458671",
                ._unitSold = 72,
                ._unitPrice = 81.73,
                ._totalRevenue = 5909.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 7, 31),
                ._orderId = "544219195",
                ._unitSold = 54,
                ._unitPrice = 205.7,
                ._totalRevenue = 11126.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 7, 31),
                ._orderId = "363329732",
                ._unitSold = 62,
                ._unitPrice = 651.21,
                ._totalRevenue = 40355.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 7, 31),
                ._orderId = "720307290",
                ._unitSold = 38,
                ._unitPrice = 154.06,
                ._totalRevenue = 5837.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 1),
                ._orderId = "634153020",
                ._unitSold = 88,
                ._unitPrice = 651.21,
                ._totalRevenue = 57475.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 1),
                ._orderId = "679414975",
                ._unitSold = 28,
                ._unitPrice = 205.7,
                ._totalRevenue = 5850.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 1),
                ._orderId = "680517470",
                ._unitSold = 91,
                ._unitPrice = 109.28,
                ._totalRevenue = 9941.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 1),
                ._orderId = "532846200",
                ._unitSold = 99,
                ._unitPrice = 81.73,
                ._totalRevenue = 8079.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 2),
                ._orderId = "775724732",
                ._unitSold = 30,
                ._unitPrice = 255.28,
                ._totalRevenue = 7763.06
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 8, 2),
                ._orderId = "768522679",
                ._unitSold = 18,
                ._unitPrice = 152.58,
                ._totalRevenue = 2737.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 2),
                ._orderId = "470897471",
                ._unitSold = 790,
                ._unitPrice = 437.2,
                ._totalRevenue = 34455.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 2),
                ._orderId = "869397771",
                ._unitSold = 30,
                ._unitPrice = 421.89,
                ._totalRevenue = 12551.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 3),
                ._orderId = "652889430",
                ._unitSold = 33,
                ._unitPrice = 421.89,
                ._totalRevenue = 14116.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 3),
                ._orderId = "685871589",
                ._unitSold = 35,
                ._unitPrice = 154.06,
                ._totalRevenue = 5392.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 3),
                ._orderId = "401116263",
                ._unitSold = 81,
                ._unitPrice = 154.06,
                ._totalRevenue = 12434.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 3),
                ._orderId = "155128943",
                ._unitSold = 500,
                ._unitPrice = 255.28,
                ._totalRevenue = 12654.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 4),
                ._orderId = "925405299",
                ._unitSold = 68,
                ._unitPrice = 205.7,
                ._totalRevenue = 14084.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 4),
                ._orderId = "901712167",
                ._unitSold = 55,
                ._unitPrice = 651.21,
                ._totalRevenue = 35966.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 4),
                ._orderId = "128090989",
                ._unitSold = 380,
                ._unitPrice = 668.27,
                ._totalRevenue = 25561.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 4),
                ._orderId = "243882596",
                ._unitSold = 910,
                ._unitPrice = 668.27,
                ._totalRevenue = 61046.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 5),
                ._orderId = "358099639",
                ._unitSold = 85,
                ._unitPrice = 651.21,
                ._totalRevenue = 55326.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 5),
                ._orderId = "682489430",
                ._unitSold = 26,
                ._unitPrice = 47.45,
                ._totalRevenue = 1254.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 5),
                ._orderId = "650727784",
                ._unitSold = 307,
                ._unitPrice = 437.2,
                ._totalRevenue = 16032.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 5),
                ._orderId = "267066323",
                ._unitSold = 97,
                ._unitPrice = 205.7,
                ._totalRevenue = 19983.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 8, 6),
                ._orderId = "763568961",
                ._unitSold = 59,
                ._unitPrice = 152.58,
                ._totalRevenue = 8970.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 6),
                ._orderId = "517935693",
                ._unitSold = 75,
                ._unitPrice = 81.73,
                ._totalRevenue = 6159.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 6),
                ._orderId = "860232770",
                ._unitSold = 8,
                ._unitPrice = 47.45,
                ._totalRevenue = 402.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 6),
                ._orderId = "954259860",
                ._unitSold = 56,
                ._unitPrice = 81.73,
                ._totalRevenue = 4538.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 8, 7),
                ._orderId = "590198266",
                ._unitSold = 16,
                ._unitPrice = 152.58,
                ._totalRevenue = 2497.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 8, 7),
                ._orderId = "360820043",
                ._unitSold = 5,
                ._unitPrice = 9.33,
                ._totalRevenue = 328.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 7),
                ._orderId = "795451629",
                ._unitSold = 7,
                ._unitPrice = 668.27,
                ._totalRevenue = 4464.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 7),
                ._orderId = "179970920",
                ._unitSold = 62,
                ._unitPrice = 47.45,
                ._totalRevenue = 2965.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 8, 8),
                ._orderId = "925333631",
                ._unitSold = 6,
                ._unitPrice = 9.33,
                ._totalRevenue = 526.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 8, 8),
                ._orderId = "873105657",
                ._unitSold = 2,
                ._unitPrice = 9.33,
                ._totalRevenue = 20.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 8),
                ._orderId = "698002040",
                ._unitSold = 32,
                ._unitPrice = 154.06,
                ._totalRevenue = 4883.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 8),
                ._orderId = "537578904",
                ._unitSold = 4,
                ._unitPrice = 47.45,
                ._totalRevenue = 189.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 9),
                ._orderId = "576700961",
                ._unitSold = 75,
                ._unitPrice = 668.27,
                ._totalRevenue = 50020.01
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 9),
                ._orderId = "636879432",
                ._unitSold = 56,
                ._unitPrice = 421.89,
                ._totalRevenue = 23760.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 9),
                ._orderId = "867360150",
                ._unitSold = 100,
                ._unitPrice = 109.28,
                ._totalRevenue = 10925.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 9),
                ._orderId = "935371100",
                ._unitSold = 5900,
                ._unitPrice = 255.28,
                ._totalRevenue = 15186.61
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 10),
                ._orderId = "953554761",
                ._unitSold = 69,
                ._unitPrice = 47.45,
                ._totalRevenue = 3273.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 10),
                ._orderId = "433871400",
                ._unitSold = 10,
                ._unitPrice = 154.06,
                ._totalRevenue = 1608.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 10),
                ._orderId = "215434443",
                ._unitSold = 7,
                ._unitPrice = 205.7,
                ._totalRevenue = 1427.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 10),
                ._orderId = "859686028",
                ._unitSold = 91,
                ._unitPrice = 205.7,
                ._totalRevenue = 18626.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 8, 11),
                ._orderId = "505975615",
                ._unitSold = 83,
                ._unitPrice = 152.58,
                ._totalRevenue = 12638.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 11),
                ._orderId = "499009597",
                ._unitSold = 69,
                ._unitPrice = 651.21,
                ._totalRevenue = 44829.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 11),
                ._orderId = "109956681",
                ._unitSold = 75,
                ._unitPrice = 255.28,
                ._totalRevenue = 19094.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 11),
                ._orderId = "974337804",
                ._unitSold = 71,
                ._unitPrice = 668.27,
                ._totalRevenue = 47199.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 12),
                ._orderId = "847999322",
                ._unitSold = 7,
                ._unitPrice = 109.28,
                ._totalRevenue = 763.87
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 12),
                ._orderId = "597918736",
                ._unitSold = 63,
                ._unitPrice = 437.2,
                ._totalRevenue = 27526.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 12),
                ._orderId = "312927377",
                ._unitSold = 10,
                ._unitPrice = 651.21,
                ._totalRevenue = 6642.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 12),
                ._orderId = "816632068",
                ._unitSold = 84,
                ._unitPrice = 651.21,
                ._totalRevenue = 54903.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 13),
                ._orderId = "666678130",
                ._unitSold = 37,
                ._unitPrice = 47.45,
                ._totalRevenue = 1769.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 13),
                ._orderId = "105117976",
                ._unitSold = 56,
                ._unitPrice = 109.28,
                ._totalRevenue = 6119.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 8, 13),
                ._orderId = "110667788",
                ._unitSold = 79,
                ._unitPrice = 152.58,
                ._totalRevenue = 12073.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 13),
                ._orderId = "644913613",
                ._unitSold = 31,
                ._unitPrice = 81.73,
                ._totalRevenue = 2553.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 14),
                ._orderId = "154119145",
                ._unitSold = 61,
                ._unitPrice = 421.89,
                ._totalRevenue = 25882.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 14),
                ._orderId = "669355189",
                ._unitSold = 59,
                ._unitPrice = 109.28,
                ._totalRevenue = 6480.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 14),
                ._orderId = "510978686",
                ._unitSold = 88,
                ._unitPrice = 255.28,
                ._totalRevenue = 22472.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 14),
                ._orderId = "956433522",
                ._unitSold = 88,
                ._unitPrice = 651.21,
                ._totalRevenue = 57228.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 15),
                ._orderId = "928647124",
                ._unitSold = 62,
                ._unitPrice = 81.73,
                ._totalRevenue = 5047.64
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 15),
                ._orderId = "262749040",
                ._unitSold = 21,
                ._unitPrice = 81.73,
                ._totalRevenue = 1744.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 15),
                ._orderId = "588200986",
                ._unitSold = 6,
                ._unitPrice = 651.21,
                ._totalRevenue = 3894.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 15),
                ._orderId = "835054767",
                ._unitSold = 1,
                ._unitPrice = 109.28,
                ._totalRevenue = 127.86
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 16),
                ._orderId = "229571187",
                ._unitSold = 41,
                ._unitPrice = 651.21,
                ._totalRevenue = 26510.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 16),
                ._orderId = "939787089",
                ._unitSold = 27,
                ._unitPrice = 255.28,
                ._totalRevenue = 6992.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 16),
                ._orderId = "218629920",
                ._unitSold = 63,
                ._unitPrice = 255.28,
                ._totalRevenue = 16100.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 16),
                ._orderId = "430967319",
                ._unitSold = 170,
                ._unitPrice = 668.27,
                ._totalRevenue = 11099.96
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 17),
                ._orderId = "925264966",
                ._unitSold = 53,
                ._unitPrice = 437.2,
                ._totalRevenue = 23259.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 17),
                ._orderId = "284870612",
                ._unitSold = 84,
                ._unitPrice = 109.28,
                ._totalRevenue = 9178.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 17),
                ._orderId = "212058293",
                ._unitSold = 16,
                ._unitPrice = 255.28,
                ._totalRevenue = 4125.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 17),
                ._orderId = "474222981",
                ._unitSold = 20,
                ._unitPrice = 255.28,
                ._totalRevenue = 5036.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 18),
                ._orderId = "893779695",
                ._unitSold = 81,
                ._unitPrice = 651.21,
                ._totalRevenue = 52930.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 18),
                ._orderId = "473555219",
                ._unitSold = 44,
                ._unitPrice = 205.7,
                ._totalRevenue = 8984.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 18),
                ._orderId = "414715278",
                ._unitSold = 230,
                ._unitPrice = 668.27,
                ._totalRevenue = 15510.55
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 18),
                ._orderId = "948607051",
                ._unitSold = 28,
                ._unitPrice = 154.06,
                ._totalRevenue = 4253.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 19),
                ._orderId = "925504004",
                ._unitSold = 61,
                ._unitPrice = 421.89,
                ._totalRevenue = 25553.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 19),
                ._orderId = "509214437",
                ._unitSold = 67,
                ._unitPrice = 109.28,
                ._totalRevenue = 7345.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 19),
                ._orderId = "837067067",
                ._unitSold = 56,
                ._unitPrice = 154.06,
                ._totalRevenue = 8630.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 19),
                ._orderId = "659798800",
                ._unitSold = 80,
                ._unitPrice = 651.21,
                ._totalRevenue = 51979.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 20),
                ._orderId = "352176463",
                ._unitSold = 57,
                ._unitPrice = 651.21,
                ._totalRevenue = 37092.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 20),
                ._orderId = "210409057",
                ._unitSold = 36,
                ._unitPrice = 651.21,
                ._totalRevenue = 23248.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 20),
                ._orderId = "166013562",
                ._unitSold = 60,
                ._unitPrice = 109.28,
                ._totalRevenue = 6509.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 20),
                ._orderId = "802078616",
                ._unitSold = 17,
                ._unitPrice = 437.2,
                ._totalRevenue = 7611.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 21),
                ._orderId = "635397565",
                ._unitSold = 71,
                ._unitPrice = 81.73,
                ._totalRevenue = 5814.27
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 21),
                ._orderId = "293258845",
                ._unitSold = 7,
                ._unitPrice = 47.45,
                ._totalRevenue = 315.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 21),
                ._orderId = "837855851",
                ._unitSold = 90,
                ._unitPrice = 437.2,
                ._totalRevenue = 39435.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 21),
                ._orderId = "618474757",
                ._unitSold = 93,
                ._unitPrice = 255.28,
                ._totalRevenue = 23687.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 22),
                ._orderId = "740760314",
                ._unitSold = 63,
                ._unitPrice = 47.45,
                ._totalRevenue = 2986.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 8, 22),
                ._orderId = "282475936",
                ._unitSold = 8,
                ._unitPrice = 9.33,
                ._totalRevenue = 910.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 22),
                ._orderId = "824200189",
                ._unitSold = 80,
                ._unitPrice = 154.06,
                ._totalRevenue = 12334.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 22),
                ._orderId = "263506495",
                ._unitSold = 63,
                ._unitPrice = 205.7,
                ._totalRevenue = 12924.13
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 23),
                ._orderId = "310343015",
                ._unitSold = 62,
                ._unitPrice = 109.28,
                ._totalRevenue = 6828.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 23),
                ._orderId = "136931979",
                ._unitSold = 1,
                ._unitPrice = 651.21,
                ._totalRevenue = 455.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 23),
                ._orderId = "770478332",
                ._unitSold = 5,
                ._unitPrice = 109.28,
                ._totalRevenue = 562.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 23),
                ._orderId = "888670623",
                ._unitSold = 62,
                ._unitPrice = 651.21,
                ._totalRevenue = 40635.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 24),
                ._orderId = "938025844",
                ._unitSold = 15,
                ._unitPrice = 154.06,
                ._totalRevenue = 2383.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 24),
                ._orderId = "642683303",
                ._unitSold = 31,
                ._unitPrice = 205.7,
                ._totalRevenue = 6430.18
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 24),
                ._orderId = "567588317",
                ._unitSold = 9,
                ._unitPrice = 47.45,
                ._totalRevenue = 403.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 24),
                ._orderId = "808538234",
                ._unitSold = 33,
                ._unitPrice = 205.7,
                ._totalRevenue = 6759.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 25),
                ._orderId = "737890565",
                ._unitSold = 71,
                ._unitPrice = 154.06,
                ._totalRevenue = 10893.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 25),
                ._orderId = "544485270",
                ._unitSold = 41,
                ._unitPrice = 437.2,
                ._totalRevenue = 18126.31
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 25),
                ._orderId = "102928006",
                ._unitSold = 75,
                ._unitPrice = 81.73,
                ._totalRevenue = 6161.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 8, 25),
                ._orderId = "451010930",
                ._unitSold = 30,
                ._unitPrice = 109.28,
                ._totalRevenue = 3291.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 26),
                ._orderId = "118002879",
                ._unitSold = 85,
                ._unitPrice = 81.73,
                ._totalRevenue = 6970.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 26),
                ._orderId = "123670709",
                ._unitSold = 58,
                ._unitPrice = 255.28,
                ._totalRevenue = 14719.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 8, 26),
                ._orderId = "795000588",
                ._unitSold = 72,
                ._unitPrice = 81.73,
                ._totalRevenue = 5881.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 26),
                ._orderId = "659845149",
                ._unitSold = 17,
                ._unitPrice = 255.28,
                ._totalRevenue = 4334.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 27),
                ._orderId = "867222821",
                ._unitSold = 94,
                ._unitPrice = 421.89,
                ._totalRevenue = 39484.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 27),
                ._orderId = "453569972",
                ._unitSold = 3,
                ._unitPrice = 437.2,
                ._totalRevenue = 1263.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 8, 27),
                ._orderId = "793938434",
                ._unitSold = 9,
                ._unitPrice = 9.33,
                ._totalRevenue = 268.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 27),
                ._orderId = "746434152",
                ._unitSold = 53,
                ._unitPrice = 668.27,
                ._totalRevenue = 35471.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 28),
                ._orderId = "991831386",
                ._unitSold = 38,
                ._unitPrice = 437.2,
                ._totalRevenue = 16626.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 8, 28),
                ._orderId = "465418040",
                ._unitSold = 64,
                ._unitPrice = 152.58,
                ._totalRevenue = 9759.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 8, 28),
                ._orderId = "357222878",
                ._unitSold = 90,
                ._unitPrice = 421.89,
                ._totalRevenue = 38151.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 28),
                ._orderId = "346045577",
                ._unitSold = 14,
                ._unitPrice = 651.21,
                ._totalRevenue = 9318.82
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 29),
                ._orderId = "289606320",
                ._unitSold = 98,
                ._unitPrice = 668.27,
                ._totalRevenue = 65497.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 8, 29),
                ._orderId = "561255729",
                ._unitSold = 69,
                ._unitPrice = 9.33,
                ._totalRevenue = 643.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 29),
                ._orderId = "242024362",
                ._unitSold = 92,
                ._unitPrice = 255.28,
                ._totalRevenue = 23592.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 29),
                ._orderId = "349157369",
                ._unitSold = 23,
                ._unitPrice = 255.28,
                ._totalRevenue = 5817.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 8, 30),
                ._orderId = "396820008",
                ._unitSold = 67,
                ._unitPrice = 154.06,
                ._totalRevenue = 10343.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 8, 30),
                ._orderId = "708063542",
                ._unitSold = 6,
                ._unitPrice = 205.7,
                ._totalRevenue = 1217.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 8, 30),
                ._orderId = "869589173",
                ._unitSold = 96,
                ._unitPrice = 437.2,
                ._totalRevenue = 42036.78
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 8, 30),
                ._orderId = "791975486",
                ._unitSold = 20,
                ._unitPrice = 47.45,
                ._totalRevenue = 949.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 31),
                ._orderId = "402646195",
                ._unitSold = 8,
                ._unitPrice = 651.21,
                ._totalRevenue = 5287.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 8, 31),
                ._orderId = "431535089",
                ._unitSold = 97,
                ._unitPrice = 255.28,
                ._totalRevenue = 24703.45
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 8, 31),
                ._orderId = "276661765",
                ._unitSold = 920,
                ._unitPrice = 668.27,
                ._totalRevenue = 61607.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 8, 31),
                ._orderId = "800084340",
                ._unitSold = 16,
                ._unitPrice = 651.21,
                ._totalRevenue = 10360.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 1),
                ._orderId = "461408460",
                ._unitSold = 99,
                ._unitPrice = 152.58,
                ._totalRevenue = 15062.7
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 1),
                ._orderId = "823699796",
                ._unitSold = 99,
                ._unitPrice = 255.28,
                ._totalRevenue = 25346.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 1),
                ._orderId = "234825313",
                ._unitSold = 89,
                ._unitPrice = 651.21,
                ._totalRevenue = 57846.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 1),
                ._orderId = "877424657",
                ._unitSold = 83,
                ._unitPrice = 437.2,
                ._totalRevenue = 36326.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 2),
                ._orderId = "745182311",
                ._unitSold = 49,
                ._unitPrice = 437.2,
                ._totalRevenue = 21247.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 2),
                ._orderId = "237660729",
                ._unitSold = 79,
                ._unitPrice = 47.45,
                ._totalRevenue = 3770.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 2),
                ._orderId = "694687259",
                ._unitSold = 23,
                ._unitPrice = 47.45,
                ._totalRevenue = 1068.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 2),
                ._orderId = "779897391",
                ._unitSold = 78,
                ._unitPrice = 152.58,
                ._totalRevenue = 11937.86
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 3),
                ._orderId = "448817956",
                ._unitSold = 41,
                ._unitPrice = 47.45,
                ._totalRevenue = 1927.42
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 3),
                ._orderId = "769822585",
                ._unitSold = 65,
                ._unitPrice = 154.06,
                ._totalRevenue = 9959.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 3),
                ._orderId = "405997025",
                ._unitSold = 24,
                ._unitPrice = 651.21,
                ._totalRevenue = 15609.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 3),
                ._orderId = "991644704",
                ._unitSold = 86,
                ._unitPrice = 668.27,
                ._totalRevenue = 57197.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 4),
                ._orderId = "267614781",
                ._unitSold = 20,
                ._unitPrice = 421.89,
                ._totalRevenue = 8505.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 4),
                ._orderId = "312404668",
                ._unitSold = 63,
                ._unitPrice = 81.73,
                ._totalRevenue = 5180.05
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 4),
                ._orderId = "711141002",
                ._unitSold = 13,
                ._unitPrice = 668.27,
                ._totalRevenue = 8553.86
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 4),
                ._orderId = "446970021",
                ._unitSold = 72,
                ._unitPrice = 154.06,
                ._totalRevenue = 11118.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 5),
                ._orderId = "971377074",
                ._unitSold = 9,
                ._unitPrice = 651.21,
                ._totalRevenue = 5971.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 5),
                ._orderId = "370222795",
                ._unitSold = 60,
                ._unitPrice = 255.28,
                ._totalRevenue = 15334.67
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 5),
                ._orderId = "724799668",
                ._unitSold = 32,
                ._unitPrice = 437.2,
                ._totalRevenue = 13916.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 5),
                ._orderId = "606017291",
                ._unitSold = 28,
                ._unitPrice = 81.73,
                ._totalRevenue = 2319.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 6),
                ._orderId = "359911954",
                ._unitSold = 48,
                ._unitPrice = 152.58,
                ._totalRevenue = 7323.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 6),
                ._orderId = "459212481",
                ._unitSold = 0,
                ._unitPrice = 651.21,
                ._totalRevenue = 214.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 6),
                ._orderId = "566935575",
                ._unitSold = 7,
                ._unitPrice = 9.33,
                ._totalRevenue = 717.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 6),
                ._orderId = "447917163",
                ._unitSold = 75,
                ._unitPrice = 47.45,
                ._totalRevenue = 3557.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 7),
                ._orderId = "681941401",
                ._unitSold = 5,
                ._unitPrice = 47.45,
                ._totalRevenue = 223.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 7),
                ._orderId = "902424991",
                ._unitSold = 65,
                ._unitPrice = 109.28,
                ._totalRevenue = 7062.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 7),
                ._orderId = "366526925",
                ._unitSold = 23,
                ._unitPrice = 152.58,
                ._totalRevenue = 3535.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 7),
                ._orderId = "914391076",
                ._unitSold = 75,
                ._unitPrice = 109.28,
                ._totalRevenue = 8189.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 8),
                ._orderId = "292180383",
                ._unitSold = 5,
                ._unitPrice = 9.33,
                ._totalRevenue = 142.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 8),
                ._orderId = "212874114",
                ._unitSold = 30,
                ._unitPrice = 421.89,
                ._totalRevenue = 12808.58
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 8),
                ._orderId = "722088277",
                ._unitSold = 8,
                ._unitPrice = 9.33,
                ._totalRevenue = 76.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 8),
                ._orderId = "837407815",
                ._unitSold = 64,
                ._unitPrice = 109.28,
                ._totalRevenue = 7033.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 9),
                ._orderId = "225666320",
                ._unitSold = 85,
                ._unitPrice = 437.2,
                ._totalRevenue = 37310.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 9),
                ._orderId = "734526431",
                ._unitSold = 15,
                ._unitPrice = 109.28,
                ._totalRevenue = 1692.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 9),
                ._orderId = "565798747",
                ._unitSold = 13,
                ._unitPrice = 421.89,
                ._totalRevenue = 5387.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 9),
                ._orderId = "784117686",
                ._unitSold = 67,
                ._unitPrice = 154.06,
                ._totalRevenue = 10326.64
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 10),
                ._orderId = "458942115",
                ._unitSold = 0,
                ._unitPrice = 81.73,
                ._totalRevenue = 20.43
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 10),
                ._orderId = "611809146",
                ._unitSold = 680,
                ._unitPrice = 668.27,
                ._totalRevenue = 45288.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 10),
                ._orderId = "332839667",
                ._unitSold = 35,
                ._unitPrice = 651.21,
                ._totalRevenue = 22850.96
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 10),
                ._orderId = "612911641",
                ._unitSold = 30,
                ._unitPrice = 154.06,
                ._totalRevenue = 4668.02
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 11),
                ._orderId = "105390059",
                ._unitSold = 61,
                ._unitPrice = 205.7,
                ._totalRevenue = 12578.56
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 11),
                ._orderId = "219607102",
                ._unitSold = 55,
                ._unitPrice = 47.45,
                ._totalRevenue = 2598.84
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 11),
                ._orderId = "994566810",
                ._unitSold = 33,
                ._unitPrice = 205.7,
                ._totalRevenue = 6736.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 11),
                ._orderId = "676121222",
                ._unitSold = 81,
                ._unitPrice = 205.7,
                ._totalRevenue = 16762.49
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 12),
                ._orderId = "613542068",
                ._unitSold = 96,
                ._unitPrice = 421.89,
                ._totalRevenue = 40446.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 12),
                ._orderId = "689975583",
                ._unitSold = 80,
                ._unitPrice = 255.28,
                ._totalRevenue = 20327.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 12),
                ._orderId = "579379737",
                ._unitSold = 2,
                ._unitPrice = 255.28,
                ._totalRevenue = 495.24
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 12),
                ._orderId = "606970441",
                ._unitSold = 49,
                ._unitPrice = 651.21,
                ._totalRevenue = 31889.75
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 13),
                ._orderId = "461463820",
                ._unitSold = 63,
                ._unitPrice = 154.06,
                ._totalRevenue = 9634.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 13),
                ._orderId = "328236997",
                ._unitSold = 15,
                ._unitPrice = 255.28,
                ._totalRevenue = 3767.93
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 13),
                ._orderId = "334612929",
                ._unitSold = 83,
                ._unitPrice = 81.73,
                ._totalRevenue = 6747.63
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 13),
                ._orderId = "170214545",
                ._unitSold = 91,
                ._unitPrice = 154.06,
                ._totalRevenue = 14051.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 14),
                ._orderId = "469414317",
                ._unitSold = 90,
                ._unitPrice = 205.7,
                ._totalRevenue = 18478.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 14),
                ._orderId = "421043574",
                ._unitSold = 50,
                ._unitPrice = 81.73,
                ._totalRevenue = 4090.59
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 14),
                ._orderId = "635309588",
                ._unitSold = 11,
                ._unitPrice = 421.89,
                ._totalRevenue = 4556.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 14),
                ._orderId = "474178349",
                ._unitSold = 88,
                ._unitPrice = 47.45,
                ._totalRevenue = 4159.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 15),
                ._orderId = "752716100",
                ._unitSold = 43,
                ._unitPrice = 47.45,
                ._totalRevenue = 2028.96
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 15),
                ._orderId = "196587741",
                ._unitSold = 35,
                ._unitPrice = 651.21,
                ._totalRevenue = 23026.79
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 15),
                ._orderId = "352327525",
                ._unitSold = 4,
                ._unitPrice = 668.27,
                ._totalRevenue = 2666.4
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 15),
                ._orderId = "308168065",
                ._unitSold = 26,
                ._unitPrice = 109.28,
                ._totalRevenue = 2877.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 16),
                ._orderId = "823444449",
                ._unitSold = 44,
                ._unitPrice = 154.06,
                ._totalRevenue = 6726.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 16),
                ._orderId = "654480731",
                ._unitSold = 42,
                ._unitPrice = 154.06,
                ._totalRevenue = 6542.93
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 16),
                ._orderId = "410067975",
                ._unitSold = 71,
                ._unitPrice = 205.7,
                ._totalRevenue = 14565.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 16),
                ._orderId = "927232635",
                ._unitSold = 76,
                ._unitPrice = 81.73,
                ._totalRevenue = 6209.03
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 17),
                ._orderId = "916881453",
                ._unitSold = 45,
                ._unitPrice = 205.7,
                ._totalRevenue = 9157.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 17),
                ._orderId = "941323029",
                ._unitSold = 3,
                ._unitPrice = 9.33,
                ._totalRevenue = 677.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 17),
                ._orderId = "252557933",
                ._unitSold = 4,
                ._unitPrice = 9.33,
                ._totalRevenue = 593.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 17),
                ._orderId = "855445134",
                ._unitSold = 41,
                ._unitPrice = 421.89,
                ._totalRevenue = 17213.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 18),
                ._orderId = "246222341",
                ._unitSold = 15,
                ._unitPrice = 255.28,
                ._totalRevenue = 3872.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 18),
                ._orderId = "792983996",
                ._unitSold = 4,
                ._unitPrice = 9.33,
                ._totalRevenue = 41.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 18),
                ._orderId = "884216010",
                ._unitSold = 80,
                ._unitPrice = 668.27,
                ._totalRevenue = 53601.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 18),
                ._orderId = "947779643",
                ._unitSold = 79,
                ._unitPrice = 81.73,
                ._totalRevenue = 6467.29
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 19),
                ._orderId = "584072101",
                ._unitSold = 88,
                ._unitPrice = 255.28,
                ._totalRevenue = 22385.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 19),
                ._orderId = "245042169",
                ._unitSold = 23,
                ._unitPrice = 9.33,
                ._totalRevenue = 212.54
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 19),
                ._orderId = "901573550",
                ._unitSold = 45,
                ._unitPrice = 255.28,
                ._totalRevenue = 11495.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 19),
                ._orderId = "596628272",
                ._unitSold = 44,
                ._unitPrice = 152.58,
                ._totalRevenue = 6742.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 20),
                ._orderId = "702186715",
                ._unitSold = 150,
                ._unitPrice = 668.27,
                ._totalRevenue = 10077.51
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 20),
                ._orderId = "107172334",
                ._unitSold = 35,
                ._unitPrice = 437.2,
                ._totalRevenue = 15433.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 20),
                ._orderId = "143657672",
                ._unitSold = 4,
                ._unitPrice = 651.21,
                ._totalRevenue = 2292.26
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 9, 20),
                ._orderId = "195177543",
                ._unitSold = 62,
                ._unitPrice = 9.33,
                ._totalRevenue = 580.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 21),
                ._orderId = "962186753",
                ._unitSold = 13,
                ._unitPrice = 668.27,
                ._totalRevenue = 8667.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 21),
                ._orderId = "653148210",
                ._unitSold = 99,
                ._unitPrice = 437.2,
                ._totalRevenue = 43387.73
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 21),
                ._orderId = "817192542",
                ._unitSold = 43,
                ._unitPrice = 154.06,
                ._totalRevenue = 6606.09
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 21),
                ._orderId = "446991050",
                ._unitSold = 34,
                ._unitPrice = 109.28,
                ._totalRevenue = 3759.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 22),
                ._orderId = "825143039",
                ._unitSold = 70,
                ._unitPrice = 437.2,
                ._totalRevenue = 30678.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 22),
                ._orderId = "109653699",
                ._unitSold = 78,
                ._unitPrice = 81.73,
                ._totalRevenue = 6392.1
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 22),
                ._orderId = "726708972",
                ._unitSold = 82,
                ._unitPrice = 421.89,
                ._totalRevenue = 34548.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 22),
                ._orderId = "173571383",
                ._unitSold = 25,
                ._unitPrice = 81.73,
                ._totalRevenue = 2030.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 23),
                ._orderId = "635122907",
                ._unitSold = 58,
                ._unitPrice = 255.28,
                ._totalRevenue = 14900.69
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 23),
                ._orderId = "801213872",
                ._unitSold = 58,
                ._unitPrice = 109.28,
                ._totalRevenue = 6386.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 23),
                ._orderId = "613830459",
                ._unitSold = 49,
                ._unitPrice = 205.7,
                ._totalRevenue = 10136.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 23),
                ._orderId = "206435525",
                ._unitSold = 77,
                ._unitPrice = 255.28,
                ._totalRevenue = 19692.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 24),
                ._orderId = "973208701",
                ._unitSold = 290,
                ._unitPrice = 668.27,
                ._totalRevenue = 19620.41
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 9, 24),
                ._orderId = "677394092",
                ._unitSold = 48,
                ._unitPrice = 255.28,
                ._totalRevenue = 12304.5
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 24),
                ._orderId = "600370490",
                ._unitSold = 18,
                ._unitPrice = 81.73,
                ._totalRevenue = 1490.76
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 24),
                ._orderId = "169754493",
                ._unitSold = 30,
                ._unitPrice = 651.21,
                ._totalRevenue = 19419.08
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 25),
                ._orderId = "326714789",
                ._unitSold = 10,
                ._unitPrice = 668.27,
                ._totalRevenue = 6823.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 25),
                ._orderId = "827506387",
                ._unitSold = 64,
                ._unitPrice = 437.2,
                ._totalRevenue = 27910.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 25),
                ._orderId = "826916301",
                ._unitSold = 18,
                ._unitPrice = 154.06,
                ._totalRevenue = 2717.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 25),
                ._orderId = "917834603",
                ._unitSold = 65,
                ._unitPrice = 47.45,
                ._totalRevenue = 3089.0
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 26),
                ._orderId = "214743077",
                ._unitSold = 61,
                ._unitPrice = 81.73,
                ._totalRevenue = 4987.98
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 26),
                ._orderId = "141812741",
                ._unitSold = 44,
                ._unitPrice = 651.21,
                ._totalRevenue = 28627.19
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 26),
                ._orderId = "596870315",
                ._unitSold = 60,
                ._unitPrice = 152.58,
                ._totalRevenue = 9223.46
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 26),
                ._orderId = "551136291",
                ._unitSold = 23,
                ._unitPrice = 109.28,
                ._totalRevenue = 2547.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 27),
                ._orderId = "586165082",
                ._unitSold = 81,
                ._unitPrice = 437.2,
                ._totalRevenue = 35535.62
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 9, 27),
                ._orderId = "607261836",
                ._unitSold = 11,
                ._unitPrice = 668.27,
                ._totalRevenue = 7531.4
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 27),
                ._orderId = "760364902",
                ._unitSold = 77,
                ._unitPrice = 421.89,
                ._totalRevenue = 32595.22
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 27),
                ._orderId = "348286616",
                ._unitSold = 46,
                ._unitPrice = 154.06,
                ._totalRevenue = 7092.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 28),
                ._orderId = "397877871",
                ._unitSold = 98,
                ._unitPrice = 47.45,
                ._totalRevenue = 4630.65
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 28),
                ._orderId = "605373561",
                ._unitSold = 23,
                ._unitPrice = 109.28,
                ._totalRevenue = 2561.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 9, 28),
                ._orderId = "276694810",
                ._unitSold = 90,
                ._unitPrice = 81.73,
                ._totalRevenue = 7354.07
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 9, 28),
                ._orderId = "877259004",
                ._unitSold = 93,
                ._unitPrice = 205.7,
                ._totalRevenue = 19107.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 29),
                ._orderId = "947434604",
                ._unitSold = 58,
                ._unitPrice = 154.06,
                ._totalRevenue = 8947.8
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 9, 29),
                ._orderId = "580854308",
                ._unitSold = 66,
                ._unitPrice = 421.89,
                ._totalRevenue = 27642.23
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 9, 29),
                ._orderId = "146263062",
                ._unitSold = 13,
                ._unitPrice = 651.21,
                ._totalRevenue = 8758.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 9, 29),
                ._orderId = "228836476",
                ._unitSold = 67,
                ._unitPrice = 152.58,
                ._totalRevenue = 10151.15
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 9, 30),
                ._orderId = "891271722",
                ._unitSold = 60,
                ._unitPrice = 109.28,
                ._totalRevenue = 6516.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 9, 30),
                ._orderId = "140635573",
                ._unitSold = 60,
                ._unitPrice = 154.06,
                ._totalRevenue = 9314.47
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 9, 30),
                ._orderId = "866004025",
                ._unitSold = 87,
                ._unitPrice = 47.45,
                ._totalRevenue = 4123.88
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 9, 30),
                ._orderId = "157244670",
                ._unitSold = 10,
                ._unitPrice = 437.2,
                ._totalRevenue = 4577.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 10, 1),
                ._orderId = "682831895",
                ._unitSold = 40,
                ._unitPrice = 47.45,
                ._totalRevenue = 1891.83
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 10, 1),
                ._orderId = "531067359",
                ._unitSold = 35,
                ._unitPrice = 421.89,
                ._totalRevenue = 14715.52
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 10, 1),
                ._orderId = "155710446",
                ._unitSold = 70,
                ._unitPrice = 154.06,
                ._totalRevenue = 10839.66
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 10, 1),
                ._orderId = "522921168",
                ._unitSold = 28,
                ._unitPrice = 154.06,
                ._totalRevenue = 4389.17
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 10, 2),
                ._orderId = "886628711",
                ._unitSold = 20,
                ._unitPrice = 47.45,
                ._totalRevenue = 945.68
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 10, 2),
                ._orderId = "738839423",
                ._unitSold = 79,
                ._unitPrice = 421.89,
                ._totalRevenue = 33156.34
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 10, 2),
                ._orderId = "574441039",
                ._unitSold = 87,
                ._unitPrice = 437.2,
                ._totalRevenue = 38141.33
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 10, 2),
                ._orderId = "866792809",
                ._unitSold = 21,
                ._unitPrice = 152.58,
                ._totalRevenue = 3217.91
            })
            list.Add(New SalesOrder With {
                ._itemType = "BabyFood",
                ._orderDate = New DateTime(2020, 10, 3),
                ._orderId = "298856723",
                ._unitSold = 72,
                ._unitPrice = 255.28,
                ._totalRevenue = 18380.16
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 10, 3),
                ._orderId = "398511302",
                ._unitSold = 720,
                ._unitPrice = 668.27,
                ._totalRevenue = 48148.85
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 10, 3),
                ._orderId = "903278148",
                ._unitSold = 89,
                ._unitPrice = 205.7,
                ._totalRevenue = 18373.12
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 10, 3),
                ._orderId = "522371423",
                ._unitSold = 2,
                ._unitPrice = 152.58,
                ._totalRevenue = 254.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 10, 4),
                ._orderId = "688344371",
                ._unitSold = 3,
                ._unitPrice = 9.33,
                ._totalRevenue = 489.92
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 10, 4),
                ._orderId = "177950036",
                ._unitSold = 82,
                ._unitPrice = 152.58,
                ._totalRevenue = 12549.71
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 10, 4),
                ._orderId = "141977107",
                ._unitSold = 30,
                ._unitPrice = 651.21,
                ._totalRevenue = 19770.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 10, 4),
                ._orderId = "630488908",
                ._unitSold = 45,
                ._unitPrice = 205.7,
                ._totalRevenue = 9326.44
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 10, 5),
                ._orderId = "733528649",
                ._unitSold = 63,
                ._unitPrice = 152.58,
                ._totalRevenue = 9586.6
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 10, 5),
                ._orderId = "604041039",
                ._unitSold = 80,
                ._unitPrice = 81.73,
                ._totalRevenue = 6556.38
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 10, 5),
                ._orderId = "798784863",
                ._unitSold = 70,
                ._unitPrice = 437.2,
                ._totalRevenue = 30809.48
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 10, 5),
                ._orderId = "607190167",
                ._unitSold = 99,
                ._unitPrice = 47.45,
                ._totalRevenue = 4706.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 10, 6),
                ._orderId = "919890248",
                ._unitSold = 48,
                ._unitPrice = 421.89,
                ._totalRevenue = 20339.32
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 10, 6),
                ._orderId = "105966842",
                ._unitSold = 8,
                ._unitPrice = 9.33,
                ._totalRevenue = 634.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Vegetables",
                ._orderDate = New DateTime(2020, 10, 6),
                ._orderId = "954092919",
                ._unitSold = 62,
                ._unitPrice = 154.06,
                ._totalRevenue = 9477.77
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 10, 6),
                ._orderId = "129268586",
                ._unitSold = 23,
                ._unitPrice = 205.7,
                ._totalRevenue = 4735.21
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 10, 7),
                ._orderId = "228097045",
                ._unitSold = 78,
                ._unitPrice = 437.2,
                ._totalRevenue = 34272.11
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 10, 7),
                ._orderId = "521787345",
                ._unitSold = 7,
                ._unitPrice = 9.33,
                ._totalRevenue = 683.42
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 10, 7),
                ._orderId = "692956054",
                ._unitSold = 100,
                ._unitPrice = 81.73,
                ._totalRevenue = 8132.14
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 10, 7),
                ._orderId = "958937633",
                ._unitSold = 98,
                ._unitPrice = 109.28,
                ._totalRevenue = 10720.37
            })
            list.Add(New SalesOrder With {
                ._itemType = "Snacks",
                ._orderDate = New DateTime(2020, 10, 8),
                ._orderId = "927766072",
                ._unitSold = 55,
                ._unitPrice = 152.58,
                ._totalRevenue = 8320.19
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 10, 8),
                ._orderId = "148871457",
                ._unitSold = 32,
                ._unitPrice = 205.7,
                ._totalRevenue = 6637.94
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 10, 8),
                ._orderId = "866053378",
                ._unitSold = 33,
                ._unitPrice = 437.2,
                ._totalRevenue = 14405.74
            })
            list.Add(New SalesOrder With {
                ._itemType = "Beverages",
                ._orderDate = New DateTime(2020, 10, 8),
                ._orderId = "944415509",
                ._unitSold = 24,
                ._unitPrice = 47.45,
                ._totalRevenue = 1134.53
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 10, 9),
                ._orderId = "721767270",
                ._unitSold = 58,
                ._unitPrice = 205.7,
                ._totalRevenue = 11990.25
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cereal",
                ._orderDate = New DateTime(2020, 10, 9),
                ._orderId = "629709136",
                ._unitSold = 38,
                ._unitPrice = 205.7,
                ._totalRevenue = 7779.57
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 10, 9),
                ._orderId = "811701095",
                ._unitSold = 92,
                ._unitPrice = 651.21,
                ._totalRevenue = 60217.39
            })
            list.Add(New SalesOrder With {
                ._itemType = "Clothes",
                ._orderDate = New DateTime(2020, 10, 9),
                ._orderId = "763920438",
                ._unitSold = 99,
                ._unitPrice = 109.28,
                ._totalRevenue = 10805.61
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 10, 10),
                ._orderId = "869832932",
                ._unitSold = 17,
                ._unitPrice = 668.27,
                ._totalRevenue = 11688.04
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 10, 10),
                ._orderId = "109358012",
                ._unitSold = 3,
                ._unitPrice = 81.73,
                ._totalRevenue = 262.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 10, 10),
                ._orderId = "674421346",
                ._unitSold = 51,
                ._unitPrice = 437.2,
                ._totalRevenue = 22375.9
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 10, 10),
                ._orderId = "408834159",
                ._unitSold = 20,
                ._unitPrice = 651.21,
                ._totalRevenue = 12815.81
            })
            list.Add(New SalesOrder With {
                ._itemType = "OfficeSupplies",
                ._orderDate = New DateTime(2020, 10, 11),
                ._orderId = "256243503",
                ._unitSold = 70,
                ._unitPrice = 651.21,
                ._totalRevenue = 45597.72
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 10, 11),
                ._orderId = "377938973",
                ._unitSold = 94,
                ._unitPrice = 81.73,
                ._totalRevenue = 7679.35
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 10, 11),
                ._orderId = "701816356",
                ._unitSold = 9,
                ._unitPrice = 9.33,
                ._totalRevenue = 178.2
            })
            list.Add(New SalesOrder With {
                ._itemType = "PersonalCare",
                ._orderDate = New DateTime(2020, 10, 11),
                ._orderId = "803517568",
                ._unitSold = 76,
                ._unitPrice = 81.73,
                ._totalRevenue = 6177.97
            })
            list.Add(New SalesOrder With {
                ._itemType = "Household",
                ._orderDate = New DateTime(2020, 10, 12),
                ._orderId = "306859576",
                ._unitSold = 540,
                ._unitPrice = 668.27,
                ._totalRevenue = 36240.28
            })
            list.Add(New SalesOrder With {
                ._itemType = "Fruits",
                ._orderDate = New DateTime(2020, 10, 12),
                ._orderId = "987714517",
                ._unitSold = 5,
                ._unitPrice = 9.33,
                ._totalRevenue = 515.95
            })
            list.Add(New SalesOrder With {
                ._itemType = "Cosmetics",
                ._orderDate = New DateTime(2020, 10, 12),
                ._orderId = "461065137",
                ._unitSold = 83,
                ._unitPrice = 437.2,
                ._totalRevenue = 36178.3
            })
            list.Add(New SalesOrder With {
                ._itemType = "Meat",
                ._orderDate = New DateTime(2020, 10, 12),
                ._orderId = "614994323",
                ._unitSold = 93,
                ._unitPrice = 421.89,
                ._totalRevenue = 39408.74
            })
            Dim count As Integer = 1

            For Each item In list
                item.Number = count
                count += 1
            Next

            Return list
        End Function
    End Class
End Namespace
