<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:NumericTextBox ID="Numeric" runat="server" ClientSideOnCreate="OnCreate"></ej:NumericTextBox>

    <script>
        function OnCreate(args) {
            var numObj = $("#<%=Numeric.ClientID%>").ejNumericTextbox("instance");
            numObj.setModel({ value: 23 });
        }
    </script>
</asp:Content>
