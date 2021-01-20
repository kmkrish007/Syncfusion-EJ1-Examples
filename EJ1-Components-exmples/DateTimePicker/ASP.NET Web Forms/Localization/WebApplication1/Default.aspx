<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:DateTimePicker ID="DateTimePicker1" runat="server" Value="<%#DateTime.Now%>" Locale="pt-BR" Width="180px"></ej:DateTimePicker>

</asp:Content>
