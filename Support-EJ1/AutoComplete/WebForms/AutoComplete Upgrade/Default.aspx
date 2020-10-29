<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Autocomplete ID="Autocomplete2" DataSourceID="ObjectDataSource1" ShowPopupButton="true" Width="100%" runat="server" CssClass="custom"> 
        <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{0}">
            <Columns>
            <ej:Columns Field="Name" HeaderText="Name" />
            <ej:Columns Field="Class" HeaderText="Class" />
            <ej:Columns Field="Designation" HeaderText="Designation" />
                <ej:Columns Field="About" HeaderText="About" />
            </Columns>
        </MultiColumnSettings> 
     </ej:Autocomplete>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="WebApplication1.ListViewData" SelectMethod="GetListItems"></asp:ObjectDataSource>

    <style>
        
        /*autocomplete header content*/
        .custom.e-atc-popup .e-atc-tableHeader {
            font-size: 15px;
        }
        /*suggestion list row height */ 
        .custom.e-atc-popup .e-atc-tableContent tr{
            height: 35px;
        }
        /* suggestion grid font */
        .custom.e-atc-popup .e-content{
            font-size: 12px;
            color: brown;
        }
        /* suggestion list hover */
        .custom.e-atc-popup .e-hover, .custom.e-atc-popup .e-content .e-atc-trbgcolor.e-hover{
            background: green;

        }
    </style>
</asp:Content>
