Public Class _Default
    Inherits Page

    Protected Result As Date
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'set value
        DTPicker.Value = "23/12/2020 01:54 PM"
        'get value
        Result = DTPicker2.Value
    End Sub

End Class