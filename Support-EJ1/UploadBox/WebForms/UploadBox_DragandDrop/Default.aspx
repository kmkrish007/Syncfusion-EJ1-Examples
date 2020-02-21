<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadBox_DragandDrop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <ej:UploadBox ID="UploadACESFile" runat="server"  MultipleFilesSelection="true" AllowDragAndDrop="true" SaveUrl="/SaveFile.ashx" AutoUpload="true" ClientSideOnError="uploaderror" 
                        ClientSideOnSuccess="uploadsuccess" ClientSideOnBeforeSend="uploadbefore" ExtensionsAllow=".zip" FileSize="100000000" DropAreaText="Drop zip files to upload or click">
                        <DialogAction CloseOnComplete="true" />
                    </ej:UploadBox>

    <script type="text/javascript">
        function uploadsuccess() {
            alert("file uploaded");
        }
    </script>
</asp:Content>
