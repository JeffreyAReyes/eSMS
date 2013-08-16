
Imports MySql.Data.MySqlClient

Public Class frmListOfSystemLogins

#Region "Database"

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetSystemUsersAll", 4)
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
                .Columns(3).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False

                .Columns(1).HeaderText = "Login Name"
                .Columns(2).HeaderText = "Full Name"
                .Columns(4).HeaderText = "Privilege"
                .Columns(5).HeaderText = "Date Entered"
                .Columns(6).HeaderText = "Entered By"
                .Columns(7).HeaderText = "Date Modified"
                .Columns(8).HeaderText = "Modified By"
                .Columns(9).HeaderText = "Module"
                .Columns(10).HeaderText = "Status"
                .Columns(13).HeaderText = "Department"

                .Columns(1).Width = "125"
                .Columns(2).Width = "200"
                .Columns(4).Width = "125"
                .Columns(5).Width = "100"
                .Columns(13).Width = "150"

                .Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(7).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(1).Frozen = True
                '.Columns(2).Frozen = True
            End With
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of System Logins.")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditSystemUsers

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New System Login"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtFullname.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetAllDepartments()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditSystemUsers

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify System Login"
            .CurrentSujectID = Me.dvgList.CurrentRow.Cells(0).Value
            .CurrentUserID = Me.dvgList.CurrentRow.Cells(0).Value
            .txtFullname.Text = Me.dvgList.CurrentRow.Cells(2).Value
            .txtLoginName.Text = Me.dvgList.CurrentRow.Cells(1).Value
            .cboModules.Text = Me.dvgList.CurrentRow.Cells(9).Value
            .CurrentDeptID = Me.dvgList.CurrentRow.Cells(12).Value
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtFullname.Text
            End If
        End With
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer = 0

        With Me
            For i = 0 To .dvgList.Rows.Count - 1
                If .dvgList.Rows(i).Cells(2).Value.ToString.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) Then
                    .dvgList.Rows(i).Selected = True
                    .dvgList.CurrentCell = .dvgList(2, i)
                    .dvgList.FirstDisplayedScrollingRowIndex = .dvgList.CurrentCell.RowIndex
                    Exit Sub
                End If
            Next
        End With
    End Sub
End Class