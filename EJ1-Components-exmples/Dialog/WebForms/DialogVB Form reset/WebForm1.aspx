<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" MasterPageFile="~/Site.Master" Inherits="WebApplicationVB.WebForm1" %>

<asp:Content ID="BodyContent" runat="server" contentplaceholderid="MainContent">

    <form id="form2">
        <div class="control">
            <table class="editors">
                <tbody>
                    <tr>
                        <td>
                            <label>Kilometers</label>
                        </td>
                        <td>
                            <ej:NumericTextBox ID="Numeric" runat="server">
                            </ej:NumericTextBox>
                        </td>
                    </tr>
                    <tr>
                       <td>
                            <label>Service Tax</label>
                        </td>
                        <td>
                            <ej:PercentageTextBox ID="Percent" runat="server"></ej:PercentageTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Fare</label>
                        </td>
                        <td>
                           <ej:CurrencyTextBox ID="Currency" runat="server"></ej:CurrencyTextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="pay-bill">
                <ej:Button ID="Pbill" Type="Button" runat="server" Text="Pay Bill">
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
