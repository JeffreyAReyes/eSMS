
Imports MySql.Data.MySqlClient

''' <summary>
''' Routines for database access layer.
''' June 14, 2012
''' </summary>
''' <remarks></remarks>
''' 

Module ModDataAccessLayer

    ''' <summary>
    ''' Procedure to retrieve data and return a data table
    ''' </summary>
    ''' <param name="connString">Database connection</param>
    ''' <param name="commText">Command text</param>
    ''' <param name="commType">Command type: 1=Text,4=SP, 512=TableDirect</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataAndReturnDataTable(ByVal connString As String, ByVal commText As String, ByVal commType As Integer) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTable")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTable")
        End Try

        Return collData

    End Function

    ''' <summary>
    ''' Retrieves data passing 1 parameter
    ''' </summary>
    ''' <param name="connString">Database connection</param>
    ''' <param name="commText">Command text</param>
    ''' <param name="commType">Command type: 1=Text,4=SP, 512=TableDirect</param>
    ''' <param name="strParameter">Name of the parameter</param>
    ''' <param name="strValue">value of the parameter</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataAndReturnDataTableWithOneParameter(ByVal connString As String, ByVal commText As String, ByVal commType As Integer, ByVal strParameter As Object, ByVal strValue As Object) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue(strParameter, strValue)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTable")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTable")
        End Try

        Return collData

    End Function


    Public Function GetDataAndReturnDataTableWithOneParameterByTermYear(ByVal connString As String, ByVal commText As String, _
        ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String, ByVal strParameter As Object, ByVal strValue As Object) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)
                    mycomm.Parameters.AddWithValue(strParameter, strValue)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableWithOneParameterByTermYear")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableWithOneParameterByTermYear")
        End Try

        Return collData

    End Function

    ''' <summary>
    ''' Procedure that retrieves data and return a dataset.
    ''' </summary>
    ''' <param name="connString">Database connectio</param>
    ''' <param name="commText">Command text</param>
    ''' <param name="commType">Command type: 1=Text,4=SP, 512=TableDirect</param>
    ''' <param name="strTerm">Current term</param>
    ''' <param name="strSchoolYear">current school year</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataAndReturnDataTableByTermYear(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableByTermYear")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableByTermYear")
        End Try

        Return collData

    End Function

    Public Function GetDataAndReturnDataTableByTermYearByBlock(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String, ByVal strBlockCode As String) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)
                    mycomm.Parameters.AddWithValue("BLCode", strBlockCode)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetStudentsAdmissionByTermYear")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetStudentsAdmissionByTermYear")
        End Try

        Return collData

    End Function

    Public Function GetDataAndReturnDataTableByTermYearByTeacherID(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String, ByVal intID As Integer) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)
                    mycomm.Parameters.AddWithValue("EmID", intID)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableByTermYearByTeacherID")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableByTermYearByTeacherID")
        End Try

        Return collData

    End Function

    Public Function GetDataAndReturnDataSetByTermYear(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String) As DataSet

        Dim collData As New DataSet
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSetByTermYear")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSetByTermYear")
        End Try

        Return collData

    End Function

    Public Function GetDataAndReturnDataSetByTermYearByEDP(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String, ByVal strEDP As String) As DataSet

        Dim collData As New DataSet
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)
                    mycomm.Parameters.AddWithValue("EDPNum", strEDP)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableByTermYearByEDP")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataTableByTermYearByEDP")
        End Try

        Return collData

    End Function

    Public Function GetStudentsAdmissionByTermYear(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetStudentsAdmissionByTermYear")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetStudentsAdmissionByTermYear")
        End Try

        Return collData

    End Function

    Public Function GetStudentsByEDPByLastByFirstByFull(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strSearchText As String, ByVal strSearchFor As String) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    'Last Name
                    'First Name
                    'Full Name
                    'EDP Number
                    Select Case strSearchFor
                        Case "Last Name"
                            mycomm.Parameters.AddWithValue("StrToSearch", strSearchText & "%")
                            mycomm.Parameters.AddWithValue("StrSearchBy", "Last")
                        Case "First Name"
                            mycomm.Parameters.AddWithValue("StrToSearch", strSearchText & "%")
                            mycomm.Parameters.AddWithValue("StrSearchBy", "First")
                        Case "Full Name"
                            mycomm.Parameters.AddWithValue("StrToSearch", strSearchText & "%")
                            mycomm.Parameters.AddWithValue("StrSearchBy", "Full")
                        Case "EDP Number"
                            mycomm.Parameters.AddWithValue("StrToSearch", "%" & strSearchText & "%")
                            mycomm.Parameters.AddWithValue("StrSearchBy", "EDP")
                    End Select

                   

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetStudentsAdmissionByTermYear")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetStudentsAdmissionByTermYear")
        End Try

        Return collData

    End Function

    Public Function GetDataAndReturnAString(ByVal connString As String, ByVal commText As String, _
               ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String) As String

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter
        Dim theobject As String = "0"

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                    For Each row As DataRow In collData.Rows
                        If IsDBNull(row(0)) = True Then
                            theobject = "0"
                        Else
                            theobject = row(0)
                            Exit For
                        End If
                    Next
                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnAnObject")
            theobject = "0"
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnAnObject")
            theobject = "0"
        End Try

        Return theobject

    End Function

    Public Function GetDataAndReturnDataSet(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer) As DataSet

        Dim collData As New DataSet
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    'mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    'mycomm.Parameters.AddWithValue("CYear", strSchoolYear)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSet")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSet")
        End Try

        Return collData

    End Function

    Public Function GetDataAndReturnDataSetTeachersLoad(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strTerm As String, ByVal strSchoolYear As String, ByVal intSectionCode As Integer) As DataSet

        Dim collData As New DataSet
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("CTerm", strTerm)
                    mycomm.Parameters.AddWithValue("CYear", strSchoolYear)
                    mycomm.Parameters.AddWithValue("CSectionCode", intSectionCode)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSet")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSet")
        End Try

        Return collData

    End Function
    Public Function GetDataAndReturnDataSetSearch(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer, ByVal strSearch As String) As DataTable

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("LName", strSearch)
                    'mycomm.Parameters.AddWithValue("CYear", strSchoolYear)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSetSearch")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSetSearch")
        End Try

        Return collData

    End Function

    ''' <summary>
    ''' Method to retrieve data from the database and return a date.
    ''' </summary>
    ''' <param name="connString"></param>
    ''' <param name="commText"></param>
    ''' <param name="commType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataAndReturnADate(ByVal connString As String, ByVal commText As String, _
               ByVal commType As Integer) As Date

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter
        Dim theobject As String = Date.Today.Date

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                    For Each row As DataRow In collData.Rows
                        If IsDBNull(row(0)) = True Then
                            theobject = Date.Today.Date
                        Else
                            theobject = row(0)
                            Exit For
                        End If
                    Next
                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnAnObject")
            theobject = Date.Today.Date
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnAnObject")
            theobject = Date.Today.Date
        End Try

        Return theobject

    End Function

    ''' <summary>
    ''' Method to determine if the software accessing the database is valid
    ''' June 14, 2012
    ''' Jeffrey A. Reyes
    ''' </summary>
    ''' <param name="connString"></param>
    ''' <param name="commText"></param>
    ''' <param name="commType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DetermineSoftwareVersionIsValid(ByVal connString As String, ByVal commText As String, _
                ByVal commType As Integer) As Boolean

        Dim collData As New DataTable
        Dim myadapter As New MySqlDataAdapter
        Dim boolReturn As Boolean

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    mycomm.Connection = myconn
                    mycomm.CommandText = commText
                    mycomm.CommandType = commType

                    mycomm.Parameters.AddWithValue("pAppName", My.Settings.AppName)
                    mycomm.Parameters.AddWithValue("pAppVersion", My.Settings.AppVersion)

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                    If collData.Rows.Count >= 0 Then
                        boolReturn = True
                    Else
                        boolReturn = False
                    End If
                End Using

            End Using

        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: DetermineSoftwareVersionIsValid")
            boolReturn = False
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: DetermineSoftwareVersionIsValid")
            boolReturn = False
        End Try

        Return boolReturn

    End Function

End Module
