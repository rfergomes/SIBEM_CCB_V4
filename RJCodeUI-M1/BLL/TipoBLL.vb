
Public Class TipoBLL
    Private ReadOnly tipoDAL As TipoDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        tipoDAL = New TipoDAL(connectionFactory)
    End Sub

    Public Sub Inserir(tipo As TipoDTO)
        Try
            ' Validação dos dados do tipo (opcional)
            tipoDAL.Insert(tipo)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir tipo." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(tipoId As Integer)
        Try
            ' Validação do ID do tipo (opcional)
            tipoDAL.Delete(tipoId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir tipo." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(tipo As TipoDTO)
        Try
            ' Validação dos dados do tipo (opcional)
            tipoDAL.Update(tipo)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar tipo." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As TipoDTO
        Try
            ' Validação do Nome do status (opcional)
            Return tipoDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Tipo." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(tipoId As Integer) As List(Of TipoDTO)
        Try
            ' Validação do ID do tipo (opcional)
            Return tipoDAL.GetByIdList(tipoId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar tipo." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of TipoDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return tipoDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return tipoDAL.GetAllList("descricao LIKE '%" & Filtro & "%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Status." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
