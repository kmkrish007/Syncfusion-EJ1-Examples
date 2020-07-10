<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>
     <ej:Dialog IsResponsive="True" ID="dialog" ClientSideOnClose="onDialogClose" ContentUrl="WebForm1.aspx" EnableModal="true" Width="550" Height="auto" Title="Dialog Title" ContentType="ajax" runat="server">
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
</asp:Content>
