Public Class UsuarioBLL
    Private ReadOnly usuarioDAL As UsuarioDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        usuarioDAL = New UsuarioDAL(connectionFactory)
    End Sub

    Public Function Login(username As String, pass As String)
        Return GetAllUsers().Find(Function(x) x.Usuario = username AndAlso x.Senha = pass)
    End Function

    Public Sub InsertUser(user As UsuarioDTO)
        Try
            ' Validação dos dados do usuário (opcional)

            usuarioDAL.Insert(user)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir usuário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub DeleteUser(userId As Integer)
        Try
            ' Validação do ID do usuário (opcional)

            usuarioDAL.Delete(userId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir usuário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub UpdateUser(user As UsuarioDTO)
        Try
            ' Validação dos dados do usuário (opcional)

            usuarioDAL.Update(user)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar usuário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function GetUserById(userId As Integer) As List(Of UsuarioDTO)
        Try
            ' Validação do ID do usuário (opcional)

            Return usuarioDAL.GetByIdList(userId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar usuário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function GetAllUsers() As List(Of UsuarioDTO)
        Try
            ' Validação do ID do usuário (opcional)
            Return usuarioDAL.GetAllList()

        Catch ex As Exception
            MsgBox("Erro ao buscar usuário." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function
End Class
