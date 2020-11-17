<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatePicker_Time._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <ej:DatePicker ID="datepicker1" ClientSideOnChange="onChange" Value="<%# DateTime.Now%>" runat="server"></ej:DatePicker>
     <ej:DatePicker ID="datepicker2" Value="02/23/2020" runat="server"></ej:DatePicker>

    <asp:Button Text="submit" runat="server" />
    <script>
        function onChange() {
            console.log("changed");
        }
    </script>

</asp:Content>
