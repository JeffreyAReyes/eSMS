


Public Class frmDailyCashiersReport

#Region "Properties"

    Dim TheList As List(Of ClassDailyPayments)
    Public Property DailyPaymentsList() As List(Of ClassDailyPayments)
        Get
            Return TheList
        End Get
        Set(ByVal value As List(Of ClassDailyPayments))
            TheList = value
        End Set
    End Property

    Dim strCashierName As String
    Public Property CashierName() As String
        Get
            Return strCashierName
        End Get
        Set(ByVal value As String)
            strCashierName = value
        End Set
    End Property

#End Region

    Private Sub frmDailyCashiersReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Daily Cashier's Report")

        'assign report parameters
        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("Cashier", Me.CashierName, True))
        

        Me.ReportViewer1.LocalReport.SetParameters(paramList)

        'show report
        Me.ClassDailyPaymentsBindingSource.DataSource = Me.TheList
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class