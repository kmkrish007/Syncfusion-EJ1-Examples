<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:DropDownList ID="ddlEnqType" runat="server"  DataValueField="ValueColumn" DataTextField="TextColumn" WatermarkText="Select Inqury Type"
       DataSourceCachingMode="ViewState" Width="100%" Height="70%" ></ej:DropDownList>

    <ej:Autocomplete ID="txt_Clientname" runat="server"  DataTextField="ClientName" FilterType="Contains" WatermarkText="Select Client"
                                            DataUniqueKeyField="ClientNumber" Width="100%" Height="70%" ShowPopupButton="true" HighlightSearch="true">
                                        <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{1}"  >
                                            <Columns>
                                                <ej:Columns Field="ClientNumber" HeaderText="Client Number" />
                                                <ej:Columns Field="ClientName" HeaderText="Client Name" />
                                                <ej:Columns Field="RMName" HeaderText="RM Name" />
                                            </Columns>
                                        </MultiColumnSettings>
        </ej:Autocomplete>




    <script>
        function onTypeChange(args) {
            var ddlobj = $("#<%= ddlEnqType.ClientID %>").data("ejDropDownList");
            console.log(ddlobj.selectedTextValue);
        }
    </script>



</asp:Content>
