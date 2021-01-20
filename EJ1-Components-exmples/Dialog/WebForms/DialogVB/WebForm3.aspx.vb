Public Class WebForm3
    Inherits System.Web.UI.Page
    Public Shared Data As List(Of GridFill) = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case Me.Combo.Items.Count
            Case 0
                Me.Combo.Items.Add("Select")
                Me.Combo.Items.Add("Yes")
                Me.Combo.Items.Add("No")
                Me.Combo.Items.Add("Load Grid")
        End Select
    End Sub

    Private Sub Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo.SelectedIndexChanged
        Select Case Combo.Text
            Case "Yes"
                Text.Value = "You Selected Yes"
            Case "No"
                Text.Value = "You Selected No"
            Case "Load Grid"
                LoadGrid()
        End Select
    End Sub

    Public Class GridFill
        Public Sub New(FirstName As String, LastName As String, Age As Integer)
            Me.FirstName = FirstName
            Me.LastName = LastName
            Me.Age = Age

        End Sub
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Age() As Integer

    End Class

    Public Sub LoadGrid()
        Data = New List(Of GridFill)()
        Try
            Data.Add(New GridFill("Chris", "Litger", 30))
            Data.Add(New GridFill("John", "Smith", 24))
            Data.Add(New GridFill("Rose", "Abraham", 27))
            Data.Add(New GridFill("Tamara", "Fields", 22))

            Me.Grid3.DataSource = Data
            Me.Grid3.DataBind()
        Catch ex As Exception
            MsgBox("There was an error")
        End Try
    End Sub
End Class