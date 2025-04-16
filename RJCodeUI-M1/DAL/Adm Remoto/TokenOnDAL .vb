Public Class TokenOnDAL
    Inherits GenericDAL(Of TokenOnDTO)

    Private Tabela = "token"
    Private TabelaView = "lista_token"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(token As TokenOnDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("token", token.Token)
        columns.Add("id_admlc", token.Id_Admlc)
        columns.Add("id_usuario", token.Id_Usuario)
        columns.Add("dispositivo", token.Dispositivo)
        columns.Add("ativo", token.Ativo)
        columns.Add("data_cad", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(tokenId As String) As Integer
        Return Excluir(Tabela, $"AND id_token = {tokenId}")
    End Function

    Public Overrides Function Update(token As TokenOnDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("id_token", token.Id)
        columns.Add("token", token.Token)
        columns.Add("id_admlc", token.Id_Admlc)
        columns.Add("id_usuario", token.Id_Usuario)
        columns.Add("dispositivo", token.Dispositivo)
        columns.Add("ativo", token.Ativo)
        Return Atualizar(Tabela, columns, $"AND id_token = '{token.Id}'")
    End Function

    Public Overrides Function GetByIdDt(tokenId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, $"AND id_token = {tokenId}")
    End Function

    Public Overrides Function GetByIdList(tokenId As String) As List(Of TokenOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, $"AND id_token = {tokenId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of TokenOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As TokenOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of TokenOnDTO) = BuscarLista(TabelaView, columns, $"AND id_token = '{id}'")
        Return lista.FirstOrDefault(Function(t) t.Id = id)
    End Function

    Public Overrides Function GetByPart(part As String) As TokenOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of TokenOnDTO) = BuscarLista(Tabela, columns, $"AND token = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Id_Admlc = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As TokenOnDTO
        Dim token As New TokenOnDTO()

        ' Verifica se o campo "id_token" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_token")) Then
            token.Id = reader.GetInt32(reader.GetOrdinal("id_token"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("token")) Then
            token.Token = reader.GetString(reader.GetOrdinal("token"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            token.Id_Admlc = reader.GetInt32(reader.GetOrdinal("id_admlc"))
        End If

        If ColumnExists(reader, "adm_local") AndAlso Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
            If reader.GetFieldType(reader.GetOrdinal("adm_local")) = GetType(String) Then
                token.Adm_Local = reader.GetString(reader.GetOrdinal("adm_local"))
            End If
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_usuario")) Then
            token.Id_Usuario = reader.GetInt32(reader.GetOrdinal("id_usuario"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("dispositivo")) Then
            token.Dispositivo = reader.GetString(reader.GetOrdinal("dispositivo"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("ativo")) Then
            token.Ativo = reader.GetInt32(reader.GetOrdinal("ativo"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("data_cad")) Then
            token.Data_Cadastro = reader.GetDateTime(reader.GetOrdinal("data_cad"))
        End If

        Return token
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
