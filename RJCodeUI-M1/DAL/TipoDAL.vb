Public Class TipoDAL
    Inherits GenericDAL(Of TipoDTO)

    Private Tabela = "tipo"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(tipo As TipoDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("descricao", tipo.Descricao)
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(tipoId As String) As Integer
        Return Excluir(Tabela, $"id_tipo = {tipoId}")
    End Function

    Public Overrides Function Update(tipo As TipoDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("descricao", tipo.Descricao)
        Return Atualizar(Tabela, columns, $"id_tipo = '{tipo.Id}'")
    End Function

    Public Overrides Function GetByIdDt(tipoId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"AND id_tipo = {tipoId}")
    End Function

    Public Overrides Function GetByIdList(tipoId As String) As List(Of TipoDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"AND id_tipo = {tipoId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of TipoDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As TipoDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As TipoDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of TipoDTO) = BuscarLista(Tabela, columns, $"AND descricao = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As TipoDTO
        Dim tipo As New TipoDTO()

        ' Verifica se o campo "id_tipo" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_tipo")) Then
            tipo.Id = reader.GetInt32(reader.GetOrdinal("id_tipo"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            tipo.Descricao = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        Return tipo
    End Function

End Class
