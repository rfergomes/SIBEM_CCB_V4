Imports PROJETOBASE.Models

Public Class FormProductMaintenance
    Inherits RJChildForm

    Public Sub New()
        InitializeComponent()
        lblTitle.Text = "Add new product"
        btnSave.Text = "Add"
    End Sub

    Public Sub New(ByVal product As Product)
        InitializeComponent()
        lblTitle.Text = "Edit product"
        btnSave.Text = "Save"
        txtID.Text = product.Id.ToString()
        txtProduct.Text = product.Item
        txtStock.Text = product.Stock.ToString()
        txtUnitPrice.Text = product.UnitPrice.ToString()
        txtID.Enabled = False
        lblTitle.Select()
    End Sub
End Class