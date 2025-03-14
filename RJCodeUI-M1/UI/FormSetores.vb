'Última Atualização:    21/11/2024
'Data:                  03/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class FormSetores
    Private setoresList As List(Of SetoresDTO)
    Private setoresBLL As SetoresBLL
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)

    Public Sub New()
        setoresList = New List(Of SetoresDTO)()
        setoresBLL = New SetoresBLL(SQLite)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        LoadPageDatagridView()

    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadPageDatagridView(TxtPesquisar.Text.ToUpper)
    End Sub

    Private Sub DgvStatus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSetores.CellClick
        ' Verifica se o índice da linha clicada é válido (para evitar erros)
        If e.RowIndex >= 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvSetores.Rows(e.RowIndex)

            ' Popula os TextBoxs com os valores das células da linha selecionada
            TxtId.Text = row.Cells("Cod_Setor").Value
            TxtDescricao.Text = row.Cells("Descricao").Value.ToString()
            BtnSalvar.Enabled = True
            BtnCancelar.Enabled = True
            TxtDescricao.Enabled = True
        End If
    End Sub

    Private Sub DgvStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvSetores.KeyDown
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
        TxtId.Enabled = True
        TxtDescricao.Enabled = True
        BtnNovo.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        ' Cria o novo SetoresDTO com o Id e Descrição
        Dim setor As New SetoresDTO With {
            .Cod_Setor = TxtId.Text.ToUpper, ' Usa o valor convertido ou 0 se não for possível converter
            .Descricao = TxtDescricao.Text.ToUpper,
            .Id_Admlc = VarGlob.SistemaAtivo.Id_Admlc
        }
        Dim IdExiste As Boolean
        Try
            IdExiste = IIf(Not IsNothing(setoresBLL.BuscarPorId(setor.Cod_Setor)), True, False)
        Catch ex As Exception
            RJMessageBox.Show("Erro ao consultar id do setor: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        If Not IdExiste Then
            Try
                setoresBLL.Inserir(setor)
                ReplicarDados(SyncOrigem.Enviar, "setores", setor.Cod_Setor, "Inserir")
                RJMessageBox.Show("Novo SETOR Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                RJMessageBox.Show("Erro ao adicionar SETOR: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            Try
                setoresBLL.Atualizar(setor)
                ReplicarDados(SyncOrigem.Enviar, "setores", setor.Cod_Setor, "Atualizar")
                RJMessageBox.Show("SETOR Atualizado com sucesso!", "Atualização")
            Catch ex As Exception
                RJMessageBox.Show("Erro ao Atualizar SETOR: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        TxtId.Enabled = False
    End Sub

    Private Sub LimparCampos()
        With Me
            .TxtId.Clear()
            .TxtDescricao.Clear()
        End With
    End Sub

    Private Sub LoadPageDatagridView(Optional Filtro As String = "")
        setoresList.Clear()
        If Filtro = "" Then
            setoresList.AddRange(setoresBLL.BuscarTodos())
        Else
            setoresList.AddRange(setoresBLL.BuscarTodos(SanitizeString(Filtro)))
        End If

        With DgvSetores
            .Columns.Clear()
            .AutoGenerateColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .DataSource = Nothing

            .Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "Cod_Setor",
                .HeaderText = "Código",
                .DataPropertyName = "Cod_Setor",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            .Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "Descricao",
                .HeaderText = "Descricao",
                .DataPropertyName = "Descricao",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            })

            .DataSource = setoresList
        End With
        lblNumberItems.Text = setoresList.Count().ToString() & " Itens"
    End Sub

    Private Sub ExcluirRegistro()
        ' Verifica se há alguma linha selecionada
        If DgvSetores.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvSetores.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idStatus As String = Convert.ToInt32(row.Cells("Cod_Setor").Value)

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    setoresBLL.Excluir(idStatus)
                    ReplicarDados(SyncOrigem.Enviar, "setores", idStatus, "Excluir")
                    ' Atualiza o DataGridView para refletir a exclusão
                    LoadPageDatagridView()

                    ' Mensagem de sucesso
                    RJMessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ' Exibe erro caso a exclusão falhe
                    RJMessageBox.Show("Erro ao excluir registro: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        Else
            ' Se nenhuma linha estiver selecionada
            RJMessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class