
Imports MySql.Data.MySqlClient

Public Class frmStudentSchedules

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

    Public Sub GetEnrolledStudentsSubjectsByTermYear(ByVal strEDP As String)
        Dim dtaTable As New DataSet

        dtaTable = GetDataAndReturnDataSetByTermYearByEDP(ConnectionString, "GetStudentSchedule", 4, CurrentTerm, CurrentSchoolYear, strEDP)
        Me.dvgList.DataSource = dtaTable.Tables(0)
        ArrangeDatagridView(Me.dvgList)

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

                .Columns(3).Width = "85"
                .Columns(6).Width = "125"
                .Columns(9).Width = "125"
                .Columns(7).Width = "75"
                .Columns(8).Width = "75"
                .Columns(10).Width = "75"
                .Columns(11).Width = "75"
                .Columns(5).Width = "300"
                .Columns(14).Width = "200"
                .Columns(12).Width = "75"

                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Function GetStudentEDP() As Boolean

        Try
            For Each row As DataRow In dtaTableStudents.Rows
                If row("ESID") = Me.cboStudents.SelectedValue Then
                    GetEnrolledStudentsSubjectsByTermYear(row("EDPNumber").ToString)
                    Return True
                End If
            Next
        Catch ex As Exception

        End Try
       
        Return False
    End Function

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Departments")
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
End Class