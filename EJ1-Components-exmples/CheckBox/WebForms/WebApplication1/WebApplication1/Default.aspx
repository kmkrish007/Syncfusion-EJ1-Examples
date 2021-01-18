<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="formContainer">
        <ej:Tab ID="TabsADT" runat="server" CssClass="syncTab">
                    <Items>
                        <ej:TabItem ID="triggerDetails" Text="Trigger Details">
                            <ContentSection>
                                <div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Name:</span></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                            <div class="regularBlock">
                                                <ej:MaskEdit InputMode="Text" ID="txtName" ClientIDMode="Static"
                                                    runat="server" Width="400px">
                                                </ej:MaskEdit>
                                            </div>
                                            <div class="regularBlock" style="color: red;">
                                                <strong>*</strong>
                                            </div>
                                            <div class="regularBlock" style="color: red;">
                                                <asp:Label ID="lblTriggerEditStatus" runat="server" ClientIDMode="Static"></asp:Label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact">
                                            <span>Query:
                                            </span>
                                        </div>
                                        <div class="col-xs-6 col-sm-3" style="margin-left: 5px; margin-top: 2px; white-space: nowrap;">
                                            <div class="regularBlock">
                                                <textarea id="txtQuery" class="txtQuery" style="width: 500px; height: 500px; padding-left: 15px;" runat="server"></textarea>
                                            </div>
                                            <div class="regularBlock" style="color: red;">
                                                <strong>*</strong>
                                            </div>
                                            <div class="regularBlock">
                                                <ej:ListBox ID="lstQueryParameters" runat="server" Height="250px" AllowVirtualScrolling="true" ClientIDMode="Static">
                                                    <Items>
                                                        <ej:ListBoxItems Text="AdmitDate"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="DateOfBirth"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="DischargeDate"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="MessageEvent"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="PatientClass"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="PatientFirstName"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="PatientLastName"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="PatientAccountNumber"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="PrimaryInsurance"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="PatientType"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="TotalHours"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="TotalMidnights"></ej:ListBoxItems>
                                                        <ej:ListBoxItems Text="TotalCharges"></ej:ListBoxItems>
                                                    </Items>
                                                </ej:ListBox>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Description:</span></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                            <div class="regularBlock">
                                                <ej:MaskEdit InputMode="Text" ID="txtDescription" ClientIDMode="Static"
                                                    runat="server" Width="600px">
                                                </ej:MaskEdit>
                                            </div>
                                            <div class="regularBlock" style="color: red;">
                                                <strong>*</strong>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Priority:</span></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                            <div class="regularBlock">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <ej:RadioButton Name="rdoPriority" Size="Small" ID="rdoLow" Checked="false" Enabled="true" ClientIDMode="Static"
                                                                runat="server">
                                                            </ej:RadioButton>
                                                            <label for="rdoLow" class="clslab">
                                                                Low
                                                            </label>
                                                        </td>
                                                        <td>
                                                            <ej:RadioButton Name="rdoPriority" Size="Small" ID="rdoMedium" Checked="false" Enabled="true" ClientIDMode="Static"
                                                                runat="server">
                                                            </ej:RadioButton>
                                                            <label for="rdoMedium" class="clslab">
                                                                Medium
                                                            </label>
                                                        </td>
                                                        <td>
                                                            <ej:RadioButton Name="rdoPriority" Size="Small" ID="rdoHigh" Checked="false" Enabled="true" ClientIDMode="Static"
                                                                runat="server">
                                                            </ej:RadioButton>
                                                            <label for="rdoHigh" class="clslab">
                                                                High
                                                            </label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div class="regularBlock" style="color: red;">
                                                <strong>*</strong>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Active time:</span></div>
                                        <div class="fieldLabelText_basic">
                                            <ej:TimePicker ID="timeStart" runat="server" ClientIDMode="Static"></ej:TimePicker>
                                        </div>
                                        <div class="fieldLabelText_basic">&nbsp;to&nbsp;</div>
                                        <div class="fieldLabelText_basic">
                                            <ej:TimePicker ID="timeEnd" runat="server" ClientIDMode="Static"></ej:TimePicker>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Sort Order:</span></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                            <div class="regularBlock">
                                                <ej:NumericTextBox ID="txtSortOrder" runat="server" ClientIDMode="Static">
                                                </ej:NumericTextBox>
                                            </div>
                                            <div class="regularBlock" style="color: red;">
                                                <strong>*</strong>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Product:</span></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                            <ej:CheckBox ID="chxProduct" runat="server" ClientIDMode="Static">
                                            </ej:CheckBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"><span>Active:</span></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                            <ej:CheckBox ID="chxActive" runat="server" ClientIDMode="Static">
                                            </ej:CheckBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="fieldLabel_compact"></div>
                                        <div class="col-xs-6 col-sm-3 fieldLabelText_basic">

                                            <div class="regularBlock">
                                                <asp:LinkButton ID="lnkAddTrigger" runat="server" ClientIDMode="Static" Text="Add" OnClientClick="javascript: AddTriggerAction();" OnClick="lnkAddTrigger_Click"></asp:LinkButton>
                                            </div>
                                            <div class="regularBlock">
                                                <asp:LinkButton ID="lnkSaveTrigger" runat="server" ClientIDMode="Static" Text="Update" OnClick="lnkSaveTrigger_Click"></asp:LinkButton>
                                            </div>
                                          <%--  <div class="regularBlock">
                                                <asp:LinkButton ID="lnkDeleteTrigger" CssClass="linkSpacer_1" runat="server" ClientIDMode="Static" Text="Delete" OnClick="lnkDeleteTrigger_Click"></asp:LinkButton>
                                            </div>--%>
                                            <div class="regularBlock">
                                                <asp:LinkButton ID="lnkCancelTrigger" CssClass="linkSpacer_1" runat="server" ClientIDMode="Static" Text="Cancel" OnClick="lnkCancelTrigger_Click"></asp:LinkButton>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </ContentSection>
                        </ej:TabItem>
                    </Items>
                    <Items>
                        <ej:TabItem ID="question" Text="Questions">
                            <ContentSection>

                                <div>

                                            <div class="regularBlock" style="margin-left: 8px; padding-bottom: 10px;">
                                                <div class="regularBlock">
                                                    <asp:LinkButton runat="server" ID="lnkNewQuestion" Text="Create New Question" OnClientClick="return ShowNewQuestionPanel();"></asp:LinkButton>
                                                </div>
                                                <div class="regularBlock" style="margin-left: 25px;">
                                                    <asp:Label runat="server" ID="lblQuestionSuccess" ClientIDMode="Static"></asp:Label>
                                                </div>
                                            </div>

                                            <div id="dvCreateNewQuestion" style="margin-left: 20px">
                                                <div class="row">
                                                    <div class="fieldLabel_compact"><span>Question:</span></div>
                                                    <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                                        <ej:MaskEdit InputMode="Text" ID="txtQuestion"
                                                            runat="server" ClientIDMode="Static" Width="600px">
                                                        </ej:MaskEdit>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="fieldLabel_compact"><span>QuestionType:</span></div>
                                                    <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                                        <ej:DropDownList ID="ddlQuestionType" ClientIDMode="Static" runat="server">
                                                        </ej:DropDownList>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="fieldLabel_compact"><span>Sort Order:</span></div>
                                                    <div class="col-xs-6 col-sm-3 fieldLabelText_basic">
                                                        <ej:NumericTextBox ID="txtQuestionSortOrder" runat="server" ClientIDMode="Static">
                                                        </ej:NumericTextBox>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="fieldLabel_compact" style="background: #ffffff;"></div>
                                                    <div class="col-xs-6 col-sm-3 fieldLabelText_basic" style="margin-top: 5px;">

                                                        <div class="regularBlock">
                                                            <a href="#" id="lnkAddQuestion">Add</a>
                                                        </div>
                                                        <div class="regularBlock">
                                                            <a href="#" id="lnkUpdateQuestion">Update</a>
                                                        </div>
                                                        <div class="regularBlock">
                                                            <a href="#" id="lnkDeleteQuestion" style="margin-left: 20px;">Delete</a>
                                                        </div>
                                                        <div class="regularBlock">
                                                            <a href="#" id="lnkCancelQuestion" style="margin-left: 20px;">Cancel</a>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>

                                            <script type="text/x-template" id="linkQuestionTemplateEdit">
                                     <div>
                                         <a rel='nofollow' class='hrefTriggerQuestionLink' TriggerQuestionId='{{:TriggerQuestionId}}' href="#">Edit</a> 
                                    </div>
                                            </script>

                                </div>
                            </ContentSection>
                        </ej:TabItem>
                    </Items>
                </ej:Tab>
    </div>
    <asp:HiddenField ID="hdnTriggerId" runat="server" ClientIDMode="Static" />
    <asp:HiddenField ID="hdnTriggerQuestionId" runat="server" ClientIDMode="Static" />

    <script type="text/javascript">

        function updateProgress(value) {
            alert("Cheked status: " + value);
        }
        $(document).ready(function () {
            $("#lnkUpdateQuestion").hide();
            $("#lnkDeleteQuestion").hide();

            

            $("#lnkDeleteTrigger").click(function (e) {

                if (!confirm("Are you sure you want to delete this trigger?")) {
                    e.preventDefault();
                    return false;
                }

            });

            $("#lnkAddTrigger").click(function (e) {

       

            });

            $("#lnkAddQuestion").click(function (e) {

                $("#hdnTriggerQuestionId").val('-1');

                //$("#TriggerGrid").ejGrid("getIndexByRow", $(".gridcontent tr").first());
                QuestionEditAction("add");
                //console.log('editing' + triggerQuestionId);
            });

            $("#lnkUpdateQuestion").click(function (e) {


                //$("#TriggerGrid").ejGrid("getIndexByRow", $(".gridcontent tr").first());
                QuestionEditAction("save");
                //console.log('editing' + triggerQuestionId);
                e.preventDefault();
                return false;
            });

            $("#lnkDeleteQuestion").click(function (e) {

                if (!confirm("Are you sure you want to delete this question?")) {
                    return false;
                }

                //$("#TriggerGrid").ejGrid("getIndexByRow", $(".gridcontent tr").first());
                QuestionEditAction("delete");
                //console.log('editing' + triggerQuestionId);
                e.preventDefault();
                return false;
            });

            $("#lnkCancelQuestion").click(function (e) {
                self.location.href = 'Triggers.aspx';
                e.preventDefault();
                return false;
            });

            $("#dvCreateNewQuestion").hide();
            $(".txtQuery").css("height", "250px").css("padding-left", "15px");


            setTimeout(function () {
                SetupTriggerQuestionEditLinks();
            }, 1000);

            $('#txtQuestionSortOrder').ejNumericTextbox({ watermarkText: "Sort Order" });   //initialize
            $('#txtSortOrder').ejNumericTextbox({ watermarkText: "Sort Order" });   //initialize

            $("#rdoPriority").ejRadioButton({
                validationRules: {
                    required: true
                },
                validationMessage: {
                    required: "Required Radio value"
                }
            });
            $('#rdoLow').ejRadioButton();   //initialize
            $('#rdoMedium').ejRadioButton();   //initialize
            $('#rdoHigh').ejRadioButton();   //initialize

        });

        function AddTriggerAction() {

            //alert($("#rdoPriority").val())
            //e.preventDefault();

            var errortext = "";

            //alert($("#txtDescription").val().trim() == "");
            //alert($("#rdoPriority").val());

            if ($("#txtName").val().trim() == "") {
                errortext += "Query name is missing.<br />";
            }

            if ($(".txtQuery").val().trim() == "") {
                errortext += "Query is missing.<br />";
            }

            if ($("#txtDescription").val().trim() == "") {
                errortext += "Description is missing.<br />";
            }

            var rdoPriority = $("#rdoPriority").ejRadioButton();

            //alert(rdoPriority.ejRadioButton('value'));

            var lowcheck = $("#rdoLow").data('ejRadioButton').isChecked;
            var mediumcheck = $("#rdoMedium").data('ejRadioButton').isChecked;
            var highcheck = $("#rdoHigh").data('ejRadioButton').isChecked;

            if (!lowcheck && !mediumcheck && !highcheck) {
                errortext += "Priority is missing.<br />";
            }

            if ($(".txtSortOrder").val().trim() == "") {
                errortext += "Sort Order is missing.<br />";
            }
            //alert(errortext);

            if (errortext != "") {
                alert(errortext);
                return false;
            }
            else {
                return;
            }
        }

        function ValidateTriggerDetail() {


            return errortext;
        }

        function SetupTriggerQuestionEditLinks() {

            $(".hrefTriggerQuestionLink").click(function () {

                var triggerQuestionId = $(this).attr('TriggerQuestionId');
                LoadTriggerQuestion(triggerQuestionId);
                //console.log('editing' + triggerQuestionId);
                return false;
            });
        }

        function ClearTriggerQuestion() {
            $("#hdnTriggerQuestionId").val("");
            $("#txtQuestion").val("");
            $("#ddlQuestionType").ejDropDownList(
                {
                    value: ""
                });

            $('#txtQuestionSortOrder').ejNumericTextbox({ value: "" });

            //            $("#txtQuestionSortOrder").val("");
        }


        function ShowNewQuestionPanel() {

            if ($("#dvCreateNewQuestion").not(":visible")) {
                $("#dvCreateNewQuestion").show();

            }
            else {
                if ($("#hdnTriggerQuestionId").val().length == 0) {
                    $("#dvCreateNewQuestion").hide();
                }
            }

            $("#lnkAddQuestion").show();
            $("#lnkDeleteQuestion").hide();
            $("#lnkUpdateQuestion").hide();
            $('#lblQuestionSuccess').html('');
            $("#ddlQuestionType").ejDropDownList("enable");

            ClearTriggerQuestion();

            return false;
        }


        $(function () {
            var items = [{
                text: "",
                value: ""
            }, {
                text: "Text",
                value: "Text"
            }, {
                text: "Yes/No",
                value: "Yes/No"
            }];
            $('#ddlQuestionType').ejDropDownList({
                dataSource: items,
                fields: {
                    text: "text",
                    value: "value"
                },
                value: ""
            });
        });

        function QuestionEditAction(theaction) {

            var grid = $("#TriggerQuestionsGrid").ejGrid("instance");

            var triggerQuestionId = $("#hdnTriggerQuestionId").val();
            var triggerQuestion = $("#txtQuestion").val();
            var triggerQuestionType = $("#ddlQuestionType").val();
            var triggerSortOrder = $("#txtQuestionSortOrder").val();

            if (theaction == "add" || theaction == "save") {
                if (triggerQuestion.trim().length == 0
                    || triggerQuestionType.trim().length == 0
                    || triggerSortOrder.trim().length == 0) {

                    $('#lblQuestionSuccess').html('Required fields are missing.');
                    return false;
                }
            }


            var jsonData = JSON.stringify({ action: theaction, triggerQuestionId: triggerQuestionId, triggerQuestion: triggerQuestion, triggerQuestionType: triggerQuestionType, triggerSortOrder: triggerSortOrder });

            //console.log(jsonData);

            $.ajax({
                type: "POST",
                url: "Triggers.aspx/QuestionGridBatchUpdate",
                data: jsonData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {

                    $('#lblQuestionSuccess').html('');
                    $('#dbCreateNewQuestion').hide();

                    $("#lnkAddQuestion").show();
                    $("#lnkDeleteQuestion").hide();
                    $("#lnkUpdateQuestion").hide();
                    $("#ddlQuestionType").ejDropDownList("enable");

                    ClearTriggerQuestion();

                    setTimeout(function () {
                        grid.refreshContent();
                    }, 1000);

                    setTimeout(function () {
                        SetupTriggerQuestionEditLinks();
                    }, 2000);

                    if (theaction == "add") {
                        $('#lblQuestionSuccess').html('The question has been added successfully.');
                    }
                    else if (theaction == "save") {
                        $('#lblQuestionSuccess').html('The question has been saved successfully.');
                    }
                    else if (theaction == "delete") {
                        $('#lblQuestionSuccess').html('The question has been deleted successfully.');
                    }

                },
                failure: function (response) {
                    alert(response.d);
                }
            });


            return false;
        }

        function LoadTriggerQuestion(triggerQuestionId) {

            var triggerId = $("#hdnTriggerId").val();

            $('#lblQuestionSuccess').html('');

            $("#ddlQuestionType").ejDropDownList("disable");

            //console.log(triggerId);
            //console.log(triggerQuestionId);

            var jsonData = JSON.stringify({ triggerId: triggerId, triggerQuestionId: triggerQuestionId });

            $.ajax({
                type: "POST",
                url: "Triggers.aspx/LoadTriggerQuestion",
                data: jsonData,

                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $("#hdnTriggerQuestionId").val(response.d.TriggerQuestionId);
                    //$("#txtQuestionSortOrder").val(response.d.SortOrder);
                    $('#txtQuestionSortOrder').ejNumericTextbox({ value: response.d.SortOrder });

                    $("#ddlQuestionType").val(response.d.QuestionType);
                    $("#txtQuestion").val(response.d.Question);

                    $("#ddlQuestionType").ejDropDownList(
                        {
                            value: response.d.QuestionType
                        });

                    $("#lnkAddQuestion").hide();
                    $("#lnkUpdateQuestion").show();
                    $("#lnkDeleteQuestion").show();
                    $("#dvCreateNewQuestion").show();
                },
                failure: function (response) {
                    alert(response.d);
                }
            });

        }

        function doubleClick(args) {
            //alert("ID Column: " + this.getColumnByIndex(0)["headerText"]);// returns the corresponding column name
            //alert("Row ID Value: " + args.row.find('td:eq(0)').html());// returns the corresponding column name
            //alert("Column Name: " + this.getColumnByIndex(args.cell.index())["headerText"]);// returns the corresponding column name
            //alert("Cell Value: " + args.cell.text());// returns the corresponding cell value
            //alert("Selected cell index: " + args.cell.index());//returns the corresponding cell index
            //alert("ID column corresponding to the selected cell: " + this.getCurrentViewData()[args.row.index()].Id);//returns the corresponding OrderID value.          

            self.location.href = 'Triggers.aspx?TriggerId=' + this.getCurrentViewData()[args.row.index()].Id;
        }

        function getUrlVars() {
            // this is not reliable. Saving the id in a hidden field instead.
            //var vars = [], hash;
            //var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            //for (var i = 0; i < hashes.length; i++) {
            //    hash = hashes[i].split('=');
            //    vars.push(hash[0]);
            //    vars[hash[0]] = hash[1];
            //}
            //return vars;
        }

        function doubleClickTriggerQuestion(args) {
            //alert("ID Column: " + this.getColumnByIndex(0)["headerText"]);// returns the corresponding column name
            //alert("Row ID Value: " + args.row.find('td:eq(0)').html());// returns the corresponding column name
            //alert("Column Name: " + this.getColumnByIndex(args.cell.index())["headerText"]);// returns the corresponding column name
            //alert("Cell Value: " + args.cell.text());// returns the corresponding cell value
            //alert("Selected cell index: " + args.cell.index());//returns the corresponding cell index
            //alert("ID column corresponding to the selected cell: " + this.getCurrentViewData()[args.row.index()].Id);//returns the corresponding OrderID value.          

            self.location.href = 'Triggers.aspx?TriggerId=' + $('#hdnTriggerId').val() + '&TriggerQuestionId=' + this.getCurrentViewData()[args.row.index()].TriggerQuestionId;
            return false;
        }

        function batchDataBoundTriggers(args) {
            this.clearSelection();       //clear the selected records if selected rows are present 
        }

    </script>

</asp:Content>
