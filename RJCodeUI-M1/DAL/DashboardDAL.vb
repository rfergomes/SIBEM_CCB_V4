'Última Atualização:    09/12/2024
'Data:                  09/12/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class DashboardDAL
    Inherits GenericDAL(Of DashboardDTO)

    Private SQLite As New ConnectionFactory

    Private Tabela = ""

    Public Sub New(connectionFactory As ConnectionFactory)
        MyBase.New(connectionFactory)
    End Sub

    Public Overrides Function Insert(status As DashboardDTO) As Long
        Throw New NotImplementedException()
    End Function

    Public Overrides Sub Delete(statusId As String)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Update(status As DashboardDTO)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function GetByIdDt(statusId As Integer) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByIdList(statusId As String) As List(Of DashboardDTO)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetAllList(Optional condicao As String = "") As List(Of DashboardDTO)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetAllDt(Optional condicao As String = "") As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetById(id As String) As DashboardDTO
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetByPart(part As String) As DashboardDTO
        Throw New NotImplementedException()
    End Function

    Protected Overrides Function ConvertFromReader(reader As Common.DbDataReader) As DashboardDTO
        Throw New NotImplementedException()
    End Function

    Public Function ObterDadosDashboard(ano As Integer, setor As String) As DashboardDTO
        Try
            ' Validar entrada
            If ano <= 0 Then Throw New ArgumentException("O ano informado é inválido.")
            'If String.IsNullOrEmpty(setor) Then setor = "Todos" ' Caso o setor não seja especificado, considerar "Todos"

            ' Instanciar BLLs
            Dim SetoresBLL As New SetoresBLL(SQLite)
            Dim IgrejasBLL As New IgrejasBLL(SQLite)
            Dim InventariosBLL As New InventariosBLL(SQLite)
            Dim SituacaoSetorBLL As New SituacaoSetorBLL(SQLite)

            ' Buscar dados
            Dim Setores As List(Of SetoresDTO) = SetoresBLL.BuscarTodos(setor)
            Dim Igrejas As List(Of IgrejasDTO) = IgrejasBLL.BuscarTodos(setor)
            Dim Inventarios As List(Of InventariosDTO) = InventariosBLL.BuscarTodos(ano, setor)
            Dim SituacaoSetor As List(Of SituacaoSetorDTO) = SituacaoSetorBLL.BuscarTodos(ano, setor)

            ' Garantir que listas não sejam nulas
            If Setores Is Nothing Then Setores = New List(Of SetoresDTO)
            If Igrejas Is Nothing Then Igrejas = New List(Of IgrejasDTO)
            If Inventarios Is Nothing Then Inventarios = New List(Of InventariosDTO)
            If SituacaoSetor Is Nothing Then SituacaoSetor = New List(Of SituacaoSetorDTO)

            ' Calcular indicadores
            Dim IgrejasAtivas As List(Of IgrejasDTO) = Igrejas.Where(Function(item) item.Id_Tipo = 15 AndAlso item.Id_Status = 1).ToList()
            Dim IgrejasInativas As List(Of IgrejasDTO) = Igrejas.Where(Function(item) item.Id_Tipo = 15 AndAlso item.Id_Status = 0).ToList()
            Dim Departamentos As List(Of IgrejasDTO) = Igrejas.Where(Function(item) item.Id_Tipo <> 15 AndAlso item.Id_Status = 1).ToList()
            Dim InventariosRealizados As List(Of InventariosDTO) = Inventarios.Where(Function(item) item.Situacao = "Finalizado" AndAlso Year(item.Data) = ano).ToList()
            Dim IgrejasPorSetor As Dictionary(Of String, Integer) = Igrejas.GroupBy(Function(i) i.Setor).ToDictionary(Function(grupo) grupo.Key, Function(grupo) grupo.Count())
            Dim InventariosPorSetor As Dictionary(Of String, Integer) = InventariosRealizados.GroupBy(Function(i) i.Setor).ToDictionary(Function(grupo) grupo.Key, Function(grupo) grupo.Count())
            Dim UltimosInventarios As List(Of InventariosDTO) = Inventarios.OrderByDescending(Function(item) item.Data).Take(5).ToList()
            Dim InventariosPorMes = Inventarios.GroupBy(Function(i) i.Data.Month).ToDictionary(Function(g) g.Key, Function(g) g.Count())

            Dim resultado As New Dictionary(Of Integer, Integer)
            For mes As Integer = 1 To 12
                If InventariosPorMes.ContainsKey(mes) Then
                    resultado.Add(mes, InventariosPorMes(mes))
                Else
                    resultado.Add(mes, 0)
                End If
            Next

            ' Preencher DTO do dashboard
            Dim dashboard As New DashboardDTO With {
                .Setores = Setores.Count,
                .IgrejasAtivas = IgrejasAtivas.Count,
                .IgrejasInativas = IgrejasInativas.Count,
                .Departamentos = Departamentos.Count,
                .InventariosRealizados = InventariosRealizados.Count,
                .IgrejasPorSetor = IgrejasPorSetor,
                .InventariosPorSetor = InventariosPorSetor,
                .InventariosPorAno = resultado,
                .UltimosInventarios = UltimosInventarios,
                .SituacaoPorSetor = SituacaoSetor
            }

            Return dashboard

        Catch ex As Exception
            ' Logar e rethrow para tratamento em camadas superiores
            Throw New Exception($"Erro ao obter dados do dashboard: {ex.Message}")
            Throw
        End Try
    End Function


End Class
