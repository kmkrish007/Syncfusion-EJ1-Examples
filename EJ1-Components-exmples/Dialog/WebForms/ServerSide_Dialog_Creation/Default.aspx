<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>
    <div id="ControlDIv" runat="server"></div>

    <script id="sample" type="text/x-jsrender">

	<div class="footerspan" style="float:right">
	
        <ej:Button ID="btn1" runat="server" Size="Mini" Height="30" Width="70" Text="Ok"></ej:Button>
		  
        <ej:Button ID="btn2" runat="server" Size="Mini" Height="30" Width="70" Text="Cancel"></ej:Button>
		  
    </div>
    <div class="condition" style="float:left; margin-left:15px">
  
        <ej:CheckBox ID="check1" runat="server" Text="Dont ask me this again"></ej:CheckBox>
  
    </div>
        </script>

        <script type="text/javascript">

        function btnclick() {
            var dialogObj = $("#dialog").ejDialog("instance");
            dialogObj.open();
            $("#<%=btnOpen.ClientID%>").hide();
        }
        function onDialogClose(args) {
            $("#<%=btnOpen.ClientID%>").show();
        }

    </script>
</asp:Content>
