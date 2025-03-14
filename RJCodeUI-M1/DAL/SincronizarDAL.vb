Public Class SincronizarDAL
    Inherits GenericDAL(Of SincronizarDTO)

    Private Tabela = "sincronizar"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(sincronizar As SincronizarDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_tabela", sincronizar.Id_Tabela},
            {"tabela", sincronizar.Tabela},
            {"acao", sincronizar.Acao},
            {"status", sincronizar.Status},
            {"tipo_operacao", sincronizar.Tipo_Operacao},
            {"data_atualizacao", sincronizar.Data_Atualizacao},
            {"id_admlc", sincronizar.Id_Admlc}
        }

        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(sincronizarId As String)
        Excluir(Tabela, $"AND id_sincronizar = {sincronizarId}")
    End Sub

    Public Overrides Sub Update(sincronizar As SincronizarDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_sincronizar", sincronizar.Id},
            {"id_tabela", sincronizar.Id_Tabela},
            {"tabela", sincronizar.Tabela},
            {"acao", sincronizar.Acao},
            {"status", sincronizar.Status},
            {"tipo_operacao", sincronizar.Tipo_Operacao},
            {"data_atualizacao", sincronizar.Data_Atualizacao},
            {"id_admlc", sincronizar.Id_Admlc}
        }
        Atualizar(Tabela, columns, $"AND id_sincronizar = '{sincronizar.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(sincronizarId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"AND id_sincronizar = {sincronizarId}")
    End Function

    Public Overrides Function GetByIdList(sincronizarId As Integer) As List(Of SincronizarDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"AND id_sincronizar = {sincronizarId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of SincronizarDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt() As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As SincronizarDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SincronizarDTO) = BuscarLista(Tabela, columns, $"AND  id_tabela = '{id}'  AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
        Return lista.FirstOrDefault(Function(t) t.Id_Tabela = id)
    End Function

    Public Overrides Function GetByPart(Id_Tabela As String) As SincronizarDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of SincronizarDTO) = BuscarLista(Tabela, columns, $"AND id_tabela = '{Id_Tabela}' LIMIT 1")
        Return lista.FirstOrDefault()
    End Function

    Public Function GetResumoSincronizar(Optional Condicao As String = "") As List(Of List(Of String))
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of List(Of String)) = BuscarListaStrings("lista_sincronizar_dados", columns, Condicao)

        ' Verifica se a lista contém algum item
        If lista IsNot Nothing AndAlso lista.Any() Then
            ' Retorna o primeiro item, que é uma List(Of String)
            Return lista
        End If

        ' Caso a lista esteja vazia, retorna uma lista vazia
        Return New List(Of List(Of String))
    End Function


    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As SincronizarDTO
        Dim sincronizar As New SincronizarDTO()

        ' Verifica se o campo "id_sincronizar" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_sincronizar")) Then
            sincronizar.Id = reader.GetInt32(reader.GetOrdinal("id_sincronizar"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("tabela")) Then
            sincronizar.Tabela = reader.GetString(reader.GetOrdinal("tabela"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_tabela")) Then
            sincronizar.Id_Tabela = reader.GetString(reader.GetOrdinal("id_tabela"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("acao")) Then
            sincronizar.Acao = reader.GetString(reader.GetOrdinal("acao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("status")) Then
            sincronizar.Status = reader.GetInt32(reader.GetOrdinal("status"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("tipo_operacao")) Then
            sincronizar.Tipo_Operacao = reader.GetString(reader.GetOrdinal("tipo_operacao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            sincronizar.Id_Admlc = reader.GetString(reader.GetOrdinal("id_admlc"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("data_atualizacao")) Then
            sincronizar.Data_Atualizacao = reader.GetString(reader.GetOrdinal("data_atualizacao"))
        End If

        Return sincronizar
    End Function

End Class
