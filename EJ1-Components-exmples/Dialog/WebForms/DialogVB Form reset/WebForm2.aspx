<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplicationVB.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <form id="form3">
        <div class="control">
            <table class="editors">
                <tbody>
                    <tr>
                        <td>
                            <label>Kilometers</label>
                        </td>
                        <td>
                            <ej:NumericTextBox ID="Numeric2" runat="server">
                            </ej:NumericTextBox>
                        </td>
                    </tr>
                    <tr>
                       <td>
                            <label>Service Tax</label>
                        </td>
                        <td>
                            <ej:PercentageTextBox ID="Percent2" runat="server"></ej:PercentageTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Fare</label>
                        </td>
                        <td>
                           <ej:CurrencyTextBox ID="Currency2" runat="server"></ej:CurrencyTextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="pay-bill">
                <ej:Button ID="Pbill2" Type="Button" runat="server" Text="Pay Bill">
                </ej:Button>
            </div>
        </div>
    </form>
    <style type="text/css">
         .frame {
            width: 300px;
        }

        .editors   {
            max-width: 400px;
        }

        .control .pay-bill
        {
            margin-left: 208px;
            margin-top: 15px;
        }

        .editors label
        {
            display: block;
            width: 130px;
        }

        .control
        {
            margin-top: 10px;
        }
        .ctrl-label
        {
            padding-bottom: 3px;
        }
    </style>
</asp:Content>
