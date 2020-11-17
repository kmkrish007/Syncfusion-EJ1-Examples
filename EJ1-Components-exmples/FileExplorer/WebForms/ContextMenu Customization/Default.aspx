<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <ej:FileExplorer ID="fexplore" runat="server" Height="100%" Width="100%" AjaxAction="Default.aspx/FileActionDefault" IsResponsive="True" MinWidth="250px" MinHeight="400px" Path="~/FileBrowser/">
                   <AjaxSettings>
                        <Download Url="downloadFile.ashx{0}" />
                        <Upload Url="uploadFiles.ashx{0}" />
                   </AjaxSettings>
           <ContextMenuSettings>
            <Items Navbar="Upload,|,Delete,Rename,|,Cut,Copy,Paste,|,Getinfo"
                Cwd="Refresh,Paste,|,SortBy,|,NewFolder,Upload,|,Getinfo"
                Files="Open,Download,|,Delete,Rename,Custom,|,Cut,Copy,Paste,|,OpenFolderLocation,Getinfo" />
            <CustomMenuFields>
                <ej:FileExplorerCustomMenuFields Id="Custom" Text="Custom Menu" SpriteCssClass="custom-menu">
                </ej:FileExplorerCustomMenuFields>
            </CustomMenuFields>
        </ContextMenuSettings>
        </ej:FileExplorer>

    <style>
        .fe-context-menu .custom-menu:before {
            content: "\e7b9";
        }
    </style>
</asp:Content>
