

Public Class ClassSubjectsEnrolled

    Dim intESSID As Integer
    Public Property TheESSID() As Integer
        Get
            Return intESSID
        End Get
        Set(ByVal value As Integer)
            intESSID = value
        End Set
    End Property

    Dim strSubjCode As String
    Public Property SubjectCode() As String
        Get
            Return strSubjCode
        End Get
        Set(ByVal value As String)
            strSubjCode = value
        End Set
    End Property

    ''' <summary>
    ''' Section Code
    ''' </summary>
    ''' <remarks></remarks>
    Dim strCourseOfferingNumber As String
    Public Property CourseOfferingNumber() As String
        Get
            Return strCourseOfferingNumber
        End Get
        Set(ByVal value As String)
            strCourseOfferingNumber = value
        End Set
    End Property

    Dim strDescTitle As String
    Public Property DescTitle() As String
        Get
            Return strDescTitle
        End Get
        Set(ByVal value As String)
            strDescTitle = value
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

    Dim intCourseOfferingID As Integer
    Public Property CourseOfferingID() As Integer
        Get
            Return intCourseOfferingID
        End Get
        Set(ByVal value As Integer)
            intCourseOfferingID = value
        End Set
    End Property

    Dim intSubjectID As Integer
    Public Property SubjectID() As Integer
        Get
            Return intSubjectID
        End Get
        Set(ByVal value As Integer)
            intSubjectID = value
        End Set
    End Property
End Class
