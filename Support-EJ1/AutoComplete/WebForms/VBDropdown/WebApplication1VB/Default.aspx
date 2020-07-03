<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <label>Code behind event binding</label>
<ej:Autocomplete ID="ref" runat="server" DataTextField="Text" DataUniqueKeyField="ID" ShowPopupButton="true" EmptyResultText="No suggestions" />

    <br />
    <br />
  <label>control level event binding</label>
<ej:Autocomplete ID="AutoComplete" runat="server" DataTextField="Text" DataUniqueKeyField="ID" ShowPopupButton="true" EmptyResultText="No suggestions" OnValueSelect="AutoComplete_ValueSelect" />


</asp:Content>
