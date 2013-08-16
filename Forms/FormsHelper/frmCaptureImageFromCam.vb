

Public Class frmCaptureImageFromCam

    Private webcam As New WebCam

#Region "Properties"

    Dim TheImage As Image
    Public Property ImageReturned() As Image
        Get
            Return TheImage
        End Get
        Set(ByVal value As Image)
            TheImage = value
        End Set
    End Property

    Dim intThereIsImage As Integer
    Public Property ThereIsImage() As Integer
        Get
            Return intThereIsImage
        End Get
        Set(ByVal value As Integer)
            intThereIsImage = value
        End Set
    End Property

#End Region

    Private Sub frmCaptureImageFromCam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            webcam.Stop()
            webcam = Nothing
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub frmCaptureImageFromCam_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        webcam = New WebCam()
        webcam.InitializeWebCam(imgCam)
        webcam.Start()
    End Sub

    Private Sub cmdCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapture.Click
        imgCaptured.Image = imgCam.Image
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        webcam.Stop()
        webcam = Nothing
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'save file
        If IsDBNull(Me.imgCaptured.Image) = True Then
            Me.ThereIsImage = 0
        Else
            Me.ThereIsImage = 1
            Me.ImageReturned = Me.imgCaptured.Image
        End If
        webcam.Stop()
        webcam = Nothing
        Me.Close()
    End Sub

End Class