<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>
     
                  <asp:UpdatePanel ID="updPnl" runat="server" UpdateMode="Conditional" RenderMode="Block">
                           <ContentTemplate>
    <ej:Dialog runat="server" EnableModal="true" EnableViewState="true" ID="d_addons" IsResponsive="true" ShowOnInit="false" Title="Addon Entry">
                                <DialogContent>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label>Addon</label>
                                            <ej:DropDownList ID="txtaddonname" runat="server" Width="100%" DataTextField="Text" OnValueSelect="txtaddonname_ValueSelect"></ej:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-4">
                                            <label>Qty</label>
                                            <ej:MaskEdit runat="server" ID="txtaddonqty" Width="100%" ReadOnly="false"></ej:MaskEdit>
                                        </div>
                                        <div class="col-md-4">
                                            <label>Rate</label>
                                            <ej:MaskEdit runat="server" ID="txtaddonunitrate" Width="100%" ReadOnly="true"></ej:MaskEdit>
                                        </div>
                                        <div class="col-md-4">
                                            <label>Total</label>
                                            <ej:MaskEdit runat="server" ID="txtaddontotal" Width="100%" ReadOnly="true"></ej:MaskEdit>
                                        </div>
                                    </div>
                                    <br />
                                    <button id="cmdaddonclose" class="btn btn-danger pull-right"

                                        onclick="$('#d_addons').ejDialog('close');return(false);">

                                                <i class="fa fa-remove"></i> Close

                                    </button>

                                    <div class="pull-right" style="width: 5px">  </div>

                                    <button id="cmdaddonsave" class="btn btn-primary pull-right"

                                        onclick="return(false);">

                                                <i class="fa fa-check"></i> Apply

                                    </button>



                                    <br />

                                    <br />

                                </DialogContent>

                            </ej:Dialog>
        </ContentTemplate>

                    </asp:UpdatePanel>
    
    <style type="text/css">
        .row {
            margin-right: 0;
            margin-left: 0;
        }
    </style>

<script type="text/javascript">
        function btnclick() {
            var dialogObj = $("#<%=d_addons.ClientID%>").ejDialog("instance");
            dialogObj.open();
        }

    </script>
</asp:Content>
