'Última Atualização:    27/11/2024
'Data:                  25/03/2025
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class FormInventarioFinalizado
    Private SQLite As New ConnectionFactory
    Private MySQL As New ConnectionFactory
    Private Inventario As InventariosDTO
    Private Situacao As String

    Sub New(Optional _inventario As InventariosDTO = Nothing, Optional _situacao As String = "")
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        SQLite = New ConnectionFactory()
        MySQL = New ConnectionFactory(DatabaseType.MySQL)
        If ChkAbrirRelatorio.Checked Then ChkBensEncontrados.Enabled = True
        Inventario = _inventario
        Situacao = _situacao
    End Sub

    Private Sub FormInventarioFinalizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Inventario IsNot Nothing Then
            If Situacao = "Reaberto" And Not Inventario.Inventario_Teste Then
                GpbSincronizar.Visible = True
                GpbSincronizar.Location = New Point(45, 103)
                Me.Size = New Size(400, 342)
                BtnFinalizar.Location = New Point(97, 244)
            Else
                GpbSincronizar.Visible = False
                Me.Size = New Size(400, 227)
                BtnFinalizar.Location = New Point(97, 116)
            End If
        Else
            GpbSincronizar.Visible = False
            Me.Size = New Size(400, 227)
            BtnFinalizar.Location = New Point(97, 116)
        End If
    End Sub

    Private Sub ChkAbrirRelatorio_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAbrirRelatorio.CheckedChanged
        If ChkSincronizar.Checked AndAlso ChkAbrirRelatorio.Checked Then
            ChkBensEncontrados.Enabled = True
            ChkBensEncontrados.Visible = True
            BtnFinalizar.Text = "Gerar Relatório e Sincronizar"
        ElseIf ChkAbrirRelatorio.Checked Then
            ChkBensEncontrados.Enabled = True
            ChkBensEncontrados.Visible = True
            BtnFinalizar.Text = "Gerar Relatório"
        ElseIf ChkSincronizar.Checked Then
            ChkBensEncontrados.Enabled = False
            ChkBensEncontrados.Visible = False
            BtnFinalizar.Text = "Apenas Sincronizar"
        Else
            ChkBensEncontrados.Enabled = False
            ChkBensEncontrados.Visible = False
            BtnFinalizar.Text = "Apenas Finalizar"
        End If
    End Sub

    Private Sub ChkSincronizar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSincronizar.CheckedChanged
        If ChkSincronizar.Checked AndAlso ChkAbrirRelatorio.Checked Then
            ChkBensEncontrados.Enabled = True
            ChkBensEncontrados.Visible = True
            BtnFinalizar.Text = "Gerar Relatório e Sincronizar"
        ElseIf ChkAbrirRelatorio.Checked Then
            ChkBensEncontrados.Enabled = True
            ChkBensEncontrados.Visible = True
            BtnFinalizar.Text = "Gerar Relatório"
        ElseIf ChkSincronizar.Checked Then
            ChkBensEncontrados.Enabled = False
            ChkBensEncontrados.Visible = False
            BtnFinalizar.Text = "Apenas Sincronizar"
        Else
            ChkBensEncontrados.Enabled = False
            ChkBensEncontrados.Visible = False
            BtnFinalizar.Text = "Apenas Finalizar"
        End If
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim Form As Form
        If Situacao = "Aberto" Then ReplicarDados(SyncOrigem.Enviar, "inventarios", Inventario.Id, "Inserir")
        If Inventario IsNot Nothing AndAlso Not Inventario.Inventario_Teste Then
            If ChkSincronizar.Checked Then ReplicarDados(SyncOrigem.Enviar, "inventarios", Inventario.Id, "Atualizar")
        End If
        If ChkAbrirRelatorio.Checked Then
            If ChkBensEncontrados.Checked Then
                Form = New FormInventarioRelatorioFinal(True)
            Else
                Form = New FormInventarioRelatorioFinal()
            End If
            Form.ShowDialog()
            VarGlob.Id_Inventario_Ativo = String.Empty
        End If
        Close()
    End Sub

End Class