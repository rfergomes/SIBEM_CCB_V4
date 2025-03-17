
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports DynamicData
Imports Mysqlx
Imports Vip.Notification

Public Class FormInventarios
    Private ReadOnly setoresBLL As SetoresBLL
    Private ReadOnly statusBLL As StatusBLL
    Private ReadOnly inventariosBLL As InventariosBLL
    Private logger As New Logger()
    Private detalhesLista As New BindingList(Of InventarioDetalhesDTO)
    Private ReadOnly dependenciasBLL As DependenciasBLL
    Private inventariosLista As List(Of InventariosDTO)
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private Id_igreja As String = String.Empty
    Private rowIndex As Integer = 0
    Private colIndex As Integer = 0


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        setoresBLL = New SetoresBLL(SQLite)
        statusBLL = New StatusBLL(SQLite)
        dependenciasBLL = New DependenciasBLL(SQLite)
        inventariosBLL = New InventariosBLL(SQLite)
        inventariosLista = New List(Of InventariosDTO)
        LoadComboAnos()
        LoadComboSetor()
        LoadPageDatagridView()
    End Sub

#Region "########## FORMULÁRIO ##############"
    Private Sub FormInventarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        With TabControl1
            .Appearance = TabAppearance.FlatButtons
            .ItemSize = New Size(0, 1)
            .SizeMode = TabSizeMode.Fixed
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub FormInventarios_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AtualizaEstatisticas()
        LoadPageDatagridViewInventarioBens()
    End Sub
#End Region 'FORMULÁRIO

#Region "########## TAB CONTROL ##############"
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Select Case e.TabPage.Text
            Case "Home"
                CboAno.SelectedIndex = CboAno.Items.Count - 1
                TxtPesquisar.Focus()
                LoadPageDatagridView()
            Case "Novo"
                TxtPesquisar.Text = String.Empty
                TxtResponsaveis.Text = String.Empty
                TxtInventariantes.Text = String.Empty
                ChkTeste.Checked = False
                TxtPesquisarNovo.Focus()
                LoadComboSetorNovo()
                LoadPageDatagridViewIgrejas()

            Case "Importar"
                If VarGlob.Id_Inventario_Ativo = String.Empty Then TabControl1.SelectedTab = TabPage1_Home
                InventarioDados()
                Id_igreja = If(Not String.IsNullOrEmpty(LblImportId_igreja.Text), LblImportId_igreja.Text, "")
                LoadPageDatagridViewBensMoveis()
                BtnImportarBens.Enabled = True
                BtnContinuar.Enabled = False
                ChkIgnorarImportar.Enabled = True

            Case "Inventário"
                If VarGlob.Id_Inventario_Ativo = String.Empty Then TabControl1.SelectedTab = TabPage1_Home
                Dim Inventario As InventariosDTO = inventariosBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
                If Inventario Is Nothing Then
                    TabControl1.SelectedTab = TabPage1_Home
                ElseIf Inventario.Bens_Importado = False Then

                    TabControl1.SelectedIndex = 2
                    InventarioDados()
                    Id_igreja = LblImportId_igreja.Text
                    LoadPageDatagridViewBensMoveis()
                    RJMessageBox.Show("Por favor, importe os bens desta casa de oração")
                    BtnImportarBens.Enabled = True
                End If
                LblInventarioNumero.Text = $"INVENTÁRIO Nº: {VarGlob.Id_Inventario_Ativo}"
                LoadPageDatagridViewInventarioBens()
                PopulaRelatoriosConsulta()
                AtualizaEstatisticas()
            Case Else
                Exit Select
        End Select
    End Sub
#End Region 'TAB CONTROL

#Region "########## TAB HOME ##############"
    Private Sub CboAno_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAno.OnSelectedIndexChanged
        LoadPageDatagridView()
    End Sub

    Private Sub CboSetor_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSetor.OnSelectedIndexChanged
        LoadPageDatagridView()
    End Sub

    Private Sub TggAbertos_CheckedChanged(sender As Object, e As EventArgs) Handles TggAbertos.CheckedChanged
        LoadPageDatagridView()
    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadPageDatagridView()
    End Sub

    Private Sub BtnLimparFiltros_Click(sender As Object, e As EventArgs) Handles BtnLimparFiltros.Click
        LimparDadosInventarioSelecionado(True)
        LoadPageDatagridView()
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        TabControl1.SelectedIndex = 1
        LimparDadosInventarioSelecionado()
    End Sub

    Private Sub BtnReabrir_Click(sender As Object, e As EventArgs) Handles BtnReabrir.Click
        If LblInventario.Text <> String.Empty Then
            VarGlob.Id_Inventario_Ativo = LblInventario.Text
            Dim Inventario As InventariosDTO = inventariosBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
            Inventario.Situacao = "Aberto"
            inventariosBLL.Atualizar(Inventario)
            VarGlob.Inventario = Inventario
            TabControl1.SelectedTab = TabPage4_Inventario
        End If
    End Sub

    Private Sub BtnEtiqueta_Click(sender As Object, e As EventArgs) Handles BtnEtiqueta.Click
        If LblInventario.Text <> String.Empty Then
            VarGlob.Id_Inventario_Ativo = LblInventario.Text
            Dim Form As Form = New FormInventarioEtiquetas(VarGlob.Id_Inventario_Ativo)
            Form.ShowDialog()
        End If
    End Sub

    Private Sub BtnRelatorio_Click(sender As Object, e As EventArgs) Handles BtnRelatorio.Click
        If Not String.IsNullOrEmpty(LblInventario.Text) Then
            VarGlob.Id_Inventario_Ativo = LblInventario.Text
            Dim Form As Form = New FormInventarioFinalizado()
            Form.ShowDialog()
        Else
            RJMessageBox.Show("Por favor, selecione um inventário dinalizado da lista")
        End If

    End Sub

    Private Sub LoadComboSetor(Optional itemSelecionado As String = "")
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
            'CboSetor.ValueMember = "Id"        ' Propriedade que será usada como valor (assumindo que a classe Setor tem a propriedade 'ID')

            ' Se foi passado um item para ser selecionado, tenta selecioná-lo
            If Not String.IsNullOrEmpty(itemSelecionado) Then
                ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
                Dim setorEncontrado = setoresList.FirstOrDefault(Function(s) s.Id = itemSelecionado)

                If setorEncontrado IsNot Nothing Then
                    ' Seleciona o item baseado no valor
                    CboSetor.Text = setorEncontrado.Descricao
                Else
                    CboSetor.Text = ""
                End If
            Else
                CboSetor.Text = ""
            End If
        End If
    End Sub

    Private Sub LoadComboAnos()
        ' Obtém a lista de listas de strings
        Dim anoList As List(Of List(Of String)) = inventariosBLL.BuscarListaAnos()

        ' Extrai os anos como uma lista de strings
        Dim anos As List(Of String) = anoList.Select(Function(sublist) sublist(0)).ToList()

        CboAno.DataSource = Nothing  ' Remove o DataSource atual
        CboAno.Items.Clear()         ' Limpa os itens do ComboBox

        If anos IsNot Nothing AndAlso anos.Count > 0 Then
            CboAno.DataSource = anos  ' Atribui a lista de anos diretamente como DataSource

            ' Seleciona o ano atual se ele existir na lista
            Dim anoAtual As String = Now.Year.ToString()
            If anos.Contains(anoAtual) Then
                CboAno.SelectedItem = anoAtual
            Else
                CboAno.SelectedIndex = -1 ' Limpa a seleção se o ano atual não estiver na lista
            End If
        Else
            CboAno.SelectedIndex = -1 ' Limpa a seleção caso a lista seja nula ou vazia
        End If
    End Sub

#Region "########## TAB HOME - DataGridView ##############"

    Private Sub LoadPageDatagridView()
        If inventariosBLL IsNot Nothing Then
            Dim ano As String = If(CboAno IsNot Nothing, SanitizeString(CboAno.Text), String.Empty)
            Dim setor As String = If(CboSetor IsNot Nothing, SanitizeString(CboSetor.Text), String.Empty)
            Dim Abertos As String = If(TggAbertos.CheckState = CheckState.Checked, "Aberto", String.Empty)
            Dim pesquisar As String = SanitizeString(TxtPesquisar.Text)


            'MessageBox.Show("Ano: " & ano & vbNewLine & "Setor: " & setor & vbNewLine & "Ativos: " & Abertos)
            ' Verifica se a lista foi inicializada
            inventariosLista = If(inventariosLista IsNot Nothing, New List(Of InventariosDTO), inventariosLista)
            inventariosLista.Clear()

            ' Limpa a fonte de dados do DataGridView
            DgvInventarios.DataSource = Nothing

            ' Busca os dados de acordo com o filtro (se houver)

            inventariosLista.AddRange(inventariosBLL.BuscarTodos(ano, setor, Abertos, pesquisar))

            ' Define o DataSource apenas com as colunas que você quer exibir
            DgvInventarios.AutoGenerateColumns = False

            ' Limpa qualquer configuração anterior de colunas
            DgvInventarios.Columns.Clear()

            ' Criação das colunas manualmente
            Dim colId As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Id",   ' Verifique se "Id" é o nome correto da propriedade
                .HeaderText = "Inventário",
                .Name = "Id",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }

            Dim colIgreja As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Igreja",  ' Verifique se "Igreja" é o nome correto da propriedade
                .HeaderText = "Igreja",
                .Name = "Igreja",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }

            Dim colIdSetor As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Setor",  ' Verifique se "Setor" é o nome correto da propriedade
                .HeaderText = "Setor",
                .Name = "Setor",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                .Visible = False
            }

            Dim colStatus As New DataGridViewTextBoxColumn With {
                .DataPropertyName = "situacao",  ' Verifique se "Setor" é o nome correto da propriedade
                .HeaderText = "Status",
                .Name = "Situacao",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }

            ' Adiciona as colunas criadas ao DataGridView
            DgvInventarios.Columns.AddRange(New DataGridViewColumn() {colId, colIgreja, colIdSetor, colStatus})

            ' Vincula a lista ao DataGridView
            DgvInventarios.DataSource = inventariosLista

            ' Atualiza o rótulo com o número de itens
            lblNumberItems.Text = $"{inventariosLista.Count} Itens"
            LimparDadosInventarioSelecionado()
        End If
    End Sub

    Private Sub DgvInventarios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvInventarios.CellFormatting
        If e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then ' Verifica se é a coluna correta e a linha válida
            Dim linha = CStr(e.Value) ' Converte o valor para string, pois pode ser null
            If linha = "BONFIM" Then
                DgvInventarios.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                ' Limpa a cor de fundo se não for "4B"
                DgvInventarios.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Empty
            End If
        End If
    End Sub

    Private Sub DgvInventarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInventarios.CellClick
        BtnReabrir.Enabled = False
        Try
            ' Verifica se o índice da linha clicada é válido (para evitar erros)
            If e.RowIndex >= 0 Then
                ' Obtém a linha selecionada
                Dim row As DataGridViewRow = DgvInventarios.Rows(e.RowIndex)

                ' Tenta obter o ID da linha selecionada (substitua "Id" pelo nome correto da coluna de ID)
                Dim idInventario As String = row.Cells("Id").Value.ToString()
                If Not String.IsNullOrEmpty(idInventario) Then
                    ' Busca os dados do inventário pelo ID
                    Dim DadosInventario As InventariosDTO = inventariosBLL.BuscarPorId(idInventario)

                    ' Verifica se os dados do inventário não são nulos antes de continuar
                    If DadosInventario IsNot Nothing Then
                        ' Popula os TextBoxs com os valores das células da linha selecionada
                        LblInventario.Text = DadosInventario.Id.ToString()
                        LblData.Text = DadosInventario.Data.ToString("dd/MM/yyyy")
                        LblIgreja.Text = DadosInventario.Igreja
                        LblSetor.Text = DadosInventario.Setor
                        LblResponsaveis.Text = DadosInventario.Responsaveis
                        LblInventariantes.Text = DadosInventario.Inventariantes
                        LblBensInicial.Text = DadosInventario.Bens_Inicial.ToString()

                        If DadosInventario.Situacao = "Finalizado" Then
                            BtnEtiqueta.Enabled = True
                            BtnRelatorio.Enabled = True
                        Else
                            BtnEtiqueta.Enabled = False
                            BtnRelatorio.Enabled = False
                        End If
                        ' Cálculo da porcentagem parcial (Bens Localizados / Bens Inicial) * 100
                        Dim bensLocalizados As Double = 0
                        Dim bensInicial As Double = 0

                        ' Tenta converter e calcular a porcentagem parcial
                        If Double.TryParse(DadosInventario.Bens_Lidos, bensLocalizados) AndAlso Double.TryParse(LblBensInicial.Text, bensInicial) Then
                            If bensInicial > 0 Then
                                Dim parcialPercent As Double = (bensLocalizados / bensInicial) * 100
                                LblParcialPercent.Text = parcialPercent.ToString("F2") & "%"
                            Else
                                LblParcialPercent.Text = "N/A"
                            End If
                        Else
                            LblParcialPercent.Text = "Valores inválidos"
                        End If

                        LblBensFinal.Text = DadosInventario.Bens_Final.ToString()
                        LblBensLocalizados.Text = DadosInventario.Bens_Lidos.ToString()
                        LblBensNovos.Text = DadosInventario.Bens_Novos.ToString()
                        LblBensPendentes.Text = DadosInventario.Bens_Pendentes.ToString()

                        ' Cálculo da porcentagem final (Bens Localizados + Bens Novos) / Bens Final * 100
                        Dim bensNovos As Double = 0
                        Dim bensFinal As Double = 0

                        ' Tenta converter e calcular a porcentagem final
                        If Double.TryParse(LblBensNovos.Text, bensNovos) AndAlso Double.TryParse(LblBensFinal.Text, bensFinal) Then
                            If bensFinal > 0 Then
                                Dim finalPercent As Double = ((bensLocalizados) / bensFinal) * 100
                                LblFinalPercent.Text = finalPercent.ToString("F2") & "%"
                            Else
                                LblFinalPercent.Text = "N/A"
                            End If
                        Else
                            LblFinalPercent.Text = "Valores inválidos"
                        End If

                        LblDuracao.Text = DadosInventario.Duracao.ToString("hh\:mm\:ss")
                        BtnReabrir.Enabled = True
                    Else
                        MessageBox.Show("Dados do inventário não encontrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("ID do inventário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            ' Log ou mensagem de erro para exibir em caso de exceção
            MessageBox.Show($"Ocorreu um erro ao processar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvInventarios_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvInventarios.KeyDown
        ' Verifica se a tecla pressionada foi a tecla Delete
        If e.KeyCode = Keys.Delete Then
            ' Chama a função para excluir o registro
            ExcluirRegistro()
            LimparDadosInventarioSelecionado()
        End If
    End Sub
#End Region 'DataGridView

#Region "########## TAB HOME - Métodos e Funções ##############"
    Private Sub LimparDadosInventarioSelecionado(Optional LimparTudo As Boolean = False)
        If LimparTudo Then
            CboAno.Text = Now.Year
            CboSetor.SelectedIndex = 0
            CboSetor.Texts = String.Empty
            TxtPesquisar.Text = String.Empty
            TggAbertos.Activated = False
            DgvInventarios.ClearSelection()
        End If
        BtnNovo.Enabled = True
        BtnReabrir.Enabled = False
        BtnEtiqueta.Enabled = False
        BtnRelatorio.Enabled = False
        BtnImportarBens.Enabled = False
        LblIgreja.ResetText()
        LblInventario.ResetText()
        LblData.ResetText()
        LblSetor.ResetText()
        LblResponsaveis.ResetText()
        LblInventariantes.ResetText()
        LblBensInicial.ResetText()
        LblParcialPercent.ResetText()
        LblBensFinal.ResetText()
        LblFinalPercent.ResetText()
        LblBensLocalizados.ResetText()
        LblBensNovos.ResetText()
        LblBensPendentes.ResetText()
        LblDuracao.ResetText()

    End Sub

    Private Sub ExcluirRegistro()
        ' Verifica se há alguma linha selecionada
        If DgvInventarios.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvInventarios.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim idInventario As String = row.Cells("Id").Value.ToString()

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    inventariosBLL.Excluir(idInventario)

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

#End Region 'Métodos

#End Region 'TAB HOME

#Region "########## TAB NOVO ##############"

    Private Sub CboSetorNovo_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSetorNovo.OnSelectedIndexChanged
        If Not String.IsNullOrEmpty(CboSetorNovo.Text.Trim()) Then
            LoadPageDatagridViewIgrejas(CboSetorNovo.SelectedItem.descricao)
            TxtPesquisarNovo.Text = String.Empty
        End If
    End Sub

    Private Sub TxtPesquisarNovo_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisarNovo.OnTextChange
        If Not String.IsNullOrEmpty(TxtPesquisarNovo.Text) Then
            LoadPageDatagridViewIgrejas(SanitizeString(TxtPesquisarNovo.Text))
            CboSetorNovo.Text = String.Empty
        End If
    End Sub

    Private Sub BtnLimparNovo_Click(sender As Object, e As EventArgs) Handles BtnLimparNovo.Click
        CboSetorNovo.Text = String.Empty
        TxtPesquisarNovo.Text = String.Empty
        LoadPageDatagridViewIgrejas()
    End Sub

    Public Sub LoadComboSetorNovo(Optional itemSelecionado As String = "")
        Dim setoresList = setoresBLL.BuscarTodos()  ' Busca todos os setores diretamente

        ' Limpa o ComboBox antes de atribuir a nova lista de setores
        CboSetorNovo.DataSource = Nothing  ' Remove o DataSource atual
        CboSetorNovo.Items.Clear()         ' Limpa os itens do ComboBox

        ' Verifica se há setores retornados
        If setoresList IsNot Nothing AndAlso setoresList.Count > 0 Then
            ' Configura o DataSource
            CboSetorNovo.DataSource = setoresList  ' Atribui a lista de setores diretamente como DataSource

            ' Define qual propriedade do objeto 'Setor' será exibida no ComboBox
            CboSetorNovo.DisplayMember = "Descricao"    ' Propriedade que será mostrada no ComboBox (assumindo que a classe Setor tem a propriedade 'Nome')

            ' Define qual propriedade será usada como valor (ID ou outra chave)
            'CboSetor.ValueMember = "Id"        ' Propriedade que será usada como valor (assumindo que a classe Setor tem a propriedade 'ID')

            ' Se foi passado um item para ser selecionado, tenta selecioná-lo
            If Not String.IsNullOrEmpty(itemSelecionado) Then
                ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
                Dim setorEncontrado = setoresList.FirstOrDefault(Function(s) s.Id = itemSelecionado)

                If setorEncontrado IsNot Nothing Then
                    ' Seleciona o item baseado no valor
                    CboSetorNovo.Text = setorEncontrado.Descricao
                Else
                    CboSetorNovo.Text = ""
                End If
            Else
                CboSetorNovo.Text = ""
            End If
        End If
    End Sub

    Private Sub LoadPageDatagridViewIgrejas(Optional Filtro As String = "")
        Dim igrejasBLL As New IgrejasBLL(SQLite)
        Dim igrejasLista As New List(Of IgrejasDTO)

        ' Limpa a lista e a fonte de dados do DataGridView
        If igrejasLista IsNot Nothing Then igrejasLista.Clear()
        DgvIgrejas.DataSource = Nothing
        LblIgrejaSelecionada.Text = String.Empty

        ' Busca os dados de acordo com o filtro (se houver)
        If Filtro = "" Then
            igrejasLista.AddRange(igrejasBLL.BuscarTodos("", True))
        Else
            igrejasLista.AddRange(igrejasBLL.BuscarTodos(SanitizeString(Filtro), True))
        End If

        With DgvIgrejas
            ' Limpa qualquer configuração anterior de colunas
            .Columns.Clear()
            ' Define o DataSource apenas com as colunas que você quer exibir
            .AutoGenerateColumns = True
            ' Vincula a lista ao DataGridView
            .DataSource = igrejasLista
            ' Organização das Colunas
            .Columns("id").Visible = False
            .Columns("Cod_Siga").Visible = False
            .Columns("razao_social").Visible = False
            .Columns("logradouro").Visible = False
            .Columns("numero").Visible = False
            .Columns("bairro").Visible = False
            .Columns("cidade").Visible = False
            .Columns("uf").Visible = False
            .Columns("cnpj").Visible = False
            .Columns("id_tipo").Visible = False
            .Columns("tipo").Visible = False
            .Columns("id_status").Visible = False
            .Columns("setor").Visible = False
            .Columns("adm_local").Visible = False
            .Columns("id_admlc").Visible = False
            .Columns("observacao").Visible = False
            .Columns("Cod_setor").HeaderText = "Setor"
            .Columns("igreja").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Status").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Cod_Setor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AllowUserToOrderColumns = True
            'Limpar seleção automática da linha 1
            .ClearSelection()
        End With

        ' Atualiza o rótulo com o número de itens
        lblNumberItems.Text = igrejasLista.Count().ToString() & " Itens"
    End Sub

    Private Sub DgvIgrejas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIgrejas.CellClick
        ' Verifica se o índice da linha clicada é válido (para evitar erros)
        If e.RowIndex >= 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvIgrejas.Rows(e.RowIndex)

            ' Popula os TextBoxs com os valores das células da linha selecionada
            LblIgrejaSelecionada.Text = row.Cells("Igreja").Value
            ErrorProvider1.SetError(DgvIgrejas, String.Empty)
        End If
    End Sub

    Private Sub DgvIgrejas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvIgrejas.CellFormatting
        If e.ColumnIndex = 13 AndAlso e.RowIndex >= 0 Then ' Verifica se é a coluna correta e a linha válida
            Dim linha = CStr(e.Value) ' Converte o valor para string, pois pode ser null
            If linha <> "ATIVO" Then
                DgvIgrejas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                ' Limpa a cor de fundo se não for "4B"
                DgvIgrejas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Empty
            End If
        End If
    End Sub

    Private Sub BtnCancelarNovo_Click(sender As Object, e As EventArgs) Handles BtnCancelarNovo.Click

        CboSetorNovo.Text = String.Empty
        TxtPesquisarNovo.Clear()
        TxtResponsaveis.Clear()
        TxtInventariantes.Clear()
        ChkTeste.Checked = False
        DgvIgrejas.DataSource = Nothing
        TabControl1.SelectedIndex = 0
        With ErrorProvider1
            .SetError(TxtInventariantes, String.Empty)
            .SetError(TxtResponsaveis, String.Empty)
            .SetError(DgvIgrejas, String.Empty)
        End With

    End Sub

    Private Sub BtnSalvarNovo_Click(sender As Object, e As EventArgs) Handles BtnSalvarNovo.Click
        If String.IsNullOrEmpty(LblIgrejaSelecionada.Text) Then
            ErrorProvider1.SetError(DgvIgrejas, "Selecione uma " & DgvIgrejas.Tag.ToString() & " da lista.")
            Alert.ShowWarning("Selecione uma " & DgvIgrejas.Tag.ToString() & " da lista.", 5000)
            Return
        Else
            ErrorProvider1.SetError(DgvIgrejas, String.Empty)
        End If
        If Not ValidarControle(TxtResponsaveis, ErrorProvider1) Then Return
        If Not ValidarControle(TxtInventariantes, ErrorProvider1) Then Return

        Id_igreja = DgvIgrejas.SelectedRows(0).Cells("Id").Value.ToString()
        Dim Responsaveis As String = SanitizeString(TxtResponsaveis.Text)
        Dim Inventariantes As String = SanitizeString(TxtInventariantes.Text)
        Dim Teste As Boolean = ChkTeste.Checked
        Dim Inventario As New InventariosDTO With {
            .Id_Igreja = Id_igreja,
            .Responsaveis = Responsaveis,
            .Inventariantes = Inventariantes,
            .Situacao = "Aberto",
            .Bens_Importado = False,
            .Inventario_Teste = Teste,
            .Data = Now().ToString("yyyy-MM-dd HH:mm:ss"),
            .Inicio = Now().ToString("yyyy-MM-dd HH:mm:ss"),
            .Termino = Now().ToString("yyyy-MM-dd HH:mm:ss")
        }

        Try

            If inventariosBLL.Inserir(Inventario) > 0 Then
                VarGlob.Id_Inventario_Ativo = inventariosBLL.UltimoIdCadastrado(Id_igreja)
                VarGlob.Inventario = Inventario
                RJMessageBox.Show("Inventário cadastrado com sucesso!" & vbNewLine & VarGlob.Id_Inventario_Ativo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPageDatagridView()
                TabControl1.SelectedIndex = 2
            Else
                RJMessageBox.Show("Não foi possível cadastrar este inventário. Tente novamente. Se o erro persistir, entre em contato com o desenvolvedor", "Falha ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If Teste Then RJMessageBox.Show("Inventários de testes não serão incluídos nas estatísticas e nem serão compartilhados, apenas para fins de trinamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            RJMessageBox.Show("Falha ao incluir Inventário" & vbNewLine & ex.Message)
        End Try

    End Sub


#End Region'TAB NOVO

#Region "########## TAB IMPORTAR ##############"

    Private Sub InventarioDados()
        Dim Inventario As InventariosDTO = inventariosBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
        If Inventario IsNot Nothing Then
            LblImportIgreja.Text = Inventario.Igreja
            LblImportInventario.Text = Inventario.Id
            LblImportSetor.Text = Inventario.Setor
            LblImportBens.Text = Inventario.Bens_Inicial
            LblImportResponsaveis.Text = Inventario.Responsaveis
            LblImportInventariantes.Text = Inventario.Inventariantes
            LblImportId_igreja.Text = Inventario.Id_Igreja
        End If
    End Sub

    Private Sub LoadPageDatagridViewBensMoveis()
        Dim bensBLL As New BensBLL(SQLite)
        Dim bensLista As New List(Of BensDTO)

        ' Limpa a lista e a fonte de dados do DataGridView
        If bensLista IsNot Nothing Then bensLista.Clear()

        ' Busca os dados de acordo com o filtro (se houver)
        bensLista.AddRange(bensBLL.BuscarTodos("", Id_igreja))

        With DgvImportBens
            .DataSource = Nothing
            ' Limpa qualquer configuração anterior de colunas
            .Columns.Clear()
            ' Define o DataSource apenas com as colunas que você quer exibir
            .AutoGenerateColumns = True
            ' Vincula a lista ao DataGridView
            .DataSource = bensLista
            ' Organização das Colunas
            .Columns("id_igreja").Visible = False
            .Columns("igreja").Visible = False
            .Columns("id_dependencia").Visible = False
            .Columns("dependencia").Visible = False
            .Columns("id_setor").Visible = False
            .Columns("setor").Visible = False
            .Columns("id_status").Visible = False
            .Columns("status").Visible = False
            .Columns("Id").HeaderText = "Etiqueta"
            .Columns("descricao").HeaderText = "Bem Móvel"
            .Columns("descricao").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AllowUserToOrderColumns = True
            'Limpar seleção automática da linha 1
            .ClearSelection()
            LblTotalImportado.Text = DgvImportBens.Rows.Count & " Bens Importado"
        End With

    End Sub

    Private Sub BtnImportarBens_Click(sender As Object, e As EventArgs) Handles BtnImportarBens.Click
        Dim xlApp As Object = Nothing
        Dim xlPasta As Object = Nothing
        Dim xlPlanilha1 As Object = Nothing
        Dim PlanNome As String = "Planilha1"
        Dim ArquivoOrigem As String = GetArquivo(TipoArquivo.Excel)

        ' Verifica se o arquivo foi selecionado
        If String.IsNullOrEmpty(ArquivoOrigem) Then
            RJMessageBox.Show("Nenhum arquivo foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Inicializa a barra de progresso
            With BarraProgresso
                .Visible = True
                .Minimum = 0
                .Maximum = 100
                .Value = 0
            End With

            ' Inicia o Excel e abre o arquivo
            xlApp = CreateObject("Excel.Application")
            xlPasta = xlApp.Workbooks.Open(ArquivoOrigem)
            xlPlanilha1 = xlPasta.Worksheets(1)

            ' Verifica o nome da planilha e o conteúdo esperado
            PlanNome = xlPlanilha1.Name
            If xlPlanilha1.Range("A9").Text = "Relatório de Bens Imobilizado" AndAlso xlPlanilha1.Range("E1").Text = "CONGREGAÇÃO CRISTÃ NO BRASIL" Then
                ' Limpa e organiza a planilha
                xlPlanilha1.Range("A1:A24").EntireRow.Delete()
                xlPlanilha1.AutoFilterMode = False
                xlPlanilha1.Cells.FormatConditions.Delete()
                xlPlanilha1.Cells.WrapText = False
                xlPlanilha1.Cells.MergeCells = False
                xlPlanilha1.Range("A:A").SpecialCells(4).EntireRow.Delete() ' -4123 corresponde a xlCellTypeBlanks
                xlPlanilha1.Range("A1:AZ1").SpecialCells(4).EntireColumn.Delete() ' -4123 corresponde a xlCellTypeBlanks
                xlPlanilha1.Range("C1;E1:F1;H1:K1").EntireColumn.Delete()
            ElseIf xlPlanilha1.Range("A1").Text = "Código" AndAlso xlPlanilha1.Range("D1").Text = "Nome" Then
                ' Limpa e organiza a planilha para o segundo formato
                xlPlanilha1.Range("A:A").SpecialCells(4).EntireRow.Delete() ' -4123 corresponde a xlCellTypeBlanks
                xlPlanilha1.Range("A1:AZ1").SpecialCells(4).EntireColumn.Delete()
                xlPlanilha1.Range("C1;E1:F1;H1:K1").EntireColumn.Delete()
            End If
            xlPasta.Save()
            xlPlanilha1.Cells.EntireColumn.AutoFit()
            xlPlanilha1.Cells.EntireRow.AutoFit()

            ' Configuração do DataGridView
            Dim listaBens As New List(Of BensDTO)
            Dim bensBLL As New BensBLL(SQLite)
            Dim todasDependencias As List(Of DependenciasDTO) = New DependenciasBLL(SQLite).BuscarTodos()
            Dim todosBens As List(Of BensDTO) = bensBLL.BuscarTodos()
            Dim todosStatus As List(Of StatusDTO) = New StatusBLL(SQLite).BuscarTodos()
            Dim MesmaIgreja As Boolean = False

            For i As Integer = 2 To xlPlanilha1.UsedRange.Rows.Count
                Dim IdBem As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 1).Value, String.Empty).Trim().Replace("-", "").Replace(" / ", "")
                Dim Descricao As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 2).Value, String.Empty).Trim().Replace("'", "''")
                Dim Dependencia As String = GetCellValueOrDefault(xlPlanilha1.Cells(i, 4).Value, String.Empty).Trim()
                Id_igreja = GetCellValueOrDefault(xlPlanilha1.Cells(i, 3).Value, String.Empty).Trim().Replace("BR ", "").Replace("-", "")

                If Id_igreja = LblImportId_igreja.Text Then
                    MesmaIgreja = True
                Else
                    RJMessageBox.Show("Os dados da planilha não correspondem à igreja.", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    LoadPageDatagridViewBensMoveis()
                    Return
                End If

                ' Atualização da barra de progresso
                BarraProgresso.Value = CInt((i / xlPlanilha1.UsedRange.Rows.Count) * 100)
                Application.DoEvents()

                ' Determinação do status
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
                .Id_igreja = Id_igreja,
                .Id_Dependencia = If(Id_Dependencia IsNot Nothing, Id_Dependencia.Id, 0),
                .Dependencia = If(Id_Dependencia IsNot Nothing, Id_Dependencia.Descricao, String.Empty),
                .Id_Status = If(Id_Status IsNot Nothing, Id_Status.Id, 1),
                .Status = If(Id_Status IsNot Nothing, Id_Status.Descricao, String.Empty)
            }
                listaBens.Add(bem)

                ' Inserção/atualização do bem no banco
                Dim BemExiste As Boolean = todosBens.Any(Function(b) b.Id = bem.Id)
                If BemExiste Then
                    bensBLL.Atualizar(bem)
                Else
                    bensBLL.Inserir(bem)
                End If
            Next

            Dim InventarioBLL As New InventariosBLL(SQLite)
            Dim InventarioDetalhes As New InventarioDetalhesBLL(SQLite)
            Dim Inventario As InventariosDTO = InventarioBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
            Dim inventarioDetalhe As List(Of InventarioDetalhesDTO) = InventarioDetalhes.BuscarTodos()
            Inventario.Bens_Inicial = inventarioDetalhe.Count
            Inventario.Bens_Importado = 1
            InventarioBLL.Atualizar(Inventario)
            ' Finalização do progresso
            BarraProgresso.Visible = False
            BtnContinuar.Enabled = True
            RJMessageBox.Show("Importação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPageDatagridViewBensMoveis()
            TabControl1.SelectedIndex = 3
        Catch ex As Exception
            RJMessageBox.Show($"Erro ao ler Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Liberação de recursos
            BarraProgresso.Visible = False
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


    Private Sub ChkIgnorarImportar_MouseClick(sender As Object, e As MouseEventArgs) Handles ChkIgnorarImportar.MouseClick
        If DgvImportBens.Rows.Count > 0 Then
            If ChkIgnorarImportar.Checked = True Then
                BtnImportarBens.Enabled = False
                BtnContinuar.Enabled = True
            Else
                BtnImportarBens.Enabled = True
                BtnContinuar.Enabled = False
            End If
        Else
            ChkIgnorarImportar.Checked = False
            RJMessageBox.Show($"Esta Igreja ainda não possui bens na base de dados." & vbNewLine & "Efetue a importação dos bens móveis para continuar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        LblInventario.Text = String.Empty
        LblImportIgreja.Text = String.Empty
        LblImportBens.Text = String.Empty
        LblImportInventariantes.Text = String.Empty
        LblImportResponsaveis.Text = String.Empty
        LblImportSetor.Text = String.Empty
        LblImportId_igreja.Text = String.Empty
        DgvImportBens.ClearSelection()
        ChkIgnorarImportar.Checked = False
        BtnContinuar.Enabled = False
        TabControl1.SelectedIndex = 3
    End Sub
#End Region ' TAB IMPORTAR

#Region "########## TAB INVENTÁRIO ##############"

    Private Sub TxtInventarioPesquisar_OnTextChange(sender As Object, e As EventArgs)
        LoadPageDatagridViewInventarioBens(TxtInventarioPesquisar.Text, CboInventarioConsultas.Text)
    End Sub

    Private Sub CboInventarioConsultas_OnSelectedIndexChanged(sender As Object, e As EventArgs)
        LoadPageDatagridViewInventarioBens(TxtInventarioPesquisar.Text, CboInventarioConsultas.Text)
    End Sub

    Private Sub BtnInventarioLimpar_Click(sender As Object, e As EventArgs)
        TxtInventarioPesquisar.Clear()
        CboInventarioConsultas.Text = String.Empty
        LoadPageDatagridViewInventarioBens()
    End Sub

    Private Sub BtnInventarioScanner_Click_1(sender As Object, e As EventArgs)
        Dim Form As Form = New FormInventarioLeitorScanner()
        Form.ShowDialog()
        AtualizaEstatisticas()
        LoadPageDatagridViewInventarioBens()
    End Sub

    Private Sub BtnInventarioDadosCelular_Click(sender As Object, e As EventArgs)
        Dim Form As Form = New FormInventarioCelular()
        Form.ShowDialog()
        AtualizaEstatisticas()
        LoadDataGridInventarioBens()
    End Sub

    Private Sub BtnInventarioPendencias_Click_1(sender As Object, e As EventArgs)
        Dim Form As Form = New FormInventarioPendencias()
        Form.ShowDialog()
        AtualizaEstatisticas()
        LoadDataGridInventarioBens()
    End Sub

    Private Sub BtnInventarioAtualizarDados_Click(sender As Object, e As EventArgs) Handles BtnInventarioAtualizarDados.Click
        AtualizaEstatisticas()
    End Sub

    Private Sub BtnEditarResponsaveis_Click(sender As Object, e As EventArgs) Handles BtnEditarResponsaveis.Click
        Dim Form As Form = New FormInventarioResponsaveis()
        Form.ShowDialog()
    End Sub

    Private Sub BtnInventarioImportar_Click(sender As Object, e As EventArgs) Handles BtnInventarioImportar.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub BtnInventarioFinalizar_Click(sender As Object, e As EventArgs) Handles BtnInventarioFinalizar.Click
        Dim InventarioBLL As New InventariosBLL(SQLite)
        Dim Inventario As InventariosDTO = InventarioBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)
        If Inventario IsNot Nothing Then
            Inventario.Situacao = "Finalizado"
            If Inventario.Termino = Inventario.Inicio Then Inventario.Termino = Now.ToString("yyyy-MM-dd HH:mm:ss")
            InventarioBLL.Atualizar(Inventario)
            If Inventario.Inventario_Teste = False Then ReplicarDados(SyncOrigem.Enviar, "inventarios", Inventario.Id, "Inserir")
            FormDashboard.AtualizarDashboard()
        End If

        Dim Form As Form = New FormInventarioFinalizado
        Form.ShowDialog()
        'VarGlob.Id_Inventario_Ativo = 0
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LoadDataGridInventarioBens(Optional TextoPesquisar As String = "", Optional Consulta As String = "")
        Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)
        Dim Dados As List(Of InventarioDetalhesDTO) = inventarioDetalhesBLL.BuscarTodos(SanitizeString(TextoPesquisar))
        Dim DadosFiltrados As List(Of InventarioDetalhesDTO) = Nothing

        Select Case (Consulta)
            Case ""
                DadosFiltrados = Dados.Where(Function(item) item.Acao = "PENDENTE").ToList()
            Case ""

            Case ""

            Case ""

            Case ""

            Case Else

        End Select


    End Sub

    Public Sub LoadPageDatagridViewInventarioBens(Optional TextoPesquisar As String = "", Optional Consulta As String = "")
        Dim inventarioDetalhesBLL As New InventarioDetalhesBLL(SQLite)

        ' Limpa a lista antes de adicionar novos itens
        detalhesLista.Clear()

        ' Busca os dados e adiciona à BindingList
        detalhesLista = New BindingList(Of InventarioDetalhesDTO)(inventarioDetalhesBLL.BuscarTodos(SanitizeString(TextoPesquisar), Consulta))

        If String.IsNullOrEmpty(Consulta) Then
            With DgvInventarioBens
                .DataSource = Nothing
                ' Limpa qualquer configuração anterior de colunas
                .Columns.Clear()
                ' Define o DataSource apenas com as colunas que você quer exibir
                .AutoGenerateColumns = True
                ' Vincula a lista ao DataGridView
                .DataSource = detalhesLista
                ' Organização das Colunas
                .Columns(0).Visible = False
                .Columns("id_inventario").Visible = False
                .Columns("id_dependencia").Visible = False
                .Columns("dependencia").Visible = False
                .Columns("acao").Visible = False
                .Columns("observacao").Visible = False
                .Columns("qtde").Visible = False
                .Columns("Id_bem").HeaderText = "Etiqueta"
                .Columns("bem").HeaderText = "Bem Móvel"
                .Columns("contagem").HeaderText = "Cont"
                .Columns("bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Id_bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("estado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("contagem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .AllowUserToOrderColumns = True
                'Limpar seleção automática da linha 1
                .ClearSelection()
            End With

        ElseIf Consulta = "BENS TOTALIZADOS" Then
            With DgvInventarioBens
                .DataSource = Nothing
                ' Limpa qualquer configuração anterior de colunas
                .Columns.Clear()
                ' Define o DataSource apenas com as colunas que você quer exibir
                .AutoGenerateColumns = True
                ' Vincula a lista ao DataGridView
                .DataSource = detalhesLista
                ' Organização das Colunas
                .Columns("id").Visible = False
                .Columns("id_inventario").Visible = False
                .Columns("id_bem").Visible = False
                .Columns("id_dependencia").Visible = False
                .Columns("dependencia").Visible = False
                .Columns("estado").Visible = False
                .Columns("acao").Visible = False
                .Columns("observacao").Visible = False
                .Columns("contagem").Visible = False
                .Columns("bem").HeaderText = "Bem Móvel"
                .Columns("bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Qtde").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                .AllowUserToOrderColumns = True
                'Limpar seleção automática da linha 1
                .ClearSelection()
            End With
        ElseIf Consulta = "BENS LOCALIZADOS" Then
            With DgvInventarioBens
                .DataSource = Nothing
                ' Limpa qualquer configuração anterior de colunas
                .Columns.Clear()
                ' Define o DataSource apenas com as colunas que você quer exibir
                .AutoGenerateColumns = True
                ' Vincula a lista ao DataGridView
                .DataSource = detalhesLista
                .Columns(0).Visible = False
                .Columns("id_inventario").Visible = False
                .Columns("id_dependencia").Visible = False
                .Columns("dependencia").Visible = False
                .Columns("acao").Visible = False
                .Columns("observacao").Visible = False
                .Columns("Id_bem").HeaderText = "Etiqueta"
                .Columns("bem").HeaderText = "Bem Móvel"
                .Columns("contagem").HeaderText = "Cont"
                .Columns("qtde").Visible = False
                .Columns("bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Id_bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("estado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("contagem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .AllowUserToOrderColumns = True
                'Limpar seleção automática da linha 1
                .ClearSelection()
            End With
        ElseIf Consulta = "BENS PENDENTES" Then
            With DgvInventarioBens
                .DataSource = Nothing
                ' Limpa qualquer configuração anterior de colunas
                .Columns.Clear()
                ' Define o DataSource apenas com as colunas que você quer exibir
                .AutoGenerateColumns = True
                ' Vincula a lista ao DataGridView
                .DataSource = detalhesLista
                .Columns(0).Visible = False
                .Columns("id_inventario").Visible = False
                .Columns("id_dependencia").Visible = False
                .Columns("acao").Visible = False
                .Columns("observacao").Visible = False
                .Columns("estado").Visible = False
                .Columns("contagem").Visible = False
                .Columns("qtde").Visible = False
                .Columns("Id_bem").HeaderText = "Etiqueta"
                .Columns("bem").HeaderText = "Bem Móvel"
                .Columns("bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Id_bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("dependencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .AllowUserToOrderColumns = True
                'Limpar seleção automática da linha 1
                .ClearSelection()
            End With
        ElseIf Consulta = "LIDOS REPETIDOS" Then
            With DgvInventarioBens
                .DataSource = Nothing
                ' Limpa qualquer configuração anterior de colunas
                .Columns.Clear()
                ' Define o DataSource apenas com as colunas que você quer exibir
                .AutoGenerateColumns = True
                ' Vincula a lista ao DataGridView
                .DataSource = detalhesLista
                .Columns(0).Visible = False
                .Columns("id_inventario").Visible = False
                .Columns("id_dependencia").Visible = False
                .Columns("acao").Visible = False
                .Columns("observacao").Visible = False
                .Columns("estado").Visible = False
                .Columns("qtde").Visible = False
                .Columns("Id_bem").HeaderText = "Etiqueta"
                .Columns("bem").HeaderText = "Bem Móvel"
                .Columns("contagem").HeaderText = "Cont"
                .Columns("bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Id_bem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("dependencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("contagem").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .AllowUserToOrderColumns = True
                'Limpar seleção automática da linha 1
                .ClearSelection()
            End With
        End If
        LblDgvInventarioBensTotal.Text = detalhesLista.Count & " item(ns)"
    End Sub

    Private Sub DgvInventarioBens_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        'Console.WriteLine("Coluna: " & e.ColumnIndex.ToString)

        ' Verifica se é a coluna "PENDENTE" (coluna de índice 6) e uma linha válida
        If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
            Dim linha As String = If(e.Value IsNot Nothing, CStr(e.Value), "") ' Converte para string e trata valores nulos

            ' Define a cor com base no valor da célula
            If linha = "PENDENTE" Then
                e.CellStyle.ForeColor = Color.OrangeRed
            ElseIf linha = "OK" Then
                e.CellStyle.ForeColor = Color.Green
            Else
                ' Limpa a cor se o valor não for "PENDENTE" nem "OK"
                e.CellStyle.ForeColor = DgvInventarioBens.DefaultCellStyle.ForeColor
            End If

            ' Verifica se é a coluna de índice 9 e uma linha válida
        ElseIf e.ColumnIndex = 9 AndAlso e.RowIndex >= 0 Then
            Dim linha As Integer
            If Integer.TryParse(Convert.ToString(e.Value), linha) Then ' Tenta converter para inteiro com segurança
                ' Define a cor com base no valor numérico
                e.CellStyle.ForeColor = If(linha > 1, Color.Red, Color.Gray)
            Else
                ' Reseta a cor se não for um número válido
                e.CellStyle.ForeColor = DgvInventarioBens.DefaultCellStyle.ForeColor
            End If
        End If
    End Sub

    Private Sub DgvInventarioBens_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Try
                ' Verifica se a linha e a célula são válidas antes de selecionar
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    DgvInventarioBens.ClearSelection()
                    DgvInventarioBens.Rows(e.RowIndex).Selected = True
                    rowIndex = e.RowIndex
                    colIndex = e.ColumnIndex

                    ' Verifica se a célula é visível antes de defini-la como a célula atual
                    DgvInventarioBens.CurrentCell = DgvInventarioBens.Rows(e.RowIndex).Cells(6)
                    ' Exibe o menu de contexto no local do cursor
                    DdmInventarioBens.Show(Cursor.Position)
                    'End If
                End If
            Catch ex As Exception
                RJMessageBox.Show($"Sem opção de Menu para esta consulta. {vbNewLine & ex.Message}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub ToolStripExcluir_Click(sender As Object, e As EventArgs) Handles ToolStripExcluir.Click
        Try
            ' Verifica se há uma linha selecionada no DataGridView
            If DgvInventarioBens.SelectedRows.Count = 0 Then
                RJMessageBox.Show("Selecione um item para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtém o índice da linha selecionada
            Dim rowIndex As Integer = DgvInventarioBens.SelectedRows(0).Index

            ' Obtém o valor da célula (ID do bem) verificando se o índice está correto
            Dim Id_bem As String = DgvInventarioBens.Rows(rowIndex).Cells("Id_bem").Value.ToString()


            ' Instancia a classe de negócios
            Dim InventarioDetalheBLL As New InventarioDetalhesBLL(SQLite)
            Dim Item As InventarioDetalhesDTO = InventarioDetalheBLL.BuscarPorId(Id_bem)

            ' Verifica se o item pode ser excluído
            If Item IsNot Nothing AndAlso Item.Estado <> "OK" Then
                InventarioDetalheBLL.Excluir(Item.Id_Bem)

                ' Remove da lista vinculada ao DataGridView
                Dim itemParaRemover As InventarioDetalhesDTO = detalhesLista.FirstOrDefault(Function(x) x.Id_Bem = Id_bem)
                If itemParaRemover IsNot Nothing Then
                    detalhesLista.Remove(itemParaRemover)
                End If
            Else
                ' Confirmação caso o item já tenha sido localizado
                If RJMessageBox.Show("Este Bem Móvel já foi localizado." & vbNewLine & "Tem certeza que quer excluí-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
                    InventarioDetalheBLL.Excluir(Item.Id_Bem)

                    ' Remove da BindingList
                    Dim itemParaRemover As InventarioDetalhesDTO = detalhesLista.FirstOrDefault(Function(x) x.Id_Bem = Id_bem)
                    If itemParaRemover IsNot Nothing Then
                        detalhesLista.Remove(itemParaRemover)
                    End If
                End If
            End If

            ' Atualiza estatísticas após exclusão
            AtualizaEstatisticas()

        Catch ex As OverflowException
            RJMessageBox.Show("O valor do ID excede o limite permitido.", "Erro de Estouro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            RJMessageBox.Show($"Erro ao excluir item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripPendente_Click(sender As Object, e As EventArgs) Handles ToolStripPendente.Click
        Try
            ' Verifica se há uma linha selecionada
            If DgvInventarioBens.SelectedRows.Count = 0 Then
                RJMessageBox.Show("Selecione um item para marcar como PENDENTE.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtém o índice da linha selecionada
            Dim rowIndex As Integer = DgvInventarioBens.SelectedRows(0).Index

            ' Obtém o valor da célula como String
            Dim Id_bem As String = DgvInventarioBens.Rows(rowIndex).Cells(2).Value.ToString()

            ' Instancia a classe de negócios
            Dim InventarioDetalheBLL As New InventarioDetalhesBLL(SQLite)
            Dim Item As InventarioDetalhesDTO = InventarioDetalheBLL.BuscarPorId(Id_bem)

            ' Atualiza os valores
            Item.Id_inventario = VarGlob.Inventario.Id
            Item.Estado = "PENDENTE"
            Item.Acao = "PENDENTE"
            Item.Bem = String.Empty
            Item.Id_dependencia = String.Empty
            Item.Contagem = 0

            ' Atualiza no banco de dados
            InventarioDetalheBLL.Atualizar(Item)

            ' Atualiza diretamente na lista vinculada ao DataGridView
            Dim itemParaAtualizar As InventarioDetalhesDTO = detalhesLista.FirstOrDefault(Function(x) x.Id_Bem = Id_bem)
            If itemParaAtualizar IsNot Nothing Then
                itemParaAtualizar.Estado = Item.Estado
                itemParaAtualizar.Acao = Item.Acao
                itemParaAtualizar.Contagem = Item.Contagem
            End If

            ' Atualiza estatísticas
            AtualizaEstatisticas()

            ' Força a atualização visual do DataGridView
            DgvInventarioBens.Refresh()

        Catch ex As OverflowException
            RJMessageBox.Show("Não foi possível reverter o estado deste Bem Móvel.", "Falha na Execução", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            RJMessageBox.Show($"Não foi possível reverter o estado deste Bem Móvel. Motivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripLocalizado_Click(sender As Object, e As EventArgs) Handles ToolStripLocalizado.Click
        Try
            ' Verifica se há uma linha selecionada
            If DgvInventarioBens.SelectedRows.Count = 0 Then
                RJMessageBox.Show("Selecione um item para marcar como LOCALIZADO.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Obtém o índice da linha selecionada
            Dim rowIndex As Integer = DgvInventarioBens.SelectedRows(0).Index

            ' Obtém o valor da célula como String
            Dim Id_bem As String = DgvInventarioBens.Rows(rowIndex).Cells(2).Value.ToString()

            ' Instancia a classe de negócios
            Dim InventarioDetalheBLL As New InventarioDetalhesBLL(SQLite)
            Dim Item As InventarioDetalhesDTO = InventarioDetalheBLL.BuscarPorId(Id_bem)

            ' Atualiza os valores
            Item.Id_inventario = VarGlob.Inventario.Id
            Item.Estado = "OK"
            Item.Acao = "OK"
            Item.Bem = String.Empty
            Item.Id_dependencia = String.Empty
            Item.Contagem += 1

            ' Atualiza no banco de dados
            InventarioDetalheBLL.Atualizar(Item)

            ' Atualiza diretamente na lista vinculada ao DataGridView
            Dim itemParaAtualizar As InventarioDetalhesDTO = detalhesLista.FirstOrDefault(Function(x) x.Id_Bem = Id_bem)
            If itemParaAtualizar IsNot Nothing Then
                itemParaAtualizar.Estado = Item.Estado
                itemParaAtualizar.Acao = Item.Acao
                itemParaAtualizar.Contagem = Item.Contagem
            End If

            ' Atualiza estatísticas
            AtualizaEstatisticas()

            ' Força a atualização visual do DataGridView
            DgvInventarioBens.Refresh()

        Catch ex As OverflowException
            RJMessageBox.Show("Não foi possível atualizar o estado deste Bem Móvel.", "Falha na Execução", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            RJMessageBox.Show($"Não foi possível atualizar o estado deste Bem Móvel. Motivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ToolStripMenuExcel_Click(sender As Object, e As EventArgs) Handles ToolStripMenuExcel.Click
        ExportarParaExcel(DgvInventarioBens)
    End Sub

    Private Sub ToolStripMenuTxt_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTxt.Click
        ExportarParaTXT(DgvInventarioBens)
    End Sub

    Private Sub ToolStripMenuPdf_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPdf.Click
        ExportarParaPDF(DgvInventarioBens)
    End Sub

    Private Sub ToolStripMenuCelula_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCelula.Click
        CopiarCelulaParaClipboard(DgvInventarioBens, colIndex)
    End Sub

    Private Sub ToolStripMenuLinha_Click(sender As Object, e As EventArgs) Handles ToolStripMenuLinha.Click
        CopiarLinhaParaClipboard(DgvInventarioBens)
    End Sub

    Private Sub ToolStripMenuTudo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTudo.Click
        CopiarTudoParaClipboard(DgvInventarioBens)
    End Sub


    Private Sub PopulaRelatoriosConsulta()
        With CboInventarioConsultas
            .Items.Clear()
            .Items.Add("BENS TOTALIZADOS")
            .Items.Add("BENS LOCALIZADOS")
            .Items.Add("BENS PENDENTES")
            .Items.Add("LIDOS REPETIDOS")
        End With
    End Sub

    Public Sub AtualizaEstatisticas()
        If Not String.IsNullOrEmpty(VarGlob.Id_Inventario_Ativo) Then
            ' Busca o inventário atual
            Dim Inventario As InventariosDTO = inventariosBLL.BuscarPorId(VarGlob.Id_Inventario_Ativo)

            ' Atualiza as informações no formulário
            LblInventarioIgreja.Text = Inventario.Igreja
            LblInventarioInicio.Text = Inventario.Inicio
            LblInventarioBensInicial.Text = Inventario.Bens_Inicial.ToString()
            LblInventarioBensPendentes.Text = Inventario.Bens_Pendentes.ToString()
            LblInventarioBensLocalizados.Text = Inventario.Bens_Lidos.ToString()
            LblInventarioBensNovos.Text = Inventario.Bens_Novos
            LblInventarioBensFinal.Text = DgvInventarioBens.Rows.Count

            ' Calcula a prévia e o resultado com verificação de divisão por zero
            LblInventarioPrevia.Text = If(Inventario.Bens_Inicial > 0,
                                       (Inventario.Bens_Lidos / Inventario.Bens_Inicial).ToString("P0"),
                                       "N/A")

            LblInventarioResultado.Text = If(Inventario.Bens_Final > 0,
                                          (Inventario.Bens_Lidos / LblInventarioBensFinal.Text).ToString("P0"),
                                          "N/A")
        End If
    End Sub

#End Region

#Region "########## FUNCOES GERAIS ##############"

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

#End Region 'FUNCOES GERAIS

End Class