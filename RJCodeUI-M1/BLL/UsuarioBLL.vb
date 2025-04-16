Imports System.Text

Public Class UsuarioBLL
    Private ReadOnly usuarioDAL As UsuarioDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        usuarioDAL = New UsuarioDAL(connectionFactory)
    End Sub

    Public Function Login(email As String, pass As String) As UsuarioDTO
        Dim Usuario As UsuarioDTO = GetByEmail(email)
        If Usuario Is Nothing Then Return Nothing
        If Usuario.Email = email AndAlso Usuario.Senha = pass Then Return Usuario
        Return Nothing
    End Function

    Public Function InsertUser(user As UsuarioDTO) As Long
        Try
            ' Validação dos dados do usuário (opcional)

            Return usuarioDAL.Insert(user)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir usuário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

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

    Public Function GetByEmail(Email As String) As UsuarioDTO
        Try
            Dim lista As List(Of UsuarioDTO)
            lista = usuarioDAL.GetAllList()
            Return lista.FirstOrDefault(Function(u) u.Email = Email)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar usuário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function GetAllUsers(Optional Pesquisar As String = "", Optional UsuarioTipo As String = "user") As List(Of UsuarioDTO)
        Dim condicao As New StringBuilder()
        Try
            If Not String.IsNullOrEmpty(Pesquisar) Then
                condicao.Append($" AND nome LIKE '%{Pesquisar}%' OR email LIKE '%{Pesquisar}%' OR id_usuario = '{Pesquisar}'")
            End If

            If Not String.IsNullOrEmpty(UsuarioTipo) Then
                If UsuarioTipo = "admin" Then
                    condicao.Append($" AND id_admlc >=0 ")
                Else
                    condicao.Append($" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
                End If
            End If

            ' Validação do ID do usuário (opcional)
            Return usuarioDAL.GetAllList(condicao.ToString())

        Catch ex As Exception
            MsgBox("Erro ao buscar usuário." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function
End Class
