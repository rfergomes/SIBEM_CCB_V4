﻿'Última Atualização:    11/10/2024
'Data:                  11/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Friend Class BensBLL

    Private ReadOnly bensDAL As BensDAL
    Private ReadOnly connectionFactory As ConnectionFactory

    Public Sub New()

    End Sub

    Public Sub New(banco As ConnectionFactory)
        connectionFactory = banco
        bensDAL = New BensDAL(connectionFactory)

    End Sub

    Public Function Inserir(bens As BensDTO) As Integer
        Try
            ' Validação dos dados do bens (opcional)
            Return bensDAL.Insert(bens)
        Catch ex As Exception
            Throw New Exception("Erro ao inserir bens. - " & ex.Message, ex)
        End Try
    End Function

    Public Sub Excluir(bensId As Integer)
        Try
            ' Validação do ID do bens (opcional)
            bensDAL.Delete(bensId)
        Catch ex As Exception
            Throw New Exception("Erro ao excluir bens." & vbNewLine & ex.Message, ex)
        End Try
    End Sub

    Public Function Atualizar(bens As BensDTO) As Integer
        Try
            ' Validação dos dados do bens (opcional)
            Return bensDAL.Update(bens)
        Catch ex As Exception
            Throw New Exception("Erro ao atualizar bens." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function Contar(Optional Id_Igreja As String = "") As Long
        Try
            If String.IsNullOrEmpty(Id_Igreja) Then
                Return bensDAL.GetCount()
            Else
                Return bensDAL.GetCount($"AND id_igreja = '{Id_Igreja}' AND id_status = 1")
            End If

        Catch ex As Exception
            Throw New Exception("CONTAR: Erro ao contar coluna." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorNome(Nome As String) As BensDTO
        Try
            ' Validação do Nome do bens (opcional)
            Return bensDAL.GetByPart(Nome)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar bens." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarListaPorId(bensId As Integer) As List(Of BensDTO)
        Try
            ' Validação do ID do bens (opcional)
            Return bensDAL.GetByIdList(bensId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar bens." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarPorId(bensId As String) As BensDTO
        Try
            ' Validação do ID do inventarios (opcional)
            Return bensDAL.GetById(bensId)
        Catch ex As Exception
            Throw New Exception("Erro ao buscar Inventário." & vbNewLine & ex.Message, ex)
        End Try
    End Function

    Public Function BuscarTodos(Optional Setor As String = "", Optional Igreja As String = "",
                            Optional Bem As String = "", Optional Dependencia As String = "") As List(Of BensDTO)
        Dim Filtro As New Text.StringBuilder()

        ' Verifica o filtro por Setor
        If Not String.IsNullOrEmpty(Setor) Then
            Filtro.Append($"AND cod_setor = '{Setor}'")
        End If

        ' Verifica o filtro por Igreja
        If Not String.IsNullOrEmpty(Igreja) Then
            Filtro.Append(" AND ")
            Filtro.Append($"(id_igreja = '{Igreja}' OR igreja LIKE '%{Igreja}%')")
        End If

        ' Verifica o filtro por Bem
        If Not String.IsNullOrEmpty(Bem) Then
            Filtro.Append(" AND ")
            Filtro.Append($"(id_bem LIKE '%{Bem}%' OR descricao LIKE '%{Bem}%')")
        End If

        ' Verifica o filtro por Dependência
        If Not String.IsNullOrEmpty(Dependencia) Then
            Filtro.Append(" AND ")
            Filtro.Append($"(id_dependencia LIKE '%{Dependencia}%' OR dependencia LIKE '%{Dependencia}%')")
        End If
        Filtro.Append($" AND id_admlc = {VarGlob.SistemaAtivo.Id_Admlc}")
        Try
            ' Verifica se foi fornecido algum filtro
            If Filtro.Length = 0 Then
                ' Se não houver filtro, retorna todos os itens
                Return bensDAL.GetAllList()
            Else
                ' Se houver um filtro, aplica a busca filtrada
                Return bensDAL.GetAllList(Filtro.ToString())
            End If
        Catch ex As Exception
            RJMessageBox.Show("Erro ao buscar Bens." & vbNewLine & ex.ToString() & vbNewLine & ex.Message, ex.TargetSite.ToString())
            Return Nothing
        End Try
    End Function

End Class
