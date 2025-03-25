'Última Atualização:    18/10/2024
'Data:                  18/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Public Class InventariosDTO
    Public Property Id As String
    Public Property Id_Igreja As String
    Public Property Igreja As String
    Public Property Cod_Setor As String
    Public Property Setor As String
    Public Property Data As DateTime
    Public Property Responsaveis As String
    Public Property Inventariantes As String
    Public Property Inicio As DateTime
    Public Property Termino As DateTime
    Public Property Duracao As TimeSpan
    Public Property Bens_Lidos As Integer
    Public Property Bens_Pendentes As Integer
    Public Property Bens_Novos As Integer
    Public Property Bens_Inicial As Integer
    Public Property Bens_Final As Integer
    Public Property Situacao As String
    Public Property Bens_Importado As Boolean
    Public Property Inventario_Teste As Boolean
    Public Property Id_AdmLc As Integer
    Public Property Siga_Ok As Boolean
    Public Property Data_Alteracao As Date
End Class
