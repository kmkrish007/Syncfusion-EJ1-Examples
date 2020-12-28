<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <ej:DropDownList ID="txtaddonname" runat="server" Width="100%" DataValueField="Id" ReadOnly="false" ClientSideOnSelect="onSelect" DataTextField="Text"></ej:DropDownList>

    <script>
        function onSelect(args) {
            alert('ok');
        }
    </script>
</asp:Content>
