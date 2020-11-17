Public Class _Default
    Inherits Page

    Dim sfDateControl As New Global.Syncfusion.JavaScript.Web.DatePicker
    Dim dtEmpty As Date = Nothing
    Protected Result As Date

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If IsPostBack Then
            Result = Request.Form("MainContent_dtDate_")

        End If
        LoadHeaderControls()
    End Sub

    Private Sub LoadHeaderControls()
        Dim pane As New AjaxControlToolkit.AccordionPane

        pane.ID = "pneH"
        Dim lblHeader As New Label
        lblHeader.Text = "Audit Selection"
        lblHeader.ID = "lblTitle"
        pane.HeaderContainer.Controls.Add(lblHeader)
        pane.HeaderContainer.Controls.Add(New LiteralControl("<hr>"))
        pane.ContentContainer.Controls.Add(New LiteralControl("<table><tr>"))
        CreateControl(pane)
        pane.ContentContainer.Controls.Add(New LiteralControl("</tr></table>"))


        accdTemplate.Panes.Add(pane)
        Page.DataBind()
    End Sub

    Private Function CreateControl(accdPane As AjaxControlToolkit.AccordionPane) As String
        Dim sControlName As String = Nothing
        accdPane.ContentContainer.Controls.Add(New LiteralControl("<td>"))
        Dim lblDate As New Label
        lblDate.Text = "Date"
        lblDate.ID = "lbl"
        lblDate.CssClass = "LblHead"
        accdPane.ContentContainer.Controls.Add(lblDate)
        accdPane.ContentContainer.Controls.Add(New LiteralControl("</td><td>"))
        Dim dtDate As New Global.Syncfusion.JavaScript.Web.DatePicker
        dtDate.ID = "dtDate_"
        If IsPostBack Then
            dtDate.Value = Result
        End If

        sControlName = dtDate.ID
        accdPane.ContentContainer.Controls.Add(dtDate)

        'Dim txtbox As New TextBox
        'txtbox.ID = "txt_"

        'accdPane.ContentContainer.Controls.Add(txtbox)




        accdPane.ContentContainer.Controls.Add(New LiteralControl("</td>"))
        Return sControlName
    End Function

    Private Sub ActionControls(blnEnable As Boolean)
        accdTemplate.Enabled = blnEnable
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Edit" Then
            btnSave.Text = "Save & Close"
            ActionControls(True)
            btnClose.Attributes.Add("onclick", "return confirm('Are you sure you want to cancel?')")

        Else
            GetHeaderValues()




        End If

    End Sub

    Private Sub GetHeaderValues()
        Dim dtDateVal As Date
        Dim sDateValue As Date

        For Each pane In accdTemplate.Panes
            For Each ctr As Control In pane.ContentContainer.Controls
                If TypeOf ctr Is Global.Syncfusion.JavaScript.Web.DatePicker Then
                    dtDateVal = dtpDtTest.Value
                    If CType(ctr, Global.Syncfusion.JavaScript.Web.DatePicker).Value <> dtEmpty Then
                        dtDateVal = CType(ctr, Global.Syncfusion.JavaScript.Web.DatePicker).Value
                        sDateValue = dtDateVal.ToString("MM/dd/yyyy")

                    Else
                        sDateValue = Nothing
                    End If
                End If

            Next
        Next



    End Sub

End Class