'Última Atualização:    13/11/2024
'Data:                  13/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class AdmlcOnBLL
    Private ReadOnly admlcOnDAL As AdmlcOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        admlcOnDAL = New AdmlcOnDAL(connectionFactory)
    End Sub

    Public Sub Inserir(admlcOn As AdmlcOnDTO)
        Try
            ' Validação dos dados do admlcOn (opcional)
            admlcOnDAL.Insert(admlcOn)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir admlcOn." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(admlcOnId As Integer)
        Try
            ' Validação do ID do admlcOn (opcional)
            admlcOnDAL.Delete(admlcOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir admlcOn." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(admlcOn As AdmlcOnDTO)
        Try
            ' Validação dos dados do admlcOn (opcional)
            admlcOnDAL.Update(admlcOn)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As AdmlcOnDTO
        Try
            ' Validação do Nome do status (opcional)
            Return admlcOnDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(admlcOnId As Integer) As List(Of AdmlcOnDTO)
        Try
            ' Validação do ID do admlcOn (opcional)
            Return admlcOnDAL.GetByIdList(admlcOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of AdmlcOnDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return admlcOnDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return admlcOnDAL.GetAllList($"AND id_admlc LIKE '%{Filtro}%' OR adm_local LIKE '%{Filtro}%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Administração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
