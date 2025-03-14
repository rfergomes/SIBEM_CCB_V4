Imports PROJETOBASE.Models

Public Class FormCustomer
    Inherits RJChildForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RjDataGridView1.DataSource = New Customer().GetCustomerList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmCustomer = New FormCustomerMaintenance()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id = RjDataGridView1.CurrentRow.Cells(2).Value.ToString()
        Dim customer = New Customer().GetCustomerList().FirstOrDefault(Function(t) t.Email = id)
        Dim frmCustomer = New FormCustomerMaintenance(customer)
        frmCustomer.ShowDialog()
    End Sub
End Class