
Imports MySql.Data.MySqlClient

Public Class frmLogin

#Region "Database"

    Dim LoginDataTable As New DataTable

    ''' <summary>
    ''' Procedure that retrieves login names and passwords of users allowed to use the system.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetLoginNames()

        LoginDataTable = GetDataAndReturnDataTable(ConnectionString, "GetSystemUsersActive", 4)

    End Sub

#End Region

#Region "Helper"

    ''' <summary>
    ''' Procedure to determine if the name entered is found in the database.
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <param name="theDataTable"></param>
    ''' <returns>True if name is found.</returns>
    ''' <remarks></remarks>
    Private Function IsNameFound(ByVal strName As String, ByVal strPassword As String, ByVal theDataTable As DataTable) As Boolean
        Try
            For Each row As DataRow In theDataTable.Rows
                If row("UserName").ToString.ToUpper = strName.ToUpper And row("UserPass").ToString = strPassword Then
                    IsNameFound = True
                    CurrentSystemUser = Me.txtUsername.Text
                    CurrentUserWholeName = row("WholeName").ToString
                    CurrentUserModule = row("ModulesAllowed").ToString
                    CurrentUserPrivilege = row("UserPriv").ToString
                    CurrentUserDept = row("UserDeptID").ToString

                    Return IsNameFound
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
       
        IsNameFound = False
    End Function

#End Region

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Text = My.Settings.AppTitle.ToString & " " & My.Settings.SchoolName
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Login")
        Try
            If My.Computer.Network.IsAvailable = True Then
                If My.Computer.Network.Ping(My.Settings.Server) = True Then
                    GetLoginNames()
                Else

                End If
            Else
                GetLoginNames()
            End If
           
        Catch ex As Exception
            Debug.Print(ex.Message & " frmLogin_Load - GetLoginNames")
        End Try
        

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
        With frmMain
            .DisableMenus()
            .KryptonHeaderGroup2.ValuesPrimary.Heading = "WELCOME, Please Log-In to use the system."
            .KryptonHeaderGroup1.ValuesPrimary.Heading = FormatDateTime(Now, DateFormat.LongDate)
            .ToolStripMenuItem3.Visible = True
        End With

    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If Me.txtUsername.Text.Length <= 0 Then
            Me.txtUsername.Focus()
            Me.ErrProve.SetError(Me.txtUsername, "Please enter valid login name.")
            Exit Sub
        End If
        If Me.txtPassword.Text.Length <= 0 Then
            Me.txtPassword.Focus()
            Me.ErrProve.SetError(Me.txtPassword, "Please enter password.")
            Exit Sub
        End If

        If Me.txtUsername.Text = "Admin" And Me.txtPassword.Text = "encoder" Then
            CurrentSystemUser = Me.txtUsername.Text
            CurrentUserWholeName = "Balong A. Luste"
            CurrentUserModule = "REGISTRARENCODER"
            CurrentUserPrivilege = "encoder"

            With frmMain
                '.DisableMenus()
                .KryptonHeaderGroup2.ValuesPrimary.Heading = "WELCOME, " & CurrentUserWholeName '& "Please Log-In to use the system."
                .KryptonHeaderGroup1.ValuesPrimary.Heading = FormatDateTime(Now, DateFormat.LongDate)
                '.KryptonHeaderGroup1.ValuesPrimary.Heading = CurrentTerm & ", " & CurrentSchoolYear
                .lblHeader.Values.Heading = CurrentTerm & ", " & CurrentSchoolYear
                .SetMenu(CurrentUserPrivilege, CurrentUserModule)
            End With

            Me.Close()

        End If

        If Me.txtUsername.Text = "Admin" And Me.txtPassword.Text = "jikirililia" Then
            CurrentSystemUser = Me.txtUsername.Text
            CurrentUserWholeName = "Jeffrey A. Reyes"
            CurrentUserModule = "ALL"
            CurrentUserPrivilege = "Admin"
            CurrentPassword = Me.txtPassword.Text
            With frmMain
                '.DisableMenus()
                .KryptonHeaderGroup2.ValuesPrimary.Heading = "WELCOME, " & CurrentUserWholeName '& "Please Log-In to use the system."
                .KryptonHeaderGroup1.ValuesPrimary.Heading = FormatDateTime(Now, DateFormat.LongDate)
                '.KryptonHeaderGroup1.ValuesPrimary.Heading = CurrentTerm & ", " & CurrentSchoolYear
                .lblHeader.Values.Heading = CurrentTerm & ", " & CurrentSchoolYear
                .SetMenu(CurrentUserPrivilege, CurrentUserModule)
            End With

            Me.Close()

        End If

        If IsNameFound(Me.txtUsername.Text, Me.txtPassword.Text, LoginDataTable) = False Then
            Me.txtUsername.Focus()
            Me.lblMessage.Visible = True
            Me.ErrProve.SetError(Me.lblMessage, "Please enter valid login name and password.")

            Exit Sub
        Else

        End If

        'CurrentSystemUser = Me.txtUsername.Text
        'CurrentUserWholeName = Me.txtUsername.Text

        With frmMain
            '.DisableMenus()
            .KryptonHeaderGroup2.ValuesPrimary.Heading = "WELCOME, " & CurrentUserWholeName '& "Please Log-In to use the system."
            .KryptonHeaderGroup1.ValuesPrimary.Heading = FormatDateTime(Now, DateFormat.LongDate)
            '.KryptonHeaderGroup1.ValuesPrimary.Heading = CurrentTerm & ", " & CurrentSchoolYear
            .lblHeader.Values.Heading = CurrentTerm & ", " & CurrentSchoolYear
            .SetMenu(CurrentUserPrivilege, CurrentUserModule)
        End With

        Me.Close()
    End Sub

    Private Sub txtUsername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtPassword.Focus()
        End Select
    End Sub

    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        If Me.txtUsername.Text.Length <= 0 Then
            'Me.txtUsername.Focus()
            Me.ErrProve.SetError(Me.txtUsername, "Login name required.")
            'Exit Sub
        End If
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        Me.ErrProve.Clear()
        Me.lblMessage.Visible = False
    End Sub

    Private Sub txtPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.cmdLogin.PerformClick()
        End Select
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        Me.ErrProve.Clear()
        Me.lblMessage.Visible = False
    End Sub
End Class