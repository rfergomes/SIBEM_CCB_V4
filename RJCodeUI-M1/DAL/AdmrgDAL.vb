Public Class AdmrgDAL
    Inherits GenericDAL(Of AdmrgDTO)

    Private Tabela = "admrg"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(admrg As AdmrgDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_admrg", admrg.Id},
            {"adm_regional", admrg.Adm_Regional},
            {"uf", admrg.UF}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(admrgId As String)
        Excluir(Tabela, $"id_admrg = {admrgId}")
    End Sub

    Public Overrides Sub Update(admrg As AdmrgDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"adm_regional", admrg.Adm_Regional},
            {"uf", admrg.UF}
        }
        Atualizar(Tabela, columns, $"AND id_admrg = '{admrg.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(admrgId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"AND id_admrg = {admrgId}")
    End Function

    Public Overrides Function GetByIdList(admrgId As String) As List(Of AdmrgDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"AND id_admrg = {admrgId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of AdmrgDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(Id As String) As AdmrgDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of AdmrgDTO) = BuscarLista(Tabela, columns, $"AND id_admrg = '{Id}'")
        Return lista.FirstOrDefault(Function(t) t.Id = Id)
    End Function

    Public Overrides Function GetByPart(part As String) As AdmrgDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of AdmrgDTO) = BuscarLista(Tabela, columns, $"AND adm_local = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Adm_Regional = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As AdmrgDTO
        Dim admrg As New AdmrgDTO()

        ' Verifica se o campo "id_admrg" é um inteiro e está presente
        If ColumnExists(reader, "id_admrg") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admrg")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_admrg")) = GetType(Int32) Then
                admrg.Id = reader.GetInt32(reader.GetOrdinal("id_admrg"))
            Else
                admrg.Id = reader.GetInt64(reader.GetOrdinal("id_admrg"))
            End If
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("adm_regional")) Then
            admrg.Adm_Regional = reader.GetString(reader.GetOrdinal("adm_regional"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("uf")) Then
            admrg.UF = reader.GetString(reader.GetOrdinal("uf"))
        End If

        Return admrg
    End Function

    ' Função auxiliar para verificar se a coluna existe no DataReader
    Private Function ColumnExists(reader As Common.DbDataReader, columnName As String) As Boolean
        Try
            ' Tenta obter o índice da coluna, se não existir, o método GetOrdinal lançará uma exceção
            Dim ordinal As Integer = reader.GetOrdinal(columnName)
            Return True
        Catch ex As IndexOutOfRangeException
            ' Se a exceção for lançada, significa que a coluna não existe
            Return False
        End Try
    End Function

End Class
