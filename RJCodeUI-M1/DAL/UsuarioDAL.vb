Public Class UsuarioDAL
    Inherits GenericDAL(Of UsuarioDTO)

    Private Tabela = "usuarios"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(user As UsuarioDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"usuario", user.Usuario},
            {"senha", user.Senha}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(userId As String)
        Excluir(Tabela, $"id_usuario = {userId}")
    End Sub

    Public Overrides Sub Update(user As UsuarioDTO)
        Dim columns As New Dictionary(Of String, Object)()
        columns.Add("usuario", user.Usuario)
        columns.Add("senha", user.Senha)
        Atualizar(Tabela, columns, $"id_usuario = '{user.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(userId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(Tabela, columns, $"id_usuario = {userId}")
    End Function

    Public Overrides Function GetByIdList(userId As Integer) As List(Of UsuarioDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, $"id_usuario = {userId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of UsuarioDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt() As DataTable
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

        ' Verifica e obtém "data_nasc" como DateTime
        If Not reader.IsDBNull(reader.GetOrdinal("data_nasc")) Then
            user.DtNasc = reader.GetDateTime(reader.GetOrdinal("data_nasc"))
        End If

        ' Verifica se os outros campos não são nulos
        If Not reader.IsDBNull(reader.GetOrdinal("email")) Then
            user.Email = reader.GetString(reader.GetOrdinal("email"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("telefone")) Then
            user.Telefone = reader.GetString(reader.GetOrdinal("telefone"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("usuario")) Then
            user.Usuario = reader.GetString(reader.GetOrdinal("usuario"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("senha")) Then
            user.Senha = reader.GetString(reader.GetOrdinal("senha"))
        End If

        Return user
    End Function

End Class
