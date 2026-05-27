Public Class Student
    Private NameValue As String
    Public Property Name() As String
        Get
            Return NameValue
        End Get
        Set(ByVal value As String)
            NameValue = value
        End Set
    End Property

    Private StudentIDValue As String
    Public Property StudentID() As String
        Get
            Return StudentIDValue
        End Get
        Set(ByVal value As String)
            StudentIDValue = value
        End Set
    End Property
End Class
