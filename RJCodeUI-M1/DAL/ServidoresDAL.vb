Public Class ServidoresDAL
    Inherits GenericDAL(Of ServidoresDTO)

    Private Tabela = "servidores"
    Private TabelaView = "lista_servidores"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(servidores As ServidoresDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_admlc", servidores.Id_Admlc},
            {"servidor", servidores.Servidor},
            {"porta", servidores.Porta},
            {"banco", servidores.Banco},
            {"usuario", servidores.Usuario},
            {"senha", servidores.Senha},
            {"ativo", servidores.Ativo}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(servidoresId As String)
        Excluir(Tabela, $"id_servidor = {servidoresId}")
    End Sub

    Public Overrides Sub Update(servidores As ServidoresDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_servidor", servidores.Id},
            {"id_admlc", servidores.Id_Admlc},
            {"servidor", servidores.Servidor},
            {"porta", servidores.Porta},
            {"banco", servidores.Banco},
            {"usuario", servidores.Usuario},
            {"senha", servidores.Senha},
            {"ativo", servidores.Ativo}
        }
        Atualizar(Tabela, columns, $"AND id_servidor = '{servidores.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(servidoresId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, $"AND id_servidor = {servidoresId}")
    End Function

    Public Overrides Function GetByIdList(servidoresId As String) As List(Of ServidoresDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, $"AND id_servidor = {servidoresId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of ServidoresDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As ServidoresDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As ServidoresDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of ServidoresDTO) = BuscarLista(Tabela, columns, $"AND descricao = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Id_Admlc = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As ServidoresDTO
        Dim servidores As New ServidoresDTO()

        ' Verifica se o campo "id_servidores" é um inteiro e está presente
        If ColumnExists(reader, "id_servidor") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_servidor")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_servidor")) = GetType(Int64) Then
                servidores.Id = reader.GetInt64(reader.GetOrdinal("id_servidor"))
            End If
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If ColumnExists(reader, "id_admlc") AndAlso Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            If reader.GetFieldType(reader.GetOrdinal("id_admlc")) = GetType(Int64) Then
                servidores.Id_Admlc = reader.GetInt64(reader.GetOrdinal("id_admlc"))
            End If
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("servidor")) Then
            servidores.Servidor = reader.GetString(reader.GetOrdinal("servidor"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("porta")) Then
            servidores.Porta = reader.GetString(reader.GetOrdinal("porta"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("banco")) Then
            servidores.Banco = reader.GetString(reader.GetOrdinal("banco"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("usuario")) Then
            servidores.Usuario = reader.GetString(reader.GetOrdinal("usuario"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("senha")) Then
            servidores.Senha = reader.GetString(reader.GetOrdinal("senha"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("ativo")) Then
            servidores.Ativo = reader.GetInt32(reader.GetOrdinal("ativo"))
        End If

        Return servidores
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
