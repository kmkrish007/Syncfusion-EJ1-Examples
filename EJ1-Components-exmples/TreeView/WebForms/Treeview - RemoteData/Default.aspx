<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:TreeView runat="server" ID="tree" DataIdField="CategoryID" DataTextField="CategoryName" Query="ej.Query().from('Categories').select('CategoryID,CategoryName').take(25)">
            <DataManager URL="https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/" CrossDomain="true" />
            <Child TableName="Products" ParentId="CategoryID" Text="ProductName" Query="ej.Query().from('Products').select('CategoryID,ProductName').take(25)">
                <DataManager URL="https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/" CrossDomain="true" />
            </Child>
        </ej:TreeView>

</asp:Content>
