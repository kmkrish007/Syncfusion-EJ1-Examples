<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <ej:DropDownList ID="ddlMGDL" runat="server" DataTextField="Text"
                    DataValueField="Id"
         DataSelectedField="Selected"
                    EnableIncrementalSearch="true"
                    EnableFilterSearch="true"
                    CaseSensitiveSearch="true"
                    EnableRTL="true"
                    FilterType="Contains"
                    Width="250px"
                    ViewStateMode="Enabled"
                    ShowCheckbox="true"
                    AllowVirtualScrolling="true"
                    MultiSelectMode="VisualMode">
     </ej:DropDownList><br />

   <ej:Button Type="Button" runat="server" ID="Button1" Text="Check All" OnClick="Button1_Click1"></ej:Button>


</asp:Content>
