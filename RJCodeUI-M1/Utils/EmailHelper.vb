Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Vip.Notification

Public Class EmailHelper
    ' Método público para enviar e-mails
    Public Shared Function EnviarEmail(Assunto As String, Mensagem As String, Destinatario As String, Optional DestinatarioCopia As String = "") As Boolean
        Try
            ' Configuração do e-mail
            Dim mail As New MailMessage()
            mail.From = New MailAddress("SIBEM CCB<contato@sibem.online>")
            mail.To.Add(Destinatario)
            If Not String.IsNullOrEmpty(DestinatarioCopia) Then mail.CC.Add(DestinatarioCopia)
            mail.Subject = Assunto
            mail.Body = Mensagem
            mail.IsBodyHtml = True ' Defina como True se quiser enviar em formato HTML

            ' Configuração do servidor SMTP
            Dim smtpServer As New SmtpClient("smtp.gmail.com") ' Substitua pelo servidor SMTP do seu provedor
            smtpServer.Port = 587 ' Porta comum para SMTP com STARTTLS
            smtpServer.Credentials = New NetworkCredential("rfergomes@gmail.com", "xemk emvk akhn jirp")
            smtpServer.EnableSsl = True ' Ativa a segurança SSL/TLS

            ' Envia o e-mail
            smtpServer.Send(mail)
            Return True ' Retorna True se o e-mail for enviado com sucesso

        Catch ex As Exception
            Throw New Exception($"Falha ao enviar o e-mail: {vbNewLine & ex.Message}")
            Return False ' Retorna False se houver um erro
        End Try
    End Function
End Class

