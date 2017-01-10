Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reader As New StreamReader("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        Dim content As String = reader.ReadToEnd()
        reader.Close()
        RichTextBox1.Text = content
        Dim replacetext = vbTab & vbtab & "to: '" & mailbox.Text & "',"
        dim primero = content.substring(191)
        Dim lineas() As String = File.ReadAllLines("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        Label1.Text = lineas(6)
        content = Regex.Replace(content, lineas(6), replacetext)
        

        Dim writer As New StreamWriter("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        writer.Write(content)
        writer.Close() ' comments
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
