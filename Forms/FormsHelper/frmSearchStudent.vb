
Imports MySql.Data.MySqlClient

Public Class frmSearchStudent

#Region "Properties"

    Dim boolHasSelected As Boolean
    Public Property HasSelected() As Boolean
        Get
            Return boolHasSelected
        End Get
        Set(ByVal value As Boolean)
            boolHasSelected = value
        End Set
    End Property

    Dim strEDPNumber As String
    Public Property EDPNumber() As String
        Get
            Return strEDPNumber
        End Get
        Set(ByVal value As String)
            strEDPNumber = value
        End Set
    End Property

#End Region

#Region "Database"

    Public Sub GetStudentsForSearch(ByVal strSearch As String, ByVal strSearchFor As String)
        Dim dtaTable As New DataTable

        dtaTable = GetStudentsByEDPByLastByFirstByFull(ConnectionString, "SearchStudents", 4, strSearch, strSearchFor)
        Me.dvgStudents.DataSource = dtaTable
        ArrangeDatagridView(Me.dvgStudents)

    End Sub

    Private Sub ArrangeDatagridView(ByVal TheGridView As DataGridView)
        Try
            With TheGridView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns(0).HeaderText = "EDP Number"
                .Columns(1).HeaderText = "Name"
                
                .Columns(0).Width = "115"                

                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception

        End Try

    End Sub
#End Region

    Private Sub frmSearchStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolStripStatusLabel1.Text = SetWindowHeader(Me, "Search Student")
        Me.cboSearchBy.SelectedIndex = 0
        Me.txtSearch.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.HasSelected = False
        Me.Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        GetStudentsForSearch(Me.txtSearch.Text, Me.cboSearchBy.Text)
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                If Me.txtSearch.Text.Length <= 0 Then
                    Me.txtSearch.Focus()
                    Exit Sub
                End If
                If Me.cboSearchBy.SelectedIndex < 0 Then
                    Me.cboSearchBy.Focus()
                    Exit Sub
                End If
                Me.cmdSearch.PerformClick()
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub cboSearchBy_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSearchBy.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                Me.txtSearch.Focus()
        End Select
    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.HasSelected = True
        Me.EDPNumber = Me.dvgStudents.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub

    Private Sub frmSearchStudent_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtSearch.Focus()
    End Sub
End Class