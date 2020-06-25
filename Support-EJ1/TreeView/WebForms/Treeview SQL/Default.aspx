<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:TreeView 
            ID="treeview" 
            runat="server" 
            DataSourceID="SqlDataSource1"
            DataTextField="Text" 
            DataIdField="Id" 
            DataParentIdField="ParentID" 
            DataExpandedField="Expanded"
        DataHasChildField="HasChild">
        </ej:TreeView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [TreeData]"></asp:SqlDataSource>
</asp:Content>
