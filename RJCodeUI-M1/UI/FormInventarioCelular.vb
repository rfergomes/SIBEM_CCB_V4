Imports System.IO
Imports System.Linq.Expressions
Imports DynamicData.Kernel
Imports FontAwesome.Sharp
Imports Microsoft.Reporting.WinForms
Imports Microsoft.Vbe.Interop
Imports System.Runtime.InteropServices

Public Class FormInventarioCelular
    Private ReadOnly igrejaBLL As IgrejasBLL
    Private ReadOnly inventarioBLL As InventariosBLL
    Private ReadOnly inventarioDetalhesBLL As InventarioDetalhesBLL
    Private ReadOnly bensBLL As BensBLL
    Private ReadOnly banco As ConnectionFactory
    Private rowIndex As Integer = 0
    Private colIndex As Integer = 0

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Conexão com Banco de dados
        banco = New ConnectionFactory(DatabaseType.SQLite)
        igrejaBLL = New IgrejasBLL(banco)
        inventarioBLL = New InventariosBLL(banco)
        inventarioDetalhesBLL = New InventarioDetalhesBLL(banco)
        bensBLL = New BensBLL(banco)

        ' Regras de inicialização
        LblInventario.Text = VarGlob.Id_Inventario_Ativo
        LblIgreja.Text = VarGlob.Inventario.Igreja
        LblTotalLista.Text = "Total: 0 registros"
        CboColunas.Clear()
        Card1.Visible = False
        Card2.Visible = False
        Card3.Visible = False
        Card4.Visible = False
        RjProgressBar1.Visible = False
    End Sub

    Private Sub FormInventarioCelular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        Using openFileDialog As New OpenFileDialog
            ' Configurações do OpenFileDialog
            openFileDialog.Filter = "Arquivos de Texto|*.txt;*.csv"
            openFileDialog.Title = "Selecione um arquivo de código de barras"

            ' Exibe o diálogo
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Exibe o caminho do arquivo selecionado no TextBox
                TxtArquivo.Text = openFileDialog.FileName

                Dim caminhoArquivo As String = openFileDialog.FileName
                Dim delimitador As String = DetectarDelimitador(caminhoArquivo) ' Detecta o delimitador automaticamente
                Dim tabela As DataTable = LerArquivoParaDataTable(caminhoArquivo, delimitador) ' Lê o arquivo e converte para DataTable

                If tabela IsNot Nothing Then
                    ' Popula o DataGridView
                    With DgvDados
                        .DataSource = Nothing
                        .DataSource = tabela
                    End With
                    LblTotalLista.Text = $"Total: {DgvDados.Rows.Count} registros"
                    PopularComboBoxComColunas(DgvDados, CboColunas) ' Popula o ComboBox com as colunas do DataGridView
                Else
                    BtnLimpar_Click(sender, e)
                    MessageBox.Show("Não foi possível importar os dados. Verifique o arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Detecta automaticamente o delimitador usado no arquivo com base na primeira linha.
    ''' </summary>
    Private Function DetectarDelimitador(caminhoArquivo As String) As String
        Dim delimitadores As String() = {",", ";", vbTab} ' Lista de delimitadores possíveis
        Dim primeiraLinha As String = File.ReadLines(caminhoArquivo).FirstOrDefault()

        If primeiraLinha IsNot Nothing Then
            For Each delimitador In delimitadores
                If primeiraLinha.Contains(delimitador) Then
                    Return delimitador ' Retorna o delimitador encontrado
                End If
            Next
        End If

        ' Caso nenhum delimitador seja detectado, retorna vírgula como padrão
        Return ","
    End Function

    ''' <summary>
    ''' Lê o arquivo com o delimitador especificado e converte para um DataTable.
    ''' </summary>
    Private Function LerArquivoParaDataTable(caminhoArquivo As String, delimitador As String) As DataTable
        Dim tabela As New DataTable()

        Try
            Using leitor As New StreamReader(caminhoArquivo)
                Dim cabecalho As String = leitor.ReadLine() ' Lê a primeira linha (cabeçalho)
                If String.IsNullOrEmpty(cabecalho) Then Return Nothing

                ' Cria as colunas do DataTable com base no cabeçalho
                Dim colunas As String() = cabecalho.Split(delimitador)
                For Each coluna In colunas
                    tabela.Columns.Add(coluna.Trim())
                Next

                ' Lê as linhas subsequentes e adiciona ao DataTable
                While Not leitor.EndOfStream
                    Dim linha As String = leitor.ReadLine()
                    If Not String.IsNullOrEmpty(linha) Then
                        Dim valores As String() = linha.Split(delimitador)
                        tabela.Rows.Add(valores)
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Erro ao importar arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

        Return tabela
    End Function

    Private Sub PopularComboBoxComColunas(dgv As DataGridView, cbo As RJComboBox)
        cbo.Items.Clear() ' Limpa os itens existentes no ComboBox

        ' Adiciona os nomes das colunas ao ComboBox
        For Each coluna As DataGridViewColumn In dgv.Columns
            cbo.Items.Add(coluna.HeaderText)
        Next

        ' Seleciona o primeiro item por padrão (opcional)
        If cbo.Items.Count > 0 Then
            cbo.SelectedIndex = 0
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtArquivo.Clear()
        DgvDados.DataSource = Nothing
        DgvDados.Columns.Clear()
        CboColunas.Clear()
        LblTotalLista.Text = "Total: 0 registros"
    End Sub

    Private Sub DgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDados.CellClick
        ' Verifica se o índice da coluna é válido
        If e.ColumnIndex >= 0 Then
            ' Obtém o nome da coluna clicada
            Dim nomeColuna As String = DgvDados.Columns(e.ColumnIndex).HeaderText
            CboColunas.SelectedItem = nomeColuna
        End If
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Card1.Visible = True
        Card2.Visible = True
        Card3.Visible = True
        Card4.Visible = True
        LblErros.Text = 0
        LblOK.Text = 0
        LblRepetidos.Text = 0
        LblOutraCO.Text = 0

        ' Verifica se há linhas no DataGridView
        If DgvDados.Rows.Count > 0 Then
            ' Nome da coluna selecionada no ComboBox
            Dim nomeColunaSelecionada As String = CboColunas.SelectedItem?.ToString()

            If String.IsNullOrEmpty(nomeColunaSelecionada) Then
                RJMessageBox.Show("Por favor, selecione uma coluna no ComboBox.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Verifica se a coluna existe no DataGridView
            If Not DgvDados.Columns.Contains(nomeColunaSelecionada) Then
                RJMessageBox.Show($"A coluna '{nomeColunaSelecionada}' não existe no DataGridView.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim cont As Integer = 1
            With RjProgressBar1
                .Minimum = 0
                .Maximum = 100
                .Value = cont
                .Visible = True
            End With

            ' Percorre os itens da coluna selecionada
            Dim valores As New List(Of String)
            If Not DgvDados.Columns.Contains("Resultado") Then
                DgvDados.Columns.Add("Resultado", "Resultado")
            End If

            For Each row As DataGridViewRow In DgvDados.Rows
                RjProgressBar1.Value = CInt((cont / DgvDados.Rows.Count) * 100)
                Refresh()
                ' Verifica se a linha não é uma linha nova
                If Not row.IsNewRow Then
                    Dim valor As Object = row.Cells(nomeColunaSelecionada).Value
                    Dim Resultado = ProcessarDados(valor.ToString())

                    Select Case Resultado
                        Case "OK", "Incluído", "Localizado", "Repetido"
                            If Resultado = "Repetido" Then
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
                                LblRepetidos.Text = CInt(LblRepetidos.Text) + 1
                            Else
                                row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
                            End If
                            LblOK.Text = CInt(LblOK.Text) + 1'192; 192; 255
                        Case "De Outra Igreja"
                            LblOutraCO.Text = CInt(LblOutraCO.Text) + 1
                            row.DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 255)
                        Case valor Is Nothing
                            LblErros.Text = CInt(LblErros.Text) + 1
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                        Case Else
                            LblErros.Text = CInt(LblErros.Text) + 1
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                    End Select
                    row.Cells("Resultado").Value = Resultado
                End If
                cont += 1
            Next

            ' Exibe os valores obtidos
            RJMessageBox.Show($"Processo finalizado!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RJMessageBox.Show("Não há dados no DataGridView.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        RjProgressBar1.Visible = False
    End Sub

    Private Function ConfirmaIgreja(Coluna As String) As Boolean
        Dim Retorno As Boolean = False
        If DgvDados.Rows.Count > 0 Then
            Dim row As DataGridViewRow = DgvDados.Rows(0)
            Dim Valor As String = row.Cells(Coluna).Value
            If IsNumeric(Valor) AndAlso Valor.Length = 12 Then
                Dim IdIgreja As String = Valor.Substring(0, 6)
                Dim Igreja As List(Of IgrejasDTO) = igrejaBLL.BuscarListaPorId(IdIgreja)
                Dim IgrejaLocalizada As IgrejasDTO = Igreja.Find(Function(x) x.Id = IdIgreja)
                If IgrejaLocalizada IsNot Nothing Then
                    Retorno = True
                Else
                    RJMessageBox.Show("Os dados deste arquivo pertence a outra Casa de Oração.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                RJMessageBox.Show($"O valor desta coluna não é um código de barras válido.{vbNewLine}{vbNewLine}Selecione uma coluna válida, precisa ser numérico de 12 dígitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return Retorno
    End Function

    Private Sub CboColunas_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CboColunas.OnSelectedIndexChanged
        If ConfirmaIgreja(CboColunas.SelectedItem.ToString()) Then
            PicStatus.Image = My.Resources.correto
            BtnImportar.Visible = True
        Else
            PicStatus.Image = My.Resources.incorreto
            BtnImportar.Visible = False
            Card1.Visible = False
            Card2.Visible = False
            Card4.Visible = False
            RjProgressBar1.Visible = False
        End If
    End Sub

    Private Function ProcessarDados(CodigoBarras As String) As String
        Dim Retorno As String = String.Empty
        Try
            'Buscando dados dos objetos
            Dim BemMovel As BensDTO = bensBLL.BuscarPorId(CodigoBarras)
            Dim Inventario As InventariosDTO = inventarioBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
            Dim InventarioDetalhes As InventarioDetalhesDTO = inventarioDetalhesBLL.BuscarPorId(CodigoBarras)

            Dim Id_igreja As String = VarGlob.Inventario.Id_Igreja
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
                        Retorno = If(InventarioDetalhes.Contagem > 1, "Repetido", "Localizado")
                    Else
                        Dim InventarioDetalhe As New InventarioDetalhesDTO With {
                            .Id_inventario = VarGlob.Id_Inventario_Ativo,
                            .Id_Bem = CodigoBarras,
                            .Estado = "PENDENTE",
                            .Acao = "TRANSFERIR",
                            .Observacao = $"TRANSFERIR DE: {Id_igreja}. BEM DE OUTRA IGREJA",
                            .Contagem = 1
                            }

                        inventarioDetalhesBLL.Inserir(InventarioDetalhe)
                        Inventario.Bens_Inicial = CInt(Inventario.Bens_Inicial) + 1
                        inventarioBLL.Atualizar(Inventario)
                        Retorno = "De Outra Igreja"
                    End If

                Else
                    If BemMovel.Id_igreja = Id_igreja Then
                        Dim InventarioDetalhe As New InventarioDetalhesDTO With {
                            .Id_inventario = VarGlob.Id_Inventario_Ativo,
                            .Id_Bem = CodigoBarras,
                            .Estado = "OK",
                            .Acao = "OK",
                            .Contagem = 1
                            }

                        inventarioDetalhesBLL.Inserir(InventarioDetalhe)
                        Dim Qtde As Integer = CInt(Inventario.Bens_Inicial) + 1
                        Inventario.Bens_Inicial = Qtde
                        inventarioBLL.Atualizar(Inventario)

                        Retorno = "Incluído"
                    Else
                        Dim InventarioDetalhe As New InventarioDetalhesDTO With {
                            .Id_inventario = VarGlob.Id_Inventario_Ativo,
                            .Id_Bem = CodigoBarras,
                            .Estado = "PENDENTE",
                            .Acao = "TRANSFERIR",
                            .Observacao = $"TRANSFERIR DE: {Id_igreja}. BEM DE OUTRA IGREJA",
                            .Contagem = 1
                            }

                        inventarioDetalhesBLL.Inserir(InventarioDetalhe)
                        Inventario.Bens_Inicial = CInt(Inventario.Bens_Inicial) + 1
                        inventarioBLL.Atualizar(Inventario)
                        Retorno = "De Outra Igreja"
                    End If
                End If

            Else
                Retorno = "Sem Cadastro"
            End If

        Catch ex As Exception
            Throw New Exception("Falha ao Checar Etiqueta" & vbNewLine & ex.Message)
        End Try
        Return Retorno
    End Function

    Private Sub DgvDados_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDados.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                ' Verifica se a linha e a célula são válidas antes de selecionar
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    DgvDados.ClearSelection()
                    DgvDados.Rows(e.RowIndex).Selected = True
                    rowIndex = e.RowIndex
                    colIndex = e.ColumnIndex

                    ' Verifica se a célula é visível antes de defini-la como a célula atual
                    If DgvDados.Rows(e.RowIndex).Cells(2).Visible Then
                        DgvDados.CurrentCell = DgvDados.Rows(e.RowIndex).Cells(6)
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
        ExportarParaExcel(DgvDados)
    End Sub

    Private Sub ToolStripMenuTxt_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTxt.Click
        ExportarParaTXT(DgvDados)
    End Sub

    Private Sub ToolStripMenuPdf_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPdf.Click
        ExportarParaPDF(DgvDados)
    End Sub

    Private Sub ToolStripMenuCelula_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCelula.Click
        CopiarCelulaParaClipboard(DgvDados, colIndex)
    End Sub

    Private Sub ToolStripMenuLinha_Click(sender As Object, e As EventArgs) Handles ToolStripMenuLinha.Click
        CopiarLinhaParaClipboard(DgvDados)
    End Sub

    Private Sub ToolStripMenuTudo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTudo.Click
        CopiarTudoParaClipboard(DgvDados)
    End Sub

End Class