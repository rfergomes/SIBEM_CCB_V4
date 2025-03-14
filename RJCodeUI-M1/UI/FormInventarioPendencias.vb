'Última Atualização:    25/01/2025
'Data:                  28/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports Mysqlx.XDevAPI.Relational

Public Class FormInventarioPendencias

    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private Id_Inventario As String
    Private Acao As String = ""
    Private Dependencia As String

#Region "Form Events"
    Private Sub FormInventarioPendencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Id_Inventario = VarGlob.Id_Inventario_Ativo
    End Sub

    Private Sub FormInventarioPendencias_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboDependencia()
        AtualizaDadosAcoes()
    End Sub
#End Region

#Region "Load e Configuração do DataGridView"
    Private Sub LoadBensMoveis()
        Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
        Dim Pendencias As List(Of InventarioDetalhesDTO) = If(ChkTodasPendencias.Checked,
            inventarioDetalhesBLL.BuscarTodos(TxtPesquisar.Text, "LISTA PENDENTES TODOS"),
            inventarioDetalhesBLL.BuscarTodos(TxtPesquisar.Text, "LISTA PENDENTES"))

        ConfigurarDataGridView(Pendencias)
        LblTotalListado.Text = $"{Pendencias.Count} Bens Pendentes"
    End Sub

    Private Sub ConfigurarDataGridView(pendencias As List(Of InventarioDetalhesDTO))
        With DgvBensPendentes
            .DataSource = Nothing
            .Columns.Clear()
            .AutoGenerateColumns = True
            .DataSource = pendencias
            ConfigurarColunasDataGridView()
            .AllowUserToOrderColumns = True
            .ClearSelection()
        End With
    End Sub

    Private Sub ConfigurarColunasDataGridView()
        ' Configuração das colunas do DataGridView
        With DgvBensPendentes
            .Columns("id").Visible = False
            .Columns("id_inventario").Visible = False
            .Columns("id_dependencia").Visible = False
            .Columns("dependencia").Visible = False
            .Columns("estado").Visible = False
            .Columns("acao").Visible = False
            .Columns("observacao").Visible = False
            .Columns("contagem").Visible = False
            .Columns("qtde").Visible = False
            .Columns("Id_bem").HeaderText = "Etiqueta"
            .Columns("bem").HeaderText = "Bem Móvel"
            .Columns("bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Id_bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End With
    End Sub

    Private Sub DgvBensPendentes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBensPendentes.CellClick
        Try
            Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)

            ' Verifica se o índice da linha clicada é válido (para evitar erros)
            If e.RowIndex >= 0 Then

                ' Obtém a linha selecionada
                Dim row As DataGridViewRow = DgvBensPendentes.Rows(e.RowIndex)

                ' Tenta obter o ID da linha selecionada (substitua "Id" pelo nome correto da coluna de ID)
                ' Busca os dados do inventário pelo ID
                Dim Pendentes As InventarioDetalhesDTO = inventarioDetalhesBLL.BuscarPorId(row.Cells("Id_bem").Value.ToString())

                ' Verifica se os dados do inventário não são nulos antes de continuar
                If Pendentes IsNot Nothing Then
                    If RbtNovo.Checked Then
                        LimparCampos()
                        ' Popula os TextBoxs com os valores das células da linha selecionada
                        TxtBemMovel.Text = Pendentes.Bem
                        DgvBensPendentes.ClearSelection()
                        Dependencia = String.Empty
                        RbtNovo_Click(sender, e)
                    Else
                        ' Popula os TextBoxs com os valores das células da linha selecionada
                        LblSituacao.Text = Pendentes.Acao
                        LblEtiqueta.Text = Pendentes.Id_Bem
                        TxtBemMovel.Text = Pendentes.Bem
                        LblLeituras.Text = Pendentes.Contagem
                        TxtObservacoes.Text = Pendentes.Observacao
                        CboDependencias.Text = Pendentes.Dependencia
                        Dependencia = Pendentes.Dependencia
                    End If
                Else
                    MessageBox.Show("Dados do inventário não encontrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            ' Log ou mensagem de erro para exibir em caso de exceção
            MessageBox.Show($"Ocorreu um erro ao processar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Eventos de Pesquisa e Filtro"
    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadBensMoveis()
    End Sub

    Private Sub ChkTodasPendencias_Click(sender As Object, e As EventArgs) Handles ChkTodasPendencias.Click
        LoadBensMoveis()
    End Sub
#End Region

#Region "Eventos dos Botões de Ação"
    Private Sub RbtImprimir_Click(sender As Object, e As EventArgs) Handles RbtImprimir.Click
        DefinirAcao("IMPRIMIR", "BEM SEM ETIQUETA", Fixar:=True, habilitarCampos:=False)
        TxtObservacoes.Enabled = True
    End Sub

    Private Sub RbtAlterar_Click(sender As Object, e As EventArgs) Handles RbtAlterar.Click
        DefinirAcao("ALTERAR", "CORRIGIR: ", Fixar:=True, habilitarCampos:=True)
    End Sub

    Private Sub RbtNovo_Click(sender As Object, e As EventArgs) Handles RbtNovo.Click
        DefinirAcao("CADASTRAR", "CARTA DE DOAÇÃO ", Fixar:=False, habilitarCampos:=True)
        With CboDependencias
            .Enabled = True
            .SelectedIndex = -1
            .Text = String.Empty
        End With
    End Sub

    Private Sub RbtExcluir_Click(sender As Object, e As EventArgs) Handles RbtExcluir.Click
        DefinirAcao("EXCLUIR", "BAIXAR: ", Fixar:=True, habilitarCampos:=False)
        TxtObservacoes.Enabled = True
    End Sub

    Private Sub RbtTransferir_Click(sender As Object, e As EventArgs) Handles RbtTransferir.Click
        DefinirAcao("TRANSFERIR", "TRANSFERIDO PARA: ", Fixar:=True, habilitarCampos:=False)
        TxtObservacoes.Enabled = True
    End Sub

    Private Sub DefinirAcao(acaoTexto As String, observacaoTexto As String, Fixar As Boolean, habilitarCampos As Boolean)
        Acao = acaoTexto
        BtnSalvar.Enabled = True
        ChkFixar.Enabled = Fixar
        ChkFixar.Checked = Fixar
        If DgvBensPendentes.SelectedRows.Count > 0 Then
            If Acao = "CADASTRAR" Then
                LimparCampos()
                DgvBensPendentes.ClearSelection()
                TxtBemMovel.Enabled = habilitarCampos
                TxtObservacoes.Enabled = habilitarCampos
            Else
                TxtObservacoes.Text = observacaoTexto
                TxtObservacoes.Enabled = habilitarCampos
                TxtBemMovel.Enabled = habilitarCampos
                CboDependencias.Enabled = habilitarCampos
                TxtObservacoes.Focus()
            End If
        Else
            If Acao = "CADASTRAR" Then
                TxtBemMovel.Enabled = habilitarCampos
                TxtObservacoes.Enabled = habilitarCampos
            Else
                RJMessageBox.Show($"Para {Acao} primeiro selecione um item da lista")
            End If
        End If

    End Sub
#End Region

#Region "Botão Salvar e Checkbox Fixar"

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
        Dim dependenciasBLL As New DependenciasBLL(SQLite)
        Dim Bem As InventarioDetalhesDTO
        Dim Depend As DependenciasDTO = dependenciasBLL.BuscarPorNome(Dependencia)

        If Not String.IsNullOrEmpty(Acao) Then
            If ChkFixar.Checked AndAlso DgvBensPendentes.SelectedRows.Count > 1 Then
                If Acao <> "CADASTRAR" Then
                    For Each Linha As DataGridViewRow In DgvBensPendentes.SelectedRows
                        Dim Id_Bem As String = Linha.Cells(2).Value.ToString()
                        Bem = inventarioDetalhesBLL.BuscarPorId(Id_Bem)
                        Bem.Acao = Acao
                        Bem.Bem = String.Empty
                        Bem.Id_dependencia = String.Empty
                        Bem.Observacao = SanitizeString(TxtObservacoes.Text)
                        inventarioDetalhesBLL.Atualizar(Bem)
                    Next
                    ChkFixar.Checked = False
                Else
                    RJMessageBox.Show("Não é possível cadastrar em Lote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            ElseIf DgvBensPendentes.SelectedRows.Count = 1 Then
                    If Not String.IsNullOrEmpty(LblEtiqueta.Text) Then
                        Dim Id_Bem As String = LblEtiqueta.Text
                        Bem = inventarioDetalhesBLL.BuscarPorId(Id_Bem)
                        Bem.Acao = Acao
                        Bem.Bem = String.Empty
                        Bem.Id_dependencia = String.Empty
                        Bem.Observacao = SanitizeString(TxtObservacoes.Text)
                        inventarioDetalhesBLL.Atualizar(Bem)
                    Else
                        RJMessageBox.Show("Selecione um item da lista")
                    End If
                ElseIf Acao = "CADASTRAR" Then
                    Dim BemNovo As New InventarioDetalhesDTO With {
                            .Id_inventario = VarGlob.Id_Inventario_Ativo,
                            .Id_Bem = GerarIdUnico(VarGlob.Id_Inventario_Ativo),
                            .Estado = "PENDENTE",
                            .Acao = "CADASTRAR",
                            .Bem = TxtBemMovel.Text,
                            .Id_dependencia = Depend.Id,
                            .Observacao = SanitizeString(TxtObservacoes.Text),
                            .Contagem = 1
                        }
                    If Not ValidarControle(TxtBemMovel, ErrorProvider1) Then Return
                    If Not ValidarControle(CboDependencias, ErrorProvider1) Then Return

                    inventarioDetalhesBLL.Inserir(BemNovo)
                Else
                    RJMessageBox.Show("Selecione um item da lista")
            End If
        Else
            RJMessageBox.Show("Selecione uma opção de Ação!")
        End If
        LimparCampos()
        LoadBensMoveis()
        AtualizaDadosAcoes()
        If ChkFixar.Checked Then BtnSalvar.Enabled = True
    End Sub

    Private Sub ChkFixar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFixar.CheckedChanged
        ' Verifica se há uma linha selecionada no DataGridView
        If DgvBensPendentes.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada antes de alterar o MultiSelect
            Dim BemSelecionado As DataGridViewRow = DgvBensPendentes.SelectedRows(0)

            ' Altera o estado do MultiSelect com base no checkbox
            DgvBensPendentes.MultiSelect = ChkFixar.Checked

            ' Após alterar o MultiSelect, restaura a seleção da linha previamente selecionada
            BemSelecionado.Selected = True
        Else
            ' Apenas altera o MultiSelect se nenhuma linha estiver selecionada
            DgvBensPendentes.MultiSelect = ChkFixar.Checked
        End If
    End Sub


#End Region

#Region "Métodos Auxiliares"
    Private Sub LimparCampos()
        ' Limpar campos e resetar controles
        LblSituacao.ResetText()
        LblEtiqueta.ResetText()
        LblLeituras.ResetText()
        TxtObservacoes.Text = String.Empty
        TxtObservacoes.Enabled = False
        CboDependencias.SelectedIndex = -1
        TxtBemMovel.Enabled = False
        TxtBemMovel.Text = String.Empty
        If Not ChkFixar.Checked Then
            Acao = String.Empty
            RbtAlterar.Checked = False
            RbtExcluir.Checked = False
            RbtImprimir.Checked = False
            RbtNovo.Checked = False
            RbtTransferir.Checked = False
        End If
        BtnSalvar.Enabled = False
    End Sub

    Private Sub LimparEdicao()
        LblSituacao.ResetText()
        LblEtiqueta.ResetText()
        TxtBemMovel.Text = String.Empty
        TxtBemMovel.Enabled = False
        LblLeituras.ResetText()
        TxtObservacoes.Text = String.Empty
        TxtObservacoes.Enabled = False
        CboDependencias.Text = String.Empty
        TxtBemMovel.Enabled = False
        'DgvBensPendentes.ClearSelection()
    End Sub

    Private Sub ComboDependencia()
        Dim dependenciasBLL As New DependenciasBLL(SQLite)
        Dim dependencias = dependenciasBLL.BuscarTodos()
        CboDependencias.DataSource = dependencias
        CboDependencias.DisplayMember = "Descricao"
        CboDependencias.ValueMember = "Id"
        CboDependencias.SelectedIndex = -1
    End Sub

    Private Sub AtualizaDadosAcoes()
        Dim Detalhes = New InventarioDetalhesBLL(SQLite)
        Dim ListaAcoes As List(Of List(Of String)) = Detalhes.BuscarAcoes()

        If ListaAcoes IsNot Nothing Then
            LblInfoImprimir.Text = ListaAcoes.Item(0).Item(2).ToString()
            LblInfoAlterar.Text = ListaAcoes.Item(0).Item(3).ToString()
            LblInfoNovo.Text = ListaAcoes.Item(0).Item(4).ToString()
            LblInfoExcluir.Text = ListaAcoes.Item(0).Item(5).ToString()
            LblInfoTransferir.Text = ListaAcoes.Item(0).Item(6).ToString()
        End If
    End Sub

    Private Function GerarIdUnico(prefixo As String) As String
        ' Função para gerar um ID único de 12 dígitos numéricos com prefixo
        Dim comprimentoPrefixo As Integer = prefixo.Length
        If comprimentoPrefixo >= 12 Then Throw New ArgumentException("O prefixo não pode ter 12 ou mais caracteres.")
        Dim digitosRestantes As Integer = 12 - comprimentoPrefixo
        Dim numeroAleatorio As String = New Random().Next(0, Math.Pow(10, digitosRestantes) - 1).ToString("D" & digitosRestantes)
        Return $"{prefixo}{numeroAleatorio}"
    End Function



#End Region

End Class