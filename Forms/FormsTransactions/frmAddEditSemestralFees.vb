
Imports MySql.Data.MySqlClient
Imports System.Transactions

Public Class frmAddEditSemestralFees

#Region "Database"

    Private Sub GetSemestralFees()

        Dim dtatable As New DataTable

        dtatable = GetDataAndReturnDataTableByTermYear(ConnectionString, "GetSemestralFees", 4, CurrentTerm, CurrentSchoolYear)

        'aasign datasource of the to the data controls
        Me.BindingSource1.DataSource = dtatable
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.dvgList.DataSource = Me.BindingSource1

        'set-up the datagridview
        ArrangeDatagridView(Me.dvgList)

    End Sub

    ''' <summary>
    ''' Method to add or modify semestral fee amount.
    ''' </summary>
    ''' <param name="intAction">The action to be performed: 0 = add new record, 1 = modify record </param>
    ''' <param name="intID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AddNewOrModify(ByVal intAction As Integer, ByVal intID As Integer, ByVal TheDataGridView As DataGridView) As Boolean

        Dim boolReturn As Boolean
        Dim strSQL As String = "AddModifySemestralFees"
        'Dim mytrans As MySqlTransaction

        Try
            Using scope As New TransactionScope
                Using myconn As New MySqlConnection(ConnectionString)
                    Using mycommand As New MySqlCommand
                        mycommand.Connection = myconn
                        mycommand.CommandType = CommandType.StoredProcedure
                        mycommand.CommandText = strSQL

                        'add parameters
                        Dim CFNID, TheAction, CTerm, CYear, CAmount, Encoder, CSFID As MySqlParameter

                        With mycommand

                            CFNID = .Parameters.Add("?CFNID", MySqlDbType.Int32)
                            TheAction = .Parameters.Add("?TheAction", MySqlDbType.Int32)
                            CTerm = .Parameters.Add("?CTerm", MySqlDbType.VarChar)
                            CYear = .Parameters.Add("?CYear", MySqlDbType.VarChar)
                            CAmount = .Parameters.Add("?CAmount", MySqlDbType.Decimal)
                            Encoder = .Parameters.Add("?Encoder", MySqlDbType.VarChar)
                            CSFID = .Parameters.Add("?CSFID", MySqlDbType.Int32)

                        End With

                        myconn.Open()

                        'iterate the datagridview 
                        For Each row As DataGridViewRow In TheDataGridView.Rows

                            CFNID.Value = row.Cells(0).Value
                            If row.Cells(4).Value = 0 Then
                                'we are adding
                                TheAction.Value = 0
                                CSFID.Value = 0
                            Else
                                'we are modifying
                                TheAction.Value = 1
                                CSFID.Value = row.Cells(4).Value
                            End If

                            CTerm.Value = CurrentTerm
                            CYear.Value = CurrentSchoolYear
                            CAmount.Value = row.Cells(3).Value
                            Encoder.Value = CurrentUserWholeName

                            mycommand.ExecuteNonQuery()

                        Next

                        boolReturn = True
                    End Using
                End Using

                scope.Complete()
                'boolReturn = True
            End Using

        Catch ex As MySqlException
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNewOrModify" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue requested operation because an error occured."
                .ShowDialog()
            End With

        Catch ex As Exception
            boolReturn = False
            Dim newfrm As New frmErrorMessageViewer
            With newfrm
                .ErrorMessage = ex.Message
                .ErrorTrace = "Module: " & Me.Name & vbCrLf & "Procedure: " & "AddNewOrModify" & vbCrLf & vbCrLf & ex.StackTrace
                .ErrorForHumans = "Cannot continue requested operation because an error occured."
                .ShowDialog()
            End With
        End Try

        Return boolReturn

    End Function

#End Region

#Region "Helper"

    ''' <summary>
    ''' Procedure to set-up datagridview after datasource is assigned
    ''' For beauty purposes.
    ''' Error handled by a catch-all try...catch, but no error messages will be emitted.
    ''' </summary>
    ''' <param name="TheGridView">The datagridview that will be set-up.</param>
    ''' <remarks></remarks>
    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Columns(4).Visible = False
                '.Columns(2).Visible = False

                .Columns(1).HeaderText = "Fee Category"
                .Columns(2).HeaderText = "Name of Fee"
                .Columns(3).HeaderText = "Amount"

                .Columns(1).Width = "125"
                .Columns(2).Width = "200"
                .Columns(3).Width = "100"

                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Format = "N2"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(1).DefaultCellStyle.BackColor = Color.Cornsilk
                .Columns(2).DefaultCellStyle.BackColor = Color.Cornsilk
                '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

            End With
        Catch ex As Exception

        End Try

    End Sub

    Public Function VerifyDataForDatagridview(ByVal TheDataGridView As DataGridView) As Boolean

        Dim boolResult As Boolean = True

        For Each Row As DataGridViewRow In TheDataGridView.Rows
            If Row.Cells(3).Value <= 0.0 Then
                Row.Cells(2).ErrorText = "Amount must be greater than zero."
                'Row.Selected = True
                boolResult = False
                'Exit Function
            Else
                Row.Cells(2).ErrorText = ""
            End If
        Next

        Return boolResult

    End Function

#End Region

#Region "Properties"

    Dim intHeight As Integer
    Public Property TheHeight() As Integer
        Get
            Return intHeight
        End Get
        Set(ByVal value As Integer)
            intHeight = value
        End Set
    End Property

    Dim intWidth As Integer
    Public Property TheWidth() As Integer
        Get
            Return intWidth
        End Get
        Set(ByVal value As Integer)
            intWidth = value
        End Set
    End Property

#End Region

    Private Sub frmAddEditSemestralFees_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.cmdCancel.PerformClick()
            Case Keys.F2
                Me.cmdSave.PerformClick()
        End Select
    End Sub

    Private Sub frmAddEditSemestralFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Semestral Fees - " & CurrentTerm & ", " & CurrentSchoolYear)
        Me.lblHeader.Values.Heading = "Semestral Fees - " & CurrentTerm & ", " & CurrentSchoolYear

        Me.cmdRefresh.PerformClick()

        Me.Height = TheHeight
        Me.Width = TheWidth - 500

        'center form
        Me.Top = Screen.PrimaryScreen.WorkingArea.Top / 2
        Me.Left = Screen.PrimaryScreen.WorkingArea.Left / 2

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetSemestralFees()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If VerifyDataForDatagridview(Me.dvgList) = False Then
            Exit Sub
        End If

        If Me.AddNewOrModify(0, 0, Me.dvgList) = True Then
            MessageBox.Show("Done saving semestral fees.", "Semestral fees.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub dvgList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgList.CellEndEdit
        Select Case e.ColumnIndex
            Case 3
                If Me.dvgList.CurrentRow.Cells(3).Value <= 0.0 Then
                    Me.dvgList.CurrentRow.Cells(2).ErrorText = "Amount must be greater than zero."
                Else
                    Me.dvgList.CurrentRow.Cells(2).ErrorText = ""
                End If

        End Select
    End Sub

End Class