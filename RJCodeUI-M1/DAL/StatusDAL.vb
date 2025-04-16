'Última Atualização:    04/10/2024
'Data:                  04/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class StatusDAL
    Inherits GenericDAL(Of StatusDTO)

    Private Tabela = "status"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(status As StatusDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("descricao", status.Descricao)
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(statusId As String) As Integer
        Return Excluir(Tabela, $"id_status = {statusId}")
    End Function

    Public Overrides Function Update(status As StatusDTO) As Integer
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("descricao", status.Descricao)
        Return Atualizar(Tabela, columns, $"id_status = '{status.Id}'")
    End Function

    Public Overrides Function GetByIdDt(statusId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"AND id_status = {statusId}")
    End Function

    Public Overrides Function GetByIdList(statusId As String) As List(Of StatusDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"AND id_status = {statusId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of StatusDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As StatusDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As StatusDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of StatusDTO) = BuscarLista(Tabela, columns, $"AND descricao = '{part}'")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As StatusDTO
        Dim status As New StatusDTO()

        ' Verifica se o campo "id_status" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_status")) Then
            status.Id = reader.GetInt32(reader.GetOrdinal("id_status"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            status.Descricao = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        Return status
    End Function

End Class
