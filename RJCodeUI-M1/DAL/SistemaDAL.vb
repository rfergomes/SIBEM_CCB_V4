Public Class SistemaDAL
    Inherits GenericDAL(Of SistemaDTO)

    Private Tabela = "sistema"
    Private TabelaView = "lista_sistema"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(sistema As SistemaDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("id_admlc", sistema.Id_Admlc)
        columns.Add("setor_definido", sistema.Setor_Definido)
        columns.Add("token", sistema.Token)
        columns.Add("token_validado", sistema.Token_Validado)
        columns.Add("ativo", sistema.Ativo)
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(sistemaId As String) As Integer
        Return Excluir(Tabela, $"AND id_sistema = {sistemaId}")
    End Function

    Public Overrides Function Update(sistema As SistemaDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("id_sistema", sistema.Id)
        columns.Add("id_admlc", sistema.Id_Admlc)
        columns.Add("setor_definido", sistema.Setor_Definido)
        columns.Add("token", sistema.Token)
        columns.Add("token_validado", sistema.Token_Validado)
        columns.Add("ativo", sistema.Ativo)
        Return Atualizar(Tabela, columns, $"AND id_sistema = '{sistema.Id}'")
    End Function

    Public Overrides Function GetByIdDt(sistemaId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, $"AND id_sistema = {sistemaId}")
    End Function

    Public Overrides Function GetByIdList(sistemaId As String) As List(Of SistemaDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, $"AND id_sistema = {sistemaId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of SistemaDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As SistemaDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As SistemaDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SistemaDTO) = BuscarLista(Tabela, columns, $"AND descricao = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Id_Admlc = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As SistemaDTO
        Dim sistema As New SistemaDTO()

        ' Verifica se o campo "id_sistema" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_sistema")) Then
            sistema.Id = reader.GetInt32(reader.GetOrdinal("id_sistema"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If ColumnExists(reader, "id_admlc") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_admlc")) = GetType(Int64) Then
                sistema.Id_Admlc = reader.GetInt64(reader.GetOrdinal("id_admlc"))
            End If
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
            sistema.Adm_Local = reader.GetString(reader.GetOrdinal("adm_local"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("razao_social")) Then
            sistema.Razao_Social = reader.GetString(reader.GetOrdinal("razao_social"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cnpj")) Then
            sistema.CNPJ = reader.GetString(reader.GetOrdinal("cnpj"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cidade")) Then
            sistema.Cidade = reader.GetString(reader.GetOrdinal("cidade"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("uf")) Then
            sistema.UF = reader.GetString(reader.GetOrdinal("uf"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_status")) Then
            sistema.Id_Status = reader.GetInt32(reader.GetOrdinal("id_status"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("status")) Then
            sistema.Status = reader.GetString(reader.GetOrdinal("status"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admrg")) Then
            sistema.Id_Admrg = reader.GetInt32(reader.GetOrdinal("id_admrg"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("adm_regional")) Then
            sistema.Adm_Regional = reader.GetString(reader.GetOrdinal("adm_regional"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("setor_definido")) Then
            sistema.Setor_Definido = reader.GetString(reader.GetOrdinal("setor_definido"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("token")) Then
            sistema.Token = reader.GetString(reader.GetOrdinal("token"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("token_validado")) Then
            sistema.Token_Validado = reader.GetInt32(reader.GetOrdinal("token_validado"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("ativo")) Then
            sistema.Ativo = reader.GetBoolean(reader.GetOrdinal("ativo"))
        End If

        Return sistema
    End Function

    ' Função auxiliar para verificar se a coluna existe no DataReader
    Private Function ColumnExists(reader As Common.DbDataReader, columnName As String) As Boolean
        Try
            Dim ordinal As Integer = reader.GetOrdinal(columnName)
            Return True
        Catch ex As IndexOutOfRangeException
            ' Coluna não existe
            Return False
        End Try
    End Function

End Class
