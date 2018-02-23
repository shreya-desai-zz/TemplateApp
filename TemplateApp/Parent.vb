Public Class Parent
  Public Sub New(ByVal Title As String)
    Title = Title
    ChildItems = New List(Of Child)()
  End Sub

  Public Property Title As String

  Public Property ChildItems As List(Of Child)

End Class
