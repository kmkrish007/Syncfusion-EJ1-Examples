<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="frame ">
        <div class="control">
            <h3>Firma del técnico</h3>
            <ej:Signature ID="Signature1" Height="300px" Width="400px" StrokeWidth="3" IsResponsive="true" runat="server" ClientIDMode="Static"></ej:Signature>
        </div>
    </div>
    <%--<asp:Button ID="FirmarButton" runat="server" Text="Firmar" OnClientClick="Firmar()" CssClass="btn btn-primary" />
    <ej:Button ID="add" Text="Firmar" Type="Button" runat="server"  ClientSideOnClick="Firmar"></ej:Button>--%>

            <input id="btnUpload" type="button" value="Save image to folder" onclick="Firmar()" />


   

    <script>
        function Firmar() {

            var obj = $("#<%=Signature1.ClientID%>").ejSignature("instance");
            image = obj._canvas[0].toDataURL("image/png");
            target = image.replace('data:image/png;base64,', '');

            PageMethods.Upload(target, onSucess, onError);

            function onSucess(response) {
                alert(response)
            }
            function onError(response) {
                alert('Something wrong.');
            }
        }
    </script>
    <style type="text/css">
        .frame {
            width: 80%;
        }
    </style>
</asp:Content>
