Public Class AccountDetails
    Private BookValue As Book
    Public Property Book() As Book
        Get
            Return BookValue
        End Get
        Set(ByVal value As Book)
            BookValue = value
        End Set
    End Property
    Private issueddateValue As DateTime
    Public Property issueddate() As DateTime
        Get
            Return issueddateValue
        End Get
        Set(ByVal value As DateTime)
            issueddateValue = value
        End Set
    End Property
    Private DueDateValue As DateTime
    Public Property DueDate() As DateTime
        Get
            Return DueDateValue
        End Get
        Set(ByVal value As DateTime)
            DueDateValue = value
        End Set
    End Property
    Private FinePerDayValue As Decimal = 1
    Public Property FinePerDay() As Decimal
        Get
            Return FinePerDayValue
        End Get
        Set(ByVal value As Decimal)
            FinePerDayValue = value
        End Set

    End Property

    Public Function CalculateFine() As Decimal
        Dim today As DateTime = DateTime.Now

        If today > DueDate Then
            Dim daysLate As Integer = (today - DueDate).Days
            Dim fineAmount As Decimal = daysLate * FinePerDay
            Return fineAmount
        Else
            Return 0D ' No fine if not overdue
        End If
    End Function
End Class
