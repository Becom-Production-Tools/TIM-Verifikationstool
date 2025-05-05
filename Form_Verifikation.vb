Imports System.ComponentModel
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml

Public Class Form_Verifikation

    Dim rptext, erco, rptext_array() As String
    Dim ISNR, SART, getall, TracePfad As String
    Dim ISNRwrite, SARTwrite As String
    Dim global_response As String
    Dim Mod_or_Gen As String
    Dim lzisnr(), lzrei1, lzrei2 As String
    Public ProfidUser, ProfidPassword As String

    '########################################################
    Dim ProgVersion As String = "V03"
    '########################################################
    Private Sub Form_Datenreparatur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Width = Me.Width - 80
        DataGridView2.Width = Me.Width - 80
        DataGridView2.Height = Me.Width - 1285

        ButtonBeenden.Location = New Point(Me.Width - 420, 10)
        PictureBox1.Location = New Point(Me.Width - 230, 10)

        TracePfad = ConfigurationManager.AppSettings.Get("TracePfad")               'Importpfad der Datenbank

        'User LOG schreiben
        If IO.Directory.Exists("S:\FTP\MRehberger\Programme\User") Then
            Dim TIMESTAMP_NOW As String = DateTime.Now.ToString("yyyy-MM-dd-HH.mm.ss")
            'strTimeImport = TIMESTAMP_NOW.ToString("yyyy-MM-dd-HH.mm.ss.ffffffzzz")
            Dim inputString As String = vbCrLf + TIMESTAMP_NOW + vbTab + Environment.UserName + vbTab + ProgVersion + vbTab + "Programm geöffnet"
            My.Computer.FileSystem.WriteAllText("S:\FTP\MRehberger\Programme\User\TIMUsers.txt", inputString, True)
        End If

        'Prüfen, ob Archivpfad existiert
        If IO.Directory.Exists(TracePfad) Then
            'nichts machen
        Else    'ansonsten den Ordner erstellen
            Directory.CreateDirectory(TracePfad)
        End If

        Label3.Text = TracePfad
        LblVersion.Text = ProgVersion
        CBSystem.SelectedIndex = 0
        tbPersNr.Select()

        ComboBoxSART.Text = "PAOI"
        AddHandler DataGridView1.EditingControlShowing, AddressOf Dgv_EditingControlShowing

        'TextBoxISNR.Text = "1212305391538"
        'TextBoxISNR.Text = "1212309640901"
        'TextBox1.Text = "1212305391538"
        'tbPersNr.Text = "5160"
    End Sub
    Private Sub Form_Verifikation_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Login()
        tbPersNr.Text = InputBox("Bitte geben Sie ihre Personalnummer ein", "Eingabe Personalnummer",, 350, 350)
        TextBoxISNR.Select()
        Dim Prozessdaten As New Form
    End Sub
    Sub Login()
        LoginForm1.ShowDialog()
        If ProfidUser <> "" And ProfidPassword <> "" Then
            'nichts tun
        Else
            MsgBox("Eingabe Personalnummer oder Passwort nicht korrekt")
            'Me.Close()
        End If
    End Sub
    Private Sub ButtonBeenden_Click(sender As Object, e As EventArgs) Handles ButtonBeenden.Click
        Me.Close()
    End Sub
    Private Sub BStartMultiChange_Click(sender As Object, e As EventArgs) Handles BStartMultiChange.Click
        Dim i As Long
        Dim a() As String
        If tbPersNr.TextLength < 4 Then
            MsgBox("Personalnummer fehlt oder keine 4 Zeichen lang!")
        Else
            Mod_or_Gen = ""
            SART = ComboBoxSART.Text

            If SART = "" Then
                MsgBox("Keine SART eingegeben")
            Else
                a = Split(TextBox1.Text, vbCrLf)    'Split the lines and store it in a String array
                For i = LBound(a) To UBound(a)      'Loop through the array
                    If a(i) <> "" Then
                        ListBox1.Items.Add(a(i))        'and add each item(ie. line) to the combobox
                    End If
                Next
                TextBox1.Clear()
                Me.Refresh()

                For Each item In ListBox1.Items
                    TextBoxISNR.Text = item

                    If CbChangeAll.Checked = True Then
                        CBgetAll.Checked = True
                    End If


                    Button_Start_Click(sender, e)   'Abfrage mir der Nummer starten

                    For Each time In CBTimestamp.Items
                        'Daten automatisch schreiben
                        If CB1.Checked Then
                            If CBT12_1.Text <> "" Then
                                If TBZeile1.Text <> "" And TBSpalte1.Text <> "" Then
                                    If CBT12_1.Text = "T1" Then
                                        TBZeile1.Text = "1"
                                        DataGridView1(CInt(Val(TBSpalte1.Text)) - 1, CInt(Val(TBZeile1.Text)) - 1).Value = TBAenderung1.Text
                                    ElseIf CBT12_1.Text = "T2" Then
                                        DataGridView2(CInt(Val(TBSpalte1.Text)) - 1, CInt(Val(TBZeile1.Text)) - 1).Value = TBAenderung1.Text
                                    End If
                                End If
                            End If
                        End If
                        If CB2.Checked Then
                            If CBT12_2.Text <> "" Then
                                If TBZeile2.Text <> "" And TBSpalte2.Text <> "" Then
                                    If CBT12_2.Text = "T1" Then
                                        TBZeile2.Text = "1"
                                        DataGridView1(CInt(Val(TBSpalte2.Text)) - 1, CInt(Val(TBZeile2.Text)) - 1).Value = TBAenderung2.Text
                                    ElseIf CBT12_2.Text = "T2" Then
                                        DataGridView2(CInt(Val(TBSpalte2.Text)) - 1, CInt(Val(TBZeile2.Text)) - 1).Value = TBAenderung2.Text
                                    End If
                                End If
                            End If
                        End If
                        If CB3.Checked Then
                            If CBT12_3.Text <> "" Then
                                If TBZeile3.Text <> "" And TBSpalte3.Text <> "" Then
                                    If CBT12_3.Text = "T1" Then
                                        TBZeile2.Text = "1"
                                        DataGridView1(CInt(Val(TBSpalte3.Text)) - 1, CInt(Val(TBZeile3.Text)) - 1).Value = TBAenderung3.Text
                                    ElseIf CBT12_3.Text = "T2" Then
                                        DataGridView2(CInt(Val(TBSpalte3.Text)) - 1, CInt(Val(TBZeile3.Text)) - 1).Value = TBAenderung3.Text
                                    End If
                                End If
                            End If

                        End If
                        Me.Refresh()
                        'Daten neu schreiben
                        Button_Daten_schreiben_Click(sender, e)
                        If CbChangeAll.Checked = True And CBTimestamp.SelectedIndex < CBTimestamp.Items.Count - 1 Then
                            CBTimestamp.SelectedIndex = CBTimestamp.SelectedIndex + 1
                        Else
                            Exit For
                        End If
                    Next

                Next
                ListBox1.Items.Clear()
            End If
        End If
    End Sub
    Private Sub nur_zahlen_zulassen(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TBSpalte3.KeyPress, TBZeile3.KeyPress, TBSpalte2.KeyPress, TBZeile2.KeyPress, TBSpalte1.KeyPress, TBZeile1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                ' Zahlen, Backspace und Space zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select
    End Sub
    Private Sub BtDBPfad_Click(sender As Object, e As EventArgs) Handles BtDBPfad.Click
        Process.Start("explorer.exe", TracePfad)
    End Sub
    Private Sub Button_Daten_schreiben_Click(sender As Object, e As EventArgs) Handles Button_Daten_schreiben.Click

        Dim Filename As String
        Dim Separator As Char = ";"c
        Dim UID As String = Guid.NewGuid().ToString()

        If tbPersNr.TextLength < 4 Then
            MsgBox("Personalnummer fehlt oder keine 4 Zeichen lang!")
        Else
            ISNRwrite = DataGridView1.Rows(0).Cells(1).Value
            SARTwrite = DataGridView1.Rows(0).Cells(7).Value

            If Mod_or_Gen = "Gen" Then
                DataGridView1.Rows(0).Cells(17).Value = "Datengeneration"           'In SOPA Info schreiben
                DataGridView1.Rows(0).Cells(18).Value = tbPersNr.Text               'Personalnummer, der die Daten erstellt hat
            Else
                If cbverifiziert.Checked = True Then
                    DataGridView1.Rows(0).Cells(17).Value = "verifiziert"           'In SOPA Info schreiben
                    DataGridView1.Rows(0).Cells(18).Value = tbPersNr.Text           'Personalnummer, der die Daten erstellt hat
                Else
                    DataGridView1.Rows(0).Cells(17).Value = "Datenmodifikation"     'In SOPA Info schreiben
                    DataGridView1.Rows(0).Cells(18).Value = tbPersNr.Text           'Personalnummer, der die Daten erstellt hat
                End If
            End If

            Dim TIMESTAMP_NOW As DateTime = DateTime.Now
            Dim strTimeImport As String
            If CheckBoxTimestamp.Checked = True Then    'Timestamp + 5 Minuten
                strTimeImport = DataGridView1.Rows(0).Cells(12).Value
                Dim dt As DateTime = DateTime.ParseExact(strTimeImport, "yyyy-MM-dd-HH.mm.ss.ffffffzzz", CultureInfo.InvariantCulture)
                dt = DateAdd(DateInterval.Minute, 5, dt)
                strTimeImport = dt.ToString("yyyy-MM-dd-HH.mm.ss.ffffffzzz")
                DataGridView1.Rows(0).Cells(12).Value = strTimeImport
            Else 'Timestamp JETZT bei neuem Datensatz schreiben
                strTimeImport = TIMESTAMP_NOW.ToString("yyyy-MM-dd-HH.mm.ss.ffffffzzz")
                DataGridView1.Rows(0).Cells(12).Value = strTimeImport
            End If

            Filename = TracePfad & "TR3_" & SARTwrite & "_" & ISNRwrite & "_" & UID & ".tmp"   'Dateipfad und Dateinamen generieren

            DGV_Export2File(DataGridView1, DataGridView2, Filename, Separator)
            File.Move(Filename, Path.ChangeExtension(Filename, "csv"))    'Dateiendung in csv ändern
        End If

        Button_Daten_schreiben.BackColor = Color.LightGreen
        Me.TextBoxISNR.Select()
        Me.TextBoxISNR.SelectAll()
    End Sub
    Public Function DGV_Export2File(ByVal DGV As DataGridView, ByVal DGV2 As DataGridView, ByVal FileName As String, ByVal Separator As Char) As Boolean
        Dim text As String = ""
        Try
            'IO.File.Delete(FileName)
            Using SW As New IO.StreamWriter(FileName, False)

                'Zeilenweise schreiben
                If DGV.Rows.Count > 0 Then
                    For i As Integer = 0 To DGV.Rows.Count - 1
                        'New Row für Dateneingabe wird nicht geschrieben
                        If Not DGV.Rows(i).IsNewRow Then
                            Using SW2 As New IO.StringWriter
                                Dim s As String = Nothing
                                For j As Integer = 0 To DGV.Columns.Count - 1
                                    text = DGV.Rows(i).Cells(j).Value      'Feld auslesen
                                    If text = "" Then
                                        SW2.Write(Separator)
                                    Else
                                        text = text.Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue").Replace("Ä", "AE").Replace("Ö", "OE").Replace("Ü", "UE")      'Umlaute ersetzen
                                        SW2.Write(text & Separator)
                                    End If
                                Next
                                s = SW2.ToString
                                'Zeile ausgeben
                                SW.WriteLine(s.Substring(0, s.Length))
                            End Using
                        End If
                    Next
                End If

                If DGV2.Rows.Count > 0 Then
                    For i As Integer = 0 To DGV2.Rows.Count - 1
                        'New Row für Dateneingabe wird nicht geschrieben
                        If Not DGV2.Rows(i).IsNewRow Then
                            Using SW2 As New IO.StringWriter
                                Dim s As String = Nothing
                                For j As Integer = 0 To DGV2.Columns.Count - 1
                                    text = DGV2.Rows(i).Cells(j).Value     'Feld auslesen
                                    If text = "" Then
                                        SW2.Write(Separator)
                                    Else
                                        text = text.Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue").Replace("Ä", "AE").Replace("Ö", "OE").Replace("Ü", "UE")      'Umlaute ersetzen
                                        SW2.Write(text & Separator)
                                    End If
                                Next
                                s = SW2.ToString
                                'Zeile ausgeben
                                SW.WriteLine(s.Substring(0, s.Length - 1))  '-1, weil am Ende ein Feld zu viel ist
                            End Using
                        End If
                    Next
                End If

            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LblAnzahl.Text = TextBox1.Lines.Count - 1
    End Sub
    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click

        If ProfidUser <> "" And ProfidPassword <> "" Then
            'nichts tun
        Else
            MsgBox("Eingabe Personalnummer oder Passwort nicht korrekt")
            Exit Sub
        End If

        lblNoData.Visible = False
        erco = ""
        ISNR = TextBoxISNR.Text
        SART = ComboBoxSART.Text

        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView2.Columns.Clear()

        If CBgetAll.Checked = True Then
            getall = "true"
        Else
            getall = "false"
        End If

        CBTimestamp.Items.Clear()

        Me.Refresh()

        If ISNR = "" Or SART = "" Then
            MsgBox("Keine ISNR oder SART eingegeben")
            GoTo Ende
        Else
            Webservice_getTraceDataByIsnrAndSart2(ISNR, SART)
        End If

        If erco = "88020" Then
            'MsgBox("Keine Daten gefunden!!!")
            lblNoData.Visible = True
        Else
            'lblSollZeichen.Text = DataGridView1.Rows(0).Cells(14).Value.ToString.Length
        End If

        Button_Daten_schreiben.BackColor = Color.Red

        Me.Activate()
        Me.TextBoxISNR.Select()
        Me.TextBoxISNR.SelectAll()
Ende:
    End Sub
    Private Sub tbPersNr_TextChanged(sender As Object, e As EventArgs) Handles tbPersNr.TextChanged
        If tbPersNr.TextLength = 4 Then
            tbPersNr.BackColor = Color.LightGreen
        Else
            tbPersNr.BackColor = Color.Red
        End If

        If tbPersNr.TextLength > 3 Then
            Button_Daten_schreiben.Enabled = True
            BDatenGenerieren.Enabled = True
            BStartMultiChange.Enabled = True
        Else
            Button_Daten_schreiben.Enabled = False
            BDatenGenerieren.Enabled = False
            BStartMultiChange.Enabled = False
        End If

        Me.Refresh()
    End Sub
    Private Sub tbISNR_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbPersNr.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 22 Then 'nur Zahlen, Entf, BackSpc und STRG+V zulassen
            e.Handled = True
        Else
            'nichts tun
        End If
    End Sub
    Private Sub CBTimestamp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTimestamp.SelectedIndexChanged
        '#######################
        Dim xmldoc As New XmlDocument()
        Dim xmlnodelist As XmlNodeList
        Dim node As XmlNode

        Dim zeile As Integer = 0
        Dim header As Boolean = True

        Prozessdaten.Close()
        'löschen
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView2.Columns.Clear()

        xmldoc.LoadXml(global_response)

        xmlnodelist = xmldoc.SelectNodes("//rrpList/rptima")

        For Each node In xmlnodelist
            If CBTimestamp.SelectedItem = node.InnerText Then
                Dim test As XmlNode = node.ParentNode
                rptext = test.Item("rptext").InnerText


                If header = False Then
                    rptext = Microsoft.VisualBasic.Right(rptext, Len(rptext) - InStr(rptext, "T2") + 1)
                End If

                If zeile = 0 Then
                    DataGridView2.Columns.Add("Name", 1)
                    DataGridView1.Rows.Add(1)
                    DataGridView2.Rows.Add(1)
                End If

                rptext_array = Split(rptext, ";")

                Dim index As Integer = Array.FindIndex(rptext_array, Function(s) s = "T2")  'Position von T2

                If index <> 26 And index <> 0 Then
                    MsgBox("Achtung, angezeigter Header stimmt nicht!!!    Es ist ein TR2 Datensatz!!! ")
                End If

                Dim spaltenzähler As Integer = 0
                'Zelle befüllen
                For i As Integer = 0 To rptext_array.GetUpperBound(0) - 1
                    rptext_array(i) = Replace(rptext_array(i), " ", "")
                    Dim x As String = rptext_array(i)
                    If header = True And i <= (index - 1) Then
                        DataGridView1(i, zeile).Value = x
                    ElseIf header = True And i > (index - 1) Then
                        spaltenzähler += 1
                        DataGridView2.Columns.Add("Name", spaltenzähler + 1)
                        DataGridView2(i - index, zeile).Value = x
                    ElseIf header = False Then
                        DataGridView2(i, zeile).Value = x
                    End If
                Next
                zeile += 1
                DataGridView2.Rows.Insert(zeile, 1)
                header = False
            Else
                'nichts machen
            End If
        Next
        '#############################

        'wenn kein Fehler, dann die letzte Zeile wieder löschen
        If erco = "" Then
            DataGridView2.Rows.RemoveAt(zeile)
        End If
        Me.Refresh()

        If Convert.ToString(DataGridView1.Rows(0).Cells(14).Value).Contains("0") Then
            Ampel_rot()
        Else
            Ampel_gruen()
        End If
        Prozessdaten.Show()
    End Sub
    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        DataGridView1.CurrentCell.Style.BackColor = Color.Red
        'lblAnzZeichen.Text = DataGridView1.Rows(0).Cells(14).Value.ToString.Length
        Me.Refresh()
    End Sub
    Private Sub DataGridView2_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView2.CurrentCellDirtyStateChanged
        DataGridView2.CurrentCell.Style.BackColor = Color.Red
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        GroupBox1.Visible = True
        BDatenGenerieren.Visible = True
        CheckBoxTimestamp.Visible = True
        cbverifiziert.Visible = True
    End Sub
    Private Sub BDatenGenerieren_Click(sender As Object, e As EventArgs) Handles BDatenGenerieren.Click
        Dim i As Long
        Dim a() As String
        If tbPersNr.TextLength < 4 Then
            MsgBox("Personalnummer fehlt oder keine 4 Zeichen lang!")
        Else
            If CBTimestamp.Items.Count > 0 Then
                Mod_or_Gen = "Gen"
                Select Case MessageBox.Show("Daten mit dieser Datenvorlage generieren???", "Frage", MessageBoxButtons.YesNo)    ' Programm wirklich beenden
                    Case Windows.Forms.DialogResult.Yes

                        SART = ComboBoxSART.Text

                        If SART = "" Then
                            MsgBox("Keine SART eingegeben")
                        Else
                            a = Split(Trim(TextBox1.Text), vbCrLf)    'Split the lines and store it in a String array
                            For i = LBound(a) To UBound(a)      'Loop through the array
                                If a(i) <> "" Then
                                    ListBox1.Items.Add(a(i))        'and add each item(ie. line) to the combobox
                                End If
                            Next
                            TextBox1.Clear()
                            Me.Refresh()

                            For Each item In ListBox1.Items
                                Dim b As Integer = 0

                                item = Trim(item)
                                TextBoxISNR.Text = item

                                Webservice_getTraceDataByIsnrAndSart2(item, SART)
                                Me.Refresh()

                                If item.ToString.Substring(2, 1) <> "0" Then 'prüfen, ob keine EinzelISNR
                                    webservice_getLzByRei(item)
                                End If


                                If erco = "88020" Then 'keine Daten vorhanden. Daten erzeugen
                                    DataGridView1.Rows(0).Cells(1).Value = item     'ISNR in T1 schreiben

                                    'Einzelprint ISNR einfügen
                                    If item.ToString.Substring(2, 1) = "0" Then    'wenn EinzelISNR
                                        DataGridView2.Rows(0).Cells(1).Value = item
                                    Else                                            'wenn NutzenISNR
                                        If DataGridView2.Rows(0).Cells(2).Value = 0 Then    'steht in 1te Zeile T2 die ID=0
                                            DataGridView2.Rows(0).Cells(1).Value = item    'ISNR eintragen
                                            b = 1
                                        Else
                                            b = 0
                                        End If

                                        If DataGridView2.RowCount > 1 Then
                                            For i = 0 To lzisnr.Length - 1
                                                If DataGridView2.Rows(i + b).Cells(2).Value <> 0 Then
                                                    DataGridView2.Rows(i + b).Cells(1).Value = lzisnr(i)
                                                End If
                                            Next
                                        End If
                                    End If
                                    Me.Refresh()
                                    'Daten neu schreiben
                                    Button_Daten_schreiben_Click(sender, e)
                                    erco = ""
                                Else
                                    'Daten vorhanden. keine Daten erzeugen
                                    MsgBox("Daten der ISNR: " + item + " und SART: " + SART + " bereits vorhanden")
                                    erco = ""
                                End If
                            Next
                            ListBox1.Items.Clear()
                        End If

                    Case Windows.Forms.DialogResult.No
                        'nichts machen
                End Select
            Else
                MsgBox("keine Vorlage vorhanden. Bitte zuerst mit vorhandener Seriennummer Daten abfragen")
            End If
        End If
    End Sub
    Private Sub Daten_anpassen()

    End Sub
    Private Sub LoginProfidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginProfidToolStripMenuItem.Click
        Login()
    End Sub
    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
    Private Sub ComboBoxSART_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxSART.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
    Public Sub Webservice_getTraceDataByIsnrAndSart2(ISNR_Anfrage As String, SART As String)

        Dim xml As String
        Dim url As String = ""
        Select Case CBSystem.SelectedIndex
            Case 0
                url = "http://whedi1:50607/traceDataExchange"
            Case 1
                url = "http://032-ITSV-EDI1:50607/traceDataExchange"
        End Select


        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:trac=""http://whedi1/traceDataExchange"">
                   <soapenv:Header/>
                       <soapenv:Body>
                               <trac:getTraceDataByIsnrAndSart2>
                                    <isnr>" & ISNR_Anfrage & "</isnr>
                                    <sart>" & SART & "</sart>
                                    <getAll>" & getall & "</getAll>
                               </trac:getTraceDataByIsnrAndSart2>
                       </soapenv:Body>
                   </soapenv:Envelope>"

        Dim responsestring As String = ""
        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim proxy As IWebProxy = CType(myReq.Proxy, IWebProxy)
        Dim proxyaddress As String
        Dim myProxy As New WebProxy()
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        proxyaddress = proxy.GetProxy(myReq.RequestUri).ToString

        Dim newUri As New Uri(proxyaddress)
        myProxy.Address = newUri
        myReq.Proxy = myProxy
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd
        global_response = response

        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(New StringReader(response))
        Dim zeile As Integer = 0
        Dim header As Boolean = True


        '#######################
        Dim xmldoc As New XmlDocument()
        Dim xmlnodelist As XmlNodeList
        Dim node As XmlNode
        xmldoc.LoadXml(response)

        xmlnodelist = xmldoc.SelectNodes("//rrpList/rptima")
        'verschiedene Datensätze in ComboBox eintragen
        For Each node In xmlnodelist
            If CBTimestamp.Items.Contains(node.InnerText) Then
                'Eintrag bereits vorhanden. nicht mehr hinzufügen
            Else
                'Eintrag hinzufügen
                CBTimestamp.Items.Add(node.InnerText)
                'unit = node.Attributes("unit").Value
            End If
        Next

        xmlnodelist = xmldoc.SelectNodes("//getTraceDataByIsnrAndSart2/errorList/errors")
        'verschiedene Datensätze in ComboBox eintragen
        For Each node In xmlnodelist
            erco = node.SelectSingleNode("erco").InnerText
        Next

        If CBTimestamp.Items.Count > 0 Then
            CBTimestamp.SelectedIndex = 0
        Else
            erco = "88020"
        End If
        Label6.Text = CBTimestamp.Items.Count
    End Sub
    Public Sub webservice_getLzByRei(ISNR_Anfrage As String)
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:trac=""http://whedi1/traceDataExchange"">
                   <soapenv:Header/>
                       <soapenv:Body>
                          <trac:getLzByRei>
                             <isnr>" & ISNR_Anfrage & "</isnr>
                          </trac:getLzByRei>
                       </soapenv:Body>
                   </soapenv:Envelope>"

        Dim url As String = "http://whedi1:50607/traceDataExchange"
        Dim responsestring As String = ""

        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim proxy As IWebProxy = CType(myReq.Proxy, IWebProxy)
        Dim proxyaddress As String
        Dim myProxy As New WebProxy()
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        proxyaddress = proxy.GetProxy(myReq.RequestUri).ToString

        Dim newUri As New Uri(proxyaddress)
        myProxy.Address = newUri
        myReq.Proxy = myProxy
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd 'Ergebnis Webserviceanfrage
        'Abfrage der Referenztabelle
        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(New StringReader(response))
        Dim i As Int16 = 0

        'Dim cntrow As Integer = DataGridView2.RowCount - 1
        'ReDim lzisnr(DataGridView2.Rows(cntrow - 2).Cells(2).Value)
        With XMLReader
            Do While .Read
                If XMLReader.Name = "lzisnr" Then
                    ReDim Preserve lzisnr(i)
                    lzisnr(i) = XMLReader.ReadElementContentAsString
                    i = i + 1
                    lzrei1 = XMLReader.ReadElementContentAsString
                    lzrei2 = XMLReader.ReadElementContentAsString
                ElseIf XMLReader.Name = "erco" Then         'Keine Daten gefunden! // No data found! // Nincsenek adatok!
                    erco = XMLReader.ReadElementContentAsString
                    Exit Do
                End If
            Loop
            .Close()
        End With
        'Array.Sort(lzisnr)      'Einzelschaltung ISNR sortieren, die die Referenztabelle nicht in der richtigen Reihenfolge sein kann
    End Sub
    Private Sub Dgv_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        Dim Tb As TextBox = CType(e.Control, TextBox)
        RemoveHandler Tb.KeyPress, AddressOf Tb_KeyPress
        AddHandler Tb.KeyPress, AddressOf Tb_KeyPress
    End Sub
    Private Sub Tb_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> vbBack Then
            Select Case DataGridView1.CurrentCell.ColumnIndex
                Case 0
                    If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
                Case Else
                    If Not Char.IsDigit(e.KeyChar) Then e.Handled = True       'If Not Char.IsLetter(e.KeyChar) Then e.Handled = True
            End Select
        End If
    End Sub
    Private Sub TextBoxISNR_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxISNR.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 22 AndAlso Asc(e.KeyChar) <> 3 Then
            e.Handled = True
        Else
            If Asc(e.KeyChar) = 13 Then
                Button_Start_Click(sender, e)
            End If
            'nichts tun
        End If
    End Sub
    Private Sub TextBoxISNR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxISNR.TextChanged
        If TextBoxISNR.TextLength = 0 Then
            TextBoxISNR.BackColor = Color.White
        ElseIf TextBoxISNR.TextLength = 13 Then
            TextBoxISNR.BackColor = Color.LightGreen
        Else
            TextBoxISNR.BackColor = Color.Red
        End If
    End Sub
    Public Sub Ampel_gruen()
        Dim g As Graphics = PictureBox2.CreateGraphics
        g.DrawEllipse(Pens.Black, New Rectangle(0, 0, 80, 80))
        g.FillEllipse(Brushes.LimeGreen, New Rectangle(0, 0, 80, 80))
    End Sub
    Public Sub Ampel_rot()
        Dim g As Graphics = PictureBox2.CreateGraphics
        g.DrawEllipse(Pens.Black, New Rectangle(0, 0, 80, 80))
        g.FillEllipse(Brushes.Red, New Rectangle(0, 0, 80, 80))
    End Sub
End Class