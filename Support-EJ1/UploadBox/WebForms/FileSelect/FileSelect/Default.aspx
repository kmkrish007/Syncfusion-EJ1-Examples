<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileSelect._Default" %>
<%@ Register Assembly="Syncfusion.EJ, Version=13.3451.0.18, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ.Web, Version=13.3451.0.18, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="upload">

    <b>Select a file to upload</b>

    <br /><br />

    <ej:UploadBox ID="Upload1" runat="server" SaveUrl="saveFile.ashx" AutoUpload="true" ClientSideOnFileSelect="fileselect"></ej:UploadBox>

</div>
   
    <script>
        function fileselect() {
            console.log("triggerd");
        }
    </script>

</asp:Content>
