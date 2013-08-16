
Imports MySql.Data.MySqlClient

Public Class frmListOfDiscounts

#Region "Database"

    Public Sub GetDiscounts()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetDiscounts", 4, CurrentTerm, CurrentSchoolYear)
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

                .Columns(1).HeaderText = "Date"
                .Columns(2).HeaderText = "Name"
                .Columns(3).HeaderText = "Ref. Num."
                .Columns(4).HeaderText = "Amount"
                .Columns(5).HeaderText = "Remarks"
                .Columns(6).HeaderText = "Encoded By"

                .Columns(1).Width = "125"
                .Columns(2).Width = "400"
                .Columns(3).Width = "125"
                .Columns(4).Width = "125"
                .Columns(5).Width = "125"
                .Columns(6).Width = "125"

                .Columns(1).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(4).DefaultCellStyle.Format = "N2"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Discounts - " & CurrentTerm & ", " & CurrentSchoolYear)
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
        GetDiscounts()
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

    Private Sub txtSearch_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.Enter
        SearchDatagridViewGlobal(Me.dvgList, 2, Me.txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        SearchDatagridViewGlobal(Me.dvgList, 2, Me.txtSearch.Text)
    End Sub

    Private Sub dvgList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgList.CellContentClick

    End Sub

    Private Sub dvgList_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgList.CellPainting
        AddNumberingToTheDataGridView(Me.dvgList, e, Me.Font)
    End Sub
End Class