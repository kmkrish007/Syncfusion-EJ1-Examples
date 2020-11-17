<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        The Essential ASP.NET WaitingPopup control is a visual element that provides support for displaying a pop-up indicator over a
target area and to prevent the end user’s interaction with the target area while loading.
    </div>

<ej:WaitingPopup ID="WaitingPopup" runat="server" Target="body" ShowOnInit="True" Text="Loading... Please wait..." CssClass="custom"></ej:WaitingPopup>

    <style type="text/css">

     .custom.e-waitpopup-pane.e-widget{
            height:100% !important;
     }
	
	.e-waitpopup-pane .e-text {
		color: white;
	}

    .custom .e-image {
        top: 50% !important;
    }

    .custom .e-text {
        top: 50% !important; 
    }
	
</style>

    <script>
        window.onload = function () {
            popUpObj = $("#<%=WaitingPopup.ClientID%>").data("ejWaitingPopup");
            popUpObj.hide();
        }
    </script>

</asp:Content>
