
Public Class ServidoresBLL
    Private ReadOnly servidoresDAL As ServidoresDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        servidoresDAL = New ServidoresDAL(connectionFactory)
    End Sub

    Public Sub Inserir(servidores As ServidoresDTO)
        Try
            ' Validação dos dados do servidores (opcional)
            servidoresDAL.Insert(servidores)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(servidoresId As Integer)
        Try
            ' Validação do ID do servidores (opcional)
            servidoresDAL.Delete(servidoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(servidores As ServidoresDTO)
        Try
            ' Validação dos dados do servidores (opcional)
            servidoresDAL.Update(servidores)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As ServidoresDTO
        Try
            ' Validação do Nome do status (opcional)
            Return servidoresDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(servidoresId As Integer) As List(Of ServidoresDTO)
        Try
            ' Validação do ID do servidores (opcional)
            Return servidoresDAL.GetByIdList(servidoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar servidor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of ServidoresDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return servidoresDAL.GetAllList($"AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return servidoresDAL.GetAllList($"AND (servidor LIKE '%{Filtro}%' OR banco LIKE '%{Filtro}%')")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar servidores." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
