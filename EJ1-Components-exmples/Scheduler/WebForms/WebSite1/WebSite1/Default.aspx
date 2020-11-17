<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
        <ej:DatePicker ID="datepcik" runat="server"></ej:DatePicker>

   <ej:Schedule ClientIDMode="Static" runat="server" ID="Schedule1" Width="100%" Height="525px" timeZone="UTC -05:00" CurrentDate="6/5/2017" ReadOnly="true">
    <AppointmentSettings Id="Id" Subject="Subject" StartTime="StartTime" EndTime="EndTime" Description="Description" AllDay="AllDay" Recurrence="Recurrence" RecurrenceRule="RecurrenceRule"/>
    <DataManager CrossDomain="true" URL="//js.syncfusion.com/demos/ejServices/api/Schedule/LoadData"/>
</ej:Schedule>
</asp:Content>
