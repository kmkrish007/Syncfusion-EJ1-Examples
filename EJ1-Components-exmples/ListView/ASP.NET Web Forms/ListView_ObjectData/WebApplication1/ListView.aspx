<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="WebApplication1.ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/ej/web/default-theme/ej.web.all.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jsrender.min.js"></script>
    <script src="Scripts/ej/web/ej.web.all.min.js"></script>
    <script src="Scripts/ej/common/ej.webform.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <div id="templatelist">
                <div class="cont-bg">
                    <div class="{{>Class}}">
                    </div>
                    <div class="listrightdiv">
                        <span class="templatetext">{{>Name}}</span> <span class="designationstyle">{{>Designation}}</span>
                        <div class="aboutstyle">
                            {{>About}}
                        </div>
                    </div>
                </div>
            </div>
            <ej:ListView ID="ListView1" runat="server" AllowScrolling="false" DataSourceID="ObjectDataSource1" ShowHeader="false" RenderTemplate="true" TemplateId="templatelist" Height="415" Width="450">
            </ej:ListView>

           <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="WebApplication1.ListViewData" SelectMethod="GetListItems"></asp:ObjectDataSource>



    </form>
</body>
</html>
