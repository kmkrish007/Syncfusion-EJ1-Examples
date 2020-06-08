<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%--<ej:UploadBox ID="upload" runat="server" FileSize="10737418240" SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx"></ej:UploadBox>--%>

    <ej:UploadBox ID="UploadFile" runat="server" MultipleFilesSelection="true" ExtensionsAllow=".pdf,.jpg,.jpeg,.gif,.png" FileSize="26214400" SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx" ClientSideOnError="onError" AutoUpload="true" ClientSideOnComplete="FileUploadComplete" ShowFileDetails="true">
            <UploadBoxButtonText Browse="Allega File" Cancel="Cancella Upload" Upload="Upload File" />
    </ej:UploadBox>
 
</asp:Content>
