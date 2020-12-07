<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>
   <ej:Dialog ID="basicDialog" IsResponsive="True" Width="550" MinWidth="310px" MinHeight="215px" ClientSideOnClose="onDialogClose" Containment=".control" runat="server" Title="Audi Q3 Drive">
            <DialogContent>
                     <img src="Content/images/2.png" class="img" alt="audiq3-1" />
            </DialogContent>
        </ej:Dialog>
        <ej:Button ID="Button1" Type="Button" Text="change image" OnClick="Button1_Click" CssClass="e-btn" runat="server"></ej:Button>

    <style type="text/css">
        .row {
            margin-right: 0;
            margin-left: 0;
        }
    </style>

<script type="text/javascript">
        function btnclick() {
            var dialogObj = $("#<%=basicDialog.ClientID%>").ejDialog("instance");
            dialogObj.open();
        }

    </script>
</asp:Content>
