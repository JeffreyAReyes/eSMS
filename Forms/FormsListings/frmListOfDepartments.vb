
Imports MySql.Data.MySqlClient

Public Class frmListOfDepartments

#Region "Database"

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetDepatrmentsAll", 4)
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

                .Columns(1).HeaderText = "Dept. Code"
                .Columns(2).HeaderText = "Department"
                .Columns(3).HeaderText = "Date Encoded"
                .Columns(4).HeaderText = "Encoder"
                .Columns(5).HeaderText = "Date Modified"
                .Columns(6).HeaderText = "Modified By"

                .Columns(3).Width = "125"
                .Columns(4).Width = "125"
                .Columns(5).Width = "125"
                .Columns(6).Width = "125"

                .Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Departments")
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