<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<%@ Register TagPrefix="ej" Namespace="Syncfusion.JavaScript.Models" Assembly="Syncfusion.EJ" %>
<style>
    input[type=checkbox], input[type=radio]
    {
        margin-right: 3px;
    }
    .ct-label-main
    {
        width:20% !important;
    }
    .ct-value-control
    {
        width:60% !important;
    }
    ul.e-ul.e-horizontal li:first-child
    {
        width:40% !important;
    }

    #currentPage
    {
        background-color:white;

    }
    .darktheme #currentPage
    {
        background-color:black;

    }
    .e-pager .e-pagercontainer 
    {
        margin:0px;
        margin-left: 6px;
    } 
    .e-pagercontainer .e-icon 
    {
        display: inline-block;
        height: 8px;
    }
</style>
<script type="text/x-jsrender" id="pagerTemplate">
        <div class="e-pagercontainer">
            <div class="e-first e-icon e-mediaback e-firstpagedisabled e-disable" title="Go to first page"></div><div class="e-prev e-icon e-arrowheadleft-2x e-prevpagedisabled e-disable" style="border-right:none" title="Go to previous page"></div>
        </div>
        <div class="e-pagercontainer" style="border-radius:0px" >
            <input id="currentPage" class="e-pagercontainer" type="text" style="text-align:center; margin:0px;border:none;width:32px;height:23px" />
        </div>
        <div id="totalPages" class="e-pagercontainer" style="margin-left:2px;margin-bottom:5px;border:none">
            <span></span>
        </div>
        <div class="e-pagercontainer">
            <div class="e-nextpage e-icon e-arrowheadright-2x e-default" title="Go to next page"></div><div class="e-lastpage e-icon e-mediaforward e-default" title="Go to last page"></div>
        </div>
</script>
<script type="text/javascript">
    //For Paging//
    function complete(args) {
            $("#totalPages").find('span').text('of ' + this.model.pageSettings.totalPages);
            if (this.initialRender)
                $("#currentPage").val(1);
            $(".e-pagercontainer:first").css('border-style', 'none');
            if (args.requestType == 'paging') {
                if (this.model.pageSettings.currentPage == this.model.pageSettings.totalPages) {
                    this.element.find('.e-nextpage').addClass('e-nextpagedisabled').removeClass('e-nextpage');
                    this.element.find('.e-lastpage').addClass('e-lastpagedisabled').removeClass('e-lastpage');
                }
                else {
                    this.element.find('.e-nextpagedisabled').addClass('e-nextpage').removeClass('e-nextpagedisabled');
                    this.element.find('.e-lastpagedisabled').addClass('e-lastpage').removeClass('e-lastpagedisabled');
                }
                if (this.model.pageSettings.currentPage == 1) {
                    this.element.find('.e-prevpage').addClass('e-prevpagedisabled e-disable').removeClass('e-prevpage');
                    this.element.find('.e-firstpage').addClass('e-firstpagedisabled e-disable').removeClass('e-firstpage');
                }
                else {
                    this.element.find('.e-prevpagedisabled').addClass('e-prevpage').removeClass('e-prevpagedisabled e-disable');
                    this.element.find('.e-firstpagedisabled').addClass('e-firstpage').removeClass('e-firstpagedisabled e-disable');
                }
                $("#currentPage").val(this.model.pageSettings.currentPage);
            }
        }
        $(function(){
            $('#currentPage').bind('keydown focusout', function (e) {
                var gridObj = $('#gvDepartment').data("ejGrid");
                var val = parseInt($("#currentPage").val());
                var keyCode = e.keyCode;
                if (keyCode == 13 || e.which == 0) {
                    if (val > gridObj.model.pageSettings.totalPages)
                        val = gridObj.model.pageSettings.totalPages;
                    if (val <= 0) {
                        val = 1;
                        $("#currentPage").val(1);
                    }
                    gridObj.gotoPage(val);
                    return false;
                }
            });
    });

    //End***For Paging***//

    function DeleteConfirmation() {
        if (confirm("Do you want to delete" + $('.txtDepartmentName').val() + "?"))
        {
            return true;
        }
        else
            return false;            
    }
</script>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:HiddenField ID="hlAction" runat="server" />
            <div><asp:Label ID="lblDepartmentID" runat="server" Text="Department ID:"></asp:Label></div>
            <div><asp:TextBox ID="txtDepartmentID" runat="server" Enabled="false"></asp:TextBox></div>

            <div><asp:Label ID="lblDepartmentName" runat="server" Text="Department Name:"></asp:Label></div>
            <div><asp:TextBox ID="txtDepartmentName" runat="server" Enabled="false"></asp:TextBox></div>
            <br />
            <div><asp:Label ID="lblITDepartment" runat="server" Text="IT Department:"></asp:Label></div>
             <div>
               <ej:RadioButton Name="Gender1" ID="RadioButton1" runat="server" Size="Small" Checked="false" Text="Yes">

                </ej:RadioButton>
                  <ej:RadioButton Name="Gender1" ID="RadioButton2" runat="server" Size="Small" Checked="false" Text="Yes">

                </ej:RadioButton>
              </div>
           <div>
            <asp:Label ID="Label1" runat="server" Text="Is Active:"></asp:Label>
            </div>
            <div>
                <ej:RadioButton Name="Gender" ID="rdoITDept" runat="server" Size="Small" Checked="false" Text="Yes">

                </ej:RadioButton>
                  <ej:RadioButton Name="Gender" ID="rdoNonITDept" runat="server" Size="Small" Checked="false" Text="Yes">

                </ej:RadioButton>
            </div>
            <div>
                <asp:Button ID="btnAdd" runat="server" Text="Add"  CssClass="btn-form" Width="150px" OnClick="btnAdd_Click"/>
                <asp:Button ID="btnEdit" runat="server" Text="Edit"  CssClass="btn-form" Width="150px" OnClick="btnEdit_Click"/>
                <asp:Button ID="btnDelete" runat="server" Text="Delete"  CssClass="btn-form" Width="150px" OnClick="btnDelete_Click"/>
                <asp:Button ID="btnSave" runat="server" Text="Save"  CssClass="btn-form" Width="150px" OnClick="btnSave_Click"/>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel"  CssClass="btn-form" Width="150px" OnClick="btnCancel_Click" CausesValidation="false"/>
            </div>
            <br />
                    <ej:Grid ID="gvDepartment" runat='server' AllowPaging="true" AllowReordering="True" EnableHeaderHover="false" AllowResizeToFit="True" 
                 AllowSorting="True" AllowTextWrap="true"  AllowFiltering="true" CssClass="grdgroup"
                 OnServerRowSelected="gvDepartment_ServerRowSelected" OnServerExcelExporting="gvDepartment_ServerExcelExporting" OnServerPdfExporting="gvDepartment_ServerPdfExporting">               
                    <Columns>
                        <ej:Column Field="OrderID" HeaderText="Department ID" Width="150px"></ej:Column>                        
                        <ej:Column Field="CustomerID" HeaderText="Department Name" Width="200px"></ej:Column>
                        <ej:Column Field="EmployeeID" HeaderText="IT Department?" Width="150px"></ej:Column>
                        <ej:Column Field="Freight" HeaderText="Status" Width="100px"></ej:Column>
                        <ej:Column Field="OrderDate" HeaderText="Created Date" Format="{0:MM/dd/yyyy hh:mm:ss tt}" Width="160px"></ej:Column>

                    </Columns>
                    <ClientSideEvents  ActionComplete="complete"/>
                    <PageSettings ShowDefaults="false" PageSize="30" EnableTemplates="true" Template="#pagerTemplate" PrintMode="AllPages"/>
                    <ToolbarSettings ShowToolbar="True" ToolbarItems="search,printGrid,excelExport,pdfExport"></ToolbarSettings>
                    <FilterSettings FilterType="Excel"></FilterSettings>
                    
                </ej:Grid>
            </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="gvDepartment"/>
        </Triggers>

    </asp:UpdatePanel> 