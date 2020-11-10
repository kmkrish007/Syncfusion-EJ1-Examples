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
        Dim countries As List(Of CountryList) = New List(Of CountryList)()
        countries.Add(New CountryList(11, "a", "Algeria", "flag-dz"))
        countries.Add(New CountryList(12, "a", "Armenia", "flag-am"))
        countries.Add(New CountryList(13, "a", "Bangladesh", "flag-bd"))
        countries.Add(New CountryList(14, "a", "Cuba", "flag-cu"))
        countries.Add(New CountryList(15, "b", "Denmark", "flag-dk"))
        countries.Add(New CountryList(16, "b", "Egypt", "flag-eg"))
        countries.Add(New CountryList(17, "c", "Finland", "flag-fi"))
        countries.Add(New CountryList(18, "c", "India", "flag-in"))
        countries.Add(New CountryList(19, "c", "Malaysia", "flag-my"))
        countries.Add(New CountryList(20, "d", "New Zealand", "flag-nz"))
        countries.Add(New CountryList(21, "d", "Norway", "flag-no"))
        countries.Add(New CountryList(22, "d", "Poland", "flag-pl"))
        countries.Add(New CountryList(23, "e", "Romania", "flag-ro"))
        countries.Add(New CountryList(24, "e", "Singapore", "flag-sg"))
        countries.Add(New CountryList(25, "e", "Thailand", "flag-th"))
        countries.Add(New CountryList(26, "e", "Ukraine", "flag-ua"))
        ddlcountryList.DataSource = countries
        'Me.CountryList.DataSource = countries
    End Sub

    <Serializable>
    Class CountryList
        Public Property value As Integer
        Public Property parentId As String
        Public Property text As String
        Public Property sprite As String

        Public Sub New(ByVal cvalue As Integer, ByVal cid As String, ByVal ctext As String, ByVal sprt As String)
            Me.value = cvalue
            Me.parentId = cid
            Me.text = ctext
            Me.sprite = sprt
        End Sub
    End Class

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