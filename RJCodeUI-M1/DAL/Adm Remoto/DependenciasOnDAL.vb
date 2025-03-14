Public Class DependenciasOnDAL
    Inherits GenericDAL(Of DependenciasOnDTO)

    Private Tabela = "dependencias"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(dependencias As DependenciasOnDTO) As Long
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("descricao", dependencias.Descricao)
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(dependenciasId As String)
        Excluir(Tabela, $"id_dependencia = {dependenciasId}")
    End Sub

    Public Overrides Sub Update(dependencias As DependenciasOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("descricao", dependencias.Descricao)
        Atualizar(Tabela, columns, $"AND id_dependencia = '{dependencias.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(dependenciasId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"id_dependencia = {dependenciasId}")
    End Function

    Public Overrides Function GetByIdList(dependenciasId As Integer) As List(Of DependenciasOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"id_dependencia = {dependenciasId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of DependenciasOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt() As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As DependenciasOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of DependenciasOnDTO) = BuscarLista(Tabela, columns, $"AND id_dependencia = '{id}'")
        Return lista.FirstOrDefault(Function(t) t.Id = id)
    End Function

    Public Overrides Function GetByPart(part As String) As DependenciasOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of DependenciasOnDTO) = BuscarLista(Tabela, columns, $"descricao LIKE '%{part}%' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As DependenciasOnDTO
        Dim dependencias As New DependenciasOnDTO()

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
