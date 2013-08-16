


Public Class frmReportStudentGrades

#Region "Properties"

    Dim TheList As List(Of ClassStudentGradesFOrComputation)
    Public Property FacultyLoadsList() As List(Of ClassStudentGradesFOrComputation)
        Get
            Return TheList
        End Get
        Set(ByVal value As List(Of ClassStudentGradesFOrComputation))
            TheList = value
        End Set
    End Property

    Dim strStudentName As String
    Public Property StudentName() As String
        Get
            Return strStudentName
        End Get
        Set(ByVal value As String)
            strStudentName = value
        End Set
    End Property

    Dim strCourse As String
    Public Property Course() As String
        Get
            Return strCourse
        End Get
        Set(ByVal value As String)
            strCourse = value
        End Set
    End Property

    Dim strYear As String
    Public Property EYear() As String
        Get
            Return strYear
        End Get
        Set(ByVal value As String)
            strYear = value
        End Set
    End Property

    Dim strSem As String
    Public Property Semester() As String
        Get
            Return strSem
        End Get
        Set(ByVal value As String)
            strSem = value
        End Set
    End Property

    Dim strSchoolYear As String
    Public Property SchoolYear() As String
        Get
            Return strSchoolYear
        End Get
        Set(ByVal value As String)
            strSchoolYear = value
        End Set
    End Property

    Dim decGPA As Decimal = 0.0
    Public Property GPA() As Decimal
        Get
            Return decGPA
        End Get
        Set(ByVal value As Decimal)
            decGPA = value
        End Set
    End Property
#End Region

#Region "Helper"


#End Region
    Private Sub frmReportStudentGrades_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Student Grades")
    End Sub

    Private Sub frmReportStudentGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'assign report parameters
        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("SchoolName", My.Settings.SchoolName, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Address", My.Settings.SchoolAddress1 & ", " & My.Settings.SchoolAddress2, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Semester", Me.Semester & ", " & Me.SchoolYear, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("SchoolYear", Me.Semester & ", " & Me.SchoolYear, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("StudentName", Me.StudentName, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Course", Me.Course, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("EYear", Me.EYear, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Gpa", Me.GPA, True))

        Me.ReportViewer1.LocalReport.SetParameters(paramList)

        'show report
        Me.ClassStudentGradesFOrComputationBindingSource.DataSource = Me.TheList
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class