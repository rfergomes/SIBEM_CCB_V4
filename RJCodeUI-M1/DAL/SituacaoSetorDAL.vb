'Última Atualização:    09/12/2024
'Data:                  09/12/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class SituacaoSetorDAL
    Inherits GenericDAL(Of SituacaoSetorDTO)

    Private Tabela = "lista_situacao_por_setor"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(status As SituacaoSetorDTO) As Integer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Delete(statusId As String) As Integer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Update(status As SituacaoSetorDTO) As Integer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByIdDt(statusId As Integer) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByIdList(statusId As String) As List(Of SituacaoSetorDTO)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of SituacaoSetorDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetById(id As String) As SituacaoSetorDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As SituacaoSetorDTO
        Throw New NotImplementedException()
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As SituacaoSetorDTO
        Dim situacao As New SituacaoSetorDTO()

        ' Verifica se o campo "id_sincronizar" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("cod_setor")) Then
            situacao.Cod_Setor = reader.GetString(reader.GetOrdinal("cod_setor"))
        End If

        ' Verifica se o campo "descrição" não é nulo antes de ler
        If Not reader.IsDBNull(reader.GetOrdinal("descricao")) Then
            situacao.Setor = reader.GetString(reader.GetOrdinal("descricao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("igrejas")) Then
            situacao.Igrejas = reader.GetInt32(reader.GetOrdinal("igrejas"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("ativas")) Then
            situacao.IgrejasAtivas = reader.GetInt32(reader.GetOrdinal("ativas"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("inativas")) Then
            situacao.IgrejasInativas = reader.GetInt32(reader.GetOrdinal("inativas"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("realizados")) Then
            situacao.InventariosRealizados = reader.GetInt32(reader.GetOrdinal("realizados"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("pendentes")) Then
            situacao.InventariosPendentes = reader.GetInt32(reader.GetOrdinal("pendentes"))
        End If

        Return situacao
    End Function

End Class
