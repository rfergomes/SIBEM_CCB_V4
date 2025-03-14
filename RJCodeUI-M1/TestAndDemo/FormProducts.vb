Imports PROJETOBASE.Models

Public Class FormProducts
    Inherits RJChildForm

    Private analysis As SalesAnalysis = New SalesAnalysis()

    Public Sub New()
        InitializeComponent()
        RjDataGridView1.DataSource = New Product().GetProductsList()

        Dim categories = New List(Of SalesAnalysis.SalesByCategory)()
        categories.AddRange(analysis.SalesByCategoryList)
        categories.Add(New SalesAnalysis.SalesByCategory With {
            .Item = "All"
        })

        RjComboBox1.DataSource = categories
        RjComboBox1.DisplayMember = "Item"
        RjComboBox1.SelectedIndex = categories.Count - 1
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim frmProduct = New FormProductMaintenance()
        frmProduct.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Dim id As Integer = CInt(RjDataGridView1.CurrentRow.Cells(0).Value)
        Dim product = New Product().GetProductsList().FirstOrDefault(Function(t) t.Id = id)
        Dim frmProduct = New FormProductMaintenance(product)
        frmProduct.ShowDialog()
    End Sub
End Class