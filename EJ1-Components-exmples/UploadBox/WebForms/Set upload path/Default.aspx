<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <label>Upploadbox</label>
<ej:UploadBox ID="upload" OnComplete="upload_Complete" ClientIDMode="Static" runat="server" FileSize="10737418240" SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx" ClientSideOnBegin="onBegin"  ClientSideOnSuccess="onSuccess" ClientSideOnFileSelect="OnSelect"></ej:UploadBox>

    <script>
        function onSuccess(args) {
            console.log("Path :" + args.responseText);
        }
        function onBegin(args) {
            var type = args.files.extension;
            args.data = "file" + type;
        }

        function OnSelect(args) {
            debugger;
        }

    </script>
</asp:Content>
