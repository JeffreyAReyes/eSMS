
Imports MySql.Data.MySqlClient

Public Class frmListOfEmployees

#Region "Database"

    Public Sub GetEmployeesAll()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetEmployeesAll", 4)
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
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False

                .Columns(2).HeaderText = "Emp. Code"
                .Columns(3).HeaderText = "Name"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City/Mun."
                .Columns(9).HeaderText = "Gender"
                .Columns(10).HeaderText = "Civil Status"
                .Columns(11).HeaderText = "Date of Birth"
                .Columns(12).HeaderText = "Landline"
                .Columns(13).HeaderText = "Mobile"
                .Columns(14).HeaderText = "E-mail"
                .Columns(15).HeaderText = "Department"

                .Columns(2).Width = "75"
                .Columns(3).Width = "250"
                .Columns(7).Width = "250"
                .Columns(8).Width = "100"
                .Columns(9).Width = "95"
                .Columns(10).Width = "95"
                .Columns(11).Width = "95"
                .Columns(12).Width = "95"
                .Columns(13).Width = "95"
                .Columns(14).Width = "95"
                .Columns(15).Width = "95"

                .Columns(11).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditEmployee

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Employee"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtLastName.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetEmployeesAll()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditEmployee

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Employee"
            .CurrentDeptID = Me.dvgList.CurrentRow.Cells(0).Value
            .CurrentEmpID = Me.dvgList.CurrentRow.Cells(0).Value
            .txtEmpCode.Text = Me.dvgList.CurrentRow.Cells(2).Value
            .txtLastName.Text = Me.dvgList.CurrentRow.Cells(4).Value
            .txtFirstname.Text = Me.dvgList.CurrentRow.Cells(5).Value
            .txtMiddleName.Text = Me.dvgList.CurrentRow.Cells(6).Value
            .txtAddress.Text = Me.dvgList.CurrentRow.Cells(7).Value
            .txtCity.Text = Me.dvgList.CurrentRow.Cells(8).Value
            .cboGender.Text = Me.dvgList.CurrentRow.Cells(9).Value
            .cboCivilStatus.Text = Me.dvgList.CurrentRow.Cells(10).Value
            .DateTimePicker1.Value = Me.dvgList.CurrentRow.Cells(11).Value
            .txtLandline.Text = Me.dvgList.CurrentRow.Cells(12).Value.ToString
            .txtMobile.Text = Me.dvgList.CurrentRow.Cells(13).Value.ToString
            .txtEmail.Text = Me.dvgList.CurrentRow.Cells(14).Value.ToString

            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtLastName.Text
            End If
        End With
    End Sub

    Private Sub frmListOfEmployees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Employees")
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