<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%--<ej:UploadBox ID="upload" runat="server" FileSize="10737418240" SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx"></ej:UploadBox>--%>


 
    <div class="wrapper" style="height:200px;width:400px">  
        Upload picture
        <ej:UploadBox ID="UploadFile" runat="server" ExtensionsAllow=".pdf,.jpg,.jpeg,.gif,.png" ShowBrowseButton="false" FileSize="26214400"
        SaveUrl="SaveFile.ashx" RemoveUrl="removeFile.ashx" AutoUpload="true" ClientSideOnComplete="FileUploadComplete" ShowFileDetails="true">
    </ej:UploadBox>
       <asp:Image ID="impPrev" runat="server"/>
     </div>  

    <script>
        function FileUploadComplete(args) {
            if (args.files) {  
                var ImageDir = new FileReader();  
                ImageDir.onload = function(e) {  
                    $('#MainContent_impPrev').attr('src', e.target.result);
                    $("#MainContent_UploadFile").css("display", "none");
                }
                ImageDir.readAsDataURL(args.files.rawFile);
            }  
        }

        $("#MainContent_impPrev").bind("click", function () {
            $("#MainContent_UploadFile").find(".e-uploadinput").trigger("click");
        });
    </script>

    <style>
        .wrapper {
            border: 1px solid gray;
        }
        #MainContent_impPrev{
            height: inherit;
            width: inherit;
        }
        #MainContent_UploadFile{
            display: none;
        }
    </style>

</asp:Content>
