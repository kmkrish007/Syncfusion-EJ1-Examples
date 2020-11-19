<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <ej:Button ID="Button1" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick1" CssClass="e-btn" runat="server"></ej:Button>
    <ej:Dialog ID="NodeDialog" runat="server" ShowOnInit="false" EnableModal="true" ClientSideOnClose="onDialogClose" Width="451" Title="Choose an option">
                <DialogContent>
                    <div title="Save" style="margin-top: 12px;">
                        <div style="height: auto; width: 100%;">
                            <%--<a class="btn btn-success btn-sm fullwidthlink" data-href="/TableInfo.aspx?NODEGUID=" href="/TableINfo.aspx?NODEGUID=">Hi Amigo ivo</a>--%>
                            <a class="btn btn-success btn-sm fullwidthlink" data-href="/About.aspx?NODEGUID=" href="/About.aspx?NODEGUID=">Hi Amigo ivo</a>
                            <br />
                            <br />
                            <%--<a href="javascript:void(0);" onclick="return closeNodeDialog();">Cancel</a>--%>
                            <a class="btn btn-danger btn-sm fullwidth" href="javascript:void(0);" onclick="return closeNodeDialog();">Cancel</a>
                            <%--<div style="display:table-cell;padding-top:10px;padding-bottom:10px;width:100%;text-align:center;">
                                <input type="button" id="CloseButton" onclick="closeNodeDialog()" value="Close" style="background-color: #28B1BF; border: medium none; color: #FFFFFF; font-family: Segoe UI; font-size: 16px; height: 32px; width: 60%;text-align:center" />
                            </div>--%>
                           
                        </div>
                    </div>
                </DialogContent>
            </ej:Dialog> 

        <script type="text/javascript">

        function btnclick1() {
            var dialogObj = $("#<%=NodeDialog.ClientID%>").ejDialog("instance");
            dialogObj.open();
            $("#<%=Button1.ClientID%>").hide();
        }
        function onDialogClose(args) {
            $("#<%=Button1.ClientID%>").show();
        }

    </script>
</asp:Content>
