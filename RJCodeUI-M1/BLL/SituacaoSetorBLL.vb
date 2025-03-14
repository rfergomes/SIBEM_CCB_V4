Imports DynamicData
Imports System.Text

Public Class SituacaoSetorBLL
    Private ReadOnly situacaoSetorDAL As SituacaoSetorDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        situacaoSetorDAL = New SituacaoSetorDAL(connectionFactory)
    End Sub

    Public Sub Inserir(situacaoSetor As SituacaoSetorDTO)
        Try
            ' Validação dos dados do situacaoSetor (opcional)
            situacaoSetorDAL.Insert(situacaoSetor)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir situacaoSetor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(situacaoSetorId As Integer)
        Try
            ' Validação do ID do situacaoSetor (opcional)
            situacaoSetorDAL.Delete(situacaoSetorId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir situacaoSetor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(situacaoSetor As SituacaoSetorDTO)
        Try
            ' Validação dos dados do situacaoSetor (opcional)
            situacaoSetorDAL.Update(situacaoSetor)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar situacaoSetor." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorNome(Nome As String) As SituacaoSetorDTO
        Try
            ' Validação do Nome do situacaoSetor (opcional)
            Return situacaoSetorDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar situacaoSetor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(situacaoSetorId As Integer) As List(Of SituacaoSetorDTO)
        Try
            ' Validação do ID do situacaoSetor (opcional)
            Return situacaoSetorDAL.GetByIdList(situacaoSetorId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar situacaoSetor." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Ano As Integer, Optional Setor As String = "") As List(Of SituacaoSetorDTO)
        Try
            Dim Query As New StringBuilder
            Dim administracao As String = If(VarGlob.SistemaAtivo IsNot Nothing, $"AND id_admlc ={VarGlob.SistemaAtivo.Id_Admlc}", String.Empty)
            Query.Append($"AND ano = '{Ano}' ")

            If Not String.IsNullOrWhiteSpace(Setor) Then
                Query.Append($"AND  (cod_setor LIKE '{Setor}%' OR descricao LIKE '%{Setor}%')")
            End If

            ' Adiciona a condição de administração, se aplicável
            If Not String.IsNullOrEmpty(administracao) Then
                Query.Append($" {administracao} ")
            End If

            ' Se houver um filtro, aplica a busca filtrada
            Return situacaoSetorDAL.GetAllList(Query.ToString)

        Catch ex As Exception
            MsgBox("Erro ao buscar situacaoSetor." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
