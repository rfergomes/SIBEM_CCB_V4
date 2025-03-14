Public Class SincronizarDTO
    Public Property Id As Integer
    Public Property Id_Tabela As String
    Public Property Tabela As String
    Public Property Acao As String ' "Local" ou "Remoto"
    Public Property Status As Integer ' 0 = Pendente, 1 = Sincronizado
    Public Property Tipo_Operacao As String ' Inserir, Atualizar, Excluir
    Public Property Data_Atualizacao As DateTime
    Public Property Id_Admlc As Integer ' ID da Administração Local
End Class
