'Última Atualização:    16/10/2024
'Data:                  11/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima


Imports System.IO
Imports System.Runtime.InteropServices

Public Class FormBensMoveis
    Private bensList As List(Of BensDTO)
    Private bensBLL As BensBLL
    Private logger As New Logger()
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private Log As New Logger

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        bensList = New List(Of BensDTO)()
        bensBLL = New BensBLL(SQLite)
        ComboSetor(VarGlob.SistemaAtivo.Setor_Definido)
        LoadPageDatagridView()
    End Sub

    Private Sub CboSetor_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSetor.OnSelectedIndexChanged
        LoadPageDatagridView()
    End Sub

    Private Sub TxtIgreja_OnTextChange(sender As Object, e As EventArgs) Handles TxtIgreja.OnTextChange
        LoadPageDatagridView()
    End Sub

    Private Sub TxtBem_OnTextChange(sender As Object, e As EventArgs) Handles TxtBem.OnTextChange
        LoadPageDatagridView()
    End Sub

    Private Sub TxtDependencia_OnTextChange(sender As Object, e As EventArgs) Handles TxtDependencia.OnTextChange
        LoadPageDatagridView()
    End Sub

    Private Sub BtnLimpaFiltro_Click(sender As Object, e As EventArgs) Handles BtnLimpaFiltro.Click
        CboSetor.Text = String.Empty
        TxtIgreja.Clear()
        TxtBem.Clear()
        TxtDependencia.Clear()
        LoadPageDatagridView()
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Dim arquivo As String = ""

        ' Configura o OpenFileDialog para selecionar o arquivo Excel ou CSV
        With OpenFileDialog1
            .Filter = "Excel |*.xls;*.xlsx;*.xlsm; | CSV |*.csv;"
            .Title = "Bens Móveis - Importação"
            .FileName = "Relatório de Bens Imobilizado.xls"
            .InitialDirectory = Environ("userprofile") & "\Downloads"
            If .ShowDialog = DialogResult.OK Then
                arquivo = .FileName
            End If
        End With

        ' Verifica se o arquivo foi selecionado
        If String.IsNullOrEmpty(arquivo) Then
            RJMessageBox.Show("Nenhum arquivo foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If Path.GetExtension(arquivo).ToLower() = ".csv" Then
                ' Tratamento para arquivos CSV
                LerCSV(arquivo)
            Else
                ' Tratamento para arquivos Excel
                LerExcel(arquivo)
            End If

        Catch ex As Exception
            RJMessageBox.Show($"Ocorreu um erro durante a importação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.WriteLog($"Bens Móveis | Botão Importar | {ex.Message}")
        End Try
    End Sub

    ' Método para ler arquivos CSV e preencher o DataGridView
    Private Sub LerCSV(arquivo As String)
        Try
            ' Limpa o DataGridView e prepara as colunas
            DgvBensMoveis.DataSource = Nothing
            DgvBensMoveis.AutoGenerateColumns = False
            DgvBensMoveis.Columns.Clear()

            ' Configurar colunas do DataGridView
            DgvBensMoveis.Columns.Add("id_bem", "ID Bem")
            DgvBensMoveis.Columns.Add("descricao", "Descrição")
            DgvBensMoveis.Columns.Add("id_igreja", "ID Igreja")
            DgvBensMoveis.Columns.Add("id_dependencia", "ID Dependência")
            DgvBensMoveis.Columns.Add("id_status", "ID Status")

            ' Limpa quaisquer dados anteriores no DataGridView
            DgvBensMoveis.Rows.Clear()

            ' Lê o arquivo CSV e adiciona cada linha ao DataGridView
            Using reader As New StreamReader(arquivo)
                Dim line As String
                Dim isFirstLine As Boolean = True

                ' Percorre todas as linhas do CSV
                While Not reader.EndOfStream
                    line = reader.ReadLine()

                    ' Ignora a primeira linha se contiver cabeçalhos
                    If isFirstLine Then
                        isFirstLine = False
                        Continue While
                    End If

                    ' Divide a linha em colunas
                    Dim columns() As String = line.Split(","c)

                    ' Verifica se há pelo menos 5 colunas
                    If columns.Length >= 5 Then
                        ' Adiciona a linha ao DataGridView
                        DgvBensMoveis.Rows.Add(columns(0).Trim(), columns(1).Trim(), columns(2).Trim(), columns(3).Trim(), columns(4).Trim())
                    End If
                End While
            End Using

            RJMessageBox.Show("Dados importados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            RJMessageBox.Show($"Erro ao ler CSV: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.WriteLog($"Bens Móveis | LerCSV | {ex.Message}")
        End Try
    End Sub

    ' Método para ler arquivos Excel e preencher o DataGridView
    Private Sub LerExcel(arquivo As String)
        Dim xlApp As Object = Nothing
        Dim xlPasta As Object = Nothing
        Dim xlPlanilha1 As Object = Nothing
        Dim PlanNome As String = "Planilha1"
        Dim listaBens As New List(Of BensDTO) ' Lista de BensDTO para armazenar os dados
        With BarraProgresso
            .Visible = True
            .Minimum = 0
            .Maximum = 100
            .Value = 0
        End With

        Try
            xlApp = CreateObject("Excel.Application")
            xlApp.DisplayAlerts = False
            xlPasta = xlApp.Workbooks.Open(arquivo)
            xlPlanilha1 = xlPasta.Worksheets(1)

            With xlPlanilha1
                PlanNome = .Name
                If .Range("A9").Text = "Relatório de Bens Imobilizado" And .Range("E1").Text = "CONGREGAÇÃO CRISTÃ NO BRASIL" Then
                    .Range("A1:A24").EntireRow.Delete()
                    .AutoFilterMode = False
                    .Cells.FormatConditions.Delete()
                    .Cells.WrapText = False
                    .Cells.MergeCells = False
                    .Range("A1:A1000").SpecialCells(4).EntireRow.Delete() ' 4 equivale a xlCellTypeBlanks
                    .Range("A1:AZ1").SpecialCells(4).EntireColumn.Delete()
                    .Range("C1;E1:F1;H1:K1").EntireColumn.Delete()
                    BarraProgresso.Value = CInt((40 / 100) * 100)
                    Application.DoEvents()
                    xlPasta.Save()
                ElseIf .Range("A1").Text = "Código" And .Range("B1").Text = "" And .Range("C1").Text = "" And .Range("D1").Text = "Nome" Then
                    .Range("A1:A1000").SpecialCells(4).EntireRow.Delete()
                    .Range("A1:AZ1").SpecialCells(4).EntireColumn.Delete()
                    .Range("C1;E1:F1;H1:K1").EntireColumn.Delete()
                    BarraProgresso.Value = CInt((40 / 100) * 100)
                    Application.DoEvents()
                    xlPasta.Save()
                End If
                .Cells.EntireColumn.AutoFit()
                .Cells.EntireRow.AutoFit()

                ' Verifica se a planilha contém os dados esperados
                If UCase(.Range("A1").Text) = UCase("Código") And UCase(.Range("B1").Text) = UCase("Nome") And UCase(.Range("C1").Text) = UCase("Localidade") And UCase(.Range("D1").Text) = UCase("Dependência") And UCase(.Range("E1").Text) = UCase("Status") Then
                    With DgvBensMoveis
                        .DataSource = Nothing
                        .AutoGenerateColumns = False
                        .Columns.Clear()
                        .Rows.Clear()
                        .Columns.Add("id_bem", "CÓDIGO")
                        .Columns.Add("descricao", "DESCRIÇÃO")
                        .Columns.Add("id_igreja", "CÓD IGREJA")
                        .Columns.Add("dependencia", "DEPENDÊNCIA")
                        .Columns.Add("status", "STATUS")
                    End With

                    ' Pré-carregar dependências e bens existentes
                    Dim todasDependencias As List(Of DependenciasDTO) = New DependenciasBLL(SQLite).BuscarTodos()
                    Dim todosBens As List(Of BensDTO) = bensBLL.BuscarTodos()
                    Dim todosStatus As List(Of StatusDTO) = New StatusBLL(SQLite).BuscarTodos()

                    ' Preenche o DataGridView com os dados da planilha
                    For i As Integer = 2 To xlPlanilha1.UsedRange.Rows.Count
                        BarraProgresso.Value = CInt((i / xlPlanilha1.UsedRange.Rows.Count) * 100)
                        Application.DoEvents()

                        Dim IdBem As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 1).Value, String.Empty, New Dictionary(Of String, String) From {{"-", ""}, {" / ", ""}}).Trim()
                        Dim Descricao As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 2).Value, String.Empty, New Dictionary(Of String, String) From {{"'", "''"}}).Trim()
                        Dim Id_Igreja As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 3).Value, String.Empty, New Dictionary(Of String, String) From {{"BR ", ""}, {"-", ""}}).Trim()
                        Dim Dependencia As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 4).Value, String.Empty).Trim()

                        Dim Status As String = If(Not Descricao Like "[5-9][0] - *" AndAlso Not Descricao Like "OT-6*", "ATIVO", "INATIVO")
                        Dim Id_Status As StatusDTO = todosStatus.FirstOrDefault(Function(d) d.Descricao = Status)
                        Dim Id_Dependencia As DependenciasDTO = todasDependencias.FirstOrDefault(Function(d) d.Descricao.Contains(Dependencia))

                        If Id_Dependencia Is Nothing Then
                            Dim dependenciasBLL = New DependenciasBLL(SQLite)
                            Id_Dependencia = New DependenciasDTO With {.Descricao = Dependencia}
                            dependenciasBLL.Inserir(Id_Dependencia)
                            todasDependencias.Add(Id_Dependencia)
                        End If

                        Dim bem As New BensDTO With {
                        .Id = IdBem,
                        .Descricao = Descricao,
                        .Id_igreja = Id_Igreja,
                        .Id_Dependencia = If(Id_Dependencia IsNot Nothing, Id_Dependencia.Id, Nothing),
                        .Dependencia = If(Id_Dependencia IsNot Nothing, Id_Dependencia.Descricao, String.Empty),
                        .Id_Status = If(Id_Status IsNot Nothing, Id_Status.Id, 1),
                        .Status = If(Id_Status IsNot Nothing, Id_Status.Descricao, String.Empty)
                    }
                        listaBens.Add(bem)
                        Try
                            Dim BemExiste As Boolean = todosBens.Any(Function(b) b.Id = bem.Id)
                            If BemExiste Then
                                bensBLL.Atualizar(bem)
                            Else
                                bensBLL.Inserir(bem)
                            End If
                        Catch ex As Exception
                            Throw New Exception("Erro: " & ex.Message)
                        End Try
                    Next
                    BarraProgresso.Visible = False

                    For Each bem As BensDTO In listaBens
                        DgvBensMoveis.Rows.Add(bem.Id, bem.Descricao, bem.Id_igreja, bem.Dependencia, bem.Status)
                    Next
                    lblNumberItems.Text = listaBens.Count().ToString() & " Itens"
                    RJMessageBox.Show("Importado " & lblNumberItems.Text & " com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    RJMessageBox.Show("Esta planilha parece não ser de Bens Móveis!", "Planilha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With

        Catch ex As Exception
            BarraProgresso.Visible = False
            RJMessageBox.Show($"Erro ao ler Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.WriteLog($"Bens Móveis | LerExcelr | {ex.Message}")
        Finally
            If xlPlanilha1 IsNot Nothing Then Marshal.ReleaseComObject(xlPlanilha1)
            If xlPasta IsNot Nothing Then
                xlPasta.Close(SaveChanges:=False)
                Marshal.ReleaseComObject(xlPasta)
            End If
            If xlApp IsNot Nothing Then
                xlApp.Quit()
                Marshal.ReleaseComObject(xlApp)
            End If
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub


    ' Função auxiliar para obter e processar valores da célula
    Private Function GetCellValueOrDefault(cell As Object, defaultValue As String, Optional replacements As Dictionary(Of String, String) = Nothing) As String
        If cell IsNot Nothing Then
            Dim value As String = cell.ToString()
            If replacements IsNot Nothing Then
                For Each kvp In replacements
                    value = value.Replace(kvp.Key, kvp.Value)
                Next
            End If
            Return value
        End If
        Return defaultValue
    End Function

    ' Function to check if header row contains expected values
    Function IsValidHeader(worksheet As Object) As Boolean
        Dim headerRow As String = worksheet.Range("A1").Text.ToUpper
        Dim expectedHeaders() As String = {"CÓDIGO", "IGREJA", "ENDEREÇO", "SETOR", "STATUS"}
        Return Join(expectedHeaders, ",") = headerRow
    End Function

    Private Sub DgvBensMoveis_KeyDown(sender As Object, e As KeyEventArgs)
        ' Verifica se a tecla pressionada foi a tecla Delete
        'If e.KeyCode = Keys.Delete Then
        ' Chama a função para excluir o registro
        'ExcluirRegistro()
        'End If
    End Sub

    Private Sub LoadPageDatagridView()
        If bensBLL IsNot Nothing Then
            ' Limpa a lista e a fonte de dados do DataGridView
            bensList = If(bensList IsNot Nothing, New List(Of BensDTO), bensList)
            bensList.Clear()
            DgvBensMoveis.DataSource = Nothing

            ' Inicializa a variável Setor
            Dim Setor As String = CboSetor.Text
            ' Verifica se o CboSetor tem um valor selecionado e se é uma String
            If Not String.IsNullOrEmpty(Setor) And Not Setor.Contains("PROJETOBASE.SetoresDTO") Then
                Dim SetorBLL As New SetoresBLL(SQLite)
                Dim Setores As SetoresDTO = SetorBLL.BuscarPorNome(Setor)

                Setor = Setores.Cod_Setor ' Usar o valor do SelectedValue como string
            End If

            Dim Igreja As String = TxtIgreja.Text
            If Not String.IsNullOrEmpty(Igreja) And Not Setor.Contains("PROJETOBASE.SetoresDTO") Then

                Igreja = SanitizeString(TxtIgreja.Text.ToString())
            End If

            Dim Bem As String = TxtBem.Text
            If Not String.IsNullOrEmpty(Bem) And Not Bem.Contains("PROJETOBASE.SetoresDTO") Then
                Bem = SanitizeString(TxtBem.Text.ToString())
            End If

            Dim Dependencia As String = TxtDependencia.Text
            If Not String.IsNullOrEmpty(Dependencia) And Not Dependencia.Contains("PROJETOBASE.SetoresDTO") Then
                Dependencia = SanitizeString(TxtDependencia.Text.ToString())
            End If


            ' Busca os dados de acordo com o filtro (se houver)
            bensList.AddRange(bensBLL.BuscarTodos(Setor, Igreja.Trim().ToUpper(), Bem.Trim().ToUpper(), Dependencia.Trim().ToUpper()))

            ' Define o DataSource apenas com as colunas que você quer exibir
            DgvBensMoveis.AutoGenerateColumns = False
            DgvBensMoveis.Columns.Clear()

            ' Criação das colunas manualmente (conforme seu código anterior)
            Dim colId As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Id",
                .HeaderText = "CÓDIGO",
                .Name = "Id",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }

            Dim colDescricao As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Descricao",
                .HeaderText = "DESCRIÇÃO",
                .Name = "Descricao",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

            Dim colIgreja As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Igreja",
                .HeaderText = "CASA DE ORAÇÃO",
                .Name = "Igreja",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

            Dim colDependencia As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Dependencia",
                .HeaderText = "DEPENDÊNCIA",
                .Name = "Dependencia",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }

            Dim colStatus As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Status",
                .HeaderText = "STATUS",
                .Name = "Status",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }

            ' Adiciona as colunas ao DataGridView
            DgvBensMoveis.Columns.Add(colId)
            DgvBensMoveis.Columns.Add(colDescricao)
            DgvBensMoveis.Columns.Add(colIgreja)
            DgvBensMoveis.Columns.Add(colDependencia)
            DgvBensMoveis.Columns.Add(colStatus)

            ' Vincula a lista ao DataGridView
            DgvBensMoveis.DataSource = bensList

            ' Atualiza o rótulo com o número de itens
            lblNumberItems.Text = bensList.Count().ToString() & " Itens"
        End If
    End Sub


    Private Sub ExcluirRegistro()
        ' Verifica se há alguma linha selecionada
        If DgvBensMoveis.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvBensMoveis.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idBens As Integer = Convert.ToInt32(row.Cells("Id").Value)

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    bensBLL.Excluir(idBens)

                    ' Atualiza o DataGridView para refletir a exclusão
                    LoadPageDatagridView()

                    ' Mensagem de sucesso
                    RJMessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ' Exibe erro caso a exclusão falhe
                    RJMessageBox.Show("Erro ao excluir registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        Else
            ' Se nenhuma linha estiver selecionada
            RJMessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DgvBensMoveis_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvBensMoveis.CellFormatting
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 Then ' Verifica se é a coluna correta e a linha válida
            Dim linha = CStr(e.Value) ' Converte o valor para string, pois pode ser null
            If linha = "INATIVO" Then
                DgvBensMoveis.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                ' Limpa a cor de fundo se não for "4B"
                DgvBensMoveis.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Empty
            End If
        End If
    End Sub

    Private Sub ComboSetor(Optional itemSelecionado As String = "")
        ' Instancia o objeto BLL para buscar os setores
        Dim setoresBLL As New SetoresBLL(SQLite)
        Dim setoresList = setoresBLL.BuscarTodos()  ' Busca todos os setores diretamente

        ' Limpa o ComboBox antes de atribuir a nova lista de setores
        CboSetor.DataSource = Nothing  ' Remove o DataSource atual
        CboSetor.Items.Clear()         ' Limpa os itens do ComboBox

        ' Verifica se há setores retornados
        If setoresList IsNot Nothing AndAlso setoresList.Count > 0 Then
            ' Configura o DataSource
            CboSetor.DataSource = setoresList  ' Atribui a lista de setores diretamente como DataSource

            ' Define qual propriedade do objeto 'Setor' será exibida no ComboBox
            CboSetor.DisplayMember = "Descricao"    ' Propriedade que será mostrada no ComboBox (assumindo que a classe Setor tem a propriedade 'Nome')

            ' Define qual propriedade será usada como valor (ID ou outra chave)
            CboSetor.ValueMember = "Cod_Setor"        ' Propriedade que será usada como valor (assumindo que a classe Setor tem a propriedade 'ID')

            ' Se foi passado um item para ser selecionado, tenta selecioná-lo
            If Not String.IsNullOrEmpty(itemSelecionado) Then
                ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
                Dim setorEncontrado = setoresList.FirstOrDefault(Function(s) s.Cod_Setor = itemSelecionado)

                If setorEncontrado IsNot Nothing Then
                    ' Seleciona o item baseado no valor
                    CboSetor.Text = setorEncontrado.Descricao
                    CboSetor.SelectedValue = setorEncontrado.Cod_Setor
                Else
                    CboSetor.Text = ""
                End If
            Else
                CboSetor.Text = ""
            End If
        End If
    End Sub

    Private Sub DgvBensMoveis_Click(sender As Object, e As EventArgs)
        MsgBox(e.ToString())
    End Sub
End Class