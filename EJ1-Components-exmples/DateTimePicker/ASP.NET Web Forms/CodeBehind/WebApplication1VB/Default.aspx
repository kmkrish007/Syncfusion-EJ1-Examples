<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <ej:DateTimePicker ID="DTPicker" runat="server" Width="220px"></ej:DateTimePicker>
    
    <ej:DateTimePicker ID="DTPicker2" runat="server" Width="220px" DateTimeFormat="d/M/yyyy h:mm tt" Value="06/11/2020 02:32 PM"></ej:DateTimePicker>

</asp:Content>
