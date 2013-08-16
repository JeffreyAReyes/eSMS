


Public Class frmReportFacultyLoad

#Region "Properties"

    Dim TheList As List(Of ClassFacultyLoad)
    Public Property FacultyLoadsList() As List(Of ClassFacultyLoad)
        Get
            Return TheList
        End Get
        Set(ByVal value As List(Of ClassFacultyLoad))
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

#End Region

    Private Sub frmReportFacultyLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Faculty Loads")

        'assign report parameters
        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("SchoolName", My.Settings.SchoolName, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("ReportHeader1", "Faculty Loads", True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("TermYear", CurrentTerm & ", " & CurrentSchoolYear, True))
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("InstructorName", Me.FacultyName, True))

        Me.ReportViewer1.LocalReport.SetParameters(paramList)

        'show report
        Me.ClassFacultyLoadBindingSource.DataSource = Me.TheList
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class