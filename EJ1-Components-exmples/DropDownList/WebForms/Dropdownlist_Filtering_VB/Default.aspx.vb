Imports Syncfusion.JavaScript.Web
Public Class _Default
    Inherits Page
    Dim ctr As Control

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim groups As List(Of GroupsList) = New List(Of GroupsList)()
        groups.Add(New GroupsList("a", "Adams"))
        groups.Add(New GroupsList("b", "James"))
        groups.Add(New GroupsList("c", "Maria"))
        groups.Add(New GroupsList("d", "Jessica"))
        groups.Add(New GroupsList("e", "Jenneth"))
        ddlgroupsList.DataSource = groups
    End Sub

    <Serializable>
    Class GroupsList
        Public Property parentId As String
        Public Property text As String

        Public Sub New(ByVal gID As String, ByVal gtext As String)
            Me.parentId = gID
            Me.text = gtext
        End Sub
    End Class

End Class