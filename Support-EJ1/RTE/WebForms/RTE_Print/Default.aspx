<%@ Page Title="Home Page" Language="C#" Debug="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RTE_Print._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <button id="printBtn" onclick="print()">Print</button>
    <br />
    <br />
    <ej:RTE ID="RTE" runat="server" ToolsList="style,doAction,lists,images,links">
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

    <script>
        function print() {
            var rte = $("#MainContent_RTE").ejRTE("instance");
            rte._onPrint();
        }
    </script>
    <style type="text/css" media="print">
  @page {
    size: auto;  
    margin: 0;  
  }
</style>
</asp:Content>
