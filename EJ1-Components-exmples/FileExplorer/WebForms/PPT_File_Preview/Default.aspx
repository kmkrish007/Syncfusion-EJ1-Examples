<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <ej:FileExplorer ID="fexplore" runat="server" Height="100%" Width="100%" AjaxAction="Default.aspx/FileActionDefault" IsResponsive="True" MinWidth="250px" MinHeight="400px" Path="~/FileBrowser/" ClientSideOnBeforeOpen="onOpen">
                   <AjaxSettings>
                        <Download Url="downloadFile.ashx{0}" />
                        <Upload Url="uploadFiles.ashx{0}" />
                   </AjaxSettings>
        </ej:FileExplorer>

    <script>
        function onOpen(args) {
            if (args.path.includes(".pptx")) {
                var items = ~ej.PdfViewer.ToolbarItems.PrintTools & ~ej.PdfViewer.ToolbarItems.DownloadTool;
                var ws = window.open("", '_blank', "width=800,height=600,location=no,menubar=no,status=no,titilebar=no,resizable=no")
                ws.document.write('<!DOCTYPE html><html><head><title>PdfViewer</title><link rel="stylesheet" type="text/css" href="https://cdn.syncfusion.com/17.2.0.36/js/web/flat-azure/ej.web.all.min.css"><script src="https://cdn.syncfusion.com/js/assets/external/jquery-2.1.4.min.js"><\/script><script src="https://cdn.syncfusion.com/17.2.0.36/js/web/ej.web.all.js"><\/script><\/head><body>');
                ws.document.write('<div style="width:100%;min-height:570px"><div id="container"><\/div><\/div>')
                ws.document.write("<script>$(function(){ $('#container').ejPdfViewer({ serviceUrl: '../api/PdfViewer', documentPath: '" + args.selectedItems[0].name + "', toolbarSettings: { toolbarItem:'" + items + "'}})})<\/script>")
                ws.document.write('<\/body><\/html>');
                ws.document.close();
            }
        }
    </script>
</asp:Content>
