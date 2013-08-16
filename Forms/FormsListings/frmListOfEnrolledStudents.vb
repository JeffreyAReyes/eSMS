
Imports MySql.Data.MySqlClient

Public Class frmListOfEnrolledStudents

#Region "Database"

    Public Sub GetEnrolledStudentsByTermYear()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetEnrolledStudentsByTermYear", 4, CurrentTerm, CurrentSchoolYear)
        Me.BindingSource1.DataSource = dtaTable
        Me.BindingNavigator1.BindingSource = Me.BindingSource1

        Me.dvgList.DataSource = Me.BindingSource1
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

                .Columns(2).HeaderText = "EDP Number"
                .Columns(3).HeaderText = "Name"
                .Columns(4).HeaderText = "Course"
                .Columns(5).HeaderText = "Year"
                .Columns(6).HeaderText = "Status"
                .Columns(7).HeaderText = "Department"
                .Columns(8).HeaderText = "Date Enrolled"

                .Columns(6).Width = "150"
                .Columns(3).Width = "125"
                .Columns(4).Width = "125"
                .Columns(5).Width = "125"
                .Columns(6).Width = "125"
                .Columns(8).Width = "200"

                .Columns(8).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Enrolled Students - " & CurrentTerm & " " & CurrentSchoolYear)
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

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        SearchDatagridViewGlobal(Me.dvgList, 3, Me.txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        SearchDatagridViewGlobal(Me.dvgList, 3, Me.txtSearch.Text)
    End Sub
End Class