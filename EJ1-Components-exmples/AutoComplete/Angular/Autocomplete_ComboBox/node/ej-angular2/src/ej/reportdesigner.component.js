"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
require("syncfusion-javascript/Scripts/ej/web/ej.reportdesigner.min");
var core_1 = require("./core");
var core_2 = require("@angular/core");
var ReportDesignerComponent = (function (_super) {
    __extends(ReportDesignerComponent, _super);
    function ReportDesignerComponent(el, cdRef, _ejIterableDiffers, _ejkeyvaluediffers) {
        var _this = _super.call(this, 'ReportDesigner', el, cdRef, [], _ejIterableDiffers, _ejkeyvaluediffers) || this;
        _this.el = el;
        _this.cdRef = cdRef;
        _this._ejIterableDiffers = _ejIterableDiffers;
        _this._ejkeyvaluediffers = _ejkeyvaluediffers;
        _this.ajaxBeforeLoad_output = new core_2.EventEmitter();
        _this.ajaxError_output = new core_2.EventEmitter();
        _this.ajaxSuccess_output = new core_2.EventEmitter();
        _this.create_output = new core_2.EventEmitter();
        _this.destroy_output = new core_2.EventEmitter();
        _this.openReportClick_output = new core_2.EventEmitter();
        _this.reportModified_output = new core_2.EventEmitter();
        _this.reportOpened_output = new core_2.EventEmitter();
        _this.reportSaved_output = new core_2.EventEmitter();
        _this.saveReportClick_output = new core_2.EventEmitter();
        _this.toolbarClick_output = new core_2.EventEmitter();
        _this.toolbarRendering_output = new core_2.EventEmitter();
        return _this;
    }
    return ReportDesignerComponent;
}(core_1.EJComponents));
ReportDesignerComponent.decorators = [
    { type: core_2.Component, args: [{
                selector: 'ej-reportdesigner',
                template: ''
            },] },
];
/** @nocollapse */
ReportDesignerComponent.ctorParameters = function () { return [
    { type: core_2.ElementRef, },
    { type: core_2.ChangeDetectorRef, },
    { type: core_2.IterableDiffers, },
    { type: core_2.KeyValueDiffers, },
]; };
ReportDesignerComponent.propDecorators = {
    'locale_input': [{ type: core_2.Input, args: ['locale',] },],
    'reportPath_input': [{ type: core_2.Input, args: ['reportPath',] },],
    'reportServerUrl_input': [{ type: core_2.Input, args: ['reportServerUrl',] },],
    'serviceAuthorizationToken_input': [{ type: core_2.Input, args: ['serviceAuthorizationToken',] },],
    'serviceUrl_input': [{ type: core_2.Input, args: ['serviceUrl',] },],
    'toolbarSettings_input': [{ type: core_2.Input, args: ['toolbarSettings',] },],
    'toolbarSettings_items_input': [{ type: core_2.Input, args: ['toolbarSettings.items',] },],
    'toolbarSettings_showToolbar_input': [{ type: core_2.Input, args: ['toolbarSettings.showToolbar',] },],
    'toolbarSettings_templateId_input': [{ type: core_2.Input, args: ['toolbarSettings.templateId',] },],
    'options': [{ type: core_2.Input, args: ['options',] },],
    'ajaxBeforeLoad_output': [{ type: core_2.Output, args: ['ajaxBeforeLoad',] },],
    'ajaxError_output': [{ type: core_2.Output, args: ['ajaxError',] },],
    'ajaxSuccess_output': [{ type: core_2.Output, args: ['ajaxSuccess',] },],
    'create_output': [{ type: core_2.Output, args: ['create',] },],
    'destroy_output': [{ type: core_2.Output, args: ['destroy',] },],
    'openReportClick_output': [{ type: core_2.Output, args: ['openReportClick',] },],
    'reportModified_output': [{ type: core_2.Output, args: ['reportModified',] },],
    'reportOpened_output': [{ type: core_2.Output, args: ['reportOpened',] },],
    'reportSaved_output': [{ type: core_2.Output, args: ['reportSaved',] },],
    'saveReportClick_output': [{ type: core_2.Output, args: ['saveReportClick',] },],
    'toolbarClick_output': [{ type: core_2.Output, args: ['toolbarClick',] },],
    'toolbarRendering_output': [{ type: core_2.Output, args: ['toolbarRendering',] },],
};
exports.ReportDesignerComponent = ReportDesignerComponent;
exports.EJ_REPORTDESIGNER_COMPONENTS = [ReportDesignerComponent
];
//# sourceMappingURL=reportdesigner.component.js.map