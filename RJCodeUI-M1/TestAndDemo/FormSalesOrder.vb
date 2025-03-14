Imports PROJETOBASE.Models

Public Class FormSalesOrder
    Inherits RJChildForm

#Region "-> Fields"
    Private rows As Integer = 8
    Private starIndex As Integer = 0
    Private isDragging As Boolean = False
    Private salesList As List(Of SalesOrder) = New List(Of SalesOrder)()
    Private salesOrder As SalesOrder = New SalesOrder()
    Private analysis As SalesAnalysis = New SalesAnalysis()
#End Region

#Region "-> Constructor"

    Public Sub New()
        InitializeComponent()
        LoadComboBoxs()
        LoadPageDatagridView()
        lblNumberItems.Text = "Total item: " & salesOrder.GetSalesList().Count.ToString()
    End Sub
#End Region

#Region "-> Private methods"

    Private Sub LoadPageDatagridView()
        salesList.Clear()
        RjDataGridView1.DataSource = Nothing
        salesList.AddRange(salesOrder.GetSalesList().GetRange(starIndex, rows))
        RjDataGridView1.DataSource = salesList
    End Sub

    Private Sub LoadComboBoxs()
        Dim categories = New List(Of SalesAnalysis.SalesByCategory)()
        categories.AddRange(analysis.SalesByCategoryList)
        categories.Add(New SalesAnalysis.SalesByCategory With {
            .Item = "All"
        })

        cbCategory.DataSource = categories
        cbCategory.DisplayMember = "Item"
        cbCategory.SelectedIndex = categories.Count - 1

        cbPeriod.SelectedIndex = 5
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub btnNextPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNextPage.Click
        starIndex = (salesOrder.GetSalesList().FindIndex(Function(a) a.OrderId = salesList.LastOrDefault().OrderId)) + 1
        If starIndex <= salesOrder.GetSalesList().Count - 1 Then LoadPageDatagridView()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RjButton2.Click
        starIndex = (salesOrder.GetSalesList().FindIndex(Function(a) a.OrderId = salesList.FirstOrDefault().OrderId)) - rows
        If starIndex >= 0 Then LoadPageDatagridView()
    End Sub

    Private Sub FormSalesOrder_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
        isDragging = True
    End Sub

    Private Sub FormSalesOrder_ResizeEnd(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ResizeEnd
        If Not isDragging Then
            rows = RjDataGridView1.Height / RjDataGridView1.Rows(0).Height - 1
            LoadPageDatagridView()
        End If

        isDragging = False
    End Sub

    Private Sub FormSalesOrder_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            rows = RjDataGridView1.Height / RjDataGridView1.Rows(0).Height - 1
            LoadPageDatagridView()
        End If
    End Sub


#End Region

End Class