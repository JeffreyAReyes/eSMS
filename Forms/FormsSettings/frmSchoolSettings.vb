


Public Class frmSchoolSettings

    Private Sub frmSchoolSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Text = My.Settings.AppTitle.ToString
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Other Settings")

        'load settings
        Me.txtAddress.Text = My.Settings.SchoolAddress1.ToString
        Me.txtCity.Text = My.Settings.SchoolAddress2.ToString
        Me.txtSchoolname.Text = My.Settings.SchoolName.ToString
        Me.txtCode.Text = My.Settings.SchoolCode

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'save settings
        My.Settings.SchoolAddress1 = Me.txtAddress.Text
        My.Settings.SchoolAddress2 = Me.txtCity.Text
        My.Settings.SchoolName = Me.txtSchoolname.Text
        My.Settings.SchoolCode = Me.txtCode.Text

        My.Settings.Save()

    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        Me.txtAddress.Text = CapitalizeWords(Me.txtAddress.Text)
        Me.txtAddress.SelectionStart = Me.txtAddress.Text.Length
    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged
        Me.txtCity.Text = CapitalizeWords(Me.txtCity.Text)
        Me.txtCity.SelectionStart = Me.txtCity.Text.Length
    End Sub

    Private Sub txtSchoolname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSchoolname.TextChanged
        Me.txtSchoolname.Text = CapitalizeWords(Me.txtSchoolname.Text)
        Me.txtSchoolname.SelectionStart = Me.txtSchoolname.Text.Length
    End Sub
End Class