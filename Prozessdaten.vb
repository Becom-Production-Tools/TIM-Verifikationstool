Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.ComponentModel
Imports System.Xml
Imports System.Xml.Linq
Imports System.Linq
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports Microsoft.SqlServer
Imports System.Net.Http

Public Class Prozessdaten
    Dim ISNR As String = Form_Verifikation.TextBoxISNR.Text
    Dim ErgTR3 As String

    Private Sub Prozessdaten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - 650, 70) 'Startposition Fenster
    End Sub
    Private Sub Prozessdaten_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Prozessdaten_abfragen()
    End Sub
    Public Async Sub Prozessdaten_abfragen()

        Try
            Dim Uri As New Uri("https://as400:11443/api/v1/sql/query")
            ''Höhe
            'Dim data = Encoding.UTF8.GetBytes("{""Query"":""select (PROWERT*1000000) as Wert, (PROLTL*1000000) as untereTol, (PROUTL*1000000) as obereTol, RTRIM(PROPOS) as Position, RTRIM(PROTYPE) as Type  from (SELECT ukop.*, upro.*, dense_rank() OVER(partition by kopisnr ORDER BY koptims desc) as dr from AS400.BEC001R426.UKOP UKOP, AS400.BEC001R426.UPRO UPRO WHERE UKOP.KOPID = UPRO.PROID AND (PROTYPE='10') AND UKOP.KOPISNR='" & ISNR & "' AND (UKOP.KOPANLNR='1097') ) where dr = 1""}")
            'Dim result_post = SendRequest(Uri, data, "application/json", "POST")
            'Dim json As JObject = JObject.Parse(result_post)
            'Dim dataTable As DataTable = GetDataTableFromJsonString(result_post)
            'dgv.DataSource = dataTable
            ''Fläche abfragen
            'Data = Encoding.UTF8.GetBytes("{""Query"":""select PROWERT as Wert, PROLTL as untereTol, PROUTL as obereTol, RTRIM(PROPOS) as Position, RTRIM(PROTYPE) as Type  from (SELECT ukop.*, upro.*, dense_rank() OVER(partition by kopisnr ORDER BY koptims desc) as dr from AS400.BEC001R426.UKOP UKOP, AS400.BEC001R426.UPRO UPRO WHERE UKOP.KOPID = UPRO.PROID AND (PROTYPE='25') AND UKOP.KOPISNR='" & ISNR & "' AND (UKOP.KOPANLNR='1097') ) where dr = 1""}")
            'result_post = SendRequest(Uri, data, "application/json", "POST")
            'dataTable = GetDataTableFromJsonString(result_post)
            'dgv2.DataSource = dataTable

            Dim jsonString As String
            'Höhe
            jsonString = "{""Query"":""select (PROWERT*1000000) as Wert, (PROLTL*1000000) as untereTol, (PROUTL*1000000) as obereTol, RTRIM(PROPOS) as Position, RTRIM(PROTYPE) as Type  from (SELECT ukop.*, upro.*, dense_rank() OVER(partition by kopisnr ORDER BY koptims desc) as dr from AS400.BEC001R426.UKOP UKOP, AS400.BEC001R426.UPRO UPRO WHERE UKOP.KOPID = UPRO.PROID AND (PROTYPE='10') AND UKOP.KOPISNR='" & ISNR & "' AND (UKOP.KOPANLNR='1097') ) where dr = 1""}"
            ' API-Request senden
            Dim result_post As String = Await SendRequestAsync(Uri.ToString(), jsonString, "application/json")
            ' API-Antwort validieren
            If String.IsNullOrWhiteSpace(result_post) Then
                MessageBox.Show("Leere Antwort von API erhalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            '' Daten in DataTable umwandeln
            'Dim dataTable As DataTable = GetDataTableFromJsonString(result_post)
            Dim dataTable As DataTable = ConvertXmlToDataTable(result_post)
            dgv.DataSource = dataTable

            'Fläche
            jsonString = "{""Query"":""select PROWERT as Wert, PROLTL as untereTol, PROUTL as obereTol, RTRIM(PROPOS) as Position, RTRIM(PROTYPE) as Type  from (SELECT ukop.*, upro.*, dense_rank() OVER(partition by kopisnr ORDER BY koptims desc) as dr from AS400.BEC001R426.UKOP UKOP, AS400.BEC001R426.UPRO UPRO WHERE UKOP.KOPID = UPRO.PROID AND (PROTYPE='25') AND UKOP.KOPISNR='" & ISNR & "' AND (UKOP.KOPANLNR='1097') ) where dr = 1""}"
            ' API-Request senden
            result_post = Await SendRequestAsync(Uri.ToString(), jsonString, "application/json")
            ' API-Antwort validieren
            If String.IsNullOrWhiteSpace(result_post) Then
                MessageBox.Show("Leere Antwort von API erhalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            '' Daten in DataTable umwandeln
            'Dim dataTable As DataTable = GetDataTableFromJsonString(result_post)
            dataTable = ConvertXmlToDataTable(result_post)
            dgv2.DataSource = dataTable


            dgv.Columns.Add("Auswertung", "Auswertung")
            dgv2.Columns.Add("Auswertung", "Auswertung")

            Dim cnt As Integer
            'Höhenwerte
            cnt = dgv.RowCount
            If cnt = 0 Then
                Label3.Visible = True
            Else
                Label3.Visible = False
            End If
            For i = 0 To cnt - 1
                If dgv.Rows(i).Cells(0).Value.ToString.Contains(".") Then
                    dgv.Rows(i).Cells(0).Value = Mid(dgv.Rows(i).Cells(0).Value, 1, InStr(1, dgv.Rows(i).Cells(0).Value, ".") - 1)
                End If
                If CInt(dgv.Rows(i).Cells(0).Value) < CInt(dgv.Rows(i).Cells(1).Value) Or CInt(dgv.Rows(i).Cells(0).Value) > CInt(dgv.Rows(i).Cells(2).Value) Then
                    dgv.Rows(i).Cells(5).Value = "NOK"
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                    dgv.Rows(i).Cells(5).Value = "OK"
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
            'Flächenwerte
            cnt = dgv2.RowCount
            If cnt = 0 Then
                Label4.Visible = True
            Else
                Label4.Visible = False
            End If
            For i = 0 To cnt - 1
                If CInt(dgv2.Rows(i).Cells(0).Value) < CInt(dgv2.Rows(i).Cells(1).Value) Then
                    dgv2.Rows(i).Cells(5).Value = "NOK"
                    dgv2.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                    dgv2.Rows(i).Cells(5).Value = "OK"
                    dgv2.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Fehler beim Abrufen der Prozessdaten: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox("Profid Benutzerdaten überprüfen und neu eingeben")
        End Try
    End Sub
    Public Function GetDataTableFromJsonString(json As String) As DataTable
        Dim jsonLinq = JObject.Parse(json)

        ' Find the first array using Linq
        Dim srcArray = jsonLinq.Descendants().Where(Function(d) TypeOf d Is JArray).First()
        Dim trgArray = New JArray()
        For Each row As JObject In srcArray.Children(Of JObject)()
            Dim cleanRow = New JObject()
            For Each column As JProperty In row.Properties()
                ' Only include JValue types
                If TypeOf column.Value Is JValue Then
                    cleanRow.Add(column.Name, column.Value)
                End If
            Next
            trgArray.Add(cleanRow)
        Next
        Return JsonConvert.DeserializeObject(Of DataTable)(trgArray.ToString())
    End Function
    Public Function ConvertXmlToDataTable(xmlString As String) As DataTable
        Dim dataSet As New DataSet()
        Using stringReader As New StringReader(xmlString)
            dataSet.ReadXml(stringReader)
        End Using

        ' Falls das XML mehrere Tabellen enthält, die erste nehmen
        If dataSet.Tables.Count > 0 Then
            Return dataSet.Tables(0)
        Else
            Return New DataTable() ' Leere Tabelle zurückgeben
        End If
    End Function
    Public Async Function SendRequestAsync(uri As String, jsonData As String, contentType As String) As Task(Of String)
        Using client As New HttpClient()
            Dim request As New HttpRequestMessage(HttpMethod.Post, uri)
            Dim credentials As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(Form_Verifikation.ProfidUser & ":" & Form_Verifikation.ProfidPassword))
            request.Headers.Add("Authorization", "Basic " & credentials)
            request.Content = New StringContent(jsonData, Encoding.UTF8, contentType)

            Dim response As HttpResponseMessage = Await client.SendAsync(request)

            If Not response.IsSuccessStatusCode Then
                MessageBox.Show("Fehler: " & response.StatusCode.ToString())
                Return ""
            End If

            Return Await response.Content.ReadAsStringAsync()
        End Using
    End Function
    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If dgv.CurrentRow.Cells(5).Value = "OK" Then
            dgv.CurrentRow.Cells(5).Value = "NOK"
            dgv.CurrentRow.DefaultCellStyle.BackColor = Color.Red
        ElseIf dgv.CurrentRow.Cells(5).Value = "NOK" Then
            dgv.CurrentRow.Cells(5).Value = "OK"
            dgv.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
        End If
        Me.Refresh()
        bÜbernahme_Click()
        Ampel_change()
    End Sub
    Private Sub dgv2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellDoubleClick
        If dgv2.CurrentRow.Cells(5).Value = "OK" Then
            dgv2.CurrentRow.Cells(5).Value = "NOK"
            dgv2.CurrentRow.DefaultCellStyle.BackColor = Color.Red
        ElseIf dgv2.CurrentRow.Cells(5).Value = "NOK" Then
            dgv2.CurrentRow.Cells(5).Value = "OK"
            dgv2.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
        End If
        Me.Refresh()
        bÜbernahme_Click()
        Ampel_change()
    End Sub
    Private Sub bÜbernahme_Click() Handles bÜbernahme.Click
        Dim cnt As Integer
        ErgTR3 = ""
        cnt = dgv.RowCount
        For i = 0 To cnt - 1
            If dgv.Rows(i).Cells(5).Value = "OK" And dgv2.Rows(i).Cells(5).Value = "OK" Then
                ErgTR3 = ErgTR3 & "1"
            Else
                ErgTR3 = ErgTR3 & "0"
            End If
        Next
        Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value = ErgTR3
    End Sub
    Private Sub bAllOK_Click(sender As Object, e As EventArgs) Handles bAllOK.Click
        Dim cnt As Integer
        ErgTR3 = ""
        cnt = dgv.RowCount
        If cnt = 0 Then
            Dim anzahlZeichen As Integer = Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value.ToString.Length
            Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value = New String("1"c, anzahlZeichen)
        Else
            For i = 0 To cnt - 1
                ErgTR3 = ErgTR3 & "1"
                dgv.Rows(i).Cells(5).Value = "OK"
                dgv.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                dgv2.Rows(i).Cells(5).Value = "OK"
                dgv2.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            Next
            Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value = ErgTR3
        End If

        Ampel_change()
    End Sub
    Private Sub bAllNOK_Click(sender As Object, e As EventArgs) Handles bAllNOK.Click
        Dim cnt As Integer
        ErgTR3 = ""
        cnt = dgv.RowCount
        If cnt = 0 Then
            Dim anzahlZeichen As Integer = Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value.ToString.Length
            Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value = New String("0"c, anzahlZeichen)
        Else
            For i = 0 To cnt - 1
                ErgTR3 = ErgTR3 & "0"
                dgv.Rows(i).Cells(5).Value = "NOK"
                dgv.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgv2.Rows(i).Cells(5).Value = "NOK"
                dgv2.Rows(i).DefaultCellStyle.BackColor = Color.Red
            Next
            Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value = ErgTR3
        End If

        Ampel_change()
    End Sub
    Private Sub Ampel_change()
        If Convert.ToString(Form_Verifikation.DataGridView1.Rows(0).Cells(14).Value).Contains("0") Then
            Form_Verifikation.Ampel_rot()
        Else
            Form_Verifikation.Ampel_gruen()
        End If
    End Sub
End Class