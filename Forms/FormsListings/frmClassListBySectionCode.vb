
Imports MySql.Data.MySqlClient

Public Class frmClassListBySectionCode

#Region "Database"

    Public Sub GetEnrolledStudentsBySectionCodeByTermByYear()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableWithOneParameterByTermYear(ConnectionString, _
                "GetEnrolledStudentsBySectionCodeByTermByYear", 4, CurrentTerm, CurrentSchoolYear, "CSectionCode", Me.SectionCode)
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

                .Columns(2).HeaderText = "EDP Number"
                .Columns(3).HeaderText = "Student"
                .Columns(4).HeaderText = "Course"
                .Columns(5).HeaderText = "Year"
                .Columns(6).HeaderText = "Date Enrolled"

                .Columns(2).Width = "125"
                .Columns(3).Width = "125"
                .Columns(4).Width = "100"
                .Columns(5).Width = "65"
                .Columns(6).Width = "100"

                .Columns(6).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub GenerateReport()

        Dim ListClassSectionClassList As New List(Of ClassSectionClassList)

        For Each row As DataGridViewRow In Me.dvgList.Rows
            If row.IsNewRow = True Then

            Else
                Dim newitem As New ClassSectionClassList

                With newitem

                    .EDPNumber = row.Cells(2).Value.ToString
                    .StudentCourse = row.Cells(4).Value.ToString
                    .StudentName = row.Cells(3).Value.ToString
                    .StudentYear = row.Cells(5).Value.ToString
                    
                    'add item to collection

                    ListClassSectionClassList.Add(newitem)

                End With
            End If
        Next

        Dim newfrm As New frmReportClassListBySectionCode

        With newfrm

            .SectionList = ListClassSectionClassList
            .SectionCode = Me.txtSecCode.Text
            .SubjectCode = Me.SubjectCode
            .DescTitle = Me.DescTitle
            .Time1 = Me.Time1
            .Day1 = Me.Day1
            .Room1 = Me.Room1
            .FacultyName = Me.txtInstructor.Text
            .Units = Me.Units

            .ShowDialog()

        End With
    End Sub

    ''' <summary>
    ''' Procedure to apply format
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ApplyFormat()

        Try
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
        Catch ex As Exception

        End Try
        
    End Sub

#End Region

#Region "Properties"

    Dim intSectionCode As Integer
    Public Property SectionCode() As Integer
        Get
            Return intSectionCode
        End Get
        Set(ByVal value As Integer)
            intSectionCode = value
        End Set
    End Property

    Dim strSubjectCode As String
    Public Property SubjectCode() As String
        Get
            Return strSubjectCode
        End Get
        Set(ByVal value As String)
            strSubjectCode = value
        End Set
    End Property

    Dim strDescrTitle As String
    Public Property DescTitle() As String
        Get
            Return strDescrTitle
        End Get
        Set(ByVal value As String)
            strDescrTitle = value
        End Set
    End Property

    Dim strTime As String
    Public Property Time1() As String
        Get
            Return strTime
        End Get
        Set(ByVal value As String)
            strTime = value
        End Set
    End Property

    Dim strDay As String
    Public Property Day1() As String
        Get
            Return strDay
        End Get
        Set(ByVal value As String)
            strDay = value
        End Set
    End Property

    Dim strRoom As String
    Public Property Room1() As String
        Get
            Return strRoom
        End Get
        Set(ByVal value As String)
            strRoom = value
        End Set
    End Property

    Dim intUnits As Integer
    Public Property Units() As Integer
        Get
            Return intUnits
        End Get
        Set(ByVal value As Integer)
            intUnits = value
        End Set
    End Property

    Dim strInstructor As String
    Public Property Instructor() As String
        Get
            Return strInstructor
        End Get
        Set(ByVal value As String)
            strInstructor = value
        End Set
    End Property


#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Class List - (" & Me.SectionCode & ") - " & Me.SubjectCode & " - " & Me.DescTitle & "")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()
        'ApplyFormat()
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
        GetEnrolledStudentsBySectionCodeByTermByYear()
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

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        GenerateReport()
    End Sub

    Private Sub dvgList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgList.CellContentClick

    End Sub

    Private Sub dvgList_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dvgList.CellPainting
        AddNumberingToTheDataGridView(Me.dvgList, e, Me.dvgList.Font)
    End Sub

    Private Sub dvgList_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dvgList.Sorted
        'ApplyFormat()
    End Sub
End Class