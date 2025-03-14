Public Class DashboardBLL
    Private ReadOnly DashboardDAL As DashboardDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        DashboardDAL = New DashboardDAL(connectionFactory)
    End Sub

    Public Sub Inserir(dashboard As DashboardDTO)
        Try
            ' Validação dos dados do dashboard (opcional)
            DashboardDAL.Insert(dashboard)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir dashboard." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(dashboardId As Integer)
        Try
            ' Validação do ID do dashboard (opcional)
            DashboardDAL.Delete(dashboardId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir dashboard." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(dashboard As DashboardDTO)
        Try
            ' Validação dos dados do dashboard (opcional)
            DashboardDAL.Update(dashboard)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar dashboard." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As DashboardDTO
        Try
            ' Validação do Nome do dashboard (opcional)
            Return DashboardDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar dashboard." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(dashboardId As Integer) As List(Of DashboardDTO)
        Try
            ' Validação do ID do dashboard (opcional)
            Return DashboardDAL.GetByIdList(dashboardId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar dashboard." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of DashboardDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return DashboardDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return DashboardDAL.GetAllList("AND descricao LIKE '" & Filtro & "%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar dashboard." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function ObterDadosDashboard(ano As Integer, setor As String) As DashboardDTO
        Try
            ' Obter os dados do DAL
            Return DashboardDAL.ObterDadosDashboard(ano, setor)
        Catch ex As Exception
            MsgBox("Erro ao buscar dashboard." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
