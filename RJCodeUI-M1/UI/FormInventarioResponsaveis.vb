Public Class FormInventarioResponsaveis
    Private SQLite As New ConnectionFactory()
    Private ReadOnly inventariosBLL As InventariosBLL

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        inventariosBLL = New InventariosBLL(SQLite)
    End Sub

    Private Sub FormInventarioResponsaveis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getResponsaveis()
    End Sub

    Private Sub getResponsaveis()
        Dim Inventario As InventariosDTO = inventariosBLL.BuscarPorId(VarGlob.Inventario.Id)

        If Inventario IsNot Nothing Then
            TxtResponsaveis.Text = Inventario.Responsaveis
            TxtInventariantes.Text = Inventario.Inventariantes
        Else
            RJMessageBox.Show("Inventário não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim Inventario As InventariosDTO = inventariosBLL.BuscarPorId(VarGlob.Inventario.Id)

        If Inventario IsNot Nothing Then
            Inventario.Responsaveis = SanitizeString(TxtResponsaveis.Text, True)
            Inventario.Inventariantes = SanitizeString(TxtInventariantes.Text, True)
            inventariosBLL.Atualizar(Inventario)
            RJMessageBox.Show("Dados atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CloseWindow()
        Else
            RJMessageBox.Show("Inventário não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtanCancelar_Click(sender As Object, e As EventArgs) Handles BtanCancelar.Click
        CloseWindow()
    End Sub
End Class