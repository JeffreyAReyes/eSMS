<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackUpDatabase
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btAll = New System.Windows.Forms.Button
        Me.btNone = New System.Windows.Forms.Button
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.colnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colnTable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colnSql = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label14 = New System.Windows.Forms.Label
        Me.btExpand = New System.Windows.Forms.Button
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.lbImportErr = New System.Windows.Forms.Label
        Me.lbTotalBytes = New System.Windows.Forms.Label
        Me.pbBytes = New System.Windows.Forms.ProgressBar
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.pgGetTotalRows = New System.Windows.Forms.ProgressBar
        Me.lbTotalTableDB = New System.Windows.Forms.Label
        Me.lbGetTotalRows = New System.Windows.Forms.Label
        Me.lbCurrentTable = New System.Windows.Forms.Label
        Me.pbRowsTable = New System.Windows.Forms.ProgressBar
        Me.label9 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.pbTable = New System.Windows.Forms.ProgressBar
        Me.lbPercentage = New System.Windows.Forms.Label
        Me.lbRowProgressDB = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label8 = New System.Windows.Forms.Label
        Me.pbPercent = New System.Windows.Forms.ProgressBar
        Me.pbRowsDB = New System.Windows.Forms.ProgressBar
        Me.lbRowProgressCurTable = New System.Windows.Forms.Label
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.cbZip = New System.Windows.Forms.CheckBox
        Me.cbRecordDumpTime = New System.Windows.Forms.CheckBox
        Me.label11 = New System.Windows.Forms.Label
        Me.nmSQLLength = New System.Windows.Forms.NumericUpDown
        Me.label6 = New System.Windows.Forms.Label
        Me.cbAutoCloseConnectionExport = New System.Windows.Forms.CheckBox
        Me.cbExProcedure = New System.Windows.Forms.CheckBox
        Me.cbExViews = New System.Windows.Forms.CheckBox
        Me.cbExFunction = New System.Windows.Forms.CheckBox
        Me.txtEncryptionKey = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.cbExEvent = New System.Windows.Forms.CheckBox
        Me.cbEnableEncryption = New System.Windows.Forms.CheckBox
        Me.cbAsynchronousModeExport = New System.Windows.Forms.CheckBox
        Me.cbExTrigger = New System.Windows.Forms.CheckBox
        Me.cbAddCreateDatabase = New System.Windows.Forms.CheckBox
        Me.cbExportTableStructure = New System.Windows.Forms.CheckBox
        Me.cbCalculateTotalRowsFromDatabase = New System.Windows.Forms.CheckBox
        Me.cbResetAutoIncrement = New System.Windows.Forms.CheckBox
        Me.cbExportRows = New System.Windows.Forms.CheckBox
        Me.tabPage2 = New System.Windows.Forms.TabPage
        Me.cbCharSet = New System.Windows.Forms.ComboBox
        Me.cbImAutoCloseConnection = New System.Windows.Forms.CheckBox
        Me.label10 = New System.Windows.Forms.Label
        Me.txtTargetDatabase = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.txtImEncryptKey = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cbImAsyn = New System.Windows.Forms.CheckBox
        Me.cbImIgnoreSqlError = New System.Windows.Forms.CheckBox
        Me.cbImEnableEncrypt = New System.Windows.Forms.CheckBox
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.lbHashResult = New System.Windows.Forms.Label
        Me.label13 = New System.Windows.Forms.Label
        Me.label12 = New System.Windows.Forms.Label
        Me.txtHash2 = New System.Windows.Forms.TextBox
        Me.txtHashFile2 = New System.Windows.Forms.TextBox
        Me.txtHash1 = New System.Windows.Forms.TextBox
        Me.txtHashFile1 = New System.Windows.Forms.TextBox
        Me.btHashFile2 = New System.Windows.Forms.Button
        Me.btHashFile1 = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.btDeleteAllRows = New System.Windows.Forms.Button
        Me.btCancelImport = New System.Windows.Forms.Button
        Me.btCancelExport = New System.Windows.Forms.Button
        Me.btExport = New System.Windows.Forms.Button
        Me.btImport = New System.Windows.Forms.Button
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.nmSQLLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btAll
        '
        Me.btAll.Location = New System.Drawing.Point(3, 3)
        Me.btAll.Name = "btAll"
        Me.btAll.Size = New System.Drawing.Size(44, 23)
        Me.btAll.TabIndex = 0
        Me.btAll.Text = "All"
        Me.btAll.UseVisualStyleBackColor = True
        '
        'btNone
        '
        Me.btNone.Location = New System.Drawing.Point(53, 3)
        Me.btNone.Name = "btNone"
        Me.btNone.Size = New System.Drawing.Size(44, 23)
        Me.btNone.TabIndex = 1
        Me.btNone.Text = "None"
        Me.btNone.UseVisualStyleBackColor = True
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.dataGridView1)
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.groupBox2)
        Me.splitContainer1.Panel2.Controls.Add(Me.groupBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer1.Panel2.Controls.Add(Me.panel2)
        Me.splitContainer1.Size = New System.Drawing.Size(884, 662)
        Me.splitContainer1.SplitterDistance = 237
        Me.splitContainer1.SplitterWidth = 10
        Me.splitContainer1.TabIndex = 1
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnSelect, Me.colnTable, Me.colnSql})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 50)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.Size = New System.Drawing.Size(237, 612)
        Me.dataGridView1.TabIndex = 4
        '
        'colnSelect
        '
        Me.colnSelect.HeaderText = ""
        Me.colnSelect.Name = "colnSelect"
        Me.colnSelect.Width = 30
        '
        'colnTable
        '
        Me.colnTable.HeaderText = "Table"
        Me.colnTable.Name = "colnTable"
        Me.colnTable.Width = 170
        '
        'colnSql
        '
        Me.colnSql.HeaderText = "SQL"
        Me.colnSql.Name = "colnSql"
        Me.colnSql.Width = 600
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label14)
        Me.panel1.Controls.Add(Me.btExpand)
        Me.panel1.Controls.Add(Me.btAll)
        Me.panel1.Controls.Add(Me.btNone)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(237, 50)
        Me.panel1.TabIndex = 3
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(4, 31)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(56, 13)
        Me.label14.TabIndex = 5
        Me.label14.Text = "None = All"
        '
        'btExpand
        '
        Me.btExpand.Location = New System.Drawing.Point(103, 3)
        Me.btExpand.Name = "btExpand"
        Me.btExpand.Size = New System.Drawing.Size(75, 23)
        Me.btExpand.TabIndex = 4
        Me.btExpand.Text = "Expand"
        Me.btExpand.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lbImportErr)
        Me.groupBox2.Controls.Add(Me.lbTotalBytes)
        Me.groupBox2.Controls.Add(Me.pbBytes)
        Me.groupBox2.Location = New System.Drawing.Point(10, 525)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(621, 125)
        Me.groupBox2.TabIndex = 73
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Import Progress"
        '
        'lbImportErr
        '
        Me.lbImportErr.AutoSize = True
        Me.lbImportErr.Location = New System.Drawing.Point(46, 89)
        Me.lbImportErr.Name = "lbImportErr"
        Me.lbImportErr.Size = New System.Drawing.Size(0, 13)
        Me.lbImportErr.TabIndex = 4
        '
        'lbTotalBytes
        '
        Me.lbTotalBytes.AutoSize = True
        Me.lbTotalBytes.Location = New System.Drawing.Point(50, 34)
        Me.lbTotalBytes.Name = "lbTotalBytes"
        Me.lbTotalBytes.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalBytes.TabIndex = 3
        '
        'pbBytes
        '
        Me.pbBytes.Location = New System.Drawing.Point(47, 50)
        Me.pbBytes.Name = "pbBytes"
        Me.pbBytes.Size = New System.Drawing.Size(531, 23)
        Me.pbBytes.TabIndex = 2
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.pgGetTotalRows)
        Me.groupBox1.Controls.Add(Me.lbTotalTableDB)
        Me.groupBox1.Controls.Add(Me.lbGetTotalRows)
        Me.groupBox1.Controls.Add(Me.lbCurrentTable)
        Me.groupBox1.Controls.Add(Me.pbRowsTable)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.pbTable)
        Me.groupBox1.Controls.Add(Me.lbPercentage)
        Me.groupBox1.Controls.Add(Me.lbRowProgressDB)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.pbPercent)
        Me.groupBox1.Controls.Add(Me.pbRowsDB)
        Me.groupBox1.Controls.Add(Me.lbRowProgressCurTable)
        Me.groupBox1.Location = New System.Drawing.Point(10, 292)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(621, 227)
        Me.groupBox1.TabIndex = 72
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Export Progress"
        '
        'pgGetTotalRows
        '
        Me.pgGetTotalRows.Location = New System.Drawing.Point(47, 44)
        Me.pgGetTotalRows.Name = "pgGetTotalRows"
        Me.pgGetTotalRows.Size = New System.Drawing.Size(531, 23)
        Me.pgGetTotalRows.TabIndex = 70
        '
        'lbTotalTableDB
        '
        Me.lbTotalTableDB.AutoSize = True
        Me.lbTotalTableDB.Location = New System.Drawing.Point(401, 174)
        Me.lbTotalTableDB.Name = "lbTotalTableDB"
        Me.lbTotalTableDB.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalTableDB.TabIndex = 67
        '
        'lbGetTotalRows
        '
        Me.lbGetTotalRows.AutoSize = True
        Me.lbGetTotalRows.Location = New System.Drawing.Point(46, 28)
        Me.lbGetTotalRows.Name = "lbGetTotalRows"
        Me.lbGetTotalRows.Size = New System.Drawing.Size(0, 13)
        Me.lbGetTotalRows.TabIndex = 71
        '
        'lbCurrentTable
        '
        Me.lbCurrentTable.AutoSize = True
        Me.lbCurrentTable.Location = New System.Drawing.Point(120, 154)
        Me.lbCurrentTable.Name = "lbCurrentTable"
        Me.lbCurrentTable.Size = New System.Drawing.Size(0, 13)
        Me.lbCurrentTable.TabIndex = 59
        '
        'pbRowsTable
        '
        Me.pbRowsTable.Location = New System.Drawing.Point(47, 190)
        Me.pbRowsTable.Name = "pbRowsTable"
        Me.pbRowsTable.Size = New System.Drawing.Size(249, 23)
        Me.pbRowsTable.TabIndex = 57
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(326, 174)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(69, 13)
        Me.label9.TabIndex = 66
        Me.label9.Text = "Total Tables:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(44, 154)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(74, 13)
        Me.label4.TabIndex = 58
        Me.label4.Text = "Current Table:"
        '
        'pbTable
        '
        Me.pbTable.Location = New System.Drawing.Point(329, 190)
        Me.pbTable.Name = "pbTable"
        Me.pbTable.Size = New System.Drawing.Size(249, 23)
        Me.pbTable.TabIndex = 65
        '
        'lbPercentage
        '
        Me.lbPercentage.AutoSize = True
        Me.lbPercentage.Location = New System.Drawing.Point(51, 103)
        Me.lbPercentage.Name = "lbPercentage"
        Me.lbPercentage.Size = New System.Drawing.Size(0, 13)
        Me.lbPercentage.TabIndex = 69
        '
        'lbRowProgressDB
        '
        Me.lbRowProgressDB.AutoSize = True
        Me.lbRowProgressDB.Location = New System.Drawing.Point(401, 103)
        Me.lbRowProgressDB.Name = "lbRowProgressDB"
        Me.lbRowProgressDB.Size = New System.Drawing.Size(0, 13)
        Me.lbRowProgressDB.TabIndex = 64
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(44, 174)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 60
        Me.label5.Text = "Rows:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(326, 103)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(64, 13)
        Me.label8.TabIndex = 63
        Me.label8.Text = "Total Rows:"
        '
        'pbPercent
        '
        Me.pbPercent.Location = New System.Drawing.Point(47, 119)
        Me.pbPercent.Name = "pbPercent"
        Me.pbPercent.Size = New System.Drawing.Size(249, 23)
        Me.pbPercent.TabIndex = 68
        '
        'pbRowsDB
        '
        Me.pbRowsDB.Location = New System.Drawing.Point(329, 119)
        Me.pbRowsDB.MarqueeAnimationSpeed = 1000
        Me.pbRowsDB.Name = "pbRowsDB"
        Me.pbRowsDB.Size = New System.Drawing.Size(249, 23)
        Me.pbRowsDB.TabIndex = 62
        '
        'lbRowProgressCurTable
        '
        Me.lbRowProgressCurTable.AutoSize = True
        Me.lbRowProgressCurTable.Location = New System.Drawing.Point(120, 174)
        Me.lbRowProgressCurTable.Name = "lbRowProgressCurTable"
        Me.lbRowProgressCurTable.Size = New System.Drawing.Size(0, 13)
        Me.lbRowProgressCurTable.TabIndex = 61
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabControl1.Location = New System.Drawing.Point(0, 69)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(637, 175)
        Me.tabControl1.TabIndex = 55
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.cbZip)
        Me.tabPage1.Controls.Add(Me.cbRecordDumpTime)
        Me.tabPage1.Controls.Add(Me.label11)
        Me.tabPage1.Controls.Add(Me.nmSQLLength)
        Me.tabPage1.Controls.Add(Me.label6)
        Me.tabPage1.Controls.Add(Me.cbAutoCloseConnectionExport)
        Me.tabPage1.Controls.Add(Me.cbExProcedure)
        Me.tabPage1.Controls.Add(Me.cbExViews)
        Me.tabPage1.Controls.Add(Me.cbExFunction)
        Me.tabPage1.Controls.Add(Me.txtEncryptionKey)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.cbExEvent)
        Me.tabPage1.Controls.Add(Me.cbEnableEncryption)
        Me.tabPage1.Controls.Add(Me.cbAsynchronousModeExport)
        Me.tabPage1.Controls.Add(Me.cbExTrigger)
        Me.tabPage1.Controls.Add(Me.cbAddCreateDatabase)
        Me.tabPage1.Controls.Add(Me.cbExportTableStructure)
        Me.tabPage1.Controls.Add(Me.cbCalculateTotalRowsFromDatabase)
        Me.tabPage1.Controls.Add(Me.cbResetAutoIncrement)
        Me.tabPage1.Controls.Add(Me.cbExportRows)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(629, 149)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Export Informations"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'cbZip
        '
        Me.cbZip.AutoSize = True
        Me.cbZip.Location = New System.Drawing.Point(399, 52)
        Me.cbZip.Name = "cbZip"
        Me.cbZip.Size = New System.Drawing.Size(123, 17)
        Me.cbZip.TabIndex = 66
        Me.cbZip.Text = "Compress as Zip File"
        Me.cbZip.UseVisualStyleBackColor = True
        '
        'cbRecordDumpTime
        '
        Me.cbRecordDumpTime.AutoSize = True
        Me.cbRecordDumpTime.Checked = True
        Me.cbRecordDumpTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbRecordDumpTime.Location = New System.Drawing.Point(399, 29)
        Me.cbRecordDumpTime.Name = "cbRecordDumpTime"
        Me.cbRecordDumpTime.Size = New System.Drawing.Size(118, 17)
        Me.cbRecordDumpTime.TabIndex = 65
        Me.cbRecordDumpTime.Text = "Record Dump Time"
        Me.cbRecordDumpTime.UseVisualStyleBackColor = True
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(421, 95)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(173, 13)
        Me.label11.TabIndex = 64
        Me.label11.Text = "Default Length: 1MB (1024 x 1024)"
        '
        'nmSQLLength
        '
        Me.nmSQLLength.Location = New System.Drawing.Point(537, 72)
        Me.nmSQLLength.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nmSQLLength.Minimum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nmSQLLength.Name = "nmSQLLength"
        Me.nmSQLLength.Size = New System.Drawing.Size(84, 20)
        Me.nmSQLLength.TabIndex = 62
        Me.nmSQLLength.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(396, 73)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(135, 13)
        Me.label6.TabIndex = 61
        Me.label6.Text = "Max Exported SQL Length:"
        '
        'cbAutoCloseConnectionExport
        '
        Me.cbAutoCloseConnectionExport.AutoSize = True
        Me.cbAutoCloseConnectionExport.Checked = True
        Me.cbAutoCloseConnectionExport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAutoCloseConnectionExport.Location = New System.Drawing.Point(399, 6)
        Me.cbAutoCloseConnectionExport.Name = "cbAutoCloseConnectionExport"
        Me.cbAutoCloseConnectionExport.Size = New System.Drawing.Size(134, 17)
        Me.cbAutoCloseConnectionExport.TabIndex = 60
        Me.cbAutoCloseConnectionExport.Text = "Auto Close Connection"
        Me.cbAutoCloseConnectionExport.UseVisualStyleBackColor = True
        '
        'cbExProcedure
        '
        Me.cbExProcedure.AutoSize = True
        Me.cbExProcedure.Checked = True
        Me.cbExProcedure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExProcedure.Location = New System.Drawing.Point(229, 6)
        Me.cbExProcedure.Name = "cbExProcedure"
        Me.cbExProcedure.Size = New System.Drawing.Size(147, 17)
        Me.cbExProcedure.TabIndex = 55
        Me.cbExProcedure.Text = "Export Stored Procedures"
        Me.cbExProcedure.UseVisualStyleBackColor = True
        '
        'cbExViews
        '
        Me.cbExViews.AutoSize = True
        Me.cbExViews.Checked = True
        Me.cbExViews.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExViews.Location = New System.Drawing.Point(229, 98)
        Me.cbExViews.Name = "cbExViews"
        Me.cbExViews.Size = New System.Drawing.Size(87, 17)
        Me.cbExViews.TabIndex = 59
        Me.cbExViews.Text = "Export Views"
        Me.cbExViews.UseVisualStyleBackColor = True
        '
        'cbExFunction
        '
        Me.cbExFunction.AutoSize = True
        Me.cbExFunction.Checked = True
        Me.cbExFunction.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExFunction.Location = New System.Drawing.Point(229, 29)
        Me.cbExFunction.Name = "cbExFunction"
        Me.cbExFunction.Size = New System.Drawing.Size(105, 17)
        Me.cbExFunction.TabIndex = 56
        Me.cbExFunction.Text = "Export Functions"
        Me.cbExFunction.UseVisualStyleBackColor = True
        '
        'txtEncryptionKey
        '
        Me.txtEncryptionKey.Location = New System.Drawing.Point(447, 120)
        Me.txtEncryptionKey.Name = "txtEncryptionKey"
        Me.txtEncryptionKey.Size = New System.Drawing.Size(122, 20)
        Me.txtEncryptionKey.TabIndex = 49
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(374, 122)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(67, 13)
        Me.label2.TabIndex = 48
        Me.label2.Text = "Encrypt Key:"
        '
        'cbExEvent
        '
        Me.cbExEvent.AutoSize = True
        Me.cbExEvent.Checked = True
        Me.cbExEvent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExEvent.Location = New System.Drawing.Point(229, 75)
        Me.cbExEvent.Name = "cbExEvent"
        Me.cbExEvent.Size = New System.Drawing.Size(92, 17)
        Me.cbExEvent.TabIndex = 58
        Me.cbExEvent.Text = "Export Events"
        Me.cbExEvent.UseVisualStyleBackColor = True
        '
        'cbEnableEncryption
        '
        Me.cbEnableEncryption.AutoSize = True
        Me.cbEnableEncryption.Location = New System.Drawing.Point(229, 121)
        Me.cbEnableEncryption.Name = "cbEnableEncryption"
        Me.cbEnableEncryption.Size = New System.Drawing.Size(112, 17)
        Me.cbEnableEncryption.TabIndex = 47
        Me.cbEnableEncryption.Text = "Enable Encryption"
        Me.cbEnableEncryption.UseVisualStyleBackColor = True
        '
        'cbAsynchronousModeExport
        '
        Me.cbAsynchronousModeExport.AutoSize = True
        Me.cbAsynchronousModeExport.Checked = True
        Me.cbAsynchronousModeExport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAsynchronousModeExport.Location = New System.Drawing.Point(6, 6)
        Me.cbAsynchronousModeExport.Name = "cbAsynchronousModeExport"
        Me.cbAsynchronousModeExport.Size = New System.Drawing.Size(123, 17)
        Me.cbAsynchronousModeExport.TabIndex = 54
        Me.cbAsynchronousModeExport.Text = "Asynchronous Mode"
        Me.cbAsynchronousModeExport.UseVisualStyleBackColor = True
        '
        'cbExTrigger
        '
        Me.cbExTrigger.AutoSize = True
        Me.cbExTrigger.Checked = True
        Me.cbExTrigger.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExTrigger.Location = New System.Drawing.Point(229, 52)
        Me.cbExTrigger.Name = "cbExTrigger"
        Me.cbExTrigger.Size = New System.Drawing.Size(97, 17)
        Me.cbExTrigger.TabIndex = 57
        Me.cbExTrigger.Text = "Export Triggers"
        Me.cbExTrigger.UseVisualStyleBackColor = True
        '
        'cbAddCreateDatabase
        '
        Me.cbAddCreateDatabase.AutoSize = True
        Me.cbAddCreateDatabase.Location = New System.Drawing.Point(6, 29)
        Me.cbAddCreateDatabase.Name = "cbAddCreateDatabase"
        Me.cbAddCreateDatabase.Size = New System.Drawing.Size(200, 17)
        Me.cbAddCreateDatabase.TabIndex = 52
        Me.cbAddCreateDatabase.Text = "Add CREATE DATABASE statement"
        Me.cbAddCreateDatabase.UseVisualStyleBackColor = True
        '
        'cbExportTableStructure
        '
        Me.cbExportTableStructure.AutoSize = True
        Me.cbExportTableStructure.Checked = True
        Me.cbExportTableStructure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExportTableStructure.Location = New System.Drawing.Point(6, 52)
        Me.cbExportTableStructure.Name = "cbExportTableStructure"
        Me.cbExportTableStructure.Size = New System.Drawing.Size(126, 17)
        Me.cbExportTableStructure.TabIndex = 45
        Me.cbExportTableStructure.Text = "ExportTableStructure"
        Me.cbExportTableStructure.UseVisualStyleBackColor = True
        '
        'cbCalculateTotalRowsFromDatabase
        '
        Me.cbCalculateTotalRowsFromDatabase.AutoSize = True
        Me.cbCalculateTotalRowsFromDatabase.Checked = True
        Me.cbCalculateTotalRowsFromDatabase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCalculateTotalRowsFromDatabase.Location = New System.Drawing.Point(6, 98)
        Me.cbCalculateTotalRowsFromDatabase.Name = "cbCalculateTotalRowsFromDatabase"
        Me.cbCalculateTotalRowsFromDatabase.Size = New System.Drawing.Size(202, 17)
        Me.cbCalculateTotalRowsFromDatabase.TabIndex = 51
        Me.cbCalculateTotalRowsFromDatabase.Text = "Calculate Total Rows From Database"
        Me.cbCalculateTotalRowsFromDatabase.UseVisualStyleBackColor = True
        '
        'cbResetAutoIncrement
        '
        Me.cbResetAutoIncrement.AutoSize = True
        Me.cbResetAutoIncrement.Location = New System.Drawing.Point(6, 121)
        Me.cbResetAutoIncrement.Name = "cbResetAutoIncrement"
        Me.cbResetAutoIncrement.Size = New System.Drawing.Size(150, 17)
        Me.cbResetAutoIncrement.TabIndex = 50
        Me.cbResetAutoIncrement.Text = "Reset Auto Increment to 1"
        Me.cbResetAutoIncrement.UseVisualStyleBackColor = True
        '
        'cbExportRows
        '
        Me.cbExportRows.AutoSize = True
        Me.cbExportRows.Checked = True
        Me.cbExportRows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExportRows.Location = New System.Drawing.Point(6, 75)
        Me.cbExportRows.Name = "cbExportRows"
        Me.cbExportRows.Size = New System.Drawing.Size(112, 17)
        Me.cbExportRows.TabIndex = 46
        Me.cbExportRows.Text = "Export Data Rows"
        Me.cbExportRows.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.cbCharSet)
        Me.tabPage2.Controls.Add(Me.cbImAutoCloseConnection)
        Me.tabPage2.Controls.Add(Me.label10)
        Me.tabPage2.Controls.Add(Me.txtTargetDatabase)
        Me.tabPage2.Controls.Add(Me.label3)
        Me.tabPage2.Controls.Add(Me.txtImEncryptKey)
        Me.tabPage2.Controls.Add(Me.label1)
        Me.tabPage2.Controls.Add(Me.cbImAsyn)
        Me.tabPage2.Controls.Add(Me.cbImIgnoreSqlError)
        Me.tabPage2.Controls.Add(Me.cbImEnableEncrypt)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(629, 149)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Import Informations"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'cbCharSet
        '
        Me.cbCharSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCharSet.FormattingEnabled = True
        Me.cbCharSet.Location = New System.Drawing.Point(389, 56)
        Me.cbCharSet.Name = "cbCharSet"
        Me.cbCharSet.Size = New System.Drawing.Size(121, 23)
        Me.cbCharSet.TabIndex = 66
        '
        'cbImAutoCloseConnection
        '
        Me.cbImAutoCloseConnection.AutoSize = True
        Me.cbImAutoCloseConnection.Checked = True
        Me.cbImAutoCloseConnection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbImAutoCloseConnection.Location = New System.Drawing.Point(6, 29)
        Me.cbImAutoCloseConnection.Name = "cbImAutoCloseConnection"
        Me.cbImAutoCloseConnection.Size = New System.Drawing.Size(134, 17)
        Me.cbImAutoCloseConnection.TabIndex = 65
        Me.cbImAutoCloseConnection.Text = "Auto Close Connection"
        Me.cbImAutoCloseConnection.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(271, 60)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(112, 13)
        Me.label10.TabIndex = 63
        Me.label10.Text = "Default Character Set:"
        '
        'txtTargetDatabase
        '
        Me.txtTargetDatabase.Location = New System.Drawing.Point(389, 29)
        Me.txtTargetDatabase.Name = "txtTargetDatabase"
        Me.txtTargetDatabase.Size = New System.Drawing.Size(189, 20)
        Me.txtTargetDatabase.TabIndex = 62
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(293, 32)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(90, 13)
        Me.label3.TabIndex = 61
        Me.label3.Text = "Target Database:"
        '
        'txtImEncryptKey
        '
        Me.txtImEncryptKey.Location = New System.Drawing.Point(95, 97)
        Me.txtImEncryptKey.Name = "txtImEncryptKey"
        Me.txtImEncryptKey.Size = New System.Drawing.Size(122, 20)
        Me.txtImEncryptKey.TabIndex = 59
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(22, 99)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 58
        Me.label1.Text = "Encrypt Key:"
        '
        'cbImAsyn
        '
        Me.cbImAsyn.AutoSize = True
        Me.cbImAsyn.Checked = True
        Me.cbImAsyn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbImAsyn.Location = New System.Drawing.Point(6, 6)
        Me.cbImAsyn.Name = "cbImAsyn"
        Me.cbImAsyn.Size = New System.Drawing.Size(123, 17)
        Me.cbImAsyn.TabIndex = 60
        Me.cbImAsyn.Text = "Asynchronous Mode"
        Me.cbImAsyn.UseVisualStyleBackColor = True
        '
        'cbImIgnoreSqlError
        '
        Me.cbImIgnoreSqlError.AutoSize = True
        Me.cbImIgnoreSqlError.Location = New System.Drawing.Point(6, 52)
        Me.cbImIgnoreSqlError.Name = "cbImIgnoreSqlError"
        Me.cbImIgnoreSqlError.Size = New System.Drawing.Size(119, 17)
        Me.cbImIgnoreSqlError.TabIndex = 53
        Me.cbImIgnoreSqlError.Text = "Ignore Error (Import)"
        Me.cbImIgnoreSqlError.UseVisualStyleBackColor = True
        '
        'cbImEnableEncrypt
        '
        Me.cbImEnableEncrypt.AutoSize = True
        Me.cbImEnableEncrypt.Location = New System.Drawing.Point(6, 75)
        Me.cbImEnableEncrypt.Name = "cbImEnableEncrypt"
        Me.cbImEnableEncrypt.Size = New System.Drawing.Size(112, 17)
        Me.cbImEnableEncrypt.TabIndex = 57
        Me.cbImEnableEncrypt.Text = "Enable Encryption"
        Me.cbImEnableEncrypt.UseVisualStyleBackColor = True
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.lbHashResult)
        Me.tabPage3.Controls.Add(Me.label13)
        Me.tabPage3.Controls.Add(Me.label12)
        Me.tabPage3.Controls.Add(Me.txtHash2)
        Me.tabPage3.Controls.Add(Me.txtHashFile2)
        Me.tabPage3.Controls.Add(Me.txtHash1)
        Me.tabPage3.Controls.Add(Me.txtHashFile1)
        Me.tabPage3.Controls.Add(Me.btHashFile2)
        Me.tabPage3.Controls.Add(Me.btHashFile1)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(629, 149)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Compare Dump Files"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'lbHashResult
        '
        Me.lbHashResult.AutoSize = True
        Me.lbHashResult.Location = New System.Drawing.Point(108, 123)
        Me.lbHashResult.Name = "lbHashResult"
        Me.lbHashResult.Size = New System.Drawing.Size(0, 13)
        Me.lbHashResult.TabIndex = 8
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(45, 96)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(60, 13)
        Me.label13.TabIndex = 7
        Me.label13.Text = "Checksum:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(45, 44)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(60, 13)
        Me.label12.TabIndex = 6
        Me.label12.Text = "Checksum:"
        '
        'txtHash2
        '
        Me.txtHash2.Location = New System.Drawing.Point(111, 93)
        Me.txtHash2.Name = "txtHash2"
        Me.txtHash2.Size = New System.Drawing.Size(503, 20)
        Me.txtHash2.TabIndex = 5
        '
        'txtHashFile2
        '
        Me.txtHashFile2.Location = New System.Drawing.Point(111, 67)
        Me.txtHashFile2.Name = "txtHashFile2"
        Me.txtHashFile2.Size = New System.Drawing.Size(503, 20)
        Me.txtHashFile2.TabIndex = 4
        '
        'txtHash1
        '
        Me.txtHash1.Location = New System.Drawing.Point(111, 41)
        Me.txtHash1.Name = "txtHash1"
        Me.txtHash1.Size = New System.Drawing.Size(503, 20)
        Me.txtHash1.TabIndex = 3
        '
        'txtHashFile1
        '
        Me.txtHashFile1.Location = New System.Drawing.Point(111, 15)
        Me.txtHashFile1.Name = "txtHashFile1"
        Me.txtHashFile1.Size = New System.Drawing.Size(503, 20)
        Me.txtHashFile1.TabIndex = 2
        '
        'btHashFile2
        '
        Me.btHashFile2.Location = New System.Drawing.Point(15, 65)
        Me.btHashFile2.Name = "btHashFile2"
        Me.btHashFile2.Size = New System.Drawing.Size(90, 23)
        Me.btHashFile2.TabIndex = 1
        Me.btHashFile2.Text = "Open File 2"
        Me.btHashFile2.UseVisualStyleBackColor = True
        '
        'btHashFile1
        '
        Me.btHashFile1.Location = New System.Drawing.Point(15, 13)
        Me.btHashFile1.Name = "btHashFile1"
        Me.btHashFile1.Size = New System.Drawing.Size(90, 23)
        Me.btHashFile1.TabIndex = 0
        Me.btHashFile1.Text = "Open File 1"
        Me.btHashFile1.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.btDeleteAllRows)
        Me.panel2.Controls.Add(Me.btCancelImport)
        Me.panel2.Controls.Add(Me.btCancelExport)
        Me.panel2.Controls.Add(Me.btExport)
        Me.panel2.Controls.Add(Me.btImport)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(637, 69)
        Me.panel2.TabIndex = 56
        '
        'btDeleteAllRows
        '
        Me.btDeleteAllRows.Location = New System.Drawing.Point(531, 14)
        Me.btDeleteAllRows.Name = "btDeleteAllRows"
        Me.btDeleteAllRows.Size = New System.Drawing.Size(94, 42)
        Me.btDeleteAllRows.TabIndex = 4
        Me.btDeleteAllRows.Text = "Delete All Rows"
        Me.btDeleteAllRows.UseVisualStyleBackColor = True
        '
        'btCancelImport
        '
        Me.btCancelImport.Enabled = False
        Me.btCancelImport.Location = New System.Drawing.Point(411, 14)
        Me.btCancelImport.Name = "btCancelImport"
        Me.btCancelImport.Size = New System.Drawing.Size(94, 42)
        Me.btCancelImport.TabIndex = 3
        Me.btCancelImport.Text = "Cancel Import"
        Me.btCancelImport.UseVisualStyleBackColor = True
        '
        'btCancelExport
        '
        Me.btCancelExport.Enabled = False
        Me.btCancelExport.Location = New System.Drawing.Point(147, 14)
        Me.btCancelExport.Name = "btCancelExport"
        Me.btCancelExport.Size = New System.Drawing.Size(94, 42)
        Me.btCancelExport.TabIndex = 2
        Me.btCancelExport.Text = "Cancel Export"
        Me.btCancelExport.UseVisualStyleBackColor = True
        '
        'btExport
        '
        Me.btExport.Location = New System.Drawing.Point(10, 14)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(131, 42)
        Me.btExport.TabIndex = 0
        Me.btExport.Text = "Export (Backup)"
        Me.btExport.UseVisualStyleBackColor = True
        '
        'btImport
        '
        Me.btImport.Location = New System.Drawing.Point(274, 14)
        Me.btImport.Name = "btImport"
        Me.btImport.Size = New System.Drawing.Size(131, 42)
        Me.btImport.TabIndex = 1
        Me.btImport.Text = "Import (Restore)"
        Me.btImport.UseVisualStyleBackColor = True
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 10
        '
        'frmMainDemo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 662)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "frmMainDemo3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Demo"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.nmSQLLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents btAll As System.Windows.Forms.Button
    Private WithEvents btNone As System.Windows.Forms.Button
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private panel1 As System.Windows.Forms.Panel
    Private WithEvents btExpand As System.Windows.Forms.Button
    Private WithEvents btImport As System.Windows.Forms.Button
    Private WithEvents btExport As System.Windows.Forms.Button
    Private tabControl1 As System.Windows.Forms.TabControl
    Private tabPage1 As System.Windows.Forms.TabPage
    Private cbAddCreateDatabase As System.Windows.Forms.CheckBox
    Private cbAsynchronousModeExport As System.Windows.Forms.CheckBox
    Private cbExportTableStructure As System.Windows.Forms.CheckBox
    Private cbCalculateTotalRowsFromDatabase As System.Windows.Forms.CheckBox
    Private cbResetAutoIncrement As System.Windows.Forms.CheckBox
    Private cbExportRows As System.Windows.Forms.CheckBox
    Private tabPage2 As System.Windows.Forms.TabPage
    Private cbImIgnoreSqlError As System.Windows.Forms.CheckBox
    Private txtEncryptionKey As System.Windows.Forms.TextBox
    Private label2 As System.Windows.Forms.Label
    Private cbEnableEncryption As System.Windows.Forms.CheckBox
    Private cbExProcedure As System.Windows.Forms.CheckBox
    Private cbExViews As System.Windows.Forms.CheckBox
    Private cbExFunction As System.Windows.Forms.CheckBox
    Private cbExEvent As System.Windows.Forms.CheckBox
    Private cbExTrigger As System.Windows.Forms.CheckBox
    Private panel2 As System.Windows.Forms.Panel
    Private txtTargetDatabase As System.Windows.Forms.TextBox
    Private label3 As System.Windows.Forms.Label
    Private txtImEncryptKey As System.Windows.Forms.TextBox
    Private label1 As System.Windows.Forms.Label
    Private cbImAsyn As System.Windows.Forms.CheckBox
    Private cbImEnableEncrypt As System.Windows.Forms.CheckBox
    Private pgGetTotalRows As System.Windows.Forms.ProgressBar
    Private lbGetTotalRows As System.Windows.Forms.Label
    Private pbRowsTable As System.Windows.Forms.ProgressBar
    Private label4 As System.Windows.Forms.Label
    Private lbPercentage As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private pbPercent As System.Windows.Forms.ProgressBar
    Private lbRowProgressCurTable As System.Windows.Forms.Label
    Private pbRowsDB As System.Windows.Forms.ProgressBar
    Private label8 As System.Windows.Forms.Label
    Private lbRowProgressDB As System.Windows.Forms.Label
    Private pbTable As System.Windows.Forms.ProgressBar
    Private label9 As System.Windows.Forms.Label
    Private lbCurrentTable As System.Windows.Forms.Label
    Private lbTotalTableDB As System.Windows.Forms.Label
    Private WithEvents btCancelExport As System.Windows.Forms.Button
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btCancelImport As System.Windows.Forms.Button
    Private lbImportErr As System.Windows.Forms.Label
    Private lbTotalBytes As System.Windows.Forms.Label
    Private pbBytes As System.Windows.Forms.ProgressBar
    Private colnSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private colnTable As System.Windows.Forms.DataGridViewTextBoxColumn
    Private colnSql As System.Windows.Forms.DataGridViewTextBoxColumn
    Private cbAutoCloseConnectionExport As System.Windows.Forms.CheckBox
    Private nmSQLLength As System.Windows.Forms.NumericUpDown
    Private label6 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private cbImAutoCloseConnection As System.Windows.Forms.CheckBox
    Private label11 As System.Windows.Forms.Label
    Private tabPage3 As System.Windows.Forms.TabPage
    Private lbHashResult As System.Windows.Forms.Label
    Private label13 As System.Windows.Forms.Label
    Private label12 As System.Windows.Forms.Label
    Private WithEvents txtHash2 As System.Windows.Forms.TextBox
    Private WithEvents txtHashFile2 As System.Windows.Forms.TextBox
    Private WithEvents txtHash1 As System.Windows.Forms.TextBox
    Private WithEvents txtHashFile1 As System.Windows.Forms.TextBox
    Private WithEvents btHashFile2 As System.Windows.Forms.Button
    Private WithEvents btHashFile1 As System.Windows.Forms.Button
    Private cbRecordDumpTime As System.Windows.Forms.CheckBox
    Private label14 As System.Windows.Forms.Label
    Private WithEvents btDeleteAllRows As System.Windows.Forms.Button
    Private cbCharSet As System.Windows.Forms.ComboBox
    Private cbZip As System.Windows.Forms.CheckBox
    Friend WithEvents RefreshTimer As System.Windows.Forms.Timer

End Class
