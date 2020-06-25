<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div id="container" class="fileupload">
         <input type="file" id="fileupload" name="UploadFiles">
   </div>

    <script type="text/javascript">
        var uploadObject = new ej.inputs.Uploader({
        maxFileSize: 3221225472,
        asyncSettings: {
            saveUrl: 'https://ej2.syncfusion.com/services/api/uploadbox/Save',
            removeUrl: 'https://ej2.syncfusion.com/services/api/uploadbox/Remove',
            // split the files into chunks of the size 102400 bytes
            chunkSize: 500000
        }
    });
    // render initialized Uploader
    uploadObject.appendTo('#fileupload');
    </script>

</asp:Content>
