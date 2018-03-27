
Imports System.Net.Mail
Public Class Form2

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim mes As New MailMessage
        Try
            mes.From = New MailAddress("cenonserquina@gamil.com")
            '     mes()
        Catch ex As Exception

        End Try
    End Sub
End Class