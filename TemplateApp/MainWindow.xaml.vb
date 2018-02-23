Class MainWindow
  Inherits Window

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    Dim bookList As List(Of Book) = New List(Of Book)()
    ' Add any initialization after the InitializeComponent() call.
    bookList.Add(New Book() With {.Name = "Computer Networking", .Author = "James F. Kurose"})
    bookList.Add(New Book() With {.Name = "Software Engineering", .Author = "deepak F. Kurose"})
    bookList.Add(New Book() With {.Name = "HTML 5", .Author = "Adam McDaniel"})
    Me.datatemplate.ItemsSource = bookList

    Dim parent1 As Parent = New Parent("Parent 1") With
      {.ChildItems = New List(Of Child) From {New Child With
      {.Title = "Child 1"}, New Child With
      {.Title = "Child 1.1"}, New Child With
      {.Title = "Child 1.2"}}}
    Dim parent2 As Parent = New Parent("Parent 2") With
      {.ChildItems = New List(Of Child) From {New Child With
      {.Title = "Child 2"}, New Child With
      {.Title = "Child 2.1"}, New Child With
      {.Title = "Child 2.2"}}}

    Me.treeView.Items.Clear()
    Dim parent As New List(Of Parent)()

    parent.Add(parent1)
    parent.Add(parent2)
    Me.treeView.ItemsSource = parent
  End Sub

  Private Sub button1_Click(sender As Object, e As RoutedEventArgs)
    Dim newchild As TreeViewItem = New TreeViewItem()
    newchild.Header = textBox1.Text
    Parent.Items.Add(newchild)
    textBox1.Text = ""

  End Sub

  Private Sub Delete_Click(sender As Object, e As RoutedEventArgs)
    Parent.Items.RemoveAt(Parent.Items.IndexOf(TreeView1.SelectedItem))
  End Sub
End Class
