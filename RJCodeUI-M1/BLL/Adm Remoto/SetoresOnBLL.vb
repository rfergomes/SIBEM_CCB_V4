'Última Atualização:    27/11/2024
'Data:                  27/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class SetoresOnBLL
    Private ReadOnly SetoresOnDAL As SetoresOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        SetoresOnDAL = New SetoresOnDAL(connectionFactory)
    End Sub

    Public Function Inserir(setores As SetoresOnDTO) As Integer
        Try
            ' Validação dos dados do setores (opcional)
            Return SetoresOnDAL.Insert(setores)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir setores." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Sub Excluir(setoresId As Integer)
        Try
            ' Validação do ID do setores (opcional)
            SetoresOnDAL.Delete(setoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir setores." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function Atualizar(setores As SetoresOnDTO) As Integer
        Try
            ' Validação dos dados do setores (opcional)
            Return SetoresOnDAL.Update(setores)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar setores." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorNome(Nome As String) As SetoresOnDTO
        Try
            ' Validação do Nome do Setor (opcional)
            Return SetoresOnDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Setor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(setoresId As String) As SetoresOnDTO
        Try
            ' Validação do ID do setores (opcional)
            Return SetoresOnDAL.GetById(setoresId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar setores." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "") As List(Of SetoresOnDTO)
        Try
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return SetoresOnDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return SetoresOnDAL.GetAllList($"AND descricao LIKE '% {Filtro}%'")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Setor." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
