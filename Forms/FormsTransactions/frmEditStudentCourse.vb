
Imports MySql.Data.MySqlClient

Public Class frmEditStudentCourse

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

    Dim strEDPNumber As String
    Public Property EDPNumber() As String
        Get
            Return strEDPNumber
        End Get
        Set(ByVal value As String)
            strEDPNumber = value
        End Set
    End Property

    Dim intCurrentDeptID As Integer
    Public Property CurrentDeptID() As Integer
        Get
            Return intCurrentDeptID
        End Get
        Set(ByVal value As Integer)
            intCurrentDeptID = value
        End Set
    End Property

    Dim intCurrentCourseID As Integer
    Public Property CurrentCourseID() As Integer
        Get
            Return intCurrentCourseID
        End Get
        Set(ByVal value As Integer)
            intCurrentCourseID = value
        End Set
    End Property

    Dim strDeptDesc As String
    Public Property DeptDesc() As String
        Get
            Return strDeptDesc
        End Get
        Set(ByVal value As String)
            strDeptDesc = value
        End Set
    End Property

    Dim strCourseDegree As String
    Public Property CourseDegree() As String
        Get
            Return strCourseDegree
        End Get
        Set(ByVal value As String)
            strCourseDegree = value
        End Set
    End Property

#End Region


#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewDepartment"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("DCode", Me.txtDepartment.Text)
                    mycommand.Parameters.AddWithValue("DName", Me.txtDeptCode.Text)
                    mycommand.Parameters.AddWithValue("Encoder", CurrentSystemUser)

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

    Private Function ModifyCourseDepartment() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifyStudentCourseFromAdvisng"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("CCID", Me.cboCourses.SelectedValue)
                    mycommand.Parameters.AddWithValue("CCDID", Me.CurrentDeptID)
                    mycommand.Parameters.AddWithValue("EDPNum", Me.EDPNumber)

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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyCourseDepartment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyCourseDepartment" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Dim dtaTable As New DataTable

    Public Sub GetCoursesAll()

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetCoursesAll", 4)

        Me.cboCourses.DataSource = dtaTable
        Me.cboCourses.DisplayMember = "CourseCode"
        Me.cboCourses.ValueMember = "CourseID"

    End Sub

#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        If Me.cboCourses.SelectedIndex < 0 Then
            Me.cboCourses.Focus()
            Me.ErrProve.SetError(Me.cboCourses, "Please select student course.")
            VerifyData = False
            Exit Function
        End If

        VerifyData = True
    End Function

    Private Sub SetDeptCodeDeptID()
        For Each row As DataRow In dtaTable.Rows
            If row("CourseID").ToString = Me.cboCourses.SelectedValue.ToString Then
                Me.CurrentCourseID = row("CourseID")
                Me.CurrentDeptID = row("DeptID")
                Me.txtDepartment.Text = row("DeptDescription")
                Me.txtDeptCode.Text = row("DeptCode")
                Exit For
            End If
        Next
    End Sub
#End Region

    Private Sub frmAddEditDepartment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.cmdCancel.PerformClick()
            Case Keys.F2
                Me.cmdSave.PerformClick()
        End Select
    End Sub

    Private Sub frmAddEditDepartment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Set Student's Course")
        Me.lblHeader.Values.Heading = "Set Student's Course"

        GetCoursesAll()

        Me.cboCourses.SelectedIndex = -1
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
                MessageBox.Show("Done updating student course.", "Update student course.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtDeptCode.Text
                Me.Close()
            Else
                Me.txtDepartment.Focus()
            End If
        Else
            If Me.ModifyCourseDepartment = True Then
                MessageBox.Show("Done updating student course.", "Modify student course.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtDeptCode.Text
                Me.Close()
            Else
                Me.cboCourses.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptCode.TextChanged
        Me.txtDeptCode.Text = CapitalizeWords(Me.txtDeptCode.Text)
        'Me.txtDeptCode.SelectionStart = Me.txtDeptCode.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepartment.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtDeptCode.Focus()
        End Select
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartment.TextChanged

    End Sub

    Private Sub cboCourses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourses.SelectedIndexChanged
        Try
            SetDeptCodeDeptID()
        Catch ex As Exception

        End Try
    End Sub
End Class