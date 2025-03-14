
Public Class SistemaBLL
    Private ReadOnly sistemaDAL As SistemaDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        sistemaDAL = New SistemaDAL(connectionFactory)
    End Sub

    Public Sub Inserir(sistema As SistemaDTO)
        Try
            ' Validação dos dados do sistema (opcional)
            sistemaDAL.Insert(sistema)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir sistema." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(sistemaId As Integer)
        Try
            ' Validação do ID do sistema (opcional)
            sistemaDAL.Delete(sistemaId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir sistema." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(sistema As SistemaDTO)
        Try
            ' Validação dos dados do sistema (opcional)
            sistemaDAL.Update(sistema)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar sistema." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As SistemaDTO
        Try
            ' Validação do Nome do status (opcional)
            Return sistemaDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar sistema." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(sistemaId As Integer) As List(Of SistemaDTO)
        Try
            ' Validação do ID do sistema (opcional)
            Return sistemaDAL.GetByIdList(sistemaId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar sistema." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of SistemaDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return sistemaDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return sistemaDAL.GetAllList($"AND (adm_local = '{Filtro}' OR token = '{Filtro}')")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Sistema." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorToken(Token As String) As List(Of SistemaDTO)
        Try
            Return sistemaDAL.GetAllList($"AND token = '{Token}'")
        Catch ex As Exception
            MsgBox("Erro ao buscar Token." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function


End Class
