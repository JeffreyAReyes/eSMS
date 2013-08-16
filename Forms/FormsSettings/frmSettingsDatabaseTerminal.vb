
Imports MySql.Data.MySqlClient

Public Class frmSettingsDatabaseTerminal

    Structure retVal
        Dim boolResult As Boolean
        Dim ex As String
    End Structure

#Region "Properties"

    Dim strHost As String
    Dim strDatabase As String
    Dim strPass As String
    Dim strName As String

    Public Property ServerHost() As String
        Get
            Return strHost
        End Get
        Set(ByVal value As String)
            strHost = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return strPass
        End Get
        Set(ByVal value As String)
            strPass = value
        End Set
    End Property

    Public Property Database() As String
        Get
            Return strDatabase
        End Get
        Set(ByVal value As String)
            strDatabase = value
        End Set
    End Property

#End Region

#Region "Helper"

    Private Function VerifyFields() As Boolean
        If Me.txtHost.Text.Length <= 0 Then
            Me.txtHost.Focus()
            Me.errprove.SetError(Me.txtHost, "Please enter server host.")
            VerifyFields = False
            Exit Function
        End If
        If Me.txtName.Text.Length <= 0 Then
            Me.txtName.Focus()
            Me.errprove.SetError(Me.txtName, "Please enter user name.")
            VerifyFields = False
            Exit Function
        End If
        If Me.txtPassword.Text.Length <= 0 Then
            Me.txtPassword.Focus()
            Me.errprove.SetError(Me.txtPassword, "Please enter password.")
            VerifyFields = False
            Exit Function
        End If
        VerifyFields = True
    End Function

    Private Function TestConnection() As retVal
        'Procedure to test database connection from settings supplied

        Dim boolResult As Boolean
        Dim retMessage As String

        Try
            Using myconn As New MySqlConnection(CreateConnectionString)
                myconn.Open()
                boolResult = True
                retMessage = "Connection successful."
            End Using
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message, "Database error.")
            retMessage = " Database error." & vbCrLf & ex.Message
            boolResult = False
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Application error.")
            retMessage = " Application error." & vbCrLf & ex.Message
            boolResult = False
        End Try

        Dim message As retVal

        message.boolResult = boolResult
        message.ex = retMessage

        Return message
    End Function

    Private Function CreateConnectionString() As String
        'Creates connection string from values supplied

        Dim strConn As String = ""

        strConn = "server=" & Me.txtHost.Text & ";" _
               & "user id=" & Me.txtName.Text & ";" _
               & "Password=" & Me.txtPassword.Text & ";" _
               & "database=" & Me.txtDatabase.Text & ";" _
               & "persist security info=True"

        Return strConn
    End Function

#End Region

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.VerifyFields = False Then Exit Sub

        'save settings
        My.Settings.Server = Me.txtHost.Text
        My.Settings.Database = Me.txtDatabase.Text
        My.Settings.UserPass = Me.txtPassword.Text
        My.Settings.UserID = Me.txtName.Text

        My.Settings.Save()
    End Sub

    Private Sub frmSettingsDatabaseTerminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ServerHost = My.Settings.Server
        Me.Database = My.Settings.Database
        'Me.Password = My.Settings.Password
        Me.UserName = My.Settings.UserID

        Me.txtHost.Text = Me.ServerHost
        Me.txtDatabase.Text = Me.Database
        Me.txtPassword.Text = Me.Password
        Me.txtName.Text = Me.UserName

        Me.Text = My.Settings.AppTitle.ToString
        Me.ToolStripStatusLabel1.Text = My.Settings.AppTitle.ToString
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        If Me.VerifyFields = False Then Exit Sub
        If Me.TestConnection.boolResult = False Then
            MessageBox.Show(TestConnection.ex, "eSMS Database server connection test.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(TestConnection.ex, "eSMS Database server connection test.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class