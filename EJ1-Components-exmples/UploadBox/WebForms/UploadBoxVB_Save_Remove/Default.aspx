<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="UploadBox_VB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <ej:UploadBox ID="Upload" runat="server" SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx" AutoUpload="true" FileSize="10737418240"></ej:UploadBox>

</asp:Content>
