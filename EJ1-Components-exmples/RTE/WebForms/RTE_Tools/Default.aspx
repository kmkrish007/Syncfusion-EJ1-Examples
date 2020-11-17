<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <ej:RTE ID="RTE" runat="server" EnableRTL="true" ToolsList="alignment,style,doAction,lists,images,links">
    <Tools Alignment="justifyFull,justifyRight,justifyCenter,justifyLeft"
        Styles="bold,italic,underline,strikethrough"
        Lists="unorderedList,orderedList"
        DoAction="undo,redo"
        Links="createLink,removeLink"
        Images="image">
    </Tools>
</ej:RTE>

</asp:Content>
