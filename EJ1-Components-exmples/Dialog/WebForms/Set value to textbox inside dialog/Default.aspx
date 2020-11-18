<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>

<ej:Dialog ID="dialogX" Title="Plan Charge" runat="server" ShowOnInit="false" EnableModal="true">
    <DialogContent>
        <div class="box">
             <div class="box-body">
               <div class="row">
                    <div class="col-md-6">
                       <label>Hall Name</label>
                       <ej:MaskEdit runat="server" ID="txthallname_1" ReadOnly="true" Width="100%"></ej:MaskEdit>
                     </div>
                </div>
             </div>
             <div class="box-footer">
             <asp:LinkButton runat="server" ID="LinkButton1" CssClass="btn btn-danger pull-right" OnClientClick="$('#dialogX').ejDialog('close');return false;">
                  <span class="glyphicon glyphicon-remove"></span>&nbsp;Close
               </asp:LinkButton>
             <div class="pull-right" style="width: 5px">&nbsp;&nbsp;</div>
               <asp:LinkButton runat="server" ID="cmdupdatecharge" CssClass="btn btn-success pull-right">
                <i class="fa fa-save"></i>&nbsp;Save
               </asp:LinkButton>
           </div>
        </div>
 </DialogContent>
</ej:Dialog>


<script type="text/javascript">
    $(function () {
        // way 1 to set the value
        $("#<%=txthallname_1.ClientID%>").ejMaskEdit({ value: "1234" });

        // way 2 to set the value
       // var txtObj = $("#<%=txthallname_1.ClientID%>").ejMaskEdit("instance");
        //txtObj.setModel({ value: "1234" });
    });
        function btnclick() {
            var dialogObj = $("#<%=dialogX.ClientID%>").ejDialog("instance");
            dialogObj.open();
        }

    </script>
</asp:Content>
