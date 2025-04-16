Imports System.IO

Public Class Logger
    Private logFilePath As String = Path.Combine(Application.StartupPath, "Files", "SIBEM_Log.txt")

    ' Método para registrar uma mensagem no arquivo de log
    Public Sub WriteLog(message As String)
        Try
            ' Adiciona a data e hora à mensagem
            Dim logMessage As String = $"{DateTime.Now}: {message}"

            ' Escreve a mensagem no arquivo de log
            File.AppendAllText(logFilePath, logMessage & Environment.NewLine)
        Catch ex As Exception
            ' Caso ocorra erro ao escrever o log
            Throw New Exception($"Erro ao escrever no log: {ex.Message}")
        End Try
    End Sub
End Class

