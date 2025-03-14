
Public Class SincronizarBLL
    Private ReadOnly sincronizarDAL As SincronizarDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        sincronizarDAL = New SincronizarDAL(connectionFactory)
    End Sub

    Public Sub Inserir(sincronizar As SincronizarDTO)
        Try
            ' Validação dos dados do sincronizar (opcional)
            sincronizarDAL.Insert(sincronizar)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir sincronizar." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(sincronizarId As Integer)
        Try
            ' Validação do ID do sincronizar (opcional)
            sincronizarDAL.Delete(sincronizarId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir sincronizar." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(sincronizar As SincronizarDTO)
        Try
            ' Validação dos dados do sincronizar (opcional)
            sincronizarDAL.Update(sincronizar)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar sincronizar." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarIdTabela(Id_Tabela As String) As SincronizarDTO
        Try
            ' Validação do Nome do status (opcional)
            Return sincronizarDAL.GetByPart(Id_Tabela)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar sincronizar." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(sincronizarId As String) As SincronizarDTO
        Try
            ' Validação do ID do sincronizar (opcional)
            Return sincronizarDAL.GetById(sincronizarId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar sincronizar." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(sincronizarId As Integer) As List(Of SincronizarDTO)
        Try
            ' Validação do ID do sincronizar (opcional)
            Return sincronizarDAL.GetByIdList(sincronizarId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar sincronizar." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of SincronizarDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return sincronizarDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return sincronizarDAL.GetAllList($"AND {Filtro}")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Sincronizar." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarResumoSincronizar(Optional Condicao As String = "")
        Try
            Return sincronizarDAL.GetResumoSincronizar(Condicao)
        Catch ex As Exception
            MsgBox("Erro ao buscar Sincronizar." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
