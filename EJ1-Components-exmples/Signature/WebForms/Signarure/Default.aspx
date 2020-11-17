<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Signarure._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <label>Syncfusion Signature</label>
    <div class="control">
        <ej:Signature ID="signature" Height="400px" StrokeWidth="3" IsResponsive="true" runat="server"></ej:Signature>
    </div>

</asp:Content>
