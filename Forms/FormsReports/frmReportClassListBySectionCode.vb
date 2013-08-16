


Public Class frmReportClassListBySectionCode

#Region "Properties"

    Dim TheList As List(Of ClassSectionClassList)
    Public Property SectionList() As List(Of ClassSectionClassList)
        Get
            Return TheList
        End Get
        Set(ByVal value As List(Of ClassSectionClassList))
            TheList = value
        End Set
    End Property

    Dim strFacultyName As String
    Public Property FacultyName() As String
        Get
            Return strFacultyName
        End Get
        Set(ByVal value As String)
            strFacultyName = value
        End Set
    End Property

    Dim strSubjCode As String
    Public Property SubjectCode() As String
        Get
            Return strSubjCode
        End Get
        Set(ByVal value As String)
            strSubjCode = value
        End Set
    End Property

    Dim strSectionCode As String
    Public Property SectionCode() As String
        Get
            Return strSectionCode
        End Get
        Set(ByVal value As String)
            strSectionCode = value
        End Set
    End Property

    Dim strDescTitle As String
    Public Property DescTitle() As String
        Get
            Return strDescTitle
        End Get
        Set(ByVal value As String)
            strDescTitle = value
        End Set
    End Property

    Dim strTime1 As String
    Public Property Time1() As String
        Get
            Return strTime1
        End Get
        Set(ByVal value As String)
            strTime1 = value
        End Set
    End Property

    Dim strTime2 As String
    Public Property Time2() As String
        Get
            Return strTime2
        End Get
        Set(ByVal value As String)
            strTime2 = value
        End Set
    End Property

    Dim strDay1 As String
    Public Property Day1() As String
        Get
            Return strDay1
        End Get
        Set(ByVal value As String)
            strDay1 = value
        End Set
    End Property

    Dim strDay2 As String
    Public Property Day2() As String
        Get
            Return strDay2
        End Get
        Set(ByVal value As String)
            strDay2 = value
        End Set
    End Property

    Dim strRoom1 As String
    Public Property Room1() As String
        Get
            Return strRoom1
        End Get
        Set(ByVal value As String)
            strRoom1 = value
        End Set
    End Property

    Dim strRoom2 As String
    Public Property Room2() As String
        Get
            Return strRoom2
        End Get
        Set(ByVal value As String)
            strRoom2 = value
        End Set
    End Property

    Dim strLabCode As String
    Public Property LabCode() As String
        Get
            Return strLabCode
        End Get
        Set(ByVal value As String)
            strLabCode = value
        End Set
    End Property

    Dim intUnits As Decimal
    Public Property Units() As Decimal
        Get
            Return intUnits
        End Get
        Set(ByVal value As Decimal)
            intUnits = value
        End Set
    End Property

#End Region

    Private Sub frmReportClassListBySectionCode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Class List - " & Me.SectionCode & " (" & Me.SubjectCode & ")")


        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("SchoolName", My.Settings.SchoolName, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("ReportHeader1", "Class List", True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("TermYear", CurrentTerm & ", " & CurrentSchoolYear, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("InstructorName", Me.FacultyName, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Units", Me.Units, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Time1", Me.Time1, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Day1", Me.Day1, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Room1", Me.Room1, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("SectionCode", Me.SectionCode, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("SubjectCode", Me.SubjectCode, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("DescriptiveTitle", Me.DescTitle, True))
        'paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("DescriptiveTitle", Me.DescTitle, True))

        Me.ReportViewer1.LocalReport.SetParameters(paramList)

        'show report
        Me.ClassSectionClassListBindingSource.DataSource = Me.TheList
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class