
'Class for printing course offerings


Public Class ClassCourseOfferings

    Dim strSectionCode As String = ""
    Public Property SectionCode() As String
        Get
            Return strSectionCode
        End Get
        Set(ByVal value As String)
            strSectionCode = value
        End Set
    End Property

    Dim strSubjectCode As String = ""
    Public Property SubjectCode() As String
        Get
            Return strSubjectCode
        End Get
        Set(ByVal value As String)
            strSubjectCode = value
        End Set
    End Property

    Dim strDescTitle As String = ""
    Public Property DescTitle() As String
        Get
            Return strDescTitle
        End Get
        Set(ByVal value As String)
            strDescTitle = value
        End Set
    End Property

    Dim intUnits As Integer = 0
    Public Property SubjectUnits() As Integer
        Get
            Return intUnits
        End Get
        Set(ByVal value As Integer)
            intUnits = value
        End Set
    End Property

    Dim strTime1 As String = ""
    Public Property Time1() As String
        Get
            Return strTime1
        End Get
        Set(ByVal value As String)
            strTime1 = value
        End Set
    End Property

    Dim strDay1 As String = ""
    Public Property Day1() As String
        Get
            Return strDay1
        End Get
        Set(ByVal value As String)
            strDay1 = value
        End Set
    End Property

    Dim strRoom1 As String = ""
    Public Property Room1() As String
        Get
            Return strRoom1
        End Get
        Set(ByVal value As String)
            strRoom1 = value
        End Set
    End Property

    Dim strInstructor As String
    Public Property Instructor() As String
        Get
            Return strInstructor
        End Get
        Set(ByVal value As String)
            strInstructor = value
        End Set
    End Property

    Dim strBlockCode As String
    Public Property BlockCode() As String
        Get
            Return strBlockCode
        End Get
        Set(ByVal value As String)
            strBlockCode = value
        End Set
    End Property

End Class
