
Imports MySql.Data.MySqlClient

Public Class frmListOfCourseOfferingsAll

#Region "Database"

    Public Sub GetCourseOfferingsBlockSubjectsWithSumEnrolledALL()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetCourseOfferingsBlockSubjectsWithSumEnrolledALL", 4, CurrentTerm, CurrentSchoolYear)
        Me.dvgList.DataSource = dtaTable
        ArrangeDatagridView(Me.dvgList)

    End Sub

    Public Sub GetDeparmentsAllForCombo()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetDeparmentsAllForCombo", 4)
        Me.cboDept.DataSource = dtaTable
        Me.cboDept.DisplayMember = "DeptDescription"
        Me.cboDept.ValueMember = "DeptID"

    End Sub

#End Region

#Region "Helper"


    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False

                .Columns(3).HeaderText = "Section Code"
                .Columns(4).HeaderText = "Subject"
                .Columns(5).HeaderText = "Descriptive Title"
                .Columns(6).HeaderText = "Time1"
                .Columns(7).HeaderText = "Day1"
                .Columns(8).HeaderText = "Room1"
                .Columns(9).HeaderText = "Time2"
                .Columns(10).HeaderText = "Day2"
                .Columns(11).HeaderText = "Room2"
                .Columns(12).HeaderText = "Units"
                .Columns(13).HeaderText = "Lab Code"
                .Columns(14).HeaderText = "Instructor"
                .Columns(15).HeaderText = "Max. Allowed"
                .Columns(16).HeaderText = "Enrolled"

                .Columns(3).Width = "75"
                .Columns(4).Width = "100"
                .Columns(5).Width = "200"
                .Columns(6).Width = "135"
                .Columns(9).Width = "135"
                .Columns(7).Width = "75"
                .Columns(8).Width = "75"
                .Columns(10).Width = "75"
                .Columns(11).Width = "75"
                .Columns(12).Width = "65"
                .Columns(14).Width = "200"
                .Columns(15).Width = "75"
                .Columns(16).Width = "75"

                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(12).DefaultCellStyle.Format = "N1"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    ''' <summary>
    ''' Procedure to apply format
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ApplyFormat()

        For Each row As DataGridViewRow In Me.dvgList.Rows
            If IsDBNull(row.Cells(16).Value) = True Then

            Else
                If row.Cells(15).Value <= row.Cells(16).Value Then
                    Dim i As Integer = 0

                    For i = 0 To 14
                        row.Cells(i).Style.BackColor = Color.LightGray
                    Next

                End If
            End If

        Next
        'set column color
        Me.dvgList.Columns(15).DefaultCellStyle.BackColor = Color.Cornsilk
        Me.dvgList.Columns(16).DefaultCellStyle.BackColor = Color.LightYellow
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Course Offerings - " & CurrentTerm & ", " & CurrentSchoolYear)
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()
        GetDeparmentsAllForCombo()
        Me.cboDept.SelectedIndex = -1
        ApplyFormat()
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
        GetCourseOfferingsBlockSubjectsWithSumEnrolledALL()
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

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer = 0

        With Me
            For i = 0 To .dvgList.Rows.Count - 1
                If .dvgList.Rows(i).Cells(4).Value.ToString.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) Then
                    .dvgList.Rows(i).Selected = True
                    .dvgList.CurrentCell = .dvgList(4, i)
                    .dvgList.FirstDisplayedScrollingRowIndex = .dvgList.CurrentCell.RowIndex
                    Exit Sub
                End If
            Next
        End With

    End Sub

    Private Sub cmdClassList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClassList.Click
        Dim newfrm As New frmClassListBySectionCode

        With newfrm
            .txtSecCode.Text = Me.dvgList.CurrentRow.Cells(3).Value
            .txtSubject.Text = Me.dvgList.CurrentRow.Cells(4).Value.ToString & " - " & _
                 Me.dvgList.CurrentRow.Cells(5).Value.ToString
            .SectionCode = Me.dvgList.CurrentRow.Cells(3).Value
            .SubjectCode = Me.dvgList.CurrentRow.Cells(4).Value.ToString
            .DescTitle = Me.dvgList.CurrentRow.Cells(5).Value.ToString
            .Time1 = Me.dvgList.CurrentRow.Cells(6).Value.ToString & " / " & _
                 Me.dvgList.CurrentRow.Cells(9).Value.ToString
            .Day1 = Me.dvgList.CurrentRow.Cells(7).Value.ToString & " / " & _
                 Me.dvgList.CurrentRow.Cells(10).Value.ToString
            .Room1 = Me.dvgList.CurrentRow.Cells(8).Value.ToString & " / " & _
                 Me.dvgList.CurrentRow.Cells(11).Value.ToString
            .Units = Me.dvgList.CurrentRow.Cells(12).Value
            .Instructor = Me.dvgList.CurrentRow.Cells(14).Value.ToString
            .txtInstructor.Text = Me.dvgList.CurrentRow.Cells(14).Value.ToString
            .ShowDialog()

        End With
    End Sub

    Private Sub dvgList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgList.CellContentClick

    End Sub

    Private Sub dvgList_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgList.Sorted
        ApplyFormat()
    End Sub
End Class