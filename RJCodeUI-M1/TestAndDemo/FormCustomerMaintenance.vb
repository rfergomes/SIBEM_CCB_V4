Public Class FormCustomerMaintenance

    Public Sub New()
        InitializeComponent()
        lblTitle.Text = "Add new client"
        btnSave.Text = "Add"
    End Sub

    Public Sub New(ByVal customer As Models.Customer)
        InitializeComponent()
        lblTitle.Select()
        lblTitle.Text = "Modify customer"
        btnSave.Text = "Save"
        txtNames.Text = customer.Names
        txtEmail.Text = customer.Email
        txtPhone.Text = customer.PhoneNumber
        txtAddress.Text = customer.StreetAddres
    End Sub

End Class