

''' <summary>
''' Class for printing class list by section code
''' </summary>
''' <remarks></remarks>
Public Class ClassSectionClassList

    Dim strEDPNumber As String
    Public Property EDPNumber() As String
        Get
            Return strEDPNumber
        End Get
        Set(ByVal value As String)
            strEDPNumber = value
        End Set
    End Property

    Dim strStudentName As String
    Public Property StudentName() As String
        Get
            Return strStudentName
        End Get
        Set(ByVal value As String)
            strStudentName = value
        End Set
    End Property

    Dim strCourse As String
    Public Property StudentCourse() As String
        Get
            Return strCourse
        End Get
        Set(ByVal value As String)
            strCourse = value
        End Set
    End Property

    Dim strYear As String
    Public Property StudentYear() As String
        Get
            Return strYear
        End Get
        Set(ByVal value As String)
            strYear = value
        End Set
    End Property

End Class
