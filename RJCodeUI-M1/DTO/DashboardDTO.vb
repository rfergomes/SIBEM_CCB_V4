Public Class DashboardDTO
    ' Indicadores
    Public Property Setores As Integer
    Public Property IgrejasAtivas As Integer
    Public Property IgrejasInativas As Integer
    Public Property Departamentos As Integer
    Public Property InventariosRealizados As Integer

    ' Dados para os gráficos
    Public Property IgrejasPorSetor As Dictionary(Of String, Integer) ' Setor -> Total Igrejas
    Public Property InventariosPorSetor As Dictionary(Of String, Integer) ' Setor -> Total Inventários
    Public Property InventariosPorAno As Dictionary(Of Integer, Integer) ' Ano -> Total Inventários

    ' Dados para as tabelas
    Public Property UltimosInventarios As List(Of InventariosDTO)
    Public Property SituacaoPorSetor As List(Of SituacaoSetorDTO)
End Class
