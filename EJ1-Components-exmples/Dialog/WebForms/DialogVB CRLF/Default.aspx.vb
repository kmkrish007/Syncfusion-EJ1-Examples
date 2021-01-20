Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Dim value As New HtmlGenericControl("div")

        Dim mydiv As New System.Web.UI.HtmlControls.HtmlGenericControl("div")
        mydiv.Attributes.Add("class", "dialog-content")
        mydiv.InnerHtml = "<p>AS OF 7PM 16/03/2020 AND AS A RESULT OF GOVERNMENT ANNOUNCESMENTS AND OUR OWN CONCERNS, THE NEWTON ABBOT SKITELS LEAGUE HAS DECIDED TO END THE SEASON, FURTHER UPDATES WILL FOLLWO. <br/> IT HASE BEEN SUGGESTED THAT THE NEXT SEASON BE STARTED ON THE FIRST WEEK OF OCTOBER AND RUN THROUGHT THE END OF MAY, YOUR CONSTRUCTIVE COMMENTS WOULD BE WELCOME. <br/> ALL COMMENTS REGARDING THE NEW WEBSITE SHOULD BE SENT TO BE LEAGUE SECRETARY <br/></p>"
        NodeDialog.DialogContent = mydiv

    End Sub

End Class