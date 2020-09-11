<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <asp:Button Text="Submit" runat="server"></asp:Button>
    <ej:TreeView ID="TreeViewPlans" runat="server" 
        ShowCheckbox="true" 
        DataTextField="Text" 
        DataIdField="Id" 
        DataParentIdField="ParentID" 
        DataExpandedField="Expanded" 
        DataIsCheckedField="IsChecked" 
        DataHasChildField="HasChild">
    </ej:TreeView>

</asp:Content>

