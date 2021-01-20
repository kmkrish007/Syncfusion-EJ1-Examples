<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<%@ Register Assembly="Syncfusion.EJ, Version=18.1460.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ.Web, Version=18.1460.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ, Version=18.1460.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Models" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ, Version=18.1460.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.DataVisualization.Models" TagPrefix="ej" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:DateRangePicker ID="drp" runat="server" Width="500"></ej:DateRangePicker>

</asp:Content>
