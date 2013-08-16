
Imports MySql.Data.MySqlClient

Public Class frmListOfBlockSubjectsForEnrollment

    Dim TheSubjectsTable As New DataTable

#Region "Database"

    Public Sub GetCourseOfferings(ByVal strTerm As String, ByVal strYear As String)
        Dim dtaTable As New DataSet

        dtaTable = GetDataAndReturnDataSetByTermYear(ConnectionString, "GetCourseOfferingsBySemesterAndSchoolYear", 4, CurrentTerm, CurrentSchoolYear)
        'Me.dvgList.DataSource = dtaTable.Tables(0)
        Me.dvgBlockCodes.DataSource = dtaTable.Tables(1)
        ArrangeDatagridViewBlockCodes(Me.dvgBlockCodes)

    End Sub

    Public Sub GetCourseOfferingsBlock(ByVal strTerm As String, ByVal strYear As String, ByVal strBLCode As String)
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYearByBlock(ConnectionString, "GetCourseOfferingsBlockSubjectsWithSumEnrolled", 4, CurrentTerm, CurrentSchoolYear, strBLCode)
        Me.dvgBlockCodesSubjects.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)
        ArrangeDatagridViewBlockSubjects(dvgBlockCodesSubjects)

    End Sub

#End Region

#Region "Helper"

    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False

                .Columns(3).HeaderText = "Subj. Number"
                .Columns(4).HeaderText = "Subj. Code"
                .Columns(5).HeaderText = "Descriptive Title"
                .Columns(6).HeaderText = "Time1"
                .Columns(7).HeaderText = "Day1"
                .Columns(8).HeaderText = "Room1"
                .Columns(9).HeaderText = "Time2"
                .Columns(10).HeaderText = "Day2"
                .Columns(11).HeaderText = "Room2"
                .Columns(12).HeaderText = "Units"
                .Columns(13).HeaderText = "Lab Code"
                .Columns(14).HeaderText = "Instructor"
                .Columns(15).HeaderText = "Num. of Seats"

                .Columns(3).Width = "85"
                .Columns(4).Width = "100"
                .Columns(7).Width = "65"
                .Columns(8).Width = "65"
                .Columns(10).Width = "65"
                .Columns(11).Width = "65"
                .Columns(12).Width = "65"
                .Columns(13).Width = "65"
                .Columns(5).Width = "400"
                .Columns(14).Width = "200"
                .Columns(6).Width = "130"
                .Columns(9).Width = "130"
                '.Columns(7).Width = "85"
                '.Columns(10).Width = "85"

                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ArrangeDatagridViewBlockSubjects(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False

                .Columns(3).HeaderText = "Section Code"
                .Columns(4).HeaderText = "Subj. Code"
                .Columns(5).HeaderText = "Descriptive Title"
                .Columns(6).HeaderText = "Time1"
                .Columns(7).HeaderText = "Day1"
                .Columns(8).HeaderText = "Room1"
                .Columns(9).HeaderText = "Time2"
                .Columns(10).HeaderText = "Day2"
                .Columns(11).HeaderText = "Room2"
                .Columns(12).HeaderText = "Units"
                .Columns(13).HeaderText = "Lab Code"
                .Columns(14).HeaderText = "Instructor"
                .Columns(15).HeaderText = "Num. of Seats"
                .Columns(16).HeaderText = "Num. of Enrolled"

                .Columns(3).Width = "85"
                .Columns(4).Width = "100"
                .Columns(7).Width = "65"
                .Columns(8).Width = "65"
                .Columns(10).Width = "65"
                .Columns(11).Width = "65"
                .Columns(12).Width = "65"
                .Columns(13).Width = "65"
                .Columns(5).Width = "400"
                .Columns(14).Width = "200"
                .Columns(6).Width = "130"
                .Columns(9).Width = "130"
                '.Columns(7).Width = "85"
                '.Columns(10).Width = "85"

                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ArrangeDatagridViewBlockCodes(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Block Codes"

                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Procedure to apply format
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ApplyFormat()

        For Each row As DataGridViewRow In Me.dvgBlockCodesSubjects.Rows
            If IsDBNull(row.Cells(16).Value) = True Then

            Else
                If row.Cells(15).Value <= row.Cells(16).Value Then
                    Dim i As Integer = 0

                    For i = 0 To 14
                        row.Cells(i).Style.BackColor = Color.LightGray
                    Next

                End If
            End If

        Next
        'set column color
        Me.dvgBlockCodesSubjects.Columns(15).DefaultCellStyle.BackColor = Color.Cornsilk
        Me.dvgBlockCodesSubjects.Columns(16).DefaultCellStyle.BackColor = Color.LightYellow
    End Sub

    Private Function AddSubjectsSelected(ByVal TheList As DataGridView) As List(Of ClassSubjectsEnrolled)

        Dim ListOfSubject As New List(Of ClassSubjectsEnrolled)

        Try
            For Each row As DataGridViewRow In TheList.Rows
                Dim SingleValue As New ClassSubjectsEnrolled

                If IsDBNull(row.Cells(16).Value) = True Then
                    'add if numenrolled column is a null, no enrolled yet

                    SingleValue.TheESSID = 0
                    SingleValue.CourseOfferingNumber = row.Cells(3).Value.ToString
                    SingleValue.SubjectCode = row.Cells(4).Value.ToString
                    SingleValue.DescTitle = row.Cells(5).Value.ToString
                    SingleValue.Time1 = row.Cells(6).Value.ToString
                    SingleValue.Time2 = row.Cells(9).Value.ToString
                    SingleValue.Day1 = row.Cells(7).Value.ToString
                    SingleValue.Day2 = row.Cells(10).Value.ToString
                    SingleValue.Room1 = row.Cells(8).Value.ToString
                    SingleValue.Room2 = row.Cells(11).Value.ToString
                    SingleValue.Units = row.Cells(12).Value
                    SingleValue.LabCode = row.Cells(13).Value
                    SingleValue.SubjectID = row.Cells(1).Value
                    SingleValue.CourseOfferingID = row.Cells(0).Value

                    ListOfSubject.Add(SingleValue)
                ElseIf Convert.ToInt32(row.Cells(15).Value) >= Convert.ToInt32(row.Cells(16).Value) Then
                    'add if numenrolled column is less than number of seats

                    SingleValue.TheESSID = 0
                    SingleValue.CourseOfferingNumber = row.Cells(3).Value.ToString
                    SingleValue.SubjectCode = row.Cells(4).Value.ToString
                    SingleValue.DescTitle = row.Cells(5).Value.ToString
                    SingleValue.Time1 = row.Cells(6).Value.ToString
                    SingleValue.Time2 = row.Cells(9).Value.ToString
                    SingleValue.Day1 = row.Cells(7).Value.ToString
                    SingleValue.Day2 = row.Cells(10).Value.ToString
                    SingleValue.Room1 = row.Cells(8).Value.ToString
                    SingleValue.Room2 = row.Cells(11).Value.ToString
                    SingleValue.Units = row.Cells(12).Value
                    SingleValue.LabCode = row.Cells(13).Value
                    SingleValue.SubjectID = row.Cells(1).Value
                    SingleValue.CourseOfferingID = row.Cells(0).Value

                    ListOfSubject.Add(SingleValue)
                ElseIf Convert.ToInt32(row.Cells(15).Value) <= Convert.ToInt32(row.Cells(16).Value) Then
                    'if subject's laboratory code is a computer lab code, then do not add,
                    'else ask for permission if we have to add another student.

                    MessageBox.Show("The course offering " & row.Cells(0).Value.ToString & vbCrLf _
                        & "Subject Num: " & row.Cells(0).Value.ToString & vbCrLf _
                        & "Descriptive Title: " & row.Cells(0).Value.ToString & vbCrLf _
                        & "has reached the maximum allowed number of students. " & vbCrLf _
                        & "Please add the subject in the advising window if you want to add student to the class list.", _
                        "Subject has reached maximum number of students.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    SingleValue.TheESSID = 0
                    SingleValue.CourseOfferingNumber = row.Cells(3).Value.ToString
                    SingleValue.SubjectCode = row.Cells(4).Value.ToString
                    SingleValue.DescTitle = row.Cells(5).Value.ToString
                    SingleValue.Time1 = row.Cells(6).Value.ToString
                    SingleValue.Time2 = row.Cells(9).Value.ToString
                    SingleValue.Day1 = row.Cells(7).Value.ToString
                    SingleValue.Day2 = row.Cells(10).Value.ToString
                    SingleValue.Room1 = row.Cells(8).Value.ToString
                    SingleValue.Room2 = row.Cells(11).Value.ToString
                    SingleValue.Units = row.Cells(12).Value
                    SingleValue.LabCode = row.Cells(13).Value
                    SingleValue.SubjectID = row.Cells(1).Value
                    SingleValue.CourseOfferingID = row.Cells(0).Value

                    ListOfSubject.Add(SingleValue)
                End If

            Next
        Catch ex As Exception
            Dim newfrmerror As New frmErrorMessageViewer
            With newfrmerror
                .ErrorMessage = "Error adding subjects for enrollment."
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "cmdBlock_Click" & vbCrLf & vbCrLf & ex.Message _
                    & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding subjects because an error occured."
                .ShowDialog()
            End With
            'ListOfSubject = Nothing
        End Try
        
        Return ListOfSubject

    End Function

#End Region

#Region "Properties"

    Dim lstTheListOfSubejctsToBePassed As List(Of ClassSubjectsEnrolled)
    Property TheList() As List(Of ClassSubjectsEnrolled)
        Get
            Return lstTheListOfSubejctsToBePassed
        End Get
        Set(ByVal value As List(Of ClassSubjectsEnrolled))
            lstTheListOfSubejctsToBePassed = value
        End Set
    End Property

    Dim boolHasSelected As Boolean
    Property HasSelectedSubjects() As Boolean
        Get
            Return boolHasSelected
        End Get
        Set(ByVal value As Boolean)
            boolHasSelected = value
        End Set
    End Property

#End Region

    Private Sub frmListOfBlockSubjectsForEnrollment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Select Block Sections")
        Me.cmdRefresh.PerformClick()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetCourseOfferings(CurrentTerm, CurrentSchoolYear)
    End Sub

    Private Sub dvgBlockCodes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgBlockCodes.CellContentClick

    End Sub

    Private Sub dvgBlockCodes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgBlockCodes.SelectionChanged
        GetCourseOfferingsBlock(CurrentTerm, CurrentSchoolYear, Me.dvgBlockCodes.CurrentRow.Cells(1).Value.ToString)
        ApplyFormat()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.HasSelectedSubjects = False
        Me.Close()
    End Sub

    Private Sub dvgBlockCodes_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgBlockCodes.Sorted

    End Sub

    Private Sub dvgBlockCodesSubjects_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgBlockCodesSubjects.Sorted
        ApplyFormat()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.TheList = AddSubjectsSelected(Me.dvgBlockCodesSubjects)
        Me.HasSelectedSubjects = True
        Me.Close()
    End Sub

    Private Sub dvgBlockCodesSubjects_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgBlockCodesSubjects.CellContentClick

    End Sub
End Class