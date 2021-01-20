﻿<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <span class="txt">Select Item</span>
   <ej:DropDownList ID="ddlgroupsList" Width="100%" EnableFilterSearch="true" MultiSelectMode="VisualMode" runat="server" DataTextField="Text" DataValueField="ID"></ej:DropDownList>
   
</asp:Content>
