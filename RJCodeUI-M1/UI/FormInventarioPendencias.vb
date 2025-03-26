'Última Atualização:    25/01/2025
'Data:                  28/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima


Public Class FormInventarioPendencias

    Private ReadOnly SQLite As New ConnectionFactory()
    Private ReadOnly MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private ReadOnly inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
    Private ReadOnly dependenciasBLL As New DependenciasBLL(SQLite)

    Private Id_Inventario As String
    Private Acao As String = ""
    'Private Dependencia As String

#Region "Form Events"
    Private Sub FormInventarioPendencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Id_Inventario = VarGlob.Id_Inventario_Ativo
        ComboDependencia()
    End Sub

    Private Sub FormInventarioPendencias_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AtualizaDadosAcoes()
    End Sub
#End Region

#Region "Carregamento e Configuração do DataGridView"
    Private Sub LoadBensMoveis()
        Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
        Dim consulta As String = If(ChkTodasPendencias.Checked, "LISTA PENDENTES TODOS",
                                    If(ChkResolvidas.Checked, "LISTA RESOLVIDOS", "LISTA PENDENTES"))
        Dim Pendencias As List(Of InventarioDetalhesDTO) = inventarioDetalhesBLL.BuscarTodos(TxtPesquisar.Text, Consulta)
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
            Dim colunasOcultas As String() = {"id", "id_inventario", "id_dependencia", "dependencia", "estado", "acao", "observacao", "contagem", "qtde"}
            For Each coluna As String In colunasOcultas
                If .Columns.Contains(coluna) Then .Columns(coluna).Visible = False
            Next
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
                    BtnSalvar.Enabled = True

                    If RbtNovo.Checked Then

                        ' Popula os TextBoxs com os valores das células da linha selecionada
                        TxtBemMovel.Text = Pendentes.Bem
                        DgvBensPendentes.ClearSelection()
                        'Dependencia = String.Empty

                    Else
                        If RbtImprimir.Checked Then RbtImprimir_Click(sender, e)
                        If RbtBipar.Checked Then RbtBipar_Click(sender, e)
                        If RbtAlterar.Checked Then RbtAlterar_Click(sender, e)
                        If RbtExcluir.Checked Then RbtExcluir_Click(sender, e)
                        Dim dependencia As DependenciasDTO = dependenciasBLL.BuscarPorNome(Pendentes.Dependencia)
                        ' Popula os TextBoxs com os valores das células da linha selecionada
                        LblSituacao.Text = Pendentes.Acao
                        LblEtiqueta.Text = Pendentes.Id_Bem
                        TxtBemMovel.Text = Pendentes.Bem
                        LblLeituras.Text = Pendentes.Contagem
                        TxtObservacoes.Text = If(Not String.IsNullOrEmpty(Pendentes.Observacao), Pendentes.Observacao, TxtObservacoes.Text)
                        CboDependencias.SelectedValue = dependencia.Id
                        CboDependencias.Text = dependencia.Descricao
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
    Private Sub BtnLimparFiltros_Click(sender As Object, e As EventArgs) Handles BtnLimparFiltros.Click
        ChkResolvidas.Checked = False
        ChkTodasPendencias.Checked = False
        LoadBensMoveis()
    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadBensMoveis()
    End Sub

    Private Sub ChkResolvidas_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResolvidas.CheckedChanged
        If ChkResolvidas.Checked Then ChkTodasPendencias.Checked = False
        LoadBensMoveis()

    End Sub

    Private Sub ChkTodasPendencias_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodasPendencias.CheckedChanged
        If ChkTodasPendencias.Checked Then ChkResolvidas.Checked = False
        LoadBensMoveis()

    End Sub
#End Region

#Region "Eventos dos Botões de Ação"
    Private Sub RbtImprimir_Click(sender As Object, e As EventArgs) Handles RbtImprimir.Click
        DefinirAcao("IMPRIMIR", "BEM SEM ETIQUETA", Fixar:=True)
    End Sub

    Private Sub RbtAlterar_Click(sender As Object, e As EventArgs) Handles RbtAlterar.Click
        DefinirAcao("ALTERAR", "CORRIGIR: ", Fixar:=True)
    End Sub

    Private Sub RbtNovo_Click(sender As Object, e As EventArgs) Handles RbtNovo.Click
        DefinirAcao("CADASTRAR", "CARTA DE DOAÇÃO ", Fixar:=False)
        With CboDependencias
            .SelectedIndex = -1
            .Text = String.Empty
        End With
    End Sub

    Private Sub RbtExcluir_Click(sender As Object, e As EventArgs) Handles RbtExcluir.Click
        DefinirAcao("EXCLUIR", "BAIXAR: ", Fixar:=True)
    End Sub

    Private Sub RbtTransferir_Click(sender As Object, e As EventArgs) Handles RbtTransferir.Click
        DefinirAcao("TRANSFERIR", "TRANSFERIDO PARA: ", Fixar:=True)
    End Sub

    Private Sub RbtBipar_Click(sender As Object, e As EventArgs) Handles RbtBipar.Click
        DefinirAcao("ENCONTRADO", "", Fixar:=True)
    End Sub

    Private Sub DefinirAcao(acaoTexto As String, observacaoTexto As String, Fixar As Boolean)
        Acao = acaoTexto
        ChkFixar.Enabled = Fixar
        ChkFixar.Checked = Fixar
        TxtObservacoes.Text = observacaoTexto
        BtnSalvar.Enabled = True
        DesabilitarCampos()

        If DgvBensPendentes.SelectedRows.Count > 0 Then
            Select Case Acao
                Case "CADASTRAR"
                    LblEtiqueta.Text = String.Empty
                    DgvBensPendentes.ClearSelection()
                    TxtBemMovel.Enabled = True
                    CboDependencias.Enabled = True
                    TxtObservacoes.Enabled = True
                    CboDependencias.Focus()
                Case "IMPRIMIR", "TRANFERIR", "EXCLUIR"
                    TxtObservacoes.Enabled = True
                    TxtObservacoes.Focus()
                Case "ALTERAR"
                    TxtBemMovel.Enabled = True
                    CboDependencias.Enabled = True
                    TxtObservacoes.Enabled = True
                    TxtObservacoes.Focus()
            End Select
        Else
            If Acao = "CADASTRAR" Then
                LblEtiqueta.Text = String.Empty
                DgvBensPendentes.ClearSelection()
                TxtBemMovel.Enabled = True
                TxtBemMovel.Text = String.Empty
                CboDependencias.Enabled = True
                TxtObservacoes.Enabled = True
                TxtBemMovel.Focus()
            Else
                BtnSalvar.Enabled = False
                TxtBemMovel.Text = String.Empty
                CboDependencias.Text = String.Empty
                RJMessageBox.Show($"Para {Acao} primeiro selecione um item da lista")
            End If
        End If
    End Sub


#End Region

#Region "Botão Salvar e Checkbox Fixar"

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        ' Verificar se a ação foi selecionada
        If String.IsNullOrEmpty(Acao) Then
            RJMessageBox.Show("Selecione uma opção de Ação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Criar instâncias das BLLs necessárias
        Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
        Dim dependenciasBLL As New DependenciasBLL(SQLite)



        ' Obter observação sanitizada apenas uma vez
        Dim observacaoSanitizada As String = SanitizeString(TxtObservacoes.Text)

        ' Caso a ação envolva atualização de itens selecionados
        If ChkFixar.Checked AndAlso DgvBensPendentes.SelectedRows.Count > 1 Then
            If Acao = "CADASTRAR" Then
                RJMessageBox.Show("Não é possível salvar as pendências selecionadas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            ' Atualizar múltiplos bens
            For Each Linha As DataGridViewRow In DgvBensPendentes.SelectedRows
                Dim Id_Bem As String = Linha.Cells(2).Value.ToString()
                AtualizarBem(Id_Bem, inventarioDetalhesBLL, observacaoSanitizada)
            Next

            RJMessageBox.Show($"{DgvBensPendentes.SelectedRows.Count} Pendências do tipo {Acao} foram salvas com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChkFixar.Checked = False

            ' Atualizar um único bem
        ElseIf DgvBensPendentes.SelectedRows.Count = 1 Then
            If Not String.IsNullOrEmpty(LblEtiqueta.Text) Then
                AtualizarBem(LblEtiqueta.Text, inventarioDetalhesBLL, observacaoSanitizada)
            Else
                RJMessageBox.Show("Selecione um item da lista", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Cadastrar um novo bem
        ElseIf Acao = "CADASTRAR" Then
            ' Validações antes da inserção
            If Not ValidarControle(TxtBemMovel, ErrorProvider1) OrElse Not ValidarControle(CboDependencias, ErrorProvider1) Then
                Exit Sub
            End If

            ' Obter dependência selecionada
            Dim Depend As DependenciasDTO = dependenciasBLL.BuscarPorNome(CboDependencias.Text)

            Dim BemNovo As New InventarioDetalhesDTO With {
            .Id_inventario = VarGlob.Id_Inventario_Ativo,
            .Id_Bem = GerarIdUnico(VarGlob.Id_Inventario_Ativo),
            .Estado = "PENDENTE",
            .Acao = "CADASTRAR",
            .Bem = TxtBemMovel.Text,
            .Id_dependencia = Depend.Id,
            .Observacao = observacaoSanitizada,
            .Contagem = 1
        }

            inventarioDetalhesBLL.Inserir(BemNovo)
            RbtNovo.Checked = False
        Else
            RJMessageBox.Show("Selecione um item da lista", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Atualizar UI
        LimparCampos()
        LoadBensMoveis()
        AtualizaDadosAcoes()
        BtnSalvar.Enabled = ChkFixar.Checked
    End Sub

    Private Sub AtualizarBem(idBem As String, bll As InventarioDetalhesBLL, observacao As String)
        Dim Bem As InventarioDetalhesDTO = bll.BuscarPorId(idBem)
        Dim Depend As DependenciasDTO = dependenciasBLL.BuscarPorNome(CboDependencias.Text)

        Bem.Id_inventario = VarGlob.Id_Inventario_Ativo
        Bem.Acao = If(Acao = "ENCONTRADO", "OK", Acao)
        Bem.Estado = If(Acao = "ENCONTRADO", "OK", "PENDENTE")
        Bem.Id_dependencia = If(Depend IsNot Nothing, Depend.Id, Nothing)
        Bem.Bem = String.Empty
        Bem.Observacao = observacao

        bll.Atualizar(Bem)
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
        LblSituacao.ResetText()
        LblEtiqueta.ResetText()
        TxtObservacoes.Text = String.Empty
        TxtBemMovel.Enabled = False
        TxtBemMovel.Text = String.Empty
        CboDependencias.SelectedIndex = -1
        TxtObservacoes.Enabled = False

        If Not ChkFixar.Checked Then
            Acao = String.Empty
        End If
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

    Private Sub DesabilitarCampos()
        TxtBemMovel.Enabled = False
        CboDependencias.Enabled = False
        TxtObservacoes.Enabled = False
    End Sub

    Private Sub ComboDependencia()
        Dim Dependencias As DataTable = ConvertToDataTable(dependenciasBLL.BuscarTodos())
        CboDependencias.DataSource = Dependencias
        CboDependencias.DisplayMember = "Descricao"
        CboDependencias.ValueMember = "Id"
        CboDependencias.SelectedIndex = -1
    End Sub

    Private Sub AtualizaDadosAcoes()
        Try
            Dim ListaAcoes As List(Of List(Of String)) = inventarioDetalhesBLL.BuscarAcoes()
            If ListaAcoes IsNot Nothing AndAlso ListaAcoes.Count > 0 Then
                LblInfoImprimir.Text = ListaAcoes(0)(2)
                LblInfoAlterar.Text = ListaAcoes(0)(3)
                LblInfoNovo.Text = ListaAcoes(0)(4)
                LblInfoExcluir.Text = ListaAcoes(0)(5)
                LblInfoTransferir.Text = ListaAcoes(0)(6)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

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