
Public Class TokenOnBLL
    Private ReadOnly tokenOnDAL As TokenOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        tokenOnDAL = New TokenOnDAL(connectionFactory)
    End Sub

    Public Sub Inserir(tokenOn As TokenOnDTO)
        Try
            ' Validação dos dados do tokenOn (opcional)
            tokenOnDAL.Insert(tokenOn)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir tokenOn." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(tokenOnId As Integer)
        Try
            ' Validação do ID do tokenOn (opcional)
            tokenOnDAL.Delete(tokenOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir tokenOn." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(tokenOn As TokenOnDTO)
        Try
            ' Validação dos dados do tokenOn (opcional)
            tokenOnDAL.Update(tokenOn)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar tokenOn." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As TokenOnDTO
        Try
            ' Validação do Nome do status (opcional)
            Return tokenOnDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar tokenOn." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(tokenOnId As Integer) As TokenOnDTO
        Try
            ' Validação do ID do tokenOn (opcional)
            Return tokenOnDAL.GetById(tokenOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar tokenOn." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(tokenOnId As Integer) As List(Of TokenOnDTO)
        Try
            ' Validação do ID do tokenOn (opcional)
            Return tokenOnDAL.GetByIdList(tokenOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar tokenOn." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of TokenOnDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return tokenOnDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return tokenOnDAL.GetAllList($"AND (adm_local = '{Filtro}' OR token = '{Filtro}')")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar tokenOn." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorToken(Token As String) As List(Of TokenOnDTO)
        Try
            Return tokenOnDAL.GetAllList($" AND token = '{Token}'")
        Catch ex As Exception
            MsgBox("Erro ao buscar Token." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function


End Class
