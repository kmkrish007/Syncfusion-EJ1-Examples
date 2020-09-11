<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="UploadBox_VB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <ej:UploadBox ID="UploadACESFile" runat="server"  MultipleFilesSelection="true" Locale="en-US" AllowDragAndDrop="true" SaveUrl="/SaveFile.ashx" ClientSideOnError="uploaderror" 
                 ClientSideOnSuccess="uploadsuccess" ClientSideOnBeforeSend="uploadbefore" FileSize="100000000" DropAreaText="Drop zip files to upload or click" >
                        <DialogAction CloseOnComplete="true" />
                    </ej:UploadBox>

    <script type="text/javascript">

        ej.Uploadbox.prototype._onDropHandler = function (e) {
            if (ej.browserInfo().name === "msie" && ej.browserInfo().version === "8.0" || ej.browserInfo().version === "9.0") return false;
            if (this._currentElement.hasClass("e-disable")) return false;
            e.stopPropagation();
            e.preventDefault();
            this._files = this._getAllFileInfo(e.originalEvent.dataTransfer.files);
			this._selectedfiles = this._selectedfiles.concat(this._files);
            if (!this.model.asyncUpload)
            {
                this._isDropped = true;
                $("input[type='file']").prop("files", e.originalEvent.dataTransfer.files);
               
            }
             
            this._fileSelect(e);
        }
        $('.e-drag-container').on({
            'dragenter': function (e) {            
                debugger;
            e.originalEvent.dataTransfer.dropEffect = "copy";

            e.stopPropagation();

            e.preventDefault();

            $(this).addClass('draginprogress');

            $(this).find('.DragText').css({ 'z-index': '1000' }).show()

            },

            'dragover': function (e) {
                debugger;
            e.originalEvent.dataTransfer.dropEffect = "copy";

            e.preventDefault();

            e.stopPropagation();

            },

            'dragleave': function (e) {
                debugger;
            e.stopPropagation();

            e.preventDefault();            

            $(this).removeClass('draginprogress');

            $(this).find('.DragText').hide();

            },

            'drop': function (e) {
                debugger;
            var dataTransfer = e.originalEvent.dataTransfer;

            $(this).removeClass('draginprogress');

            $(this).find('.DragText').hide()

            if (dataTransfer && dataTransfer.files.length) {

            e.originalEvent.dataTransfer.dropEffect = "copy";

            e.preventDefault();

            e.stopPropagation();

            //My drop action code 

            }

            }

            });


        function uploadsuccess() {
            alert("file uploaded");
        }
        ej.Uploadbox.Locale["en-CA"] = {
            buttonText: {
                upload: "Upload",
                browse: "Browse",
                cancel: "Cancel",
                close: "Close"
            },
            dialogText: {
                title: "Upload Box",
                name: "Name",
                size: "Size",
                status: "Status"
            },
            dropAreaText: "Drop files or click to upload",
            filedetail: "The selected file size is too large. Please select a file within the valid size.",
            denyError: "Files with #Extension extensions are not allowed.",
            allowError: "Only files with #Extension extensions are allowed.",
            cancelToolTip: "Cancel",
            removeToolTip: "Remove",
            retryToolTip: "Retry",
            completedToolTip: "Completed",
            failedToolTip: "Failed",
            closeToolTip: "Close"
        };
    </script>

</asp:Content>
