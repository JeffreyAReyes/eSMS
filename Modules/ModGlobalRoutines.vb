

''' <summary>
''' Global procedures and functions used application-wide scope
''' </summary>
''' <remarks></remarks>
Module ModGlobalRoutines

    Public Function ConnectionString() As String

        Dim strConn As String = "server=valiant;user id=root;database=valiant;Password=jikiri;persist security info=True"

        Dim strHost As String
        Dim strDatabase As String
        Dim strPass As String
        Dim strName As String

        strHost = My.Settings.Server
        strDatabase = My.Settings.Database
        strPass = My.Settings.UserPass
        strName = My.Settings.UserID

        strConn = "server=" & strHost & ";" _
                & "user id=" & strName & ";" _
                & "Password=" & strPass & ";" _
                & "database=" & strDatabase & ";" _
                & "persist security info=True"

        'Return My.Settings.MySQLConnection
        Return strConn

    End Function

    ''' <summary>
    ''' Capitalize the first letter of each word in a string
    ''' </summary>
    ''' <param name="strTheString"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CapitalizeWords(ByVal strTheString As String) As String

        Dim cr As String
        Dim t As String
        Dim i
        cr = Chr(13) + Chr(10)
        t = strTheString  'the string
        If t <> "" Then
            Mid$(t, 1, 1) = UCase$(Mid$(t, 1, 1))
            For i = 1 To Len(t$) - 1
                If Mid$(t, i, 2) = cr Then Mid$(t$, i + 2, 1) = UCase$(Mid$(t, i + 2, 1))
                If Mid$(t, i, 1) = " " Then Mid$(t$, i + 1, 1) = UCase$(Mid$(t, i + 1, 1))
            Next
            CapitalizeWords = t
        End If
        CapitalizeWords = t

    End Function


    Public Function FirstDayOfTheMonth(Optional ByVal intHowManyPreviousMonths As Integer = 1)

        Dim strFirstDay As String = "01"
        Dim TheDate As Date

        Select Case intHowManyPreviousMonths
            Case 1
                TheDate = MonthName(Month(Date.Today.Date)) & "/" & strFirstDay & "/" & Date.Today.Year
            Case 2
                TheDate = MonthName(Month(Date.Today.Date) - 1) & "/" & strFirstDay & "/" & Date.Today.Year
        End Select

        Return TheDate

    End Function

    ''' <summary>
    ''' Procedure to write debug info in the output window
    ''' For debugging purposes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub WriteDebugInfo(ByVal ExceptionMessage As String, ByVal ExceptionStackTrace As String, ByVal NameOfForm As String, _
                              ByVal NameOfProcedure As String, ByVal ShowMessagebox As Boolean)

        Select Case ShowMessagebox
            Case True
                'show the error message in the messagebox
                MessageBox.Show(ExceptionMessage & vbCrLf & ExceptionStackTrace, "In " & NameOfForm & "." & NameOfProcedure, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case False
                'show only in the output window
                Debug.Print(ExceptionMessage & vbCrLf & ExceptionStackTrace & vbCrLf & "In " & NameOfForm & "." & NameOfProcedure)
        End Select
    End Sub

    ''' <summary>
    ''' Procedure that retrieves the current computer name.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetComputerName() As String

        Dim strComputerName As String = My.Settings.TerminalName

        Return strComputerName
    End Function

    ''' <summary>
    ''' Method that sets captions of a Krypton form header and footer controls
    ''' </summary>
    ''' <param name="TheForm"></param>
    ''' <param name="strHeader"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetWindowHeader(ByVal TheForm As ComponentFactory.Krypton.Toolkit.KryptonForm, ByVal strHeader As String) As String

        TheForm.TextExtra = My.Settings.AppTitle.ToString '& " " & My.Settings.SchoolName
        TheForm.Text = strHeader

        Return My.Settings.SchoolName.ToString

    End Function

    Public Sub SelectDatagridViewRow(ByVal e As System.Windows.Forms.MouseEventArgs, ByVal theDatagridview As DataGridView, ByVal contxt As ContextMenuStrip)

        If theDatagridview.RowCount <= 0 Then Exit Sub
        Dim nameofMenu As New ContextMenuStrip

        Dim info As DataGridView.HitTestInfo

        If e.Button = Windows.Forms.MouseButtons.Right Then
            'Clear all the previously selected rows

            For Each row As DataGridViewRow In theDatagridview.Rows
                row.Selected = False
            Next

            'Get the selected Row
            info = theDatagridview.HitTest(e.X, e.Y)
            If info.ColumnIndex < 0 Then Exit Sub
            If info.RowIndex < 0 Then Exit Sub
            'Set as selected

            theDatagridview.Rows(info.RowIndex).Selected = True
            theDatagridview.CurrentCell = theDatagridview(info.ColumnIndex, info.RowIndex)
            contxt.Show(theDatagridview, e.Location)
            'nameofMenu.Name = theDatagridview.ContextMenuStrip.Name
            'nameofMenu.Show()
        End If
    End Sub

    ''' <summary>
    ''' Procedure to search a datagridview.
    ''' </summary>
    ''' <param name="TheListControl">The datagridview to be searched.</param>
    ''' <param name="intColumn">The datagridview column to search for.</param>
    ''' <param name="StringToSearch">The text to be searched.</param>
    ''' <remarks></remarks>
    Public Sub SearchDatagridViewGlobal(ByVal TheListControl As DataGridView, ByVal intColumn As Integer, ByVal StringToSearch As String)

        Dim i As Integer = 0

        For i = 0 To TheListControl.Rows.Count - 1
            If TheListControl.Rows(i).Cells(intColumn).Value.ToString.StartsWith(StringToSearch, StringComparison.InvariantCultureIgnoreCase) Then
                TheListControl.Rows(i).Selected = True
                TheListControl.CurrentCell = TheListControl(intColumn, i)
                TheListControl.FirstDisplayedScrollingRowIndex = TheListControl.CurrentCell.RowIndex
                Exit Sub
            End If
        Next
    End Sub

    ''' <summary>
    ''' Add numbers to the datagridview row headers, for used in the cell painting event.
    ''' </summary>
    ''' <param name="TheDataGridView">The datagridview to be painted</param>
    ''' <param name="e"></param>
    ''' <param name="TheFont">The font for painting row numbers</param>
    ''' <remarks></remarks>
    Public Sub AddNumberingToTheDataGridView(ByVal TheDataGridView As DataGridView, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs, ByVal TheFont As Font)

        Dim StringFormat As New StringFormat
        StringFormat.Alignment = StringAlignment.Near
        'Check if the 
        ' current Cell Column to be painted is the RowHeader
        ' current Cell Row to be painted is a record row 
        ' current Cell Row to be painted is not the EOF Row
        ' tbl is the name of my Datatable that i bind with the Datagridview
        If e.ColumnIndex = -1 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < TheDataGridView.Rows.Count Then
            e.PaintBackground(e.ClipBounds, True)
            e.Graphics.DrawString((e.RowIndex + 1).ToString, TheFont, Brushes.Black, e.CellBounds, StringFormat)
            e.Handled = True
        End If

    End Sub


End Module
