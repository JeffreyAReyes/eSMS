


Public Class frmSplash

#Region "Properties"


#End Region

#Region "Helper"

    Private Sub GetCurrentTermYear()
        Dim dtaTable As New DataTable

        Try
            dtaTable = GetDataAndReturnDataTable(ConnectionString, "GetCurrentScoolYear", 4)
            'Me.dvgList.DataSource = dtaTable
            'ArrangeDatagridView(Me.dvgList)

            For Each row As DataRow In dtaTable.Rows

                CurrentSchoolYear = row("SchoolYear").ToString
                CurrentTerm = row("Term").ToString

            Next
        Catch ex As Exception

        End Try
       
    End Sub

#End Region

#Region "Database"


#End Region

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Settings.AppTitle.ToString
        Me.ToolStripStatusLabel1.Text = My.Settings.AppTitle.ToString
        GetCurrentTermYear()
        Me.lblHeader.Values.Heading = My.Settings.SchoolName
        Me.lblHeader2.Values.Heading = CurrentTerm & ", " & CurrentSchoolYear
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static i As Integer = 0

        i = i + 1

        If i >= 5 Then
            frmMain.Show()
            Me.Close()
        End If
    End Sub
End Class
