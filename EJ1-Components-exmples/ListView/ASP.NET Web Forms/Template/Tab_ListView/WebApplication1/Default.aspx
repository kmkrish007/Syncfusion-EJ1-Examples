<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Tab ID="DishType" runat="server" Width="800px" ClientSideOnActive="onTabActive">
            <Items>
                <ej:TabItem Id="PizzaType" Text="Pizza Menu">
                    <ContentSection>
                        <div id="div_sdn_lst" runat="server">
                            <ej:ListView ID="lstSDN1" AllowScrolling="true" runat="server" ShowScrollbars="true" ShowHeader="true" HeaderTitle="OFAC SDN " Height="400" Width="600" RenderTemplate="true" TemplateId="template">
                           </ej:ListView>
                        </div>
                    </ContentSection>
                </ej:TabItem>

                <ej:TabItem Id="SandwichType" Text="Sandwich Menu">

                    <ContentSection>

                       <div id="div1" runat="server">
                            <ej:ListView ID="lstSDN" AllowScrolling="true" runat="server" ShowScrollbars="true" ShowHeader="true" HeaderTitle="OFAC SDN " Height="400" Width="600" RenderTemplate="true" TemplateId="template">
                           </ej:ListView>
                        </div>

                    </ContentSection>

                </ej:TabItem>

            </Items>

        </ej:Tab>
    

     <script type="text/x-jsrender" id="template">
        <div class="templatetext">
            <span style="font-weight: bold">Type :</span> {{:Class}}
            <br />
            <span style="font-weight: bold">Name : </span>{{:Name}} 
            <br />
            <span style="font-weight: bold">Remarks : </span>{{:Designation}} 
        </div>
    </script>

    <style>

        .templatetext {
            height: 60px;
            display: block;
            font-size: 13px !important;
            color: #333333;
            width: 600px;
            padding: 5px;
        }
      
    </style>

    <script>
        function onTabActive(args) {
            var listObj = $("#<%=lstSDN.ClientID %>").ejListView("instance");
            listObj._refresh();
        }
    </script>
</asp:Content>
