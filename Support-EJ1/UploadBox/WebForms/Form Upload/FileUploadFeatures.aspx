<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="FileUpload" AutoEventWireup="true" CodeBehind="FileUploadFeatures.aspx.cs" Inherits="SyncfusionASPNETApplication2.FileUploadFeatures" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ControlRegion">
        <div class="frame">
            <div class="control">
                <div class="posupload" style="display: inline-grid;">
                    <label>Name:</label>
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                    <br />
                    <label>Age:</label>
                    <asp:TextBox ID="Age" runat="server"></asp:TextBox>
                     <br />
                    <label>Resume:</label>
                    <ej:UploadBox ID="Upload1" AsyncUpload="false" runat="server" OnComplete="Upload1_Complete">
                    </ej:UploadBox>
                    <br />
                    <ej:Button ID="post" runat="server" OnClick="post_Click" Text="Save" Width="100px" />
                    <%--Once the  submit button is clicked it triggers the post_Click method of aspx.cs file and selcted file is uploaded.--%>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
