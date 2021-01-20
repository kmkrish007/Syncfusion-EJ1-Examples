<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />
 <ej:DropDownList ID="DropDownList1" runat="server" DataTextField="Text" DataValueField="Id" Width="235px"
        WatermarkText="- Select a Pay Period -" ClientSideOnChange="validatemsgRemove">
    <ValidationRule>
        <ej:KeyValue Key="required" Value="true" />
    </ValidationRule>
    <ValidationMessage>
        <ej:KeyValue Key="required" Value="* Select any Value" />
    </ValidationMessage>
</ej:DropDownList>

    <br /><br />

    <button type="submit">Validate</button>
    <br /><br />
    <button type="button" onclick="resetform()">Reset</button>
    <script>
        $.validator.setDefaults({
            ignore: [],
            errorClass: 'e-validation-error', // to get the error message on jquery validation
            errorPlacement: function (error, element) {
                $(error).insertAfter(element.closest(".e-widget"));
                $(".e-ddl > span:has(input.e-validation-error)").css("border", "solid red"); // setting border to DDL's container 
            }
            // any other default options and/or rules
        });
        function validatemsgRemove() {
            this.element.valid();
            this.container.css("border", "1px solid #c8c8c8"); // set the border back to initial value for the container
            // OR
          //  $(".e-ddl > span:has(input.valid)").css("border", "1px solid #c8c8c8");
        }
        function resetform() {
            $(".e-ddl > span:has(input.e-validation-error)").css("border", "1px solid #c8c8c8"); // set the border back to initial value for the container
            var validator = $("#form1").validate();
            validator.resetForm(); // resetting form validation
        }
    </script>

</asp:Content>
