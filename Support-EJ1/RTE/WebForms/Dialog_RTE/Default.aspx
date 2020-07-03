<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button ID="btn" runat="server" Text="Open" ClientSideOnClick="Open" Type="Button"></ej:Button>
    <ej:Dialog ID="Dialog1" runat="server" EnableModal="true" ShowOnInit="false" Width="500">
        <DialogContent>
            <ej:RTE ID="rteSample" runat="server" Width="450" IsResponsive="true">
                <ImportSettings Url="Import.ashx" />
                <ExportToWordSettings Url="Default.aspx/ExportToWord" FileName="WordExport" />
                <ExportToPdfSettings Url="Default.aspx/ExportToPDF" FileName="PdfExport" />
                 <Tools  ImportExport="import,wordExport,pdfExport"></Tools>
            </ej:RTE>
        </DialogContent>
    </ej:Dialog>
    <script>
        function Open(args) {
            var diaObj = $("#<%=Dialog1.ClientID%>").data("ejDialog");
            diaObj.open();

        }
    </script>

</asp:Content>
