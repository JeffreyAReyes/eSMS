
Imports MySql.Data.MySqlClient

Public Class frmAddEditDiscountsCharges

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

    Dim strWhatToAdd As String
    Public Property WhatToAdd() As String
        Get
            Return strWhatToAdd
        End Get
        Set(ByVal value As String)
            strWhatToAdd = value
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
                    mycommand.Parameters.AddWithValue("DCode", Me.txtRemarks.Text)
                    mycommand.Parameters.AddWithValue("DName", Me.txtAmount.Text)
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
                    mycommand.Parameters.AddWithValue("DCode", Me.txtRemarks.Text)
                    mycommand.Parameters.AddWithValue("DName", Me.txtAmount.Text)
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

        If Me.cboStudents.SelectedIndex < 0 Then
            Me.cboStudents.Focus()
            Me.ErrProve.SetError(Me.cboStudents, "Please select student from the list.")
            VerifyData = False
            Exit Function
        End If

        If Me.txtRemarks.Text.Length <= 0 Then
            Me.txtRemarks.Focus()
            Me.ErrProve.SetError(Me.txtRemarks, "Please enter ref. num.")
            VerifyData = False
            Exit Function
        End If

        If CDec(Me.txtAmount.Text) <= 0.0 Then
            Me.txtAmount.Focus()
            Me.ErrProve.SetError(Me.txtAmount, "Please enter amount greater than zero.")
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
                MessageBox.Show("Done adding new record.", "Add Record.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtAmount.Text
                Me.Close()
            Else
                Me.txtRemarks.Focus()
            End If
        Else
            If Me.ModifyDepartment = True Then
                MessageBox.Show("Done updating Record.", "Modify Record.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtAmount.Text
                Me.Close()
            Else
                Me.txtRemarks.Focus()
            End If
        End If
    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtAmount.Focus()
        End Select
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks.TextChanged

    End Sub

    Private Sub txtAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Leave
        If IsNumeric(Me.txtAmount.Text) = False Then
            Me.txtAmount.Text = "0.00"
            Me.txtAmount.SelectAll()
            Me.txtAmount.Focus()
        End If

        Me.txtAmount.Text = FormatNumber(Me.txtAmount.Text, 2)
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        If IsNumeric(Me.txtAmount.Text) = False Then
            Me.txtAmount.Text = "0.00"
            Me.txtAmount.SelectAll()
            Me.txtAmount.Focus()
        End If
    End Sub
End Class