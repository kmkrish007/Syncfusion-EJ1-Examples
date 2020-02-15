<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatePicker_Time._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <ej:DatePicker ID="datepicker1" ClientSideOnChange="onChange" Value="<%# DateTime.Now %>" runat="server"></ej:DatePicker>

    <script>
        function onChange() {
            console.log("changed");
        }
    </script>

</asp:Content>
