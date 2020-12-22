<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <ej:DateTimePicker runat="server" Width="220px" TimeDisplayFormat="HH:mm:ss" DateTimeFormat="dd-MMM-yyyy HH:mm:ss" Value="<%# DateTime.Now %>"></ej:DateTimePicker>
    
    
    <ej:DateTimePicker runat="server" Width="220px" TimeDisplayFormat="HH:mm:ss" DateTimeFormat="dd-MMM-yyyy HH:mm:ss" Value="06/11/2015 12:32:43"></ej:DateTimePicker>

</asp:Content>
