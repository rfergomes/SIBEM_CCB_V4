'Última Atualização: 18/10/2024
'Data: 18/10/2024
'Autor: Rodrigo Fernando Gomes Lima

Public Class InventariosDAL
    Inherits GenericDAL(Of InventariosDTO)

    Private ReadOnly Tabela = "inventarios"
    Private ReadOnly TabelaViews = "lista_inventarios"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(inventarios As InventariosDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_igreja", inventarios.Id_Igreja},
            {"data", inventarios.Data},
            {"responsaveis", inventarios.Responsaveis},
            {"inventariantes", inventarios.Inventariantes},
            {"inicio", inventarios.Inicio},
            {"termino", inventarios.Termino},
            {"tempo", inventarios.Duracao},
            {"bens_lidos", inventarios.Bens_Lidos},
            {"bens_pendentes", inventarios.Bens_Pendentes},
            {"bens_novos", inventarios.Bens_Novos},
            {"bens_inicial", inventarios.Bens_Inicial},
            {"bens_final", inventarios.Bens_Final},
            {"situacao", inventarios.Situacao},
            {"bens_importado", inventarios.Bens_Importado},
            {"teste", inventarios.Inventario_Teste},
            {"id_admlc", VarGlob.SistemaAtivo.Id_Admlc},
            {"siga_ok", inventarios.Siga_Ok},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(inventariosId As String) As Integer
        Return Excluir(Tabela, $"id_inventario = '{inventariosId}'")
    End Function

    Public Overrides Function Update(inventarios As InventariosDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_inventario", inventarios.Id},
            {"id_igreja", inventarios.Id_Igreja},
            {"data", inventarios.Data},
            {"responsaveis", inventarios.Responsaveis},
            {"inventariantes", inventarios.Inventariantes},
            {"inicio", inventarios.Inicio},
            {"termino", inventarios.Termino},
            {"tempo", inventarios.Duracao},
            {"bens_lidos", inventarios.Bens_Lidos},
            {"bens_pendentes", inventarios.Bens_Pendentes},
            {"bens_novos", inventarios.Bens_Novos},
            {"bens_inicial", inventarios.Bens_Inicial},
            {"bens_final", inventarios.Bens_Final},
            {"situacao", inventarios.Situacao},
            {"bens_importado", inventarios.Bens_Importado},
            {"teste", inventarios.Inventario_Teste},
            {"id_admlc", VarGlob.SistemaAtivo.Id_Admlc},
            {"siga_ok", inventarios.Siga_Ok},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Atualizar(Tabela, columns, $"AND id_inventario = '{inventarios.Id}'")
    End Function

    Public Overrides Function GetById(inventariosId As String) As InventariosDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of InventariosDTO) = BuscarLista(TabelaViews, columns, $"AND id_inventario = '{inventariosId}'")
        Return lista.FirstOrDefault(Function(t) t.Id = inventariosId)
    End Function

    Public Overrides Function GetByIdDt(inventariosId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, $"AND id_inventario = {inventariosId}")
    End Function

    Public Overrides Function GetByIdList(inventariosId As String) As List(Of InventariosDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"AND id_inventario = '{inventariosId}'")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of InventariosDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $"{condicao} AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaViews, columns, condicao)
    End Function

    Public Overrides Function GetByPart(part As String) As InventariosDTO
        Throw New NotImplementedException()
    End Function

    Public Function GetCount(Optional condicao As String = "") As Integer
        Return BuscarContagem(TabelaViews, condicao)
    End Function

    Public Function GetMax(Coluna As String, Optional Condicao As String = "") As Object
        Return BuscarMaximo(TabelaViews, Coluna, Condicao)
    End Function

    Public Function GetMin(Coluna As String, Optional Condicao As String = "") As Object
        Return BuscarMaximo(TabelaViews, Coluna, Condicao)
    End Function

    Public Function GetYearList() As List(Of List(Of String))
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarListaStrings("lista_anos", columns, $" id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As InventariosDTO
        Dim inventarios As New InventariosDTO()

        ' Verifica se o reader não é nulo
        If reader Is Nothing Then
            Throw New ArgumentNullException(NameOf(reader), "O DataReader não pode ser nulo.")
        End If

        Try
            ' Verifica o campo "id_inventario"

            If ColumnExists(reader, "id_inventario") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_inventario")) Then
                If reader.GetFieldType(reader.GetOrdinal("id_inventario")) = GetType(String) Then
                    inventarios.Id = reader.GetString(reader.GetOrdinal("id_inventario"))
                End If
            End If

            If ColumnExists(reader, "id_igreja") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_igreja")) Then
                If reader.GetFieldType(reader.GetOrdinal("id_igreja")) = GetType(String) Then
                    inventarios.Id_Igreja = reader.GetString(reader.GetOrdinal("id_igreja"))
                End If
            End If

            If ColumnExists(reader, "igreja") AndAlso Not reader.IsDBNull(reader.GetOrdinal("igreja")) Then
                inventarios.Igreja = reader.GetString(reader.GetOrdinal("igreja"))
            End If

            If ColumnExists(reader, "cod_setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("cod_setor")) Then
                inventarios.Cod_Setor = reader.GetString(reader.GetOrdinal("cod_setor"))
            End If

            If ColumnExists(reader, "setor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("setor")) Then
                inventarios.Setor = reader.GetString(reader.GetOrdinal("setor"))
            End If

            ' Verifica outros campos de forma similar
            If ColumnExists(reader, "data") AndAlso Not reader.IsDBNull(reader.GetOrdinal("data")) Then
                If reader.GetFieldType(reader.GetOrdinal("data")) = GetType(Date) Then
                    inventarios.Data = reader.GetDateTime(reader.GetOrdinal("data"))
                End If
            End If

                If ColumnExists(reader, "responsaveis") AndAlso Not reader.IsDBNull(reader.GetOrdinal("responsaveis")) Then
                inventarios.Responsaveis = reader.GetString(reader.GetOrdinal("responsaveis"))
            End If

            If ColumnExists(reader, "inventariantes") AndAlso Not reader.IsDBNull(reader.GetOrdinal("inventariantes")) Then
                inventarios.Inventariantes = reader.GetString(reader.GetOrdinal("inventariantes"))
            End If

            If ColumnExists(reader, "inicio") AndAlso Not reader.IsDBNull(reader.GetOrdinal("inicio")) Then
                inventarios.Inicio = reader.GetDateTime(reader.GetOrdinal("inicio"))
            End If

            If ColumnExists(reader, "termino") AndAlso Not reader.IsDBNull(reader.GetOrdinal("termino")) Then
                inventarios.Termino = reader.GetDateTime(reader.GetOrdinal("termino"))
            End If

            If ColumnExists(reader, "tempo") AndAlso Not reader.IsDBNull(reader.GetOrdinal("tempo")) Then
                Dim duracaoStr = reader.GetString(reader.GetOrdinal("tempo"))
                Dim duracao As TimeSpan
                If TimeSpan.TryParse(duracaoStr, duracao) Then
                    inventarios.Duracao = duracao
                End If
            End If

            If ColumnExists(reader, "bens_lidos") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bens_lidos")) Then
                inventarios.Bens_Lidos = reader.GetInt64(reader.GetOrdinal("bens_lidos"))
            End If

            If ColumnExists(reader, "bens_pendentes") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bens_pendentes")) Then
                inventarios.Bens_Pendentes = reader.GetInt64(reader.GetOrdinal("bens_pendentes"))
            End If

            If ColumnExists(reader, "bens_novos") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bens_novos")) Then
                inventarios.Bens_Novos = reader.GetInt64(reader.GetOrdinal("bens_novos"))
            End If

            If ColumnExists(reader, "bens_inicial") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bens_inicial")) Then
                inventarios.Bens_Inicial = reader.GetInt64(reader.GetOrdinal("bens_inicial"))
            End If

            ' Verifica se "bens_final" é realmente uma string
            If ColumnExists(reader, "bens_final") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bens_final")) Then
                inventarios.Bens_Final = reader.GetInt64(reader.GetOrdinal("bens_final"))
            End If

            If ColumnExists(reader, "situacao") AndAlso Not reader.IsDBNull(reader.GetOrdinal("situacao")) Then
                inventarios.Situacao = reader.GetString(reader.GetOrdinal("situacao"))
            End If

            If ColumnExists(reader, "bens_importado") AndAlso Not reader.IsDBNull(reader.GetOrdinal("bens_importado")) Then
                inventarios.Bens_Importado = reader.GetBoolean(reader.GetOrdinal("bens_importado"))
            End If

            If ColumnExists(reader, "teste") AndAlso Not reader.IsDBNull(reader.GetOrdinal("teste")) Then
                inventarios.Inventario_Teste = reader.GetBoolean(reader.GetOrdinal("teste"))
            End If

            If ColumnExists(reader, "id_admlc") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
                inventarios.Id_AdmLc = reader.GetBoolean(reader.GetOrdinal("id_admlc"))
            End If

            If ColumnExists(reader, "siga_ok") AndAlso Not reader.IsDBNull(reader.GetOrdinal("siga_ok")) Then
                inventarios.Siga_Ok = reader.GetInt64(reader.GetOrdinal("siga_ok"))
            End If

            If ColumnExists(reader, "data_alter") AndAlso Not reader.IsDBNull(reader.GetOrdinal("data_alter")) Then
                inventarios.Data_Alteracao = reader.GetDateTime(reader.GetOrdinal("data_alter"))
            End If

            Return inventarios
        Catch ex As Exception
            ' Adiciona registro de log ou re-throw com mais informações
            Throw New Exception("Erro ao converter os dados do reader para InventariosDTO", ex)
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
