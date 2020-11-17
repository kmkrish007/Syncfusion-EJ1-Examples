<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button runat="server" Type="Button" ClientSideOnClick="printPage" Text="Print"></ej:Button>

    <%--<asp:LinkButton ID="btnprint" OnClientClick="printPage" Text="print" ToolTip="Print" runat="server"></asp:LinkButton>--%>

    <div class="col-md-12 " id="printableArea">
        <ej:DatePicker ID="txt_FilingDate" runat="server"></ej:DatePicker>
        <ej:Autocomplete ID="txt_ClientName" runat="server"></ej:Autocomplete>
        
                                                    <ej:Accordion ID="Ard_Audit" runat="server" Collapsible="true" EnableMultipleOpen="true">
                                                        <Items>
                                                            <ej:AccordionItem Text="Data" AjaxUrl="EmpRecord.html">
                                                            </ej:AccordionItem>
                                                        </Items>
                                                        <Items>
                                                            <ej:AccordionItem Text="Grid">
                                                                <ContentSection>
                                                                    <ej:Grid runat="server" ID="Grid">                        
           <Columns>
               <ej:Column Field="FirstName" HeaderText="First Name"></ej:Column>
               <ej:Column Field="LastName" HeaderText="Last Name"></ej:Column>
               <ej:Column Field="Email" HeaderText="Email"></ej:Column>
           </Columns>          
</ej:Grid>
                                                                </ContentSection>
                                                            </ej:AccordionItem>
                                                        </Items>
                                                    </ej:Accordion>
                                               
        </div>

    <script>
         function printPopup(data) {  
            var mywindow = window.open('', 'PRINT', 'height=600,width=800');  
            
            mywindow.document.write('<html><head><title>' + document.title + '</title>');
          //  mywindow.document.write('<link href="../assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />');
           // mywindow.document.write('<link href="../Assets/Script/jquery-ui.css" rel="stylesheet" type="text/css" />');
           // mywindow.document.write('<link href="../Content/ejthemes/ej.widgets.core.css" rel="stylesheet" type="text/css" />');  
            //mywindow.document.write('<link href="../Content/ejthemes/bootstrap-theme/ej.theme.css" rel="stylesheet" type="text/css" />');  
           // mywindow.document.write('<link href="../assets/css/style.css" rel="stylesheet" type="text/css" />');  
            //mywindow.document.write(' <style> .noPrint{ display: none; !important;} </style> ');
            mywindow.document.write('</head><body>');
            mywindow.document.write('<h1>' + document.title  + '</h1>');
            mywindow.document.write(data);
            mywindow.document.write('</body></html>');

            mywindow.focus(); // necessary for IE >= 10*/
            mywindow.print();
            mywindow.close();
        } 


  function printPage1() {
      //get all the tab item
     <%-- var tabItems = document.querySelectorAll(".e-tab .e-content-item");
      // set 100% for tab control heigh
    // $("#<%=Tab_SCR.ClientID%>").height("100%");

      $.each(tabItems, function (index, value) {
          // set 100% height for each tab
          //$(value).height("100%")

          if (value.style.display == "none" || value.style.display == "") {
              value.style.display = "block";
          }
      });--%>
      // get the target html
      var elem = document.getElementById('printableArea').innerHTML;
      var newWin = window.open('', 'PRINT', 'height=600,width=800');  
      newWin.document.write('<html><body>' + elem + '</body></html>');
      newWin.document.write('<style type="text/css" media="print">@@media print {#TabItem_Bad {overflow: visible !important;}}</style>');
      newWin.print();
      //printPopup(elem);
      // printPopup($('<div/>').append($(elem).clone()).html());
        }

        <%--function printPage() {
 
             $("#<%=txt_FilingDate.ClientID%>").ejDatePicker("model.height", "25");
            $("#<%=txt_FilingDate.ClientID%>").attr("value", $("#<%=txt_FilingDate.ClientID%>").val());

            // j error
           $("#<%=txt_ClientName.ClientID%>").ejAutocomplete("model.height", "25");
            $("#<%=txt_ClientName.ClientID%>").attr("value", $("#<%=txt_ClientName.ClientID%>").val());

            var elem = document.getElementById('printableArea').innerHTML;

            printPopup($('<div/>').append($(elem).clone()).html());
           // redirect();
        }--%>

        function printPage() {
            // expand the first item
            $("#<%= Ard_Audit.ClientID %>").ejAccordion({ selectedItemIndex: 0 });

            // expand the all item
            var accObj = $("#<%= Ard_Audit.ClientID %>").ejAccordion("instance");
            accObj.expandAll();

            if ($("#<%= Grid.ClientID %>").ejGrid("getRows").length > 0) {
                var gridObj = $("#<%= Grid.ClientID %>").ejGrid('instance');
                var height = gridObj.getRowHeight() * gridObj.getRows().length;
                gridObj.option({ "scrollSettings": { "height": height } });
            }

           // var elem1 = document.getElementById('div_header').innerHTML;
            //var elem2 = document.getElementById('TabItem_Tran').innerHTML;
            //var elem3 = document.getElementById('TabItem_Approval').innerHTML;

           // printPopup($('<div/>').append($(elem1)).append($('<br /><br />')).append($(elem2)).append($('<br /><br />')).append($(elem3)).html());
        }

    </script>
    <style>

        @media only print {
            #TabItem_Bad, #TabItem_Sdn {
                overflow: visible !important;
            }
        }
</style>
</asp:Content>
