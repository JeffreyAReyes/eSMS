Public Class frmTempSY

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        CurrentSchoolYear = Me.txtSY.Text
        CurrentTerm = Me.txtTerm.Text
    End Sub
End Class