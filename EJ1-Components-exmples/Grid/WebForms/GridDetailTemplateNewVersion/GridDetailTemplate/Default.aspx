<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridDetailTemplate._Default" %>
<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<%@ Register assembly="Syncfusion.EJ, Version=18.2460.0.47, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" namespace="Syncfusion.JavaScript.Models" tagprefix="ej" %>
<%@ Register TagPrefix="ej" Namespace="Syncfusion.JavaScript.Models" Assembly="Syncfusion.EJ" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

                <%--<ej:Grid ID="gvRequests" runat='server' AllowPaging="True" AllowReordering="True" EnableHeaderHover="false" AllowResizeToFit="True"
                AllowSorting="True" AllowTextWrap="true" AllowFiltering="true" Width="2500px" DetailsTemplate="#tabGridContents">
                    <ClientSideEvents ActionComplete="complete" RowDataBound="rowDataBound" DetailsDataBound="detailGridData" />                    
                    <Columns>
                        <ej:Column Field="EmployeeID" HeaderText="Employee ID" IsPrimaryKey="True" TextAlign="Right" Width="75" />
                        <ej:Column Field="FirstName" HeaderText="First Name" Width="100" />
                        <ej:Column Field="Title" HeaderText="Title" Width="120" />
                        <ej:Column Field="City" HeaderText="City" Width="100" />
                        <ej:Column Field="Country" HeaderText="Country" Width="100" />

                    </Columns>
                    <PageSettings ShowDefaults="false" PageSize="10" EnableTemplates="true" Template="#pagerTemplate" PrintMode="AllPages"/>
                    <ToolbarSettings ShowToolbar="True" ToolbarItems="search,printGrid,excelExport,pdfExport"></ToolbarSettings>
                    <FilterSettings FilterType="Excel"></FilterSettings>
                </ej:Grid>

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

                <script id="tabGridContents" type="text/x-jsrender">
                    <div class="tabcontrol">
                        <ul>
                            <li><a href="#detailChart{{:EmployeeID}}">Status Chart</a>
                            </li>
                            <li><a href="#gridTab{{:EmployeeID}}">Sub Form(s)</a>
                            </li>
                         </ul>
                        <div id="detailChart{{:EmployeeID}}"></div>
                        <div id="gridTab{{:EmployeeID}}">
                            <div id="detailGrid"></div>
                        </div>
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
                                var gridObj = $('#<%= gvRequests.ClientID %>').data("ejGrid");
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

                    function detailGridData(e) {
                        var filteredData = e.data["EmployeeID"];
                        var ele = e.detailsElement;
                        $.ajax({
                            type: "POST",
                            url: "/Default.aspx/Data2",
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',

                            success: function (data) {
                                debugger
                                var data = ej.DataManager(data.d).executeLocal(ej.Query().where("EmployeeID", "equal", parseInt(filteredData), true));
                                ele.find("#detailGrid").ejGrid({
                                    dataSource: data,
                                    allowSelection: false,
                                    columns: [
                                        { field: "OrderID", key: true, headerText: "Order ID", width: 80, textAlign: ej.TextAlign.Right },
                                        { field: "CustomerID", headerText: 'Customer ID', width: 80, textAlign: ej.TextAlign.Left },
                                        { field: "CompanyName", headerText: 'Company Name', width: 120, textAlign: ej.TextAlign.Left },
                                        { field: "ShipCity", headerText: 'City', width: 120, textAlign: ej.TextAlign.Left }
                                    ]
                                });



                                ele.css("display", "");
                                ele.find("#detailChart" + filteredData).ejChart({
                                   series:[
				                 {
                                points: [{ x: 'Other Personnal', y: 94658, text: 'Other Personal, 88.47%' },
                                         { x: 'Medical care', y: 9090, text: 'Medical care, 8.49%' },
							             { x: 'Housing', y: 2577, text: 'Housing, 2.40%' },
                                         { x: 'Transportation', y: 473, text: 'Transportation, 0.44%' },
                                         { x: 'Education', y: 120, text: 'Education, 0.11%' },
                                         { x: 'Electronics', y: 70, text: 'Electronics, 0.06%' }],                         
                                marker: 
					            {
                                    dataLabel: 
						            {
							            visible:true,
                                        shape: 'none', 
							            connectorLine: { type: 'bezier',color: 'black' },
                                        font: {size:'14px'},
							            enableContrastColor:true
						            }
                                },
                                border :{width:2, color:'white'}, 
                                name: 'Expenses', 
					            type: 'pie', 
					            enableAnimation : true, 
					            labelPosition:'outsideExtended', 
					            enableSmartLabels:true, startAngle:145
                            }
                        ],
                        load: "loadTheme",
			            seriesRendering:"seriesRender",
                        title:{text: 'Expenditures'},		
                        isResponsive: true,
                        size: { height: "600"},
                        legend: { visible: false}
                    });				
                   
                                ele.find(".tabcontrol").ejTab({ selectedItemIndex: 1 });
                            }
                            // the datasource "window.ordersView" is referred from jsondata.min.js



                        });
                    }
                </script>--%>
</asp:Content>
