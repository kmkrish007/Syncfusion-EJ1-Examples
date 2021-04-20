<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:ListBox ID="ListBox" runat="server" CssClass="custom">
        <Items>
            <ej:ListBoxItems Text="Audi A4"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A5"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A6"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A7"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A8"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 501"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 502"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 503"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Batch"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 507"></ej:ListBoxItems>
        </Items>
    </ej:ListBox>

    <style>
        /*selected item text color*/
        .custom .e-select {
            color: brown;
            background: gold;
        }
        /*hover item color*/
        .custom .e-hover{
            color: chartreuse;
            background-color: crimson;
        }
    </style>

</asp:Content>
