<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <ej:TreeView
            ID="TreeXmlDS"
            runat="server"
            DataSourceID="XmlDataSource1">
     </ej:TreeView>
     <asp:XmlDataSource
                ID="XmlDataSource1"
                runat="server"
                DataFile="~\App_Data\XMLData.xml">
            </asp:XmlDataSource>
</asp:Content>

