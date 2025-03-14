
Imports System.Text

Public Class TokenSolicitacaoOnBLL
    Private ReadOnly tokenSolicitacaoOnDAL As TokenSolicitacaoOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        tokenSolicitacaoOnDAL = New TokenSolicitacaoOnDAL(connectionFactory)
    End Sub

    Public Sub Inserir(tokenSolicitacaoOn As TokenSolicitacaoOnDTO)
        Try
            ' Validação dos dados do tokenSolicitacaoOn (opcional)
            tokenSolicitacaoOnDAL.Insert(tokenSolicitacaoOn)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir tokenSolicitacaoOn." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(tokenSolicitacaoOnId As Integer)
        Try
            ' Validação do ID do tokenSolicitacaoOn (opcional)
            tokenSolicitacaoOnDAL.Delete(tokenSolicitacaoOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Solicitação de Token." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(tokenSolicitacaoOn As TokenSolicitacaoOnDTO)
        Try
            ' Validação dos dados do tokenSolicitacaoOn (opcional)
            tokenSolicitacaoOnDAL.Update(tokenSolicitacaoOn)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Solicitação de Token." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As TokenSolicitacaoOnDTO
        Try
            ' Validação do Nome do status (opcional)
            Return tokenSolicitacaoOnDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Solicitação de Token." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(tokenSolicitacaoOnId As String) As TokenSolicitacaoOnDTO
        Try
            ' Validação do ID do tokenSolicitacaoOn (opcional)
            Return tokenSolicitacaoOnDAL.GetById(tokenSolicitacaoOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Solicitação de Token." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(tokenSolicitacaoOnId As Integer) As List(Of TokenSolicitacaoOnDTO)
        Try
            ' Validação do ID do tokenSolicitacaoOn (opcional)
            Return tokenSolicitacaoOnDAL.GetByIdList(tokenSolicitacaoOnId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Solicitação de Token." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional TextoPesquisa As String = "") As List(Of TokenSolicitacaoOnDTO)
        Dim condicao As New StringBuilder()

        Try
            ' Monta a query condicionalmente
            If Not String.IsNullOrEmpty(TextoPesquisa) Then
                condicao.Append($" AND (id_solicitacao LIKE '%{TextoPesquisa}%' OR nome LIKE '%{TextoPesquisa}%')")
            End If


            ' Se houver um filtro, aplica a busca filtrada
            Return tokenSolicitacaoOnDAL.GetAllList(condicao.ToString())

        Catch ex As Exception
            MsgBox("Erro ao buscar Solicitação de Token." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorToken(Token As String) As List(Of TokenSolicitacaoOnDTO)
        Try
            Return tokenSolicitacaoOnDAL.GetAllList($"AND token = '{Token}'")
        Catch ex As Exception
            MsgBox("Erro ao buscar Token." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function


End Class
