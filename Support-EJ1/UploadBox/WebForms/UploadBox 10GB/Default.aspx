<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<ej:UploadBox ID="upload" runat="server" FileSize="10737418240" SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx"></ej:UploadBox>
 
</asp:Content>
