Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Text

Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Form_Verifikation.ProfidUser = tbUser.Text
        Form_Verifikation.ProfidPassword = tbPassword.Text
        Me.Close()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form_Verifikation.ProfidUser = ""
        Form_Verifikation.ProfidPassword = ""
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If tbPassword.PasswordChar = "*" Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUser.Text = ""
        tbPassword.Text = ""
        tbPassword.PasswordChar = "*"
    End Sub

    Public Sub bTest_Click() Handles bTest.Click
        Form_Verifikation.ProfidUser = tbUser.Text
        Form_Verifikation.ProfidPassword = tbPassword.Text

        'für JSON
        Dim Uri As New Uri("https://as400.becom.at:11443/api/v1/sql/query")
        Dim data As Byte()
        Dim Test As Integer = 0

        On Error GoTo Verbindungsfehler
        '#######   Abfrage Zähler ICT   ########################
        'data = Encoding.UTF8.GetBytes("{""Query"":""select count(*) AS Anzahl from AS400.BEC001ASP2.rrp0pf where rpisnr = '1402405018468' AND RPSART ='6253'""}")
        data = Encoding.UTF8.GetBytes("{""Query"":""Select COUNT(*) As Anzahl FROM BEC001ASP2.RKO0PF FETCH FIRST 5 ROWS ONLY""}")
        Dim result_post = SendRequest(Uri, data, "application/json", "POST")
        Dim json As JObject = JObject.Parse(result_post)

        For Each Row In json("data").ToList()
            Test = CInt(Row("ANZAHL"))
        Next
Verbindungsfehler:
        If Test > 0 Then
            MsgBox("Verbindungstest erfolgreich")
        Else
            MsgBox("Verbindungstest fehlgeschlagen")
        End If

    End Sub
    Public Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim response As String
        Dim request As HttpWebRequest

        request = HttpWebRequest.Create(uri)
        Dim Encoded As String = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Form_Verifikation.ProfidUser & ":" & Form_Verifikation.ProfidPassword))

        request.Headers.Add("Authorization", "Basic " + Encoded)
        request.ContentLength = jsonDataBytes.Length
        request.ContentType = contentType
        request.Accept = contentType
        request.Method = method
        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        ServicePointManager.ServerCertificateValidationCallback = Function(sender, cert, chain, sllPolicyErrors) True

        Using requestStream = request.GetRequestStream
            requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
            requestStream.Close()
            Using responseStream = request.GetResponse.GetResponseStream
                Using reader As New StreamReader(responseStream)
                    response = reader.ReadToEnd()
                End Using
            End Using
        End Using

        Return response
    End Function

End Class
