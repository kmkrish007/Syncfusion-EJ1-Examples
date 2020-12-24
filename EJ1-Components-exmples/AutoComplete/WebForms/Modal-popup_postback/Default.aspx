<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


        <ej:Button ID="btnOpen" Type="Button" Text="Click to open dialog" ClientSideOnClick="btnclick" CssClass="e-btn" runat="server"></ej:Button>

    <ej:Dialog ID="dialogX" Title="Add Prescription" runat="server" ShowOnInit="false" EnableModal="true" Width="600px" Height="250px">
    <DialogContent>
        <div class="box">
                       <label>Medicine</label>
    <ej:Autocomplete ID="AutoMedicine" runat="server" DataTextField="ProductName" FilterType="StartsWith" DataUniqueKeyField="TM_PRM_ID" Width="100%" ShowPopupButton="true" HighlightSearch="true" PopupHeight="200px" popupWidth="50%" ShowRoundedCorner="True"> 
        <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{0}">
            <Columns>
             <ej:Columns Field="ProductCode" HeaderText="Product Code" />
             <ej:Columns Field="ProductName" HeaderText="Trade Name" />
             <ej:Columns Field="GenericName" HeaderText="Generic Name"/>
            </Columns>
        </MultiColumnSettings> 
     </ej:Autocomplete>
                </div>
 </DialogContent>
</ej:Dialog>
<script type="text/javascript">
        function btnclick() {
            var dialogObj = $("#<%=dialogX.ClientID%>").ejDialog("instance");
            dialogObj.open();
        }

    </script>
</asp:Content>
