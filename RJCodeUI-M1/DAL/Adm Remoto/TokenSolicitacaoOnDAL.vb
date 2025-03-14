Public Class TokenSolicitacaoOnDAL
    Inherits GenericDAL(Of TokenSolicitacaoOnDTO)

    Private Tabela = "token_solicitacao"
    Private TabelaView = "token_solicitacao"

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(tokenSolicitacaoOn As TokenSolicitacaoOnDTO) As Long
        Dim columns As New Dictionary(Of String, Object) From {
            {"nome", tokenSolicitacaoOn.Nome},
            {"email", tokenSolicitacaoOn.Email},
            {"telefone", tokenSolicitacaoOn.Telefone},
            {"igreja", tokenSolicitacaoOn.Igreja},
            {"cidade", tokenSolicitacaoOn.Cidade},
            {"setor", tokenSolicitacaoOn.Setor},
            {"admlc", tokenSolicitacaoOn.AdmLc},
            {"status", tokenSolicitacaoOn.Status}
        }
        Return Inserir(Tabela, columns)
    End Function

    Public Overrides Sub Delete(tokenSolicitacaoOnId As String)
        Excluir(Tabela, $"AND id_solicitacao = {tokenSolicitacaoOnId}")
    End Sub

    Public Overrides Sub Update(tokenSolicitacaoOn As TokenSolicitacaoOnDTO)
        Dim columns As New Dictionary(Of String, Object) From {
            {"id_solicitacao", tokenSolicitacaoOn.Id},
            {"nome", tokenSolicitacaoOn.Nome},
            {"email", tokenSolicitacaoOn.Email},
            {"telefone", tokenSolicitacaoOn.Telefone},
            {"igreja", tokenSolicitacaoOn.Igreja},
            {"cidade", tokenSolicitacaoOn.Cidade},
            {"setor", tokenSolicitacaoOn.Setor},
            {"admlc", tokenSolicitacaoOn.AdmLc},
            {"status", tokenSolicitacaoOn.Status}
        }
        Atualizar(Tabela, columns, $"AND id_solicitacao = '{tokenSolicitacaoOn.Id}'")
    End Sub

    Public Overrides Function GetByIdDt(tokenSolicitacaoOnId As Integer) As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, $"AND id_solicitacao = {tokenSolicitacaoOnId}")
    End Function

    Public Overrides Function GetByIdList(tokenSolicitacaoOnId As Integer) As List(Of TokenSolicitacaoOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(TabelaView, columns, $"AND id_solicitacao = {tokenSolicitacaoOnId}")
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of TokenSolicitacaoOnDTO)
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarLista(Tabela, columns, condicao)
    End Function

    Public Overrides Function GetAllDt() As DataTable
        Dim columns As New Dictionary(Of String, Object)()
        Return BuscarDataTable(TabelaView, columns, "")
    End Function

    Public Overrides Function GetById(id As String) As TokenSolicitacaoOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of TokenSolicitacaoOnDTO) = BuscarLista(TabelaView, columns, $"AND id_solicitacao = '{id}'")
        Return lista.FirstOrDefault(Function(t) t.Id = id)
    End Function

    Public Overrides Function GetByPart(part As String) As TokenSolicitacaoOnDTO
        Dim columns As New Dictionary(Of String, Object)()
        Dim lista As List(Of TokenSolicitacaoOnDTO) = BuscarLista(Tabela, columns, $"AND nome = '{part}' LIMIT 1")
        Return lista.FirstOrDefault(Function(t) t.Nome = part)
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As TokenSolicitacaoOnDTO
        Dim tokenSolicitacaoOn As New TokenSolicitacaoOnDTO()

        ' Verifica se o campo "id_solicitacao" é um inteiro e está presente
        If Not reader.IsDBNull(reader.GetOrdinal("id_solicitacao")) Then
            tokenSolicitacaoOn.Id = reader.GetInt32(reader.GetOrdinal("id_solicitacao"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("nome")) Then
            tokenSolicitacaoOn.Nome = reader.GetString(reader.GetOrdinal("nome"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("email")) Then
            tokenSolicitacaoOn.Email = reader.GetString(reader.GetOrdinal("email"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("telefone")) Then
            tokenSolicitacaoOn.Telefone = reader.GetString(reader.GetOrdinal("telefone"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("igreja")) Then
            tokenSolicitacaoOn.Igreja = reader.GetString(reader.GetOrdinal("igreja"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("cidade")) Then
            tokenSolicitacaoOn.Cidade = reader.GetString(reader.GetOrdinal("cidade"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("setor")) Then
            tokenSolicitacaoOn.Setor = reader.GetString(reader.GetOrdinal("setor"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("admlc")) Then
            tokenSolicitacaoOn.AdmLc = reader.GetString(reader.GetOrdinal("admlc"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("status")) Then
            tokenSolicitacaoOn.Status = reader.GetInt32(reader.GetOrdinal("status"))
        End If

        If Not reader.IsDBNull(reader.GetOrdinal("data")) Then
            tokenSolicitacaoOn.Data = reader.GetDateTime(reader.GetOrdinal("data"))
        End If

        Return tokenSolicitacaoOn
    End Function

    ' Função auxiliar para verificar se a coluna existe no DataReader
    Private Function ColumnExists(reader As Common.DbDataReader, columnName As String) As Boolean
        Try
            Dim ordinal As Integer = reader.GetOrdinal(columnName)
            Return True
        Catch ex As IndexOutOfRangeException
            ' Coluna não existe
            Return False
        End Try
    End Function

End Class
