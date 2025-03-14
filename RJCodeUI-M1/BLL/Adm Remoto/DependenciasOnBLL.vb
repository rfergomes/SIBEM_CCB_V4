

Public Class DependenciasOnBLL

    Private ReadOnly DependenciasOnDAL As DependenciasOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        DependenciasOnDAL = New DependenciasOnDAL(connectionFactory)
    End Sub

    Public Sub Inserir(dependencias As DependenciasOnDTO)
        Try
            ' Validação dos dados do dependencias (opcional)
            DependenciasOnDAL.Insert(dependencias)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir Dependência." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(dependenciasId As Integer)
        Try
            ' Validação do ID do dependencias (opcional)
            DependenciasOnDAL.Delete(dependenciasId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Dependência." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(dependencias As DependenciasOnDTO)
        Try
            ' Validação dos dados do dependencias (opcional)
            DependenciasOnDAL.Update(dependencias)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Dependência." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As DependenciasOnDTO
        Try
            ' Validação do Nome do bens (opcional)
            Return DependenciasOnDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Dependencia." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(dependenciasId As Integer) As DependenciasOnDTO
        Try
            ' Validação do ID do dependencias (opcional)
            Return DependenciasOnDAL.GetById(dependenciasId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Dependência." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(dependenciasId As Integer) As List(Of DependenciasOnDTO)
        Try
            ' Validação do ID do dependencias (opcional)
            Return DependenciasOnDAL.GetByIdList(dependenciasId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Dependência." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of DependenciasOnDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return DependenciasOnDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return DependenciasOnDAL.GetAllList("AND descricao LIKE '%" & Filtro & "%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Dependência." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
