<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            <ej:DatePicker runat="server"  ID="dtpDtTest"></ej:DatePicker>
    <ej:DatePicker ID="datePicker" Value='<%#Bind("BirthDate")%>' TimeZone="false" runat="server"></ej:DatePicker> 
     <ej:DatePicker ID="BirthDateTextBox" MaxDate="<%# DateTime.Now %>" MinDate="01/01/1900" runat="server" Width="145" Height="23" 
                                ClientIDMode="Static" CssClass="DateBox editModeCalendar" DateFormat="dd/MM/yyyy" Value='<%#Bind("BirthDate")%>'></ej:DatePicker>
</asp:Content>
