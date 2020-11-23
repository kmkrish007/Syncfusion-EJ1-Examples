Imports Syncfusion.JavaScript.Web
Public Class _Default
    Inherits Page
    Dim ctr As Control

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim groups As List(Of GroupsList) = New List(Of GroupsList)()
        groups.Add(New GroupsList("a", "Group A"))
        groups.Add(New GroupsList("b", "Group B"))
        groups.Add(New GroupsList("c", "Group C"))
        groups.Add(New GroupsList("d", "Group D"))
        groups.Add(New GroupsList("e", "Group E"))
        ddlgroupsList.DataSource = groups
        ddlgroupsList.SelectedIndices = New List(Of Integer)({0, 1, 2})
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