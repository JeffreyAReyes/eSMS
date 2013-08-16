
Imports MySql.Data.MySqlClient

Public Class frmListOfTeachersLoad

#Region "Database"

    Public Sub GetTeachersLoadByTeacher(ByVal intID As Integer)
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYearByTeacherID(ConnectionString, "GetTeachersLoadByTeacher", 4, CurrentTerm, CurrentSchoolYear, intID)
        Me.dvgList.DataSource = dtaTable
        ArrangeDatagridView(Me.dvgList)

    End Sub

    Private Sub GetEmployees()
        Dim dtatable As New DataTable

        dtatable = GetDataAndReturnDataTable(ConnectionString, "GetEmployeesAllForCombo", 4)

        With Me.cboInstructor
            .DataSource = dtatable
            .DisplayMember = "EmployeeName"
            .ValueMember = "EmpID"

        End With
    End Sub
#End Region

#Region "Helper"

    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False

                .Columns(2).HeaderText = "Section Code"
                .Columns(3).HeaderText = "Subj. Code"
                .Columns(4).HeaderText = "Descriptive Title"
                .Columns(5).HeaderText = "Time1"
                .Columns(6).HeaderText = "Day1"
                .Columns(7).HeaderText = "Room1"
                .Columns(8).HeaderText = "Time2"
                .Columns(9).HeaderText = "Day2"
                .Columns(10).HeaderText = "Room2"
                .Columns(11).HeaderText = "Units"
                .Columns(12).HeaderText = "Num. of Seats"
                .Columns(13).HeaderText = "Num. of Enrolled"

                .Columns(2).Width = "85"
                .Columns(4).Width = "95"
                .Columns(5).Width = "130"
                .Columns(6).Width = "65"
                .Columns(7).Width = "65"
                .Columns(8).Width = "130"
                .Columns(9).Width = "65"
                .Columns(10).Width = "65"
                .Columns(11).Width = "65"
                .Columns(12).Width = "100"
                .Columns(13).Width = "100"
                
                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                'add a column button 
                'Dim column1 As New DataGridViewButtonColumn

                'column1.Name = "Buttons"
                'column1.HeaderText = "View Class List"
                'column1.Text = "Class List"

                '.Columns.Add(column1)

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub GenerateReport()

        Dim ListOfFacultyLoad As New List(Of ClassFacultyLoad)

        For Each row As DataGridViewRow In Me.dvgList.Rows
            If row.IsNewRow = True Then

            Else
                Dim newitem As New ClassFacultyLoad

                With newitem                    

                    .SectionCode = row.Cells(2).Value.ToString
                    .SubjectCode = row.Cells(3).Value.ToString
                    .DescriptiveTitle = row.Cells(4).Value.ToString
                    .Time1 = row.Cells(5).Value.ToString
                    .Day1 = row.Cells(6).Value.ToString
                    .Room1 = row.Cells(7).Value.ToString
                    .Time2 = row.Cells(8).Value.ToString
                    .Day2 = row.Cells(9).Value.ToString
                    .Room2 = row.Cells(10).Value.ToString
                    .Units = row.Cells(11).Value
                    .NumStudents = row.Cells(13).Value
                    'add item to collection

                    ListOfFacultyLoad.Add(newitem)

                End With
            End If
        Next

        Dim newfrm As New frmReportFacultyLoad

        With newfrm

            .FacultyLoadsList = ListOfFacultyLoad
            .FacultyName = Me.cboInstructor.Text
            
            .ShowDialog()

        End With
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Faculty Loads")
        'Me.Text = "List of Departments"
        'Me.cmdRefresh.PerformClick()
        GetEmployees()
        Me.cboInstructor.SelectedValue = -1
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
        Me.dvgList.DataSource = Nothing
        If Me.cboInstructor.SelectedValue <= 0 Then
            Me.cboInstructor.Focus()
        Else
            GetTeachersLoadByTeacher(Me.cboInstructor.SelectedValue)
        End If

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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.dvgList.DataSource = Nothing
        If Me.cboInstructor.SelectedValue <= 0 Then
            Me.cboInstructor.Focus()
        Else
            GetTeachersLoadByTeacher(Me.cboInstructor.SelectedValue)
        End If
    End Sub

    Private Sub cboInstructor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInstructor.SelectedIndexChanged
        Me.dvgList.DataSource = Nothing
        Try
            GetTeachersLoadByTeacher(Me.cboInstructor.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        GenerateReport()
    End Sub

    Private Sub cmdClassList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClassList.Click
        Dim newfrm As New frmClassListBySectionCode
        Try
            With newfrm
                .txtSecCode.Text = Me.dvgList.CurrentRow.Cells(2).Value
                .txtSubject.Text = Me.dvgList.CurrentRow.Cells(3).Value.ToString & " - " & _
                     Me.dvgList.CurrentRow.Cells(4).Value.ToString
                .SectionCode = Me.dvgList.CurrentRow.Cells(2).Value
                .SubjectCode = Me.dvgList.CurrentRow.Cells(3).Value.ToString
                .DescTitle = Me.dvgList.CurrentRow.Cells(4).Value.ToString
                .Time1 = Me.dvgList.CurrentRow.Cells(5).Value.ToString & " / " & _
                     Me.dvgList.CurrentRow.Cells(8).Value.ToString
                .Day1 = Me.dvgList.CurrentRow.Cells(6).Value.ToString & " / " & _
                     Me.dvgList.CurrentRow.Cells(9).Value.ToString
                .Room1 = Me.dvgList.CurrentRow.Cells(7).Value.ToString & " / " & _
                     Me.dvgList.CurrentRow.Cells(10).Value.ToString
                .Units = Me.dvgList.CurrentRow.Cells(11).Value
                .Instructor = Me.cboInstructor.SelectedValue
                .txtInstructor.Text = Me.cboInstructor.Text
                .ShowDialog()

            End With
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dvgList_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgList.CellPainting
        AddNumberingToTheDataGridView(Me.dvgList, e, Me.dvgList.Font)
    End Sub
End Class