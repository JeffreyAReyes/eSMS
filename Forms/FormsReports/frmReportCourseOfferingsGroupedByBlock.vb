


Public Class frmReportCourseOfferingsGroupedByBlock

#Region "Database"

    Public Sub GetCourseOfferingsBySemesterAndSchoolYearAll()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetCourseOfferingsBySemesterAndSchoolYearAll", 4, CurrentTerm, CurrentSchoolYear)
        'Me.dvgList.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)

        GenerateReport(LoadIntoClass(dtaTable))

    End Sub

#End Region

#Region "Helper"

    Private Function LoadIntoClass(ByVal TheTable As DataTable) As List(Of ClassCourseOfferings)

        Dim ListOfClassOfferings As New List(Of ClassCourseOfferings)

        For Each row As DataRow In TheTable.Rows
            Dim SingleValue As New ClassCourseOfferings

            With SingleValue

                .BlockCode = row("BlockCode").ToString
                .Day1 = row("Day1").ToString & "  " & row("Day2").ToString
                .DescTitle = row("DescriptiveTitle").ToString
                .Instructor = row("Instructor").ToString
                .Room1 = row("Room1").ToString & "   " & row("Room2").ToString
                .SectionCode = row("SOCode").ToString
                .SubjectCode = row("SubjectCode").ToString
                .SubjectUnits = row("NumOfUnits").ToString
                .Time1 = row("Time1").ToString & "  " & row("Time2").ToString

                ListOfClassOfferings.Add(SingleValue)

            End With
        Next

        Return ListOfClassOfferings

    End Function

    Private Sub GenerateReport(ByVal TheList As List(Of ClassCourseOfferings))

        Me.ClassCourseOfferingsBindingSource.DataSource = TheList
        Me.ReportViewer1.RefreshReport()
    End Sub

#End Region

    Private Sub frmReportCourseOfferingsGroupedByBlock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Report Course Offerings")

        GetCourseOfferingsBySemesterAndSchoolYearAll()

    End Sub

End Class