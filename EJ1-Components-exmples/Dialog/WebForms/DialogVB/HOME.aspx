<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HOME.aspx.vb" Inherits="WebApplicationVB.HOME1" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <link href="Content/ej/web/bootstrap-theme/ej.web.all.min.css" rel="stylesheet" />
    <%--<link href="../css/web/bootstrap-theme/ej.web.all.min.css" rel="stylesheet" />--%>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jsrender.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <%--<script src="Scripts/js/bootstrap.min.js"></script>--%>
    <script src="Scripts/ej/web/ej.web.all.min.js"></script>
        <script src="Scripts/ej/common/ej.webform.min.js"></script>

    <title><%: Page.Title %></title>
    <style>
        body {
            overflow: hidden;
        }

        #WebForm1.e-dialog.e-widget-content {
            padding: 5px 1px;
            padding-top: 0;
            padding-bottom: 0;
        }

        #WebForm2.e-dialog.e-widget-content {
            padding: 5px 1px;
            padding-top: 0;
            padding-bottom: 0;
        }

        #WebForm3.e-dialog.e-widget-content {
            padding: 5px 1px;
            padding-top: 0;
            padding-bottom: 0;
        }
    </style>

</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server">
        </asp:ScriptManager>
            <a href="#" onclick='openWebForm1()'>WebForm1</a><br />
            <a href="#" onclick='openWebForm2()'>WebForm2</a><br />
            <a href="#" onclick='openWebForm3()'>WebForm3</a>

            <!-- start modals --->
            <ej:Dialog ID="WebForm1" ContentType="iframe" ContentUrl="WebForm1.aspx" Title="WebForm1" ShowRoundedCorner="false" AllowDraggable="true" CloseOnEscape="true" ShowOnInit="false" ClientSideOnClose="onWebFormClose" IsResponsive="True" Width="90%" Height="94%" EnableModal="true" EnableResize="false" runat="server">
            </ej:Dialog>
            <ej:Dialog ID="WebForm2" ContentType="iframe" ContentUrl="WebForm2.aspx" Title="WebForm2" ShowRoundedCorner="false" AllowDraggable="true" CloseOnEscape="true" ShowOnInit="false" ClientSideOnClose="onWebFormClose" IsResponsive="True" Width="90%" Height="94%" EnableModal="true" EnableResize="false" runat="server">
            </ej:Dialog>
            <ej:Dialog ID="WebForm3" ContentType="iframe" ContentUrl="WebForm3.aspx" Title="WebForm3" ShowRoundedCorner="false" AllowDraggable="true" CloseOnEscape="true" ShowOnInit="false" ClientSideOnClose="onWebFormClose" IsResponsive="True" Width="90%" Height="98%" EnableModal="true" EnableResize="false" runat="server">
            </ej:Dialog>

            <!-- end modals --->
    </form>

    <script>
        function openWebForm1() {
            $("#WebForm1").ejDialog("open");
        }

        //dialog close event
        function onWebFormClose() {
            // Get the all ifram elements
            var iframe = document.getElementsByClassName("e-iframe");
            for (var i = 0; i < iframe.length; i++) {
                // reload the iframe
                iframe[i].contentDocument.location.reload();
            }
        }

        function openWebForm2() {
            $("#WebForm2").ejDialog("open");
        }

        function openWebForm3() {
            $("#WebForm3").ejDialog("open");
        }
    </script>
</body>
</html>