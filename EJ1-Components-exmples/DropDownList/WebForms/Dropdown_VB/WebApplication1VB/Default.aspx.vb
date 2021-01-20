Imports System.ComponentModel
Imports Syncfusion.JavaScript.Web
Public Class _Default
    Inherits Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim data As List(Of DropDownData) = New List(Of DropDownData)()
        data.Add(New DropDownData(1, "Railways"))
        data.Add(New DropDownData(2, "Roadways"))
        data.Add(New DropDownData(3, "Airways"))
        data.Add(New DropDownData(4, "Waterways"))
        data.Add(New DropDownData(5, "Electric Trains"))
        data.Add(New DropDownData(6, "Diesel Trains"))
        data.Add(New DropDownData(7, "Heavy Motor Vehicles"))
        data.Add(New DropDownData(8, "Light Motor Vehicles"))
        data.Add(New DropDownData(9, "Aero planes"))
        data.Add(New DropDownData(10, "Helicopters"))
        data.Add(New DropDownData(11, "Ships"))
        data.Add(New DropDownData(12, "Submarines"))
        ddlgroupsList.DataSource = data
        ddlgroupsList.Value = "3,4,10"
    End Sub

    <Serializable>
    Class DropDownData
        Public Property ID As Integer
        Public Property Text As String

        Public Sub New(ByVal _id As Integer, ByVal _text As String)
            Me.ID = _id
            Me.Text = _text
        End Sub
    End Class

End Class