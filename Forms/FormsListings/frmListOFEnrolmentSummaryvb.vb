
Imports MySql.Data.MySqlClient

Public Class frmListOFEnrolmentSummaryvb

#Region "Database"

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataSet

        dtaTable = GetDataAndReturnDataSetByTermYear(ConnectionString, "GetSummaryOfEnrolment", 4, CurrentTerm, CurrentSchoolYear)
        Me.dvgList.DataSource = dtaTable.Tables(0)
        Me.dvgDept.DataSource = dtaTable.Tables(1)
        Me.dvgEnrolled.DataSource = dtaTable.Tables(2)
        Me.dvgGender.DataSource = dtaTable.Tables(3)
        Me.dvgCourseYearLevel.DataSource = dtaTable.Tables(4)
        Me.dvgDepartmentYearLevel.DataSource = dtaTable.Tables(5)

        ArrangeDatagridView(Me.dvgList)

    End Sub

#End Region

#Region "Helper"

    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(0).Visible = False

                .Columns(0).HeaderText = "Course"
                .Columns(1).HeaderText = "Total"
               
                .Columns(0).Width = "150"
                
                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Catch ex As Exception

        End Try

        Try
            With Me.dvgDept
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(0).Visible = False

                .Columns(0).HeaderText = "Department"
                .Columns(1).HeaderText = "Total"

                .Columns(0).Width = "150"

                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Catch ex As Exception

        End Try

        Try
            With Me.dvgEnrolled
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(0).Visible = False

                .Columns(0).HeaderText = "Date Enrolled"
                .Columns(1).HeaderText = "Total"

                .Columns(0).Width = "150"

                .Columns(0).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Catch ex As Exception

        End Try

        Try
            With Me.dvgGender
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(0).Visible = False

                .Columns(0).HeaderText = "Course"
                .Columns(1).HeaderText = "Male"
                .Columns(2).HeaderText = "Female"
                .Columns(3).HeaderText = "Total"

                .Columns(0).Width = "150"

                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Catch ex As Exception

        End Try

        Try
            With Me.dvgCourseYearLevel
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(0).Visible = False

                .Columns(0).HeaderText = "Course"
                .Columns(1).HeaderText = "1st Year"
                .Columns(2).HeaderText = "2nd Year"
                .Columns(3).HeaderText = "3rd Year"
                .Columns(4).HeaderText = "4th Year"
                .Columns(5).HeaderText = "Total"

                .Columns(0).Width = "150"

                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
        Catch ex As Exception

        End Try

        Try
            With Me.dvgDepartmentYearLevel
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(0).Visible = False

                .Columns(0).HeaderText = "Dept"
                .Columns(1).HeaderText = "1st Year"
                .Columns(2).HeaderText = "2nd Year"
                .Columns(3).HeaderText = "3rd Year"
                .Columns(4).HeaderText = "4th Year"
                .Columns(5).HeaderText = "Total"

                .Columns(0).Width = "150"

                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Enrolment Summary " & CurrentTerm & ", " & CurrentSchoolYear)
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
        GetAllDepartments()
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

End Class