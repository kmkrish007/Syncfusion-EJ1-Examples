<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>
     <asp:LinkButton ID="LinkButtonSave" runat="server" CssClass="btn btn-default" OnClientClick="saveOrder();return false">
        <span aria-hidden="true" data-toggle="tooltip" data-placement="top" title="Save" class="glyphicon glyphicon-floppy-disk"></span>
     </asp:LinkButton>
    <ej:Dialog ID="dialog" runat="server"  ShowOnInit="true" ShowHeader="true" ClientSideOnClose="onDialogClose" ClientSideOnBeforeOpen="onOpen">
        <DialogContent>
            This is dialog content.
        </DialogContent>
    </ej:Dialog>


        <script type="text/javascript">

        function btnclick() {
            var dialogObj = $("#dialog").ejDialog("instance");
            dialogObj.open();
            $("#<%=btnOpen.ClientID%>").hide();
        }
        function onDialogClose(args) {
            $("#<%=btnOpen.ClientID%>").show();
        }

        function onOpen() {
            BtnOBJ = $("#<%=LinkButtonSave.ClientID%>");
            dialogObj = $("#<%=dialog.ClientID%>").data("ejDialog");
            dialogObj.wrapper.find(".e-titlebar").prepend(BtnOBJ);
		}

    </script>
</asp:Content>
