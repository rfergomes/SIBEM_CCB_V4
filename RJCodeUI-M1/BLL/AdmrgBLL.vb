'Última Atualização:    07/10/2024
'Data:                  07/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class AdmrgBLL
    Private ReadOnly admrgDAL As AdmrgDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        admrgDAL = New AdmrgDAL(connectionFactory)
    End Sub

    Public Sub Inserir(admrg As AdmrgDTO)
        Try
            ' Validação dos dados do admrg (opcional)
            admrgDAL.Insert(admrg)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir admrg." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(admrgId As Integer)
        Try
            ' Validação do ID do admrg (opcional)
            admrgDAL.Delete(admrgId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir admrg." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(admrg As AdmrgDTO)
        Try
            ' Validação dos dados do admrg (opcional)
            admrgDAL.Update(admrg)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As AdmrgDTO
        Try
            ' Validação do Nome do status (opcional)
            Return admrgDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(admrgId As Integer) As AdmrgDTO
        Try
            ' Validação do ID do admrg (opcional)
            Return admrgDAL.GetById(admrgId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(admrgId As Integer) As List(Of AdmrgDTO)
        Try
            ' Validação do ID do admrg (opcional)
            Return admrgDAL.GetByIdList(admrgId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Administração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of AdmrgDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return admrgDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return admrgDAL.GetAllList("descricao LIKE '%" & Filtro & "%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Administração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
