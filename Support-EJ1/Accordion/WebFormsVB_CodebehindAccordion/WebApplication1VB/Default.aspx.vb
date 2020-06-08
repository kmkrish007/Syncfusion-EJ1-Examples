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

        iPerfIndexId = 14
        Session("TemplateId") = 7
        sAction = "rw"

        If Session("TemplateId") > 0 Then
            LoadQuestions()
            'LoadQuestionResponse()
        End If

        If Not IsPostBack Then
            Select Case sAction
                Case "rw"
                    'Edit
                    '    LoadHeaderValues()

                    btnSave.Text = "Save & Close"
                    ActionControls(True)
                Case "new"
                    'add new

                    btnSave.Text = "Save & Close"
                    ActionControls(True)

                Case Else
                    'View 
                    'LoadHeaderValues()
                    ActionControls(False)
                    btnSave.Text = "Edit"
            End Select

            If Request.UrlReferrer IsNot Nothing AndAlso Request.UrlReferrer.ToString <> "" Then
                sPreviousPageUrl = Request.UrlReferrer.ToString
            End If
        End If
    End Sub


    Private Sub GetCboSelection()
        alMultiItems = CType(Session("alMultiItems"), ArrayList)
        iDtcount = alMultiItems.Count
        tpCboVal = New List(Of Tuple(Of String, String, Integer))
        For iLpCnt = 0 To iDtcount - 1

            scboControl = alMultiItems(iLpCnt)

            If String.IsNullOrEmpty(Request.Form("MainContent_" & scboControl)) Then
            Else

                scboSelValue = Request.Form("MainContent_" & scboControl)
                tpCboVal.Add(New Tuple(Of String, String, Integer)(scboControl, scboSelValue, iLpCnt))
            End If

        Next
        Session("ListCboValue") = tpCboVal
    End Sub




    'Private Sub btnAddEdit_Click(sender As Object, e As EventArgs) Handles btnAddEdit.Click
    '    Response.Redirect("~/Areas/TACTemplate/Templates.aspx")
    'End Sub


    Private Function GetFieldIdControl(sControlName As String) As Integer
        Dim iIndexId, iPos As Integer
        Dim sIndexId As String
        iPos = InStr(sControlName, "_")
        sIndexId = Right(sControlName, (sControlName.Length - iPos))
        iIndexId = CType(sIndexId, Integer)
        Return iIndexId
    End Function
    Private Function GetControlPrefix(sControlName As String) As String
        Dim iPos As Integer
        Dim sEltPrefix As String
        iPos = InStr(sControlName, "_")
        sEltPrefix = Left(sControlName, iPos - 1)

        Return sEltPrefix
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Edit" Then
            btnSave.Text = "Save & Close"
            ActionControls(True)
            btnClose.Attributes.Add("onclick", "return confirm('Are you sure you want to cancel?')")

        Else

            GetQuestionAnswers()
            Session("ListDates") = Nothing
            Session("ListCboValue") = Nothing


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

    Public Property sPreviousPageUrl As String
        Get
            Return CStr(ViewState("PreviousPageUrl"))
        End Get
        Set(ByVal value As String)
            ViewState("PreviousPageUrl") = value
        End Set
    End Property
    Private Sub ActionControls(blnEnable As Boolean)

        'accdQuestion.Enabled = blnEnable


        For Each sfQnPane In sfaccdQuestion.Items
            For Each ctr As Control In sfQnPane.ContentSection.Controls
                'For Each ctr As Control In QnPane.ContentContainer.Controls
                If TypeOf ctr Is TextBox Then
                    CType(ctr, TextBox).Enabled = blnEnable
                End If

                If TypeOf ctr Is RadioButtonList Then
                    CType(ctr, RadioButtonList).Enabled = blnEnable
                End If

            Next
        Next
        ' Next
    End Sub
    Private Sub getData()

        questions = New List(Of Question)() From {
            New Question With {
            .DataFieldId = 1,
            .QuestionDesc = "How do you feel?",
            .DataFieldType = "Text Multiline",
            .QnSectioHeader = "Feelings",
            .blnDisplay = True},
             New Question With {
            .DataFieldId = 2,
            .QuestionDesc = "Fuel Fill",
            .DataFieldType = "Boolean",
            .QnSectioHeader = "Feelings",
            .blnDisplay = True},
             New Question With {
            .DataFieldId = 3,
            .QuestionDesc = "Checklist",
            .DataFieldType = "File Upload",
            .QnSectioHeader = "Checklist",
            .blnDisplay = True}
        }


    End Sub

    Private Sub LoadQuestions()

        Dim sfpaneQn As New Syncfusion.JavaScript.Web.AccordionItem
        Dim QuestionItems As New Dictionary(Of Integer, IndexAreaField) ' collection to store question & control name
        Dim dsQnTmplt As New DataSet
        Dim dtQnT As DataTable
        Dim iQnRowCnt, iPnCnt As Integer
        Dim sQnControlId, sQnPrevSection As String
        Dim blnNew As Boolean = True
        lstaccdItems = New List(Of Integer)
        iTemplateId = Session("TemplateId")


        'dsQnTmplt = SimpleSQL.runProcedureGetDataSet("csWebData", "TacTmplt_GetQuestionsbyTemplate", iTemplateId)
        'dtQnT = dsQnTmplt.Tables(0)

        getData()
        dtQnT = TACSettings.ToDataTable(Of Question)(questions)
        iQnRowCnt = dtQnT.Rows.Count

        sQnPrevSection = ""
        alFiles.Clear()


        For iQnLpCnt = 0 To iQnRowCnt - 1
            sQnDesc = dtQnT.Rows(iQnLpCnt)("questiondesc")
            sQnMainSection = dtQnT.Rows(iQnLpCnt)("QnSectioHeader")
            If sQnMainSection <> sQnPrevSection Then
                If Not blnNew Then

                    CloseSFPane(sfpaneQn)
                End If
                iPnCnt = iPnCnt + 1

                sfpaneQn = CreateSectionSF(sQnMainSection, iPnCnt)
                blnNew = True
            Else
                blnNew = False
            End If

            sQnFieldType = dtQnT.Rows(iQnLpCnt)("DataFieldType")
            iQnFieldId = dtQnT.Rows(iQnLpCnt)("DataFieldId")

            sQnControlId = CreateQuestionItemSF(sfpaneQn, sQnDesc, sQnFieldType, iQnFieldId, sQnChoiceCategory, sQnMainSection)
            TACSettings.AddAreaIndxFieldItems(QuestionItems, sQnControlId, sQnFieldType, iQnFieldId)
            sQnPrevSection = sQnMainSection

        Next

        ViewState("QuestionItems") = QuestionItems
        Session("alFiles") = alFiles
        sfpaneQn.ContentSection.Controls.Add(New LiteralControl("</table>"))
        sfaccdQuestion.Items.Add(sfpaneQn)
        sfaccdQuestion.SelectedItems = lstaccdItems

    End Sub
    Private Function CreateSectionSF(sMainSection As String, iCnt As Integer) As Syncfusion.JavaScript.Web.AccordionItem
        Dim accdPaneQn As New Syncfusion.JavaScript.Web.AccordionItem

        accdPaneQn.ID = "pneQn" & iCnt
        accdPaneQn.Text = sQnMainSection

        accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<table class='QnTable'>"))
        lstaccdItems.Add(iCnt - 1)
        Return accdPaneQn
    End Function

    Private Function CreateQuestionItemSF(accdPaneQn As Syncfusion.JavaScript.Web.AccordionItem, sQuestion As String, sQnType As String, iQnId As Integer, sCatMulti As String, sSection As String) As String
        Dim sControlName As String = Nothing
        Dim sFileControl As String = Nothing
        Select Case LCase(sQnType)
            Case "boolean"
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))
                'accdPaneQn.ContentContainer.Controls.Add(New LiteralControl("<tr><td>"))
                Dim lbl As New Label
                lbl.Text = sQuestion
                lbl.ID = "lbl_" & iQnId
                lbl.CssClass = "LblHead"

                accdPaneQn.ContentSection.Controls.Add(lbl)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))

                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))
                Dim rdbLst As New RadioButtonList
                rdbLst.ID = "rdb_" & iQnId
                sControlName = rdbLst.ID
                rdbLst.Items.Add(New ListItem("Pass", 1))
                rdbLst.Items.Add(New ListItem("Fail", 0))
                rdbLst.Items.Add(New ListItem("None of the above", 2))
                rdbLst.RepeatDirection = RepeatDirection.Vertical
                rdbLst.CssClass = "rdblstItems"
                rdbLst.SelectedIndex = 2
                accdPaneQn.ContentSection.Controls.Add(rdbLst)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))
            Case "text multiline"

                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))
                Dim lbl As New Label
                lbl.Text = sQuestion
                lbl.ID = "lbl_" & iQnId
                lbl.CssClass = "LblHead"
                accdPaneQn.ContentSection.Controls.Add(lbl)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))

                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))
                Dim textM As New TextBox
                textM.ID = "txt_" & iQnId
                sControlName = textM.ID
                sControlName = textM.ID
                textM.TextMode = TextBoxMode.MultiLine
                textM.MaxLength = 500
                textM.Width = 400
                textM.Height = 200
                accdPaneQn.ContentSection.Controls.Add(textM)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))
            Case "file upload"
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))
                Dim lbl As New Label
                lbl.Text = sQuestion
                lbl.ID = "lbl_" & iQnId
                lbl.CssClass = "LblHead"
                accdPaneQn.ContentSection.Controls.Add(lbl)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))

                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))

                ' Dim upld As New FileUpload
                'upld.ID = "upld_" & iQnId
                'sControlName = upld.ID
                'Dim regexVal As RegularExpressionValidator = New RegularExpressionValidator With {
                '    .ControlToValidate = sControlName,
                '    .ID = "regex_" & iQnId,
                '    .ErrorMessage = "Invalid File Type",
                '    .ValidationExpression = "^.+(.doc|.DOC|.docx|.DOCX|.rtf|.RTF|.pdf|.PDF|.xlsx|XLSX|.txt|.TXT|.jpg|.JPG|.png|.PNG)$",
                '    .ForeColor = Color.Red,
                '    .Display = ValidatorDisplay.Dynamic
                '    }

                Dim upld As New UploadBox
                upld.ID = "upld_" & iQnId
                sControlName = upld.ID
                'Dim regexVal As RegularExpressionValidator = New RegularExpressionValidator With {
                '    .ControlToValidate = sControlName,
                '    .ID = "regex_" & iQnId,
                '    .ErrorMessage = "Invalid File Type",
                '    .ValidationExpression = "^.+(.doc|.DOC|.docx|.DOCX|.rtf|.RTF|.pdf|.PDF|.xlsx|XLSX|.txt|.TXT|.jpg|.JPG|.png|.PNG)$",
                '    .ForeColor = Color.Red,
                '    .Display = ValidatorDisplay.Dynamic
                '}


                accdPaneQn.ContentSection.Controls.Add(upld)

                'accdPaneQn.ContentSection.Controls.Add(regexVal)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))

                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("<tr><td>"))



                Dim lnkFile As HyperLink = New HyperLink With {
                    .ID = "lnk_" & iQnId,
                    .Text = "File Link"
                    }

                accdPaneQn.ContentSection.Controls.Add(lnkFile)
                accdPaneQn.ContentSection.Controls.Add(New LiteralControl("</td></tr>"))
        End Select
        Return sControlName
    End Function
    Private Sub CloseSFPane(accdPane As Syncfusion.JavaScript.Web.AccordionItem)
        accdPane.ContentSection.Controls.Add(New LiteralControl("</table>"))
        sfaccdQuestion.Items.Add(accdPane)

    End Sub
    Private Sub GetQuestionAnswers()
        Dim sTxtValue, sPaneId, sElementId, sResponseType, sRespTypeReduced As String
        Dim sQnAnswers As New StringBuilder
        Dim iQuestionId, iCntrlCnt, iCntrlLp, iFileOWId As Integer
        Dim oQuestionField As New IndexAreaField

        Dim sfQnPane As New Syncfusion.JavaScript.Web.AccordionItem
        Dim ctr As Control
        Dim QnItemsCntrl As New Dictionary(Of Integer, IndexAreaField)
        QnItemsCntrl = CType(ViewState("QuestionItems"), Dictionary(Of Integer, IndexAreaField))


        For Each sfQnPane In sfaccdQuestion.Items
            'sPaneId = QnPane.ID
            sPaneId = sfQnPane.ID

            iCntrlCnt = sfQnPane.ContentSection.Controls.Count
            For iCntrlLp = 0 To iCntrlCnt - 1
                ctr = sfQnPane.ContentSection.Controls.Item(iCntrlLp)


                ' For Each ctr As Control In sfQnPane.ContentSection.Controls.Item
                If TypeOf ctr Is TextBox Then
                    sElementId = ctr.ID
                    iQuestionId = GetFieldIdControl(sElementId)
                    If QnItemsCntrl.TryGetValue(iQuestionId, oQuestionField) Then
                        'sTxtValue = CType(ctr, TextBox).Text
                        sTxtValue = Request.Form("ctl00$MainContent$sfaccdQuestion$txt_1")
                        sResponseType = oQuestionField.FieldType
                        If sResponseType = "TEXT" Then
                            sRespTypeReduced = "TXT"
                        Else
                            sRespTypeReduced = "TXTM"
                        End If
                        ' iPerfIndexId = pkPerfIndxId.Value
                        SaveQuestionAnswer(iQuestionId, sTxtValue, sRespTypeReduced, iPerfIndexId)
                        sQnAnswers.Append(oQuestionField.FieldName & ": ")
                        sQnAnswers.Append(sTxtValue)
                        sQnAnswers.Append(vbCrLf)

                    End If

                End If
                If TypeOf ctr Is RadioButtonList Then
                    sElementId = ctr.ID
                    iQuestionId = GetFieldIdControl(sElementId)
                    If QnItemsCntrl.TryGetValue(iQuestionId, oQuestionField) Then
                        'sTxtValue = CType(ctr, RadioButtonList).SelectedValue
                        sTxtValue = Request.Form("ctl00$MainContent$sfaccdQuestion$rdb_2")
                        sResponseType = oQuestionField.FieldType
                        'iPerfIndexId = pkPerfIndxId.Value
                        If sTxtValue <> "2" Then
                            SaveQuestionAnswer(iQuestionId, sTxtValue, sResponseType, iPerfIndexId)
                        End If
                        sQnAnswers.Append(oQuestionField.FieldName & ": ")
                        sQnAnswers.Append(sTxtValue)
                        sQnAnswers.Append(vbCrLf)
                    End If
                End If


                'If TypeOf ctr Is FileUpload Then
                If TypeOf ctr Is UploadBox Then
                    sElementId = ctr.ID
                    iQuestionId = GetFieldIdControl(sElementId)
                    If QnItemsCntrl.TryGetValue(iQuestionId, oQuestionField) Then
                        sResponseType = oQuestionField.FieldType
                        sfUpload = Request.Form("ctl00$MainContent$sfaccdQuestion$upld_3")
                        'If CType(ctr, FileUpload).HasFile Then
                        If CType(ctr, UploadBox).HasFiles Then
                            'sTxtValue = CType(ctr, FileUpload).PostedFile.FileName
                            sTxtValue = CType(ctr, UploadBox).PostedFiles.First.FileName
                            If Session("OWFile") <> "" Then
                                    iFileOWId = Session("OWFile")

                                End If
                                Dim myFileID As Integer = Utilities.UploadFile(ctr, Session("sUser"), 1)
                                If myFileID > 0 Then
                                    SaveQuestionAnswer(iQuestionId, myFileID, sResponseType, iPerfIndexId)
                                End If
                            End If
                        End If
                End If
            Next

        Next
        'Next
        lblResults.Text = sQnAnswers.ToString
    End Sub
    Private Sub LoadQuestionResponse()
        Dim dtQnResp As DataTable
        Dim sControlName As String
        Dim iRowCnt, iQuestionId As Integer
        Dim sCtrlValue, sBlnValue, sFileValue, sFileName As String

        Dim oQuestionField As New IndexAreaField
        Dim QnItems As New Dictionary(Of Integer, IndexAreaField)
        QnItems = CType(ViewState("QuestionItems"), Dictionary(Of Integer, IndexAreaField))

        Dim dsQnResp As New DataSet
        Dim iRowCntAct As Integer = 0

        'dsQnResp = SimpleSQL.runProcedureGetDataSet("csWebData", "TACTmplt_GetPerformedQuestionAns", iPerfIndexId)

        dtQnResp = dsQnResp.Tables(0)
        iRowCnt = dtQnResp.Rows.Count

        'Dim drQnResp As DataRow = dtQnResp.Rows(0)

        For iLpCnt = 0 To iRowCnt - 1
            iQuestionId = dtQnResp.Rows(iLpCnt)("qnid")
            iTemplateId = dtQnResp.Rows(iLpCnt)("templateid")
            sBlnValue = Utilities.Coalesce(dtQnResp.Rows(iLpCnt)("ansbool"), "2")
            sCtrlValue = Utilities.Coalesce(dtQnResp.Rows(iLpCnt)("txtother"), "")
            sFileValue = Utilities.Coalesce(dtQnResp.Rows(iLpCnt)("fileId"), "")
            Session("OWFile") = sFileValue
            sFileName = Utilities.Coalesce(dtQnResp.Rows(iLpCnt)("filename"), "")
            If QnItems.TryGetValue(iQuestionId, oQuestionField) Then
                sControlName = oQuestionField.FieldName

                DisplayQnResponse(sControlName, sBlnValue, sCtrlValue, sFileValue, sFileName)

            End If

        Next
    End Sub
    Private Sub DisplayQnResponse(sElementName As String, sblnAnswer As String, sElementValue As String, Optional sFileUpldID As String = "", Optional sUpldFileName As String = "")

        Dim pane As New Syncfusion.JavaScript.Web.AccordionItem
        Dim ctrlFound As Control
        Dim sCtrlPrefix As String = "MainContent_"
        Dim iQnFieldId As Integer
        Dim sLinkCtrlName As String


        For Each pane In sfaccdQuestion.Items


            ctrlFound = pane.FindControl(sElementName)
            If Not ctrlFound Is Nothing Then
                If TypeOf ctrlFound Is RadioButtonList Then
                    Select Case sblnAnswer
                        Case "True"
                            CType(ctrlFound, RadioButtonList).SelectedIndex = 0
                        Case "False"
                            CType(ctrlFound, RadioButtonList).SelectedIndex = 1
                        Case "2"
                            CType(ctrlFound, RadioButtonList).SelectedIndex = 2
                    End Select

                    'CType(ctrlFound, RadioButtonList).SelectedValue = blnAnswer
                End If

                If TypeOf ctrlFound Is System.Web.UI.WebControls.DropDownList Then
                    CType(ctrlFound, System.Web.UI.WebControls.DropDownList).Text = sElementValue

                End If
                If TypeOf ctrlFound Is TextBox Then
                    CType(ctrlFound, TextBox).Text = sElementValue

                End If
                If TypeOf ctrlFound Is Global.Syncfusion.JavaScript.Web.DatePicker Then
                    CType(ctrlFound, Global.Syncfusion.JavaScript.Web.DatePicker).Value = sElementValue
                End If

                If sUpldFileName <> "" Then
                    iQnFieldId = GetFieldIdControl(sElementName)
                    sLinkCtrlName = "lnk_" & iQnFieldId

                    ctrlFound = pane.FindControl(sLinkCtrlName)
                    If TypeOf ctrlFound Is HyperLink Then
                        CType(ctrlFound, HyperLink).Text = sUpldFileName
                        CType(ctrlFound, HyperLink).NavigateUrl = "~/Areas/TACTemplate/ViewFile.aspx?fid=" & sFileUpldID
                        CType(ctrlFound, HyperLink).Target = "_blank"
                        CType(ctrlFound, HyperLink).Visible = True
                    End If

                End If
            End If

        Next
    End Sub
    Private Sub SaveQuestionAnswer(iQnFieldId As Integer, sAnsValue As String, sQnType As String, iPIndexId As Integer)
        iTemplateId = CInt(Session("TemplateId"))
        'SimpleSQL.runProcedureScalar("csWebData", "TACTmplt_SavePerformedDataValues", iQnFieldId, sAnsValue, sQnType, iTemplateId, iPIndexId)
    End Sub



End Class