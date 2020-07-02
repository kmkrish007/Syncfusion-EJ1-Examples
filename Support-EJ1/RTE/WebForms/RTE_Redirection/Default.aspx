<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <ej:RTE ID="RTE_Custom_Welcome_Text" runat="server" ToolsList="style,doAction,lists,images,links">
    <RTEContent>
        Welcome to the section of the CE Portal for Sample Memorial Hospital.  This is the one spot where you can find upcoming events, download course materials, take online evaluations, and login to get your CE certificates and transcripts. <br><br> This portal is a collaboration between Sample Memorial Hospital and the education documentation system, eeds.  As a result, some links make take you away from this portal and <span style="color: rgb(149, 55, 52);"><b>to the eeds website to access more information.</b></span>
    </RTEContent>
    <Tools Styles="bold,italic,underline,strikethrough"
        Lists="unorderedList,orderedList"
        DoAction="undo,redo"
        Links="createLink,removeLink"
        Images="image">
    </Tools>
</ej:RTE>

    <asp:Button ID="Sub" Text="Submit" runat="server" OnClick="Sub_Click" />

</asp:Content>
