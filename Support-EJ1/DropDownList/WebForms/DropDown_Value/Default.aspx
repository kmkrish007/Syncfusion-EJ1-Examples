<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropDown_Value._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<ej:DatePicker runat="server" ID="datePicker"></ej:DatePicker>

<ej:DropDownList runat="server" ID="ddHorariosC" CssClass="form-control" Visible="true" PopupHeight="380px" PopupWidth="130px" Width="92%" DataTextField="Hora" DataValueField="Hora" Enabled="true" WatermarkText="Horario" ToolTip="Color verde horario normal, color rojo horario extraordinario." Style="background-color: whitesmoke" ForeColor="Black" ClientSideOnSelect="selectH"></ej:DropDownList>


    <script type="text/javascript">
        function selectH() {
            $.ajax({
                type: "POST",
                url: "Default.aspx/Buscar",
                data: "{'pedido':'" + JSON.stringify($("#<%=DropDownList1.ClientID%>")[0].value) + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function OnSuccess(data) {
                    var informacion = JSON.parse(data.d);
                    $("#<%=ddHorariosC.ClientID%>").ejDropDownList({ enabled: true, value: informacion[0][0].Horapedido.substring(0, informacion[0][0].Horapedido.length - 3) });
                },
                failure: function (response) {
                }
            });
        }
    </script>
</asp:Content>
