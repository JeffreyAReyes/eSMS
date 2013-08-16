

''' <summary>
''' Class for printing daily payments received
''' 
''' </summary>
''' <remarks></remarks>
Public Class ClassDailyPayments

    Dim strEDPNumber As String
    Public Property EDPNumber() As String
        Get
            Return strEDPNumber
        End Get
        Set(ByVal value As String)
            strEDPNumber = value
        End Set
    End Property

    Dim strNameOfPayee As String
    Public Property NameOfPayee() As String
        Get
            Return strNameOfPayee
        End Get
        Set(ByVal value As String)
            strNameOfPayee = value
        End Set
    End Property

    Dim strRefNumber As String
    Public Property RefNumber() As String
        Get
            Return strRefNumber
        End Get
        Set(ByVal value As String)
            strRefNumber = value
        End Set
    End Property

    Dim strCashierName As String
    Public Property CashierName() As String
        Get
            Return strCashierName
        End Get
        Set(ByVal value As String)
            strCashierName = value
        End Set
    End Property

    Dim decAmountPaid As Decimal
    Public Property AmountPaid() As Decimal
        Get
            Return decAmountPaid
        End Get
        Set(ByVal value As Decimal)
            decAmountPaid = value
        End Set
    End Property

    Dim strFeeTitle As String
    Public Property FeeTitle() As String
        Get
            Return strFeeTitle
        End Get
        Set(ByVal value As String)
            strFeeTitle = value
        End Set
    End Property

    Dim strPayFor As String
    Public Property PayFor() As String
        Get
            Return strPayFor
        End Get
        Set(ByVal value As String)
            strPayFor = value
        End Set
    End Property

End Class
