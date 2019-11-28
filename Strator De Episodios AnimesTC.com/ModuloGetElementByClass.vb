Module Modulo1
<Runtime.CompilerServices.Extension> _
Public Function GetElementsByClassName(Source As HtmlDocument, ClassName As String) As HtmlElement()
Dim output As New List(Of HtmlElement)
For i As Integer = 0 To Source.All.Count - 1
Try
If (Source.All(i).GetAttribute("className") = ClassName) Then
output.Add(Source.All(i))
End If
Catch ex As Exception
End Try
Next
Return output.ToArray()
End Function
End Module
