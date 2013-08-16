
Imports MySql.Data.MySqlClient

Public Class frmAddEditSystemUsers

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

    Dim intCurrentUserID As Integer
    Public Property CurrentUserID() As Integer
        Get
            Return intCurrentUserID
        End Get
        Set(ByVal value As Integer)
            intCurrentUserID = value
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
        Dim strSQL As String = "AddNewSystemUser"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'UName,UPass,UPriv,UWhole,UEntered,UModulesAllowed
                    mycommand.Parameters.AddWithValue("UName", Me.txtLoginName.Text)
                    mycommand.Parameters.AddWithValue("UPass", Me.txtPassword.Text)
                    mycommand.Parameters.AddWithValue("UPriv", "User")
                    mycommand.Parameters.AddWithValue("UWhole", Me.txtFullname.Text)
                    mycommand.Parameters.AddWithValue("UEntered", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("UModulesAllowed", Me.cboModules.Text)
                    mycommand.Parameters.AddWithValue("ActionType", 0)
                    mycommand.Parameters.AddWithValue("DepID", Me.cboDept.SelectedValue)
                    mycommand.Parameters.AddWithValue("UID", 0)


                    myconn.Open()
                    mycommand.ExecuteNonQuery()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            Dim strErrMessage As String = ""

            With newfrm
                If ex.Message.Contains("Duplicate") Then
                    .ErrorMessage = "Login name already taken. Please try another login name."
                Else
                    .ErrorMessage = ex.Message
                End If

                .ErrorTrace = ex.Message & vbCrLf & "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            Dim strErrMessage As String = ""

            With newfrm
                If ex.Message.Contains("Duplicate") Then
                    .ErrorMessage = "Login name already taken. Please try another login name."
                Else
                    .ErrorMessage = ex.Message
                End If
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Private Function ModifySystemUser() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewSystemUser"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'UName,UPass,UPriv,UWhole,UEntered,UModulesAllowed
                    mycommand.Parameters.AddWithValue("UName", Me.txtLoginName.Text)
                    mycommand.Parameters.AddWithValue("UPass", Me.txtPassword.Text)
                    mycommand.Parameters.AddWithValue("UPriv", "User")
                    mycommand.Parameters.AddWithValue("UWhole", Me.txtFullname.Text)
                    mycommand.Parameters.AddWithValue("UEntered", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("UModulesAllowed", Me.cboModules.Text)
                    mycommand.Parameters.AddWithValue("ActionType", 1)
                    mycommand.Parameters.AddWithValue("DepID", Me.cboDept.SelectedValue)
                    mycommand.Parameters.AddWithValue("UID", Me.CurrentUserID)
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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifySystemUser" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifySystemUser" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function
#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        If Me.txtLoginName.Text.Length <= 0 Then
            Me.txtLoginName.Focus()
            Me.ErrProve.SetError(Me.txtLoginName, "Please enter department code.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtPassword.Text.Length <= 0 Then
            Me.txtPassword.Focus()
            Me.ErrProve.SetError(Me.txtPassword, "Please enter department.")
            VerifyData = False
            Exit Function
        End If

        If Me.cboModules.SelectedIndex < 0 Then
            Me.cboModules.Focus()
            Me.ErrProve.SetError(Me.cboModules, "Please select module allowed.")
            VerifyData = False
            Exit Function
        End If

        If Me.cboDept.SelectedIndex < 0 Then
            Me.cboDept.Focus()
            Me.ErrProve.SetError(Me.cboDept, "Please select login department.")
            VerifyData = False
            Exit Function
        End If

        VerifyData = True
    End Function

    Public Sub GetAllDepartments()
        Dim dtaTable As New DataTable

        Try
            dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetDepatrmentsAll", 4)

            With Me
                .cboDept.DataSource = dtaTable
                .cboDept.ValueMember = "DeptID"
                .cboDept.DisplayMember = "DeptDescription"

            End With
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

        GetAllDepartments()
        Me.cboDept.SelectedValue = Me.CurrentDeptID
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
                MessageBox.Show("Done adding new system login.", "Add system login.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtPassword.Text
                Me.Close()
            Else
                Me.txtLoginName.Focus()
            End If
        Else
            If Me.ModifySystemUser = True Then
                MessageBox.Show("Done updating system login.", "Modify system login.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtPassword.Text
                Me.Close()
            Else
                Me.txtLoginName.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        'Me.txtPassword.Text = CapitalizeWords(Me.txtPassword.Text)
        'Me.txtPassword.SelectionStart = Me.txtPassword.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoginName.KeyUp
        
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoginName.TextChanged

    End Sub
End Class