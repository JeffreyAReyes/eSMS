
Imports MySql.Data.MySqlClient

Public Class frmMain

#Region "Helper"

    ''' <summary>
    ''' Procedure to select menu items to be activated based on the user privilege
    ''' </summary>
    ''' <param name="strPrivilege"></param>
    ''' <remarks></remarks>
    Public Sub SetMenu(ByVal strPrivilege As String, ByVal strModulesAllowed As String)
        SetMenus(strModulesAllowed)
    End Sub

    ''' <summary>
    ''' Procedure that disables menus if the user is not logged in
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DisableMenus()
        With Me
            .LogOutToolStripMenuItem.Visible = False
            .LogInToolStripMenuItem.Visible = True
            .FileToolStripMenuItem.Visible = False
            .EnrollmentToolStripMenuItem.Visible = False
            .ViewsToolStripMenuItem.Visible = False
            .ReportsToolStripMenuItem.Visible = False
            .ToolStripMenuItem8.Visible = False
            .ToolStripMenuItem9.Visible = False
            .ToolStripMenuItem3.Visible = False
            .ReportsToolStripMenuItem.Visible = False
            .ToolStripMenuItem10.Visible = False
            .ToolStripMenuItem11.Visible = False
            .ToolStripMenuItem13.Visible = False
            .ToolStripMenuItem14.Visible = False
        End With
    End Sub

    Public Sub EnableAllMenus()
        With Me
            .LogOutToolStripMenuItem.Visible = True
            .LogInToolStripMenuItem.Visible = True
            .FileToolStripMenuItem.Visible = True
            .EnrollmentToolStripMenuItem.Visible = True
            .ViewsToolStripMenuItem.Visible = True
            .ReportsToolStripMenuItem.Visible = True
            .ToolStripMenuItem8.Visible = True
            .ToolStripMenuItem9.Visible = True
            .ToolStripMenuItem3.Visible = True
            .ReportsToolStripMenuItem.Visible = True
            .ToolStripMenuItem10.Visible = True
            .ToolStripMenuItem11.Visible = True
            .ToolStripMenuItem13.Visible = True
            .ToolStripMenuItem14.Visible = True
        End With
    End Sub

    Private Sub SetMenus(ByVal strModuleAllowed)

        Select Case strModuleAllowed.ToString.ToUpper
            Case "ALL"
                EnableAllMenus()
            Case "ACCOUNTING"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem8.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.FileToolStripMenuItem.Visible = True
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ReportsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem11.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem13.Visible = True
                Me.ToolStripMenuItem14.Visible = False
                'Me.ToolStripMenuItem12.Visible = True
                'Me.CoursesToolStripMenuItem.Visible = False
                'Me.EmployeesToolStripMenuItem.Visible = False
                'Me.
            Case "REGISTRAR"
                Me.ToolStripMenuItem3.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem8.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.FileToolStripMenuItem.Visible = True
                Me.EnrollmentToolStripMenuItem.Visible = True
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ReportsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem11.Visible = False
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = False
            Case "ADVISING"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.ToolStripMenuItem8.Visible = True
                Me.FileToolStripMenuItem.Visible = True
                Me.ViewsToolStripMenuItem.Visible = True
                'Me.ReportsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem11.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = False
            Case "GRADING"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.FileToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.ToolStripMenuItem9.Visible = True
                Me.ToolStripMenuItem11.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = False
            Case "ADMINISTRATIVE TASKS"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem8.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem10.Visible = True
                Me.FileToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem11.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = False
            Case "DSA"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem8.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.FileToolStripMenuItem.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem11.Visible = True
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = False
            Case "CASHIERING"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem8.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.FileToolStripMenuItem.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem11.Visible = False
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = True
            Case "REGISTRARENCODER"
                Me.ToolStripMenuItem3.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem8.Visible = False
                Me.ToolStripMenuItem9.Visible = False
                Me.ToolStripMenuItem10.Visible = False
                Me.FileToolStripMenuItem.Visible = False
                Me.ReportsToolStripMenuItem.Visible = False
                Me.ToolStripMenuItem11.Visible = False
                Me.ViewsToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem13.Visible = False
                Me.ToolStripMenuItem14.Visible = False
                Me.EnrollmentToolStripMenuItem.Visible = True
                Me.ToolStripMenuItem7.Visible = False
                Me.EnrollStudentToolStripMenuItem.Visible = False
                Me.GradesToolStripMenuItem.Visible = False
                Me.ReportsToolStripMenuItem1.Visible = True
        End Select
    End Sub

#End Region

#Region "Database"

    Public Function GetSystemCurrentDateTime() As Date
        Dim dtaDate As New Date

        dtaDate = GetDataAndReturnADate(ConnectionString, "GetSystemCurrentDateTime", 4)
        'Me.dvgList.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)

        Return dtaDate

    End Function

#End Region

    Private Sub frmMain_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.AppTitle.ToString & " " & My.Settings.SchoolName
        Me.ToolStripStatusLabel1.Text = My.Settings.AppTitle.ToString

        DisableMenus()
        'sSetMenu(CurrentUserPrivilege, CurrentUserModule)

        'Me.KryptonHeaderGroup2.ValuesPrimary.Heading = CurrentTerm & ", " & CurrentSchoolYear
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim newfrm As New frmLogin

        With newfrm
            .ShowDialog()
        End With

        'get server date
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = FormatDateTime(GetSystemCurrentDateTime(), DateFormat.LongDate)

    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        Dim newfrm As New frmLogin

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub DatabaseSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseSettingsToolStripMenuItem.Click
        Dim newfrm As New frmSettingsDatabaseTerminal

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub OtherSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherSettingsToolStripMenuItem.Click
        Dim newfrm As New frmSchoolSettings

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Dim newfrm As New frmListOfDepartments

        With newfrm
            If CurrentUserPrivilege.ToUpper <> "REGISTRAR" Then
                .cmdAddNew.Visible = False
                .cmdDelete.Visible = False
                .cmdModify.Visible = False
            Else
                .cmdAddNew.Visible = True
                .cmdDelete.Visible = True
                .cmdModify.Visible = True
            End If
            .ShowDialog()
        End With
    End Sub

    Private Sub SubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem.Click
        Dim newfrm As New frmListOfSubjects

        With newfrm
            If CurrentUserPrivilege.ToUpper <> "REGISTRAR" Then
                .cmdAddNew.Visible = False
                .cmdDelete.Visible = False
                .cmdModify.Visible = False
            Else
                .cmdAddNew.Visible = True
                .cmdDelete.Visible = True
                .cmdModify.Visible = True
            End If
            .ShowDialog()
        End With
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem.Click
        Dim newfrm As New frmListOfCourses

        With newfrm
            If CurrentUserPrivilege.ToUpper <> "REGISTRAR" Then
                .cmdAddNew.Visible = False
                .cmdDelete.Visible = False
                .cmdModify.Visible = False
            Else
                .cmdAddNew.Visible = True
                .cmdDelete.Visible = True
                .cmdModify.Visible = True
            End If
            .ShowDialog()
        End With
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        Dim newfrm As New frmListOfStudents

        With newfrm
            If CurrentUserPrivilege.ToUpper <> "REGISTRAR" Then
                .cmdAddNew.Visible = False
                .cmdDelete.Visible = False
                .cmdModify.Visible = False
            Else
                .cmdAddNew.Visible = True
                .cmdDelete.Visible = True
                .cmdModify.Visible = True
            End If
            .ShowDialog()
        End With
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesToolStripMenuItem.Click
        Dim newfrm As New frmListOfEmployees

        With newfrm
            If CurrentUserPrivilege.ToUpper <> "REGISTRAR" Then
                .cmdAddNew.Visible = False
                .cmdDelete.Visible = False
                .cmdModify.Visible = False
            Else
                .cmdAddNew.Visible = True
                .cmdDelete.Visible = True
                .cmdModify.Visible = True
            End If
            .ShowDialog()
        End With
    End Sub

    Private Sub SubjectsOfferedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsOfferedToolStripMenuItem.Click
        Dim newfrm As New frmListOfSubjectsOffered

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Dim newfrm As New frmListOfStudentsAdmission

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub SystemLoginsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemLoginsToolStripMenuItem.Click
        Dim newfrm As New frmListOfSystemLogins

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim newfrm As New frmAbout

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub StudentAdmissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAdmissionToolStripMenuItem.Click
        Dim newfrm As New frmListOfStudentsAdmission

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub StudentAdmissionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAdmissionToolStripMenuItem1.Click
        Dim newfrm As New frmListOfStudentsAdmission

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Dim newfrm As New frmHelp

        With newfrm
            .Topic = "Index"
            .HelpModule = 0
            .Show()
        End With
    End Sub

    Private Sub EvaluationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluationToolStripMenuItem.Click
        Dim newfrm As New frmAskDepartment
        Dim strCurrentDepartment As String = ""

        With newfrm
            .FormHeading = "Select Department"
            .ShowDialog()
            strCurrentDepartment = .CurrentDeptName
            If .IsOk = True Then
                Dim newfrmevaluation As New frmAddEditStudentEvaluation

                With newfrmevaluation
                    .lblHeader.Values.Heading = CurrentTerm & ", " & CurrentSchoolYear & " - " & strCurrentDepartment
                    .ShowDialog()
                End With
            End If
        End With
    End Sub

    Private Sub TeachersLoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeachersLoadToolStripMenuItem.Click
        Dim newfrm As New frmListOfTeachersLoad

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub FeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesToolStripMenuItem.Click
        Dim newfrm As New frmListOfFeesNames

        With newfrm
           
            .ShowDialog()
        End With
    End Sub

    Private Sub FeesAmountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesAmountsToolStripMenuItem.Click
        Dim newfrm As New frmAddEditSemestralFees

        With newfrm
            .TheHeight = Me.Height - 35
            .TheWidth = Me.Width - 45
            .ShowDialog()
        End With
    End Sub

    Private Sub FeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeToolStripMenuItem.Click
        Dim newfrm As New frmListOfFeesNames

        With newfrm

            .ShowDialog()
        End With
    End Sub

    Private Sub SemestralFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemestralFeesToolStripMenuItem.Click
        Dim newfrm As New frmAddEditSemestralFees

        With newfrm
            .TheHeight = Me.Height - 35
            .TheWidth = Me.Width - 45
            .ShowDialog()
        End With
    End Sub

    Private Sub EnrollStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollStudentToolStripMenuItem.Click
        Dim newfrm As New frmRegisterStudent

        With newfrm
            .lblHeader.Values.Heading = CurrentTerm & ", " & CurrentSchoolYear & " - " & "Registrar"
            '.NewEnrollment = False

            .ShowDialog()
        End With
    End Sub

    Private Sub EnrolledStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrolledStudentsToolStripMenuItem.Click
        Dim newfrm As New frmListOfEnrolledStudents

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

        'Attempt of my 18 months old son to program
        'June 03, 2011 - 7:00 AM

        ',bhhhgfrfi--0ttrruip[[pouuer790---97trt8[[;[[;:';;ll;;/..;///


        ''



        'm(m)
    End Sub

    Private Sub CourseOfferingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseOfferingsToolStripMenuItem.Click
        Dim newfrm As New frmReportCourseOfferingsGroupedByBlock

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub CashieringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashieringToolStripMenuItem.Click
        Dim newfrm As New frmAddEditCashiering

        With newfrm
            .IsAdding = True
            .ShowDialog()
        End With
    End Sub

    Private Sub PaymentsReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsReceivedToolStripMenuItem.Click
        Dim newfrm As New frmListOfPaymentsReceived

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub StudentScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentScheduleToolStripMenuItem.Click
        Dim newfrm As New frmStudentSchedules

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        Dim newfrm As New frmListOfCourseOfferingsAll

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub BlockSectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockSectionsToolStripMenuItem.Click
        Dim newfrm As New frmListOfBlockSubjectsForEnrollment

        With newfrm
            .cmdSave.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub SummaryOfEnrollmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryOfEnrollmentToolStripMenuItem.Click
        Dim newfrm As New frmListOFEnrolmentSummaryvb

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub StudentGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentGradesToolStripMenuItem.Click
        Dim newfrm As New frmStudentGrades

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub StudentLedgersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentLedgersToolStripMenuItem.Click
        Dim newfrm As New frmStudentLedger

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountsToolStripMenuItem.Click
        Dim newfrm As New frmListOfDiscounts

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub SetCurrentTermYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCurrentTermYearToolStripMenuItem.Click
        If CurrentPassword = "jikirililia" Then
            Dim newfrm As New frmTempSY

            With newfrm
                .ShowDialog()
            End With
        Else

        End If
    End Sub

    Private Sub GradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradesToolStripMenuItem.Click
        Dim newfrm As New frmAddEditGrades

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub AcceptGradToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptGradToolStripMenuItem.Click

    End Sub

    Private Sub EnrollmentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentListToolStripMenuItem.Click
        Dim newfrm As New frmListOfStudentsIndividualLoad

        With newfrm
            .Show()
        End With
    End Sub

    Private Sub ListForExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListForExportToolStripMenuItem.Click
        Dim newfrm As New frmListOfStudentsAdmissionForExport

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub OpenImportedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImportedToolStripMenuItem.Click
        Dim newfrm As New frmListOfStudentsAdmissionImportedFromXML

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub OpenImportedDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImportedDataToolStripMenuItem.Click
        Dim newfrm As New frmListOfStudentsAdmissionImportedFromXML

        With newfrm
            .ShowDialog()
        End With
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        Dim newfrm As New frmBackUpDatabase(ConnectionString)

        With newfrm
            .ShowDialog()
        End With
    End Sub
End Class