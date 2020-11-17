<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="FileExplorer" AutoEventWireup="true" CodeBehind="FileExplorerFeatures.aspx.cs" Inherits="SyncfusionASPNETApplication9.FileExplorerFeatures" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>FileExplorer Features:</h2>
<br />
    <%--Path="https://rupeedocs.blob.core.windows.net/docs/">--%>
<br/>            

     <script src='<%= Page.ResolveClientUrl("~/Scripts/ej/i18n/ej.culture.en-US.min.js")%>' type="text/javascript"></script>
			<script src='<%= Page.ResolveClientUrl("~/Scripts/ej/l10n/ej.localetexts.en-US.min.js")%>' type="text/javascript"></script>
<div id = "ControlRegion">
<ej:FileExplorer
            ID="fileexplorer1" ClientSideOnBeforeDownload ="beforeDownload"
            runat="server" 
            AjaxAction="FileExplorerFeatures.aspx/FileActionDefault"
        Path="https://filebrowsercontent.blob.core.windows.net/blob1/Content/"
          <AjaxSettings> 
        <Upload Url="uploadFiles.ashx{0}" /> 
    </AjaxSettings>
        </ej:FileExplorer>
        
       <ej:Dialog ID="helpDialog" Title="FileExplorer Help" ShowOnInit="false" EnableModal="true" Width="350" EnableResize="false" runat="server">
        <DialogContent>
            <div class="text-content">
                <div class="header-content">Need assistance?</div>
                Our help document assists you to know more about FileExplorer control.<br /><br />
                Please refer -> <a href="http://help.syncfusion.com/web" target="_blank">Help Document</a>
            </div>
        </DialogContent>
    </ej:Dialog>
    <script type="text/javascript">
        function dialogOpen() {
            $('#<%=helpDialog.ClientID%>').ejDialog('open')
        }
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
 <script type="text/javascript" >
    $(function () {
           $(document).on("keydown", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $("#<%=fileexplorer1.ClientID%>").find(".e-toolbar").focus();
                }
            });
    });
       </script>
         
</div>
//FeatureScript###
</asp:Content>
