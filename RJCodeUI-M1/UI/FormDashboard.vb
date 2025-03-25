Imports System.Windows.Forms.DataVisualization.Charting
Imports PROJETOBASE.Models

Public Class FormDashboard
    Inherits RJChildForm

    Private analysis As SalesAnalysis = New SalesAnalysis()
    Private SQLite As New ConnectionFactory(DatabaseType.SQLite)

    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        LoadComboAnos()
        LoadComboSetor()
        AtualizarDashboard()
        BtnReset_Click(sender:="", e:=Nothing)
    End Sub

    Private Sub LblCliqueAqui_Click(sender As Object, e As EventArgs) Handles LblCliqueAqui.Click
        Dim Form As Form = New FormSincronizar
        Form.ShowDialog()
    End Sub

    Public Sub AtualizarDashboard()
        Try

            Dim DashboardBLL As New DashboardBLL(SQLite)
            Dim anoSelecionado As Integer = If(CmbAno.SelectedItem IsNot Nothing, CInt(CmbAno.SelectedItem), Year(Now()))
            Dim setorSelecionado As String = If(CmbSetor IsNot Nothing, CmbSetor.Text, "") 'If(CmbSetor.SelectedItem IsNot Nothing, CmbSetor.SelectedItem.descricao.ToString(), "")

            Dim Dashboard As DashboardDTO = DashboardBLL.ObterDadosDashboard(anoSelecionado, setorSelecionado)

            LblTitulo.Text = $"DADOS ANALÍTICOS PARA INVENTÁRIOS DE BENS MÓVEIS DO ANO DE {anoSelecionado}{If(String.IsNullOrWhiteSpace(setorSelecionado), String.Empty, $" | SETOR - {setorSelecionado}")}"

            ' Preencher indicadores
            LblSetores.Text = Dashboard.Setores.ToString()
            LblIgrejasAtivas.Text = Dashboard.IgrejasAtivas.ToString()
            LblIgrejasInativas.Text = Dashboard.IgrejasInativas.ToString()
            LblDepartamentos.Text = Dashboard.Departamentos.ToString()
            LblRealizadosTotal.Text = Dashboard.InventariosRealizados.ToString()

            Dim totalRealizados As Integer = Convert.ToInt32(LblRealizadosTotal.Text)
            Dim totalIgrejasAtivas As Integer = Convert.ToInt32(LblIgrejasAtivas.Text)

            If totalIgrejasAtivas > 0 Then
                Dim percentRealizados As Double = totalRealizados / totalIgrejasAtivas
                LblRealizadosPercent.Text = percentRealizados.ToString("P0") ' Formata como porcentagem sem casas decimais
            Else
                LblRealizadosPercent.Text = "0%" ' Evita divisão por zero
            End If

            ' Preencher gráfico de pizza (Igrejas por Setor)
            Load_Grafico_Pizza_IgrejasSetor(Dashboard.IgrejasPorSetor)
            Load_Grafico_Pizza_InventariosSetor(Dashboard.InventariosPorSetor)

            ' Preencher gráfico de barras (Inventários por Ano)
            Load_Grafico_Barras_Inventarios(Dashboard.InventariosPorAno)

            ' Preencher tabela de Últimos Inventários
            Load_UltimosInventarios(Dashboard.UltimosInventarios)

            ' Preencher tabela de Situação por Setor
            Load_SituacaoSetor(Dashboard.SituacaoPorSetor)

        Catch ex As Exception
            MessageBox.Show($"Erro ao atualizar o dashboard: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadComboAnos()
        Dim InventariosBLL As New InventariosBLL(SQLite)
        ' Obtém a lista de listas de strings
        Dim anoList As List(Of List(Of String)) = InventariosBLL.BuscarListaAnos()

        ' Extrai os anos como uma lista de strings
        Dim anos As List(Of String) = anoList.Select(Function(sublist) sublist(0)).ToList()

        CmbAno.DataSource = Nothing  ' Remove o DataSource atual
        CmbAno.Items.Clear()         ' Limpa os itens do ComboBox

        If anos IsNot Nothing AndAlso anos.Count > 0 Then
            CmbAno.DataSource = anos  ' Atribui a lista de anos diretamente como DataSource

            ' Seleciona o ano atual se ele existir na lista
            Dim anoAtual As String = Now.Year.ToString()
            If anos.Contains(anoAtual) Then
                CmbAno.SelectedItem = anoAtual
            Else
                CmbAno.SelectedIndex = -1 ' Limpa a seleção se o ano atual não estiver na lista
            End If
        Else
            CmbAno.SelectedIndex = -1 ' Limpa a seleção caso a lista seja nula ou vazia
        End If
    End Sub

    Private Sub LoadComboSetor()
        Try
            Dim SetoresBLL As New SetoresBLL(SQLite)
            Dim setoresList = SetoresBLL.BuscarTodos()  ' Busca todos os setores diretamente

            ' Limpa o ComboBox antes de atribuir a nova lista de setores
            CmbSetor.DataSource = Nothing  ' Remove o DataSource atual
            CmbSetor.Items.Clear()         ' Limpa os itens do ComboBox

            ' Verifica se há setores retornados
            If setoresList IsNot Nothing AndAlso setoresList.Count > 0 Then
                With CmbSetor
                    ' Configura o DataSource
                    .DataSource = setoresList  ' Atribui a lista de setores diretamente como DataSource

                    ' Define qual propriedade do objeto 'Setor' será exibida no ComboBox
                    .DisplayMember = "Descricao"    ' Propriedade que será mostrada no ComboBox (assumindo que a classe Setor tem a propriedade 'Nome')

                    ' Define qual propriedade será usada como valor (ID ou outra chave)
                    .ValueMember = "Cod_Setor"        ' Propriedade que será usada como valor (assumindo que a classe Setor tem a propriedade 'ID')
                    .SelectedItem = Nothing
                    .SelectedIndex = -1
                    .Text = String.Empty

                End With
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Load_UltimosInventarios(Dados As List(Of InventariosDTO))
        With DgvUltimosInventarios
            .DataSource = Nothing
            ' Limpa qualquer configuração anterior de colunas
            .Columns.Clear()

            ' Define o DataSource apenas com as colunas que você quer exibir
            .AutoGenerateColumns = True

            ' Vincula a lista ao DataGridView
            .DataSource = Dados

            ' Configuração das colunas
            .Columns("id_igreja").Visible = False
            .Columns("responsaveis").Visible = False
            .Columns("inventariantes").Visible = False
            .Columns("inicio").Visible = False
            .Columns("termino").Visible = False
            .Columns("duracao").Visible = False
            .Columns("situacao").Visible = False
            .Columns("bens_inicial").Visible = False
            .Columns("bens_lidos").Visible = False
            .Columns("bens_pendentes").Visible = False
            .Columns("bens_novos").Visible = False
            .Columns("bens_final").Visible = False
            .Columns("bens_importado").Visible = False
            .Columns("inventario_teste").Visible = False
            .Columns("cod_setor").Visible = False
            .Columns("id_admlc").Visible = False
            .Columns("data_alteracao").Visible = False

            ' Definir os cabeçalhos das colunas visíveis
            .Columns("id").HeaderText = "Inventário"
            .Columns("data").HeaderText = "Data"
            .Columns("igreja").HeaderText = "Igreja"
            .Columns("setor").HeaderText = "Setor"
            .Columns("siga_ok").HeaderText = "Siga Pendente"

            ' Definindo a largura das colunas
            .Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("data").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("igreja").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("setor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("siga_ok").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            ' Ordenação das colunas
            .Columns("id").DisplayIndex = 0    ' Inventário na primeira posição
            .Columns("data").DisplayIndex = 1 ' Data na segunda posição
            .Columns("igreja").DisplayIndex = 2 ' Igreja na terceira posição
            .Columns("setor").DisplayIndex = 3 ' Setor na quarta posição
            .Columns("siga_ok").DisplayIndex = 4 ' Siga Ok na quinta posição

            ' Permitir ordenação de colunas pelo usuário
            .AllowUserToOrderColumns = True

            ' Limpar seleção automática da linha 1
            .ClearSelection()
        End With
    End Sub

    Private Sub Load_SituacaoSetor(Dados As List(Of SituacaoSetorDTO))
        With DgvSituacaoPorSetor
            .DataSource = Nothing
            ' Limpa qualquer configuração anterior de colunas
            .Columns.Clear()

            ' Define o DataSource apenas com as colunas que você quer exibir
            .AutoGenerateColumns = True

            ' Vincula a lista ao DataGridView
            .DataSource = Dados

            ' Configuração das colunas

            ' Definir os cabeçalhos das colunas visíveis
            With .Columns("cod_setor")
                .HeaderText = "#"
                .ToolTipText = "Código do Setors"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Visible = True
            End With

            With .Columns("setor")
                .HeaderText = "Setor"
                .ToolTipText = "Setor"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            With .Columns("igrejas")
                .HeaderText = "Igrejas"
                .ToolTipText = "Total de Igrejas"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            With .Columns("igrejasativas")
                .HeaderText = "AT"
                .ToolTipText = "Total de Igrejas Ativas"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            With .Columns("igrejasinativas")
                .HeaderText = "IN"
                .ToolTipText = "Total de Igrejas Inativas"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            With .Columns("inventariosrealizados")
                .HeaderText = "RL"
                .ToolTipText = "Total de Inventários Realizados"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            With .Columns("inventariospendentes")
                .HeaderText = "PD"
                .ToolTipText = "Total de Inventários Pendentes"
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            ' Permitir ordenação de colunas pelo usuário
            .AllowUserToOrderColumns = True

            ' Limpar seleção automática da linha 1
            .ClearSelection()
        End With
    End Sub

    Private Sub Load_Grafico_Pizza_IgrejasSetor(Dados As Dictionary(Of String, Integer))
        ' Configurar o gráfico de pizza com os dados de Igrejas por Setor
        ChartIgrejasPorSetor.Series.Clear() ' Limpa qualquer série existente

        ' Cria uma nova série do tipo Pizza
        Dim series = ChartIgrejasPorSetor.Series.Add("Igrejas")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Pie ' Define o tipo de gráfico como pizza

        ' Adiciona os dados ao gráfico
        For Each setor In Dados
            series.Points.AddXY(setor.Key, setor.Value) ' Adiciona cada setor como um ponto no gráfico
        Next

        ' Configurações visuais (opcional)
        ChartIgrejasPorSetor.Titles.Clear()
        ChartIgrejasPorSetor.Titles.Add("Igrejas por Setor") ' Título do gráfico

        ' Personalizar rótulos de dados
        series.IsValueShownAsLabel = True ' Mostra os valores nos rótulos
        series.LabelFormat = "{N0}" ' Formata os rótulos para exibir porcentagem

        ' Configurações adicionais (opcional, para melhor visualização)
        ChartIgrejasPorSetor.Legends.Clear() ' Adiciona uma legenda
        Dim legend = ChartIgrejasPorSetor.Legends.Add("Legenda")
        With legend
            .Docking = DataVisualization.Charting.Docking.Right ' Posiciona a legenda abaixo do gráfico
            .Alignment = StringAlignment.Center
            .Title = "Setores"
        End With

    End Sub

    Private Sub Load_Grafico_Barras_Inventarios(Dados As Dictionary(Of Integer, Integer))
        ' Limpa as séries existentes no gráfico
        chartInventarios.Series.Clear()

        ' Adiciona uma nova série
        Dim seriesInventarios = chartInventarios.Series.Add("Inventários")
        seriesInventarios.ChartType = SeriesChartType.Column ' Define como gráfico de colunas (barras verticais)

        ' Define os nomes dos meses
        Dim nomesMeses As String() = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                                   "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"}

        ' Adiciona os dados ao gráfico
        Dim maxValor As Integer = 0 ' Variável para armazenar o maior valor (definição do eixo Y)

        For Each mes In Dados
            Dim mesNome As String = nomesMeses(mes.Key - 1) ' Obtém o nome do mês
            Dim inventarios As Integer = mes.Value ' Quantidade de inventários

            ' Adiciona ponto ao gráfico
            seriesInventarios.Points.AddXY(mesNome, inventarios)

            ' Atualiza o maior valor do eixo Y
            If inventarios > maxValor Then maxValor = inventarios
        Next

        ' Configurações do título
        chartInventarios.Titles.Clear()
        chartInventarios.Titles.Add("Inventários por Mês") ' Título do gráfico

        ' Mostra os valores sobre as barras
        seriesInventarios.IsValueShownAsLabel = True ' Exibe os valores no gráfico
        seriesInventarios.LabelFormat = "{N0}" ' Formato dos números

        ' Configurações do eixo X (Meses)
        Dim eixoX = chartInventarios.ChartAreas(0).AxisX
        eixoX.Interval = 1 ' Define o intervalo como 1 para exibir todos os meses
        eixoX.Title = "Meses"
        eixoX.MajorGrid.Enabled = False ' Remove as linhas de grade no eixo X

        ' Configurações do eixo Y (Quantidade de Inventários)
        Dim eixoY = chartInventarios.ChartAreas(0).AxisY
        eixoY.Title = "Inventários"
        eixoY.LabelStyle.Format = "{N0}" ' Formata os números no eixo Y
        eixoY.MajorGrid.LineDashStyle = ChartDashStyle.Dash ' Linhas de grade no eixo Y
        eixoY.Minimum = 0 ' Garante que o eixo Y comece do zero
        eixoY.Maximum = If(maxValor > 0, maxValor + (maxValor * 0.2), 10) ' Define um pouco acima do maior valor
        eixoY.Interval = Math.Max(1, Math.Ceiling(maxValor / 5.0)) ' Define intervalos razoáveis

        ' Atualiza o gráfico
        chartInventarios.Refresh()
    End Sub


    Private Sub Load_Grafico_Pizza_InventariosSetor(Dados As Dictionary(Of String, Integer))
        ' Configurar o gráfico de pizza com os dados de Igrejas por Setor
        ChartInventariosPorSetor.Series.Clear() ' Limpa qualquer série existente

        ' Cria uma nova série do tipo Pizza
        Dim series = ChartInventariosPorSetor.Series.Add("Inventarios")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Pie ' Define o tipo de gráfico como pizza

        ' Adiciona os dados ao gráfico
        For Each Inventario In Dados
            series.Points.AddXY(Inventario.Key, Inventario.Value) ' Adiciona cada setor como um ponto no gráfico
        Next

        ' Configurações visuais (opcional)
        ChartInventariosPorSetor.Titles.Clear()
        ChartInventariosPorSetor.Titles.Add("Inventários por Setor") ' Título do gráfico

        ' Personalizar rótulos de dados
        series.IsValueShownAsLabel = True ' Mostra os valores nos rótulos
        series.LabelFormat = "{N0}" ' Formata os rótulos para exibir porcentagem

        ' Configurações adicionais (opcional, para melhor visualização)
        ChartInventariosPorSetor.Legends.Clear() ' Adiciona uma legenda
        Dim legend = ChartInventariosPorSetor.Legends.Add("Legenda")
        With legend
            .Docking = DataVisualization.Charting.Docking.Right ' Posiciona a legenda abaixo do gráfico
            .Alignment = StringAlignment.Center
            .Title = "Setores"
        End With

    End Sub

    Private Sub CmbAno_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAno.OnSelectedIndexChanged
        AtualizarDashboard()
    End Sub

    Private Sub CmbSetor_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSetor.OnSelectedIndexChanged
        AtualizarDashboard()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        LoadComboAnos()
        LoadComboSetor()
        AtualizarDashboard()
        LblTitulo.Text = $"DADOS ANALÍTICOS PARA INVENTÁRIOS DE BENS MÓVEIS DO ANO DE {Year(Now())}"
    End Sub
End Class