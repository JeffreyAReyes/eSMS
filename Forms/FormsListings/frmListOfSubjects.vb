
Imports MySql.Data.MySqlClient

Public Class frmListOfSubjects

#Region "Database"

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetSubjectsAll", 4)
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
                .Columns(6).Visible = False

                .Columns(1).HeaderText = "Sub. Code"
                .Columns(2).HeaderText = "Descriptive Title"
                .Columns(3).HeaderText = "Num. of Units"
                .Columns(4).HeaderText = "Units Lecture"
                .Columns(5).HeaderText = "Units Lab"
                .Columns(6).HeaderText = "With Lab"
                .Columns(7).HeaderText = "Lab. Code"
                .Columns(8).HeaderText = "Date Encoded"
                .Columns(9).HeaderText = "Encoder"
                .Columns(10).HeaderText = "Date Modified"
                .Columns(11).HeaderText = "Encoder"

                .Columns(3).Width = "95"
                .Columns(4).Width = "95"
                .Columns(5).Width = "95"
                .Columns(6).Width = "95"

                .Columns(3).DefaultCellStyle.Format = "N1"
                .Columns(4).DefaultCellStyle.Format = "N1"
                .Columns(5).DefaultCellStyle.Format = "N1"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(8).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(10).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    ''' <summary>
    ''' Procedure to search a datagridview
    ''' </summary>
    ''' <param name="TheListControl">The datagridview to be searched.</param>
    ''' <param name="intColumn">The datagridview column to seacrh for.</param>
    ''' <param name="StringToSearch">The text to be searched.</param>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Exports data to formats selected.
    ''' </summary>
    ''' <param name="strFileFormat">File format of the resulting file.</param>
    ''' <param name="TheDataTable">The datatable where data comes from.</param>
    ''' <returns>True if export is successful.</returns>
    ''' <remarks></remarks>
    Private Function DataExporter(ByVal strFileFormat As String, ByVal TheDataTable As DataTable) As Boolean

        Dim boolResult As Boolean

        Select Case strFileFormat
            Case "Excel"
                With Me.ExportToExcel
                    .FileName = "Subjects List.xls"
                    .SaveToFile()
                End With
            Case "PDF"
            Case "HTML"
            Case "XML"
            Case "Text"
            Case "RTF"

        End Select

        Return boolResult

    End Function

    Public Function DataTableCreator(ByVal TheDataGridview As DataGridView) As Boolean

        Dim boolResult As Boolean

        'create a datatable
        Dim newtable As New DataTable

        With newtable

        End With

        Return boolResult

    End Function

    Public Function DataTableCreator(ByVal TheListview As ListView) As Boolean

        Dim boolResult As Boolean


        Return boolResult

    End Function

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Subjects")
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
        Me.cboSearch.SelectedIndex = 1
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditSubjects

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Subject"
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

        Try
            Dim newfrm As New frmAddEditSubjects

            With newfrm
                .IsAdding = False
                .FormHeading = "Modify Subject"
                .CurrentSujectID = Me.dvgList.CurrentRow.Cells(0).Value
                .txtDescriptiveTitle.Text = Me.dvgList.CurrentRow.Cells(2).Value
                .txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(1).Value
                .txtUnits.Text = Me.dvgList.CurrentRow.Cells(3).Value
                .txtHoursLecture.Text = Me.dvgList.CurrentRow.Cells(4).Value
                .txtHoursLab.Text = Me.dvgList.CurrentRow.Cells(5).Value
                .txtLabCode.Text = Me.dvgList.CurrentRow.Cells(7).Value

                .ShowDialog()
                If .MustUpdate = True Then
                    Me.cmdRefresh.PerformClick()
                    Me.txtSearch.Text = .txtDescriptiveTitle.Text
                End If
            End With
        Catch ex As Exception
            Dim newfrm As New frmErrorMessageViewer

            With newfrm
                .ErrorForHumans = "Error loading record."
                .ErrorMessage = ex.Message
                .ErrorTrace = ex.StackTrace
                .ShowDialog()
            End With
        End Try
       
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Select Case Me.cboSearch.SelectedIndex
            Case 0
                SearchDatagridview(Me.dvgList, 1, Me.txtSearch.Text)
            Case 1
                SearchDatagridview(Me.dvgList, 2, Me.txtSearch.Text)
        End Select

    End Sub

    Private Sub dvgList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgList.CellContentClick

    End Sub

    Private Sub cboSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearch.Click

    End Sub

    Private Sub cboSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSearch.SelectedIndexChanged
        Select Case Me.cboSearch.SelectedIndex
            Case 0
                Me.dvgList.Sort(Me.dvgList.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                SearchDatagridview(Me.dvgList, 1, Me.txtSearch.Text)
            Case 1
                Me.dvgList.Sort(Me.dvgList.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
                SearchDatagridview(Me.dvgList, 2, Me.txtSearch.Text)
        End Select
    End Sub
End Class