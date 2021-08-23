Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim newItem As New Syncfusion.JavaScript.Web.MenuItem
        newItem.Text = "new Item"
        newItem.Url = "About.aspx"
        newItem.HtmlAttributes = "class=e-disabled-item"
        MenuCtrl.Items.Add(newItem)

        'MenuCtrl.Items


        'MenuCtrl.Items[0].Items[1].HtmlAttributes = "class=e-hidden-item"
        'MenuCtrl.Items[0].Items[2].HtmlAttributes = "class='e-hidden-item'"



    End Sub

    Protected Sub Hide_Click(Sender As Object, e As Syncfusion.JavaScript.Web.ButtonEventArgs)
        'MenuCtrl.Items








    End Sub
End Class