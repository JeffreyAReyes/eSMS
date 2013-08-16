Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmBackUpDatabase

    Private Enum CurrentProcessType
        Export
        Import
        DeletingRows
        FetchingTablesInfo
        None
    End Enum

    Private constr As String = ""

    Private WithEvents mb As MySqlBackup
    Private HighTimeForGuiRefresh As Boolean = True
    Private cpt As CurrentProcessType = CurrentProcessType.None

    Private md As New Methods()


    Public Sub New(ByVal connectionString As String)

        InitializeComponent()

        constr = connectionString
        nmSQLLength.Value = 1024 * 1024

        cbCharSet.Items.Add("not specify")
        For Each cs As ImportInformations.CharSet In [Enum].GetValues(GetType(ImportInformations.CharSet))
            cbCharSet.Items.Add(cs)
        Next
        cbCharSet.SelectedIndex = 0

        LoadTables()

    End Sub


#Region "Form's Events"

    Private Sub dataGridView1_CellEndEdit(ByVal sender As Object, _
        ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellEndEdit
        dataGridView1.ClearSelection()
    End Sub

    Private Sub dataGridView1_CellClick(ByVal sender As Object, _
        ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick

        If e.RowIndex < 0 Then Exit Sub

        If e.ColumnIndex = colnSelect.Index OrElse e.ColumnIndex = colnTable.Index Then
            dataGridView1.Rows(e.RowIndex).Cells(colnSelect.Index).Value = _
                Not Convert.ToBoolean(dataGridView1.Rows(e.RowIndex).Cells(colnSelect.Index).Value)
            dataGridView1.EndEdit()
            dataGridView1.ClearSelection()
        ElseIf e.ColumnIndex = colnSql.Index Then
            dataGridView1.BeginEdit(True)
        End If

    End Sub

    Private Sub btExpand_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btExpand.Click
        splitContainer1.Panel2Collapsed = Not splitContainer1.Panel2Collapsed
        If splitContainer1.Panel2Collapsed Then
            btExpand.Text = "Return"
        Else
            btExpand.Text = "Expand"
        End If
    End Sub

    Private Sub btAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAll.Click
        For Each dgvr As DataGridViewRow In dataGridView1.Rows
            dgvr.Cells(colnSelect.Index).Value = True
        Next
        dataGridView1.ClearSelection()
    End Sub

    Private Sub btNone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btNone.Click
        For Each dgvr As DataGridViewRow In dataGridView1.Rows
            dgvr.Cells(colnSelect.Index).Value = False
        Next
        dataGridView1.ClearSelection()
    End Sub

    Private Sub RefreshTimer_Tick(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RefreshTimer.Tick
        RefreshTimer.Stop()
        If mb Is Nothing OrElse cpt = CurrentProcessType.None Then Exit Sub
        HighTimeForGuiRefresh = True
        RefreshTimer.Start()
    End Sub

#End Region

#Region "Export"

    Private Sub btExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btExport.Click

        If Not mb Is Nothing Then
            MsgBox("Error. Can't start export while another process is in progress.", _
                MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim fn As String = ""

        Using sf As New SaveFileDialog()
            sf.FileName = "test " & DateTime.Now.ToString("yyyyMMdd HHmmss") & ".sql"
            If sf.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub
            fn = sf.FileName
        End Using

        If Not FetchNewMySqlBackup() Then Exit Sub

        mb.ExportInfo.FileName = fn
        mb.ExportInfo.RecordDumpTime = cbRecordDumpTime.Checked
        mb.ExportInfo.AddCreateDatabase = cbAddCreateDatabase.Checked
        mb.ExportInfo.AsynchronousMode = cbAsynchronousModeExport.Checked
        mb.ExportInfo.AutoCloseConnection = cbAutoCloseConnectionExport.Checked
        mb.ExportInfo.CalculateTotalRowsFromDatabase = cbCalculateTotalRowsFromDatabase.Checked
        mb.ExportInfo.EnableEncryption = cbEnableEncryption.Checked
        mb.ExportInfo.EncryptionKey = txtEncryptionKey.Text
        mb.ExportInfo.ExportEvents = cbExEvent.Checked
        mb.ExportInfo.ExportFunctions = cbExFunction.Checked
        mb.ExportInfo.ExportRows = cbExportRows.Checked
        mb.ExportInfo.ExportStoredProcedures = cbExProcedure.Checked
        mb.ExportInfo.ExportTableStructure = cbExportTableStructure.Checked
        mb.ExportInfo.ExportTriggers = cbExTrigger.Checked
        mb.ExportInfo.ExportViews = cbExViews.Checked
        mb.ExportInfo.ResetAutoIncrement = cbResetAutoIncrement.Checked
        mb.ExportInfo.MaxSqlLength = CInt(nmSQLLength.Value)
        mb.ExportInfo.TableCustomSql = GetTableSql()
        mb.ExportInfo.ZipOutputFile = cbZip.Checked

        If cbAsynchronousModeExport.Checked Then

            AddHandler mb.ExportProgressChanged, AddressOf mb_ExportProgressChanged
            AddHandler mb.ExportCompleted, AddressOf mb_ExportCompleted

        End If

        cpt = CurrentProcessType.Export
        ResetButtons()

        Dim OldCursor As Cursor = Me.Cursor

        Try

            If Not mb.ExportInfo.AsynchronousMode Then Me.Cursor = Cursors.WaitCursor

            mb.Export()

            If Not mb.ExportInfo.AsynchronousMode Then
                Me.Cursor = OldCursor
                ShowExportCompleteMessage(mb.ExportInfo.CompleteArg)
                ClearOperationData(True)
            Else
                RefreshTimer.Start()
            End If

        Catch
            If Not mb.ExportInfo.AsynchronousMode Then Me.Cursor = OldCursor
            ShowExportCompleteMessage(mb.ExportInfo.CompleteArg)
            If Not mb.ExportInfo.AsynchronousMode Then ClearOperationData(True)
        End Try

    End Sub

    Private Function GetTableSql() As Dictionary(Of String, String)

        Dim dicTableSql As New Dictionary(Of String, String)

        For Each dgvr As DataGridViewRow In dataGridView1.Rows
            If Convert.ToBoolean(dgvr.Cells(colnSelect.Index).Value) Then
                Dim tablename As String = dgvr.Cells(colnTable.Index).Value & ""
                Dim sql As String = dgvr.Cells(colnSql.Index).Value & ""
                If sql = "" Then
                    sql = String.Format("SELECT * FROM `{0}`;", tablename)
                End If
                dicTableSql.Add(tablename, sql)
            End If
        Next

        If dicTableSql.Count = 0 Then Return Nothing

        Return dicTableSql

    End Function


    Private Sub mb_ExportCompleted(ByVal sender As Object, ByVal e As ExportCompleteArg)
        ReportExportCompleted(e)
    End Sub

    Private Delegate Sub ReportExportCompletedInvoker(ByVal e As ExportCompleteArg)
    Private Sub ReportExportCompleted(ByVal e As ExportCompleteArg)

        If Me.InvokeRequired Then
            Me.Invoke(New ReportExportCompletedInvoker(AddressOf ReportExportCompleted), New Object() {e})
            Exit Sub
        End If

        RefreshTimer.Stop()

        ShowExportCompleteMessage(e)

        RemoveHandler mb.ExportProgressChanged, AddressOf mb_ExportProgressChanged
        RemoveHandler mb.ExportCompleted, AddressOf mb_ExportCompleted
        ClearOperationData(True)

    End Sub

    Private Sub ShowExportCompleteMessage(ByVal e As ExportCompleteArg)

        If e.CompletedType = ExportCompleteArg.CompleteType.Cancelled Then
            lbGetTotalRows.Text = "Backup process was canceled."
        ElseIf e.CompletedType = ExportCompleteArg.CompleteType.Error Then
            lbGetTotalRows.Text = "Backup process was interrupted by an exception."
        Else
            lbGetTotalRows.Text = "Backup process was succesfuly completed."
        End If

        Dim sb As New StringBuilder()
        sb.Append("Export " & e.CompletedType.ToString() & vbCr & vbLf)
        sb.Append("Time Start: " & e.TimeStart.ToString() & vbCr & vbLf)
        sb.Append("Time End: " & e.TimeEnd.ToString() & vbCr & vbLf)
        sb.Append("Time Used: " & e.TimeUsed.Minutes & " m " & e.TimeUsed.Seconds _
            & " s " & e.TimeUsed.Milliseconds & " ms" & vbCr & vbLf)

        Dim mbb As MessageBoxButtons = MessageBoxButtons.YesNo
        If e.Error IsNot Nothing Then
            sb.Append(vbCr & vbLf & "Error Message:" & vbCr & vbLf & vbCr & vbLf)
            sb.Append(e.[Error].ToString())
            mbb = MessageBoxButtons.OK
        Else
            sb.Append("File save at: " & mb.ExportInfo.FileName & vbCr & vbLf _
                & vbCr & vbLf & "Do you want to open the dump file?")
        End If

        If MessageBox.Show(sb.ToString(), "Finished", mbb) = System.Windows.Forms.DialogResult.Yes Then
            Dim p As New System.Diagnostics.Process()
            p.StartInfo.FileName = mb.ExportInfo.FileName
            p.Start()
        End If

    End Sub


    Private Sub mb_ExportProgressChanged(ByVal sender As Object, ByVal e As ExportProgressArg)
        ReportExportProgress(e)
    End Sub

    Private Delegate Sub ReportExportProgressInvoker(ByVal e As ExportProgressArg)
    Private Sub ReportExportProgress(ByVal e As ExportProgressArg)

        If Not HighTimeForGuiRefresh AndAlso e.PercentageCompleted < 99 Then Exit Sub

        If Me.InvokeRequired Then
            Me.Invoke(New ReportExportProgressInvoker(AddressOf ReportExportProgress), New Object() {e})
            Exit Sub
        End If

        If e.PercentageGetTotalRowsCompleted = 100 Then
            lbGetTotalRows.Text = "100%. Total Rows Calculation Completed. Begin backup process..."
        ElseIf e.PercentageGetTotalRowsCompleted = 0 Then
            lbGetTotalRows.Text = ""
        Else
            lbGetTotalRows.Text = "Calculating Total Rows... " _
                & e.PercentageGetTotalRowsCompleted.ToString() & "% completed."
        End If

        pgGetTotalRows.Value = e.PercentageGetTotalRowsCompleted

        pbPercent.Value = e.PercentageCompleted
        lbPercentage.Text = e.PercentageCompleted & "% Completed"

        lbCurrentTable.Text = e.CurrentTableName
        lbRowProgressCurTable.Text = e.CurrentRowInCurrentTable & " / " & e.TotalRowsInCurrentTable
        lbRowProgressDB.Text = e.CurrentRowInAllTable & " / " & e.TotalRowsInAllTables
        lbTotalTableDB.Text = e.CurrentTableIndex & " / " & e.TotalTables

        pbTable.Maximum = CInt(e.TotalTables) * 10
        pbTable.Value = CInt(e.CurrentTableIndex) * 10

        If e.TotalRowsInAllTables <> 0 Then
            Try
                pbRowsDB.Maximum = CInt(e.TotalRowsInAllTables)
                pbRowsDB.Value = CInt(e.CurrentRowInAllTable)
                pbRowsTable.Maximum = CInt(e.TotalRowsInCurrentTable)
                pbRowsTable.Value = CInt(e.CurrentRowInCurrentTable)
                ' Purposely left empty
                ' reason:
                ' pbRowsTable.Maximum might be holding total rows for table1
                ' but value for pbRowsTable.Value might be from table2
                ' if total rows of table1 is 10 and value of current row is 11 in table2
                ' exception will occur because value 11 is exceed maximum of pbRowsTable which is 10.
                ' This is a rare but might possible happened case.
                ' Because of the process is too fast, that the values might not come from the same table.
                ' MySqlBackup.NET has loop to next table
                ' This happens usually when total rows of the previous table is few,
                ' It is fast enough to finish processing and switch to next table almost simultaneously..
            Catch
            End Try
        End If

        HighTimeForGuiRefresh = False

    End Sub


    Private Sub btCancelExport_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btCancelExport.Click

        If mb Is Nothing OrElse cpt <> CurrentProcessType.Export Then Exit Sub

        If mb.ExportInfo.AsynchronousMode Then
            RefreshTimer.Stop()
            HighTimeForGuiRefresh = False
        End If
        Me.btCancelExport.Enabled = False
        lbGetTotalRows.Text = "Canceling backup process..."

        mb.CancelExport()

        If Not mb.ExportInfo.AsynchronousMode Then
            MsgBox("Export cancelled.", MsgBoxStyle.Information, "")
            ClearOperationData(True)
        End If

    End Sub

#End Region

#Region "Import"

    Private Sub btImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btImport.Click

        If Not mb Is Nothing Then
            MsgBox("Error. Can't start import while another process is in progress.", _
                MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim fn As String = ""

        Using ofd As New OpenFileDialog()
            ofd.Multiselect = False
            If ofd.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub
            fn = ofd.FileName
            If fn Is Nothing OrElse String.IsNullOrEmpty(fn.Trim) OrElse _
                Not IO.File.Exists(fn) Then Exit Sub
        End Using

        If Not FetchNewMySqlBackup() Then Exit Sub

        mb.ImportInfo.AsynchronousMode = cbImAsyn.Checked
        mb.ImportInfo.AutoCloseConnection = cbImAutoCloseConnection.Checked
        mb.ImportInfo.EnableEncryption = cbImEnableEncrypt.Checked
        mb.ImportInfo.EncryptionKey = txtImEncryptKey.Text
        mb.ImportInfo.FileName = fn
        mb.ImportInfo.IgnoreSqlError = cbImIgnoreSqlError.Checked
        Dim newCharSet As String = ""
        If cbCharSet.SelectedIndex > 0 Then
            newCharSet = cbCharSet.Text
        End If

        mb.ImportInfo.SetTargetDatabase(txtTargetDatabase.Text, newCharSet)

        If cbImAsyn.Checked Then

            AddHandler mb.ImportProgressChanged, AddressOf mb_ImportProgressChanged
            AddHandler mb.ImportCompleted, AddressOf mb_ImportCompleted

        End If

        cpt = CurrentProcessType.Import

        ResetButtons()

        Dim OldCursor As Cursor = Me.Cursor

        Try

            If Not mb.ImportInfo.AsynchronousMode Then Me.Cursor = Cursors.WaitCursor

            mb.Import()

            If Not mb.ImportInfo.AsynchronousMode Then
                Me.Cursor = OldCursor
                ShowImportCompleteMessage(mb.ImportInfo.CompleteArg)
                ClearOperationData(True)
            Else
                RefreshTimer.Start()
            End If

        Catch
            If Not mb.ImportInfo.AsynchronousMode Then Me.Cursor = OldCursor
            ShowImportCompleteMessage(mb.ImportInfo.CompleteArg)
            If Not mb.ImportInfo.AsynchronousMode Then ClearOperationData(True)
        End Try

    End Sub


    Private Sub mb_ImportCompleted(ByVal sender As Object, ByVal e As ImportCompleteArg)
        ReportImportCompleted(e)
    End Sub

    Private Delegate Sub ReportImportCompletedInvoker(ByVal e As ImportCompleteArg)
    Private Sub ReportImportCompleted(ByVal e As ImportCompleteArg)

        If Me.InvokeRequired Then
            Me.Invoke(New ReportImportCompletedInvoker(AddressOf ReportImportCompleted), New Object() {e})
            Exit Sub
        End If

        RefreshTimer.Stop()

        ShowImportCompleteMessage(e)

        RemoveHandler mb.ImportProgressChanged, AddressOf mb_ImportProgressChanged
        RemoveHandler mb.ImportCompleted, AddressOf mb_ImportCompleted
        ClearOperationData(True)

    End Sub

    Private Sub ShowImportCompleteMessage(ByVal e As ImportCompleteArg)

        If e.CompletedType = ExportCompleteArg.CompleteType.Cancelled Then
            lbGetTotalRows.Text = "Restore process was canceled."
        ElseIf e.CompletedType = ExportCompleteArg.CompleteType.Error Then
            lbGetTotalRows.Text = "Restore process was interrupted by an exception."
        Else
            lbGetTotalRows.Text = "Restore process was succesfuly completed."
        End If

        Dim sb As New StringBuilder()

        sb.Append("Import " & e.CompletedType.ToString() & vbCr & vbLf)
        sb.Append("Start Time: " & e.TimeStart.ToString() & vbCr & vbLf)
        sb.Append("End Time: " & e.TimeEnd.ToString() & vbCr & vbLf)
        sb.Append("Time Used: " & e.TimeUsed.Minutes & " m " & e.TimeUsed.Seconds _
            & " s " & e.TimeUsed.Milliseconds & " ms" & vbCr & vbLf)

        If e.HasErrors Then sb.Append("Errors occur during the import process." _
            & vbCr & vbLf & vbCr & vbLf & "Displaying the last exception:" _
            & vbCr & vbLf & vbCr & vbLf & e.LastError.ToString())

        MessageBox.Show(sb.ToString())

    End Sub


    Private Sub mb_ImportProgressChanged(ByVal sender As Object, ByVal e As ImportProgressArg)
        ReportImportProgress(e)
    End Sub

    Private Delegate Sub ReportImportProgressInvoker(ByVal e As ImportProgressArg)
    Private Sub ReportImportProgress(ByVal e As ImportProgressArg)

        If Not HighTimeForGuiRefresh AndAlso e.PercentageCompleted < 99 Then Exit Sub

        If Me.InvokeRequired Then
            Me.Invoke(New ReportImportProgressInvoker(AddressOf ReportImportProgress), New Object() {e})
            Exit Sub
        End If

        lbTotalBytes.Text = "Processed bytes: " & e.CurrentByte & " / " & e.TotalBytes
        pbBytes.Value = e.PercentageCompleted

        HighTimeForGuiRefresh = False

    End Sub


    Private Sub btCancelImport_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btCancelImport.Click

        If mb Is Nothing OrElse cpt <> CurrentProcessType.Import Then Exit Sub

        If mb.ImportInfo.AsynchronousMode Then RefreshTimer.Stop()
        Me.btCancelImport.Enabled = False
        lbGetTotalRows.Text = "Canceling restore process..."

        mb.CancelImport()

        If Not mb.ImportInfo.AsynchronousMode Then
            MessageBox.Show("Import cancelled.")
            ClearOperationData(True)
        End If

    End Sub

#End Region

#Region "Compare File by SHA256"

    Private Sub txtHash2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtHash2.TextChanged
        CompareFilesDisplayResult()
    End Sub

    Private Sub txtHashFile2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtHashFile2.TextChanged
        If System.IO.File.Exists(txtHashFile2.Text) Then
            Dim ba As Byte() = System.IO.File.ReadAllBytes(txtHashFile2.Text)
            txtHash2.Text = md.Sha2Hash(ba)
        End If
    End Sub

    Private Sub txtHashFile1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtHashFile1.TextChanged
        If System.IO.File.Exists(txtHashFile1.Text) Then
            Dim ba As Byte() = System.IO.File.ReadAllBytes(txtHashFile1.Text)
            txtHash1.Text = md.Sha2Hash(ba)
        End If
    End Sub

    Private Sub txtHash1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtHash1.TextChanged
        CompareFilesDisplayResult()
    End Sub

    Private Sub btHashFile1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btHashFile1.Click
        Using ofd As New OpenFileDialog
            ofd.Multiselect = False
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then _
                txtHashFile1.Text = ofd.FileName
        End Using
    End Sub

    Private Sub btHashFile2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btHashFile2.Click
        Using ofd As New OpenFileDialog
            ofd.Multiselect = False
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then _
                txtHashFile2.Text = ofd.FileName
        End Using
    End Sub

    Private Sub CompareFilesDisplayResult()
        If txtHash1.Text = txtHash2.Text Then
            lbHashResult.Text = "Match. The content of these 2 files are totally same."
        Else
            lbHashResult.Text = "Not match. The contents are not totally same. " _
                & "Make sure you have disabled Record Dump Time."
        End If
    End Sub

#End Region


    Private Sub btDeleteAllRows_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btDeleteAllRows.Click

        If Not mb Is Nothing Then
            MsgBox("Error. Can't start deletion while another process is in progress.", _
                MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim OldCursor As Cursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor

        cpt = CurrentProcessType.DeletingRows

        Try
            mb = New MySqlBackup(constr)
            ResetButtons()
            mb.DeleteAllRows(True)
            Me.Cursor = OldCursor
            MsgBox("done", MsgBoxStyle.Information, "")
        Catch ex As Exception
            Me.Cursor = OldCursor
            MsgBox("Error while deleting rows: " & ex.Message, MsgBoxStyle.Exclamation, "")
        End Try

        ClearOperationData(True)

    End Sub


#Region "Helper methods"

    Private Sub LoadTables()

        cpt = CurrentProcessType.FetchingTablesInfo

        If Not FetchNewMySqlBackup() Then
            dataGridView1.ClearSelection()
            Exit Sub
        End If

        Dim tables As String() = mb.DatabaseInfo.TableNames

        ClearOperationData(False)

        If Not tables Is Nothing AndAlso tables.Length > 0 Then
            dataGridView1.Rows.Clear()
            For Each s As String In tables
                dataGridView1.Rows(dataGridView1.Rows.Add()).Cells(colnTable.Index).Value = s
            Next
        ElseIf constr.Trim.ToLower.Contains("database") Then
            MsgBox("The selected database is empty (contains no tables) or " _
                & "unidentified error occured while fetching tables info.", _
                MsgBoxStyle.Exclamation, "")
        End If

        dataGridView1.ClearSelection()

    End Sub

    Private Function FetchNewMySqlBackup() As Boolean

        Dim OldCursor As Cursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor

        Try

            mb = New MySqlBackup(constr)

        Catch ex As Exception

            ClearOperationData(False)
            Me.Cursor = OldCursor
            MsgBox("Error ocured while fetching table info: " & ex.Message, MsgBoxStyle.Exclamation, "")
            Return False

        End Try

        Me.Cursor = OldCursor

        Return True

    End Function

    Private Sub ClearOperationData(ByVal ContinueWithResetButtons As Boolean)
        If Not mb Is Nothing Then
            mb.Dispose()
            mb = Nothing
        End If
        cpt = CurrentProcessType.None
        HighTimeForGuiRefresh = True
        If ContinueWithResetButtons Then ResetButtons()
    End Sub

    Private Sub ResetButtons()

        btExport.Enabled = (mb Is Nothing)
        btCancelExport.Enabled = (Not mb Is Nothing AndAlso cpt = CurrentProcessType.Export)
        btImport.Enabled = (mb Is Nothing)
        btCancelImport.Enabled = (Not mb Is Nothing AndAlso cpt = CurrentProcessType.Import)
        btDeleteAllRows.Enabled = (mb Is Nothing)

    End Sub

#End Region

End Class
