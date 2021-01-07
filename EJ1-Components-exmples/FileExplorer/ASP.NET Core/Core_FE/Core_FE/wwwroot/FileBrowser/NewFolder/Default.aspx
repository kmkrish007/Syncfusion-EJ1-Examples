<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <ej:TreeView
            ID="TreeXmlDS"
            runat="server"
        CssClass="custom"
            DataSourceID="XmlDataSource1"
        ClientSideOnCreated="onCreated">
        </ej:TreeView>
    
        <div>
            <asp:XmlDataSource
                ID="XmlDataSource1"
                runat="server"
                DataFile="~\App_Data\XMLData.xml">
            </asp:XmlDataSource>
        </div>

    <script>
        function onCreated(args) {
            debugger;
        }
    </script>
    <style>
        .custom.e-treeview .e-item {
            /*background-image: url(Content//icons//file_icons.png);*/
            background-image: url(Content//icons//folder.png);
            background-repeat: no-repeat;
            /*background-position: 5px -548px;*/
            background-position: 12px 0px;
        }
        .e-treeview .e-text{
            left: 18px;
    position: relative;
        }

        .e-text-wrap {
    height: 25px;
}
        
    </style>
</asp:Content>

