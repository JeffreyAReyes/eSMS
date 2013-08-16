
Imports MySql.Data.MySqlClient

Public Class frmListOfCourses

#Region "Database"

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetCoursesAll", 4)
        Me.dvgList.DataSource = dtaTable
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

                .Columns(2).HeaderText = "Department"
                .Columns(3).HeaderText = "Course Code"
                .Columns(4).HeaderText = "Course"
                .Columns(5).HeaderText = "GR Num"
                .Columns(6).HeaderText = "GR Year"

                .Columns(2).Width = "300"
                .Columns(4).Width = "125"
                .Columns(5).Width = "125"
                .Columns(6).Width = "125"

                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Programs of Study")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()
        If CurrentUserModule.ToString.ToUpper <> "REGISTRAR" Then
            Me.cmdAddNew.Visible = False
            Me.cmdModify.Visible = False
            Me.cmdDelete.Visible = False
        Else
            Me.cmdAddNew.Visible = True
            Me.cmdModify.Visible = True
            Me.cmdDelete.Visible = True
        End If
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditCourse

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Program of Study"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .CurrentSearchString
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetAllDepartments()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditCourse

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Program of Study"
            .CurrentSujectID = Me.dvgList.CurrentRow.Cells(0).Value
            .CurrentDeptID = Me.dvgList.CurrentRow.Cells(1).Value
            .txtDescriptiveTitle.Text = Me.dvgList.CurrentRow.Cells(4).Value
            .txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(3).Value
            .txtGRNum.Text = Me.dvgList.CurrentRow.Cells(5).Value.ToString
            .txtGRYear.Text = Me.dvgList.CurrentRow.Cells(6).Value.ToString
            .cboDegree.Text = Me.dvgList.CurrentRow.Cells(7).Value.ToString
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .CurrentSearchString
            End If
        End With
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer = 0

        With Me
            For i = 0 To .dvgList.Rows.Count - 1
                If .dvgList.Rows(i).Cells(3).Value.ToString.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) Then
                    .dvgList.Rows(i).Selected = True
                    .dvgList.CurrentCell = .dvgList(3, i)
                    .dvgList.FirstDisplayedScrollingRowIndex = .dvgList.CurrentCell.RowIndex
                    Exit Sub
                End If
            Next
        End With
    End Sub
End Class