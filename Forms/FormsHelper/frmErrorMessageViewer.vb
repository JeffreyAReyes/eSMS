


Public Class frmErrorMessageViewer

#Region "Properties"

    Dim strError As String
    Public Property ErrorMessage() As String
        Get
            Return strError
        End Get
        Set(ByVal value As String)
            strError = value
        End Set
    End Property

    Dim strTrace As String
    Public Property ErrorTrace() As String
        Get
            Return strTrace
        End Get
        Set(ByVal value As String)
            strTrace = value
        End Set
    End Property

    Dim strErrorForHumans As String
    Public Property ErrorForHumans() As String
        Get
            Return strErrorForHumans
        End Get
        Set(ByVal value As String)
            strErrorForHumans = value
        End Set
    End Property

#End Region
    Private Sub frmErrorMessageViewer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.cmdCancel.PerformClick()
        End Select
    End Sub

    Private Sub frmErrorMessageViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Error")
        Me.lblHeader.Values.Heading = Me.ErrorForHumans
        Me.rtfError.Text = Me.ErrorMessage
        Me.rtfTrace.Text = Me.ErrorTrace
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class