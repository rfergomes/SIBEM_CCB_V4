Public Class StatusBLL
    Private ReadOnly statusDAL As StatusDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        statusDAL = New StatusDAL(connectionFactory)
    End Sub

    Public Sub Inserir(status As StatusDTO)
        Try
            ' Validação dos dados do status (opcional)
            statusDAL.Insert(status)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir status." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(statusId As Integer)
        Try
            ' Validação do ID do status (opcional)
            statusDAL.Delete(statusId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir status." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(status As StatusDTO)
        Try
            ' Validação dos dados do status (opcional)
            statusDAL.Update(status)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar status." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As StatusDTO
        Try
            ' Validação do Nome do status (opcional)
            Return statusDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar status." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(statusId As Integer) As List(Of StatusDTO)
        Try
            ' Validação do ID do status (opcional)
            Return statusDAL.GetByIdList(statusId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar status." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of StatusDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return statusDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return statusDAL.GetAllList("AND descricao LIKE '" & Filtro & "%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Status." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
