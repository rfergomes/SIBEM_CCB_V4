Imports Org.BouncyCastle.X509

Public Class SetoresDAL
    Inherits GenericDAL(Of SetoresDTO)

    Private ReadOnly Tabela = "setores"
    Private ReadOnly TabelaViews = "lista_setores"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(setores As SetoresDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"cod_setor", setores.Cod_Setor},
            {"descricao", setores.Descricao},
            {"id_admlc", setores.Id_Admlc},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(setoresId As String) As Integer
        Return Excluir(Tabela, $"cod_setor = {setoresId}  AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function Update(setores As SetoresDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"cod_setor", setores.Cod_Setor},
            {"descricao", setores.Descricao},
            {"id_admlc", setores.Id_Admlc},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Atualizar(Tabela, columns, $"AND cod_setor = {setores.Cod_Setor} AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetByIdDt(setoresId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"AND cod_setor = {setoresId}  AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetByIdList(setoresId As String) As List(Of SetoresDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"AND cod_setor = {setoresId}  AND id_admlc='{VarGlob.SistemaAtivo.Id_Admlc}' ORDER BY cod_setor")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of SetoresDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"{condicao} AND id_admlc = '{VarGlob.SistemaAtivo.Id_Admlc}' ORDER BY cod_setor")
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"{condicao} AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetById(idSetor As String) As SetoresDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SetoresDTO) = BuscarLista(TabelaViews, columns, $"AND cod_setor = '{idSetor}'  AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
        Return lista.FirstOrDefault(Function(t) t.Cod_Setor = idSetor)
    End Function

    Public Overrides Function GetByPart(part As String) As SetoresDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SetoresDTO) = BuscarLista(TabelaViews, columns, $"AND descricao = '{part}'  AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc} LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As SetoresDTO
        Dim setores As New SetoresDTO()

        ' Verifica se o campo "id_setor" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_setor")) Then
            setores.Id = reader.GetInt32(reader.GetOrdinal("id_setor"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cod_setor")) Then
            setores.Cod_Setor = reader.GetString(reader.GetOrdinal("cod_setor"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            setores.Descricao = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_admlc")) = GetType(Int32) Then
                setores.Id_Admlc = reader.GetInt32(reader.GetOrdinal("id_admlc"))
            Else
                setores.Id_Admlc = reader.GetInt64(reader.GetOrdinal("id_admlc"))
            End If
        End If

        If ColumnExists(reader, "adm_local") AndAlso Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
            If Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
                setores.Adm_Local = reader.GetString(reader.GetOrdinal("adm_local"))
            End If
        End If

        If ColumnExists(reader, "data_alter") AndAlso Not reader.IsDBNull(reader.GetOrdinal("data_alter")) Then
            setores.Data_Alteracao = reader.GetDateTime(reader.GetOrdinal("data_alter"))
        End If

        Return setores
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
