'Última Atualização:    04/10/2024
'Data:                  04/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima


Public Class FormDependencias
    Private dependenciasList As List(Of DependenciasDTO)
    Private dependenciasBLL As DependenciasBLL
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)

    Public Sub New()
        dependenciasList = New List(Of DependenciasDTO)()
        dependenciasBLL = New DependenciasBLL(SQLite)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        LoadPageDatagridView()

    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadPageDatagridView(TxtPesquisar.Text.ToUpper)
    End Sub

    Private Sub DgvStatus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDependencias.CellClick
        ' Verifica se o índice da linha clicada é válido (para evitar erros)
        If e.RowIndex >= 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvDependencias.Rows(e.RowIndex)

            ' Popula os TextBoxs com os valores das células da linha selecionada
            TxtId.Text = row.Cells("Id").Value
            TxtDescricao.Text = row.Cells("Descricao").Value.ToString()
            BtnSalvar.Enabled = True
            BtnCancelar.Enabled = True
            TxtDescricao.Enabled = True
        End If
    End Sub

    Private Sub DgvStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvDependencias.KeyDown
        ' Verifica se a tecla pressionada foi a tecla Delete
        If e.KeyCode = Keys.Delete Then
            ' Chama a função para excluir o registro
            ExcluirRegistro()
        End If
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        LimparCampos()
        BtnSalvar.Enabled = True
        BtnCancelar.Enabled = True
        TxtDescricao.Enabled = True
        BtnNovo.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim idStatus As Integer = 0

        ' Verifica se o valor de TxtId.Text pode ser convertido para um número inteiro
        If Not String.IsNullOrEmpty(TxtId.Text) AndAlso Integer.TryParse(TxtId.Text, idStatus) Then
            ' Se for convertível, usa o valor convertido
            idStatus = Convert.ToInt32(TxtId.Text)
        End If

        ' Cria o novo DependenciasDTO com o Id e Descrição
        Dim newStatus As New DependenciasDTO With {
            .Id = idStatus, ' Usa o valor convertido ou 0 se não for possível converter
            .Descricao = SanitizeString(TxtDescricao.Text.ToUpper)
        }

        If newStatus.Id <= 0 Then
            Try
                dependenciasBLL.Inserir(newStatus)
                ReplicarDados(SyncOrigem.Enviar, "dependencias", newStatus.Id, "Inserir")
                RJMessageBox.Show("Novo DEPENDÊNCIA Cadastrado com sucesso!", "Cadastro")
            Catch ex As Exception
                RJMessageBox.Show("Erro ao adicionar DEPENDÊNCIA: " & ex.Message, "Erro")
            End Try
        Else
            Try
                dependenciasBLL.Atualizar(newStatus)
                ReplicarDados(SyncOrigem.Enviar, "dependencias", newStatus.Id, "Atualizar")
                RJMessageBox.Show("DEPENDÊNCIA Atualizado com sucesso!", "Atualização")
            Catch ex As Exception
                RJMessageBox.Show("Erro ao Atualizar DEPENDÊNCIA: " & ex.Message, "Erro")
            End Try
        End If
        LoadPageDatagridView()
        BtnCancelar_Click(sender, e)
        TxtDescricao.Enabled = False
        BtnSalvar.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimparCampos()
        BtnNovo.Enabled = True
        BtnSalvar.Enabled = False
        BtnCancelar.Enabled = False
        TxtDescricao.Enabled = False
    End Sub

    Private Sub LimparCampos()
        With Me
            .TxtId.Clear()
            .TxtDescricao.Clear()
        End With
    End Sub

    Private Sub LoadPageDatagridView(Optional Filtro As String = "")
        dependenciasList.Clear()

        If Filtro = "" Then
            dependenciasList.AddRange(dependenciasBLL.BuscarTodos())
        Else
            dependenciasList.AddRange(dependenciasBLL.BuscarTodos(SanitizeString(Filtro)))
        End If

        With DgvDependencias
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

            .DataSource = dependenciasList
        End With

        lblNumberItems.Text = dependenciasList.Count().ToString() & " Itens"
    End Sub

    Private Sub ExcluirRegistro()
        ' Verifica se há alguma linha selecionada
        If DgvDependencias.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvDependencias.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idStatus As Integer = Convert.ToInt32(row.Cells("Id").Value)

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    dependenciasBLL.Excluir(idStatus)

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