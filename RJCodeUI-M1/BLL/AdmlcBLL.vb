'Última Atualização:    07/10/2024
'Data:                  07/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class AdmlcBLL
    Private ReadOnly admlcDAL As AdmlcDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        admlcDAL = New AdmlcDAL(connectionFactory)
    End Sub

    Public Sub Inserir(admlc As AdmlcDTO)
        Try
            ' Validação dos dados do admlc (opcional)
            admlcDAL.Insert(admlc)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir admlc." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(admlcId As Integer)
        Try
            ' Validação do ID do admlc (opcional)
            admlcDAL.Delete(admlcId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir admlc." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(admlc As AdmlcDTO)
        Try
            ' Validação dos dados do admlc (opcional)
            admlcDAL.Update(admlc)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As AdmlcDTO
        Try
            ' Validação do Nome do status (opcional)
            Return admlcDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(admlcId As Integer) As AdmlcDTO
        Try
            ' Validação do ID do admlc (opcional)
            Return admlcDAL.GetById(admlcId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(admlcId As Integer) As List(Of AdmlcDTO)
        Try
            ' Validação do ID do admlc (opcional)
            Return admlcDAL.GetByIdList(admlcId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of AdmlcDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return admlcDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return admlcDAL.GetAllList("descricao LIKE '%" & Filtro & "%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Administração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
