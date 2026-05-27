Public Class Book
    Private TitleValue As String
    Public Property Title() As String
        Get
            Return TitleValue
        End Get
        Set(ByVal value As String)
            TitleValue = value
        End Set
    End Property
    Private AuthorValue As String
    Public Property Author() As String
        Get
            Return AuthorValue
        End Get
        Set(ByVal value As String)
            AuthorValue = value
        End Set
    End Property

End Class
