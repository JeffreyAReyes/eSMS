
Imports MySql.Data.MySqlClient

Public Class frmListOfStudents

#Region "Database"

    Public Sub GetAllStudents()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetAllStudents", 4)
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
                .Columns(5).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False

                .Columns(1).HeaderText = "EDP Number"
                .Columns(2).HeaderText = "Name"
                .Columns(6).HeaderText = "Present Address"
                .Columns(7).HeaderText = "Home Address"
                .Columns(8).HeaderText = "Gender"
                .Columns(9).HeaderText = "Civil Status"
                .Columns(10).HeaderText = "Date of Birth"
                .Columns(11).HeaderText = "Age"
                .Columns(12).HeaderText = "Mobile Num"
                .Columns(13).HeaderText = "Tel. Num"
                .Columns(14).HeaderText = "Campus"
                .Columns(15).HeaderText = "Term Admitted"

                .Columns(1).Width = "100"
                .Columns(2).Width = "250"
                .Columns(6).Width = "250"
                .Columns(7).Width = "250"
                .Columns(10).Width = "110"
                .Columns(11).Width = "65"
                .Columns(15).Width = "255"

                .Columns(10).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub SearchDatagridview(ByVal TheListControl As DataGridView, ByVal intColumn As Integer, ByVal StringToSearch As String)

        Dim i As Integer = 0

        For i = 0 To TheListControl.Rows.Count - 1
            If TheListControl.Rows(i).Cells(intColumn).Value.ToString.StartsWith(StringToSearch, StringComparison.InvariantCultureIgnoreCase) Then
                TheListControl.Rows(i).Selected = True
                TheListControl.CurrentCell = TheListControl(intColumn, i)
                TheListControl.FirstDisplayedScrollingRowIndex = TheListControl.CurrentCell.RowIndex
                Exit Sub
            End If
        Next
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Students")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditDepartment

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Student"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetAllStudents()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditDepartment

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Student"
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

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        SearchDatagridview(Me.dvgList, 2, Me.txtSearch.Text)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

    End Sub
End Class