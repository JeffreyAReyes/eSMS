
Imports MySql.Data.MySqlClient

Public Class frmAddEditEmployee

    Private webcam As WebCam

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

    Dim intCurrentEmpID As Integer
    Public Property CurrentEmpID() As Integer
        Get
            Return intCurrentEmpID
        End Get
        Set(ByVal value As Integer)
            intCurrentEmpID = value
        End Set
    End Property
#End Region

#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewEmployee"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'IN IntWhat INTEGER(11), IN DepID INTEGER(11), IN ECode vARCHAR(20), IN ELast vARCHAR(100), 
                    'IN EFirst vARCHAR(100), IN EMiddle vARCHAR(100), IN EAddress vARCHAR(1000), IN ECity vARCHAR(500), 
                    'IN EGender vARCHAR(20), IN ECivil vARCHAR(20), IN EBirth DATE, IN ELand vARCHAR(20), IN ECell vaRCHAR(20), 
                    'IN EEMail vaRCHAR(100), IN EID INTEGER(11))
                    mycommand.Parameters.AddWithValue("IntWhat", 0)
                    mycommand.Parameters.AddWithValue("DepID", Me.cboDept.SelectedValue)
                    mycommand.Parameters.AddWithValue("ECode", Me.txtEmpCode.Text)
                    mycommand.Parameters.AddWithValue("ELast", Me.txtLastName.Text)
                    mycommand.Parameters.AddWithValue("EFirst", Me.txtFirstname.Text)
                    mycommand.Parameters.AddWithValue("EMiddle", Me.txtMiddleName.Text)
                    mycommand.Parameters.AddWithValue("EAddress", Me.txtAddress.Text)
                    mycommand.Parameters.AddWithValue("ECity", Me.txtCity.Text)
                    mycommand.Parameters.AddWithValue("EGender", Me.cboGender.Text)
                    mycommand.Parameters.AddWithValue("ECivil", Me.cboCivilStatus.Text)
                    mycommand.Parameters.AddWithValue("EBirth", Me.DateTimePicker1.Value.Date)
                    mycommand.Parameters.AddWithValue("ELand", Me.txtLandline.Text)
                    mycommand.Parameters.AddWithValue("ECell", Me.txtMobile.Text)
                    mycommand.Parameters.AddWithValue("EEMail", Me.txtEmail.Text)
                    mycommand.Parameters.AddWithValue("Encoder", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("EID", 0)

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

    Private Function ModifyEmployee() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewEmployee"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("IntWhat", 1)
                    mycommand.Parameters.AddWithValue("DepID", Me.cboDept.SelectedValue)
                    mycommand.Parameters.AddWithValue("ECode", Me.txtEmpCode.Text)
                    mycommand.Parameters.AddWithValue("ELast", Me.txtLastName.Text)
                    mycommand.Parameters.AddWithValue("EFirst", Me.txtFirstname.Text)
                    mycommand.Parameters.AddWithValue("EMiddle", Me.txtMiddleName.Text)
                    mycommand.Parameters.AddWithValue("EAddress", Me.txtAddress.Text)
                    mycommand.Parameters.AddWithValue("ECity", Me.txtCity.Text)
                    mycommand.Parameters.AddWithValue("EGender", Me.cboGender.Text)
                    mycommand.Parameters.AddWithValue("ECivil", Me.cboCivilStatus.Text)
                    mycommand.Parameters.AddWithValue("EBirth", Me.DateTimePicker1.Value.Date)
                    mycommand.Parameters.AddWithValue("ELand", Me.txtLandline.Text)
                    mycommand.Parameters.AddWithValue("ECell", Me.txtMobile.Text)
                    mycommand.Parameters.AddWithValue("EEMail", Me.txtEmail.Text)
                    mycommand.Parameters.AddWithValue("Encoder", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("EID", Me.CurrentEmpID)

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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyEmployee" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyEmployee" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Public Sub GetDeparmentsAllForCombo()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetDeparmentsAllForCombo", 4)
        Me.cboDept.DataSource = dtaTable
        Me.cboDept.DisplayMember = "DeptDescription"
        Me.cboDept.ValueMember = "DeptID"

    End Sub

#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        'If Me.cboGender.SelectedIndex < 0 Then
        '    'Me.cboGender.Focus()
        '    Me.ErrProve.SetError(Me.cboGender, "Please select employee gender.")
        '    VerifyData = False
        '    'Exit Function
        'End If

        VerifyData = True
        If Me.txtLastName.Text.Length <= 0 Then
            'Me.txtLastName.Focus()
            Me.ErrProve.SetError(Me.txtLastName, "Please enter employee last name.")
            VerifyData = False
            'Exit Function
        End If

        If Me.txtFirstname.Text.Length <= 0 Then
            'Me.txtFirstname.Focus()
            Me.ErrProve.SetError(Me.txtFirstname, "Please enter employee first name.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboGender.SelectedIndex < 0 Then
            'Me.cboGender.Focus()
            Me.ErrProve.SetError(Me.cboGender, "Please select employee gender.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboCivilStatus.SelectedIndex < 0 Then
            'Me.cboCivilStatus.Focus()
            Me.ErrProve.SetError(Me.cboCivilStatus, "Please select employee civil status.")
            VerifyData = False
            'Exit Function
        End If

        If Date.Today.Date.Year - Me.DateTimePicker1.Value.Date.Year <= 20 Then
            Me.ErrProve.SetError(Me.DateTimePicker1, "Please select valid employee birth date.")
            VerifyData = False
        End If

        If VerifyData = False Then
            VerifyData = False
        Else
            VerifyData = True
        End If

    End Function

    Private Sub LoadImageFromFile()

        Dim num1 As Integer = Me.PicBrowser.ShowDialog
        Dim strFileName As String = Me.PicBrowser.FileName

        If strFileName.Length > 0 Then

            Try
                Me.PicImage.Image = Image.FromFile(strFileName)

            Catch ex As Exception
                MessageBox.Show("An error occured loading picture.\r\n" + ex.ToString(), "System error.")
            End Try

        End If
       
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
        GetDeparmentsAllForCombo()
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
                MessageBox.Show("Done adding new employee.", "Add employee.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtLastName.Text
                Me.Close()
            Else
                Me.txtEmpCode.Focus()
            End If
        Else
            If Me.ModifyEmployee = True Then
                MessageBox.Show("Done updating employee.", "Modify employee.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtLastName.Text
                Me.Close()
            Else
                Me.txtEmpCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        'Me.txtLastName.Text = CapitalizeWords(Me.txtLastName.Text)
        'Me.txtLastName.SelectionStart = Me.txtLastName.Text.Length
    End Sub

    Private Sub txtFirstname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstname.TextChanged
        'Me.txtFirstname.Text = CapitalizeWords(Me.txtFirstname.Text)
        'Me.txtFirstname.SelectionStart = Me.txtFirstname.Text.Length
    End Sub

    Private Sub txtMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleName.TextChanged
        'Me.txtMiddleName.Text = CapitalizeWords(Me.txtMiddleName.Text)
        'Me.txtMiddleName.SelectionStart = Me.txtMiddleName.Text.Length
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        'Me.txtAddress.Text = CapitalizeWords(Me.txtAddress.Text)
        'Me.txtAddress.SelectionStart = Me.txtAddress.Text.Length
    End Sub

    Private Sub cmdLoadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadFromFile.Click
        LoadImageFromFile()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.PicImage.Image = Nothing
    End Sub

    Private Sub cmdCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapture.Click
        Dim newfrm As New frmCaptureImageFromCam

        With newfrm
            .ShowDialog()
            If .ThereIsImage = 1 Then
                Me.PicImage.Image = .ImageReturned
            End If
        End With
    End Sub
End Class