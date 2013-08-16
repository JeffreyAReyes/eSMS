


Public Class frmHelp

#Region "Properties"

    Dim strTopic As String = "Index"
    Public Property Topic() As String
        Get
            Return strTopic
        End Get
        Set(ByVal value As String)
            strTopic = value
        End Set
    End Property

    Dim intModule As Integer
    Public Property HelpModule() As Integer
        Get
            Return intModule
        End Get
        Set(ByVal value As Integer)
            intModule = value
        End Set
    End Property

#End Region

    Private Sub frmHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Help Contents - ") & My.Settings.AppTitle

        Me.WebHelp.Navigate(Application.StartupPath & "\Help\SMSReferenceManual.htm")

    End Sub

End Class