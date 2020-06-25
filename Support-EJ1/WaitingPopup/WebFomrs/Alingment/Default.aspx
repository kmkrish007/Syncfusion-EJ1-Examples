<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="targetelement"></div>

<ej:WaitingPopup ID="target" runat="server" Target="#targetelement" ShowOnInit="True" Text="Submitting... Please wait..." CssClass="custom"></ej:WaitingPopup>

    <style type="text/css">

    #targetelement {
        height: 500px;
        width: 1000px;
    }
	
	.e-waitpopup-pane .e-text {
		color: white;
	}

    .custom .e-image {
        top: 50px !important;
    }

    .custom .e-text {
        top: 60px !important; 
    }
	
</style>

</asp:Content>
