'Última Atualização:    04/10/2024
'Data:                  04/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class SetoresBLL
    Private ReadOnly setoresDAL As SetoresDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        setoresDAL = New SetoresDAL(connectionFactory)
    End Sub

    Public Sub Inserir(setores As SetoresDTO)
        Try
            ' Validação dos dados do setores (opcional)
            setoresDAL.Insert(setores)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir setores." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(setoresId As Integer)
        Try
            ' Validação do ID do setores (opcional)
            setoresDAL.Delete(setoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir setores." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(setores As SetoresDTO)
        Try
            ' Validação dos dados do setores (opcional)
            setoresDAL.Update(setores)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar setores." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As SetoresDTO
        Try
            ' Validação do Nome do Setor (opcional)
            Return setoresDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Setor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(setoresId As String) As SetoresDTO
        Try
            ' Validação do ID do setores (opcional)
            Return setoresDAL.GetById(setoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar setores." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of SetoresDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return setoresDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return setoresDAL.GetAllList($"AND descricao LIKE '%{Filtro}%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Setor." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
