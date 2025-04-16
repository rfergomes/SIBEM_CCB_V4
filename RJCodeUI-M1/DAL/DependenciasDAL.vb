Public Class DependenciasDAL
    Inherits GenericDAL(Of DependenciasDTO)

    Private Tabela = "dependencias"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(dependencias As DependenciasDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("id_dependencia", dependencias.Id)
        columns.Add("descricao", dependencias.Descricao)
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(dependenciasId As String) As Integer
        Return Excluir(Tabela, $"id_dependencia = {dependenciasId}")
    End Function

    Public Overrides Function Update(dependencias As DependenciasDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"descricao", dependencias.Descricao}
        }
        Return Atualizar(Tabela, columns, $"AND id_dependencia = '{dependencias.Id}'")
    End Function

    Public Overrides Function GetByIdDt(dependenciasId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"id_dependencia = {dependenciasId}")
    End Function

    Public Overrides Function GetByIdList(dependenciasId As String) As List(Of DependenciasDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"id_dependencia = {dependenciasId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of DependenciasDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As DependenciasDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of DependenciasDTO) = BuscarLista(Tabela, columns, $"AND id_dependencia = '{id}'")
        Return lista.FirstOrDefault(Function(t) t.Id = id)
    End Function

    Public Overrides Function GetByPart(part As String) As DependenciasDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of DependenciasDTO) = BuscarLista(Tabela, columns, $"AND descricao LIKE '%{part}%' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As DependenciasDTO
        Dim dependencias As New DependenciasDTO()

        ' Verifica se o campo "id_dependencia" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_dependencia")) Then
            dependencias.Id = reader.GetInt32(reader.GetOrdinal("id_dependencia"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            dependencias.Descricao = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        Return dependencias
    End Function


End Class
