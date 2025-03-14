'Última Atualização:    13/11/2024
'Data:                  13/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Text
Imports DynamicData

Public Class IgrejasOnBLL
    Private ReadOnly igrejasOnDAL As IgrejasOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        igrejasOnDAL = New IgrejasOnDAL(connectionFactory)
    End Sub

    Public Sub Inserir(igrejas As IgrejasOnDTO)
        Try
            ' Validação dos dados do igrejas (opcional)
            igrejasOnDAL.Insert(igrejas)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Excluir(igrejasId As Integer)
        Try
            ' Validação do ID do igrejas (opcional)
            igrejasOnDAL.Delete(igrejasId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(igrejas As IgrejasOnDTO)
        Try
            ' Validação dos dados do igrejas (opcional)
            igrejasOnDAL.Update(igrejas)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorId(igrejasId As String) As IgrejasOnDTO
        Try
            ' Validação do ID do igrejas (opcional)
            Return igrejasOnDAL.GetById(igrejasId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(igrejasId As Integer) As List(Of IgrejasOnDTO)
        Try
            ' Validação do ID do igrejas (opcional)
            Return igrejasOnDAL.GetByIdList(igrejasId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Casa de Oração." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Filtro As String = "", Optional Ativas As Boolean = False) As List(Of IgrejasOnDTO)
        Try
            Dim IgrejasAtivas As String = If(Ativas, $" AND id_status = 1", "")
            ' Verifica se foi fornecido algum filtro
            If String.IsNullOrEmpty(Filtro) Then
                ' Se não houver filtro, retorna todos os itens
                Return igrejasOnDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return igrejasOnDAL.GetAllList($"AND (igreja LIKE '%{Filtro}%' OR id_igreja LIKE '%{Filtro}%' OR bairro LIKE '%{Filtro}%' OR cidade LIKE '%{Filtro}%' OR setor = '{Filtro}' OR cod_setor = '{Filtro}' OR  status LIKE '{Filtro}%') {IgrejasAtivas}")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar Casa de Oração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorAdministracao(Id_Admlc As String) As List(Of IgrejasOnDTO)
        Try
            ' Se não houver filtro, retorna todos os itens
            Return igrejasOnDAL.GetAllList($"AND id_admlc = {Id_Admlc}")
        Catch ex As Exception
            MsgBox("Erro ao buscar Casa de Oração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

    Public Function BuscarPorSetor(Optional Filtro As String = "", Optional Ativas As Boolean = False) As List(Of IgrejasOnDTO)

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
            Return igrejasOnDAL.GetAllList(Query.ToString)

        Catch ex As Exception
            MsgBox("Erro ao buscar Casa de Oração." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
        Return Nothing
    End Function

End Class
