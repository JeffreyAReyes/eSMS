
Imports MySql.Data.MySqlClient

Public Class frmListOfPaymentsReceived

#Region "Database"

    Public Sub GetPaymentsDaily()
        Dim dtaTable As New DataTable

        dtaTable = GetDataAndReturnDataTableWithOneParameter(ConnectionString, "GetPaymentsDaily", 4, "CCashier", CurrentUserWholeName)
        Me.dvgList.DataSource = dtaTable
        ArrangeDatagridView(Me.dvgList)

    End Sub

#End Region

#Region "Helper"

    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False

                .Columns(1).HeaderText = "EDP Number"
                .Columns(2).HeaderText = "Date"
                .Columns(3).HeaderText = "Name"
                .Columns(4).HeaderText = "OR/Ref. Num"
                .Columns(5).HeaderText = "Amount Paid"
                .Columns(6).HeaderText = "Psy For"
                .Columns(7).HeaderText = "Received By"
                .Columns(8).HeaderText = "Remarks"

                .Columns(1).Width = "100"
                .Columns(2).Width = "100"
                .Columns(3).Width = "125"
                .Columns(4).Width = "125"

                .Columns(2).DefaultCellStyle.Format = "MMM/dd/yyyy"
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub CalcTotal()

        Dim decTotal As Decimal = 0.0

        Try
            For Each row As DataGridViewRow In Me.dvgList.Rows
                decTotal = decTotal + row.Cells(5).Value
            Next
        Catch ex As Exception

        End Try
        Me.txtTotal.Text = FormatNumber(decTotal, 2)
    End Sub

    Private Sub GenerateReport()

        Dim ListOfDailyPayments As New List(Of ClassDailyPayments)

        For Each row As DataGridViewRow In Me.dvgList.Rows
            If row.IsNewRow = True Then

            Else
                Dim newitem As New ClassDailyPayments

                With newitem

                    .AmountPaid = row.Cells(5).Value
                    .CashierName = row.Cells(7).Value.ToString
                    .EDPNumber = row.Cells(1).Value.ToString
                    .FeeTitle = row.Cells(6).Value.ToString
                    .NameOfPayee = row.Cells(3).Value.ToString
                    .PayFor = row.Cells(6).Value.ToString
                    .RefNumber = row.Cells(4).Value.ToString
                    
                    'add item to collection

                    ListOfDailyPayments.Add(newitem)

                End With
            End If
        Next

        Dim newfrm As New frmDailyCashiersReport

        With newfrm

            .DailyPaymentsList = ListOfDailyPayments
            .CashierName = CurrentUserWholeName

            .ShowDialog()

        End With
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmListOfDepartments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "List of Payments Received")
        'Me.Text = "List of Departments"
        Me.cmdRefresh.PerformClick()

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim newfrm As New frmAddEditDepartment

        With newfrm
            .IsAdding = True
            .FormHeading = "Add New Department"
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetPaymentsDaily()
        CalcTotal()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim newfrm As New frmAddEditDepartment

        With newfrm
            .IsAdding = False
            .FormHeading = "Modify Department"
            .CurrentSujectID = Me.dvgList.CurrentRow.Cells(0).Value
            .txtDescriptiveTitle.Text = Me.dvgList.CurrentRow.Cells(2).Value
            .txtSubjectCode.Text = Me.dvgList.CurrentRow.Cells(1).Value
            .ShowDialog()
            If .MustUpdate = True Then
                Me.cmdRefresh.PerformClick()
                Me.txtSearch.Text = .txtDescriptiveTitle.Text
            End If
        End With
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        
        GenerateReport()

    End Sub
End Class