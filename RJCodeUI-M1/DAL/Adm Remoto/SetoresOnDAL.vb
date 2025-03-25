Public Class SetoresOnDAL
    Inherits GenericDAL(Of SetoresOnDTO)

    Private ReadOnly Tabela = "setores"
    Private ReadOnly TabelaViews = "setores"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(setores As SetoresOnDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_setor", setores.Id},
            {"cod_setor", setores.Cod_Setor},
            {"descricao", setores.Descricao},
            {"id_admlc", setores.Id_Admlc},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(setoresId As String)
        Excluir(Tabela, $"AND cod_setor = {setoresId} AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Sub

    Public Overrides Sub Update(setores As SetoresOnDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"cod_setor", setores.Cod_Setor},
            {"descricao", setores.Descricao},
            {"id_admlc", setores.Id_Admlc},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Atualizar(Tabela, columns, $"AND cod_setor = '{setores.Cod_Setor}' AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Sub

    Public Overrides Function GetByIdDt(setoresId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"AND cod_setor = {setoresId} AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetByIdList(setoresId As String) As List(Of SetoresOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"AND cod_setor = {setoresId} AND id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of SetoresOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetById(idSetor As String) As SetoresOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SetoresOnDTO) = BuscarLista(TabelaViews, columns, $"AND cod_setor = '{idSetor}'  AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
        Return lista.FirstOrDefault(Function(t) t.Cod_Setor = idSetor)
    End Function

    Public Overrides Function GetByPart(part As String) As SetoresOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SetoresOnDTO) = BuscarLista(TabelaViews, columns, $"AND descricao = '{part}'  AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc} LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Descricao = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As SetoresOnDTO
        Dim setores As New SetoresOnDTO()

        '' Verifica se o campo "id_setor" é um inteiro e está presente
        'If Not reader.IsDBNull(reader.GetOrdinal("id_setor")) Then
        '    setores.Id = reader.GetString(reader.GetOrdinal("id_setor"))
        'End If

        If ColumnExists(reader, "id_setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_setor")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_setor")) = GetType(Integer) Then
                setores.Id = reader.GetInt32(reader.GetOrdinal("id_setor"))
            End If
        End If

        If ColumnExists(reader, "cod_setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cod_setor")) Then
            If reader.GetFieldType(reader.GetOrdinal("cod_setor")) = GetType(String) Then
                setores.Cod_Setor = reader.GetString(reader.GetOrdinal("cod_setor"))
            End If
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            setores.Descricao = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            setores.Id_Admlc = reader.GetInt32(reader.GetOrdinal("id_admlc"))
        End If

        If ColumnExists(reader, "data_alter") AndAlso Not reader.IsDBNull(reader.GetOrdinal("data_alter")) Then
            If reader.GetFieldType(reader.GetOrdinal("data_alter")) = GetType(Date) Then
                setores.Data_Alteracao = reader.GetDateTime(reader.GetOrdinal("data_alter"))
            End If
        End If

        Return setores
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
