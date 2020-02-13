<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropDown_Value._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:DropDownList ID="DropDownList1" runat="server" DataTextField="Text"  WatermarkText="-Production Cycle-" Width="100%">
                                              
     </ej:DropDownList>

</asp:Content>
