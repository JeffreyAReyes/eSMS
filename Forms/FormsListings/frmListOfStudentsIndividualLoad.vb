
Imports MySql.Data.MySqlClient

Public Class frmListOfStudentsIndividualLoad

#Region "Database"

    Public Sub GetListOfStudentsIndividualLoad()
        Dim ThedtaSet As New DataSet

        ThedtaSet = GetDataAndReturnDataSetByTermYear(ConnectionString, "GetListOfStudentsIndividualLoad", 4, Me.cboTerm.Text, Me.cboSchoolYear.Text)
        'Me.dvgList.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)
        SetDataToDatagridview(ThedtaSet)
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
                .Columns(3).HeaderText = "Student Name"
                .Columns(4).HeaderText = "Course"
                .Columns(5).HeaderText = "Year"
                .Columns(6).HeaderText = "Status"
                .Columns(7).HeaderText = "Sex"
                .Columns(8).HeaderText = "Dept"
                .Columns(9).HeaderText = "Degree"

                '.Columns(3).Width = "125"
                '.Columns(4).Width = "125"
                '.Columns(5).Width = "125"
                '.Columns(6).Width = "125"

                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub SetDataToDatagridview(ByVal TheDataSet As DataSet)
        'clear list
        Me.dvgList.Rows.Clear()
        Dim strSCode As String = ""
        Dim strDescTitle As String = ""
        Dim intUnit As Integer = 0

        For Each row As DataRow In TheDataSet.Tables(0).Rows
            For Each rrow As DataRow In TheDataSet.Tables(1).Rows
                If row("StudentID").ToString = rrow("StudentID").ToString Then
                    strSCode = rrow("SubjectCode").ToString
                    strDescTitle = rrow("DescriptiveTitle").ToString
                    intUnit = rrow("NumOfUnits")
                    Me.dvgList.Rows.Add(row("ESID"), row("StudentID"), row("EDPNumber"), row("Student_Name"), row("CourseCode"), _
                    row("EnrolYear"), row("EnrolStatus"), row("Gender"), row("DeptCode"), row("Degree"), strSCode, strDescTitle, intUnit)

                End If
                
            Next
           
        Next
    End Sub
#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Student's Individual Load")
        Me.cboTerm.Text = CurrentTerm
        Me.cboSchoolYear.Text = CurrentSchoolYear
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
        GetListOfStudentsIndividualLoad()
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

    Private Sub dvgList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgList.CellContentClick

    End Sub

    Private Sub dvgList_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgList.CellPainting
        Dim StringFormat As New StringFormat

        StringFormat.Alignment = StringAlignment.Near
        'Check if the
        ' current Cell Column to be painted is the RowHeader
        ' current Cell Row to be painted is a record row
        ' current Cell Row to be painted is not the EOF Row
        If e.ColumnIndex = -1 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < Me.dvgList.Rows.Count Then
            e.PaintBackground(e.ClipBounds, True)
            e.Graphics.DrawString((e.RowIndex + 1).ToString, Me.Font, Brushes.Black, e.CellBounds, StringFormat)
            e.Handled = True
        End If
    End Sub
End Class