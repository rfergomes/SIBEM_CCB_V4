

Public Class UsuarioDAL
    Inherits GenericDAL(Of UsuarioDTO)

    Private Tabela = "usuarios"
    Private TabelaViews = "lista_usuarios"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(user As UsuarioDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"nome", user.Nome},
            {"telefone", user.Telefone},
            {"email", user.Email},
            {"senha", user.Senha},
            {"igreja", user.Igreja},
            {"cidade", user.Cidade},
            {"tipo", user.Tipo},
            {"id_admlc", user.Id_Admlc},
            {"foto", user.Foto},
            {"data_cad", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Function Delete(userId As String) As Integer
        Return Excluir(Tabela, $" AND id_usuario = {userId}")
    End Function

    Public Overrides Function Update(user As UsuarioDTO) As Integer
        Dim columns As New Dictionary(Of String, Object) From {
            {"nome", user.Nome},
            {"telefone", user.Telefone},
            {"email", user.Email},
            {"senha", user.Senha},
            {"igreja", user.Igreja},
            {"cidade", user.Cidade},
            {"tipo", user.Tipo},
            {"id_admlc", user.Id_Admlc},
            {"foto", user.Foto},
            {"data_alter", Now.ToString("yyyy-MM-dd HH:mm:ss")}
        }
        Return Atualizar(Tabela, columns, $" AND id_usuario = {user.Id}")
    End Function

    Public Overrides Function GetByIdDt(userId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $" AND id_usuario = {userId}")
    End Function

    Public Overrides Function GetByIdList(userId As String) As List(Of UsuarioDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, $" AND id_usuario = {userId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of UsuarioDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaViews, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As UsuarioDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As UsuarioDTO
        Throw New NotImplementedException()
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As UsuarioDTO
        Dim user As New UsuarioDTO()

        ' Verifica se o campo "id_usuario" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_usuario")) Then
            user.Id = reader.GetInt32(reader.GetOrdinal("id_usuario"))
        End If

        ' Verifica se o campo "nome" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("nome")) Then
            user.Nome = reader.GetString(reader.GetOrdinal("nome"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("telefone")) Then
            user.Telefone = reader.GetString(reader.GetOrdinal("telefone"))
        End If

        ' Verifica se os outros campos não são nulos
        If Not reader.IsDBNull(reader.GetOrdinal("email")) Then
            user.Email = reader.GetString(reader.GetOrdinal("email"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("senha")) Then
            user.Senha = reader.GetString(reader.GetOrdinal("senha"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("igreja")) Then
            user.Igreja = reader.GetString(reader.GetOrdinal("igreja"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cidade")) Then
            user.Cidade = reader.GetString(reader.GetOrdinal("cidade"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("tipo")) Then
            user.Tipo = reader.GetString(reader.GetOrdinal("tipo"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("id_admlc")) Then
            user.Id_Admlc = reader.GetInt32(reader.GetOrdinal("id_admlc"))
        End If

        If ColumnExists(reader, "adm_local") AndAlso Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
            If Not reader.IsDBNull(reader.GetOrdinal("adm_local")) Then
                user.Adm_Local = reader.GetString(reader.GetOrdinal("adm_local"))
            End If
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("foto")) Then
            user.Foto = reader.GetString(reader.GetOrdinal("foto"))
        End If

        Return user
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
