'Última Atualização:    27/11/2024
'Data:                  26/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class FormInventarioFinalizado
    Private SQLite As New ConnectionFactory
    Private MySQL As New ConnectionFactory

    Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        SQLite = New ConnectionFactory()
        MySQL = New ConnectionFactory(DatabaseType.MySQL)
        If ChkAbrirRelatorio.Checked Then ChkBensEncontrados.Enabled = True
    End Sub

    Private Sub ChkAbrirRelatorio_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAbrirRelatorio.CheckedChanged
        If ChkAbrirRelatorio.Checked Then
            ChkBensEncontrados.Enabled = True
            BtnFinalizar.Text = "Ok"
        Else
            ChkBensEncontrados.Enabled = False
            ChkBensEncontrados.Checked = False
            BtnFinalizar.Text = "Cancelar"
        End If
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim Form As Form
        If ChkAbrirRelatorio.Checked Then
            If ChkBensEncontrados.Checked Then
                Form = New FormInventarioRelatorioFinal(True)
            Else
                Form = New FormInventarioRelatorioFinal()
            End If
            Form.ShowDialog()
            VarGlob.Id_Inventario_Ativo = 0
        End If
        Close()
    End Sub
End Class