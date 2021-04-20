<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DragDrop.aspx.cs" Inherits="WebApplication1.DragDrop" %>

<%@ Register Assembly="Syncfusion.EJ.Web" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <%-- <script src="Scripts/jquery-3.5.1.js"></script>
    <script src="Scripts/jquery.easing.1.3.js"></script>
    <script src="Scripts/jsrender.min.js"></script>
    <script src="Scripts/ej/web/ej.web.all.min.js"></script>
    <script src="Scripts/ej/common/ej.webform.min.js"></script>
    <script src="Scripts/ej/common/ej.core.min.js"></script>
    <script src="Scripts/ej/web/ej.listbox.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/ej/web/ej.widgets.core.bootstrap.min.css" rel="stylesheet" />
    <link href="Content/ej/web/bootstrap-theme/ej.core.min.css" rel="stylesheet" />
    <link href="Content/ej/web/bootstrap-theme/ej.listview.bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/ej/web/bootstrap-theme/ej.listview.min.css" rel="stylesheet" />--%>

    <link href="Content/ej/web/default-theme/ej.web.all.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jsrender.min.js"></script>
    <script src="Scripts/ej/web/ej.web.all.min.js"></script>
    <script src="Scripts/ej/common/ej.webform.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="row">
            <div class="col-md-3 form-group">
            <ej:ListBox ID="ListBox1" runat="server" AllowDragAndDrop="True" OnItemDrop="ListBox1_ItemDrop">
                <Items>
                    <ej:ListBoxItems Text="First" />
                    <ej:ListBoxItems Text="Second" />
                    <ej:ListBoxItems Text="Third" />
                </Items>
            </ej:ListBox>
        </div>
        <div class="col-md-3 form-group">
            <ej:ListBox ID="ListBox2" runat="server" AllowDragAndDrop="True" OnItemDrop="ListBox2_ItemDrop">
                <Items>
                    <ej:ListBoxItems Text="Fourth" />
                    <ej:ListBoxItems Text="Fifth" />
                    <ej:ListBoxItems Text="Sixth" />
                </Items>
            </ej:ListBox>
        </div>
        </div>
    </form>
</body>
</html>
