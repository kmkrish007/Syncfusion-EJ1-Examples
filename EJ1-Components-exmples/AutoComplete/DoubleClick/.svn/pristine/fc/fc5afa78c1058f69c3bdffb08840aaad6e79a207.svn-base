"use strict";
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var isIELowerVersion = (ej.browserInfo().name == "msie" && parseInt(ej.browserInfo().version) < 9);
var DocumentEditor = (function (_super) {
    __extends(DocumentEditor, _super);
    function DocumentEditor() {
        _super.apply(this, arguments);
        this.rootCSS = "e-documenteditor";
        this.PluginName = "ejDocumentEditor";
        this._id = "null";
        this.defaults = {
            importExportSettings: {
                importUrl: "",
            },
            documentChange: null,
            zoomFactorChange: null,
            requestNavigate: null,
            selectionChange: null
        };
        this._documentEditorHelper = null;
        this.model = this.defaults;
    }
    DocumentEditor.prototype._init = function () {
        if (isIELowerVersion)
            return;
        if (!ej.isNullOrUndefined(this.element)) {
            this._documentEditorHelper = new DocumentEditorFeatures.DocumentEditorHelper(this, ej);
            this._documentEditorHelper.Document = this.createEmptyDocument();
        }
    };
    DocumentEditor.prototype._destroy = function () {
        if (isIELowerVersion)
            return;
        window.removeEventListener('resize', this._documentEditorHelper.viewer.windowResizeHandler);
        window.removeEventListener('mousedown', this._documentEditorHelper.viewer.windowMouseDownHandler);
        window.removeEventListener('keyup', this._documentEditorHelper.viewer.windowKeyUpHandler);
    };
    DocumentEditor.prototype.createEmptyDocument = function () {
        var documentAdv = new DocumentEditorFeatures.DocumentAdv(null);
        var sectionAdv = new DocumentEditorFeatures.SectionAdv(null);
        var paragraphAdv = new DocumentEditorFeatures.ParagraphAdv(null);
        sectionAdv.Blocks.push(paragraphAdv);
        documentAdv.Sections.push(sectionAdv);
        return documentAdv;
    };
    DocumentEditor.prototype.loadDocument = function (data) {
        this._documentEditorHelper.ParseDocument(data);
    };
    DocumentEditor.prototype.raiseClientEvent = function (eventName, argument) {
        var val = null;
        if (argument === null) {
        }
        else {
            val = argument;
        }
        var args;
        if (eventName == "documentChange")
            args = "";
        else if (eventName == "selectionChange")
            args = "";
        else if (eventName == "zoomFactorChange")
            args = "";
        else if (eventName == "requestNavigate") {
            var linkType = "";
            switch (val.Hyperlink.LinkType) {
                case DocumentEditorFeatures.HyperlinkType.Bookmark:
                    linkType = "bookmark";
                    break;
                case DocumentEditorFeatures.HyperlinkType.Email:
                    linkType = "email";
                    break;
                case DocumentEditorFeatures.HyperlinkType.File:
                    linkType = "file";
                    break;
                default:
                    linkType = "webpage";
                    break;
            }
            var HyperLink = { "navigationLink": val.Hyperlink.navigationLink, "linkType": linkType };
            args = { "hyperlink": HyperLink };
        }
        this._trigger(eventName, args);
    };
    DocumentEditor.prototype.load = function (path) {
        if (isIELowerVersion)
            return;
        var _ejDocumentEditor = this;
        this._documentEditorHelper.InitDocumentLoad();
        var formData = null;
        if (ej.browserInfo().name == "msie" && parseInt(ej.browserInfo().version) == 9) {
            formData = "";
        }
        else {
            formData = new FormData();
            formData.append("files", path);
        }
        $.ajax({
            type: "POST",
            async: true,
            processData: false,
            contentType: false,
            crossDomain: true,
            data: formData,
            url: this.model.importExportSettings.importUrl,
            dataType: "JSON",
            success: function (data) {
                _ejDocumentEditor.loadDocument(data);
            },
        });
    };
    DocumentEditor.prototype.getCurrentPageNumber = function () {
        if (isIELowerVersion)
            return;
        return this._documentEditorHelper.CurrentPageNumber;
    };
    DocumentEditor.prototype.getPageCount = function () {
        if (isIELowerVersion)
            return;
        return this._documentEditorHelper.PageCount;
    };
    DocumentEditor.prototype.getZoomFactor = function () {
        if (isIELowerVersion)
            return;
        return this._documentEditorHelper.ZoomFactor;
    };
    DocumentEditor.prototype.setZoomFactor = function (value) {
        if (isIELowerVersion)
            return;
        this._documentEditorHelper.ZoomFactor = value;
    };
    DocumentEditor.prototype.print = function () {
        if (isIELowerVersion)
            return;
        this._documentEditorHelper.Print();
    };
    DocumentEditor.prototype.find = function (text) {
        if (isIELowerVersion)
            return;
        if (text != undefined && text != null && text != "")
            this._documentEditorHelper.Find(text.toString(), 0);
    };
    DocumentEditor.prototype.getSelectedText = function () {
        if (isIELowerVersion)
            return;
        return this._documentEditorHelper.Selection.Text;
    };
    return DocumentEditor;
}(ej.WidgetBase));
ej.widget("ejDocumentEditor", "ej.DocumentEditor", new DocumentEditor());
