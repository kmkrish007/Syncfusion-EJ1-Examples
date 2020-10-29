<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <label>Category: </label>
    <ej:Autocomplete ID="Autocomplete1" runat="server"  DataTextField="Description" DataUniqueKeyField="Product_ID" Width="100%" ShowPopupButton="true" OnValueSelect="Autocomplete1_ValueSelect">
        </ej:Autocomplete>

    <label>select item: </label>
    <ej:Autocomplete ID="Autocomplete2" DataTextField="Products" DataUniqueKeyField="Product_ID" ShowPopupButton="true"  Width="100%" runat="server"> 
     </ej:Autocomplete>

</asp:Content>
