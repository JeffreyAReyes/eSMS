
Imports MySql.Data.MySqlClient

Public Class frmListOfSubjectsOffered

#Region "Database"

    Public Sub GetCourseOfferings(ByVal strTerm As String, ByVal strYear As String)
        Dim dtaTable As New DataSet

        dtaTable = GetDataAndReturnDataSetByTermYear(ConnectionString, "GetCourseOfferingsBySemesterAndSchoolYear", 4, CurrentTerm, CurrentSchoolYear)
        Me.dvgList.DataSource = dtaTable.Tables(0)
        Me.dvgBlockCodes.DataSource = dtaTable.Tables(1)
        ArrangeDatagridView(Me.dvgList)
        ArrangeDatagridViewBlockCodes(Me.dvgBlockCodes)

    End Sub

    Public Sub GetCourseOfferingsBlock(ByVal strTerm As String, ByVal strYear As String, ByVal strBLCode As String)
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYearByBlock(ConnectionString, "GetCourseOfferingsBlockSubjects", 4, CurrentTerm, CurrentSchoolYear, strBLCode)
        Me.dvgBlockCodesSubjects.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)
        ArrangeDatagridViewBlockSubjects(dvgBlockCodesSubjects)

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
                .Columns(4).HeaderText = "Subj. Code"
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
                .Columns(15).HeaderText = "Num. of Seats"

                .Columns(3).Width = "85"
                .Columns(4).Width = "100"
                .Columns(7).Width = "65"
                .Columns(8).Width = "65"
                .Columns(10).Width = "65"
                .Columns(11).Width = "65"
                .Columns(12).Width = "65"
                .Columns(13).Width = "65"
                .Columns(5).Width = "400"
                .Columns(14).Width = "200"
                .Columns(6).Width = "130"
                .Columns(9).Width = "130"
                '.Columns(7).Width = "85"
                '.Columns(10).Width = "85"

                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub ArrangeDatagridViewBlockSubjects(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False

                .Columns(3).HeaderText = "Section Code"
                .Columns(4).HeaderText = "Subj. Code"
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
                .Columns(15).HeaderText = "Num. of Seats"

                .Columns(3).Width = "85"
                .Columns(4).Width = "100"
                .Columns(7).Width = "65"
                .Columns(8).Width = "65"
                .Columns(10).Width = "65"
                .Columns(11).Width = "65"
                .Columns(12).Width = "65"
                .Columns(13).Width = "65"
                .Columns(5).Width = "400"
                .Columns(14).Width = "200"
                .Columns(6).Width = "130"
                .Columns(9).Width = "130"
                '.Columns(7).Width = "85"
                '.Columns(10).Width = "85"

                '.Columns(3).DefaultCellStyle.Format = "MMM/dd/yyyy"
                '.Columns(5).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ArrangeDatagridViewBlockCodes(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Block Codes"

                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub
#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Course Offerings - " & CurrentTerm & ", " & CurrentSchoolYear)
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditCourseOfferings

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Course Offerings - Open Subject"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetCourseOfferings(CurrentTerm, CurrentSchoolYear)
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Try
            Dim newfrm As New frmAddEditCourseOfferings

            With newfrm
                .IsAdding = False
                .FormHeading = "Modify Course Offering - Open Subject"
                .txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(3).Value
                .CurrentSujectID = Me.dvgList.CurrentRow.Cells(1).Value
                .CurrentCourseOfferingID = Me.dvgList.CurrentRow.Cells(0).Value
                '.txtDescriptiveTitle.Text = Me.dvgList.CurrentRow.Cells(2).Value
                '.txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(1).Value
                If IsDBNull(Me.dvgList.CurrentRow.Cells(2).Value) = True Then
                    .CurrentEmployeeID = 0
                Else
                    .CurrentEmployeeID = Me.dvgList.CurrentRow.Cells(2).Value
                End If

                .txtTime1.Text = Me.dvgList.CurrentRow.Cells(6).Value.ToString
                .txtDay1.Text = Me.dvgList.CurrentRow.Cells(7).Value.ToString
                .txtRoom1.Text = Me.dvgList.CurrentRow.Cells(8).Value.ToString
                .txtTime2.Text = Me.dvgList.CurrentRow.Cells(9).Value.ToString
                .txtDay2.Text = Me.dvgList.CurrentRow.Cells(10).Value.ToString
                .txtRoom2.Text = Me.dvgList.CurrentRow.Cells(11).Value.ToString
                .txtSeats.Text = Me.dvgList.CurrentRow.Cells(15).Value.ToString
                .ShowDialog()
                If .MustUpdate = True Then
                    Me.cmdRefresh.PerformClick()
                    Me.txtSearch.Text = .txtDescriptiveTitle.Text
                End If
            End With
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub cmdAddBlockCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBlockCode.Click
        Dim newfrm As New frmAddEditBlockCode

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Course Offerings - Block Code"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                'Me.txtSearch.Text = .txtSubjectCode.Text
            End If
        End With
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim newfrm As New frmAddEditCourseOfferingsByBlock

        Try
            With newfrm
                .IsAdding = True
                .FormHeading = "Add New Course Offerings - Block Section (" & Me.dvgBlockCodes.CurrentRow.Cells(1).Value.ToString & ")"
                .CurrentBlockCode = Me.dvgBlockCodes.CurrentRow.Cells(1).Value.ToString
                .ShowDialog()
                If .MustUpdate = True Then
                    Me.cmdRefreshBlockSubjects.PerformClick()
                    Me.ToolStripTextBox1.Text = .txtDescriptiveTitle.Text
                End If
            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim newfrm As New frmAddEditCourseOfferingsByBlock

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Course Offering - Block Section (" & Me.dvgBlockCodes.CurrentRow.Cells(1).Value.ToString & ")"
            .txtSubjectCode.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(3).Value
            .CurrentSujectID = Me.dvgBlockCodesSubjects.CurrentRow.Cells(1).Value
            .CurrentCourseOfferingID = Me.dvgBlockCodesSubjects.CurrentRow.Cells(0).Value
            .CurrentBlockCode = Me.dvgBlockCodes.CurrentRow.Cells(1).Value.ToString
            '.txtDescriptiveTitle.Text = Me.dvgList.CurrentRow.Cells(2).Value
            '.txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(1).Value
            If IsDBNull(Me.dvgBlockCodesSubjects.CurrentRow.Cells(2).Value) = True Then
                .CurrentEmployeeID = 0
            Else
                .CurrentEmployeeID = Me.dvgBlockCodesSubjects.CurrentRow.Cells(2).Value
            End If

            .txtTime1.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(6).Value.ToString
            .txtDay1.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(7).Value.ToString
            .txtRoom1.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(8).Value.ToString
            .txtTime2.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(9).Value.ToString
            .txtDay2.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(10).Value.ToString
            .txtRoom2.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(11).Value.ToString
            .txtSeats.Text = Me.dvgBlockCodesSubjects.CurrentRow.Cells(15).Value.ToString
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefreshBlockSubjects.PerformClick()
                Me.ToolStripTextBox1.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cmdRefreshBlockSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshBlockSubjects.Click
        Try
            GetCourseOfferingsBlock(CurrentTerm, CurrentSchoolYear, Me.dvgBlockCodes.CurrentRow.Cells(1).Value.ToString)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dvgBlockCodes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgBlockCodes.CellContentClick

    End Sub

    Private Sub dvgBlockCodes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgBlockCodes.SelectionChanged
        Me.cmdRefreshBlockSubjects.PerformClick()
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub cmdModifyBlockCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModifyBlockCode.Click

    End Sub
End Class