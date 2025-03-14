'Última Atualização: 25/10/2024
'Data: 25/10/2024
'Autor: Rodrigo Fernando Gomes Lima

Public Class InventarioDetalhesDAL
    Inherits GenericDAL(Of InventarioDetalhesDTO)

    Private ReadOnly Tabela = "inventario_detalhes"
    Private ReadOnly TabelaViews = "lista_inventario_detalhes"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(inventario_detalhes As InventarioDetalhesDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_inventario", inventario_detalhes.Id_inventario},
            {"id_bem", inventario_detalhes.Id_Bem},
            {"situacao", inventario_detalhes.Estado},
            {"acao", inventario_detalhes.Acao},
            {"cad_desc", inventario_detalhes.Bem},
            {"cad_dep", inventario_detalhes.Id_dependencia},
            {"observacao", inventario_detalhes.Observacao},
            {"cont", inventario_detalhes.Contagem}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(Id_Bem As String)
        Excluir(Tabela, $"id_bem = '{Id_Bem}' AND id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
    End Sub

    Public Sub Drop(Id_Bem As String)
        Excluir(Tabela, $"id_bem = '{Id_Bem}' AND id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
    End Sub

    Public Overrides Sub Update(inventario_detalhes As InventarioDetalhesDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_detalhe", inventario_detalhes.Id},
            {"id_inventario", inventario_detalhes.Id_inventario},
            {"id_bem", inventario_detalhes.Id_Bem},
            {"situacao", inventario_detalhes.Estado},
            {"acao", inventario_detalhes.Acao},
            {"cad_desc", inventario_detalhes.Bem},
            {"cad_dep", inventario_detalhes.Id_dependencia},
            {"observacao", inventario_detalhes.Observacao},
            {"cont", inventario_detalhes.Contagem}
        }
        Atualizar(Tabela, columns, $"AND id_detalhe = {inventario_detalhes.Id} AND id_bem = '{inventario_detalhes.Id_Bem}'")
    End Sub

    Public Overrides Function GetById(Id_Bem As String) As InventarioDetalhesDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of InventarioDetalhesDTO) = BuscarLista(TabelaViews, columns, $"AND id_bem = '{Id_Bem}' AND id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
        Return lista.FirstOrDefault(Function(t) t.Id_Bem = Id_Bem)
    End Function

    Public Overrides Function GetByIdDt(Id_Bem As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"AND id_bem = {Id_Bem} AND id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
    End Function

    Public Overrides Function GetByIdList(Id_Bem As Integer) As List(Of InventarioDetalhesDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"AND id_bem = {Id_Bem} AND id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of InventarioDetalhesDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"{condicao} ")
    End Function

    Public Function GetAllListByTable(Optional Tabela As String = "", Optional condicao As String = "") As List(Of InventarioDetalhesDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(If(String.IsNullOrEmpty(Tabela), TabelaViews, Tabela), columns, $"{condicao} ")
    End Function

    Public Overrides Function GetAllDt() As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, "")
    End Function

    Public Overrides Function GetByPart(part As String) As InventarioDetalhesDTO
        Throw New NotImplementedException()
    End Function

    Public Function GetGenericList(TabelaView As String, Condition As String) As List(Of List(Of String))
        Dim columns As New Dictionary(Of String, Object) From {
            {"lido", ""},
            {"pendente", ""},
            {"imprimir", ""},
            {"alterar", ""},
            {"novo", ""},
            {"excluir", ""},
            {"transferir", ""},
            {"total", ""}
        }

        Return BuscarListaStrings(TabelaView, columns, Condition)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As InventarioDetalhesDTO
        Dim inventario_detalhes As New InventarioDetalhesDTO()

        ' Verifica se o reader não é nulo
        If reader Is Nothing Then
            Throw New ArgumentNullException(NameOf(reader), "O DataReader não pode ser nulo.")
        End If

        Try
            ' Verifica o campo "id_detalhe"
            If ColumnExists(reader, "id_detalhe") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_detalhe")) Then
                If reader.GetFieldType(reader.GetOrdinal("id_detalhe")) = GetType(Int64) Then
                    inventario_detalhes.Id = reader.GetInt64(reader.GetOrdinal("id_detalhe"))
                End If
            End If

            'If ColumnExists(reader, "id_inventario") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_inventario")) Then
            '    inventario_detalhes.Bem = reader.GetString(reader.GetOrdinal("id_inventario"))
            'End If

            If ColumnExists(reader, "id_inventario") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_inventario")) Then
                If reader.GetFieldType(reader.GetOrdinal("id_inventario")) = GetType(String) Then
                    inventario_detalhes.Id_inventario = reader.GetString(reader.GetOrdinal("id_inventario"))
                End If
            End If

            'If ColumnExists(reader, "id_bem") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_bem")) Then
            '    inventario_detalhes.Id_Bem = reader.GetString(reader.GetOrdinal("id_bem"))
            'End If

            If ColumnExists(reader, "id_bem") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_bem")) Then
                If reader.GetFieldType(reader.GetOrdinal("id_bem")) = GetType(Int64) Then
                    inventario_detalhes.Id_Bem = reader.GetInt64(reader.GetOrdinal("id_bem"))
                End If
            End If

            If ColumnExists(reader, "bem") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bem")) Then
                inventario_detalhes.Bem = reader.GetString(reader.GetOrdinal("bem"))
            End If

            'If ColumnExists(reader, "id_dependencia") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_dependencia")) Then
            '    inventario_detalhes.Id_dependencia = reader.GetString(reader.GetOrdinal("id_dependencia"))
            'End If

            If ColumnExists(reader, "id_dependencia") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_dependencia")) Then
                If reader.GetFieldType(reader.GetOrdinal("id_dependencia")) = GetType(Int64) Then
                    inventario_detalhes.Id_dependencia = reader.GetInt64(reader.GetOrdinal("id_dependencia"))
                End If
            End If

            If ColumnExists(reader, "dependencia") AndAlso Not reader.IsDBNull(reader.GetOrdinal("dependencia")) Then
                inventario_detalhes.Dependencia = reader.GetString(reader.GetOrdinal("dependencia"))
            End If

            ' Verifica outros campos de forma similar
            If ColumnExists(reader, "situacao") AndAlso Not reader.IsDBNull(reader.GetOrdinal("situacao")) Then
                inventario_detalhes.Estado = reader.GetString(reader.GetOrdinal("situacao"))
            End If

            If ColumnExists(reader, "acao") AndAlso Not reader.IsDBNull(reader.GetOrdinal("acao")) Then
                inventario_detalhes.Acao = reader.GetString(reader.GetOrdinal("acao"))
            End If

            If ColumnExists(reader, "observacao") AndAlso Not reader.IsDBNull(reader.GetOrdinal("observacao")) Then
                inventario_detalhes.Observacao = reader.GetString(reader.GetOrdinal("observacao"))
            End If

            If ColumnExists(reader, "cont") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cont")) Then
                If reader.GetFieldType(reader.GetOrdinal("cont")) = GetType(Int64) Then
                    inventario_detalhes.Contagem = reader.GetInt64(reader.GetOrdinal("cont"))
                End If
            End If

            If ColumnExists(reader, "qtde") AndAlso Not reader.IsDBNull(reader.GetOrdinal("qtde")) Then
                If reader.GetFieldType(reader.GetOrdinal("qtde")) = GetType(Int64) Then
                    inventario_detalhes.Qtde = reader.GetInt64(reader.GetOrdinal("qtde"))
                End If
            End If

            Return inventario_detalhes
        Catch ex As Exception
            ' Adiciona registro de log ou re-throw com mais informações
            Throw New Exception("Erro ao converter os dados do reader para InventarioDetalhesDTO", ex)
        End Try
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
