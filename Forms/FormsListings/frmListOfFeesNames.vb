
Imports MySql.Data.MySqlClient

Public Class frmListOfFeesNames

#Region "Database"

    Public Sub GetFeesNamesAll()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetFeesNamesAll", 4)
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

                .Columns(1).HeaderText = "Fee Category"
                .Columns(2).HeaderText = "Fee Name"
                
                .Columns(1).Width = "300"
                
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Fees Titles")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditFeesName

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Fee Name"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtFeeName.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetFeesNamesAll()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditFeesName

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Fee Name"
            .CurrentPrimaryKeyID = Me.dvgList.CurrentRow.Cells(0).Value
            .txtFeeName.Text = Me.dvgList.CurrentRow.Cells(2).Value
            .cboFeeCategory.Text = Me.dvgList.CurrentRow.Cells(1).Value
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtFeeName.Text
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