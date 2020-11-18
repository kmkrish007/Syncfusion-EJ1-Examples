<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>
     <ej:Dialog IsResponsive="True" ID="dialog" CssClass="custom" ClientSideOnClose="onDialogClose" EnableModal="true" Width="550" Height="auto" Title="Dialog Title" runat="server">
         <DialogContent>
             <p>This is a simple dialog</p>
        </DialogContent>
     </ej:Dialog>
            

    <script type="text/javascript">

        function btnclick() {
            var dialogObj = $("#<%=dialog.ClientID%>").ejDialog("instance");
            dialogObj.open();
            $("#<%=btnOpen.ClientID%>").hide();
        }
        function onDialogClose(args) {
            $("#<%=btnOpen.ClientID%>").show();
        }

    </script>

    <style>
        /*dialog header */
        .custom.e-dialog .e-header {
            background: bisque;
            border-bottom: 3px solid blue;
        }

        /*dialog header title*/
        .custom.e-dialog .e-title{
            color: red;
        }

        /*dialog content */
        .custom .e-dialog.e-widget-content{
            background: cyan;
        }

        /*dialog content */
        .custom.e-dialog.e-dialog-wrap {
            font-family: monospace;
        }
    </style>
</asp:Content>
