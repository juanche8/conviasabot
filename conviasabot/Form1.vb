Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabNavigationPage1.PageText = "Email"
        TabNavigationPage2.PageText = "Fechas"
        TabNavigationPage3.PageText = "index.js"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reader As New StreamReader("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js") 'directorio de prueba. podra ser un reader global.
        Dim content As String = reader.ReadToEnd()
        reader.Close()
               Dim replacetext = vbTab & vbtab & "to: '" & mailbox.Text & "',"
        dim primero = content.substring(191)
        Dim lineas() As String = File.ReadAllLines("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
                content = Regex.Replace(content, lineas(6), replacetext)
               Dim writer As New StreamWriter("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        writer.Write(content)
        writer.Close() ' comments push test
         End Sub
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim reader As New StreamReader("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        Dim content As String = reader.ReadToEnd()
        reader.Close()
        Dim tab = vbTab+vbTab+vbTab
        Dim fecha1 =tab+ """B_DATE_1"": """  + Format(DateEdit1.DateTime, "yyyyMMdd1200")+""""+","
        Dim fecha2 =tab+ """B_DATE_2"": """  + Format(DateEdit2.DateTime, "yyyyMMdd0000")+""""+","
        Dim fecha3 =tab+ """fecha_desde"": """  +DateEdit1.Text+""""+","
        Dim fecha4 =tab+ """fecha_hasta"": """  +DateEdit2.text+""""+","
        Dim lineas() As String = File.ReadAllLines("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        
        content = Regex.Replace(content, lineas(40), fecha1)
        content = Regex.Replace(content, lineas(41), fecha2)
        content = Regex.Replace(content , lineas(43), fecha3)
        content = Regex.Replace(content , lineas(44), fecha4)
        Dim writer As New StreamWriter("C:\Users\juanyoris\Documents\GitHub\conviasa-bot\config2.js")
        writer.Write(content)
        writer.Close()
       ' Format(DateEdit2.DateTime, "yyyyMMdd0000")
        Label4.Text = "DESDE EL DIA "+ DateEdit1.Text + " HASTA " + DateEdit2.DateTime  
    End Sub
End Class
