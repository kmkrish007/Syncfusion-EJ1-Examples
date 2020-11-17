<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:Button ID="btnClearItem" Type="Button" OnClick="SeverClick"  Text="Clear" runat="server" PrefixIcon="e-icon e-cancel" />

<%--    <ej:ToggleButton ID="ToggleButton1" runat="server" Size="Small" DefaultText="Play" ActiveText="Pause" ContentType="TextAndImage" DefaultPrefixIcon="e-icon e-mediaplay" ActivePrefixIcon="e-icon e-mediapause" ToggleState="false">

</ej:ToggleButton>--%>

<br />

<ej:ToggleButton ID="ToggleButton2" ClientIDMode="Static" runat="server" Size="Small" DefaultText="Go" ActiveText="Stop" ContentType="TextAndImage" DefaultPrefixIcon="e-icon e-mediaplay" ActivePrefixIcon="e-icon e-mediapause" ToggleState="true">

</ej:ToggleButton>
</asp:Content>
