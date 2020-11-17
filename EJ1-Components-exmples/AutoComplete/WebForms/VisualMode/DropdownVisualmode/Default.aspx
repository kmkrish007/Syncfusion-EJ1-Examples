<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropdownVisualmode._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    Select a component:

<ej:Autocomplete ID="ComponentList" runat="server" DataTextField="ComponentName" DataUniqueKeyField="ComponentName"></ej:Autocomplete>

</div>
    <asp:Button runat="server" Text="click" />


</asp:Content>
