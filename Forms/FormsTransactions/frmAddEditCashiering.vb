

Imports MySql.Data.MySqlClient

Public Class frmAddEditCashiering

#Region "properties"

    Dim intCurrentID As Integer
    Public Property CurrentID() As Integer
        Get
            Return intCurrentID
        End Get
        Set(ByVal value As Integer)
            intCurrentID = value
        End Set
    End Property

    Dim boolIsAdding As Boolean
    Public Property IsAdding() As Boolean
        Get
            Return boolIsAdding
        End Get
        Set(ByVal value As Boolean)
            boolIsAdding = value
        End Set
    End Property
#End Region

#Region "Database"

    Private Function AddNewPayments() As Boolean
        Dim strSQL As String = "AddNewPayments"
        Dim boolReturn As Boolean

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'UName,UPass,UPriv,UWhole,UEntered,UModulesAllowed
                    mycommand.Parameters.AddWithValue("FeeID", Me.txtName.Text)
                    'mycommand.Parameters.AddWithValue("PaymentDate", Date.Today.Date)
                    mycommand.Parameters.AddWithValue("CRefNum", Me.txtOR.Text)
                    mycommand.Parameters.AddWithValue("CAmountGiven", Me.txtTendered.Text)
                    mycommand.Parameters.AddWithValue("CAmountPaid", Me.txtAmountPaid.Text)
                    mycommand.Parameters.AddWithValue("CReceivedBy", CurrentUserWholeName)
                    mycommand.Parameters.AddWithValue("CRemarks", "Payments")
                    mycommand.Parameters.AddWithValue("CTerm", CurrentTerm)
                    mycommand.Parameters.AddWithValue("CPayFor", Me.cboFor.Text)
                    mycommand.Parameters.AddWithValue("CSchoolYear", CurrentSchoolYear)
                    mycommand.Parameters.AddWithValue("CID", Me.CurrentID)
                    mycommand.Parameters.AddWithValue("CIntTrans", 1)

                    myconn.Open()
                    mycommand.ExecuteNonQuery()


                End Using
            End Using

            boolReturn = True

        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            Dim strErrMessage As String = ""

            With newfrm
                If ex.Message.Contains("Duplicate") Then
                    .ErrorMessage = "Login name already taken. Please try another login name."
                Else
                    .ErrorMessage = ex.Message
                End If

                .ErrorTrace = ex.Message & vbCrLf & "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            Dim strErrMessage As String = ""

            With newfrm
                If ex.Message.Contains("Duplicate") Then
                    .ErrorMessage = "Login name already taken. Please try another login name."
                Else
                    .ErrorMessage = ex.Message
                End If
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function


    Private Function AddNew() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewPayments"
        
        Dim mytrans As MySqlTransaction

        Try
            Using myconn As New MySqlConnection(ConnectionString)

                myconn.Open()
                mytrans = myconn.BeginTransaction

                Try
                    Using mycommand As New MySqlCommand
                        mycommand.Connection = myconn
                        mycommand.CommandType = CommandType.StoredProcedure
                        mycommand.CommandText = strSQL

                        'add parameters
                        'UName,UPass,UPriv,UWhole,UEntered,UModulesAllowed
                        mycommand.Parameters.AddWithValue("CStudentID", Me.txtEDP.Text)
                        'mycommand.Parameters.AddWithValue("PaymentDate", Date.Today.Date)
                        mycommand.Parameters.AddWithValue("CRefNum", Me.txtOR.Text)
                        mycommand.Parameters.AddWithValue("CAmountGiven", Me.txtTendered.Text)
                        mycommand.Parameters.AddWithValue("CAmountPaid", Me.txtAmountPaid.Text)
                        mycommand.Parameters.AddWithValue("CReceivedBy", CurrentUserWholeName)
                        mycommand.Parameters.AddWithValue("CRemarks", "Payments")
                        mycommand.Parameters.AddWithValue("CTerm", CurrentTerm)
                        mycommand.Parameters.AddWithValue("CPayFor", Me.cboFor.Text)
                        mycommand.Parameters.AddWithValue("CSchoolYear", CurrentSchoolYear)
                        mycommand.Parameters.AddWithValue("CID", Me.CurrentID)
                        mycommand.Parameters.AddWithValue("CIntTrans", 1)


                        mycommand.ExecuteNonQuery()

                    End Using

                    'Add payments details from datagridview
                    Dim strSQLDetails As String = "" _
                        & "INSERT INTO paymentsperstudentbysem " _
                        & "(Term,SchoolYear,FeeID,FeeTitle,Amount,Cashier,Remarks,PaymentDate,EDPNumber,ORNUmber) VALUES " _
                        & "(?Term,?SchoolYear,?FeeID,?FeeTitle,?Amount,?Cashier,?Remarks,?PaymentDate,?EDPNumber,?ORNUmber);" _
                        & "UPDATE studentchargespersemester SET " _
                        & "TotalPaid = TotalPaid + ?Amount WHERE EDPNumber = ?EDPNumber AND Term = ?Term AND " _
                        & "SchoolYear = ?SchoolYear AND FeeID = ?FeeID;"

                    Using mycommanddetails As New MySqlCommand
                        mycommanddetails.Connection = myconn
                        mycommanddetails.CommandText = strSQLDetails
                        mycommanddetails.CommandType = CommandType.Text

                        'add parameters
                        Dim Term, SchoolYear, FeeID, FeeTitle, Amount, Remarks, Cashier, PaymentDate, EDPNumber, ORNUmber As MySqlParameter

                        With mycommanddetails

                            FeeID = .Parameters.Add("?FeeID", MySqlDbType.Int32)
                            FeeTitle = .Parameters.Add("?FeeTitle", MySqlDbType.VarChar)
                            Amount = .Parameters.Add("?Amount", MySqlDbType.Decimal)
                            Term = .Parameters.Add("?Term", MySqlDbType.VarChar)
                            SchoolYear = .Parameters.Add("?SchoolYear", MySqlDbType.VarChar)
                            Remarks = .Parameters.Add("?Remarks", MySqlDbType.VarChar)
                            Cashier = .Parameters.Add("?Cashier", MySqlDbType.VarChar)
                            PaymentDate = .Parameters.Add("?PaymentDate", MySqlDbType.Date)
                            EDPNumber = .Parameters.Add("?EDPNumber", MySqlDbType.VarChar)
                            ORNUmber = .Parameters.Add("?ORNUmber", MySqlDbType.VarChar)

                            Term.Value = CurrentTerm
                            SchoolYear.Value = CurrentSchoolYear
                            Remarks.Value = "Payments"
                            Cashier.Value = CurrentSystemUser
                            PaymentDate.Value = Date.Today.Date
                            ORNUmber.Value = Me.txtOR.Text
                            EDPNumber.Value = Me.txtEDP.Text

                            For Each row As DataGridViewRow In Me.PaymentGrid.Rows
                                If row.IsNewRow = True Then

                                Else
                                    FeeID.Value = row.Cells(0).Value
                                    FeeTitle.Value = row.Cells(1).Value.ToString
                                    Amount.Value = row.Cells(5).Value

                                    .ExecuteNonQuery()

                                End If
                            Next

                        End With

                    End Using
                    mytrans.Commit()
                    boolReturn = True
                Catch ex As MySqlException
                    boolReturn = False
                    mytrans.Rollback()
                    Dim newfrm As New frmErrorMessageViewer
                    With newfrm
                        .ErrorMessage = ex.Message
                        .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                        .ErrorForHumans = "Cannot continue saving record because an error occured."
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    boolReturn = False
                    mytrans.Rollback()
                    Dim newfrm As New frmErrorMessageViewer
                    With newfrm
                        .ErrorMessage = ex.Message
                        .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                        .ErrorForHumans = "Cannot continue saving record because an error occured."
                        .ShowDialog()
                    End With

                End Try
                

            End Using



        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            Dim strErrMessage As String = ""

            With newfrm
                If ex.Message.Contains("Duplicate") Then
                    .ErrorMessage = "Login name already taken. Please try another login name."
                Else
                    .ErrorMessage = ex.Message
                End If

                .ErrorTrace = ex.Message & vbCrLf & "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            Dim strErrMessage As String = ""

            With newfrm
                If ex.Message.Contains("Duplicate") Then
                    .ErrorMessage = "Login name already taken. Please try another login name."
                Else
                    .ErrorMessage = ex.Message
                End If
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNew" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue adding new record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Private Function ModifySystemUser() As Boolean
        Dim boolReturn As Boolean
        Dim strSQL As String = "AddNewSystemUser"

        Try
            Using myconn As New MySqlConnection(ConnectionString)
                Using mycommand As New MySqlCommand
                    mycommand.Connection = myconn
                    mycommand.CommandType = CommandType.StoredProcedure
                    mycommand.CommandText = strSQL

                    'add parameters
                    'UName,UPass,UPriv,UWhole,UEntered,UModulesAllowed
                    mycommand.Parameters.AddWithValue("StudentID", Me.txtEDP.Text)
                    mycommand.Parameters.AddWithValue("PaymentDate", Date.Today.Date)
                    mycommand.Parameters.AddWithValue("RefNum", Me.txtOR.Text)
                    mycommand.Parameters.AddWithValue("AmountGiven", Me.txtTendered.Text)
                    mycommand.Parameters.AddWithValue("AmountPaid", Me.txtAmountPaid.Text)
                    mycommand.Parameters.AddWithValue("ReceivedBy", CurrentSystemUser)
                    mycommand.Parameters.AddWithValue("Remarks", "Cashiering")
                    mycommand.Parameters.AddWithValue("Term", CurrentTerm)
                    mycommand.Parameters.AddWithValue("SchoolYear", CurrentSchoolYear)

                    mycommand.Parameters.AddWithValue("PaymentId", Me.CurrentID)
                    myconn.Open()
                    mycommand.ExecuteNonQuery()

                    boolReturn = True
                End Using
            End Using
        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifySystemUser" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "ModifySystemUser" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue modifying record because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

    Public Function GetEnrollmentDetails(ByVal strEDP As String) As Boolean

        Dim boolResult As Boolean
        Dim dtaTable As New DataSet

        Try
            dtaTable = GetDataAndReturnDataSetByTermYearByEDP(ConnectionString, "GetEnrollmentDetails", 4, CurrentTerm, CurrentSchoolYear, strEDP)

            'get student details
            For Each row As DataRow In dtaTable.Tables(0).Rows
                Me.txtName.Text = row("StudentName").ToString
                If IsDBNull(row("CourseCode")) = True Then
                    Me.txtCourse.Text = ""
                Else
                    Me.txtCourse.Text = row("CourseCode").ToString
                End If
                If IsDBNull(row("DeptCode")) = True Then
                    Me.txtDept.Text = ""
                Else
                    Me.txtDept.Text = row("DeptCode").ToString
                End If
                If IsDBNull(row("Gender")) = True Then
                    Me.txtSex.Text = ""
                Else
                    Me.txtSex.Text = row("Gender").ToString
                End If
                'If IsDBNull(row("Degree")) = True Then
                '    Me.txtDegree.Text = ""
                'Else
                '    Me.txtDegree.Text = row("Degree").ToString
                'End If
            Next

            'get enrollment details, if any            
         
            boolResult = True
        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & " In GetEnrollmentDetails")
            boolResult = False
        End Try

        Return boolResult

    End Function

#End Region

#Region "Helper"

    Dim TheTableOfFees As New DataSet

    Private Sub GetSemestralFees()

        'Dim dtatable As New DataTable

        TheTableOfFees = GetDataAndReturnDataSetByTermYearByEDP(ConnectionString, "GetStudentChargesByEDPNumberBySem", 4, CurrentTerm, CurrentSchoolYear, Me.txtEDP.Text)
        AssigneFeeNamesIntoDataGridview(TheTableOfFees.Tables(0), Me.PaymentGrid)

    End Sub

    Private Sub AssigneFeeNamesIntoDataGridview(ByVal theDataOfFees As DataTable, ByVal theDatagridview As DataGridView)
        Try
            For Each row As DataRow In theDataOfFees.Rows
                With theDatagridview
                    .Rows.Add(row("FeeID"), row("FeeTitle"), row("AmountToBePaid"), row("TotalPaid"), _
                              row("AmountToBePaid") - row("TotalPaid"), 0.0, row("AmountToBePaid") - row("TotalPaid"))
                End With
            Next
        Catch ex As Exception
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & "In AssigneFeeNamesIntoDataGridview")
        End Try

    End Sub

    Private Function CalculateChange() As Decimal

        Dim decChange As Decimal = 0.0

        Dim decAmountPaid As Decimal = Me.txtAmountPaid.Text
        Dim decAmountTendered As Decimal = Me.txtTendered.Text

        decChange = decAmountTendered - decAmountPaid

        Return decChange

    End Function

    Private Sub ClearControls()
        Me.txtEDP.Clear()
        Me.txtAmountPaid.Text = 0.0
        Me.txtTendered.Text = 0.0
        Me.txtChange.Text = 0.0
        Me.txtEDP.Focus()
        Me.txtName.Clear()
        Me.txtYear.Clear()
        Me.txtSex.Clear()
        Me.txtStatus.Clear()
        Me.txtDept.Clear()
        Me.txtCourse.Clear()
        Me.cboFor.Focus()
        Me.PaymentGrid.Rows.Clear()
    End Sub

    ''' <summary>
    ''' Oct. 23, 2011
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PrintReceipt()

    End Sub

    Private Function GetTotalPaid(ByVal theGrid As DataGridView) As Decimal

        Dim decTotalPaid As Decimal = 0.0

        For Each row As DataGridViewRow In theGrid.Rows
            decTotalPaid = decTotalPaid + row.Cells(5).Value
        Next

        Return decTotalPaid

    End Function

    Private Function CalculateBalancePerRowAndRemainingBalance(ByVal theGrid As DataGridView) As Decimal

        Dim decRemainingBalance As Decimal = 0.0

        For Each row As DataGridViewRow In theGrid.Rows
            row.Cells(6).Value = row.Cells(4).Value - row.Cells(5).Value
            decRemainingBalance = decRemainingBalance + row.Cells(6).Value
        Next

        Return decRemainingBalance
    End Function

#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtAmountPaid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmountPaid.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtTendered.Focus()
        End Select
    End Sub

    Private Sub txtAmountPaid_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles txtAmountPaid.Layout

    End Sub

    Private Sub txtAmountPaid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountPaid.Leave
        Try
            Me.txtChange.Text = FormatNumber(CalculateChange, 2)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtAmountPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountPaid.TextChanged
        If IsNumeric(Me.txtAmountPaid.Text) = False Then
            Me.txtAmountPaid.Text = "0.00"
            Me.txtAmountPaid.Focus()
            Me.txtAmountPaid.SelectAll()
        End If

        Try
            Me.txtChange.Text = FormatNumber(CalculateChange, 2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTendered_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTendered.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtChange.Focus()
        End Select
    End Sub

    Private Sub txtTendered_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTendered.Leave
        Try
            Me.txtChange.Text = FormatNumber(CalculateChange, 2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTendered_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTendered.TextChanged
        If IsNumeric(Me.txtAmountPaid.Text) = False Then
            Me.txtAmountPaid.Text = "0.00"
            Me.txtAmountPaid.Focus()
            Me.txtAmountPaid.SelectAll()
        End If

        Try
            Me.txtChange.Text = FormatNumber(CalculateChange, 2)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmAddEditCashiering_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.cmdCancel.PerformClick()
            Case Keys.F2
                Me.cmdSave.PerformClick()
        End Select
    End Sub

    Private Sub txtEDP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDP.GotFocus
        Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
    End Sub

    Private Sub txtEDP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEDP.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                If Me.txtEDP.Text.Length <= 0 Then
                    Me.txtEDP.Text = My.Settings.SchoolCode & "-"
                    Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                    Me.txtEDP.Focus()

                End If
                Me.txtAmountPaid.Text = "0.00"
                Me.txtTendered.Text = "0.00"
                Me.txtName.Text = ""
                Me.txtOR.Text = ""
                Me.txtSex.Text = ""
                Me.txtStatus.Text = ""
                Me.PaymentGrid.Rows.Clear()
                If GetEnrollmentDetails(Me.txtEDP.Text) = True Then
                    Me.txtOR.Focus()
                    GetSemestralFees()
                Else
                    Me.txtEDP.Focus()
                    Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
                End If
        End Select

    End Sub

    Private Sub txtEDP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEDP.TextChanged
        If Me.txtEDP.Text.Length <= 0 Then
            Me.txtEDP.Text = My.Settings.SchoolCode & "-"
            Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
            Me.txtEDP.Focus()

        End If
        Me.txtAmountPaid.Text = "0.00"
        Me.txtTendered.Text = "0.00"
        Me.txtName.Text = ""
        Me.txtOR.Text = ""
        Me.txtSex.Text = ""
        Me.txtStatus.Text = ""
        Me.PaymentGrid.Rows.Clear()
    End Sub

    Private Sub cboFor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFor.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtEDP.Focus()
        End Select
    End Sub

    Private Sub cboFor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFor.SelectedIndexChanged
        Select Case cboFor.SelectedIndex
            Case 0
                Me.txtEDP.Enabled = True
                Me.txtEDP.Focus()
                Me.txtName.ReadOnly = True
            Case 1
                Me.txtEDP.Enabled = True
                Me.txtEDP.Focus()
                Me.txtName.ReadOnly = False
        End Select
    End Sub

    Private Sub txtOR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOR.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtAmountPaid.Focus()
        End Select
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Me.txtName.Text.Length <= 0 Then

            Me.txtEDP.Focus()
            Exit Sub
        End If

        If Me.cboFor.SelectedIndex < 0 Then
            Me.cboFor.Focus()
            Exit Sub
        End If

        If Me.txtOR.Text.Length <= 0 Then
            Me.txtOR.Focus()
            Exit Sub
        End If
        If CDec(Me.txtAmountPaid.Text) <= 0 Then
            Me.txtAmountPaid.Focus()
            Exit Sub
        End If
        If CDec(Me.txtTendered.Text) <= 0 Then
            Me.txtAmountPaid.Focus()
            Exit Sub
        End If

        If Me.AddNew = True Then
            MessageBox.Show("Done saving new payment.", "Payments.", MessageBoxButtons.OK)
            ClearControls()
        Else
            Me.txtEDP.Focus()
            Me.txtEDP.SelectionStart = Me.txtEDP.Text.Length
        End If
    End Sub

    Private Sub frmAddEditCashiering_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cboFor.SelectedIndex = 0
        Me.cboFor.Focus()
    End Sub

    Private Sub txtChange_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChange.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter

                Me.cmdSave.PerformClick()
        End Select
    End Sub

   
    Private Sub txtChange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChange.TextChanged

    End Sub

    Private Sub PaymentGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentGrid.CellContentClick

    End Sub

    Private Sub PaymentGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentGrid.CellDoubleClick
        Select Case e.ColumnIndex
            Case 4
                Me.PaymentGrid.CurrentRow.Cells(5).Value = Me.PaymentGrid.CurrentRow.Cells(4).Value
                Me.txtbalance.Text = CalculateBalancePerRowAndRemainingBalance(Me.PaymentGrid)
                Me.txtAmountPaid.Text = GetTotalPaid(Me.PaymentGrid)
        End Select
    End Sub

    Private Sub PaymentGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentGrid.CellEndEdit

        Me.txtbalance.Text = CalculateBalancePerRowAndRemainingBalance(Me.PaymentGrid)
        Me.txtAmountPaid.Text = GetTotalPaid(Me.PaymentGrid)
    End Sub
End Class