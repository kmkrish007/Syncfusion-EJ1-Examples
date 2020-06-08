<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div>

    Select a component:

<ej:Autocomplete ID="ComponentList" runat="server" MultiSelectMode="VisualMode" DataTextField="ComponentName" DataUniqueKeyField="ComponentName"/>

</div>
    <asp:Button runat="server" Text="click" />

</asp:Content>
