'Última Atualização:    31/10/2024
'Data:                  31/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima


Public Class FormInventarioLeitorScanner
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private inventarioDetalhesBLL As InventarioDetalhesBLL
    Private Log As New Logger
    Private rowIndex As Integer = 0
    Private colIndex As Integer = 0

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        inventarioDetalhesBLL = New InventarioDetalhesBLL(SQLite)
    End Sub

    Private Sub FormLeitorScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEtiqueta.Focus()
    End Sub


    ' Evento TextChanged para verificar se o comprimento é 12
    Private Sub TxtEtiqueta_TextChanged(sender As Object, e As EventArgs) Handles TxtEtiqueta.TextChanged
        If TxtEtiqueta.Text.Length = 12 Then
            Salvar(TxtEtiqueta.Text)
            TxtEtiqueta.Text = String.Empty
        End If

        ' Usando BeginInvoke para garantir que o foco seja aplicado após o evento
        BeginInvoke(New Action(Sub() TxtEtiqueta.Select()))
        BeginInvoke(New Action(Sub() TxtEtiqueta.Focus()))
    End Sub

    ' Evento KeyPress para permitir apenas números e acionar a verificação ao pressionar Enter
    Private Sub TxtEtiqueta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEtiqueta.KeyPress
        ' Permite apenas números e teclas de controle como Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If
        'Console.WriteLine("Tecla: " & (e.KeyChar))
        ' Verifica se Enter foi pressionado e o texto tem 12 caracteres
        If (e.KeyChar = ChrW(Keys.Enter) OrElse e.KeyChar = ChrW(Keys.Tab)) AndAlso TxtEtiqueta.Text.Length = 12 Then
            Salvar(TxtEtiqueta.Text)
            e.Handled = True ' Impede o som de "beep" ao pressionar Enter
            TxtEtiqueta.Text = String.Empty
            ' Usando BeginInvoke para garantir que o foco seja aplicado após o evento
            BeginInvoke(New Action(Sub() TxtEtiqueta.Select()))
        End If
    End Sub

    ' Função para verificar se a etiqueta existe no banco de dados e preencher o DataGridView
    Private Sub Salvar(Etiqueta As String)
        Dim Observacao As String = ""
        Etiqueta = SanitizeString(Etiqueta)
        If Etiqueta.Length = 12 Then
            Try
                'Instanciamento de objetos
                Dim bensBLL As New BensBLL(SQLite)
                Dim inventarioBLL As New InventariosBLL(SQLite)
                Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
                'Buscando dados dos objetos
                Dim BemMovel As BensDTO = bensBLL.BuscarPorId(Etiqueta)
                Dim Inventario As InventariosDTO = inventarioBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
                Dim InventarioDetalhes As InventarioDetalhesDTO = inventarioDetalhesBLL.BuscarPorId(Etiqueta)

                Dim Id_igreja As String = VarGlob.Id_Inventario_Ativo.Substring(0, 6).ToString()
                If BemMovel IsNot Nothing Then
                    If InventarioDetalhes IsNot Nothing Then
                        If BemMovel.Id_igreja = Id_igreja Then
                            InventarioDetalhes.Bem = String.Empty
                            InventarioDetalhes.Dependencia = String.Empty
                            InventarioDetalhes.Estado = "OK"
                            InventarioDetalhes.Acao = "OK"
                            InventarioDetalhes.Contagem = InventarioDetalhes.Contagem + 1
                            If BemMovel.Status = "ATIVO" Then
                                inventarioDetalhesBLL.Atualizar(InventarioDetalhes)
                            Else
                                inventarioDetalhesBLL.Inserir(InventarioDetalhes)
                                Inventario.Bens_Inicial = CInt(Inventario.Bens_Inicial) + 1
                                inventarioBLL.Atualizar(Inventario)
                            End If
                            Observacao = If(InventarioDetalhes.Contagem > 1, "Repetido", "Localizado")
                        Else
                            Dim InventarioDetalhe As New InventarioDetalhesDTO With {
                                .Id_inventario = VarGlob.Id_Inventario_Ativo,
                                .Id_Bem = Etiqueta,
                                .Estado = "PENDENTE",
                                .Acao = "TRANSFERIR",
                                .Observacao = $"TRANSFERIR DE: {Id_igreja}. BEM DE OUTRA IGREJA",
                                .Contagem = 1
                                }

                            inventarioDetalhesBLL.Inserir(InventarioDetalhe)
                            Inventario.Bens_Inicial = CInt(Inventario.Bens_Inicial) + 1
                            inventarioBLL.Atualizar(Inventario)
                            Observacao = "De Outra Igreja"
                        End If

                    Else
                        If BemMovel.Id_igreja = Id_igreja Then
                            Dim InventarioDetalhe As New InventarioDetalhesDTO With {
                                .Id_inventario = VarGlob.Id_Inventario_Ativo,
                                .Id_Bem = Etiqueta,
                                .Estado = "OK",
                                .Acao = "OK",
                                .Contagem = 1
                                }

                            inventarioDetalhesBLL.Inserir(InventarioDetalhe)
                            Dim Qtde As Integer = CInt(Inventario.Bens_Inicial) + 1
                            Inventario.Bens_Inicial = Qtde
                            inventarioBLL.Atualizar(Inventario)

                            Observacao = "Incluído"
                        Else
                            Dim InventarioDetalhe As New InventarioDetalhesDTO With {
                                .Id_inventario = VarGlob.Id_Inventario_Ativo,
                                .Id_Bem = Etiqueta,
                                .Estado = "PENDENTE",
                                .Acao = "TRANSFERIR",
                                .Observacao = $"TRANSFERIR DE: {Id_igreja}. BEM DE OUTRA IGREJA",
                                .Contagem = 1
                                }

                            inventarioDetalhesBLL.Inserir(InventarioDetalhe)
                            Inventario.Bens_Inicial = CInt(Inventario.Bens_Inicial) + 1
                            inventarioBLL.Atualizar(Inventario)
                            Observacao = "De Outra Igreja"
                        End If
                    End If
                    ' Adiciona uma linha com os dados do bem encontrado
                    DgvLidos.Rows.Add(Etiqueta, BemMovel.Descricao, Observacao)
                Else
                    ' Adiciona uma linha indicando que o bem não foi encontrado
                    DgvLidos.Rows.Add(Etiqueta, "", "Sem Cadastro")
                End If
                If DgvLidos.Rows.Count > 0 Then Label1.Text = DgvLidos.Rows.Count & " Lidos"
                Me.BeginInvoke(New Action(Sub() TxtEtiqueta.Select()))
            Catch ex As Exception
                Throw New Exception("Falha ao Checar Etiqueta" & vbNewLine & ex.Message)
            End Try
        Else
            Log.WriteLog($"Etiqueta nº {Etiqueta} incorreta")
        End If
    End Sub

    Private Sub DgvLidos_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvLidos.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                ' Verifica se a linha e a célula são válidas antes de selecionar
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    DgvLidos.ClearSelection()
                    DgvLidos.Rows(e.RowIndex).Selected = True
                    rowIndex = e.RowIndex
                    colIndex = e.ColumnIndex

                    ' Verifica se a célula é visível antes de defini-la como a célula atual
                    If DgvLidos.Rows(e.RowIndex).Cells(2).Visible Then
                        DgvLidos.CurrentCell = DgvLidos.Rows(e.RowIndex).Cells(2)
                        ' Exibe o menu de contexto no local do cursor
                        DpwMenuExportar.Show(Cursor.Position)
                    End If
                End If
            Catch ex As Exception
                RJMessageBox.Show($"Sem opção de Menu para esta consulta. {vbNewLine & ex.Message}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuExcel_Click(sender As Object, e As EventArgs) Handles ToolStripMenuExcel.Click
        ExportarParaExcel(DgvLidos)
    End Sub

    Private Sub ToolStripMenuTxt_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTxt.Click
        ExportarParaTXT(DgvLidos)
    End Sub

    Private Sub ToolStripMenuPdf_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPdf.Click
        ExportarParaPDF(DgvLidos)
    End Sub

    Private Sub ToolStripMenuCelula_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCelula.Click
        CopiarCelulaParaClipboard(DgvLidos, colIndex)
    End Sub

    Private Sub ToolStripMenuLinha_Click(sender As Object, e As EventArgs) Handles ToolStripMenuLinha.Click
        CopiarLinhaParaClipboard(DgvLidos)
    End Sub

    Private Sub ToolStripMenuTudo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTudo.Click
        CopiarTudoParaClipboard(DgvLidos)
    End Sub

End Class