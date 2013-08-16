
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmRegisterStudent

    Dim TheTableOfFees As New DataTable
    Dim TheTableOfCourseOfferings As New DataTable

    Private intSlots As Integer
    Private strDay As String
    Private strDesc As String
    Private strRoom As String
    Private strSectionCode As String
    Private strSubCode As String
    Private strTime As String
    Private strUnit As String
    Private intCourseOfferingID As Integer
    Private intSubjectID As Integer
    Private strSubjectNumber As String
    Private strDay1 As String
    Private strRoom1 As String
    Private strTime1 As String
    Private strLabCode As String

#Region "Database"

    Public Function GetEnrollmentDetails(ByVal strEDP As String) As Boolean

        Dim boolResult As Boolean
        Dim dtaTable As New DataSet

        Try
            dtaTable = GetDataAndReturnDataSetByTermYearByEDP(ConnectionString, "GetEnrollmentDetails", 4, CurrentTerm, CurrentSchoolYear, strEDP)
            
            'get student details
            For Each row As DataRow In dtaTable.Tables(0).Rows
                Me.txtName.Text = row("StudentName").ToString
                If IsDBNull(row("CourseCode")) = True Then
                    Me.txtCourse.Text = ""
                Else
                    Me.txtCourse.Text = row("CourseCode").ToString
                End If
                If IsDBNull(row("DeptCode")) = True Then
                    Me.txtDept.Text = ""
                Else
                    Me.txtDept.Text = row("DeptCode").ToString
                End If
                If IsDBNull(row("Gender")) = True Then
                    Me.txtSex.Text = ""
                Else
                    Me.txtSex.Text = row("Gender").ToString
                End If
                If IsDBNull(row("Degree")) = True Then
                    Me.txtDegree.Text = ""
                Else
                    Me.txtDegree.Text = row("Degree").ToString
                End If
            Next

            'get enrollment details, if any
            For Each row As DataRow In dtaTable.Tables(1).Rows

                If IsDBNull(row("EnrolYear")) = True Then
                    Me.txtYear.Text = "0"
                Else
                    Me.txtYear.Text = row("EnrolYear").ToString
                End If

                If IsDBNull(row("EnrolStatus")) = True Then
                    Me.txtStatus.Text = ""
                Else
                    Me.txtStatus.Text = row("EnrolStatus").ToString
                End If
                If IsDBNull(row("DateAdvised")) = True Then
                    Me.dtpEnrolled.Value = Date.Today.Date
                Else
                    Me.dtpEnrolled.Value = row("DateAdvised")
                    'Me.dtpEnrolled.Value = Date.Today.Date
                End If
                If IsDBNull(row("DateReAssessed")) = True Then
                    Me.dtpAssessed.Value = Date.Today.Date
                Else
                    Me.dtpAssessed.Value = row("DateReAssessed")
                End If
                If IsDBNull(row("IsRegistered")) = True Then
                    Me.txtIsEnrolled.Text = 0
                Else
                    If row("IsRegistered") = 0 Then
                        Me.txtIsEnrolled.Text = 1
                    Else
                        Me.txtIsEnrolled.Text = 1
                    End If

                End If
            Next

            'get payment details
            Dim decTotalPay As Decimal = 0.0
            For Each rowp As DataRow In dtaTable.Tables(2).Rows
                If IsDBNull(rowp("TotalAmountPaid")) = True Then
                    decTotalPay = 0.0
                Else
                    decTotalPay = rowp("TotalAmountPaid")
                End If
            Next
            'assign to the datagridview
            Me.dvgFees.Rows(6).Cells(2).Value = decTotalPay
            Me.txtPayments.Text = FormatNumber(decTotalPay, 2)

            'get subjects enrolled
            For Each rowsub As DataRow In dtaTable.Tables(3).Rows
                '   TheDataGridViewToBeAdded.Rows.Add(ListElement.TheESSID, ListElement.CourseOfferingNumber, '
                '   ListElement.SubjectCode, ListElement.DescTitle, _
                '    ListElement.Time1, ListElement.Day1, ListElement.Room1, ListElement.Time2, ListElement.Day2, _
                '    ListElement.Room2, ListElement.Units, ListElement.LabCode, ListElement.SubjectID, 
                '  ListElement.CourseOfferingID)

                With Me.dvgSubjectsList
                    .Rows.Add(rowsub("ESSID"), rowsub("SOCode"), rowsub("SubjectCode"), rowsub("DescriptiveTitle"), rowsub("Time1"), _
                              rowsub("Day1"), rowsub("Room1"), rowsub("Time2"), rowsub("Day2"), rowsub("Room2"), _
                              rowsub("NumOfUnits"), rowsub("LabCode"), rowsub("SubjectID"), rowsub("SOID"))
                End With
            Next

            'determine if it's a new enrollment or not
            If Me.dvgSubjectsList.Rows.Count <= 0 Then
                'must be a new enrollment
                Me.NewEnrollment = False
                Me.cmdSave.Enabled = False
                MessageBox.Show("Cannot continue enrollment." & vbCrLf & _
                                "Student must be advised first before enrollment.", "No advising.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'might be updating
                Me.NewEnrollment = False
            End If

            boolResult = True
        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & " In GetEnrollmentDetails")
            boolResult = False
        End Try

        Return boolResult

    End Function

    Private Sub GetSemestralFees()

        'Dim dtatable As New DataTable

        TheTableOfFees = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetSemestralFees", 4, CurrentTerm, CurrentSchoolYear)

    End Sub

    Private Function SaveStudentEnrollment(ByVal boolIsAdding As Boolean) As Boolean

        Dim boolReturn As Boolean

        'command text for adding to enrolled student main table
        'add new enrolledstudents SQL
        Dim strEnrolledStudentsSQL As String = "INSERT INTO enrolledstudents (" _
            & "StudentID,Term,SchoolYear,CourseCode,DeptCode,Adviser,Degree,EnrolStatus) VALUES (" _
            & "?StudentID,?Term,?SchoolYear,?CourseCode,?DeptCode,?Adviser,?Degree,?EnrolStatus)"

        'modify student enrollment, we have to delete enrolled subjects.
        Dim strModifyEnrolledStudentsSQL As String = "DELETE FROM enrolledstudentssubjects WHERE " _
            & "StudentID=?StudentID AND Term=?Term AND SchoolYear=?SchoolYear;" _
            & "UPDATE enrolledstudents SET CourseCode=?CourseCode,DeptCode=?DeptCode," _
            & "DeptCode=?DeptCode,Degree=?Degree,EnrolStatus=?EnrolStatus,Term=?Term,SchoolYear=?SchoolYear,  " _
            & "DateRegistered=?DateRegistered,RegisteredBy=?RegisteredBy,IsRegistered=1,EnrolYear=?EnrolYear " _
            & " WHERE StudentID=?StudentID AND Term = ?Term AND SchoolYear = ?SchoolYear;"

        'command text for adding to enrolled student details table
        'enrolledstudentssubjects
        Dim strEnrolledStudentsSubjectsSQL As String = "INSERT INTO enrolledstudentssubjects (" _
            & "SOID,StudentID,SubjectID,Term,SchoolYear,Remarks,SectionCode,IsPosted) VALUES (" _
            & "?SOID,?StudentID,?SubjectID,?Term,?SchoolYear,?Remarks,?SectionCode,?IsPosted)"


        'command text for adding/modifying student's assessment, student's ledger
        Dim strAsessment As String = "DELETE FROM enrolledstudentassessment WHERE StudentID=?StudentID AND " _
            & " Term=?Term AND SchoolYear=?SchoolYear;" _
            & "INSERT INTO enrolledstudentassessment " _
            & "(StudentID,Term,SchoolYear,TuitionFee,MiscellaneousFee,OtherFees,LabFees) VALUES " _
            & "(?StudentID,?Term,?SchoolYear,?TuitionFee,?MiscellaneousFee,?OtherFees,?LabFees)"

        
        Dim mytrans As MySqlTransaction
        Dim intExecuteNonQueryBycommandmain As Integer = 0
        Dim intExecuteNonQueryBycommandchild As Integer = 0

        Try
            Using myconn As New MySqlConnection(ConnectionString)

                myconn.Open()
                mytrans = myconn.BeginTransaction

                Try
                    Using mycommandmain As New MySqlCommand
                        mycommandmain.Connection = myconn
                        If boolIsAdding = True Then
                            mycommandmain.CommandText = strEnrolledStudentsSQL
                        Else
                            mycommandmain.CommandText = strModifyEnrolledStudentsSQL
                        End If

                        mycommandmain.CommandType = CommandType.Text

                        'add Parameters
                        mycommandmain.Parameters.AddWithValue("StudentID", Me.txtEDP.Text)
                        mycommandmain.Parameters.AddWithValue("Term", CurrentTerm)
                        mycommandmain.Parameters.AddWithValue("SchoolYear", CurrentSchoolYear)
                        mycommandmain.Parameters.AddWithValue("CourseCode", Me.txtCourse.Text)
                        mycommandmain.Parameters.AddWithValue("DeptCode", Me.txtDept.Text)
                        mycommandmain.Parameters.AddWithValue("Adviser", CurrentUserWholeName)
                        mycommandmain.Parameters.AddWithValue("Degree", Me.txtDegree.Text)
                        mycommandmain.Parameters.AddWithValue("EnrolStatus", Me.txtStatus.Text)
                        mycommandmain.Parameters.AddWithValue("EnrolYear", Me.txtYear.Text)
                        mycommandmain.Parameters.AddWithValue("DateRegistered", Date.Today.Date)
                        mycommandmain.Parameters.AddWithValue("RegisteredBy", CurrentUserWholeName)

                        'execute the transaction
                        intExecuteNonQueryBycommandmain = mycommandmain.ExecuteNonQuery()

                    End Using

                    'add details
                    Using mycommanddetails As New MySqlCommand
                        mycommanddetails.Connection = myconn
                        mycommanddetails.CommandText = strEnrolledStudentsSubjectsSQL
                        mycommanddetails.CommandType = CommandType.Text

                        'add parameters
                        Dim SOID, StudentID, SubjectID, Term, SchoolYear, Remarks, SectionCode, IsPosted As MySqlParameter

                        With mycommanddetails

                            SOID = .Parameters.Add("?SOID", MySqlDbType.Int32)
                            StudentID = .Parameters.Add("?StudentID", MySqlDbType.VarChar)
                            SubjectID = .Parameters.Add("?SubjectID", MySqlDbType.Int32)
                            Term = .Parameters.Add("?Term", MySqlDbType.VarChar)
                            SchoolYear = .Parameters.Add("?SchoolYear", MySqlDbType.VarChar)
                            Remarks = .Parameters.Add("?Remarks", MySqlDbType.VarChar)
                            SectionCode = .Parameters.Add("?SectionCode", MySqlDbType.Int32)
                            IsPosted = .Parameters.Add("?IsPosted", MySqlDbType.Int32)

                            Term.Value = CurrentTerm
                            SchoolYear.Value = CurrentSchoolYear
                            Remarks.Value = "Advising"
                            StudentID.Value = Me.txtEDP.Text
                            IsPosted.Value = 1
                            For Each row As DataGridViewRow In Me.dvgSubjectsList.Rows
                                If row.IsNewRow = True Then

                                Else
                                    SOID.Value = row.Cells(13).Value
                                    SubjectID.Value = row.Cells(12).Value
                                    SectionCode.Value = row.Cells(1).Value

                                    intExecuteNonQueryBycommandchild = .ExecuteNonQuery()

                                End If
                            Next

                        End With

                    End Using

                    'if this is the registrar's office, then add assessment and ledger
                    'assessment
                    Using mycommandassessment As New MySqlCommand
                        mycommandassessment.Connection = myconn
                        mycommandassessment.CommandText = strAsessment
                        mycommandassessment.CommandType = CommandType.Text

                        Dim decTuiFee As Decimal = Me.dvgFees.Rows(0).Cells(2).Value
                        Dim decMiscFee As Decimal = Me.dvgFees.Rows(1).Cells(2).Value
                        Dim decOtherFee As Decimal = Me.dvgFees.Rows(3).Cells(2).Value
                        Dim decLabFee As Decimal = Me.dvgFees.Rows(2).Cells(2).Value

                        mycommandassessment.Parameters.AddWithValue("StudentID", Me.txtEDP.Text)
                        mycommandassessment.Parameters.AddWithValue("Term", CurrentTerm)
                        mycommandassessment.Parameters.AddWithValue("SchoolYear", CurrentSchoolYear)
                        mycommandassessment.Parameters.AddWithValue("TuitionFee", decTuiFee)
                        mycommandassessment.Parameters.AddWithValue("MiscellaneousFee", decMiscFee)
                        mycommandassessment.Parameters.AddWithValue("OtherFees", decOtherFee)
                        mycommandassessment.Parameters.AddWithValue("LabFees", decLabFee)

                        mycommandassessment.ExecuteNonQuery()

                    End Using

                    'ledger

                    'command text for adding / modifying student's ledger
                    Dim strLedger As String = "DELETE FROM studentledgers WHERE StudentID=?StudentID AND " _
                        & " Term=?Term AND SchoolYear=?SchoolYear AND RefNum = ?RefNum;" _
                        & "INSERT INTO studentledgers " _
                        & "(StudentID,Term,SchoolYear,TransDate,TransType,Debit,Credit,Remarks,RefNum) VALUES " _
                        & "(?StudentID,?Term,?SchoolYear,?TransDate,?TransType,?Debit,?Credit,?Remarks,?RefNum)"

                    Using mycommandledger As New MySqlCommand
                        mycommandledger.Connection = myconn
                        mycommandledger.CommandText = strLedger
                        mycommandledger.CommandType = CommandType.Text

                        Dim decEnrollmentTotal As Decimal = Me.dvgFees.Rows(4).Cells(2).Value
                        
                        mycommandledger.Parameters.AddWithValue("StudentID", Me.txtEDP.Text)
                        mycommandledger.Parameters.AddWithValue("Term", CurrentTerm)
                        mycommandledger.Parameters.AddWithValue("SchoolYear", CurrentSchoolYear)
                        mycommandledger.Parameters.AddWithValue("TransDate", Date.Today.Date)
                        mycommandledger.Parameters.AddWithValue("TransType", "Debit")
                        mycommandledger.Parameters.AddWithValue("Debit", decEnrollmentTotal)
                        mycommandledger.Parameters.AddWithValue("Credit", 0.0)
                        mycommandledger.Parameters.AddWithValue("Remarks", "Enrolment")
                        mycommandledger.Parameters.AddWithValue("RefNum", "Enrolment")

                        mycommandledger.ExecuteNonQuery()

                    End Using

                    'Add assessments fees distributions-===================================================
                    Using mycommandassessmentsdetails As New MySqlCommand
                        mycommandassessmentsdetails.Connection = myconn
                        mycommandassessmentsdetails.CommandType = CommandType.StoredProcedure

                        If boolIsAdding = True Then
                            mycommandassessmentsdetails.CommandText = "AddModifyStudentChargesPerSemester"
                        Else
                            mycommandassessmentsdetails.CommandText = "AddModifyStudentChargesPerSemester"
                        End If

                        'add parameters
                        Dim EDPNumber, FeeID, FeeTitle, Term, SchoolYear, AmountToBePaid, Remarks, Encoder, FeeCat As MySqlParameter

                        With mycommandassessmentsdetails

                            EDPNumber = .Parameters.Add("?CEDPNum", MySqlDbType.VarChar)
                            Term = .Parameters.Add("?CTerm", MySqlDbType.VarChar)
                            SchoolYear = .Parameters.Add("?CSchoolYear", MySqlDbType.VarChar)
                            AmountToBePaid = .Parameters.Add("?CAmountToBePaid", MySqlDbType.Decimal)
                            Remarks = .Parameters.Add("?CRemarks", MySqlDbType.VarChar)
                            FeeID = .Parameters.Add("?CFeeID", MySqlDbType.Int32)
                            FeeTitle = .Parameters.Add("?CFeeTitle", MySqlDbType.VarChar)
                            Encoder = .Parameters.Add("?CEncoder", MySqlDbType.VarChar)
                            FeeCat = .Parameters.Add("?CFeeCat", MySqlDbType.VarChar)

                            Term.Value = CurrentTerm
                            SchoolYear.Value = CurrentSchoolYear
                            EDPNumber.Value = Me.txtEDP.Text
                            Remarks.Value = "Enrollment"
                            Encoder.Value = CurrentSystemUser

                            'add first the tuition
                            FeeID.Value = 11111
                            FeeTitle.Value = "Tuition Fee"
                            FeeCat.Value = "Tuition Fee"
                            AmountToBePaid.Value = Me.dvgFees.Rows(0).Cells(2).Value

                            .ExecuteNonQuery()

                            'add lab fee
                            FeeID.Value = 22222
                            FeeTitle.Value = "Lab. Fee"
                            FeeCat.Value = "Lab. Fee"
                            AmountToBePaid.Value = Me.dvgFees.Rows(2).Cells(2).Value

                            .ExecuteNonQuery()

                            For Each rowC As DataGridViewRow In Me.dvgSemestralFees.Rows
                                If rowC.IsNewRow = True Then

                                Else
                                    If rowC.Cells(3).Value.ToString.Contains("Tuition") Then
                                    ElseIf rowC.Cells(2).Value.ToString.Contains("Lab. Fee") Then
                                    Else
                                        FeeID.Value = rowC.Cells(1).Value
                                        FeeTitle.Value = rowC.Cells(3).Value
                                        AmountToBePaid.Value = rowC.Cells(4).Value
                                        FeeCat.Value = rowC.Cells(2).Value.ToString
                                        .ExecuteNonQuery()

                                    End If

                                End If
                            Next

                        End With

                    End Using
                    'End add assessments fees distributions-============================================================

                    '--------------------------------------------- commit transactions ----------------------------------
                    mytrans.Commit()
                    boolReturn = True

                Catch ex As MySqlException
                    boolReturn = False
                    mytrans.Rollback()
                    Dim newfrm As New frmErrorMessageViewer
                    With newfrm
                        .ErrorMessage = ex.Message
                        .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveStudentEnrollment" & vbCrLf & vbCrLf & ex.StackTrace
                        .ErrorForHumans = "Cannot continue saving record because an error occured."
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    boolReturn = False
                    mytrans.Rollback()
                    Dim newfrm As New frmErrorMessageViewer
                    With newfrm
                        .ErrorMessage = ex.Message
                        .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveStudentEnrollment" & vbCrLf & vbCrLf & ex.StackTrace
                        .ErrorForHumans = "Cannot continue saving record because an error occured."
                        .ShowDialog()
                    End With
                End Try
            End Using
        Catch ex As MySqlException
            boolReturn = False
            'mytrans.Rollback()
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveStudentEnrollment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue saving record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveStudentEnrollment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue saving record because an error occured."
                .ShowDialog()
            End With
        End Try
       

        Return boolReturn

    End Function


    Private Sub SetSubject()

        If Trim(Me.txtEDP.Text).Length <= 0 Then
            Me.txtEDP.Focus()
            Me.ErrProve.SetError(Me.txtEDP, "Please select student to enroll.")
            Me.lblError.Text = "Please select student to enroll."
            Me.lblError.Visible = True
            Exit Sub
        End If

        If (Me.txtSectionCode.Text.Length < 4) Then
            Me.txtSectionCode.Focus()
            Me.txtSectionCode.SelectAll()
            Me.ErrProve.SetError(Me.txtSectionCode, "Please enter correct Section Code.")
            Me.lblError.Text = "Please enter correct Section Code."
            Me.lblError.Visible = True
        Else
            Try


                If (Me.txtSectionCode.Text.Length < 4) Then
                    Me.txtDummy.Focus()
                    Me.txtSectionCode.SelectAll()
                    Me.ErrProve.SetError(Me.txtSectionCode, "Please enter correct Section Code.")
                Else
                    Dim num2 As String = Me.txtSectionCode.Text

                    If Me.CheckEntries(num2) = True Then
                        Me.ErrProve.SetError(Me.txtSectionCode, "Section code is in the list.")
                        Me.lblError.Text = "Section code is in the list."
                        Me.lblError.Visible = True
                        Exit Sub
                    Else
                        Dim boolIsTrue As Boolean = Me.SearchSubjectFromDataset(num2)

                        If boolIsTrue = False Then
                            Me.ErrProve.SetError(Me.txtSectionCode, "Section Code not found in the current course offerings.")
                            Me.lblError.Text = "Section Code not found in the current course offerings."
                            Me.lblError.Visible = True
                            Me.txtSectionCode.Focus()
                            Me.txtSectionCode.SelectAll()
                            Exit Sub
                        End If

                        Dim subjectTotalEnrolees As Integer = Me.GetSubjectTotalEnrolees(num2)

                        If (subjectTotalEnrolees >= Me.intSlots) Then
                            'Dim num3 As Integer = CInt(MessageBox.Show(("Number of students enrolled has reached the limit set for this section." & vbCrLf & "Subject closed: " & ChrW(13) & ChrW(10) & "Number of enrolees: " & ChrW(13) & ChrW(10) & Convert.ToString(subjectTotalEnrolees) & ChrW(13) & ChrW(10) & "Limits: " & Convert.ToString(Me.intSlots)), "Closed Subject"))
                            Me.ErrProve.SetError(Me.txtSectionCode, "Number of students enrolled has reached the limit set for this section.")
                            Me.lblError.Text = "Number of students enrolled has reached the limit set for this section."

                            Dim intYN As Integer

                            intYN = MessageBox.Show("Number of students enrolled has reached the limit set for this section." & _
                                    vbCrLf & vbCrLf & "Please click Yes to allow admission or No to not allow admission.", "Select action.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

                            If intYN = vbNo Then
                                Me.lblError.Visible = True
                                Me.txtSectionCode.Focus()
                                Exit Sub
                            End If

                        End If

                        If Me.CheckConflict(Me.strTime, Me.strDay, Me.strRoom) Then
                            'MessageBox.Show("This schedule conflicts with another schedule already listed.", "Conflict of Schedule")
                            Me.ErrProve.SetError(Me.txtSectionCode, "This schedule conflicts with another schedule already listed.")
                            Me.lblError.Text = "This schedule conflicts with another schedule already listed."
                            Me.lblError.Visible = True

                            If Me.chkAllowConflict.Checked = False Then
                                Exit Sub
                            Else
                                'add to datagridvieew

                                With Me.dvgSubjectsList
                                    .Rows.Add(0, Me.strSectionCode, Me.strSubCode, Me.strDesc, Me.strTime, _
                                              Me.strDay, Me.strRoom, Me.strTime1, Me.strDay1, Me.strRoom1, _
                                              Me.strUnit, Me.strLabCode, Me.strSubjectNumber, Me.intCourseOfferingID)
                                End With

                            End If

                        Else

                            With Me.dvgSubjectsList
                                .Rows.Add(0, Me.strSectionCode, Me.strSubCode, Me.strDesc, Me.strTime, _
                                          Me.strDay, Me.strRoom, Me.strTime1, Me.strDay1, Me.strRoom1, _
                                          Me.strUnit, Me.strLabCode, Me.strSubjectNumber, Me.intCourseOfferingID)
                            End With

                        End If
                    End If
                    'Me.lblTotUnits.Text = CalcTotalUnits(Me.lvwSubjects)
                    Me.txtSectionCode.Clear()
                    Me.txtSectionCode.Focus()

                End If
            Catch exception1 As Exception
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message, "Error - Set Subject")
                Me.cboSubjects.Focus()
            End Try
        End If
    End Sub

    Private Sub GetCourseOfferings()

        'Dim dtatable As New DataTable

        TheTableOfCourseOfferings = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetCourseOfferingsBySemesterAndSchoolYearAll", 4, CurrentTerm, CurrentSchoolYear)

    End Sub

    Private Function SearchSubjectFromDataset(ByVal strSectionCode As String) As Boolean

        Try
            For Each rowsub As DataRow In TheTableOfCourseOfferings.Rows
                If rowsub("SOCode").ToString = strSectionCode Then
                    'set data
                    Me.strSectionCode = Convert.ToString(rowsub("SOCode"))
                    Me.strSubCode = Convert.ToString(rowsub("SubjectCode"))
                    Me.strDesc = Convert.ToString(rowsub("DescriptiveTitle"))
                    Me.strTime = Convert.ToString(rowsub("Time1"))
                    Me.strRoom = Convert.ToString(rowsub("Room1"))
                    Me.strDay = Convert.ToString(rowsub("Day1"))
                    Me.strUnit = Convert.ToString(rowsub("NumOfUnits"))
                    Me.intSlots = Convert.ToInt32(rowsub("NumOfSeats"))
                    Me.intCourseOfferingID = Convert.ToInt32(rowsub("SOID"))
                    Me.strSubjectNumber = Convert.ToString(rowsub("SubjectID"))
                    Me.strTime1 = Convert.ToString(rowsub("Time2"))
                    Me.strDay1 = Convert.ToString(rowsub("Day2"))
                    Me.strRoom1 = Convert.ToString(rowsub("Room2"))
                    Me.strLabCode = Convert.ToString(rowsub("LabCode"))
                    Return True
                End If
            Next
        Catch ex As Exception
            Return False
            Debug.Print(ex.Message & vbCrLf & "In SearchSubjectFromDataset")
        Finally
            'Return False
        End Try

        'Return boolReturn

    End Function

    Private Function GetSubjectTotalEnrolees(ByVal SecNum As String) As Integer
        Dim connection As New MySqlConnection
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter

        Dim intNumEnrolled As Integer = 0

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    With mycommand
                        .Connection = myconn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT COUNT(ESSID) AS NumeEnrolled FROM enrolledstudentssubjects WHERE " _
                            & "SectionCode=?SectionCode AND Term=?Term AND SchoolYear=?SchoolYear;"

                        .Parameters.AddWithValue("SectionCode", SecNum)
                        .Parameters.AddWithValue("Term", CurrentTerm)
                        .Parameters.AddWithValue("SchoolYear", CurrentSchoolYear)

                        myconn.Open()
                        Dim reader As MySqlDataReader = .ExecuteReader

                        Do While reader.Read
                            If IsDBNull(reader.Item(0)) = True Then
                                intNumEnrolled = 0
                            Else
                                intNumEnrolled = reader.GetInt32("NumeEnrolled")
                            End If

                        Loop
                    End With
                End Using
            End Using
        Catch ex As Exception

        End Try
        
        Return intNumEnrolled

    End Function

#End Region

#Region "Helper"

    Private Sub DisAbleEnableModifications(ByVal boolAllow As Boolean)

        With Me
            .cmdSave.Enabled = boolAllow
            .txtSectionCode.Enabled = boolAllow
            .cmdRemove.Enabled = boolAllow
            .cmdClearList.Enabled = boolAllow
            .txtYear.Enabled = boolAllow
            .txtStatus.Enabled = boolAllow
        End With
    End Sub

    Private Function CalculateTotalUnits() As Decimal

        Dim decUnits As Decimal = 0.0
        Dim decUnitsNSTP As Decimal = 0.0

        For Each row As DataGridViewRow In Me.dvgSubjectsList.Rows

            If Trim(row.Cells(11).Value.ToString).ToUpper = "N" Then
                'exclude NSTP subjects
                decUnitsNSTP = decUnitsNSTP + row.Cells(10).Value
            Else
                decUnits = decUnits + row.Cells(10).Value
            End If
            Debug.Print("row.Cells(11).ToString: " & row.Cells(11).Value.ToString.ToUpper)
        Next
        If decUnitsNSTP > 0.0 Then
            Me.lblTotUnitsDisplay.Text = FormatNumber(decUnits, 1) & "/" & FormatNumber(decUnits + decUnitsNSTP, 1)
        Else
            Me.lblTotUnitsDisplay.Text = FormatNumber(decUnits, 1)
        End If
        Me.lblNSTP.Text = FormatNumber(decUnitsNSTP + decUnits, 1)
        Return decUnits
        

    End Function

    Private Function AddSubjectsToTheDataGridView(ByVal TheList As List(Of ClassSubjectsEnrolled), ByVal TheDataGridViewToBeAdded As DataGridView) As Boolean

        Try
            For Each ListElement As ClassSubjectsEnrolled In TheList
                TheDataGridViewToBeAdded.Rows.Add(ListElement.TheESSID, ListElement.CourseOfferingNumber, ListElement.SubjectCode, ListElement.DescTitle, _
                    ListElement.Time1, ListElement.Day1, ListElement.Room1, ListElement.Time2, ListElement.Day2, _
                    ListElement.Room2, ListElement.Units, ListElement.LabCode, ListElement.SubjectID, ListElement.CourseOfferingID)
            Next
            AddSubjectsToTheDataGridView = True
        Catch ex As Exception
            AddSubjectsToTheDataGridView = False
            Dim newfrmerror As New frmErrorMessageViewer
            With newfrmerror
                .ErrorMessage = "Error adding subjects for enrollment."
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "cmdBlock_Click" & vbCrLf & vbCrLf & ex.Message _
                    & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding subjects because an error occured."
                .ShowDialog()
            End With
        End Try
        
    End Function

    Private Sub InitializeFeesGrids()
        Me.dvgFees.Rows.Add(0, "Tuition Fee", 0.0)
        Me.dvgFees.Rows.Add(0, "Misc. Fee", 0.0)
        Me.dvgFees.Rows.Add(0, "Lab. Fee", 0.0)
        Me.dvgFees.Rows.Add(0, "Other Fees", 0.0)
        Me.dvgFees.Rows.Add(0, "Sub-Total", 0.0)
        Me.dvgFees.Rows.Add(0, "Back Accounts", 0.0)
        Me.dvgFees.Rows.Add(0, "Less: Payments", 0.0)
        Me.dvgFees.Rows.Add(0, "Balance", 0.0)

        'apply beauty
        Me.dvgFees.Rows(4).Cells(1).Style.BackColor = Color.Cornsilk
        Me.dvgFees.Rows(4).Cells(2).Style.BackColor = Color.Cornsilk
        Me.dvgFees.Rows(7).Cells(1).Style.BackColor = Color.LightSkyBlue
        Me.dvgFees.Rows(7).Cells(2).Style.BackColor = Color.LightSkyBlue
    End Sub


    Private Sub AssignFees()

        'assign first the tuition fees
        Dim decTuitionFee As Decimal = 0.0
        Dim decTuitionFeeOld As Decimal = 0.0
        Dim decTuitionFeeNew As Decimal = 0.0
        Dim decTuitionFeeGrad As Decimal = 0.0

        Dim decMiscellaneousFees As Decimal = 0.0

        Dim LabAgricultureFee As Decimal = 0.0
        Dim LabComputerFee As Decimal = 0.0
        Dim LabScienceFee As Decimal = 0.0
        Dim LabBSEDInternFee As Decimal = 0.0

        Dim TotalLabAgricultureFee As Decimal = 0.0
        Dim TotalLabComputerFee As Decimal = 0.0
        Dim TotalLabScienceFee As Decimal = 0.0
        Dim TotalLabBSEDInternFee As Decimal = 0.0

        Dim TotalLabFee As Decimal = 0.0

        Dim decOtherFees As Decimal = 0.0
        Dim decNSTP As Decimal = 0.0
        Dim boolNSTPSubjectIsPresent As Boolean = False

        Try
            'get fees amount
            For Each row As DataRow In TheTableOfFees.Rows
                If row("FeeCategory") = "Tuition Fee" Then
                    decTuitionFee = decTuitionFee + row("Amount")
                    If row("FeeName") = "Tuition Fee New" Then
                        decTuitionFeeNew = decTuitionFeeNew + row("Amount")
                    ElseIf row("FeeName") = "Tuition Fee Old" Then
                        decTuitionFeeOld = decTuitionFeeOld + row("Amount")
                    End If
                ElseIf row("FeeCategory") = "Misc. Fee" Then
                    decMiscellaneousFees = decMiscellaneousFees + row("Amount")
                    If row("FeeName") = "NSTP(ROTC/CWTS/LTS)" Then
                        decNSTP = decNSTP + row("Amount")
                    End If
                ElseIf row("FeeCategory") = "Other Fees" Then
                    decOtherFees = decOtherFees + row("Amount")
                ElseIf row("FeeCategory") = "Lab. Fee" Then
                    If row("FeeName") = "Agriculture" Then
                        LabAgricultureFee = LabAgricultureFee + row("Amount")
                    ElseIf row("FeeName") = "BSED Internship" Then
                        LabBSEDInternFee = LabBSEDInternFee + row("Amount")
                    ElseIf row("FeeName") = "Computer" Then
                        LabComputerFee = LabComputerFee + row("Amount")
                    ElseIf row("FeeName") = "Science" Then
                        LabScienceFee = LabScienceFee + row("Amount")
                    End If
                End If
            Next

            'get number of subjects
            Dim intNumOfUnits As Integer = CInt(Me.lblTotUnits.Text)

            Dim TotalTuitionFee As Decimal = intNumOfUnits * decTuitionFee

            If Me.txtStatus.Text.ToUpper = "NEW" Then
                TotalTuitionFee = intNumOfUnits * decTuitionFeeNew

            ElseIf Me.txtStatus.Text.ToUpper = "OLD" Then
                TotalTuitionFee = intNumOfUnits * decTuitionFeeOld
            ElseIf Me.txtStatus.Text.ToUpper = "Returnee" Then
                TotalTuitionFee = intNumOfUnits * decTuitionFeeOld
            End If
            'iterate the subjects list for assigning lab fees, and other fees that are to be calculated based
            'on the number of units
            For Each row As DataGridViewRow In Me.dvgSubjectsList.Rows
                'get lab code
                If row.Cells("LabCode").Value.ToString.ToUpper = "C" Then
                    TotalLabComputerFee = TotalLabComputerFee + LabComputerFee
                ElseIf row.Cells("LabCode").Value.ToString.ToUpper = "A" Then
                    TotalLabAgricultureFee = TotalLabAgricultureFee + LabComputerFee
                ElseIf row.Cells("LabCode").Value.ToString.ToUpper = "S" Then
                    TotalLabScienceFee = TotalLabScienceFee + LabScienceFee
                ElseIf row.Cells("LabCode").Value.ToString.ToUpper = "B" Then
                    TotalLabBSEDInternFee = TotalLabBSEDInternFee + LabBSEDInternFee
                ElseIf row.Cells("LabCode").Value.ToString.ToUpper = "N" Then
                    boolNSTPSubjectIsPresent = True
                End If
            Next

            'determine if there's NSTP present, if not present, subtract amount of the nstp from the miscellaneous fee
            If boolNSTPSubjectIsPresent = False Then
                decMiscellaneousFees = decMiscellaneousFees - decNSTP
            End If

            'total laboratory fees
            TotalLabFee = TotalLabAgricultureFee + TotalLabScienceFee + TotalLabBSEDInternFee + TotalLabComputerFee

            Dim SubTotal As Decimal = 0.0

            SubTotal = TotalTuitionFee + TotalLabFee + decMiscellaneousFees + decOtherFees + decTuitionFee

            Dim BackAccounts As Decimal = 0.0
            Dim Payments As Decimal = CDec(Me.txtPayments.Text)

            Dim Balance As Decimal = 0.0

            'calculate balance,
            Balance = SubTotal + BackAccounts - Payments

            'insert into the datagridview fees list

            Me.dvgFees.Rows(0).Cells(2).Value = TotalTuitionFee
            Me.dvgFees.Rows(1).Cells(2).Value = decMiscellaneousFees
            Me.dvgFees.Rows(2).Cells(2).Value = TotalLabFee
            Me.dvgFees.Rows(3).Cells(2).Value = decOtherFees
            Me.dvgFees.Rows(4).Cells(2).Value = SubTotal
            Me.dvgFees.Rows(5).Cells(2).Value = BackAccounts
            Me.dvgFees.Rows(6).Cells(2).Value = Payments
            Me.dvgFees.Rows(7).Cells(2).Value = Balance

            'Insert into the datagridview for fee distribution
            'Insert Tuition

            For Each rowC As DataGridViewRow In Me.dvgSemestralFees.Rows
                If Me.txtStatus.Text.ToUpper = "OLD" Then
                    If rowC.Cells("FeeName").Value.ToString = "Tuition Fee New" Then
                        rowC.Cells("FeeAmount").Value = 0.0
                    End If
                    If rowC.Cells("FeeName").Value.ToString = "Tuition Fee Old" Then
                        rowC.Cells("FeeAmount").Value = TotalTuitionFee
                    End If
                Else
                    If rowC.Cells("FeeName").Value.ToString = "Tuition Fee New" Then
                        rowC.Cells("FeeAmount").Value = TotalTuitionFee
                    End If
                    If rowC.Cells("FeeName").Value.ToString = "Tuition Fee Old" Then
                        rowC.Cells("FeeAmount").Value = 0.0
                    End If
                End If

            Next

        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & " In AssignFees")
        End Try        

    End Sub

    Private Sub AssigneFeeNamesIntoDataGridview(ByVal theDataOfFees As DataTable, ByVal theDatagridview As DataGridView)
        Try
            For Each row As DataRow In theDataOfFees.Rows
                With theDatagridview
                    .Rows.Add(row("SFID"), row("FNID"), row("FeeCategory"), row("FeeName"), row("Amount"))
                End With
            Next
        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Procedure to check if section code is already entered.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckEntries(ByVal strCode As String) As Boolean

        Dim boolReturned As Boolean = False

        For Each row As DataGridViewRow In Me.dvgSubjectsList.Rows
            Debug.Print("row.Cells(1).ToString: " & row.Cells(1).Value.ToString & " In CheckEntries")
            If row.Cells(1).Value.ToString = strCode Then

                Debug.Print("row.Cells(1).ToString: " & row.Cells(1).Value.ToString & " In CheckEntries inside If")
                Return True
                'Exit Function
            End If
        Next

        Return False


    End Function


    Private Function CheckConflict(ByVal strTimeC As String, ByVal strDayC As String, ByVal strRoomC As String) As Boolean

        Dim boolReturn As Boolean

        For Each row As DataGridViewRow In Me.dvgSubjectsList.Rows

            If row.Cells(4).Value.ToString = strTimeC And row.Cells(5).Value.ToString = strDayC _
                And row.Cells(6).Value.ToString = strRoomC Then
                'we have conflict

                boolReturn = True

                Exit Function
            End If
        Next

        Return boolReturn

    End Function

    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        Dim decTuiFee As Decimal = Me.dvgFees.Rows(0).Cells(2).Value
        Dim decMiscFee As Decimal = Me.dvgFees.Rows(1).Cells(2).Value
        Dim decOtherFee As Decimal = Me.dvgFees.Rows(3).Cells(2).Value
        Dim decLabFee As Decimal = Me.dvgFees.Rows(2).Cells(2).Value

        Dim decTotal As Decimal = decTuiFee + decMiscFee + decOtherFee + decLabFee

        Dim decLess As Decimal = Me.dvgFees.Rows(6).Cells(2).Value
        Dim decBack As Decimal = Me.dvgFees.Rows(5).Cells(2).Value

        Dim decBalance As Decimal = decTotal + decBack - decLess

        Dim s As String = "----------------------------------------------------------------------------------------------------------------------------------------------------------------------"

        Dim format As New StringFormat

        With format
            .Alignment = StringAlignment.Near
            '.LineAlignment = StringAlignment.Far
            'LineAlignment = StringAlignment.Far
            .FormatFlags = StringFormatFlags.DirectionRightToLeft
        End With
        'format = New StringFormat(format.Alignment = StringAlignment.Far)

        ev.PageSettings.PrinterResolution.Kind = PrinterResolutionKind.Draft
        ev.Graphics.DrawString("JHCSC Main Campus", New Font("Draft 5cpi", 13.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(20.0!))
        ev.Graphics.DrawString("STUDENT'S COPY", New Font("Draft PS", 11.0!, FontStyle.Regular), Brushes.Black, 700.0!, 20.0!, format)
        ev.Graphics.DrawString("CERTIFICATE OF ENROLLMENT", New Font("Sans Serif 6cpi", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(50.0!))
        ev.Graphics.DrawString((CurrentTerm & ", " & CurrentSchoolYear), New Font("Sans Serif 6cpi", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(70.0!))
        ev.Graphics.DrawString(("EDP No. : " & Me.txtEDP.Text), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(100.0!))
        ev.Graphics.DrawString("Tuition Fee      : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(100.0!))
        ev.Graphics.DrawString(FormatNumber(decTuiFee, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 100.0!, format)
        ev.Graphics.DrawString("Lab. Fee    : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(120.0!))
        ev.Graphics.DrawString(FormatNumber(decLabFee, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 120.0!, format)
        ev.Graphics.DrawString(("Name ... : " & Me.txtName.Text.ToUpper), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(140.0!))
        ev.Graphics.DrawString("Misc. Fee         : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(140.0!))
        ev.Graphics.DrawString(FormatNumber(decMiscFee, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 140.0!, format)
        ev.Graphics.DrawString(("Course & Year: " & Me.txtCourse.Text & " - " & Me.txtYear.Text), New Font("Draft PS", 11.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(160.0!))
        ev.Graphics.DrawString("Other Fees         : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(160.0!))
        ev.Graphics.DrawString(FormatNumber(decOtherFee, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 160.0!, format)
        ev.Graphics.DrawString(("Sex .... : " & Me.txtSex.Text), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(180.0!))
        'ev.Graphics.DrawString("Other Fees       : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(160.0!))
        ev.Graphics.DrawString("--------------", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 180.0!, format)
        'ev.Graphics.DrawString(FormatNumber(decOtherFee, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 160.0!, format)
        ev.Graphics.DrawString(("Date Enrolled : " & (Me.dtpEnrolled.Value.Date)), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(200.0!))
        ev.Graphics.DrawString(("Date Re-assessed : " & (Me.dtpAssessed.Value.Date)), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(210.0!), CSng(200.0!))
        ev.Graphics.DrawString("*Total Charge    : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(200.0!))
        ev.Graphics.DrawString(FormatNumber(decTotal, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 200.0!, format)

        'ev.Graphics.DrawString("Charges          : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(175.0!))
        'ev.Graphics.DrawString(FormatNumber(0, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 175.0!, format)
        'ev.Graphics.DrawString("Add'l Charges    : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(188.0!))
        'ev.Graphics.DrawString(FormatNumber(CDec(Me.txtAddCharges.Text) + CDec(Me.txtHRMFund.Text), 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 188.0!, format)
        'ev.Graphics.DrawString("Cooking Program  : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(203.0!))
        'ev.Graphics.DrawString(Me.txtCooking.Text, New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 203.0!, format)
        'ev.Graphics.DrawString("--------------", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 213.0!, format)
        'ev.Graphics.DrawString("*Total Charge    : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(224.0!))
        'ev.Graphics.DrawString(FormatNumber(decTotal, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 224.0!, format)
        ev.Graphics.DrawString("Less: Payments   : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(220.0!))
        ev.Graphics.DrawString(FormatNumber(decLess, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 220.0!, format)
        ev.Graphics.DrawString("--------------", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 230.0!, format)
        ev.Graphics.DrawString("*Balance         : ", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(550.0!), CSng(245.0!))
        ev.Graphics.DrawString(FormatNumber(decBalance, 2), New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 750.0!, 245.0!, format)
        ev.Graphics.DrawString(s, New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(290.0!))
        ev.Graphics.DrawString("Section", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(310.0!))
        ev.Graphics.DrawString("Subject", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(80.0!), CSng(310.0!))

        ev.Graphics.DrawString("Units", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(180.0!), CSng(310.0!))
        ev.Graphics.DrawString("Time", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(230.0!), CSng(310.0!))
        ev.Graphics.DrawString("Day", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(350.0!), CSng(310.0!))
        ev.Graphics.DrawString("Room", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(420.0!), CSng(310.0!))
        ev.Graphics.DrawString("Descriptive Title", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(512.0!), CSng(310.0!))
        'ev.Graphics.DrawString("No", New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(730.0!), CSng(310.0!))
        ev.Graphics.DrawString(s, New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, CSng(20.0!), CSng(320.0!))

        Dim num2 As Integer = 317
        Dim num3 As Integer = 0
        Dim i As Integer = 0

        Dim text As String = ""
        Dim str7 As String = ""
        Dim str9 As String = ""
        Dim str8 As String = ""
        Dim str As String = ""
        Dim str5 As String = ""
        Dim str2 As String = ""
        Dim str4 As String = ""

        For Each row As DataGridViewRow In Me.dvgSubjectsList.Rows
            text = row.Cells(1).Value.ToString      'section code
            str7 = row.Cells(2).Value.ToString      'subject
            str9 = row.Cells(10).Value.ToString      'units
            str8 = row.Cells(4).Value.ToString      'time
            str = row.Cells(5).Value.ToString      'day
            str5 = row.Cells(6).Value.ToString      'room

            'descriptive title, but limit to 19 characters only
            str2 = Mid(row.Cells(3).Value.ToString, 1, 29)
            str4 = row.Cells(12).Value.ToString      'subject number

            num2 = (num2 + 15)

            ev.Graphics.DrawString([text], New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 20.0!, CSng(num2))
            ev.Graphics.DrawString(str7, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
            ev.Graphics.DrawString(str9, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 180.0!, CSng(num2))
            ev.Graphics.DrawString(str8, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 230.0!, CSng(num2))
            ev.Graphics.DrawString(str, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 350.0!, CSng(num2))
            ev.Graphics.DrawString(str5, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 420.0!, CSng(num2))
            ev.Graphics.DrawString(str2, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 512.0!, CSng(num2))

        Next

        'Do While (i <= num3)

        '    'Dim text As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(1).Text
        '    'Dim str7 As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(2).Text
        '    'Dim str9 As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(4).Text
        '    'Dim str8 As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(5).Text
        '    'Dim str As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(6).Text
        '    'Dim str5 As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(7).Text
        '    'Dim str2 As String = Strings.Mid(Me.lvwSubjects.Items.Item(i).SubItems.Item(3).Text, 1, &H19)
        '    'Dim str4 As String = Me.lvwSubjects.Items.Item(i).SubItems.Item(11).Text

        '    num2 = (num2 + 15)

        '    ev.Graphics.DrawString([text], New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 20.0!, CSng(num2))
        '    ev.Graphics.DrawString(str7, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
        '    ev.Graphics.DrawString(str9, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 180.0!, CSng(num2))
        '    ev.Graphics.DrawString(str8, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 230.0!, CSng(num2))
        '    ev.Graphics.DrawString(str, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 350.0!, CSng(num2))
        '    ev.Graphics.DrawString(str5, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 420.0!, CSng(num2))
        '    ev.Graphics.DrawString(str2, New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 512.0!, CSng(num2))
        '    'ev.Graphics.DrawString(str4, New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 730.0!, CSng(num2))
        '    i += 1
        'Loop

        num2 = (num2 + 10)
        ev.Graphics.DrawString(s, New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 20.0!, CSng(num2))
        num2 = (num2 + 20)
        ev.Graphics.DrawString(("** Total Units : " & Me.lblNSTP.Text & " **"), New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
        num2 = (num2 + 10)
        ev.Graphics.DrawString("-----------------------------------------", New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
        num2 = (num2 + 5)
        ev.Graphics.DrawString("-----------------------------------------", New Font("Draft PS", 9.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
        num2 = (num2 + 15)
        ev.Graphics.DrawString("Note: Please report immediately any data entry error.", New Font("Draft PS", 8.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
        num2 = (num2 + 15)
        ev.Graphics.DrawString("         -- Always use correct student EDP No. --", New Font("Draft PS", 8.0!, FontStyle.Regular), Brushes.Black, 80.0!, CSng(num2))
        num2 = (num2 + 10)
        ev.Graphics.DrawString(s, New Font("Draft PS", 10.0!, FontStyle.Regular), Brushes.Black, 20.0!, CSng(num2))
        ev.HasMorePages = False
    End Sub

    Private Sub PrintCertificate()
        Try
            Dim document As New PrintDocument
            AddHandler document.PrintPage, New PrintPageEventHandler(AddressOf Me.PrintText)
            document.Print()
        Catch exception1 As Exception
            'ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            MessageBox.Show((exception.Message & ChrW(13) & ChrW(10) & "Sorry--there is a problem printing"), "Error - PrintDocument")
            'ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub ClearControls()
        If Me.txtEDP.Text.Length <= 0 Then
            Me.txtEDP.Text = My.Settings.SchoolCode & "-"
            Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
            Me.txtEDP.Focus()

        End If

        With Me
            .txtName.Clear()
            .txtCourse.Clear()
            .txtDegree.Clear()
            .txtDept.Clear()
            .txtYear.Clear()
            .txtStatus.Clear()
            .txtPayments.Text = "0.00"
            '.lvwSubjects.Items.Clear()
            .dvgSubjectsList.Rows.Clear()
            .ErrProve.Clear()

            .txtCourse.Clear()
            .txtAddCharges.Text = "0.00"
            .txtBackAccount.Text = "0.00"
            .txtSex.Clear()
            '.lvwSubjects.Items.Clear()
            .txtStatus.Clear()
            .txtCourse.Clear()
            .txtYear.Clear()
            .txtPremium.Text = "0.00"
            .txtOtherFees.Text = "0.00"
            .txtLabFee.Text = "0.00"
            .txtMatFee.Text = "0.00"
            .txtTuition.Text = "0.00"
            .txtCharges.Text = "0.00"
            .txtTotal.Text = "0.00"
            .txtLess.Text = "0.00"
            .txtBalance.Text = "0.00"
            .txtCooking.Text = "0.00"
            .lblTotUnits.Text = Convert.ToDecimal(0)
            .lblNSTP.Text = Convert.ToDecimal(0)
            .lblTotUnitsDisplay.Text = Convert.ToDecimal(0)
            .dtpEnrolled.Value = Date.Today.Date
            .txtPayments.Text = "0.00"
            '.TheEDP = ""
            Me.txtIsEnrolled.Text = 0
        End With
    End Sub
#End Region


#Region "Properties"

    Dim boolIsNewEnrollment As Boolean

    ''' <summary>
    ''' If it's a new enrollment, returns True
    ''' else returns False
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NewEnrollment() As Boolean
        Get
            Return boolIsNewEnrollment
        End Get
        Set(ByVal value As Boolean)
            boolIsNewEnrollment = value
        End Set
    End Property


    Dim intNumOfSlots As Integer
    Public Property NumOfSlots() As Integer
        Get
            Return intNumOfSlots
        End Get
        Set(ByVal value As Integer)
            intNumOfSlots = value
        End Set
    End Property

#End Region

    Private Sub frmAddEditStudentEvaluation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Student Evaluation / Load Encoding")
        InitializeFeesGrids()
        GetSemestralFees()
        GetCourseOfferings()
        CurrentUserDept = "REGISTRAR"
        Me.NewEnrollment = False
        AssigneFeeNamesIntoDataGridview(TheTableOfFees, Me.dvgSemestralFees)
    End Sub

    Private Sub txtEDPNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtEDP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDP.GotFocus
        Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
    End Sub

    Private Sub txtEDP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEDP.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                ClearControls()
                If GetEnrollmentDetails(Me.txtEDP.Text) = True Then

                    Me.txtYear.Focus()
                    'If Convert.ToDecimal(Me.txtPayments.Text) <= 0.0 Then
                    '    Me.ErrProve.SetError(Me.lblError, "No payments for entrance have been received. Please advise student to pay for entrance fee first before enrolling.")
                    '    Me.ErrProve.SetError(Me.txtLess, "No payments for entrance have been received. Please advise student to pay for entrance fee first before enrolling.")
                    '    Me.lblError.Text = "No payments for entrance have been received from this student."
                    '    Me.lblError.Visible = True
                    '    'Me.txtEDP.Focus()
                    '    Exit Sub
                    'End If
                    If Me.txtCourse.Text.Length <= 0 Then
                        'student have no course yet, therefore allow adviser to enter course for the student.
                        If Me.txtName.Text.Length <= 0 Then

                        Else
                            Dim newfrm As New frmEditStudentCourse

                            With newfrm
                                .IsAdding = False
                                .EDPNumber = Me.txtEDP.Text
                                .ShowDialog()
                                If .MustUpdate = True Then
                                    'reload
                                    ClearControls()
                                    If GetEnrollmentDetails(Me.txtEDP.Text) = True Then
                                        Me.txtYear.Focus()
                                    Else
                                        Me.txtEDP.Focus()
                                        Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                                    End If
                                Else
                                    Me.txtEDP.Focus()
                                    Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                                End If
                            End With
                        End If
                    End If
                Else
                    Me.txtEDP.Focus()

                End If
                'Case Keys.Escape

        End Select
    End Sub

    Private Sub txtEDP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEDP.TextChanged
        If Me.txtEDP.Text.Length <= 0 Then
            Me.txtEDP.Text = My.Settings.SchoolCode & "-"
            Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
            Me.txtEDP.Focus()

        End If

        With Me
            .txtName.Clear()
            .txtCourse.Clear()
            .txtDegree.Clear()
            .txtDept.Clear()
            .txtYear.Clear()
            .txtStatus.Clear()
            .txtPayments.Text = "0.00"
            '.lvwSubjects.Items.Clear()
            .dvgSubjectsList.Rows.Clear()
            .ErrProve.Clear()

            .txtCourse.Clear()
            .txtAddCharges.Text = "0.00"
            .txtBackAccount.Text = "0.00"
            .txtSex.Clear()
            '.lvwSubjects.Items.Clear()
            .txtStatus.Clear()
            .txtCourse.Clear()
            .txtYear.Clear()
            .txtPremium.Text = "0.00"
            .txtOtherFees.Text = "0.00"
            .txtLabFee.Text = "0.00"
            .txtMatFee.Text = "0.00"
            .txtTuition.Text = "0.00"
            .txtCharges.Text = "0.00"
            .txtTotal.Text = "0.00"
            .txtLess.Text = "0.00"
            .txtBalance.Text = "0.00"
            .txtCooking.Text = "0.00"
            .lblTotUnits.Text = Convert.ToDecimal(0)
            .lblNSTP.Text = Convert.ToDecimal(0)
            .lblTotUnitsDisplay.Text = Convert.ToDecimal(0)
            .dtpEnrolled.Value = Date.Today.Date
            .txtPayments.Text = "0.00"
            '.TheEDP = ""
            Me.txtIsEnrolled.Text = 0
        End With

    End Sub

    Private Sub txtYear_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYear.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtStatus.Focus()
                Me.txtStatus.SelectAll()
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Me.txtName.Text.Length <= 0 Then
            Me.lblError.Text = "Please select student."
            Me.lblError.Visible = True
            Me.txtEDP.Focus()
            Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
            Exit Sub
        End If
        If IsNumeric(Me.txtYear.Text) = False Then
            Me.txtYear.Text = 0
            Me.lblError.Text = "Incorrect Data for Year."
            Me.lblError.Visible = True
            Me.txtYear.Focus()
            Exit Sub
        End If
        If CInt(Me.txtYear.Text) < 1 Or CInt(Me.txtYear.Text) > 5 Then
            Me.txtYear.Text = 0
            Me.lblError.Text = "Incorrect Data for Year."
            Me.lblError.Visible = True
            Me.txtYear.Focus()
            Exit Sub
        End If

        If Me.txtStatus.Text <> "OLD" And Me.txtStatus.Text <> "NEW" And Me.txtStatus.Text <> "RETURNEE" Then
            Me.ErrProve.SetError(Me.txtStatus, "Please enter Status [NEW,OLD,RETURNEE].")
            Me.txtStatus.Focus()
            Exit Sub
        End If

        'payment received?
        'for registrar only
        Dim intYN As Integer = vbNo

        If CurrentUserDept.ToString.ToUpper = "REGISTRAR" Then
            'check if student has paid the downpayment
            If Convert.ToDecimal(Me.txtPayments.Text) <= 0.0 Then
                Me.ErrProve.SetError(Me.lblError, "No payments for entrance have been received. Please advise student to pay for entrance fee first before enrolling.")
                Me.lblError.Text = "No payments for entrance have been received from this student."
                Me.lblError.Visible = True
                intYN = MessageBox.Show("No entrance payment has been received. " & vbCrLf _
                                      & "Allow student to register? " & vbCrLf _
                                      & "Please select Yes to allow enrollment or No and advise student to pay entrance first.", _
                                      "Confirm registration.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                If intYN = vbNo Then
                    Me.txtEDP.Focus()
                    Exit Sub
                Else

                End If
                
            End If
        Else
            'do not check
        End If        

        'are there subjects encoded
        If (Convert.ToDouble(Me.lblTotUnits.Text) <= 0.0) Then
            Me.ErrProve.SetError(Me.lblError, "You have not selected subjects for enrollment.")
            Me.lblError.Text = "No subjects listed to be enrolled. Please enter subjects."
            Me.lblError.Visible = True
            Exit Sub
        End If

        If Me.SaveStudentEnrollment(Me.NewEnrollment) = True Then
            'do we have to print COR?
            If Me.chkCOR.Checked = True Then
                Me.PrintCertificate()
            Else

            End If

            MessageBox.Show("Student subjects load saved.", "Save subject load.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.txtEDP.Clear()
        Else

        End If
    End Sub

    Private Sub txtStatus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStatus.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtSectionCode.Focus()
        End Select
    End Sub

    Private Sub txtStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatus.TextChanged
        Me.ErrProve.Clear()
        Me.lblError.Visible = False
        AssignFees()
    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged
        Me.ErrProve.Clear()
        Me.lblError.Visible = False
        AssignFees()
    End Sub

    Private Sub cmdBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBlock.Click
        Dim newfrm As New frmListOfBlockSubjectsForEnrollment

        Dim TheListReceived As New List(Of ClassSubjectsEnrolled)

        With newfrm
            .ShowDialog()
            If .HasSelectedSubjects = True Then
                'clear list
                Me.dvgSubjectsList.Rows.Clear()
                TheListReceived = .TheList
                If AddSubjectsToTheDataGridView(TheListReceived, Me.dvgSubjectsList) = True Then

                Else

                End If
            End If
        End With
    End Sub

    Private Sub dvgSubjectsList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgSubjectsList.CellContentClick

    End Sub

    Private Sub dvgSubjectsList_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dvgSubjectsList.RowsAdded
        Me.lblTotUnits.Text = FormatNumber(CalculateTotalUnits, 1)
        AssignFees()
    End Sub

    Private Sub dvgSubjectsList_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dvgSubjectsList.RowsRemoved
        Me.lblTotUnits.Text = FormatNumber(CalculateTotalUnits, 1)
        AssignFees()
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click

        If Me.dvgSubjectsList.Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim intYN As Integer = vbNo

        intYN = MessageBox.Show("Are you sure you want to remove " & Me.dvgSubjectsList.CurrentRow.Cells(2).Value.ToString & " from the list?" & vbCrLf & vbCrLf _
                & "Please select Yes to continue or No to cancel.", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If intYN = vbNo Then

        Else
            Me.dvgSubjectsList.Rows.Remove(Me.dvgSubjectsList.CurrentRow)
        End If


    End Sub

    Private Sub cmdClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearList.Click

        If Me.dvgSubjectsList.Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim intYN As Integer = vbNo

        intYN = MessageBox.Show("Are you sure you want to remove all subjects from the list?" & vbCrLf & vbCrLf _
                & "Please select Yes to continue or No to cancel.", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If intYN = vbNo Then

        Else
            Me.dvgSubjectsList.Rows.Clear()
        End If
    End Sub

    Private Sub cmdViewFees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewFees.Click
        Dim newfrm As New frmAddEditSemestralFees

        With newfrm
            .cmdSave.Visible = False
            .KryptonHeader1.Visible = False
            .dvgList.AllowUserToAddRows = False
            .dvgList.AllowUserToDeleteRows = False
            .TheHeight = Me.Height - 35
            .TheWidth = Me.Width - 45
            .ShowDialog()
        End With
    End Sub

    Private Sub txtIsEnrolled_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIsEnrolled.TextChanged
        If Me.txtIsEnrolled.Text = "0" Then
            'DisAbleEnableModifications(True)
        ElseIf Me.txtIsEnrolled.Text = "1" Then
            'DisAbleEnableModifications(False)
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim newfrm As New frmSearchStudent
        Dim strEDP As String = ""

        With newfrm

            .ShowDialog()
            strEDP = .EDPNumber
            Debug.Print("strEDP: " & vbCrLf & strEDP)
        End With
        Try
            If strEDP.Length > 0 Then
                ClearControls()
                Me.txtEDP.Text = strEDP
                If GetEnrollmentDetails(Me.txtEDP.Text) = True Then
                    Me.txtYear.Focus()
                    'If Convert.ToDecimal(Me.txtPayments.Text) <= 0.0 Then
                    '    Me.ErrProve.SetError(Me.lblError, "No payments for entrance have been received. Please advise student to pay for entrance fee first before enrolling.")
                    '    Me.ErrProve.SetError(Me.txtLess, "No payments for entrance have been received. Please advise student to pay for entrance fee first before enrolling.")
                    '    Me.lblError.Text = "No payments for entrance have been received from this student."
                    '    Me.lblError.Visible = True
                    '    'Me.txtEDP.Focus()
                    '    Exit Sub
                    'End If
                    If Me.txtCourse.Text.Length <= 0 Then
                        'student have no course yet, therefore allow adviser to enter course for the student.
                        If Me.txtName.Text.Length <= 0 Then

                        Else
                            Dim newfrm1 As New frmEditStudentCourse

                            With newfrm1
                                .IsAdding = False
                                .EDPNumber = Me.txtEDP.Text
                                .ShowDialog()
                                If .MustUpdate = True Then
                                    'reload
                                    If GetEnrollmentDetails(Me.txtEDP.Text) = True Then
                                        Me.txtYear.Focus()
                                    Else
                                        Me.txtEDP.Focus()
                                        Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                                    End If
                                Else
                                    Me.txtEDP.Focus()
                                    Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                                End If
                            End With
                        End If

                    End If
                Else
                    Me.txtEDP.Focus()

                End If
            End If
        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & " In cmdSearch_Click")
        End Try
    End Sub

    Private Sub cmdViewCourseOfferings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewCourseOfferings.Click
        Dim newfrm As New frmListOfCourseOfferingsAll

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub dvgSubjectsList_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dvgSubjectsList.UserDeletingRow
        If Me.dvgSubjectsList.Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim intYN As Integer = vbNo

        intYN = MessageBox.Show("Are you sure you want to remove " & Me.dvgSubjectsList.CurrentRow.Cells(2).Value.ToString & " from the list?" & vbCrLf & vbCrLf _
                & "Please select Yes to continue or No to cancel.", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        Try
            If intYN = vbNo Then
                e.Cancel = True
            Else
                Me.dvgSubjectsList.Rows.Remove(Me.dvgSubjectsList.CurrentRow)
            End If
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub txtSectionCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSectionCode.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                If Trim(Me.txtSectionCode.Text).Length <= 0 Then

                    Me.txtSectionCode.Focus()
                    Me.txtSectionCode.SelectAll()
                    Exit Sub
                End If
                SetSubject()
                'Me.txtSectionCode.Clear()
                Me.txtSectionCode.Focus()
                Me.txtSectionCode.SelectAll()
        End Select
        
    End Sub

    Private Sub txtSectionCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSectionCode.TextChanged
        Me.ErrProve.Clear()
        Me.lblError.Visible = False
    End Sub

    Private Sub cmdChangeCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeCourse.Click
        Dim newfrm As New frmEditStudentCourse

        With newfrm
            .IsAdding = False
            .EDPNumber = Me.txtEDP.Text
            .ShowDialog()

            If .MustUpdate = True Then
                'reload
                ClearControls()
                If GetEnrollmentDetails(Me.txtEDP.Text) = True Then
                    Me.txtYear.Focus()
                Else
                    Me.txtEDP.Focus()
                    Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                End If
            Else
                Me.txtEDP.Focus()
                Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
            End If

        End With
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If Trim(Me.txtName.Text).Length <= 0 Then
            Me.cmdChangeCourse.Enabled = False
        Else
            Me.cmdChangeCourse.Enabled = True
        End If
    End Sub

    Private Sub cmdViewRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewRecords.Click
        Dim newfm As New frmStudentGrades

        With newfm
            .txtEDP.Text = Me.txtEDP.Text
            .ShowDialog()
        End With
    End Sub
End Class