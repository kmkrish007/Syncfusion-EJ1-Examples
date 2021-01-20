<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="FileExplorer" AutoEventWireup="true" CodeBehind="FileExplorerFeatures.aspx.cs" Inherits="SyncfusionASPNETApplication9.FileExplorerFeatures" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>FileExplorer Azure:</h2>
<div id = "ControlRegion">
    <ej:FileExplorer runat="server" ID="fileexplorer1" ClientSideOnBeforeDownload ="beforeDownload" AjaxAction="FileExplorerFeatures.aspx/FileActionDefault"
        Path="https://filebrowsercontent.blob.core.windows.net/blob1/Content/">
            <AjaxSettings> 
                <Upload Url="uploadFiles.ashx{0}" /> 
            </AjaxSettings>
     </ej:FileExplorer>
</div>
    <script type="text/javascript">
        function beforeDownload(args) {
            var names = args.files;
            var selectedItems = args.selectedItems;
            var dataValue = { "path": args.path, "names": names}; 
               $.ajax({
                    type: "POST",
                    url: "downloadFile.ashx/Download",
                   data: JSON.stringify(dataValue),
                   contentType: "application/json; charset=utf-8"
            });
            args.cancel = true;
        }
    </script>
    <style type="text/css">
        .e-fileExplorer-toolbar-icon {
            height: 22px;
            width: 22px;
            font-family: 'ej-webfont';
            font-size: 18px;
            margin-top: 2px;
            text-align: center;
        }
        .e-fileExplorer-toolbar-icon.Help:before {
            content: "\e72b";
        }
        .e-dialog .header-content {
           font-size:16px;
           margin-top: .5em;
           margin-bottom: 1em;
        }
        .e-dialog>.e-titlebar {
            padding: .25em .25em .25em 1em;
        }
        .e-dialog.e-dialog-wrap {
            border: none;
        }
        .e-dialog .e-dialog-icon {
            right: 0;
        }
    </style>
</asp:Content>
