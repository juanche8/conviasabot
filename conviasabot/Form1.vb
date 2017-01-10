Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reader As New StreamReader("D:\Juan Jose\Escritorio\test\conviasa-bot\config.js")
        Dim content As String = reader.ReadToEnd()
        reader.Close()

        Dim replacetext = "to: '" & mailbox.Text
        dim primero = content.substring(191)
        Dim stringPart = content.Substring(primero, content.IndexOf("'"))
        content = Regex.Replace(content, stringPart, replacetext)

        Dim writer As New StreamWriter("D:\Juan Jose\Escritorio\test\conviasa-bot \config.js")
        writer.Write(content)
        writer.Close() ' comments
        Dim consola As string
    End Sub
End Class
