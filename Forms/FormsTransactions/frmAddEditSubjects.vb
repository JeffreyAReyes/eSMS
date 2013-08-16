
Imports MySql.Data.MySqlClient

Public Class frmAddEditSubjects

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

#End Region


#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewSubject"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("SCode", Me.txtSubjectCode.Text)
                    mycommand.Parameters.AddWithValue("STitle", Me.txtDescriptiveTitle.Text)
                    mycommand.Parameters.AddWithValue("SUnits", CDec(Me.txtUnits.Text))
                    mycommand.Parameters.AddWithValue("SLectureHours", CDec(Me.txtHoursLecture.Text))
                    mycommand.Parameters.AddWithValue("SLabHours", CDec(Me.txtHoursLab.Text))
                    If Me.txtLabCode.Text = "0" Then
                        mycommand.Parameters.AddWithValue("SWithLab", 0)
                    Else
                        mycommand.Parameters.AddWithValue("SWithLab", 1)
                    End If
                    mycommand.Parameters.AddWithValue("SLabCode", Me.txtLabCode.Text)
                    mycommand.Parameters.AddWithValue("SEncoder", CurrentSystemUser)

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

    Private Function ModifySubject() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifySubject"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'add parameters
                    mycommand.Parameters.AddWithValue("SCode", Me.txtSubjectCode.Text)
                    mycommand.Parameters.AddWithValue("STitle", Me.txtDescriptiveTitle.Text)
                    mycommand.Parameters.AddWithValue("SUnits", CDec(Me.txtUnits.Text))
                    mycommand.Parameters.AddWithValue("SLectureHours", CDec(Me.txtHoursLecture.Text))
                    mycommand.Parameters.AddWithValue("SLabHours", CDec(Me.txtHoursLab.Text))
                    If Me.txtLabCode.Text = "0" Then
                        mycommand.Parameters.AddWithValue("SWithLab", 0)
                    Else
                        mycommand.Parameters.AddWithValue("SWithLab", 1)
                    End If
                    mycommand.Parameters.AddWithValue("SLabCode", Me.txtLabCode.Text)
                    mycommand.Parameters.AddWithValue("SEncoder", CurrentSystemUser)

                    mycommand.Parameters.AddWithValue("SID", Me.CurrentSujectID)

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
#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        If Me.txtSubjectCode.Text.Length <= 0 Then
            Me.txtSubjectCode.Focus()
            Me.ErrProve.SetError(Me.txtSubjectCode, "Please enter subject code.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtDescriptiveTitle.Text.Length <= 0 Then
            Me.txtDescriptiveTitle.Focus()
            Me.ErrProve.SetError(Me.txtDescriptiveTitle, "Please enter descriptive title.")
            VerifyData = False
            Exit Function
        End If

        If CDec(Me.txtUnits.Text) <= 0 Then
            Me.txtUnits.Focus()
            Me.txtUnits.SelectAll()
            Me.ErrProve.SetError(Me.txtUnits, "Please enter valid number of units.")
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

        If Me.IsAdding = True Then
            If Me.AddNew = True Then
                MessageBox.Show("Done adding new subject.", "Add subject.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtDescriptiveTitle.Text
                Me.Close()
            Else
                Me.txtSubjectCode.Focus()
            End If
        Else
            If Me.ModifySubject = True Then
                MessageBox.Show("Done updating subject.", "Modify subject.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtDescriptiveTitle.Text
                Me.Close()
            Else
                Me.txtSubjectCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescriptiveTitle.TextChanged
        ' Me.txtDescriptiveTitle.Text = CapitalizeWords(Me.txtDescriptiveTitle.Text)
        'Me.txtDescriptiveTitle.SelectionStart = Me.txtDescriptiveTitle.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubjectCode.KeyUp
        
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectCode.TextChanged

    End Sub

    Private Sub txtUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnits.TextChanged
        If IsNumeric(Me.txtUnits.Text) = False Then
            Me.txtUnits.Text = 3.0
            Me.txtUnits.Focus()
            Me.txtUnits.SelectAll()
        End If
    End Sub

    Private Sub txtHoursLecture_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoursLecture.TextChanged
        If IsNumeric(Me.txtHoursLecture.Text) = False Then
            Me.txtHoursLecture.Text = 3.0
            Me.txtHoursLecture.Focus()
            Me.txtHoursLecture.SelectAll()
        End If
    End Sub

    Private Sub txtHoursLab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoursLab.TextChanged
        If IsNumeric(Me.txtHoursLab.Text) = False Then
            Me.txtHoursLab.Text = 0.0
            Me.txtHoursLab.Focus()
            Me.txtHoursLab.SelectAll()
        End If
    End Sub

    Private Sub txtLabCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLabCode.TextChanged
        If Me.txtLabCode.Text.Length <= 0 Then
            Me.txtLabCode.Text = 0
            Me.txtLabCode.Focus()
            Me.txtLabCode.SelectAll()
        End If
    End Sub
End Class