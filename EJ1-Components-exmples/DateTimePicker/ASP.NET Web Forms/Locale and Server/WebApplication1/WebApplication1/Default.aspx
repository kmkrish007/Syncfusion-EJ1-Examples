<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:DateTimePicker ID="DateTimePicker1" runat="server" Value="7/18/2014" Locale="el-GR" Width="180px"></ej:DateTimePicker>

    <ej:Button ID="ejBtn" runat="server" Text="Change value" OnClick="ejBtn_Click"></ej:Button>
</asp:Content>
