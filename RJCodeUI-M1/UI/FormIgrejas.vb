'Última Atualização: 04/10/2024
'Data: 04/10/2024
'Autor: Rodrigo Fernando Gomes Lima

Public Class FormIgrejas
    Private igrejasList As List(Of IgrejasDTO)
    Private igrejasBLL As IgrejasBLL
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)

    Public Sub New()
        igrejasList = New List(Of IgrejasDTO)()
        igrejasBLL = New IgrejasBLL(SQLite)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        LoadPageDatagridView()

    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadPageDatagridView(SanitizeString(TxtPesquisar.Text.ToUpper))
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Dim frmIgreja = New FormIgrejasCad()
        frmIgreja.ShowDialog()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DgvIgrejas.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvIgrejas.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idIgreja As String = row.Cells("Id").Value.ToString() 'Convert.ToInt32(row.Cells("Id").Value)

            ' Busca todas as igrejas e armazena em uma lista
            Dim listaIgrejas As IgrejasDTO = igrejasBLL.BuscarPorId(idIgreja)

            ' Filtra a lista de igrejas para encontrar uma igreja com um ID específico (exemplo: id_igreja)
            'Dim igrejaFiltrada As IgrejasDTO = listaIgrejas.FirstOrDefault(Function(i) i.Id = "id_igreja")

            ' Verifica se encontrou algum resultado
            If listaIgrejas IsNot Nothing Then
                ' Se encontrou, você pode acessar os dados dessa igreja
                Dim frmIgreja = New FormIgrejasCad(listaIgrejas).ShowDialog
            Else
                ' Se não encontrou, lidar com a ausência do registro
                Throw New Exception("Nenhuma igreja encontrada com o ID fornecido.")
            End If
        End If

    End Sub

    Private Sub DgvIgrejas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIgrejas.CellClick
        ' Verifica se o índice da linha clicada é válido (para evitar erros)
        If e.RowIndex >= 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvIgrejas.Rows(e.RowIndex)

            ' Popula os TextBoxs com os valores das células da linha selecionada
            Dim igreja As String = row.Cells("Igreja").Value
            LoadInventarios(igreja)
        End If
    End Sub

    Private Sub DgvIgrejas_KeyDown(sender As Object, e As KeyEventArgs)
        ' Verifica se a tecla pressionada foi a tecla Delete
        If e.KeyCode = Keys.Delete Then
            ' Chama a função para excluir o registro
            'ExcluirRegistro()
        End If
    End Sub

    Private Sub DgvIgrejas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIgrejas.CellDoubleClick
        If DgvIgrejas.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvIgrejas.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idIgreja As String = row.Cells("Id").Value.ToString() 'Convert.ToInt32(row.Cells("Id").Value)

            ' Busca todas as igrejas e armazena em uma lista
            Dim listaIgrejas As IgrejasDTO = igrejasBLL.BuscarPorId(idIgreja)

            ' Filtra a lista de igrejas para encontrar uma igreja com um ID específico (exemplo: id_igreja)
            'Dim igrejaFiltrada As IgrejasDTO = listaIgrejas.FirstOrDefault(Function(i) i.Id = "id_igreja")



            ' Verifica se encontrou algum resultado
            If listaIgrejas IsNot Nothing Then
                ' Se encontrou, você pode acessar os dados dessa igreja

                Dim frmIgreja = New FormIgrejasCad(listaIgrejas).ShowDialog
            Else
                ' Se não encontrou, lidar com a ausência do registro
                Throw New Exception("Nenhuma igreja encontrada com o ID fornecido.")
            End If
        End If
    End Sub

    Private Sub LoadPageDatagridView(Optional Filtro As String = "")
        ' Limpa a lista e a fonte de dados do DataGridView
        igrejasList.Clear()
        DgvIgrejas.DataSource = Nothing

        ' Busca os dados de acordo com o filtro (se houver)
        If Filtro = "" Then
            igrejasList.AddRange(igrejasBLL.BuscarTodos())
        Else
            igrejasList.AddRange(igrejasBLL.BuscarTodos(Filtro))
        End If

        ' Define o DataSource apenas com as colunas que você quer exibir
        DgvIgrejas.AutoGenerateColumns = False

        ' Limpa qualquer configuração anterior de colunas
        DgvIgrejas.Columns.Clear()

        ' Criação das colunas manualmente
        Dim colId As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Id",
            .HeaderText = "Id",
            .Name = "Id",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        Dim colIgreja As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Igreja",
            .HeaderText = "Igreja",
            .Name = "Igreja",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        }

        Dim colIdSetor As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Cod_Setor",
            .HeaderText = "Cód. Setor",
            .Name = "Cod_Setor",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        Dim colSetor As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Setor",
            .HeaderText = "Setor",
            .Name = "Setor",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        Dim colStatus As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Status",
            .HeaderText = "Status",
            .Name = "Status",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }


        ' Adiciona as colunas criadas ao DataGridView
        DgvIgrejas.Columns.Add(colId)
        DgvIgrejas.Columns.Add(colIgreja)
        DgvIgrejas.Columns.Add(colIdSetor)
        DgvIgrejas.Columns.Add(colSetor)
        DgvIgrejas.Columns.Add(colStatus)

        ' Vincula a lista ao DataGridView
        DgvIgrejas.DataSource = igrejasList

        ' Atualiza o rótulo com o número de itens
        lblNumberItems.Text = igrejasList.Count().ToString() & " Itens"
    End Sub

    Private Sub LoadInventarios(Igreja As String)
        Dim InventarioBLL As New InventariosBLL(SQLite)
        Dim InventarioList As New List(Of InventariosDTO)

        ' Limpa a lista e a fonte de dados do DataGridView
        DgvInventarios.DataSource = Nothing

        ' Busca os dados de acordo com o filtro (se houver)
        InventarioList.AddRange(InventarioBLL.BuscarTodos("", "", "", Igreja))

        ' Define o DataSource apenas com as colunas que você quer exibir
        DgvInventarios.AutoGenerateColumns = False

        ' Limpa qualquer configuração anterior de colunas
        DgvInventarios.Columns.Clear()

        ' Criação das colunas manualmente
        Dim colId As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Id",
            .HeaderText = "Inventário",
            .Name = "Id",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        Dim colData As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Data",
            .HeaderText = "Data",
            .Name = "Data",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        }

        Dim colBens As New DataGridViewTextBoxColumn With {
            .DataPropertyName = "Bens_Final",
            .HeaderText = "Bens",
            .Name = "Bens_Final",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }
        ' Adiciona as colunas criadas ao DataGridView
        DgvInventarios.Columns.Add(colId)
        DgvInventarios.Columns.Add(colData)
        DgvInventarios.Columns.Add(colBens)

        ' Vincula a lista ao DataGridView
        DgvInventarios.DataSource = InventarioList

        ' Atualiza o rótulo com o número de itens
        LblInventariosTotalItens.Text = InventarioList.Count().ToString() & " Itens"
    End Sub

    Private Sub ExcluirRegistro()
        ' Verifica se há alguma linha selecionada
        If DgvIgrejas.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvIgrejas.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idStatus As Integer = Convert.ToInt32(row.Cells("Id").Value)

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    igrejasBLL.Excluir(idStatus)

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

    Private Sub DgvIgrejas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvIgrejas.CellFormatting
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 Then ' Verifica se é a coluna correta e a linha válida
            Dim linha = CStr(e.Value) ' Converte o valor para string, pois pode ser null
            If linha <> "ATIVO" Then
                DgvIgrejas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                ' Limpa a cor de fundo se não for "4B"
                DgvIgrejas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Empty
            End If
        End If
    End Sub

End Class