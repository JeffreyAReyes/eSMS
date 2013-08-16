

''' <summary>
''' Class for printing faculty load.
''' </summary>
''' <remarks></remarks>
Public Class ClassFacultyLoad

    Dim strSectionCode As String
    Public Property SectionCode() As String
        Get
            Return strSectionCode
        End Get
        Set(ByVal value As String)
            strSectionCode = value
        End Set
    End Property

    Dim strSubjectCode As String
    Public Property SubjectCode() As String
        Get
            Return strSubjectCode
        End Get
        Set(ByVal value As String)
            strSubjectCode = value
        End Set
    End Property

    Dim strDescription As String
    Public Property DescriptiveTitle() As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
        End Set
    End Property

    Dim strTime1 As String
    Public Property Time1() As String
        Get
            Return strTime1
        End Get
        Set(ByVal value As String)
            strTime1 = value
        End Set
    End Property

    Dim strTime2 As String
    Public Property Time2() As String
        Get
            Return strTime2
        End Get
        Set(ByVal value As String)
            strTime2 = value
        End Set
    End Property

    Dim strDay1 As String
    Public Property Day1() As String
        Get
            Return strDay1
        End Get
        Set(ByVal value As String)
            strDay1 = value
        End Set
    End Property

    Dim strDay2 As String
    Public Property Day2() As String
        Get
            Return strDay2
        End Get
        Set(ByVal value As String)
            strDay2 = value
        End Set
    End Property

    Dim strRoom1 As String
    Public Property Room1() As String
        Get
            Return strRoom1
        End Get
        Set(ByVal value As String)
            strRoom1 = value
        End Set
    End Property

    Dim strRoom2 As String
    Public Property Room2() As String
        Get
            Return strRoom2
        End Get
        Set(ByVal value As String)
            strRoom2 = value
        End Set
    End Property

    Dim strLabCode As String
    Public Property LabCode() As String
        Get
            Return strLabCode
        End Get
        Set(ByVal value As String)
            strLabCode = value
        End Set
    End Property

    Dim intUnits As Decimal
    Public Property Units() As Decimal
        Get
            Return intUnits
        End Get
        Set(ByVal value As Decimal)
            intUnits = value
        End Set
    End Property

    Dim intNumStudents As Integer
    Public Property NumStudents() As Integer
        Get
            Return intNumStudents
        End Get
        Set(ByVal value As Integer)
            intNumStudents = value
        End Set
    End Property
End Class
