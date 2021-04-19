<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="Content/ej/web/default-theme/ej.web.all.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jsrender.min.js"></script>
    <script src="Scripts/ej/web/ej.web.all.min.js"></script>
    <script src="Scripts/ej/common/ej.webform.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</head>
<body>
   <form id="form1" runat="server">

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
			<ej:PercentageTextBox runat="server" ID="txtImpostos" CssClass="form-control"
				Locale="pt-BR" DecimalPlaces="2" ShowSpinButton="false">
			</ej:PercentageTextBox>
		</div>
	</div>
	<div class="form-group row">
		<label for="txtVencimento" class="col-sm-3 col-form-label">Vencimento:&nbsp;</label>
		<div class="col-md-5">
			<ej:DatePicker runat="server" ID="txtVencimento" WatermarkText="Selecione a data"
				DateFormat="dd/MM/yyyy" Locale="pt-BR" CssClass="form-control">
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
       </form>

    <script>
        $(function () {
            $("#txtValor").ejCurrencyTextbox({
                watermarkText: "Amount per unit" // sets watermark in currency                       
            });
        });
    </script>
</body>
</html>
