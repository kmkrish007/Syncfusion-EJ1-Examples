<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


   <script id="treeTemplate" type="text/x-jsrender">
            <div class="treename">
                <span class="firstname">{{>FirstName}}</span>
                <span class="lastname">{{>LastName}}</span>
            </div>
    </script>
    
        <ej:TreeView
            ID="treeview"
            runat="server"
            Template="#treeTemplate"
            DataTextField="FirstName"
            DataIdField="Id"
            DataParentIdField="PId"
            DataHasChildField="HasChild"
            DataExpandedField="Expanded"
            CssClass="custom-tree"/>
    
        <style type="text/css">

            .custom-tree.e-treeview .firstname{
                font-style: italic;
                color: blue;
            }

            .custom-tree.e-treeview .lastname{
                font-weight: bold;
                color: red;
            }
        </style>
</asp:Content>
