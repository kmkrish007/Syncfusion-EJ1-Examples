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


        .custom.e-treeview .e-item {
            background-image: url(Content//icon//Horizontal.png);
            background-repeat: repeat-y;
        }

        .custom.e-treeview .e-text-wrap {
            padding-left: 4px;
        }

        .custom .e-text-wrap:before {
              display: block;
              content: " ";
              background-image: url(Content//icon//Vertical.png);
              height: 10px;
              position: absolute;
              width: 20px;
              margin-left: -17px;
              margin-top: 12px;
              background-repeat: repeat-x;
        }

        .custom.e-treeview .e-icon.e-minus:before {
            content: "";
            font-size: 12px;
            margin-left: 2px;
        }

        .custom.e-treeview .e-icon.e-plus:before {
            content: "";
            font-size: 12px;
            margin-left: 2px;
        }

        .custom.e-treeview .e-icon.e-minus, .custom.e-treeview .e-icon.e-plus{
            border: 1px solid gray;
            padding: 0px;
            display: flex;
            margin-left: -28px;
            align-items: center;
            background-color: darkgrey;
        }

        .e-item.last.e-collapse {
            background-repeat: no-repeat !important;
        }

         </style>
</asp:Content>
