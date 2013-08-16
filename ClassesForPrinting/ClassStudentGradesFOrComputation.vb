


Public Class ClassStudentGradesFOrComputation

    Dim strSubjectNumber As String
    Public Property SubjectNumber() As String
        Get
            Return strSubjectNumber
        End Get
        Set(ByVal value As String)
            strSubjectNumber = value
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

    Dim decUnits As Decimal
    Public Property Units() As Decimal
        Get
            Return decUnits
        End Get
        Set(ByVal value As Decimal)
            decUnits = value
        End Set
    End Property

    Dim decGrades As Decimal
    Public Property Grades() As Decimal
        Get
            Return decGrades
        End Get
        Set(ByVal value As Decimal)
            decGrades = value
        End Set
    End Property

    Dim decPointGrades As Decimal
    Public Property PointGrades() As Decimal
        Get
            Return decPointGrades
        End Get
        Set(ByVal value As Decimal)
            decPointGrades = value
        End Set
    End Property

    Dim strRemarks As String
    Public Property Remarks() As String
        Get
            Return strRemarks
        End Get
        Set(ByVal value As String)
            strRemarks = value
        End Set
    End Property
End Class
