<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatePicker_Postback._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:DatePicker ID="datepick2" EnablePersistence="true" runat="server"></ej:DatePicker>
    <asp:Button runat="server" Text="Submit"></asp:Button>
</asp:Content>
