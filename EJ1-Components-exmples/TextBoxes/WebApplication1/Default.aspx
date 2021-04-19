<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#myModal").modal('show');
        });
    </script>
    <div id="myModal" class="modal fade">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                        &times;</button>
                    <h4 class="modal-title">
                        Confirmation</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group row">
		<label for="txtCodigoPagamento" class="col-sm-3 col-form-label">Código:&nbsp;</label>
		<div class="col-md-5">
			<asp:TextBox runat="server" ID="txtCodigoPagamento" CssClass="form-control">
			</asp:TextBox>
		</div>
	</div>
	<div class="form-group row">
		<label for="txtFornecedor" class="col-sm-3 col-form-label">Fornecedor:&nbsp;</label>
		<div class="col-md-5">
			<asp:TextBox runat="server" ID="txtFornecedor" CssClass="form-control"></asp:TextBox>
		</div>
	</div>
	<div class="form-group row">
		<label for="txtValor" class="col-sm-3 col-form-label">Valor:&nbsp;</label>
		<div class="col-md-5">
			<input type="text" id="txtValor" />
		</div>
	</div>
	<div class="form-group row">
		<label for="txtImpostos" class="col-sm-3 col-form-label">Impostos:&nbsp;</label>
		<div class="col-md-5">
			<ej:PercentageTextBox runat="server" ID="txtImpostos" ShowRoundedCorner="true" CssClass="custom"
				Locale="pt-BR" DecimalPlaces="2" ShowSpinButton="false">
			</ej:PercentageTextBox>
		</div>
	</div>
	<div class="form-group row">
		<label for="txtVencimento" class="col-sm-3 col-form-label">Vencimento:&nbsp;</label>
		<div class="col-md-5">
			<ej:DatePicker runat="server" ID="txtVencimento" WatermarkText="Selecione a data" ShowRoundedCorner="true"
				DateFormat="dd/MM/yyyy" Locale="pt-BR" CssClass="custom">
			</ej:DatePicker>
		</div>
	</div>
	<div class="form-group row">
		<label for="txtStatus" class="col-sm-3 col-form-label">Status:&nbsp;</label>
		<div class="col-md-5">
			<asp:TextBox runat="server" ID="txtStatus" ReadOnly="true" CssClass="form-control"></asp:TextBox>
		</div>
	</div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        Close</button>
                    <asp:Button runat="server" ID="btnSaveImage" Text="Save Image" class="btn btn-default"
                        UseSubmitBehavior="false" data-dismiss="modal" />
                </div>
            </div>
        </div>
    </div>

    <script>
        $(function () {
            $("#txtValor").ejCurrencyTextbox({
                watermarkText: "Amount per unit", // sets watermark in currency      
                showSpinButton: false,
                showRoundedCorner: true,
                cssClass : "custom"
            });
        });
    </script>

    <style>
        /*Datepicker input style*/
        .custom.e-datewidget,
        /*CurrencytextBox input style*/
        .custom.e-currency,
        /*PercentagetextBox input style*/
        .custom.e-percent {
            height: 34px;
            width: 100%;
            max-width: 280px;
        }
    </style>
</asp:Content>
