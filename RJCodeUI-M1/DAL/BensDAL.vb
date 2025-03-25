Public Class BensDAL
    Inherits GenericDAL(Of BensDTO)

    Private Tabela = "bens"
    Private TabelaViews = "lista_bens"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(bens As BensDTO) As Long
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("id_bem", bens.Id)
        columns.Add("descricao", bens.Descricao)
        columns.Add("id_igreja", bens.Id_igreja)
        columns.Add("id_dependencia", bens.Id_Dependencia)
        columns.Add("id_status", bens.Id_Status)
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(bensId As String)
        Excluir(Tabela, $"id_bem = {bensId}")
    End Sub

    Public Overrides Sub Update(bens As BensDTO)
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("id_bem", bens.Id)
        columns.Add("descricao", bens.Descricao)
        columns.Add("id_igreja", bens.Id_igreja)
        columns.Add("id_dependencia", bens.Id_Dependencia)
        columns.Add("id_status", bens.Id_Status)
        Atualizar(Tabela, columns, $"AND id_bem = '{bens.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(bensId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"ANDid_bem = {bensId}")
    End Function

    Public Overrides Function GetByIdList(bensId As String) As List(Of BensDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"AND id_bem = {bensId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of BensDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As BensDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of BensDTO) = BuscarLista(TabelaViews, columns, $"AND id_bem = '{id}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Id = id)
    End Function

    Public Overrides Function GetByPart(part As String) As BensDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of BensDTO) = BuscarLista(TabelaViews, columns, $"AND descricao = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Public Function GetCount(Optional condicao As String = "") As Integer
        Return BuscarContagem(TabelaViews, condicao)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As BensDTO
        Dim bens As New BensDTO()

        ' Verifica se o campo "id_bem" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_bem")) Then
            bens.Id = reader.GetString(reader.GetOrdinal("id_bem"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            bens.Descricao = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_igreja")) Then
            bens.Id_igreja = reader.GetString(reader.GetOrdinal("id_igreja"))
        End If

        If ColumnExists(reader, "igreja") AndAlso Not reader.IsDBNull(reader.GetOrdinal("igreja")) Then
            If reader.GetFieldType(reader.GetOrdinal("igreja")) = GetType(String) Then
                bens.Igreja = reader.GetString(reader.GetOrdinal("igreja"))
            End If
        End If

        If ColumnExists(reader, "id_dependencia") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_dependencia")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_dependencia")) = GetType(Int64) Then
                bens.Id_Dependencia = reader.GetInt64(reader.GetOrdinal("id_dependencia"))
            End If
        End If

        If ColumnExists(reader, "dependencia") AndAlso Not reader.IsDBNull(reader.GetOrdinal("dependencia")) Then
            If reader.GetFieldType(reader.GetOrdinal("dependencia")) = GetType(String) Then
                bens.Dependencia = reader.GetString(reader.GetOrdinal("dependencia"))
            End If
        End If

        If ColumnExists(reader, "id_setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_setor")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_setor")) = GetType(String) Then
                bens.Dependencia = reader.GetString(reader.GetOrdinal("id_setor"))
            End If
        End If

        If ColumnExists(reader, "setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("setor")) Then
            If reader.GetFieldType(reader.GetOrdinal("setor")) = GetType(String) Then
                bens.Id_Setor = reader.GetString(reader.GetOrdinal("setor"))
            End If
        End If

        If ColumnExists(reader, "id_status") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_status")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_status")) = GetType(Int64) Then
                bens.Id_Status = reader.GetInt64(reader.GetOrdinal("id_status"))
            End If
        End If

        If ColumnExists(reader, "status") AndAlso Not reader.IsDBNull(reader.GetOrdinal("status")) Then
            If reader.GetFieldType(reader.GetOrdinal("status")) = GetType(String) Then
                bens.Status = reader.GetString(reader.GetOrdinal("status"))
            End If
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            bens.Id_Admlc = reader.GetInt32(reader.GetOrdinal("id_admlc"))
        End If

        Return bens
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
