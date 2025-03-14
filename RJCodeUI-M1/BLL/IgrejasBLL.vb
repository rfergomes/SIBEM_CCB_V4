'Última Atualização:    04/10/2024
'Data:                  04/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Text

Public Class IgrejasBLL
    Private ReadOnly igrejasDAL As IgrejasDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        igrejasDAL = New IgrejasDAL(connectionFactory)
    End Sub

    Public Sub Inserir(igrejas As IgrejasDTO)
        Try
            ' Validação dos dados do igrejas (opcional)
            igrejasDAL.Insert(igrejas)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(igrejasId As Integer)
        Try
            ' Validação do ID do igrejas (opcional)
            igrejasDAL.Delete(igrejasId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(igrejas As IgrejasDTO)
        Try
            ' Validação dos dados do igrejas (opcional)
            igrejasDAL.Update(igrejas)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorId(igrejasId As String) As IgrejasDTO
        Try
            ' Validação do ID do igrejas (opcional)
            Return igrejasDAL.GetById(igrejasId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(igrejasId As Integer) As List(Of IgrejasDTO)
        Try
            ' Validação do ID do igrejas (opcional)
            Return igrejasDAL.GetByIdList(igrejasId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "", Optional Ativas As Boolean = False) As List(Of IgrejasDTO)
        Try
            Dim Query As New StringBuilder
            Dim administracao As String = If(VarGlob.SistemaAtivo IsNot Nothing, $"AND id_admlc ={VarGlob.SistemaAtivo.Id_Admlc}", String.Empty)
            Dim IgrejasAtivas As String = If(Ativas, $" AND id_status = 1 ", "")

            If Not String.IsNullOrWhiteSpace(Filtro) Then
                Query.Append($"AND (igreja LIKE '%{Filtro}%' OR id_igreja LIKE '%{Filtro}%' OR bairro LIKE '%{Filtro}%' OR cidade LIKE '%{Filtro}%' OR setor = '{Filtro}' OR cod_setor = '{Filtro}' OR  status LIKE '{Filtro}%')")
            End If

            If Ativas Then
                Query.Append($" {IgrejasAtivas} ")
            End If

            ' Adiciona a condição de administração, se aplicável
            If Not String.IsNullOrEmpty(administracao) Then
                Query.Append($" {administracao} ")
            End If

            ' Se não houver filtro, retorna todos os itens
            Return igrejasDAL.GetAllList(Query.ToString)

        Catch ex As Exception
            MsgBox($"Erro ao buscar Casa de Oração. {vbNewLine} {ex.Message} {vbNewLine} {ex.Message}", MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorAdministracao(Id_Admlc As String) As List(Of IgrejasDTO)
        Try
            ' Se não houver filtro, retorna todos os itens
            Return igrejasDAL.GetAllList($"AND id_admlc = {Id_Admlc}")
        Catch ex As Exception
            MsgBox($"Erro ao buscar Casa de Oração.{vbNewLine} {ex.Message} {vbNewLine} {ex.Message}", MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorSetor(Optional Filtro As String = "", Optional Ativas As Boolean = False) As List(Of IgrejasDTO)

        Try
            Dim IgrejasAtivas As String = If(Ativas, $"AND id_status = 1 AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}", "")
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return igrejasDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return igrejasDAL.GetAllList($"AND cod_setor = '{Filtro}' {IgrejasAtivas}")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Casa de Oração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
