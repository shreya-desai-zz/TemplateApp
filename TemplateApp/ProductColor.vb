Public Class ProductColor

  Public Sub New(pname As String, cname As String)
    ProductName = pname
    CustomerName = cname
  End Sub

  Public Property ProductName As String
  Public Property CustomerName As String

  Public Class ProductColors
    Inherits List(Of ProductColor)

    Public Sub New()
      Me.Add(New ProductColor("Blue Color", "Blue"))
      Me.Add(New ProductColor("Red Color", "Red"))
      Me.Add(New ProductColor("Green Color", "Green"))
      Me.Add(New ProductColor("Yellow Color", "Yellow"))
      Me.Add(New ProductColor("Black Color", "Black"))
      Me.Add(New ProductColor("Gray Color", "Gray"))
    End Sub

  End Class

End Class
