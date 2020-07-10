<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>You can close the dialog using below button</h3>
        </div>
        <ej:Button Type="Button" ClientSideOnClick="close" runat="server" Text="close"></ej:Button>
    </form>

    <script type="text/javascript">
        function close() {
            var dialogObj = $("#MainContent_dialog").ejDialog("instance");
            dialogObj.close();
        }
    </script>
</body>
</html>
