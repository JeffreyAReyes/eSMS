
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class frmAddEditAdmission

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

    Dim intCurrentCourseID As Integer
    Public Property CurrentCOurseID() As Integer
        Get
            Return intCurrentCourseID
        End Get
        Set(ByVal value As Integer)
            intCurrentCourseID = value
        End Set
    End Property

    Dim intCurrentStudeID As Integer
    Public Property CurrentStudeID() As Integer
        Get
            Return intCurrentStudeID
        End Get
        Set(ByVal value As Integer)
            intCurrentStudeID = value
        End Set
    End Property

    Dim boolIsViewing As Boolean
    Public Property IsViewing() As Boolean
        Get
            Return boolIsViewing
        End Get
        Set(ByVal value As Boolean)
            boolIsViewing = value
        End Set
    End Property
#End Region


#Region "Database"

    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewAdmission"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("EDPNum", Me.txtEDPNumber.Text)
                    mycommand.Parameters.AddWithValue("CCID", Me.cboCourse.SelectedValue)
                    mycommand.Parameters.AddWithValue("CDID", 0)
                    mycommand.Parameters.AddWithValue("LName", Me.txtLastName.Text)
                    mycommand.Parameters.AddWithValue("FName", Me.txtFirstName.Text)
                    mycommand.Parameters.AddWithValue("MName", Me.txtMiddle.Text)
                    mycommand.Parameters.AddWithValue("CStatus", Me.cboCivilStatus.Text)
                    mycommand.Parameters.AddWithValue("Gend", Me.cboGender.Text)
                    mycommand.Parameters.AddWithValue("BDate", Me.dtpBirth.Value.Date)
                    mycommand.Parameters.AddWithValue("PAddress", Me.txtPAddress.Text)
                    mycommand.Parameters.AddWithValue("HAddress", Me.txtHAdress.Text)
                    mycommand.Parameters.AddWithValue("TAdmit", CurrentTerm)
                    mycommand.Parameters.AddWithValue("SYAdmit", CurrentSchoolYear)
                    mycommand.Parameters.AddWithValue("AdBy", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("CSchoolCode", My.Settings.SchoolCode)
                    mycommand.Parameters.AddWithValue("CContactPerson", Me.txtContactPersonName.Text)
                    mycommand.Parameters.AddWithValue("CContactPersonNumber", Me.txtContactPersonNumber.Text)

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

    Private Function ModifyAdmission() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "ModifyAdmission"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'add parameters
                    'mycommand.Parameters.AddWithValue("EDPNum", Me.txtEDPNumber.Text)
                    mycommand.Parameters.AddWithValue("CCID", Me.cboCourse.SelectedValue)
                    mycommand.Parameters.AddWithValue("CDID", 0)
                    mycommand.Parameters.AddWithValue("EDPNum", Me.txtEDPNumber.Text)
                    mycommand.Parameters.AddWithValue("LName", Me.txtLastName.Text)
                    mycommand.Parameters.AddWithValue("FName", Me.txtFirstName.Text)
                    mycommand.Parameters.AddWithValue("MName", Me.txtMiddle.Text)
                    mycommand.Parameters.AddWithValue("CStatus", Me.cboCivilStatus.Text)
                    mycommand.Parameters.AddWithValue("Gend", Me.cboGender.Text)
                    mycommand.Parameters.AddWithValue("BDate", Me.dtpBirth.Value.Date)
                    mycommand.Parameters.AddWithValue("PAddress", Me.txtPAddress.Text)
                    mycommand.Parameters.AddWithValue("HAddress", Me.txtHAdress.Text)
                    mycommand.Parameters.AddWithValue("TAdmit", CurrentTerm)
                    mycommand.Parameters.AddWithValue("SYAdmit", CurrentSchoolYear)
                    mycommand.Parameters.AddWithValue("AdBy", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("CSchoolCode", My.Settings.SchoolCode)
                    mycommand.Parameters.AddWithValue("CContactPerson", Me.txtContactPersonName.Text)
                    mycommand.Parameters.AddWithValue("CContactPersonNumber", Me.txtContactPersonNumber.Text)

                    mycommand.Parameters.AddWithValue("SSID", Me.CurrentStudeID)

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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyAdmission" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifyAdmission" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Public Sub GetCoursesAll()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetCoursesAll", 4)
        Me.cboCourse.DataSource = dtaTable
        Me.cboCourse.ValueMember = "CourseID"
        Me.cboCourse.DisplayMember = "CourseCode"

    End Sub

    Private Function SaveImageToDB(ByVal thePicBox As PictureBox, ByVal theEDPNumber As String) As Boolean

        If thePicBox.Image Is Nothing Then Exit Function

        Dim boolReturn As Boolean
        Dim strSQL As String = "UPDATE students SET StudeImage = ?BLOBData WHERE EDPNumber = ?EDPNumber"

        Dim ms As MemoryStream = New MemoryStream

        Try
            thePicBox.Image.Save(ms, ImageFormat.Jpeg)
        Catch ex As Exception

        End Try


        Dim bytBLOBData(ms.Length - 1) As Byte

        ms.Position = 0
        ms.Read(bytBLOBData, 0, ms.Length)

        Dim prm As New MySql.Data.MySqlClient.MySqlParameter("?BLOBData", _
                MySql.Data.MySqlClient.MySqlDbType.Blob, _
                bytBLOBData.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytBLOBData)

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.Text
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.Add(prm)
                    mycommand.Parameters.AddWithValue("EDPNumber", theEDPNumber)

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
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveImageToDB" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot save picture because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "SaveImageToDB" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot save picture because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn
    End Function

    Private Function RetrieveImageToPictureBox(ByVal thePicBox As PictureBox, ByVal theEDPNumber As String) As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "SELECT StudeImage FROM students WHERE EDPNumber = ?EDPNumber"

        Dim Data As DataTable

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.Text
                    mycommand.CommandText = strSQL

                    'add parameters
                    mycommand.Parameters.AddWithValue("EDPNumber", theEDPNumber)

                    myconn.Open()

                    Dim adapter As New MySqlDataAdapter
                    adapter.SelectCommand = mycommand

                    Data = New DataTable

                    adapter.Fill(Data)

                    Dim lb() As Byte = Data.Rows(0).Item("StudeImage")
                    Dim lstr As New System.IO.MemoryStream(lb)
                    thePicBox.Image = Image.FromStream(lstr)
                    'thePicBox.SizeMode = PictureBoxSizeMode.StretchImage
                    lstr.Close()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "RetrieveImageToPictureBox" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot retrieve picture because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "RetrieveImageToPictureBox" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot retrieve picture because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn
    End Function

#End Region

#Region "Helper"

    Public Function VerifyData() As Boolean

        VerifyData = True

        If Me.txtLastName.Text.Length <= 0 Then
            'Me.txtLastName.Focus()
            Me.ErrProve.SetError(Me.txtLastName, "Please enter last name.")
            VerifyData = False
            'Exit Function        
        End If

        If Me.txtFirstName.Text.Length <= 0 Then
            'Me.txtFirstName.Focus()
            Me.ErrProve.SetError(Me.txtFirstName, "Please enter first name.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboGender.Text <> "Male" And Me.cboGender.Text <> "Female" Then
            'Me.cboGender.Focus()
            Me.ErrProve.SetError(Me.cboGender, "Please select gender from the list.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboCivilStatus.Text.Length <= 0 Then
            'Me.cboCivilStatus.Focus()
            Me.ErrProve.SetError(Me.cboCivilStatus, "Please select Civil Status from the list.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboCivilStatus.SelectedValue < 0 Then
            'Me.cboCivilStatus.Focus()
            Me.ErrProve.SetError(Me.cboCivilStatus, "Please select Civil Status from the list.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboCourse.Text.Length <= 0 Then
            'Me.cboCivilStatus.Focus()
            Me.ErrProve.SetError(Me.cboCourse, "Please select Course from the list.")
            VerifyData = False
            'Exit Function
        End If

        If Me.cboCourse.SelectedValue < 0 Then
            'Me.cboCivilStatus.Focus()
            Me.ErrProve.SetError(Me.cboCourse, "Please select Course from the list.")
            VerifyData = False
            'Exit Function
        End If

        If VerifyData = False Then
            VerifyData = False
            Me.txtLastName.Focus()
        Else
            VerifyData = True
        End If

        'Return VerifyData

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

        GetCoursesAll()

        If Me.IsAdding = True Then
            Me.cboCourse.SelectedIndex = -1
        Else
            Me.cboCourse.SelectedValue = Me.CurrentCOurseID
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.MustUpdate = False
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Me.ErrProve.Clear()

        If Me.VerifyData = False Then
            Exit Sub
        End If

        If Me.IsAdding = True Then
            If Me.AddNew = True Then
                MessageBox.Show("Done adding new admission." & vbCrLf & _
                                "" & "", "Add admission.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtLastName.Text
                Me.Close()
            Else
                Me.txtEDPNumber.Focus()
            End If
        Else
            If Me.ModifyAdmission = True Then
                SaveImageToDB(Me.PicImage, Me.txtEDPNumber.Text)
                MessageBox.Show("Done updating admission.", "Modify admission.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MustUpdate = True
                Me.CurrentSearchString = Me.txtLastName.Text
                Me.Close()
            Else
                Me.txtEDPNumber.Focus()
            End If
        End If
    End Sub

    Private Sub txtLastName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastName.LostFocus
        Me.txtLastName.Text = CapitalizeWords(Me.txtLastName.Text)
    End Sub

    Private Sub txtDescriptiveTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        'Me.txtLastName.Text = CapitalizeWords(Me.txtLastName.Text)
        'Me.txtLastName.SelectionStart = Me.txtLastName.Text.Length

    End Sub

    Private Sub txtSubjectCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEDPNumber.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtLastName.Focus()
        End Select
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEDPNumber.TextChanged

    End Sub

    Private Sub txtFirstName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstName.LostFocus
        Me.txtFirstName.Text = CapitalizeWords(Me.txtFirstName.Text)
    End Sub

    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtMiddle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMiddle.LostFocus
        Me.txtMiddle.Text = CapitalizeWords(Me.txtMiddle.Text)
    End Sub

    Private Sub txtPAddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPAddress.Leave
        Me.txtPAddress.Text = CapitalizeWords(Me.txtPAddress.Text)
    End Sub

    Private Sub txtPAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPAddress.TextChanged

    End Sub

    Private Sub txtHAdress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHAdress.Leave
        Me.txtHAdress.Text = CapitalizeWords(Me.txtHAdress.Text)
    End Sub

    Private Sub cmdLoadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadFromFile.Click

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

    Private Sub txtContactPersonName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPersonName.Leave
        Me.txtContactPersonName.Text = CapitalizeWords(Me.txtContactPersonName.Text)
    End Sub

    Private Sub cboCivilStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCivilStatus.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.PicImage.Image = Nothing
    End Sub

    Private Sub frmAddEditAdmission_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Me.IsViewing = True Then

        Else
            If Me.IsAdding = True Then

            Else
                RetrieveImageToPictureBox(Me.PicImage, Me.txtEDPNumber.Text)
            End If
        End If

    End Sub

    Private Sub CopyPictureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPictureToolStripMenuItem.Click
        Try
            Clipboard.SetImage(Me.PicImage.Image)
        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & " In CopyPictureToolStripMenuItem_Click")
        End Try
    End Sub
End Class