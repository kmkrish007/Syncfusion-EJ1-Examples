<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>File Path:</div><label id="filepath">~/FileBrowser/</label>
    <br />
    <br />
       <ej:FileExplorer ID="fexplore" runat="server" Height="100%" Width="100%" AjaxAction="Default.aspx/FileActionDefault" IsResponsive="True" MinWidth="250px" MinHeight="400px" Path="~/FileBrowser/" ClientSideOnSelect="select">
                   <AjaxSettings>
                        <Download Url="downloadFile.ashx{0}" />
                        <Upload Url="uploadFiles.ashx{0}" />
                   </AjaxSettings>
        </ej:FileExplorer>

    <script>
        function select() {
            var feObj = $("#<%= fexplore.ClientID%>").ejFileExplorer("instance");
            // first way
            document.getElementById("filepath").innerText = feObj._currentPath;
        }
    </script>
</asp:Content>
