Public Class Book

  Private _Name As String
  Public Property Name() As String
    Get
      Return _Name
    End Get
    Set(ByVal value As String)
      _Name = value
    End Set
  End Property

  Private _Author As String
  Public Property Author() As String
    Get
      Return _Author
    End Get
    Set(ByVal value As String)
      _Author = value
    End Set
  End Property

End Class
