<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <ej:Button ID="Button1" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick1" runat="server"></ej:Button>

    <ej:Dialog ID="NodeDialog" runat="server" ShowOnInit="true" EnableModal="true" ClientSideOnClose="onDialogClose" Width="500" Title="Priority Message">
    </ej:Dialog>

    <script type="text/javascript">

        function btnclick1() {
            var dialogObj = $("#<%=NodeDialog.ClientID%>").ejDialog("instance");
            dialogObj.open();
            $("#<%=Button1.ClientID%>").hide();
        }

        function onDialogClose(args) {
            $("#<%=Button1.ClientID%>").show();
        }

    </script>
    <style>
        .e-dialog>.e-header {
            background: coral;
        }
    </style>
</asp:Content>

