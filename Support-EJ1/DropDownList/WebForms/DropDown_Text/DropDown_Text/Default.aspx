<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropDown_Text._Default" %>

<%@ Register TagPrefix="ej" Namespace="Syncfusion.JavaScript.Models" Assembly="Syncfusion.EJ" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/x-jsrender" id="columnTemplate">
        <input type="text" class="List"  />
    </script>
    <script type="text/x-jsrender" id="columnTemplate1">
        <input type="text" class="List"  />
    </script>

    <ej:Grid ID="OrdersGrid" runat="server" AllowPaging="true">
        <DataManager URL="http://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/Orders/"></DataManager>  
        <ClientSideEvents TemplateRefresh="template" />
            <Columns>
                <ej:Column Field="OrderID" />
                <ej:Column Field="EmployeeID" />
                <ej:Column Field="CustomerID" />
                <ej:Column HeaderText="Customer" Template="#columnTemplate1"></ej:Column>
                <ej:Column Field="ShipCountry" />
                <ej:Column HeaderText="Temp" Template="#columnTemplate"></ej:Column>
                <ej:Column Field="Freight" />
            </Columns>
    </ej:Grid>

    <ej:DropDownList runat="server" ID="DropDownList1" DataTextField="ShipCountry" DataValueField="ShipCountry"></ej:DropDownList>

    <script type="text/javascript">
        var List = [
        { text: "Action 1", icon: "1"},
        { text: "Action 2", icon: "2" },
        { text: "Action 3", icon: "3" },
    ];

    function template(args) {
        $(args.cell).find('.List').ejDropDownList({
            dataSource: List,
            fields: { text: "text", value: "icon" },
            width: "100px"
        });
    }
</script>
</asp:Content>
