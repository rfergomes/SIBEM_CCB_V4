'Última Atualização:    04/10/2024
'Data:                  ~01/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class FormStatus
    Private statusList As List(Of StatusDTO)
    Private statusBLL As StatusBLL
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)

    Public Sub New()
        statusList = New List(Of StatusDTO)()
        statusBLL = New StatusBLL(SQLite)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        LoadPageDatagridView()

    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles txtPesquisar.OnTextChange
        LoadPageDatagridView(txtPesquisar.Text.ToUpper)
    End Sub

    Private Sub DgvStatus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStatus.CellClick
        ' Verifica se o índice da linha clicada é válido (para evitar erros)
        If e.RowIndex >= 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = dgvStatus.Rows(e.RowIndex)

            ' Popula os TextBoxs com os valores das células da linha selecionada
            txtCodigo.Text = row.Cells("Id").Value
            txtDescricao.Text = row.Cells("Descricao").Value.ToString()
            btnSalvar.Enabled = True
            btnCancelar.Enabled = True
            txtDescricao.Enabled = True
        End If
    End Sub

    Private Sub DgvStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvStatus.KeyDown
        ' Verifica se a tecla pressionada foi a tecla Delete
        If e.KeyCode = Keys.Delete Then
            ' Chama a função para excluir o registro
            ExcluirRegistro()
        End If
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        LimparCampos()
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
        txtDescricao.Enabled = True
        btnNovo.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim idStatus As Integer = 0

        ' Verifica se o valor de txtCodigo.Text pode ser convertido para um número inteiro
        If Not String.IsNullOrEmpty(txtCodigo.Text) AndAlso Integer.TryParse(txtCodigo.Text, idStatus) Then
            ' Se for convertível, usa o valor convertido
            idStatus = Convert.ToInt32(txtCodigo.Text)
        End If

        ' Cria o novo StatusDTO com o Id e Descrição
        Dim newStatus As New StatusDTO With {
            .Id = idStatus, ' Usa o valor convertido ou 0 se não for possível converter
            .Descricao = SanitizeString(txtDescricao.Text)
        }

        If newStatus.Id <= 0 Then
            Try
                statusBLL.Inserir(newStatus)
                RJMessageBox.Show("Novo STATUS Cadastrado com sucesso!", "Cadastro")
            Catch ex As Exception
                RJMessageBox.Show("Erro ao adicionar STATUS: " & ex.Message, "Erro")
            End Try
        Else
            Try
                statusBLL.Atualizar(newStatus)
                RJMessageBox.Show("STATUS Atualizado com sucesso!", "Atualização")
            Catch ex As Exception
                RJMessageBox.Show("Erro ao Atualizar STATUS: " & ex.Message, "Erro")
            End Try
        End If
        LoadPageDatagridView()
        BtnCancelar_Click(sender, e)
        txtDescricao.Enabled = False
        btnSalvar.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimparCampos()
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        txtDescricao.Enabled = False
    End Sub

    Private Sub LimparCampos()
        With Me
            .txtCodigo.Clear()
            .txtDescricao.Clear()
        End With
    End Sub

    Private Sub LoadPageDatagridView(Optional Filtro As String = "")
        statusList.Clear()
        dgvStatus.DataSource = Nothing
        If Filtro = "" Then
            statusList.AddRange(statusBLL.BuscarTodos())
        Else
            statusList.AddRange(statusBLL.BuscarTodos(SanitizeString(Filtro)))
        End If
        With dgvStatus
            .Columns.Clear()
            .AutoGenerateColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .DataSource = Nothing

            .Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "Id",
                .HeaderText = "Código",
                .DataPropertyName = "Id",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            .Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "Descricao",
                .HeaderText = "Descricao",
                .DataPropertyName = "Descricao",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            })

            .DataSource = statusList
        End With
        lblNumberItems.Text = statusList.Count().ToString() & " Itens"
    End Sub

    Private Sub ExcluirRegistro()
        ' Verifica se há alguma linha selecionada
        If dgvStatus.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = dgvStatus.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idStatus As Integer = Convert.ToInt32(row.Cells("Id").Value)

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    statusBLL.Excluir(idStatus)

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


End Class