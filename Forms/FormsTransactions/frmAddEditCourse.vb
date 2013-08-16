
Imports MySql.Data.MySqlClient

Public Class frmAddEditCourse

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

    Dim intCurrentDeptID As Integer
    Public Property CurrentDeptID() As Integer
        Get
            Return intCurrentDeptID
        End Get
        Set(ByVal value As Integer)
            intCurrentDeptID = value
        End Set
    End Property

#End Region

#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewCourse"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("DID", Me.cboDepartment.SelectedValue)
                    mycommand.Parameters.AddWithValue("CCode", Me.txtSubjectCode.Text)
                    mycommand.Parameters.AddWithValue("CDesc", Me.txtDescriptiveTitle.Text)
                    mycommand.Parameters.AddWithValue("GNum", Me.txtGRNum.Text)
                    mycommand.Parameters.AddWithValue("GYear", Me.txtGRYear.Text)
                    mycommand.Parameters.AddWithValue("Encoder", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("CDegree", Me.cboDegree.Text)

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

    Private Function ModifyCourse() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifyCourse"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("DID", Me.cboDepartment.SelectedValue)
                    mycommand.Parameters.AddWithValue("CCode", Me.txtSubjectCode.Text)
                    mycommand.Parameters.AddWithValue("CDesc", Me.txtDescriptiveTitle.Text)
                    mycommand.Parameters.AddWithValue("GNum", Me.txtGRNum.Text)
                    mycommand.Parameters.AddWithValue("GYear", Me.txtGRYear.Text)
                    mycommand.Parameters.AddWithValue("Encoder", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("CDegree", Me.cboDegree.Text)

                    mycommand.Parameters.AddWithValue("CID", Me.CurrentSujectID)

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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifySubject" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifySubject" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetDepatrmentsAll", 4)
        Me.cboDepartment.DataSource = dtaTable
        Me.cboDepartment.ValueMember = "DeptID"
        Me.cboDepartment.DisplayMember = "DeptCode"

    End Sub

#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        If Me.cboDepartment.SelectedIndex < 0 Then
            Me.cboDepartment.Focus()
            Me.ErrProve.SetError(Me.cboDepartment, "Please select department from the list.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtSubjectCode.Text.Length <= 0 Then
            Me.txtSubjectCode.Focus()
            Me.ErrProve.SetError(Me.txtSubjectCode, "Please enter course code.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtDescriptiveTitle.Text.Length <= 0 Then
            Me.txtDescriptiveTitle.Focus()
            Me.ErrProve.SetError(Me.txtDescriptiveTitle, "Please enter course.")
            VerifyData = False
            Exit Function
        End If

        If Me.cboDegree.SelectedIndex < 0 Then
            Me.cboDegree.Focus()
            Me.ErrProve.SetError(Me.cboDegree, "Please select degree from the list.")
            VerifyData = False
            Exit Function
        End If

        VerifyData = True
    End Function

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
        GetAllDepartments()
        Me.cboDepartment.SelectedValue = Me.CurrentDeptID
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
                MessageBox.Show("Done adding new program of study.", "Add program of study.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtSubjectCode.Text
                Me.Close()
            Else
                Me.txtSubjectCode.Focus()
            End If
        Else
            If Me.ModifyCourse = True Then
                MessageBox.Show("Done updating program of study.", "Modify program of study.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtSubjectCode.Text
                Me.Close()
            Else
                Me.txtSubjectCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescriptiveTitle.TextChanged
        'Me.txtDescriptiveTitle.Text = CapitalizeWords(Me.txtDescriptiveTitle.Text)
        'Me.txtDescriptiveTitle.SelectionStart = Me.txtDescriptiveTitle.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubjectCode.KeyUp
       
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectCode.TextChanged

    End Sub
End Class