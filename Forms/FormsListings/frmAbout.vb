Public Class frmAbout

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.cmdCancel.PerformClick()
        End Select
    End Sub

    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "About " & My.Settings.AppTitle)
        Me.lblHeader.Values.Heading = "About " & My.Settings.AppTitle
    End Sub
End Class