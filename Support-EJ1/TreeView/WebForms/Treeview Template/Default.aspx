<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:TreeView 
            ID="treeview" 
        ShowCheckbox="true"
            runat="server" 
            DataTextField="Text" 
            DataIdField="Id" 
            DataParentIdField="Parent" 
            DataExpandedField="Expanded"
        CssClass="custom">
        </ej:TreeView>

    <style type="text/css">


        .custom.e-treeview .e-item .e-item {
            background-image: url(Content//icon//treeview-gray-line.gif);
            background-repeat: repeat-y;
        }

        .custom .e-text-wrap:before {
              display: block;
              content: " ";
              background-image: url(Content//icon//treeview-gray.gif);
              height: 14px;
              position: absolute;
              width: 14px;
              margin-left: -7px;
              margin-top: 4px;
              background-position: -3px -327px;
        }

         .custom .e-icon.e-minus:before,
         .custom .e-icon.e-plus:before{
             content: "";
         }
         </style>
</asp:Content>
