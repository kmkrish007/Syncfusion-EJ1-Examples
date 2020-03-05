<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>
<%@Register Assembly="Syncfusion.EJ, Version=17.4450.0.53, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@Register Assembly="Syncfusion.EJ.Web, Version=17.4450.0.53, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

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
