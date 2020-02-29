<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button
            ID="add"
            Text="Add Node"
            Type="Button"
            runat="server"
            ClientSideOnClick="Add">
        </ej:Button>
    <ej:TreeView 
            ID="treeview" 
            runat="server" 
            DataTextField="Text" 
            DataIdField="Id" 
            DataParentIdField="Parent" 
            DataExpandedField="Expanded">
        </ej:TreeView>


    <script type="text/javascript">

        function Add() {
            treeObj = $("#<%= treeview.ClientID %>").ejTreeView('instance');
            var newNode = { Id: 11, Text: "Item 2.1" };
            //to add tree node
            treeObj.addNode(newNode, "2");
        }
        
    </script>

</asp:Content>
