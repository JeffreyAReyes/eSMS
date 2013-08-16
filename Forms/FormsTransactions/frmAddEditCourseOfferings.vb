
Imports MySql.Data.MySqlClient

Public Class frmAddEditCourseOfferings

    Dim dtaTable As New DataSet

#Region "Properties"

    Dim intCurrentSubjectID As Integer
    Public Property CurrentSujectID() As Integer
        Get
            Return intCurrentSubjectID
        End Get
        Set(ByVal value As Integer)
            intCurrentSubjectID = value
        End Set
    End Property

    Dim boolMustUpdate As Boolean
    Public Property MustUpdate() As Boolean
        Get
            Return boolMustUpdate
        End Get
        Set(ByVal value As Boolean)
            boolMustUpdate = value
        End Set
    End Property

    Dim boolIsAdding As Boolean
    Public Property IsAdding() As Boolean
        Get
            Return boolIsAdding
        End Get
        Set(ByVal value As Boolean)
            boolIsAdding = value
        End Set
    End Property

    Dim strHeader As String
    Public Property FormHeading() As String
        Get
            Return strHeader
        End Get
        Set(ByVal value As String)
            strHeader = value
        End Set
    End Property

    Dim strCurrentSearchString As String
    Public Property CurrentSearchString() As String
        Get
            Return strCurrentSearchString
        End Get
        Set(ByVal value As String)
            strCurrentSearchString = value
        End Set
    End Property

    Dim intCurrentEmployeeID As Integer
    Public Property CurrentEmployeeID() As Integer
        Get
            Return intCurrentEmployeeID
        End Get
        Set(ByVal value As Integer)
            intCurrentEmployeeID = value
        End Set
    End Property

    Dim intCurrentCourseOfferingID As Integer
    Public Property CurrentCourseOfferingID() As Integer
        Get
            Return intCurrentCourseOfferingID
        End Get
        Set(ByVal value As Integer)
            intCurrentCourseOfferingID = value
        End Set
    End Property

#End Region


#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewCourseOffering"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("SubID", Me.cboSubject.SelectedValue)
                    mycommand.Parameters.AddWithValue("SCode", Me.txtSubjectCode.Text)
                    mycommand.Parameters.AddWithValue("Trm", CurrentTerm)
                    mycommand.Parameters.AddWithValue("Sy", CurrentSchoolYear)
                    mycommand.Parameters.AddWithValue("SubCode", Me.txtSubCode.Text)
                    mycommand.Parameters.AddWithValue("DCode", 0)
                    mycommand.Parameters.AddWithValue("T1", Me.txtTime1.Text)
                    mycommand.Parameters.AddWithValue("D1", Me.txtDay1.Text)
                    mycommand.Parameters.AddWithValue("R1", Me.txtRoom1.Text)
                    mycommand.Parameters.AddWithValue("T2", Me.txtTime2.Text)
                    mycommand.Parameters.AddWithValue("D2", Me.txtDay2.Text)
                    mycommand.Parameters.AddWithValue("R2", Me.txtRoom2.Text)
                    mycommand.Parameters.AddWithValue("NUnits", Me.txtUnits.Text)
                    mycommand.Parameters.AddWithValue("InstID", Me.cboInstructor.SelectedValue)
                    mycommand.Parameters.AddWithValue("NumSeats", Me.txtSeats.Text)
                    mycommand.Parameters.AddWithValue("EncBy", CurrentSystemUser)

                    myconn.Open()
                    mycommand.ExecuteNonQuery()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Private Function ModifyCourseOffering() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifyCourseOffering"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("SubID", Me.cboSubject.SelectedValue)
                    mycommand.Parameters.AddWithValue("SCode", Me.txtSubjectCode.Text)
                    mycommand.Parameters.AddWithValue("Trm", CurrentTerm)
                    mycommand.Parameters.AddWithValue("Sy", CurrentSchoolYear)
                    mycommand.Parameters.AddWithValue("SubCode", Me.txtSubCode.Text)
                    mycommand.Parameters.AddWithValue("DCode", 0)
                    mycommand.Parameters.AddWithValue("T1", Me.txtTime1.Text)
                    mycommand.Parameters.AddWithValue("D1", Me.txtDay1.Text)
                    mycommand.Parameters.AddWithValue("R1", Me.txtRoom1.Text)
                    mycommand.Parameters.AddWithValue("T2", Me.txtTime2.Text)
                    mycommand.Parameters.AddWithValue("D2", Me.txtDay2.Text)
                    mycommand.Parameters.AddWithValue("R2", Me.txtRoom2.Text)
                    mycommand.Parameters.AddWithValue("NUnits", Me.txtUnits.Text)
                    mycommand.Parameters.AddWithValue("InstID", Me.cboInstructor.SelectedValue)
                    mycommand.Parameters.AddWithValue("NumSeats", Me.txtSeats.Text)
                    mycommand.Parameters.AddWithValue("EncBy", CurrentSystemUser)

                    mycommand.Parameters.AddWithValue("COID", Me.CurrentCourseOfferingID)

                    myconn.Open()
                    mycommand.ExecuteNonQuery()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyDepartment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyDepartment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Public Sub GetSubjectsEmployeesAll()


        dtaTable = GetDataAndReturnDataSet(ConnectionString, "LoadSubjectsAndEmployeesForCombo", 4)
        'Me.dvgList.DataSource = dtaTable
        'ArrangeDatagridView(Me.dvgList)
        Me.cboSubject.DataSource = dtaTable.Tables(0)
        Me.cboSubject.ValueMember = "SubjectID"
        Me.cboSubject.DisplayMember = "TheSubject"

        Me.cboInstructor.DataSource = dtaTable.Tables(1)
        Me.cboInstructor.ValueMember = "EmpID"
        Me.cboInstructor.DisplayMember = "TheEmployee"

    End Sub

    Public Sub GetLastCourseOfferingNumber()

        Dim theobject As String

        theobject = GetDataAndReturnAString(ConnectionString, "GetLastCourseOfferingsNumber", 4, CurrentTerm, CurrentSchoolYear)

        Me.txtSubjectCode.Text = theobject.ToString

    End Sub

#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        If Me.cboSubject.SelectedValue <= 0 Then
            Me.ErrProve.SetError(Me.cboSubject, "Please select subject from the list.")
            Me.cboSubject.Focus()
            VerifyData = False
            Exit Function
        End If

        If Me.txtTime1.Text.Length <= 0 Then
            Me.txtSubjectCode.Focus()
            Me.ErrProve.SetError(Me.txtSubjectCode, "Please enter time 1.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtDay1.Text.Length <= 0 Then
            Me.txtSubjectCode.Focus()
            Me.ErrProve.SetError(Me.txtSubjectCode, "Please enter day 1.")
            VerifyData = False
            Exit Function
        End If


        VerifyData = True
    End Function

    Private Sub SearchSubject(ByVal thetable As DataTable)
        Try
            For Each row As DataRow In thetable.Rows
                If row("SubjectID").ToString = Me.cboSubject.SelectedValue.ToString Then
                    Me.txtDescriptiveTitle.Text = row("DescriptiveTitle").ToString
                    Me.txtUnits.Text = row("NumOfUnits").ToString
                    Me.txtLabCode.Text = row("LabCode").ToString
                    Me.txtSubCode.Text = row("SubjectCode").ToString
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

    Private Sub frmAddEditDepartment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.cmdCancel.PerformClick()
            Case Keys.F2
                Me.cmdSave.PerformClick()
            Case Keys.Enter
                SendKeys.Send(vbTab)
        End Select
    End Sub

    Private Sub frmAddEditDepartment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, Me.FormHeading)
        Me.lblHeader.Values.Heading = Me.FormHeading

        'load all data
        GetSubjectsEmployeesAll()
        Me.cboSubject.SelectedValue = Me.CurrentSujectID
        Me.cboInstructor.SelectedValue = Me.CurrentEmployeeID

        If Me.IsAdding = True Then
            GetLastCourseOfferingNumber()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.MustUpdate = False
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.VerifyData = False Then
            Exit Sub
        End If

        If Me.IsAdding = True Then
            If Me.AddNew = True Then
                MessageBox.Show("Done adding new course offering.", "Add course offering.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtDescriptiveTitle.Text
                Me.Close()
            Else
                Me.txtSubjectCode.Focus()
            End If
        Else
            If Me.ModifyCourseOffering = True Then
                MessageBox.Show("Done updating course offering.", "Modify course offering.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtDescriptiveTitle.Text
                Me.Close()
            Else
                Me.txtSubjectCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescriptiveTitle.TextChanged
        Me.txtDescriptiveTitle.Text = CapitalizeWords(Me.txtDescriptiveTitle.Text)
        Me.txtDescriptiveTitle.SelectionStart = Me.txtDescriptiveTitle.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubjectCode.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtDescriptiveTitle.Focus()
        End Select
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectCode.TextChanged

    End Sub

    Private Sub cboSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubject.SelectedIndexChanged
        SearchSubject(dtaTable.Tables(0))
    End Sub

    Private Sub txtSeats_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeats.TextChanged
        If IsNumeric(Me.txtSeats.Text) = False Then
            Me.txtSeats.Text = 0
            Me.txtSeats.Focus()
            Me.txtSeats.SelectAll()
        End If
    End Sub
End Class