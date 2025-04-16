'Última Atualização:    25/10/2024
'Data:                  25/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Text

Public Class InventarioDetalhesBLL
    Private ReadOnly inventarioDetalhesDAL As InventarioDetalhesDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        inventarioDetalhesDAL = New InventarioDetalhesDAL(connectionFactory)
    End Sub

    Public Function Inserir(inventarioDetalhes As InventarioDetalhesDTO) As Integer
        Try
            ' Validação dos dados do InventarioDetalhes (opcional)
            Return inventarioDetalhesDAL.Insert(inventarioDetalhes)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Sub Excluir(inventarioDetalhesId As String)
        Try
            ' Validação do ID do InventarioDetalhes (opcional)
            inventarioDetalhesDAL.Delete(inventarioDetalhesId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function Atualizar(inventarioDetalhes As InventarioDetalhesDTO) As Integer
        Try
            ' Validação dos dados do InventarioDetalhes (opcional)
            Return inventarioDetalhesDAL.Update(inventarioDetalhes)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(inventarioDetalhesId As String) As InventarioDetalhesDTO
        Try
            ' Validação do ID do InventarioDetalhes (opcional)
            Return inventarioDetalhesDAL.GetById(inventarioDetalhesId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(inventarioDetalhesId As Integer) As List(Of InventarioDetalhesDTO)
        Try
            ' Validação do ID do InventarioDetalhes (opcional)
            Return inventarioDetalhesDAL.GetByIdList(inventarioDetalhesId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional TextoPesquisa As String = "", Optional Consultas As String = "") As List(Of InventarioDetalhesDTO)
        Dim condicao As New StringBuilder()
        Dim Tabela As String = ""
        Try
            ' Monta a query condicionalmente
            If Not String.IsNullOrEmpty(TextoPesquisa) Then
                condicao.Append($" AND (id_bem LIKE '%{TextoPesquisa}%' OR bem LIKE '%{TextoPesquisa}%')")
            End If

            Select Case (Consultas)
                Case "BENS TOTALIZADOS"
                    condicao.Clear()
                    Tabela = "lista_inventario_detalhes_totalizado"
                    condicao.Append($" AND bem LIKE '%{TextoPesquisa}%'")

                Case "BENS LOCALIZADOS"
                    condicao.Clear()
                    condicao.Append($" AND situacao = 'OK' AND bem LIKE '%{TextoPesquisa}%'")

                Case "BENS PENDENTES"
                    condicao.Clear()
                    condicao.Append($" AND situacao <> 'OK' AND bem LIKE '%{TextoPesquisa}%'")

                Case "LIDOS REPETIDOS"
                    condicao.Clear()
                    condicao.Append($" AND cont >1  AND bem LIKE '%{TextoPesquisa}%'")

                Case "LISTA PENDENTES"
                    condicao.Clear()
                    condicao.Append($" AND acao='PENDENTE' AND (id_bem LIKE '%{TextoPesquisa}%' OR bem LIKE '%{TextoPesquisa}%')")

                Case "LISTA RESOLVIDOS"
                    condicao.Clear()
                    condicao.Append($" AND situacao <> 'OK' AND acao NOT IN('OK','PENDENTE')")

                Case "LISTA PENDENTES TODOS"
                    condicao.Clear()
                    condicao.Append($" AND situacao = 'PENDENTE' AND (id_bem LIKE '%{TextoPesquisa}%' OR bem LIKE '%{TextoPesquisa}%')")
                Case Else
                    Tabela = "lista_inventario_detalhes"
            End Select

            condicao.Append($" AND id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
            ' Faz a busca com a condição montada
            Return inventarioDetalhesDAL.GetAllListByTable(Tabela, condicao.ToString())
        Catch ex As Exception
            MsgBox("Erro ao buscar Inventário." & vbNewLine & ex.ToString(), MsgBoxStyle.Critical)
        End Try

        Return New List(Of InventarioDetalhesDTO)()
    End Function

    Public Function BuscarAcoes() As List(Of List(Of String))
        Try
            Return inventarioDetalhesDAL.GetGenericList("lista_inventario_detalhes_acao", $" id_inventario = '{VarGlob.Id_Inventario_Ativo}'")
        Catch ex As Exception
            MsgBox("Erro ao buscar Lista." & vbNewLine & ex.ToString(), MsgBoxStyle.Critical)
        End Try
        Return New List(Of List(Of String))
    End Function

End Class
