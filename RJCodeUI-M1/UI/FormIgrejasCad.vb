'Última Atualização: 08/10/2024
'Data: 04/10/2024
'Autor: Rodrigo Fernando Gomes Lima

Public Class FormIgrejasCad
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private igrejasBLL As IgrejasBLL
    Private statusBLL As StatusBLL
    Private tipoBLL As TipoBLL
    Private setorBLL As SetoresBLL
    Private admlcBLL As AdmlcBLL

    Public Sub New()

        InitializeComponent()
        igrejasBLL = New IgrejasBLL(SQLite)
        statusBLL = New StatusBLL(SQLite)
        tipoBLL = New TipoBLL(SQLite)
        setorBLL = New SetoresBLL(SQLite)
        admlcBLL = New AdmlcBLL(SQLite)
        ComboUF()           ' Carregar os estados brasileiros
        ComboStatus()       ' Carregar os status
        ComboSetor()        ' Carregar os setores
        ComboTipo()         ' Carregar os tipos
        ComboAdmLc()        ' Carregar os administradores locais
        lblTitulo.Text = "Incluir Casa de Oração"
        TxtCodigo.Enabled = True
        TxtCod_Siga.Enabled = True
        TxtIgreja.Enabled = True

    End Sub

    Public Sub New(igreja As IgrejasDTO)
        ' Chama a inicialização padrão do form
        InitializeComponent()
        igrejasBLL = New IgrejasBLL(SQLite)
        statusBLL = New StatusBLL(SQLite)
        tipoBLL = New TipoBLL(SQLite)
        setorBLL = New SetoresBLL(SQLite)
        admlcBLL = New AdmlcBLL(SQLite)


        ' Preenche os campos com os dados da Igreja
        lblTitulo.Text = "Alterar Casa de Oração"
        lblTitulo.Select()

        TxtCodigo.Text = igreja.Id
        TxtCod_Siga.Text = igreja.Cod_Siga
        TxtIgreja.Text = igreja.Igreja
        TxtRazao_Social.Text = igreja.Razao_Social
        TxtCNPJ.Text = igreja.CNPJ
        TxtLogradouro.Text = igreja.Logradouro
        TxtNumero.Text = igreja.Numero
        TxtBairro.Text = igreja.Bairro
        TxtCidade.Text = igreja.Cidade

        ' Define o valor selecionado nos ComboBox
        ComboUF(igreja.UF)
        ComboStatus(igreja.Id_Status)
        ComboSetor(igreja.Cod_Setor)
        ComboTipo(igreja.Id_Tipo)
        ComboAdmLc(igreja.id_AdmLc)
        TxtObservacao.Text = igreja.observacao
    End Sub

    ' Método para carregar os estados brasileiros no ComboBox
    Private Sub ComboUF(Optional itemSelecionado As String = "")
        Dim estadosBrasil As New Dictionary(Of String, String) From {
        {"AC", "Acre"}, {"AL", "Alagoas"}, {"AP", "Amapá"}, {"AM", "Amazonas"}, {"BA", "Bahia"},
        {"CE", "Ceará"}, {"DF", "Distrito Federal"}, {"ES", "Espírito Santo"}, {"GO", "Goiás"},
        {"MA", "Maranhão"}, {"MT", "Mato Grosso"}, {"MS", "Mato Grosso do Sul"}, {"MG", "Minas Gerais"},
        {"PA", "Pará"}, {"PB", "Paraíba"}, {"PR", "Paraná"}, {"PE", "Pernambuco"}, {"PI", "Piauí"},
        {"RJ", "Rio de Janeiro"}, {"RN", "Rio Grande do Norte"}, {"RS", "Rio Grande do Sul"},
        {"RO", "Rondônia"}, {"RR", "Roraima"}, {"SC", "Santa Catarina"}, {"SP", "São Paulo"},
        {"SE", "Sergipe"}, {"TO", "Tocantins"}
    }

        CboUF.DisplayMember = "Key"    ' Exibe a sigla
        CboUF.ValueMember = "Key"      ' O valor também será a sigla

        For Each estado As KeyValuePair(Of String, String) In estadosBrasil
            CboUF.Items.Add(estado)
        Next

        ' Se foi passado um item para ser selecionado, tenta selecioná-lo
        If Not String.IsNullOrEmpty(itemSelecionado) Then
            ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
            Dim itemEncontrado = estadosBrasil.FirstOrDefault(Function(s) s.Key = itemSelecionado)

            If itemEncontrado.Key IsNot Nothing Then
                ' Seleciona o item baseado no valor
                CboUF.Text = itemEncontrado.Key
            Else
                CboUF.Text = ""
            End If
        Else
            CboUF.Text = ""
        End If
    End Sub

    ' Método para carregar os status no ComboBox
    Private Sub ComboStatus(Optional itemSelecionado As Integer = -1)
        ' Instancia o objeto BLL para buscar os status
        Dim statusBLL As New StatusBLL(SQLite)
        Dim statusList = New List(Of StatusDTO)()

        ' Busca todos os status e adiciona na lista
        statusList.AddRange(statusBLL.BuscarTodos())

        ' Limpa o ComboBox antes de atribuir a nova lista de Status
        CboStatus.DataSource = Nothing  ' Remove o DataSource atual
        CboStatus.Items.Clear()         ' Limpa os itens do ComboBox

        ' Verifica se há Status retornados
        If statusList IsNot Nothing AndAlso statusList.Count > 0 Then
            ' Configura o DataSource
            CboStatus.DataSource = statusList  ' Atribui a lista de Status diretamente como DataSource           

            ' Define qual propriedade do objeto 'Status' será exibida no ComboBox
            CboStatus.DisplayMember = "Descricao"    ' Propriedade que será mostrada no ComboBox (assumindo que a classe Status tem a propriedade 'Nome')

            ' Define qual propriedade será usada como valor (ID ou outra chave)
            CboStatus.ValueMember = "Id"        ' Propriedade que será usada como valor (assumindo que a classe Status tem a propriedade 'ID')

            ' Se foi passado um item para ser selecionado, tenta selecioná-lo
            If Not String.IsNullOrEmpty(itemSelecionado) Then
                ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
                Dim itemEncontrado = statusList.FirstOrDefault(Function(s) s.Id = itemSelecionado)

                If itemEncontrado IsNot Nothing Then
                    ' Seleciona o item baseado no valor
                    CboStatus.Text = itemEncontrado.Descricao
                Else
                    CboStatus.Text = ""
                End If
            Else
                CboStatus.Text = ""
            End If
        End If
    End Sub

    ' Método para carregar os tipos no ComboBox
    Private Sub ComboTipo(Optional itemSelecionado As Integer = -1)
        ' Instancia o objeto BLL para buscar os Tipo
        Dim tipoBLL As New TipoBLL(SQLite)
        Dim tipoList = New List(Of TipoDTO)()

        ' Busca todos os Tipo e adiciona na lista
        tipoList.AddRange(tipoBLL.BuscarTodos())

        ' Limpa o ComboBox antes de atribuir a nova lista de Tipo
        CboTipo.DataSource = Nothing  ' Remove o DataSource atual
        CboTipo.Items.Clear()         ' Limpa os itens do ComboBox

        ' Verifica se há Tipo retornados
        If tipoList IsNot Nothing AndAlso tipoList.Count > 0 Then
            ' Configura o DataSource
            CboTipo.DataSource = tipoList  ' Atribui a lista de Tipo diretamente como DataSource

            ' Define qual propriedade do objeto 'Tipo' será exibida no ComboBox
            CboTipo.DisplayMember = "Descricao"    ' Propriedade que será mostrada no ComboBox (assumindo que a classe Tipo tem a propriedade 'Nome')

            ' Define qual propriedade será usada como valor (ID ou outra chave)
            CboTipo.ValueMember = "Id"        ' Propriedade que será usada como valor (assumindo que a classe Tipo tem a propriedade 'ID')

            ' Se foi passado um item para ser selecionado, tenta selecioná-lo
            If Not String.IsNullOrEmpty(itemSelecionado) Then
                ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
                Dim admEncontrada = tipoList.FirstOrDefault(Function(s) s.Id = itemSelecionado)

                If admEncontrada IsNot Nothing Then
                    ' Seleciona o item baseado no valor
                    CboTipo.Text = admEncontrada.Descricao
                Else
                    CboTipo.Text = ""
                End If
            Else
                CboTipo.Text = ""
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
            CboSetor.ValueMember = "Id"        ' Propriedade que será usada como valor (assumindo que a classe Setor tem a propriedade 'ID')

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

    Private Sub ComboAdmLc(Optional itemSelecionado As Integer = -1)
        ' Instancia o objeto BLL para buscar os admlc
        Dim admlcBLL As New AdmlcBLL(SQLite)
        Dim admlcList = admlcBLL.BuscarTodos()

        ' Limpa o ComboBox antes de atribuir a nova lista de admlc
        CboAdmlc.Items.Clear()

        ' Limpa o ComboBox antes de atribuir a nova lista de setores
        CboAdmlc.DataSource = Nothing  ' Remove o DataSource atual
        CboAdmlc.Items.Clear()         ' Limpa os itens do ComboBox

        ' Verifica se há setores retornados
        If admlcList IsNot Nothing AndAlso admlcList.Count > 0 Then
            ' Configura o DataSource
            CboAdmlc.DataSource = admlcList  ' Atribui a lista de setores diretamente como DataSource

            ' Define qual propriedade do objeto 'Admlc' será exibida no ComboBox
            CboAdmlc.DisplayMember = "Adm_Local"    ' Propriedade que será mostrada no ComboBox (assumindo que a classe Admlc tem a propriedade 'Nome')

            ' Define qual propriedade será usada como valor (ID ou outra chave)
            CboAdmlc.ValueMember = "Id"        ' Propriedade que será usada como valor (assumindo que a classe Admlc tem a propriedade 'ID')

            ' Se foi passado um item para ser selecionado, tenta selecioná-lo
            If Not String.IsNullOrEmpty(itemSelecionado) Then
                ' Procura o índice do item na lista comparando pelo DisplayMember (Nome)
                Dim admEncontrada = admlcList.FirstOrDefault(Function(s) s.Id = itemSelecionado)

                If admEncontrada IsNot Nothing Then
                    ' Seleciona o item baseado no valor
                    CboAdmlc.Text = admEncontrada.Adm_Local
                Else
                    CboAdmlc.Text = ""
                End If
            Else
                CboAdmlc.Text = ""
            End If
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim alerta As New List(Of String)
        ' Chama a função de validação. Se falhar, interrompe o processo
        If Not ValidarControle(TxtCodigo, ErrorProvider1) Then Return
        If Not ValidarControle(TxtIgreja, ErrorProvider1) Then Return
        If Not ValidarControle(TxtCod_Siga, ErrorProvider1) Then Return
        If Not ValidarControle(CboTipo, ErrorProvider1) Then Return
        If Not ValidarControle(CboSetor, ErrorProvider1) Then Return
        If Not ValidarControle(CboStatus, ErrorProvider1) Then Return
        If Not ValidarControle(CboAdmlc, ErrorProvider1) Then Return

        Dim id_status = statusBLL.BuscarPorNome(CboStatus.Text)
        Dim cod_setor = setorBLL.BuscarPorNome(CboSetor.Text)
        Dim id_tipo = tipoBLL.BuscarPorNome(CboTipo.Text)
        Dim id_admlc = admlcBLL.BuscarPorNome(CboAdmlc.Text)

        Dim igreja As New IgrejasDTO With {
            .Id = SanitizeString(TxtCodigo.Text),
            .Igreja = SanitizeString(TxtIgreja.Text.ToUpper()),
            .Cod_Siga = SanitizeString(TxtCod_Siga.Text),
            .Razao_Social = "CONGREGAÇÃO CRISTÃ NO BRASIL",
            .CNPJ = SanitizeString(TxtCNPJ.Text),
            .Logradouro = SanitizeString(TxtLogradouro.Text.ToUpper()),
            .Numero = SanitizeString(TxtNumero.Text.ToUpper()),
            .Bairro = SanitizeString(TxtBairro.Text.ToUpper()),
            .Cidade = SanitizeString(TxtCidade.Text.ToUpper()),
            .UF = SanitizeString(CboUF.Text.ToUpper()),
            .Id_Tipo = id_tipo.Id,
            .Cod_Setor = cod_setor.Cod_Setor,
            .Id_Status = id_status.Id,
            .Id_AdmLc = id_admlc.Id,
            .observacao = SanitizeString(TxtObservacao.Text.ToUpper())
        }

        Dim IdExiste As Boolean
        Try
            IdExiste = IIf(Not IsNothing(igrejasBLL.BuscarPorId(igreja.Id)), True, False)
        Catch ex As Exception
            RJMessageBox.Show("Erro ao consultar id do setor: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        If IdExiste Then
            'ATUALIZAR
            Try
                igrejasBLL.Atualizar(igreja)
                ReplicarDados(SyncOrigem.Enviar, "igrejas", igreja.Id, "Atualiza")
                RJMessageBox.Show("Casa de Oração atualizada com sucesso!", "ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Catch ex As Exception
                RJMessageBox.Show("Erro ao Atualizar CASA DE ORAÇÃO: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            'CADASTRAR
            Try
                igrejasBLL.Inserir(igreja)
                ReplicarDados(SyncOrigem.Enviar, "igrejas", igreja.Id, "Inserir")
                RJMessageBox.Show("Casa de Oração cadastrada com sucesso!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Catch ex As Exception
                RJMessageBox.Show("Erro ao adicionar CASA DE ORAÇÃO: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If


    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Close()
    End Sub
End Class