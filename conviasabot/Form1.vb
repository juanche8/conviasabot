Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reader As New StreamReader("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config.js")
        Dim content As String = reader.ReadToEnd()
        reader.Close()

        Dim replacetext = "to: '" & mailbox.Text
        dim primero = content.substring(191)
        Dim stringPart = content.Substring(primero, content.IndexOf("'"))
        content = Regex.Replace(content, stringPart, replacetext)

        Dim writer As New StreamWriter("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config.js")
        writer.Write(content)
        writer.Close() ' comments
        Dim consola As string
    End Sub
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub mailbox_TextChanged(sender As Object, e As EventArgs) Handles mailbox.TextChanged

    End Sub
End Class
