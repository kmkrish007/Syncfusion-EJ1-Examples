<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="UploadBox_VB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <ej:UploadBox ID="UploadACESFile" runat="server"  MultipleFilesSelection="true" Locale="en-US" AllowDragAndDrop="true" SaveUrl="/SaveFile.ashx" AutoUpload="true" ClientSideOnError="uploaderror" 
                 ClientSideOnSuccess="uploadsuccess" ClientSideOnBeforeSend="uploadbefore" ExtensionsAllow=".zip" FileSize="100000000" DropAreaText="Drop zip files to upload or click">
                        <DialogAction CloseOnComplete="true" />
                    </ej:UploadBox>

    <script type="text/javascript">
        function uploadsuccess() {
            alert("file uploaded");
        }
        ej.Uploadbox.Locale["en-CA"] = {
            buttonText: {
                upload: "Upload",
                browse: "Browse",
                cancel: "Cancel",
                close: "Close"
            },
            dialogText: {
                title: "Upload Box",
                name: "Name",
                size: "Size",
                status: "Status"
            },
            dropAreaText: "Drop files or click to upload",
            filedetail: "The selected file size is too large. Please select a file within the valid size.",
            denyError: "Files with #Extension extensions are not allowed.",
            allowError: "Only files with #Extension extensions are allowed.",
            cancelToolTip: "Cancel",
            removeToolTip: "Remove",
            retryToolTip: "Retry",
            completedToolTip: "Completed",
            failedToolTip: "Failed",
            closeToolTip: "Close"
        };
    </script>

</asp:Content>
