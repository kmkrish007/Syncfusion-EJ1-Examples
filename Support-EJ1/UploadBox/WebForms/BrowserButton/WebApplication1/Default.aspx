<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <ej:UploadBox ID="uploader" runat="server"
                                    AutoUpload="false"
                                    AllowDragAndDrop="false"
                                    MultipleFilesSelection="true"
                                    ShowBrowseButton="true"
                                    SaveUrl="SaveFile.ashx"
                                    RemoveUrl="removeFile.ashx">
                                </ej:UploadBox>
</asp:Content>
