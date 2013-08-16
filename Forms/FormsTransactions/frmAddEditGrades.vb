
Imports MySql.Data.MySqlClient

Public Class frmAddEditGrades

    Dim dtaTable As New DataSet

#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewCourseOfferingBlock"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'mycommand.Parameters.AddWithValue("SubID", Me.cboSubject.SelectedValue)
                    'mycommand.Parameters.AddWithValue("SCode", Me.txtSubjectCode.Text)
                    'mycommand.Parameters.AddWithValue("Trm", CurrentTerm)
                    'mycommand.Parameters.AddWithValue("Sy", CurrentSchoolYear)
                    'mycommand.Parameters.AddWithValue("SubCode", Me.txtSubCode.Text)
                    'mycommand.Parameters.AddWithValue("DCode", 0)
                    'mycommand.Parameters.AddWithValue("T1", Me.txtTime1.Text)
                    'mycommand.Parameters.AddWithValue("D1", Me.txtDay1.Text)
                    'mycommand.Parameters.AddWithValue("R1", Me.txtRoom1.Text)
                    'mycommand.Parameters.AddWithValue("T2", Me.txtTime2.Text)
                    'mycommand.Parameters.AddWithValue("D2", Me.txtDay2.Text)
                    'mycommand.Parameters.AddWithValue("R2", Me.txtRoom2.Text)
                    'mycommand.Parameters.AddWithValue("NUnits", Me.txtUnits.Text)
                    'mycommand.Parameters.AddWithValue("InstID", Me.cboInstructor.SelectedValue)
                    'mycommand.Parameters.AddWithValue("NumSeats", Me.txtSeats.Text)
                    'mycommand.Parameters.AddWithValue("EncBy", CurrentSystemUser)
                    'mycommand.Parameters.AddWithValue("BLCode", Me.CurrentBlockCode)

                    myconn.Open()
                    mycommand.ExecuteNonQuery()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Private Function ModifyCourseOffering() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifyCourseOffering"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'mycommand.Parameters.AddWithValue("SubID", Me.cboSubject.SelectedValue)
                    'mycommand.Parameters.AddWithValue("SCode", Me.txtSubjectCode.Text)
                    'mycommand.Parameters.AddWithValue("Trm", CurrentTerm)
                    'mycommand.Parameters.AddWithValue("Sy", CurrentSchoolYear)
                    'mycommand.Parameters.AddWithValue("SubCode", Me.txtSubCode.Text)
                    'mycommand.Parameters.AddWithValue("DCode", 0)
                    'mycommand.Parameters.AddWithValue("T1", Me.txtTime1.Text)
                    'mycommand.Parameters.AddWithValue("D1", Me.txtDay1.Text)
                    'mycommand.Parameters.AddWithValue("R1", Me.txtRoom1.Text)
                    'mycommand.Parameters.AddWithValue("T2", Me.txtTime2.Text)
                    'mycommand.Parameters.AddWithValue("D2", Me.txtDay2.Text)
                    'mycommand.Parameters.AddWithValue("R2", Me.txtRoom2.Text)
                    'mycommand.Parameters.AddWithValue("NUnits", Me.txtUnits.Text)
                    'mycommand.Parameters.AddWithValue("InstID", Me.cboInstructor.SelectedValue)
                    'mycommand.Parameters.AddWithValue("NumSeats", Me.txtSeats.Text)
                    'mycommand.Parameters.AddWithValue("EncBy", CurrentSystemUser)
                    'mycommand.Parameters.AddWithValue("BLCode", Me.CurrentBlockCode)

                    'mycommand.Parameters.AddWithValue("COID", Me.CurrentCourseOfferingID)

                    myconn.Open()
                    mycommand.ExecuteNonQuery()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyDepartment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyDepartment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Public Sub GetEnrolledStudentsBySectionCodeByTermByYear()

        Dim dtaTableLoads As New DataSet

        Try
            dtaTableLoads = GetDataAndReturnDataSetTeachersLoad(ConnectionString, "GetEnrolledStudentsBySectionCodeByTermByYear", 4, _
                        Me.cboTerm.Text, Me.cboSY.Text, Me.dvgLoads.CurrentRow.Cells(2).Value)

        Catch ex As Exception

        End Try
        
        'Me.dvgStudents.DataSource = dtaTableLoads.Tables(0)

        LoadIntoDatagridview(dtaTableLoads.Tables(0), Me.dvgStudents)
    End Sub

    Public Sub GetSubjectsEmployeesAll()

        Dim dtaTableLoads As New DataTable

        dtaTableLoads = GetDataAndReturnDataTableByTermYearByTeacherID(ConnectionString, "GetTeachersLoadByTeacher", 4, Me.cboTerm.Text, Me.cboSY.Text, Me.cboInsturctor.SelectedValue)

        Me.dvgLoads.DataSource = dtaTableLoads


    End Sub

    Public Sub GetEmployeesAll()


        dtaTable = GetDataAndReturnDataSet(ConnectionString, "GetEmployeesAll", 4)


        Me.cboInsturctor.DataSource = dtaTable.Tables(0)
        Me.cboInsturctor.ValueMember = "EmpID"
        Me.cboInsturctor.DisplayMember = "EmployeeName"

    End Sub

    Public Sub GetLastCourseOfferingNumber()

        Dim theobject As String

        theobject = GetDataAndReturnAString(ConnectionString, "GetLastCourseOfferingsNumber", 4, CurrentTerm, CurrentSchoolYear)

        'Me.txtSubjectCode.Text = theobject.ToString

    End Sub

    Private Function SaveGrades() As Boolean

        Dim boolReturn As Boolean
        Dim strSQL As String = "UPDATE enrolledstudentssubjects SET " _
            & "FinalGrade=?FinalGrade,PointGrade=?PointGrade,GradingRemarks=?GradingRemarks,PostedBy=?PostedBy " _
            & "WHERE ESSID=?ESSID;"

        Dim mytrans As MySqlTransaction

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                myconn.Open()
                mytrans = myconn.BeginTransaction

                Try
                    Using mycommandmain As New MySqlCommand
                        mycommandmain.Connection = myconn
                        mycommandmain.CommandType = CommandType.Text
                        mycommandmain.CommandText = strSQL

                        'add parameters
                        Dim FinalGrade, PointGrade, GradingRemarks, PostedBy, ESSID As MySqlParameter

                        With mycommandmain
                            ESSID = .Parameters.Add("?ESSID", MySqlDbType.Int32)
                            FinalGrade = .Parameters.Add("?FinalGrade", MySqlDbType.VarChar)
                            PointGrade = .Parameters.Add("?PointGrade", MySqlDbType.VarChar)
                            GradingRemarks = .Parameters.Add("?GradingRemarks", MySqlDbType.VarChar)
                            PostedBy = .Parameters.Add("?PostedBy", MySqlDbType.VarChar)

                            PostedBy.Value = CurrentSystemUser

                            For Each row As DataGridViewRow In Me.dvgStudents.Rows
                                ESSID.Value = row.Cells(1).Value
                                FinalGrade.Value = row.Cells(6).Value.ToString
                                PointGrade.Value = row.Cells(7).Value.ToString
                                GradingRemarks.Value = row.Cells(8).Value.ToString

                                .ExecuteNonQuery()

                            Next
                        End With
                    End Using
                    boolReturn = True
                    mytrans.Commit()
                Catch ex As MySqlException
                    boolReturn = False
                    mytrans.Rollback()
                    Dim newfrm As New frmErrorMessageViewer
                    With newfrm
                        .ErrorMessage = ex.Message
                        .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveGrades" & vbCrLf & vbCrLf & ex.StackTrace
                        .ErrorForHumans = "Cannot continue saving record because an error occured."
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    mytrans.Rollback()
                    boolReturn = False
                    Dim newfrm As New frmErrorMessageViewer
                    With newfrm
                        .ErrorMessage = ex.Message
                        .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveGrades" & vbCrLf & vbCrLf & ex.StackTrace
                        .ErrorForHumans = "Cannot continue saving record because an error occured."
                        .ShowDialog()
                    End With
                End Try
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveGrades" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue saving record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveGrades" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue saving record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

#End Region

#Region "Properties"

#End Region

#Region "Helper"

    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                '.Columns(14).Visible = False
                '.Columns(15).Visible = False

                .Columns(2).HeaderText = "Section Code"
                .Columns(3).HeaderText = "Subject"
                .Columns(4).HeaderText = "Descriptive Title"
                .Columns(5).HeaderText = "Time1"
                .Columns(6).HeaderText = "Day1"
                .Columns(7).HeaderText = "Room1"
                .Columns(8).HeaderText = "Time2"
                .Columns(9).HeaderText = "Day2"
                .Columns(10).HeaderText = "Room2"
                .Columns(11).HeaderText = "Units"

                .Columns(2).Width = "100"
                .Columns(3).Width = "100"
                .Columns(4).Width = "255"
                .Columns(5).Width = "100"
                .Columns(6).Width = "100"
                .Columns(7).Width = "200"
                .Columns(8).Width = "100"
                .Columns(9).Width = "100"
                .Columns(10).Width = "200"
                .Columns(11).Width = "100"
                .Columns(11).DefaultCellStyle.Format = "N2"

                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ArrangeDatagridViewStudents(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                '.Columns(14).Visible = False
                '.Columns(15).Visible = False

                .Columns(2).HeaderText = "Section Code"
                .Columns(3).HeaderText = "Subject"
                .Columns(4).HeaderText = "Descriptive Title"
                .Columns(5).HeaderText = "Time1"
                .Columns(6).HeaderText = "Day1"
                .Columns(7).HeaderText = "Room1"
                .Columns(8).HeaderText = "Time2"
                .Columns(9).HeaderText = "Day2"
                .Columns(10).HeaderText = "Room2"
                .Columns(11).HeaderText = "Units"

                .Columns(2).Width = "100"
                .Columns(3).Width = "100"
                .Columns(4).Width = "255"
                .Columns(5).Width = "100"
                .Columns(6).Width = "100"
                .Columns(7).Width = "200"
                .Columns(8).Width = "100"
                .Columns(9).Width = "100"
                .Columns(10).Width = "200"
                .Columns(11).Width = "100"
                .Columns(11).DefaultCellStyle.Format = "N2"

                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadIntoDatagridview(ByVal dtaTable As DataTable, ByVal TheGrid As DataGridView)
        For Each row As DataRow In dtaTable.Rows
            With TheGrid.Rows
                .Add(row("SOID"), row("ESSID"), row("StudentID"), row("StudentName"), _
                     row("CourseCode").ToString, row("EnrolYear"), row("FinalGrade"), row("PointGrade"), row("GradingRemarks"))
            End With
        Next
    End Sub

    Private Sub SetPintGradeAndRemarks(ByVal decFinalGrade As String, ByVal intRow As Integer, ByVal theGrid As DataGridView)
        Dim decPointGrade As String = 0.0
        Dim decRemarks As String = ""
        Dim desiredCell As DataGridViewCell


        'MessageBox.Show("decFinalGrade: " & decFinalGrade & vbCrLf & "intRow: " & intRow)
        desiredCell = theGrid(6, intRow)
        Try
            Select Case decFinalGrade
                Case 100, 99, 98, 97
                    decPointGrade = 1.0
                    decRemarks = "Passed"
                Case 96, 95, 94
                    decPointGrade = 1.25
                    decRemarks = "Passed"
                Case 93, 92, 91
                    decPointGrade = 1.5
                    decRemarks = "Passed"
                Case 90, 89, 88
                    decPointGrade = 1.75
                    decRemarks = "Passed"
                Case 87, 86, 85
                    decPointGrade = 2.0
                    decRemarks = "Passed"
                Case 84, 83, 82
                    decPointGrade = 2.25
                    decRemarks = "Passed"
                Case 81, 80, 79
                    decPointGrade = 2.5
                    decRemarks = "Passed"
                Case 78, 77, 76
                    decPointGrade = 2.75
                    decRemarks = "Passed"
                Case 75, 74, 73
                    decPointGrade = 3.0
                    decRemarks = "Passed"

                Case 70, 69
                    decPointGrade = 5.0
                    decRemarks = "Failed"

                Case "Incomplete", "Inc", "INC", "INCOMPLETE", "incomplete", "inc"
                    decPointGrade = 4.0
                    decRemarks = "Incomplete"
                Case "Failed", "F", "FAILED", "failed", "f"
                    decPointGrade = 5.0
                    decRemarks = "Failed"


                Case "Dropped", "dropped", "drop", "drp", "DRP", "D", "d"
                    decPointGrade = "Dropped"
                    decRemarks = "Dropped"


                Case Else
                    MsgBox("The Grade Value that you have entered is INVALID", MsgBoxStyle.Exclamation, "ESMS")

                    theGrid.CurrentCell = desiredCell
                    theGrid.Rows(intRow).Cells(6).Value = ""
                    theGrid.CurrentCell.Selected = True


                    Exit Sub
            End Select

            With theGrid
                .Rows(intRow).Cells(7).Value = decPointGrade
                .Rows(intRow).Cells(8).Value = decRemarks

                If decPointGrade = "5" Then

                    .Rows(intRow).Cells(8).Style.ForeColor = Color.Red

                    .Rows(intRow).Cells(8).Style.Font = New Font("Tahoma", .DefaultCellStyle.Font.Size, FontStyle.Bold)

                ElseIf decPointGrade = "4" Then
                    .Rows(intRow).Cells(8).Style.ForeColor = Color.Brown
                    .Rows(intRow).Cells(8).Style.Font = New Font("Tahoma", .DefaultCellStyle.Font.Size, FontStyle.Bold)

                ElseIf decPointGrade = "Dropped" Then
                    .Rows(intRow).Cells(8).Style.ForeColor = Color.Green
                    .Rows(intRow).Cells(8).Style.Font = New Font("Tahoma", .DefaultCellStyle.Font.Size, FontStyle.Bold)
                End If


            End With
        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & " In SetPintGradeAndRemarks")
        End Try
    End Sub

    Private Sub SetGridCellColors(ByVal TheDvg As DataGridView)

        Dim decPointGrade As String = ""

        Try
            For Each row As DataGridViewRow In TheDvg.Rows

                decPointGrade = row.Cells(7).Value.ToString

                With TheDvg
                    '.Rows(intRow).Cells(7).Value = decPointGrade
                    '.Rows(intRow).Cells(8).Value = decRemarks

                    If decPointGrade = "5" Then

                        row.Cells(8).Style.ForeColor = Color.Red

                        row.Cells(8).Style.Font = New Font("Tahoma", .DefaultCellStyle.Font.Size, FontStyle.Bold)

                    ElseIf decPointGrade = "4" Then
                        row.Cells(8).Style.ForeColor = Color.Brown
                        row.Cells(8).Style.Font = New Font("Tahoma", .DefaultCellStyle.Font.Size, FontStyle.Bold)

                    ElseIf decPointGrade = "Dropped" Then
                        row.Cells(8).Style.ForeColor = Color.Green
                        row.Cells(8).Style.Font = New Font("Tahoma", .DefaultCellStyle.Font.Size, FontStyle.Bold)
                    End If


                End With
            Next

        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & "In SetGridCellColors")
        End Try
        
    End Sub

    Private Function DeterminedIfAllGradesAreEntered(ByVal theGrid As DataGridView) As Boolean

        Dim boolReturn As Boolean

        Try
            For Each row As DataGridViewRow In theGrid.Rows
                If row.Cells(8).Value.ToString = "" Then
                    MsgBox("Some entries are empty or incorrect. Please verify it again before saving.", MsgBoxStyle.Exclamation, "ESMS")
                    boolReturn = False
                    Exit For
                End If
            Next
            boolReturn = True
        Catch ex As Exception

        End Try

        Return boolReturn

    End Function

#End Region

    Private Sub frmAddEditGrades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Add Grades")
    End Sub

    Private Sub frmAddEditGrades_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        GetEmployeesAll()
        Me.cboInsturctor.SelectedIndex = -1

    End Sub

    Private Sub cboInsturctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInsturctor.SelectedIndexChanged
        Try
            GetSubjectsEmployeesAll()
            ArrangeDatagridView(Me.dvgLoads)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dvgLoads_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgLoads.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dvgLoads_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgLoads.SelectionChanged
        Me.dvgStudents.Rows.Clear()
        GetEnrolledStudentsBySectionCodeByTermByYear()
        SetGridCellColors(Me.dvgStudents)
    End Sub

    Private Sub dvgStudents_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgStudents.CellContentClick

    End Sub

    Private Sub dvgStudents_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgStudents.CellEndEdit
        SetPintGradeAndRemarks(Me.dvgStudents.CurrentRow.Cells(6).Value.ToString, e.RowIndex, Me.dvgStudents)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        'If DeterminedIfAllGradesAreEntered(Me.dvgStudents) = False Then

        '    Exit Sub
        'End If

        'scontinue saving data
        If SaveGrades() = True Then
            MessageBox.Show("Done saving grades.", "Save grades.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCheckGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheckGrades.Click

        If DeterminedIfAllGradesAreEntered(Me.dvgStudents) = False Then
            MessageBox.Show("All grades are ok.", "Check grades.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub dvgStudents_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgStudents.CellPainting
        Dim StringFormat As New StringFormat

        StringFormat.Alignment = StringAlignment.Near
        'Check if the
        ' current Cell Column to be painted is the RowHeader
        ' current Cell Row to be painted is a record row
        ' current Cell Row to be painted is not the EOF Row
        If e.ColumnIndex = -1 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < dvgStudents.Rows.Count Then
            e.PaintBackground(e.ClipBounds, True)
            e.Graphics.DrawString((e.RowIndex + 1).ToString, Me.Font, Brushes.Black, e.CellBounds, StringFormat)
            e.Handled = True
        End If
    End Sub

    Private Sub dvgStudents_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgStudents.Sorted
        SetGridCellColors(Me.dvgStudents)
    End Sub
End Class