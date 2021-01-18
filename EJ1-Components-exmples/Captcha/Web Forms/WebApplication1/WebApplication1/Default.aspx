<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="frame" style="width: 500px">
        <div class="control">
            <table class="tabprop">
                <tr>
                    <td>
                        <div style="width: 185px;">
                           <ej:Captcha ID="Captcha2" CustomErrorMessage="Invalid Captcha" EnableAutoValidation="true"  ShowAudioButton="true" ShowRefreshButton="true" TargetButton="btnSubmit" Mapper="GetCurrentItme"  runat="server"></ej:Captcha>
                         </div>
                    </td>
                </tr>
                <tr>
                    <td>                       
                        <ej:Button ID="Button1"   runat="server" Type="Button" Text="Submit" Size="Large" ShowRoundedCorner="true" ClientSideOnClick="onValidate"></ej:Button>
                    </td>

                   
                </tr>
            </table>
        </div>
    </div>
 
   <script type="text/javascript">
      ej.Captcha.Locale["pt-BR"] = {   
        placeHolderText: "Type the code shown",   
        customErrorMessage: "Invalid Captcha"   
    }; 
         function onValidate(e) {

             var value = $("#<%=Captcha2.ClientID%>_CaptchaMessage")[0].innerHTML;
             if (value != "Invalid Captcha") {
                 alert("Thank you for registering");
             }
         }
    </script>
        

    <style type="text/css">
        .control {
            width:155px;
            margin: 0 auto;
        }
    </style>
</asp:Content>
