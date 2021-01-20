<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>
<%@ Register Assembly="Syncfusion.EJ.Web, Version=18.2460.0.44, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register TagPrefix="ej" Namespace="Syncfusion.JavaScript.Models" Assembly="Syncfusion.EJ, Version=18.2460.0.44, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="update1" runat="server">
        <ContentTemplate>
                <label>DatePicker</label>
  <ej:DatePicker runat="server" ID="datep"></ej:DatePicker>

    <label>Toggle button</label>
    <ej:ToggleButton ID="ToggleButtonLarge" runat="server" Size="Large" ShowRoundedCorner="true" DefaultText="Play" ActiveText="Next">
</ej:ToggleButton>
    <label>
        RTE
    </label>
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
            <asp:Button ID="btnAddNew" runat="server" Text="Submit" class="btn btn-lg btn-warning" onclick="btnAddNew_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
