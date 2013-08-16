
Imports MySql.Data.MySqlClient

Public Class frmAddEditFeesName

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

    Dim intCurrentPrimaryKeyID As Integer
    Public Property CurrentPrimaryKeyID() As Integer
        Get
            Return intCurrentPrimaryKeyID
        End Get
        Set(ByVal value As Integer)
            intCurrentPrimaryKeyID = value
        End Set
    End Property

#End Region


#Region "Database"

    ''' <summary>
    ''' Method to add or modify fee name.
    ''' </summary>
    ''' <param name="intAction">The action to be performed: 0 = add new record, 1 = modify record </param>
    ''' <param name="intID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AddNewOrModify(ByVal intAction As Integer, ByVal intID As Integer) As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddModifyFeeName"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("CatName", Me.cboFeeCategory.Text)
                    mycommand.Parameters.AddWithValue("FName", Me.txtFeeName.Text)
                    mycommand.Parameters.AddWithValue("TheAction", intAction)
                    mycommand.Parameters.AddWithValue("FID", intID)

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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNewOrModify" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue requested operation because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNewOrModify" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue requested operation because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Private Function ModifyDepartment() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifyDepartment"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("DCode", Me.txtFeeName.Text)
                    mycommand.Parameters.AddWithValue("DName", Me.txtDescriptiveTitle.Text)
                    mycommand.Parameters.AddWithValue("Encoder", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("DID", Me.CurrentSujectID)

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
#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        If Me.cboFeeCategory.SelectedIndex < 0 Then
            Me.cboFeeCategory.Focus()
            Me.ErrProve.SetError(Me.cboFeeCategory, "Please select fee category from the list.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtFeeName.Text.Length <= 0 Then
            Me.txtFeeName.Focus()
            Me.ErrProve.SetError(Me.txtFeeName, "Please enter fee name.")
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
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.MustUpdate = False
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.VerifyData = False Then
            Exit Sub
        End If

        Me.txtFeeName.Text = CapitalizeWords(Me.txtFeeName.Text)

        If Me.IsAdding = True Then
            If Me.AddNewOrModify(0, 0) = True Then
                MessageBox.Show("Done adding new fee name.", "Add Fee Name.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtFeeName.Text
                Me.Close()
            Else
                Me.txtFeeName.Focus()
            End If
        Else
            If Me.AddNewOrModify(1, Me.CurrentPrimaryKeyID) = True Then
                MessageBox.Show("Done updating fee name.", "Modify Fee Name.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtFeeName.Text
                Me.Close()
            Else
                Me.txtFeeName.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescriptiveTitle.TextChanged
        Me.txtDescriptiveTitle.Text = CapitalizeWords(Me.txtDescriptiveTitle.Text)
        'Me.txtDescriptiveTitle.SelectionStart = Me.txtDescriptiveTitle.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFeeName.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtDescriptiveTitle.Focus()
        End Select
    End Sub

    Private Sub txtFeeName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFeeName.LostFocus
        Me.txtFeeName.Text = CapitalizeWords(Me.txtFeeName.Text)
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFeeName.TextChanged

    End Sub
End Class