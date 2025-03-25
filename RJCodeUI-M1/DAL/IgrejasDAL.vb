'Última Atualização: 04/10/2024
'Data: 04/10/2024
'Autor: Rodrigo Fernando Gomes Lima


Public Class IgrejasDAL
    Inherits GenericDAL(Of IgrejasDTO)

    Private Tabela = "igrejas"
    Private TabelaViews = "lista_igrejas"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(igrejas As IgrejasDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_igreja", igrejas.Id},
            {"igreja", igrejas.Igreja},
            {"cod_siga", igrejas.Cod_Siga},
            {"razao_social", igrejas.Razao_Social},
            {"cnpj", igrejas.CNPJ},
            {"logradouro", igrejas.Logradouro},
            {"numero", igrejas.Numero},
            {"bairro", igrejas.Bairro},
            {"cidade", igrejas.Cidade},
            {"uf", igrejas.UF},
            {"id_tipo", igrejas.Id_Tipo},
            {"id_status", igrejas.Id_Status},
            {"cod_setor", igrejas.Cod_Setor},
            {"id_admlc", igrejas.Id_AdmLc},
            {"observacao", igrejas.observacao},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(igrejasId As String)
        Excluir(Tabela, $"AND id_igreja = {igrejasId} AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Sub

    Public Overrides Sub Update(igrejas As IgrejasDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_igreja", igrejas.Id},
            {"igreja", igrejas.Igreja},
            {"cod_siga", igrejas.Cod_Siga},
            {"razao_social", igrejas.Razao_Social},
            {"cnpj", igrejas.CNPJ},
            {"logradouro", igrejas.Logradouro},
            {"numero", igrejas.Numero},
            {"bairro", igrejas.Bairro},
            {"cidade", igrejas.Cidade},
            {"uf", igrejas.UF},
            {"id_tipo", igrejas.Id_Tipo},
            {"id_status", igrejas.Id_Status},
            {"cod_setor", igrejas.Cod_Setor},
            {"id_admlc", igrejas.Id_AdmLc},
            {"observacao", igrejas.observacao},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Atualizar(Tabela, columns, $"AND id_igreja = '{igrejas.Id}' AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Sub

    Public Overrides Function GetById(igrejasId As String) As IgrejasDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of IgrejasDTO) = BuscarLista(TabelaViews, columns, $"AND id_igreja = '{igrejasId}' AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
        Return lista.FirstOrDefault(Function(t) t.Id = igrejasId)
    End Function

    Public Overrides Function GetByIdDt(igrejasId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"AND id_igreja = {igrejasId} AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetByIdList(igrejasId As String) As List(Of IgrejasDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"AND id_igreja = {igrejasId} AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of IgrejasDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"{condicao}")
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetByPart(part As String) As IgrejasDTO
        Throw New NotImplementedException()
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As IgrejasDTO
        Dim igrejas As New IgrejasDTO()

        ' Verifica se o campo "id_igreja" está presente e não é nulo
        If ColumnExists(reader, "id_igreja") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_igreja")) Then
            igrejas.Id = reader.GetString(reader.GetOrdinal("id_igreja"))
        End If

        ' Verifica se o campo "igreja" está presente e não é nulo
        If ColumnExists(reader, "igreja") AndAlso Not reader.IsDBNull(reader.GetOrdinal("igreja")) Then
            igrejas.Igreja = reader.GetString(reader.GetOrdinal("igreja"))
        End If

        If ColumnExists(reader, "cod_siga") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cod_siga")) Then
            igrejas.Cod_Siga = reader.GetString(reader.GetOrdinal("cod_siga"))
        End If

        If ColumnExists(reader, "razao_social") AndAlso Not reader.IsDBNull(reader.GetOrdinal("razao_social")) Then
            igrejas.Razao_Social = reader.GetString(reader.GetOrdinal("razao_social"))
        End If

        If ColumnExists(reader, "logradouro") AndAlso Not reader.IsDBNull(reader.GetOrdinal("logradouro")) Then
            igrejas.Logradouro = reader.GetString(reader.GetOrdinal("logradouro"))
        End If

        ' Verifica o tipo da coluna antes de tentar converter para inteiro
        If ColumnExists(reader, "numero") AndAlso Not reader.IsDBNull(reader.GetOrdinal("numero")) Then
            Dim numeroStr = reader.GetString(reader.GetOrdinal("numero"))
            If IsNumeric(numeroStr) Then
                igrejas.Numero = numeroStr ' Pode ser convertido diretamente, caso seja numérico
            Else
                igrejas.Numero = "0" ' Ou trate o erro, se não for numérico
            End If
        End If

        If ColumnExists(reader, "bairro") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bairro")) Then
            igrejas.Bairro = reader.GetString(reader.GetOrdinal("bairro"))
        End If

        If ColumnExists(reader, "cidade") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cidade")) Then
            igrejas.Cidade = reader.GetString(reader.GetOrdinal("cidade"))
        End If

        If ColumnExists(reader, "uf") AndAlso Not reader.IsDBNull(reader.GetOrdinal("uf")) Then
            igrejas.UF = reader.GetString(reader.GetOrdinal("uf"))
        End If

        If ColumnExists(reader, "cnpj") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cnpj")) Then
            igrejas.CNPJ = reader.GetString(reader.GetOrdinal("cnpj"))
        End If

        ' Verifica se o campo "tipo" é realmente um inteiro antes de converter
        If ColumnExists(reader, "id_tipo") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_tipo")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_tipo")) = GetType(Int64) Then
                igrejas.Id_Tipo = reader.GetInt64(reader.GetOrdinal("id_tipo"))
            End If
        End If

        If ColumnExists(reader, "tipo") AndAlso Not reader.IsDBNull(reader.GetOrdinal("tipo")) Then
            igrejas.Tipo = reader.GetString(reader.GetOrdinal("tipo"))
        End If

        ' Verifica se o campo "id_status" é realmente um inteiro antes de converter
        If ColumnExists(reader, "id_status") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_status")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_status")) = GetType(Int64) Then
                igrejas.Id_Status = reader.GetInt64(reader.GetOrdinal("id_status"))
            End If
        End If

        If ColumnExists(reader, "status") AndAlso Not reader.IsDBNull(reader.GetOrdinal("status")) Then
            igrejas.Status = reader.GetString(reader.GetOrdinal("status"))
        End If

        ' Verifica se o campo "id_setor" não é nulo e é do tipo string
        If ColumnExists(reader, "cod_setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cod_setor")) Then
            igrejas.Cod_Setor = reader.GetString(reader.GetOrdinal("cod_setor"))
        End If

        If ColumnExists(reader, "setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("setor")) Then
            igrejas.Setor = reader.GetString(reader.GetOrdinal("setor"))
        End If

        If ColumnExists(reader, "id_admlc") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            igrejas.Id_AdmLc = reader.GetInt32(reader.GetOrdinal("id_admlc"))
        End If

        If ColumnExists(reader, "adm_local") AndAlso Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
            igrejas.Adm_Local = reader.GetString(reader.GetOrdinal("adm_local"))
        End If

        If ColumnExists(reader, "observacao") AndAlso Not reader.IsDBNull(reader.GetOrdinal("observacao")) Then
            igrejas.observacao = reader.GetString(reader.GetOrdinal("observacao"))
        End If

        If ColumnExists(reader, "data_alter") AndAlso Not reader.IsDBNull(reader.GetOrdinal("data_alter")) Then
            igrejas.Data_Alteracao = reader.GetDateTime(reader.GetOrdinal("data_alter"))
        End If

        Return igrejas
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
