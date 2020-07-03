Imports System.Data
Imports System.Drawing

Imports System.Reflection
Imports Syncfusion.JavaScript.Web
Public Class _Default
    Inherits Page
    Dim data As List(Of LoadData) = New List(Of LoadData)()
    Dim Val As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        data.Add(New LoadData With {.ID = 1, .Text = "Audi S6"})
        data.Add(New LoadData With {.ID = 2, .Text = "Austin-Healey"})
        data.Add(New LoadData With {.ID = 3, .Text = "Aston Martin"})
        data.Add(New LoadData With {.ID = 4, .Text = "BMW 7"})
        data.Add(New LoadData With {.ID = 5, .Text = "Bentley Mulsanne"})
        data.Add(New LoadData With {.ID = 6, .Text = "Bugatti Veyron"})
        data.Add(New LoadData With {.ID = 7, .Text = "Chevrolet Camaro"})
        data.Add(New LoadData With {.ID = 8, .Text = "Cadillac"})
        Me.AutoComplete.DataSource = data
        Me.ref.DataSource = data

    End Sub

    Public Class LoadData
        Public Property ID As Integer
        Public Property Text As String
    End Class

    Protected Sub AutoComplete_ValueSelect(sender As Object, e As AutocompleteSelectEventArgs)
        Val = e.Key
    End Sub

    Private Sub ref_ValueSelect(sender As Object, e As AutocompleteSelectEventArgs) Handles ref.ValueSelect

        Dim Value = e.Key

    End Sub
End Class