'Última Atualização:    18/10/2024
'Data:                  18/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Text

Public Class InventariosOnBLL
    Private ReadOnly InventariosOnDAL As InventariosOnDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        InventariosOnDAL = New InventariosOnDAL(connectionFactory)
    End Sub

    Public Function Inserir(inventarios As InventariosOnDTO) As Long
        Try
            ' Validação dos dados do inventarios (opcional)
            Return InventariosOnDAL.Insert(inventarios)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Sub Excluir(inventariosId As Integer)
        Try
            ' Validação do ID do inventarios (opcional)
            InventariosOnDAL.Delete(inventariosId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(inventarios As InventariosOnDTO)
        Try
            ' Validação dos dados do inventarios (opcional)
            InventariosOnDAL.Update(inventarios)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorId(inventariosId As String) As InventariosOnDTO
        Try
            ' Validação do ID do inventarios (opcional)
            Return InventariosOnDAL.GetById(inventariosId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(inventariosId As Integer) As List(Of InventariosOnDTO)
        Try
            ' Validação do ID do inventarios (opcional)
            Return InventariosOnDAL.GetByIdList(inventariosId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Ano As String = "", Optional Setor As String = "", Optional Abertos As String = "", Optional TextoPesquisa As String = "") As List(Of InventariosOnDTO)
        Dim condicao As New StringBuilder()

        Try
            ' Monta a query condicionalmente
            If Not String.IsNullOrEmpty(Ano) Then
                condicao.Append($" AND strftime('%Y', data) = '{Ano}'")
            End If
            If Not String.IsNullOrEmpty(Setor) Then
                condicao.Append($" AND setor = '{Setor}'")
            End If
            If Not String.IsNullOrEmpty(Abertos) Then ' Verifica se o valor de Ativos é válido
                condicao.Append($" AND situacao = '{Abertos}'")
            End If
            If Not String.IsNullOrEmpty(TextoPesquisa) Then
                condicao.Append($" AND (id_inventario LIKE '%{TextoPesquisa}%' OR igreja LIKE '%{TextoPesquisa}%')")
            End If
            condicao.Append($" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc} ORDER BY id_igreja")
            ' Faz a busca com a condição montada
            Return InventariosOnDAL.GetAllList(condicao.ToString())
        Catch ex As Exception
            MsgBox("Erro ao buscar Inventário." & vbNewLine & ex.ToString(), MsgBoxStyle.Critical)
        End Try

        Return New List(Of InventariosOnDTO)()
    End Function

    Public Function Contar()
        Try
            Return InventariosOnDAL.GetCount("id_inventario")
        Catch ex As Exception
            Throw New Exception("CONTAR: Erro ao contar coluna." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function Maximo()
        Try
            Return InventariosOnDAL.GetMax("id_inventario", " AND ")
        Catch ex As Exception
            Throw New Exception("MÁXIMO: Erro ao buscar valor máximo." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function UltimoIdCadastrado(id_igreja As Integer) As Long
        Try
            Return InventariosOnDAL.GetMax("id_inventario", $" AND id_igreja ={id_igreja}")
        Catch ex As Exception
            Throw New Exception("UltimoIdCadastrado: Erro ao buscar último Id Cadastrado." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaAnos() As List(Of List(Of String))
        Try
            ' Validação do ID do inventarios (opcional)
            Return InventariosOnDAL.GetYearList()
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Anos." & vbNewLine & ex.Message, ex)
        End Try
    End Function

End Class
