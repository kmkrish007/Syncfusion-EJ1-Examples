<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button runat="server" Type="Button" ClientSideOnClick="printPage" Text="Print"></ej:Button>

    <div class="col-md-12 " id="printableArea">
    <ej:Tab ID="Tab_SCR" runat="server" Width="100%" EnableTabScroll="true" Height="470px" HeightAdjustMode="None">
                                    <Items>
                                        <ej:TabItem ID="TabItem_Bad" Text="Bad Press" runat="server">
                                            <ContentSection>
                                                <div id="nav-bad">
                                                    <ej:Accordion ID="Acd_Bad" runat="server" Collapsible="true">
                                                        <Items>
                                                            <ej:AccordionItem Text="" AjaxUrl="EmpRecord.html">
                                                            </ej:AccordionItem>
                                                        </Items>
                                                    </ej:Accordion>
                                                </div>
                                            </ContentSection>
                                        </ej:TabItem>


                                        <ej:TabItem ID="TabItem_Sdn" Text="OFAC SDN" runat="server">
                                            <ContentSection>
                                                <div class="col-md-10">
                                                    
                                                    <div id="div_sdn_lst" runat="server">
                                                        <table width="800" cellpadding="5" class="lvHeader">
                                                            <tr>
                                                                <td height="40">Search Result</td>
                                                            </tr>
                                                        </table>
                            
                                                                <table border="1" cellpadding="5" cellspacing="0" width="800">
                                                                    <td>
                                                                        <table width="100%">
                                                                            <tr>
                                                                                <td width="25%" height="25px">
                                                                                    <span style="font-weight: bold">Type :</span> <%# Eval("Type")%> 
                                                                                </td>
                                                                                <td width="75%">
                                                                                    <span style="font-weight: bold">Name : </span><%# Eval("DisplayName")%>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td colspan="2">
                                                                                    <span style="font-weight: bold">Remarks : </span><%# Eval("Remark")%>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </table>
                      
                                                    </div>
                                                </div>
                                            </ContentSection>
                                        </ej:TabItem>

                                   </Items>
                                </ej:Tab>
        </div>

    <script>
         function printPopup(data) {  
            var mywindow = window.open('', 'PRINT', 'height=600,width=800');  
            
            mywindow.document.write('<html><head><title>' + document.title + '</title>');
            mywindow.document.write('<link href="../assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />');
            mywindow.document.write('<link href="../Assets/Script/jquery-ui.css" rel="stylesheet" type="text/css" />');
            mywindow.document.write('<link href="../Content/ejthemes/ej.widgets.core.css" rel="stylesheet" type="text/css" />');  
            mywindow.document.write('<link href="../Content/ejthemes/bootstrap-theme/ej.theme.css" rel="stylesheet" type="text/css" />');  
            mywindow.document.write('<link href="../assets/css/style.css" rel="stylesheet" type="text/css" />');  
            mywindow.document.write(' <style> .noPrint{ display: none; !important;} </style> ');
            mywindow.document.write('</head><body>');
            mywindow.document.write('<h1>' + document.title  + '</h1>');
            mywindow.document.write(data);
            mywindow.document.write('</body></html>');

            mywindow.focus(); // necessary for IE >= 10*/
            mywindow.print();
            mywindow.close();
        } 


  function printPage() {
      //get all the tab item
      var tabItems = document.querySelectorAll(".e-tab .e-content-item");
      // set 100% for tab control heigh
      $("#<%=Tab_SCR.ClientID%>").height("100%");
      $.each(tabItems, function (index, value) {
          // set 100% height for each tab
          $(value).height("100%")
          if (value.style.display == "none" && value.style.display == "") {
              value.style.display = "block";
          }
      });
      // get the target html
      var elem = document.getElementById('printableArea').innerHTML;
       printPopup($('<div/>').append($(elem).clone()).html());
  }

              // assign the previous state of display
      //$.each(tabItems, function (index, value) {
      //    value.style.display = arr[index];
      //});

    </script>
</asp:Content>
