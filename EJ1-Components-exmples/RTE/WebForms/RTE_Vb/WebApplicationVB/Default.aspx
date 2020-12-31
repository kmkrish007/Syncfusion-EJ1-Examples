<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">

     <ej:RTE ID="RTE1" ToolsList="images" runat="server" ClientSideOnChange="change" ClientSideOnExecute="execute">
    <RTEContent>
            Description:
            <p> The Rich Text Editor (RTE) control is an easy to render in
            client side. Customer easy to edit the contents and get the HTML content for
            the displayed content. A rich text editor control provides users with a toolbar
            that helps them to apply rich text formats to the text entered in the text
            area. </p>
    </RTEContent>
    <Tools Images="image"> </Tools>
    <ImageBrowser ExtensionAllow="*.png,*.gif,*.jpg,*.jpeg" FilePath="~/FileBrowser/"  AjaxAction="Default.aspx/FileActionDefault"/>
    <FileBrowser ExtensionAllow="*.png,*.txt,*.jpg,*.docx" FilePath="~/FileBrowser/" AjaxAction="Default.aspx/FileActionDefault"/>
</ej:RTE>

    <script>
        function change(args) {
            debugger;
        }
        function execute(args) {
            debugger;
        }
    </script>
</asp:Content>

