'Última Atualização:    21/11/2024
'Data:                  21/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima
'Descrição:             Gerenciamento de sincronização de dados

Imports System.Windows.Media

Module SyncHelper
    Private ReadOnly SQLite As New ConnectionFactory()
    Private ReadOnly MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private ReadOnly MySQL_SYS As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private ReadOnly InventBLL As New InventariosBLL(SQLite)
    Private ReadOnly InventOnBLL As New InventariosOnBLL(MySQL)
    Private ReadOnly SincroBLL As New SincronizarBLL(SQLite)
    Private ReadOnly DependBLL As New DependenciasBLL(SQLite)
    Private ReadOnly DependOnBLL As New DependenciasOnBLL(MySQL_SYS)
    Private ReadOnly igrejasBLL As New IgrejasBLL(SQLite)
    Private ReadOnly igrejasOnBLL As New IgrejasOnBLL(MySQL_SYS)
    Private ReadOnly setoresBLL As New SetoresBLL(SQLite)
    Private ReadOnly setoresOnBLL As New SetoresOnBLL(MySQL_SYS)

    Public Enum SyncOrigem
        Enviar
        Receber
    End Enum

    Public Sub ReplicarDados(Destino As SyncOrigem, Tabela As String, Id_Tabela As String, TipoOperacao As String)
        Dim DataAtual As DateTime = DateTime.Now
        Dim Id_Admlc As Integer = VarGlob.SistemaAtivo.Id_Admlc

        ' Buscar se já existe um registro de sincronização para este item
        Dim SincroExiste As SincronizarDTO = SincroBLL.BuscarIdTabela(Id_Tabela)

        If SincroExiste IsNot Nothing Then
            ' Atualiza a sincronização existente
            SincroExiste.Tipo_Operacao = TipoOperacao.ToUpper
            SincroExiste.Acao = If(Destino = 0, "Enviar", "Receber")
            SincroExiste.Status = 0 ' Pendente para sincronização
            SincroExiste.Data_Atualizacao = DataAtual
            SincroExiste.Id_Admlc = Id_Admlc
            SincroBLL.Atualizar(SincroExiste)
        Else
            ' Criar novo registro de sincronização
            Dim SincroAdd As New SincronizarDTO With {
                .Tabela = Tabela,
                .Id_Tabela = Id_Tabela,
                .Tipo_Operacao = TipoOperacao.ToUpper,
                .Acao = If(Destino = 0, "Enviar", "Receber"),
                .Status = 0,
                .Data_Atualizacao = DataAtual,
                .Id_Admlc = Id_Admlc
            }
            SincroBLL.Inserir(SincroAdd)
        End If
    End Sub

    Public Sub ChecarDadosRemotos()
        'Checar Setores
        ChecarSetoresRemotos()
        'Checar Dependências
        ChecarNovasDependencias()
        'Checar Igrejas
        ChecarIgrejasRemotas()
        'Checar Inventarios
        ChecarInventariosRemotos()
    End Sub

    Private Sub ChecarNovasDependencias()
        Try
            ' Busca todas as dependências remotas (nuvem) e locais
            Dim DependListRemoto As List(Of DependenciasOnDTO) = DependOnBLL.BuscarTodos()
            Dim DependListLocal As List(Of DependenciasDTO) = DependBLL.BuscarTodos()

            ' Verifica se há dependências remotas antes de continuar
            If DependListRemoto Is Nothing OrElse DependListRemoto.Count = 0 Then Exit Sub

            ' Cria um dicionário para acesso rápido às dependências locais por ID
            Dim DependLocalDict As Dictionary(Of Integer, DependenciasDTO) = DependListLocal.ToDictionary(Function(d) d.Id)

            ' Percorre as dependências remotas e verifica se precisam ser adicionadas
            For Each DepOn As DependenciasOnDTO In DependListRemoto
                If Not DependLocalDict.ContainsKey(DepOn.Id) Then
                    ' Se a dependência não existe localmente, adiciona à fila de sincronização
                    ReplicarDados(SyncOrigem.Receber, "dependencias", DepOn.Id, "inserir")
                End If
            Next

        Catch ex As Exception
            ' Captura qualquer erro e exibe/loga a mensagem
            Console.WriteLine($"Erro ao verificar dependências remotas: {ex.Message}")
        End Try
    End Sub


    Private Sub ChecarInventariosRemotos()
        Try
            ' Busca os inventários remotos (nuvem) e locais
            Dim InventListRemoto As List(Of InventariosOnDTO) = InventOnBLL.BuscarTodos()
            Dim InventListLocal As List(Of InventariosDTO) = InventBLL.BuscarTodos()

            ' Verifica se há inventários remotos
            If InventListRemoto Is Nothing OrElse InventListRemoto.Count = 0 Then Exit Sub

            ' Otimiza a busca local usando um Dicionário para acesso rápido por ID
            Dim InventLocalDict As Dictionary(Of String, InventariosDTO) = InventListLocal.ToDictionary(Function(i) i.Id)

            ' Percorre os inventários remotos para comparar e sincronizar
            For Each InvOn As InventariosOnDTO In InventListRemoto
                If Not InventLocalDict.ContainsKey(InvOn.Id) Then
                    ' Se o inventário não existe localmente, adiciona à fila de sincronização
                    ReplicarDados(SyncOrigem.Receber, "inventarios", InvOn.Id, "inserir")
                Else
                    ' Evita erro se Data_Alteracao for NULL no banco de dados
                    Dim DataRemota As DateTime = If(IsDBNull(InvOn.Data_Alteracao), DateTime.MinValue, InvOn.Data_Alteracao)
                    Dim DataLocal As DateTime = If(IsDBNull(InventLocalDict(InvOn.Id).Data_Alteracao), DateTime.MinValue, InventLocalDict(InvOn.Id).Data_Alteracao)

                    ' Se a versão remota for mais recente, marca para atualizar
                    If DataRemota > DataLocal Then
                        ReplicarDados(SyncOrigem.Receber, "inventarios", InvOn.Id, "atualizar")
                    End If
                End If
            Next

        Catch ex As Exception
            ' Registra erro no log para análise
            Console.WriteLine($"Erro ao verificar inventários remotos: {ex.Message}")
        End Try
    End Sub


    Private Sub ChecarIgrejasRemotas()
        Try
            ' Buscar igrejas do banco remoto (Nuvem) e local
            Dim IgrejasOnline As List(Of IgrejasOnDTO) = igrejasOnBLL.BuscarPorAdministracao(VarGlob.SistemaAtivo.Id_Admlc)
            Dim IgrejasLocal As List(Of IgrejasDTO) = igrejasBLL.BuscarTodos()

            ' Se não há igrejas online, não há necessidade de comparar
            If IgrejasOnline Is Nothing OrElse IgrejasOnline.Count = 0 Then Exit Sub

            ' Otimiza a busca local usando um Dicionário para acesso rápido por ID
            Dim IgrejasLocalDict As Dictionary(Of String, IgrejasDTO) = IgrejasLocal.ToDictionary(Function(i) i.Id)

            ' Percorre as igrejas remotas para comparação e sincronização
            For Each IgrejaOn As IgrejasOnDTO In IgrejasOnline
                Dim IgrejaLocal As IgrejasDTO = Nothing
                IgrejasLocalDict.TryGetValue(IgrejaOn.Id, IgrejaLocal)

                If IgrejaLocal Is Nothing Then
                    ' Caso não exista localmente, marca para inserir
                    ReplicarDados(SyncOrigem.Receber, "igrejas", IgrejaOn.Id, "inserir")
                Else
                    ' Evita erro se Data_Alteracao for NULL no banco de dados
                    Dim DataRemota As DateTime = If(IsDBNull(IgrejaOn.Data_Alteracao), DateTime.MinValue, IgrejaOn.Data_Alteracao)
                    Dim DataLocal As DateTime = If(IsDBNull(IgrejaLocal.Data_Alteracao), DateTime.MinValue, IgrejaLocal.Data_Alteracao)

                    ' Se a versão remota for mais recente, marca para atualizar
                    If DataRemota > DataLocal Then
                        ReplicarDados(SyncOrigem.Receber, "igrejas", IgrejaOn.Id, "atualizar")
                    End If
                End If
            Next

        Catch ex As Exception
            ' Registra erro no log para análise
            Console.WriteLine($"Erro ao verificar igrejas remotas: {ex.Message}")
        End Try
    End Sub

    Private Sub ChecarSetoresRemotos()
        Try
            ' Buscar setores do banco remoto (Nuvem) e local
            Dim setoresOnline As List(Of SetoresOnDTO) = setoresOnBLL.BuscarTodos()
            Dim setoresLocal As List(Of SetoresDTO) = setoresBLL.BuscarTodos()

            ' Se não há setores online, não há necessidade de comparar
            If setoresOnline Is Nothing OrElse setoresOnline.Count = 0 Then Exit Sub

            ' Otimiza a busca local usando um Dicionário para acesso rápido por ID
            Dim setoresLocalDict As Dictionary(Of String, SetoresDTO) = setoresLocal.ToDictionary(Function(i) i.Cod_Setor)

            ' Percorre as setores remotas para comparação e sincronização
            For Each SetorOn As SetoresOnDTO In setoresOnline
                Dim SetorLocal As SetoresDTO = Nothing
                setoresLocalDict.TryGetValue(SetorOn.Cod_Setor, SetorLocal)

                If SetorLocal Is Nothing Then
                    ' Caso não exista localmente, marca para inserir
                    ReplicarDados(SyncOrigem.Receber, "setores", SetorOn.Cod_Setor, "inserir")
                Else
                    ' Evita erro se Data_Alteracao for NULL no banco de dados
                    Dim DataRemota As DateTime = If(IsDBNull(SetorOn.Data_Alteracao), DateTime.MinValue, SetorOn.Data_Alteracao)
                    Dim DataLocal As DateTime = If(IsDBNull(SetorLocal.Data_Alteracao), DateTime.MinValue, SetorLocal.Data_Alteracao)

                    ' Se a versão remota for mais recente, marca para atualizar
                    If DataRemota > DataLocal Then
                        ReplicarDados(SyncOrigem.Receber, "setores", SetorOn.Cod_Setor, "atualizar")
                    End If
                End If
            Next

        Catch ex As Exception
            ' Registra erro no log para análise
            Console.WriteLine($"Erro ao verificar setores remotas: {ex.Message}")
        End Try
    End Sub

End Module
