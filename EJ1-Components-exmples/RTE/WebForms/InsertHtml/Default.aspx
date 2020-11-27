<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:RTE ID="RTE2" runat="server" ToolsList="style,doAction,lists,images,links">
    <RTEContent>
        <ul>
            <li>The Rich Text Editor  (RTE) control is an easy to render in client side. </li>
            <li>Customer easy to edit the contents and get the HTML content for the displayed content. </li>
            <li> A rich text editor control provides users with a toolbar that helps them to apply rich text formats to the text entered  in the text area.</li>
        </ul>  
    </RTEContent>
    <Tools Styles="bold,italic,underline,strikethrough"
        Lists="unorderedList,orderedList"
        DoAction="undo,redo"
        Links="createLink,removeLink"
        Images="image">
    </Tools>
</ej:RTE>

    <ej:Button ID="Ejbtn" Text="Insert" Type="Button" runat="server" ClientSideOnClick="insert"></ej:Button>

    <script>
        function insert(args) {
            var rteObj = $("#<%=RTE2.ClientID%>").ejRTE("instance");
            rteObj.executeCommand("insertHtml", "<li>new content</li>");
        }
    </script>
</asp:Content>
