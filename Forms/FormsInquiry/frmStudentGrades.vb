
Imports MySql.Data.MySqlClient

Public Class frmStudentGrades

#Region "Database"

    Dim dtaTableStudents As New DataTable

    Public Sub GetEnrolledStudentsByTermYear()
        
        dtaTableStudents = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetEnrolledStudentsByTermYear", 4, CurrentTerm, CurrentSchoolYear)
        'Me.dvgList.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)
        Me.cboStudents.DataSource = dtaTableStudents
        Me.cboStudents.ValueMember = "ESID"
        Me.cboStudents.DisplayMember = "StudentName"
        Me.cboStudents.SelectedIndex = -1
    End Sub

    Public Sub GetEnrolledStudentsSubjectsByTermYear(ByVal strEDP As String, ByVal strTerm As String, ByVal strYear As String)
        Dim dtaTable As New DataSet

        dtaTable = GetDataAndReturnDataSetByTermYearByEDP(ConnectionString, "GetStudentScheduleWithGrades", 4, strTerm, strYear, strEDP)
        Me.dvgList.DataSource = dtaTable.Tables(0)
        ArrangeDatagridView(Me.dvgList)

        Try
            For Each row As DataRow In dtaTable.Tables(1).Rows
                Me.txtName.Text = row("Student_Name").ToString
                Me.txtCourse.Text = row("CourseDescription").ToString
            Next

            For Each row As DataRow In dtaTable.Tables(2).Rows
                'Me.txtName.Text = row("Student_Name").ToString
                Me.txtYear.Text = row("EnrolYear").ToString
            Next

        Catch ex As Exception

        End Try
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
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False

                .Columns(13).Visible = False

                .Columns(3).HeaderText = "Section Code"
                .Columns(4).HeaderText = "Subject"
                .Columns(5).HeaderText = "Descriptive Title"
                .Columns(6).HeaderText = "Time"
                .Columns(7).HeaderText = "Day"
                .Columns(8).HeaderText = "Room"
                .Columns(9).HeaderText = "Time"
                .Columns(10).HeaderText = "Day"
                .Columns(11).HeaderText = "Room"
                .Columns(12).HeaderText = "Units"
                .Columns(14).HeaderText = "Instructor"
                .Columns(15).HeaderText = "Prelim"
                .Columns(16).HeaderText = "Midterm"
                .Columns(17).HeaderText = "Final"
                .Columns(18).HeaderText = "Point Grade"
                .Columns(19).HeaderText = "Remarks"

                .Columns(4).Width = "125"
                .Columns(6).Width = "125"
                .Columns(9).Width = "125"
                .Columns(7).Width = "75"
                .Columns(8).Width = "75"
                .Columns(10).Width = "75"
                .Columns(11).Width = "75"
                .Columns(5).Width = "300"
                .Columns(14).Width = "200"
                .Columns(12).Width = "75"

                .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Function GetStudentEDP() As Boolean

        Try
            For Each row As DataRow In dtaTableStudents.Rows
                If row("ESID") = Me.cboStudents.SelectedValue Then
                    GetEnrolledStudentsSubjectsByTermYear(row("EDPNumber").ToString, Me.cboSubjects.Text, Me.cboSY.Text)
                    Return True
                End If
            Next
        Catch ex As Exception

        End Try
       
        Return False
    End Function

    Private Sub GenerateReport()

        Dim ListOfStudentGrades As New List(Of ClassStudentGradesFOrComputation)

        For Each row As DataGridViewRow In Me.dvgList.Rows
            If row.IsNewRow = True Then

            Else
                Dim newitem As New ClassStudentGradesFOrComputation

                With newitem

                    .SubjectNumber = row.Cells(4).Value.ToString
                    .DescTitle = row.Cells(5).Value.ToString
                    .Units = row.Cells(12).Value.ToString
                    .Grades = row.Cells(13).Value.ToString
                    .PointGrades = row.Cells(18).Value.ToString
                    .Remarks = row.Cells(19).Value.ToString
                    'add item to collection

                    ListOfStudentGrades.Add(newitem)

                End With
            End If
        Next

        Dim newfrm As New frmReportStudentGrades

        With newfrm

            .FacultyLoadsList = ListOfStudentGrades
            '.FacultyName = Me.cboInstructor.Text
            .StudentName = Me.txtName.Text
            .Course = Me.txtCourse.Text & " - " & Me.txtYear.Text
            .EYear = Me.txtCourse.Text
            .SchoolYear = Me.cboSY.Text
            .Semester = Me.cboSubjects.Text
            .GPA = CDec(Me.txtGPA.Text)

            .ShowDialog()

        End With
    End Sub

    Private Function CalculateGPA(ByVal theGrid As DataGridView) As Decimal

        Dim decGPA As Boolean
        Dim decTotalUnits As Decimal = 0.0
        Dim decUnits As Decimal = 0.0
        Dim decGrades As Decimal = 0.0
        Dim decTotalGrades As Decimal = 0.0

        Try
            For Each row As DataGridViewRow In theGrid.Rows

                decUnits = row.Cells(12).Value

                If row.Cells(18).Value.ToString.ToUpper.Contains("DROPPED") Then
                    decGrades = 0
                Else
                    decGrades = row.Cells(18).Value
                End If
                decTotalUnits = decTotalUnits + decUnits
                decTotalGrades = decTotalGrades + (decUnits * decGrades)

            Next
            decGPA = decTotalGrades / decTotalUnits
        Catch ex As Exception

        End Try
        


        Return decGPA

    End Function
#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Student Grades")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditDepartment

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Department"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetEnrolledStudentsByTermYear()
        Me.cboStudents.SelectedIndex = -1
        Me.dvgList.DataSource = Nothing
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditDepartment

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Department"
            .CurrentSujectID = Me.dvgList.CurrentRow.Cells(0).Value
            .txtDescriptiveTitle.Text = Me.dvgList.CurrentRow.Cells(2).Value
            .txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(1).Value
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cboStudents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStudents.SelectedIndexChanged
        Me.dvgList.DataSource = Nothing
        GetStudentEDP()
    End Sub

    Private Sub cboStudents_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStudents.TextChanged
        Me.dvgList.DataSource = Nothing
    End Sub

    Private Sub txtEDP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDP.GotFocus
        If Me.txtEDP.Text.Length = 5 Then
            Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
        Else

        End If

    End Sub

    Private Sub txtEDP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEDP.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.cmdLoad.PerformClick()
        End Select

    End Sub

    Private Sub txtEDP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEDP.TextChanged
        Me.ErrProve.Clear()
        Me.txtName.Clear()
        Me.txtCourse.Clear()
        Me.dvgList.DataSource = Nothing
    End Sub

    Private Sub cboSubjects_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubjects.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.cmdLoad.PerformClick()
        End Select
    End Sub

    Private Sub cboSubjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubjects.SelectedIndexChanged
        Me.dvgList.DataSource = Nothing
        Me.ErrProve.Clear()
        Me.txtName.Clear()
        Me.txtCourse.Clear()
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If Me.cboSubjects.SelectedIndex < 0 Then
            Me.ErrProve.SetError(Me.cboSubjects, "Please select term from the list.")
            Me.cboSubjects.Focus()
            Exit Sub
        End If
        If Me.cboSY.SelectedIndex < 0 Then
            Me.ErrProve.SetError(Me.cboSY, "Please select School year from the list.")
            Me.cboSY.Focus()
            Exit Sub
        End If

        GetEnrolledStudentsSubjectsByTermYear(Me.txtEDP.Text, Me.cboSubjects.Text, Me.cboSY.Text)
        Me.txtGPA.Text = CalculateGPA(Me.dvgList)

        Me.dvgList.Focus()
    End Sub

    Private Sub cboSY_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSY.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.cmdLoad.PerformClick()
        End Select
    End Sub

    Private Sub cboSY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSY.SelectedIndexChanged
        Me.ErrProve.Clear()
        Me.dvgList.DataSource = Nothing
        Me.txtName.Clear()
        Me.txtCourse.Clear()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        GenerateReport()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim newfrm As New frmSearchStudent

        With newfrm
            .ShowDialog()
            If .HasSelected = True Then
                Me.txtEDP.Text = .EDPNumber
                Me.txtEDP.Focus()
                Me.cmdLoad.PerformClick()
            End If
        End With
    End Sub
End Class