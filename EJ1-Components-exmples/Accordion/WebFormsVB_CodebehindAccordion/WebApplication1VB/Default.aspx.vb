Imports System.Data
Imports System.Drawing

Imports System.Reflection
Imports Syncfusion.JavaScript.Web
Public Class _Default
    Inherits Page

    Dim sTempltType, sDateValue, sUser, sQS, sAction, sQsTID, sDtControl, scboControl, sFilUpldCtrl As String
    Dim dtIndxFields As DataTable
    Dim sFieldName, sFieldType, sCategory, sShift, scboSelValue, sFileName As String
    Dim sQnDesc, sQnFieldType, sQnMainSection, sQnSubSection, sQnChoiceCategory, saccdItems As String
    Dim FUpld As FileUpload
    Dim indxItems As New Dictionary(Of Integer, IndexAreaField) ' collection to store Index field name & control name
    Dim alDates As ArrayList = New ArrayList 'list to store date control names
    Dim alMultiItems As ArrayList = New ArrayList 'list to store multi choice control names
    Dim alFiles As ArrayList = New ArrayList ' list to store file upload control names
    Dim tpDates As List(Of Tuple(Of String, Date, Integer))
    Dim tpCboVal As List(Of Tuple(Of String, String, Integer))
    Dim tpFileVal As List(Of Tuple(Of String, FileUpload, Integer))
    Dim lstaccdItems As List(Of Integer)
    Dim iIndxFieldId, iPerfIndexId, iLpCnt, iTemplateId, iQnFieldId, iQnLpCnt, iDtcount As Integer
    Dim dtEmpty As Date = Nothing
    Protected dtResult As Date
    Protected sfUpload As String

    Dim questions As List(Of Question)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim txt As New TextBox
        Dim sfpane As New AccordionItem
        txt.ID = "DynControl"
        Dim rfv As New RequiredFieldValidator
        rfv.ErrorMessage = "Error is for Dynamic Control"
        rfv.ForeColor = Color.Red
        rfv.ControlToValidate = "DynControl"

        sfpane.ContentSection.Controls.Add(txt)
        sfpane.ContentSection.Controls.Add(rfv)
        sfaccdQuestion.Items.Add(sfpane)


        Dim txt3 As New TextBox
        Dim sTab As New TabItem

        txt3.ID = "DynControl3"
        Dim rfv3 As New RequiredFieldValidator
        rfv3.ErrorMessage = "Error is for Dynamic Control"
        rfv3.ForeColor = Color.Red
        rfv3.ControlToValidate = "DynControl3"

        sTab.ContentSection.Controls.Add(txt3)
        sTab.ContentSection.Controls.Add(rfv3)
        sfTab.Items.Add(sTab)


        'Dim txt2 As New TextBox
        'txt2.ID = "DynControl2"
        'Dim rfv2 As New RequiredFieldValidator
        'rfv2.ErrorMessage = "Error is for Dynamic Control2"
        'rfv2.ForeColor = Color.Red
        'rfv2.ControlToValidate = "DynControl2"
        'sfDialog.DialogContent.Controls.Add(txt2)
        'sfDialog.DialogContent.Controls.Add(rfv2)

        'Dim txt1 As New TextBox
        'txt1.ID = "DynControl1"
        'Dim rfv1 As New RequiredFieldValidator
        'rfv1.ErrorMessage = "Error is for Dynamic Control1"
        'rfv1.ForeColor = Color.Red
        'rfv1.ControlToValidate = "DynControl1"

        'divTest.Controls.Add(txt1) 'This Is the div i spoke about In 3Rd point
        'divTest.Controls.Add(rfv1)
    End Sub




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Edit" Then
            btnSave.Text = "Save & Close"
            btnClose.Attributes.Add("onclick", "return confirm('Are you sure you want to cancel?')")

        Else
            Page.Validate()

            If Page.IsValid Then

            End If


        End If

    End Sub


    Sub SetListItem(ByVal inList As System.Web.UI.WebControls.ListControl, ByVal sValue As String)
        If Not (sValue Is Nothing) And Not (inList.Items.FindByText(sValue.Trim()) Is Nothing) Then

            inList.SelectedIndex = inList.Items.IndexOf(inList.Items.FindByText(sValue.Trim()))
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'If sPreviousPageUrl IsNot Nothing Then
        '    Response.Redirect(sPreviousPageUrl)
        'Else
        Response.Redirect("ListAllAudits.aspx?type=OA")
        'End If
    End Sub

End Class