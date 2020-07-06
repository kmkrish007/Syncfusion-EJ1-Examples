<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <ej:Button ID="Button1" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick1" runat="server"></ej:Button>
    <ej:Button ID="Button2" Type="Button" Text="Click to open dialog 2" ClientSideOnClick="btnclick2" runat="server"></ej:Button>

    <ej:Dialog ID="NodeDialog" runat="server" ShowOnInit="false" EnableModal="true" ContentType="iframe" ContentUrl="WebForm1.aspx" ClientSideOnClose="onDialogClose" Width="500" Height="600" Title="Choose an option">
    </ej:Dialog> 

    <ej:Dialog ID="NodeDialog2" runat="server" ShowOnInit="false" EnableModal="true" ContentType="iframe" ContentUrl="WebForm2.aspx" ClientSideOnClose="onDialogClose2" Width="500" Height="600" Title="Form 2">
    </ej:Dialog>

    <script type="text/javascript">

        function btnclick1() {
            var dialogObj = $("#<%=NodeDialog.ClientID%>").ejDialog("instance");
            dialogObj.open();
            $("#<%=Button1.ClientID%>").hide();
        }

        function onDialogClose(args) {
            $("#<%=Button1.ClientID%>").show();
            var iframe = document.getElementsByClassName("e-iframe");
            for (var i = 0; i < iframe.length; i++) {
                var formCtrl = iframe[i].contentWindow.document.getElementsByTagName('form')[0];
                formCtrl.reset();
            }
        }

        function btnclick2() {
            var dialogObj = $("#<%=NodeDialog2.ClientID%>").ejDialog("instance");
            dialogObj.open();
        }

        function onDialogClose2() {
            var iframe = document.getElementsByClassName("e-iframe");
            for (var i = 0; i < iframe.length; i++) {
                var formCtrl = iframe[i].contentWindow.document.getElementsByTagName('form')[0];
                formCtrl.reset();
            }
        }

    </script>
    
</asp:Content>

