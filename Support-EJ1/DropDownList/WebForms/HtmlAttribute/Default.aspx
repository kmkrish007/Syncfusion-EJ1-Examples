<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EJDropDownList._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<ej:DropDownList ID="DropDownList1" runat="server" Width="300px" DataTextField="Text" DataValueField="Id" DataHtmlAttributesField="HtmlAttr" EnableFilterSearch="true" MultiSelectMode="Delimiter" FilterType="StartsWith"></ej:DropDownList>


</asp:Content>
