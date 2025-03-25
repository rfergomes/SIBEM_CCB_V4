'Última Atualização:    18/10/2024
'Data:                  18/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Text

Public Class InventariosBLL
    Private ReadOnly inventariosDAL As InventariosDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        inventariosDAL = New InventariosDAL(connectionFactory)
    End Sub

    Public Function Inserir(inventarios As InventariosDTO) As String
        Try
            ' Validação dos dados do inventarios (opcional)
            Return inventariosDAL.Insert(inventarios)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Sub Excluir(inventariosId As String)
        Try
            ' Validação do ID do inventarios (opcional)
            inventariosDAL.Delete(inventariosId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Sub Atualizar(inventarios As InventariosDTO)
        Try
            ' Validação dos dados do inventarios (opcional)
            inventariosDAL.Update(inventarios)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function BuscarPorId(inventariosId As String) As InventariosDTO
        Try
            ' Validação do ID do inventarios (opcional)
            Return inventariosDAL.GetById(inventariosId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(inventariosId As String) As List(Of InventariosDTO)
        Try
            ' Validação do ID do inventarios (opcional)
            Return inventariosDAL.GetByIdList(inventariosId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Ano As String = "", Optional Setor As String = "", Optional Abertos As String = "", Optional Siga_Ok As Boolean = False, Optional TextoPesquisa As String = "") As List(Of InventariosDTO)
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
                condicao.Append($" AND situacao = '{Abertos}' OR situacao = 'Reaberto'")
            End If
            If Siga_Ok Then ' Verifica se o valor de Ativos é válido
                condicao.Append($" AND siga_ok = {Siga_Ok}")
            End If

            If Not String.IsNullOrEmpty(TextoPesquisa) Then
                condicao.Append($" AND (id_inventario LIKE '%{TextoPesquisa}%' OR igreja LIKE '%{TextoPesquisa}%')")
            End If
            condicao.Append($" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
            ' Faz a busca com a condição montada
            Return inventariosDAL.GetAllList(condicao.ToString())
        Catch ex As Exception
            MsgBox("Erro ao buscar Inventário." & vbNewLine & ex.ToString(), MsgBoxStyle.Critical)
        End Try

        Return New List(Of InventariosDTO)()
    End Function

    Public Function BuscarListaDt(DataInicio As Date, DataFim As Date, Optional Setor As String = "") As DataTable
        Dim condicao As New StringBuilder()
        Try
            ' Monta a query condicionalmente
            If Not String.IsNullOrEmpty(Setor) Then
                condicao.Append($" AND (cod_setor = '{Setor}' OR setor LIKE '%{Setor}%')")
            End If
            condicao.Append($" AND date(data) BETWEEN date('{DataInicio.ToString("yyyy-MM-dd HH:mm:ss")}') AND date('{DataFim.ToString("yyyy-MM-dd HH:mm:ss")}') AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc} ORDER BY cod_setor")
            ' Faz a busca com a condição montada
            Return inventariosDAL.GetAllDt(condicao.ToString())
        Catch ex As Exception
            RJMessageBox.Show("Falha ao buscar lista de inventários", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End Try
    End Function

    Public Function Contar()
        Try
            Return inventariosDAL.GetCount("id_inventario")
        Catch ex As Exception
            Throw New Exception("CONTAR: Erro ao contar coluna." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function Maximo()
        Try
            Return inventariosDAL.GetMax($"id_inventario", $" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc} ")
        Catch ex As Exception
            Throw New Exception("MÁXIMO: Erro ao buscar valor máximo." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function UltimoIdCadastrado(id_igreja As String) As String
        Try
            Return inventariosDAL.GetMax("id_inventario", $" AND id_igreja ='{id_igreja}'")
        Catch ex As Exception
            Throw New Exception("UltimoIdCadastrado: Erro ao buscar último Id Cadastrado." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaAnos() As List(Of List(Of String))
        Try
            ' Validação do ID do inventarios (opcional)
            Return inventariosDAL.GetYearList()
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Anos." & vbNewLine & ex.Message, ex)
        End Try
    End Function

End Class
