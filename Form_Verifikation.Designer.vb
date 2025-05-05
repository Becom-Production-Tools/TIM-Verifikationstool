<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Verifikation
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Verifikation))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.T1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BISNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KSNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Auftrag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abruf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anlagennummer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mandant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Funktionsgruppe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Einzel_OK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nutzen_OK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prüfungszähler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOAP_aktiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOAP_Info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOAP_PersNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameProg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionProg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.TextBoxISNR = New System.Windows.Forms.TextBox()
        Me.Label_ISNR = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBeenden = New System.Windows.Forms.Button()
        Me.Button_Daten_schreiben = New System.Windows.Forms.Button()
        Me.ComboBoxSART = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.T2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CBTimestamp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBgetAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BStartMultiChange = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBZeile1 = New System.Windows.Forms.TextBox()
        Me.TBSpalte1 = New System.Windows.Forms.TextBox()
        Me.TBAenderung1 = New System.Windows.Forms.TextBox()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.CB2 = New System.Windows.Forms.CheckBox()
        Me.TBAenderung2 = New System.Windows.Forms.TextBox()
        Me.TBSpalte2 = New System.Windows.Forms.TextBox()
        Me.TBZeile2 = New System.Windows.Forms.TextBox()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.TBAenderung3 = New System.Windows.Forms.TextBox()
        Me.TBSpalte3 = New System.Windows.Forms.TextBox()
        Me.TBZeile3 = New System.Windows.Forms.TextBox()
        Me.CBT12_1 = New System.Windows.Forms.ComboBox()
        Me.CBT12_2 = New System.Windows.Forms.ComboBox()
        Me.CBT12_3 = New System.Windows.Forms.ComboBox()
        Me.BtDBPfad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbChangeAll = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblAnzahl = New System.Windows.Forms.Label()
        Me.BDatenGenerieren = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CBSystem = New System.Windows.Forms.ComboBox()
        Me.CheckBoxTimestamp = New System.Windows.Forms.CheckBox()
        Me.cbverifiziert = New System.Windows.Forms.CheckBox()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.tbPersNr = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginProfidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T1, Me.BISNR, Me.KSNR, Me.Auftrag, Me.Abruf, Me.Rest, Me.Position, Me.Anlagennummer, Me.PersNR, Me.Version, Me.Mandant, Me.Funktionsgruppe, Me.Timestamp, Me.Einzel_OK, Me.Nutzen_OK, Me.Prüfungszähler, Me.SOAP_aktiv, Me.SOAP_Info, Me.SOAP_PersNR, Me.NameProg, Me.VersionProg, Me.Res1, Me.Res2, Me.Res3, Me.Res4, Me.Res5})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 260)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1084, 96)
        Me.DataGridView1.TabIndex = 4
        '
        'T1
        '
        Me.T1.HeaderText = "1 T1"
        Me.T1.MinimumWidth = 30
        Me.T1.Name = "T1"
        Me.T1.ReadOnly = True
        Me.T1.Width = 30
        '
        'BISNR
        '
        Me.BISNR.HeaderText = "2 ISNR"
        Me.BISNR.MinimumWidth = 70
        Me.BISNR.Name = "BISNR"
        Me.BISNR.ReadOnly = True
        Me.BISNR.Width = 70
        '
        'KSNR
        '
        Me.KSNR.HeaderText = "3 KSNR"
        Me.KSNR.MinimumWidth = 60
        Me.KSNR.Name = "KSNR"
        Me.KSNR.ReadOnly = True
        Me.KSNR.Width = 60
        '
        'Auftrag
        '
        Me.Auftrag.HeaderText = "4 Auftrag"
        Me.Auftrag.MinimumWidth = 55
        Me.Auftrag.Name = "Auftrag"
        Me.Auftrag.ReadOnly = True
        Me.Auftrag.Width = 55
        '
        'Abruf
        '
        Me.Abruf.HeaderText = "5 Abruf"
        Me.Abruf.MinimumWidth = 40
        Me.Abruf.Name = "Abruf"
        Me.Abruf.ReadOnly = True
        Me.Abruf.Width = 40
        '
        'Rest
        '
        Me.Rest.HeaderText = "6 Rest"
        Me.Rest.MinimumWidth = 40
        Me.Rest.Name = "Rest"
        Me.Rest.ReadOnly = True
        Me.Rest.Width = 40
        '
        'Position
        '
        Me.Position.HeaderText = "7 Pos"
        Me.Position.MinimumWidth = 30
        Me.Position.Name = "Position"
        Me.Position.ReadOnly = True
        Me.Position.Width = 30
        '
        'Anlagennummer
        '
        Me.Anlagennummer.HeaderText = "8 SART"
        Me.Anlagennummer.MinimumWidth = 50
        Me.Anlagennummer.Name = "Anlagennummer"
        Me.Anlagennummer.ReadOnly = True
        Me.Anlagennummer.Width = 50
        '
        'PersNR
        '
        Me.PersNR.HeaderText = "9 PersNR"
        Me.PersNR.MinimumWidth = 55
        Me.PersNR.Name = "PersNR"
        Me.PersNR.ReadOnly = True
        Me.PersNR.Width = 55
        '
        'Version
        '
        Me.Version.HeaderText = "10 Version"
        Me.Version.MinimumWidth = 45
        Me.Version.Name = "Version"
        Me.Version.ReadOnly = True
        Me.Version.Width = 45
        '
        'Mandant
        '
        Me.Mandant.HeaderText = "11 Mandant"
        Me.Mandant.MinimumWidth = 60
        Me.Mandant.Name = "Mandant"
        Me.Mandant.ReadOnly = True
        Me.Mandant.Width = 60
        '
        'Funktionsgruppe
        '
        Me.Funktionsgruppe.HeaderText = "12 FktGrp"
        Me.Funktionsgruppe.MinimumWidth = 50
        Me.Funktionsgruppe.Name = "Funktionsgruppe"
        Me.Funktionsgruppe.ReadOnly = True
        Me.Funktionsgruppe.Width = 50
        '
        'Timestamp
        '
        Me.Timestamp.HeaderText = "13 Timestamp"
        Me.Timestamp.MinimumWidth = 70
        Me.Timestamp.Name = "Timestamp"
        Me.Timestamp.ReadOnly = True
        Me.Timestamp.Width = 70
        '
        'Einzel_OK
        '
        Me.Einzel_OK.HeaderText = "14 Einzel OK"
        Me.Einzel_OK.MinimumWidth = 50
        Me.Einzel_OK.Name = "Einzel_OK"
        Me.Einzel_OK.ReadOnly = True
        Me.Einzel_OK.Width = 50
        '
        'Nutzen_OK
        '
        Me.Nutzen_OK.HeaderText = "15 Nutzen OK"
        Me.Nutzen_OK.MinimumWidth = 50
        Me.Nutzen_OK.Name = "Nutzen_OK"
        Me.Nutzen_OK.Width = 50
        '
        'Prüfungszähler
        '
        Me.Prüfungszähler.HeaderText = "16 PrüfZähl"
        Me.Prüfungszähler.MinimumWidth = 50
        Me.Prüfungszähler.Name = "Prüfungszähler"
        Me.Prüfungszähler.ReadOnly = True
        Me.Prüfungszähler.Width = 50
        '
        'SOAP_aktiv
        '
        Me.SOAP_aktiv.HeaderText = "17 SOAP aktiv"
        Me.SOAP_aktiv.MinimumWidth = 45
        Me.SOAP_aktiv.Name = "SOAP_aktiv"
        Me.SOAP_aktiv.ReadOnly = True
        Me.SOAP_aktiv.Width = 45
        '
        'SOAP_Info
        '
        Me.SOAP_Info.HeaderText = "18 SOAP Info"
        Me.SOAP_Info.MinimumWidth = 45
        Me.SOAP_Info.Name = "SOAP_Info"
        Me.SOAP_Info.ReadOnly = True
        Me.SOAP_Info.Width = 45
        '
        'SOAP_PersNR
        '
        Me.SOAP_PersNR.HeaderText = "19 SOAP PersNR"
        Me.SOAP_PersNR.MinimumWidth = 50
        Me.SOAP_PersNR.Name = "SOAP_PersNR"
        Me.SOAP_PersNR.ReadOnly = True
        Me.SOAP_PersNR.Width = 50
        '
        'NameProg
        '
        Me.NameProg.HeaderText = "20 Name Programm"
        Me.NameProg.MinimumWidth = 70
        Me.NameProg.Name = "NameProg"
        Me.NameProg.ReadOnly = True
        Me.NameProg.Width = 70
        '
        'VersionProg
        '
        Me.VersionProg.HeaderText = "21 Version Prog"
        Me.VersionProg.MinimumWidth = 50
        Me.VersionProg.Name = "VersionProg"
        Me.VersionProg.ReadOnly = True
        Me.VersionProg.Width = 50
        '
        'Res1
        '
        Me.Res1.HeaderText = "22 Res1"
        Me.Res1.MinimumWidth = 40
        Me.Res1.Name = "Res1"
        Me.Res1.ReadOnly = True
        Me.Res1.Width = 40
        '
        'Res2
        '
        Me.Res2.HeaderText = "23 Res2"
        Me.Res2.MinimumWidth = 40
        Me.Res2.Name = "Res2"
        Me.Res2.ReadOnly = True
        Me.Res2.Width = 40
        '
        'Res3
        '
        Me.Res3.HeaderText = "24 Res3"
        Me.Res3.MinimumWidth = 40
        Me.Res3.Name = "Res3"
        Me.Res3.ReadOnly = True
        Me.Res3.Width = 40
        '
        'Res4
        '
        Me.Res4.HeaderText = "25 Res4"
        Me.Res4.MinimumWidth = 40
        Me.Res4.Name = "Res4"
        Me.Res4.ReadOnly = True
        Me.Res4.Width = 40
        '
        'Res5
        '
        Me.Res5.HeaderText = "26 Res5"
        Me.Res5.MinimumWidth = 40
        Me.Res5.Name = "Res5"
        Me.Res5.ReadOnly = True
        Me.Res5.Width = 40
        '
        'Button_Start
        '
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button_Start.Location = New System.Drawing.Point(20, 56)
        Me.Button_Start.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(118, 43)
        Me.Button_Start.TabIndex = 2
        Me.Button_Start.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.Button_Start, "Start der Abfrage mit der eingegebenen Seriennummer und SART")
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'TextBoxISNR
        '
        Me.TextBoxISNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxISNR.Location = New System.Drawing.Point(184, 60)
        Me.TextBoxISNR.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxISNR.Name = "TextBoxISNR"
        Me.TextBoxISNR.Size = New System.Drawing.Size(150, 29)
        Me.TextBoxISNR.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextBoxISNR, "Eingabe Seriennummer")
        '
        'Label_ISNR
        '
        Me.Label_ISNR.AutoSize = True
        Me.Label_ISNR.Location = New System.Drawing.Point(143, 71)
        Me.Label_ISNR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_ISNR.Name = "Label_ISNR"
        Me.Label_ISNR.Size = New System.Drawing.Size(39, 13)
        Me.Label_ISNR.TabIndex = 8
        Me.Label_ISNR.Text = "ISNR: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SART:"
        '
        'ButtonBeenden
        '
        Me.ButtonBeenden.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonBeenden.Location = New System.Drawing.Point(1477, 84)
        Me.ButtonBeenden.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBeenden.Name = "ButtonBeenden"
        Me.ButtonBeenden.Size = New System.Drawing.Size(165, 50)
        Me.ButtonBeenden.TabIndex = 6
        Me.ButtonBeenden.Text = "BEENDEN"
        Me.ToolTip1.SetToolTip(Me.ButtonBeenden, "Programm beenden")
        Me.ButtonBeenden.UseVisualStyleBackColor = True
        '
        'Button_Daten_schreiben
        '
        Me.Button_Daten_schreiben.Enabled = False
        Me.Button_Daten_schreiben.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button_Daten_schreiben.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Daten_schreiben.Location = New System.Drawing.Point(969, 37)
        Me.Button_Daten_schreiben.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Daten_schreiben.Name = "Button_Daten_schreiben"
        Me.Button_Daten_schreiben.Size = New System.Drawing.Size(120, 61)
        Me.Button_Daten_schreiben.TabIndex = 5
        Me.Button_Daten_schreiben.Text = "Daten schreiben"
        Me.ToolTip1.SetToolTip(Me.Button_Daten_schreiben, "einzelnen Datensatz mit den angezeigten Daten in der Tabelle erstellen")
        Me.Button_Daten_schreiben.UseVisualStyleBackColor = True
        '
        'ComboBoxSART
        '
        Me.ComboBoxSART.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxSART.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSART.Enabled = False
        Me.ComboBoxSART.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ComboBoxSART.FormattingEnabled = True
        Me.ComboBoxSART.Items.AddRange(New Object() {"AOI", "EOL", "ICT", "INS", "LOET", "MONT", "NUTZ", "PAOI", "PGMA", "ROBO"})
        Me.ComboBoxSART.Location = New System.Drawing.Point(380, 60)
        Me.ComboBoxSART.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxSART.Name = "ComboBoxSART"
        Me.ComboBoxSART.Size = New System.Drawing.Size(104, 32)
        Me.ComboBoxSART.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ComboBoxSART, "Eingabe Anlagennummer")
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T2})
        Me.DataGridView2.Enabled = False
        Me.DataGridView2.Location = New System.Drawing.Point(20, 359)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1084, 253)
        Me.DataGridView2.TabIndex = 10
        '
        'T2
        '
        Me.T2.HeaderText = "T2"
        Me.T2.MinimumWidth = 6
        Me.T2.Name = "T2"
        Me.T2.Width = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1477, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 59)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'CBTimestamp
        '
        Me.CBTimestamp.FormattingEnabled = True
        Me.CBTimestamp.Location = New System.Drawing.Point(572, 75)
        Me.CBTimestamp.Margin = New System.Windows.Forms.Padding(2)
        Me.CBTimestamp.Name = "CBTimestamp"
        Me.CBTimestamp.Size = New System.Drawing.Size(225, 21)
        Me.CBTimestamp.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.CBTimestamp, "Datensätze mit unterschiedlichen TIMESTAMP")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Timestamps Dateneinträge"
        '
        'CBgetAll
        '
        Me.CBgetAll.AutoSize = True
        Me.CBgetAll.Checked = True
        Me.CBgetAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBgetAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBgetAll.Location = New System.Drawing.Point(492, 66)
        Me.CBgetAll.Name = "CBgetAll"
        Me.CBgetAll.Size = New System.Drawing.Size(68, 24)
        Me.CBgetAll.TabIndex = 38
        Me.CBgetAll.Text = "getAll"
        Me.ToolTip1.SetToolTip(Me.CBgetAll, "True = alle Datensätze abfragen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "False = nur den letzten Datensatz abfragen")
        Me.CBgetAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(598, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Anzahl Datensätze:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(702, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "?"
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(148, 60)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 69)
        Me.ListBox1.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 60)
        Me.TextBox1.MaxLength = 100000000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(125, 70)
        Me.TextBox1.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Eingabe mehrerer ISNR (getrennt durch ENTER), um diesegesammelt ändern zu können")
        '
        'BStartMultiChange
        '
        Me.BStartMultiChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BStartMultiChange.Enabled = False
        Me.BStartMultiChange.Location = New System.Drawing.Point(6, 10)
        Me.BStartMultiChange.Name = "BStartMultiChange"
        Me.BStartMultiChange.Size = New System.Drawing.Size(112, 32)
        Me.BStartMultiChange.TabIndex = 43
        Me.BStartMultiChange.Text = "Start Multi Change"
        Me.ToolTip1.SetToolTip(Me.BStartMultiChange, "Datensatz oder alle Datensätze durch die angegebenen Änderungen erstellen")
        Me.BStartMultiChange.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Eingabe ISNR:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Änderungen:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Zeile"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(403, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Spalte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(467, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Änderung"
        '
        'TBZeile1
        '
        Me.TBZeile1.Location = New System.Drawing.Point(357, 58)
        Me.TBZeile1.MaxLength = 2
        Me.TBZeile1.Name = "TBZeile1"
        Me.TBZeile1.Size = New System.Drawing.Size(35, 20)
        Me.TBZeile1.TabIndex = 49
        '
        'TBSpalte1
        '
        Me.TBSpalte1.Location = New System.Drawing.Point(405, 58)
        Me.TBSpalte1.MaxLength = 2
        Me.TBSpalte1.Name = "TBSpalte1"
        Me.TBSpalte1.Size = New System.Drawing.Size(35, 20)
        Me.TBSpalte1.TabIndex = 50
        '
        'TBAenderung1
        '
        Me.TBAenderung1.Location = New System.Drawing.Point(450, 58)
        Me.TBAenderung1.Name = "TBAenderung1"
        Me.TBAenderung1.Size = New System.Drawing.Size(84, 20)
        Me.TBAenderung1.TabIndex = 51
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.Location = New System.Drawing.Point(284, 62)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(15, 14)
        Me.CB1.TabIndex = 52
        Me.CB1.UseVisualStyleBackColor = True
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.Location = New System.Drawing.Point(284, 88)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(15, 14)
        Me.CB2.TabIndex = 56
        Me.CB2.UseVisualStyleBackColor = True
        Me.CB2.Visible = False
        '
        'TBAenderung2
        '
        Me.TBAenderung2.Location = New System.Drawing.Point(451, 84)
        Me.TBAenderung2.Name = "TBAenderung2"
        Me.TBAenderung2.Size = New System.Drawing.Size(84, 20)
        Me.TBAenderung2.TabIndex = 55
        Me.TBAenderung2.Visible = False
        '
        'TBSpalte2
        '
        Me.TBSpalte2.Location = New System.Drawing.Point(405, 86)
        Me.TBSpalte2.MaxLength = 2
        Me.TBSpalte2.Name = "TBSpalte2"
        Me.TBSpalte2.Size = New System.Drawing.Size(35, 20)
        Me.TBSpalte2.TabIndex = 54
        Me.TBSpalte2.Visible = False
        '
        'TBZeile2
        '
        Me.TBZeile2.Location = New System.Drawing.Point(357, 86)
        Me.TBZeile2.MaxLength = 2
        Me.TBZeile2.Name = "TBZeile2"
        Me.TBZeile2.Size = New System.Drawing.Size(35, 20)
        Me.TBZeile2.TabIndex = 53
        Me.TBZeile2.Visible = False
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.Location = New System.Drawing.Point(284, 113)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(15, 14)
        Me.CB3.TabIndex = 60
        Me.CB3.UseVisualStyleBackColor = True
        Me.CB3.Visible = False
        '
        'TBAenderung3
        '
        Me.TBAenderung3.Location = New System.Drawing.Point(451, 111)
        Me.TBAenderung3.Name = "TBAenderung3"
        Me.TBAenderung3.Size = New System.Drawing.Size(84, 20)
        Me.TBAenderung3.TabIndex = 59
        Me.TBAenderung3.Visible = False
        '
        'TBSpalte3
        '
        Me.TBSpalte3.Location = New System.Drawing.Point(405, 111)
        Me.TBSpalte3.MaxLength = 2
        Me.TBSpalte3.Name = "TBSpalte3"
        Me.TBSpalte3.Size = New System.Drawing.Size(35, 20)
        Me.TBSpalte3.TabIndex = 58
        Me.TBSpalte3.Visible = False
        '
        'TBZeile3
        '
        Me.TBZeile3.Location = New System.Drawing.Point(357, 111)
        Me.TBZeile3.MaxLength = 2
        Me.TBZeile3.Name = "TBZeile3"
        Me.TBZeile3.Size = New System.Drawing.Size(35, 20)
        Me.TBZeile3.TabIndex = 57
        Me.TBZeile3.Visible = False
        '
        'CBT12_1
        '
        Me.CBT12_1.FormattingEnabled = True
        Me.CBT12_1.Items.AddRange(New Object() {"T1", "T2"})
        Me.CBT12_1.Location = New System.Drawing.Point(310, 58)
        Me.CBT12_1.MaxLength = 2
        Me.CBT12_1.Name = "CBT12_1"
        Me.CBT12_1.Size = New System.Drawing.Size(38, 21)
        Me.CBT12_1.TabIndex = 61
        '
        'CBT12_2
        '
        Me.CBT12_2.FormattingEnabled = True
        Me.CBT12_2.Items.AddRange(New Object() {"T1", "T2"})
        Me.CBT12_2.Location = New System.Drawing.Point(310, 84)
        Me.CBT12_2.MaxLength = 2
        Me.CBT12_2.Name = "CBT12_2"
        Me.CBT12_2.Size = New System.Drawing.Size(38, 21)
        Me.CBT12_2.TabIndex = 62
        Me.CBT12_2.Visible = False
        '
        'CBT12_3
        '
        Me.CBT12_3.FormattingEnabled = True
        Me.CBT12_3.Items.AddRange(New Object() {"T1", "T2"})
        Me.CBT12_3.Location = New System.Drawing.Point(310, 110)
        Me.CBT12_3.MaxLength = 2
        Me.CBT12_3.Name = "CBT12_3"
        Me.CBT12_3.Size = New System.Drawing.Size(38, 21)
        Me.CBT12_3.TabIndex = 63
        Me.CBT12_3.Visible = False
        '
        'BtDBPfad
        '
        Me.BtDBPfad.Location = New System.Drawing.Point(20, 99)
        Me.BtDBPfad.Name = "BtDBPfad"
        Me.BtDBPfad.Size = New System.Drawing.Size(75, 23)
        Me.BtDBPfad.TabIndex = 64
        Me.BtDBPfad.Text = "DB-Pfad"
        Me.ToolTip1.SetToolTip(Me.BtDBPfad, "öffnen des angezeigten Pfades im Explorer")
        Me.BtDBPfad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Aktiv"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(303, 41)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Datensatz"
        '
        'CbChangeAll
        '
        Me.CbChangeAll.AutoSize = True
        Me.CbChangeAll.Location = New System.Drawing.Point(125, 23)
        Me.CbChangeAll.Margin = New System.Windows.Forms.Padding(2)
        Me.CbChangeAll.Name = "CbChangeAll"
        Me.CbChangeAll.Size = New System.Drawing.Size(135, 17)
        Me.CbChangeAll.TabIndex = 66
        Me.CbChangeAll.Text = "alle Datensätze ändern"
        Me.ToolTip1.SetToolTip(Me.CbChangeAll, "ALLE Datensätze im System werden geändert")
        Me.CbChangeAll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblAnzahl)
        Me.GroupBox1.Controls.Add(Me.CbChangeAll)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBT12_3)
        Me.GroupBox1.Controls.Add(Me.CBT12_2)
        Me.GroupBox1.Controls.Add(Me.CBT12_1)
        Me.GroupBox1.Controls.Add(Me.CB3)
        Me.GroupBox1.Controls.Add(Me.TBAenderung3)
        Me.GroupBox1.Controls.Add(Me.TBSpalte3)
        Me.GroupBox1.Controls.Add(Me.TBZeile3)
        Me.GroupBox1.Controls.Add(Me.CB2)
        Me.GroupBox1.Controls.Add(Me.TBAenderung2)
        Me.GroupBox1.Controls.Add(Me.TBSpalte2)
        Me.GroupBox1.Controls.Add(Me.TBZeile2)
        Me.GroupBox1.Controls.Add(Me.CB1)
        Me.GroupBox1.Controls.Add(Me.TBAenderung1)
        Me.GroupBox1.Controls.Add(Me.TBSpalte1)
        Me.GroupBox1.Controls.Add(Me.TBZeile1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BStartMultiChange)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 139)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'LblAnzahl
        '
        Me.LblAnzahl.AutoSize = True
        Me.LblAnzahl.Location = New System.Drawing.Point(95, 43)
        Me.LblAnzahl.Name = "LblAnzahl"
        Me.LblAnzahl.Size = New System.Drawing.Size(25, 13)
        Me.LblAnzahl.TabIndex = 67
        Me.LblAnzahl.Text = "Anz"
        '
        'BDatenGenerieren
        '
        Me.BDatenGenerieren.Enabled = False
        Me.BDatenGenerieren.Location = New System.Drawing.Point(572, 125)
        Me.BDatenGenerieren.Name = "BDatenGenerieren"
        Me.BDatenGenerieren.Size = New System.Drawing.Size(97, 45)
        Me.BDatenGenerieren.TabIndex = 68
        Me.BDatenGenerieren.Text = "Daten generieren"
        Me.ToolTip1.SetToolTip(Me.BDatenGenerieren, "Datensätze aller eingegebenen ISNR und SART mit der angezeigten Vorlage neu erste" &
        "llen")
        Me.BDatenGenerieren.UseVisualStyleBackColor = True
        Me.BDatenGenerieren.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Information"
        '
        'CBSystem
        '
        Me.CBSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSystem.FormattingEnabled = True
        Me.CBSystem.Items.AddRange(New Object() {"GmbH/KFT", "Heyuan"})
        Me.CBSystem.Location = New System.Drawing.Point(20, 28)
        Me.CBSystem.Margin = New System.Windows.Forms.Padding(2)
        Me.CBSystem.Name = "CBSystem"
        Me.CBSystem.Size = New System.Drawing.Size(119, 25)
        Me.CBSystem.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.CBSystem, "Auswahl System der Datenabfrage")
        Me.CBSystem.Visible = False
        '
        'CheckBoxTimestamp
        '
        Me.CheckBoxTimestamp.AutoSize = True
        Me.CheckBoxTimestamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTimestamp.Location = New System.Drawing.Point(832, 104)
        Me.CheckBoxTimestamp.Name = "CheckBoxTimestamp"
        Me.CheckBoxTimestamp.Size = New System.Drawing.Size(195, 20)
        Me.CheckBoxTimestamp.TabIndex = 73
        Me.CheckBoxTimestamp.Text = "TIMESTAMP + 5 Minuten"
        Me.ToolTip1.SetToolTip(Me.CheckBoxTimestamp, "TRUE = originaler TIMESTAMP + 5 Minuten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FALSE = neuer TIMESTEMP (jetzt)")
        Me.CheckBoxTimestamp.UseVisualStyleBackColor = True
        '
        'cbverifiziert
        '
        Me.cbverifiziert.AutoSize = True
        Me.cbverifiziert.Checked = True
        Me.cbverifiziert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbverifiziert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbverifiziert.Location = New System.Drawing.Point(832, 130)
        Me.cbverifiziert.Name = "cbverifiziert"
        Me.cbverifiziert.Size = New System.Drawing.Size(89, 20)
        Me.cbverifiziert.TabIndex = 74
        Me.cbverifiziert.Text = "verifiziert"
        Me.ToolTip1.SetToolTip(Me.cbverifiziert, "TRUE = ""verifiziert"" steht im Feld SOAP-Info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FALSE = SOAP-Info steht ""Datenmodif" &
        "ikation"" oder ""Datengeneration""")
        Me.cbverifiziert.UseVisualStyleBackColor = True
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(1424, 223)
        Me.LblVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(52, 26)
        Me.LblVersion.TabIndex = 69
        Me.LblVersion.Text = "Vxx"
        '
        'tbPersNr
        '
        Me.tbPersNr.BackColor = System.Drawing.Color.Red
        Me.tbPersNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPersNr.Location = New System.Drawing.Point(832, 75)
        Me.tbPersNr.Name = "tbPersNr"
        Me.tbPersNr.Size = New System.Drawing.Size(106, 29)
        Me.tbPersNr.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(829, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Personalnummer"
        '
        'lblNoData
        '
        Me.lblNoData.AutoSize = True
        Me.lblNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoData.ForeColor = System.Drawing.Color.Red
        Me.lblNoData.Location = New System.Drawing.Point(298, 514)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(359, 108)
        Me.lblNoData.TabIndex = 79
        Me.lblNoData.Text = "noData"
        Me.lblNoData.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(897, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label14.Location = New System.Drawing.Point(1094, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 16)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "GRÜN = Daten neu erzeugt"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1094, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 16)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "ROT = Daten nicht erzeugt"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginProfidToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1658, 24)
        Me.MenuStrip1.TabIndex = 83
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginProfidToolStripMenuItem
        '
        Me.LoginProfidToolStripMenuItem.Name = "LoginProfidToolStripMenuItem"
        Me.LoginProfidToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.LoginProfidToolStripMenuItem.Text = "Login Profid"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'Form_Verifikation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1658, 688)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblNoData)
        Me.Controls.Add(Me.cbverifiziert)
        Me.Controls.Add(Me.CheckBoxTimestamp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbPersNr)
        Me.Controls.Add(Me.CBSystem)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.BDatenGenerieren)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtDBPfad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBgetAll)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBTimestamp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ComboBoxSART)
        Me.Controls.Add(Me.Button_Daten_schreiben)
        Me.Controls.Add(Me.ButtonBeenden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_ISNR)
        Me.Controls.Add(Me.TextBoxISNR)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Verifikation"
        Me.Text = "TIM Verifikation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Start As Button
    Friend WithEvents TextBoxISNR As TextBox
    Friend WithEvents Label_ISNR As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBeenden As Button
    Friend WithEvents Button_Daten_schreiben As Button
    Friend WithEvents ComboBoxSART As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents T2 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBTimestamp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBgetAll As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BStartMultiChange As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TBZeile1 As TextBox
    Friend WithEvents TBSpalte1 As TextBox
    Friend WithEvents TBAenderung1 As TextBox
    Friend WithEvents CB1 As CheckBox
    Friend WithEvents CB2 As CheckBox
    Friend WithEvents TBAenderung2 As TextBox
    Friend WithEvents TBSpalte2 As TextBox
    Friend WithEvents TBZeile2 As TextBox
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents TBAenderung3 As TextBox
    Friend WithEvents TBSpalte3 As TextBox
    Friend WithEvents TBZeile3 As TextBox
    Friend WithEvents CBT12_1 As ComboBox
    Friend WithEvents CBT12_2 As ComboBox
    Friend WithEvents CBT12_3 As ComboBox
    Friend WithEvents BtDBPfad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CbChangeAll As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BDatenGenerieren As Button
    Friend WithEvents LblAnzahl As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LblVersion As Label
    Friend WithEvents CBSystem As ComboBox
    Friend WithEvents tbPersNr As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBoxTimestamp As CheckBox
    Friend WithEvents cbverifiziert As CheckBox
    Friend WithEvents T1 As DataGridViewTextBoxColumn
    Friend WithEvents BISNR As DataGridViewTextBoxColumn
    Friend WithEvents KSNR As DataGridViewTextBoxColumn
    Friend WithEvents Auftrag As DataGridViewTextBoxColumn
    Friend WithEvents Abruf As DataGridViewTextBoxColumn
    Friend WithEvents Rest As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Anlagennummer As DataGridViewTextBoxColumn
    Friend WithEvents PersNR As DataGridViewTextBoxColumn
    Friend WithEvents Version As DataGridViewTextBoxColumn
    Friend WithEvents Mandant As DataGridViewTextBoxColumn
    Friend WithEvents Funktionsgruppe As DataGridViewTextBoxColumn
    Friend WithEvents Timestamp As DataGridViewTextBoxColumn
    Friend WithEvents Einzel_OK As DataGridViewTextBoxColumn
    Friend WithEvents Nutzen_OK As DataGridViewTextBoxColumn
    Friend WithEvents Prüfungszähler As DataGridViewTextBoxColumn
    Friend WithEvents SOAP_aktiv As DataGridViewTextBoxColumn
    Friend WithEvents SOAP_Info As DataGridViewTextBoxColumn
    Friend WithEvents SOAP_PersNR As DataGridViewTextBoxColumn
    Friend WithEvents NameProg As DataGridViewTextBoxColumn
    Friend WithEvents VersionProg As DataGridViewTextBoxColumn
    Friend WithEvents Res1 As DataGridViewTextBoxColumn
    Friend WithEvents Res2 As DataGridViewTextBoxColumn
    Friend WithEvents Res3 As DataGridViewTextBoxColumn
    Friend WithEvents Res4 As DataGridViewTextBoxColumn
    Friend WithEvents Res5 As DataGridViewTextBoxColumn
    Friend WithEvents lblNoData As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginProfidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
End Class
