
Public Class ServidoresOnBLL
    Private ReadOnly servidoresOnDAL As ServidoresOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        servidoresOnDAL = New ServidoresOnDAL(connectionFactory)
    End Sub

    Public Sub Inserir(servidores As ServidoresOnDTO)
        Try
            ' Validação dos dados do servidores (opcional)
            servidoresOnDAL.Insert(servidores)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(servidoresId As Integer)
        Try
            ' Validação do ID do servidores (opcional)
            servidoresOnDAL.Delete(servidoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(servidores As ServidoresOnDTO)
        Try
            ' Validação dos dados do servidores (opcional)
            servidoresOnDAL.Update(servidores)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As ServidoresOnDTO
        Try
            ' Validação do Nome do status (opcional)
            Return servidoresOnDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(servidoresId As Integer) As List(Of ServidoresOnDTO)
        Try
            ' Validação do ID do servidores (opcional)
            Return servidoresOnDAL.GetByIdList(servidoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of ServidoresOnDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return servidoresOnDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return servidoresOnDAL.GetAllList($"AND (adm_local = '{Filtro}' OR token = '{Filtro}')")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar servidor." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing

    End Function
End Class
