Public Class AdmlcDAL
    Inherits GenericDAL(Of AdmlcDTO)

    Private Tabela = "admlc"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(admlc As AdmlcDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_admlc", admlc.Id},
            {"adm_Local", admlc.Adm_Local},
            {"razao_social", admlc.Razao_Social},
            {"cnpj", admlc.CNPJ},
            {"cidade", admlc.Cidade},
            {"uf", admlc.UF},
            {"id_status", admlc.Id_Status},
            {"id_admrg", admlc.Id_Admrg}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(admlcId As String) As Integer
        Return Excluir(Tabela, $"id_admlc = {admlcId}")
    End Function

    Public Overrides Function Update(admlc As AdmlcDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"adm_local", admlc.Adm_Local},
            {"razao_social", admlc.Razao_Social},
            {"cnpj", admlc.CNPJ},
            {"cidade", admlc.Cidade},
            {"uf", admlc.UF},
            {"id_status", admlc.Id_Status},
            {"id_admrg", admlc.Id_Admrg}
        }
        Return Atualizar(Tabela, columns, $"AND id_admlc = '{admlc.Id}'")
    End Function

    Public Overrides Function GetByIdDt(admlcId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"AND id_admlc = {admlcId}")
    End Function

    Public Overrides Function GetByIdList(admlcId As String) As List(Of AdmlcDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"AND id_admlc = {admlcId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of AdmlcDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As AdmlcDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of AdmlcDTO) = BuscarLista(Tabela, columns, $"AND id_admlc = '{id}'")
        Return lista.FirstOrDefault(Function(t) t.Id = id)
    End Function

    Public Overrides Function GetByPart(part As String) As AdmlcDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of AdmlcDTO) = BuscarLista(Tabela, columns, $" And adm_local = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Adm_Local = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As AdmlcDTO
        Dim admlc As New AdmlcDTO()

        ' Verifica se o campo "id_admlc" é um inteiro e está presente
        If ColumnExists(reader, "id_admlc") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_admlc")) = GetType(Int32) Then
                admlc.Id = reader.GetInt32(reader.GetOrdinal("id_admlc"))
            Else
                admlc.Id = reader.GetInt64(reader.GetOrdinal("id_admlc"))
            End If
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
            admlc.Adm_Local = reader.GetString(reader.GetOrdinal("adm_local"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("razao_social")) Then
            admlc.Razao_Social = reader.GetString(reader.GetOrdinal("razao_social"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cnpj")) Then
            admlc.CNPJ = reader.GetString(reader.GetOrdinal("cnpj"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cidade")) Then
            admlc.Cidade = reader.GetString(reader.GetOrdinal("cidade"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("uf")) Then
            admlc.UF = reader.GetString(reader.GetOrdinal("uf"))
        End If

        If ColumnExists(reader, "id_status") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_status")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_status")) = GetType(Int32) Then
                admlc.Id_Status = reader.GetInt32(reader.GetOrdinal("id_status"))
            Else
                admlc.Id_Status = reader.GetInt64(reader.GetOrdinal("id_status"))
            End If
        End If

        If ColumnExists(reader, "id_admrg") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admrg")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_admrg")) = GetType(Int32) Then
                admlc.Id_Admrg = reader.GetInt32(reader.GetOrdinal("id_admrg"))
            Else
                admlc.Id_Admrg = reader.GetInt64(reader.GetOrdinal("id_admrg"))
            End If
        End If

        Return admlc
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
