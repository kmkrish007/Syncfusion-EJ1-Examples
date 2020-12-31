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
require("syncfusion-javascript/Scripts/ej/web/ej.combobox.min");
var core_1 = require("./core");
var core_2 = require("@angular/core");
var forms_1 = require("@angular/forms");
var noop = function () {
};
exports.ComboBoxValueAccessor = {
    provide: forms_1.NG_VALUE_ACCESSOR,
    useExisting: core_2.forwardRef(function () { return ComboBoxComponent; }),
    multi: true
};
var ComboBoxComponent = (function (_super) {
    __extends(ComboBoxComponent, _super);
    function ComboBoxComponent(el, cdRef, _ejIterableDiffers, _ejkeyvaluediffers) {
        var _this = _super.call(this, 'ComboBox', el, cdRef, [], _ejIterableDiffers, _ejkeyvaluediffers) || this;
        _this.el = el;
        _this.cdRef = cdRef;
        _this._ejIterableDiffers = _ejIterableDiffers;
        _this._ejkeyvaluediffers = _ejkeyvaluediffers;
        _this.value_twoChange = new core_2.EventEmitter();
        _this.actionBegin_output = new core_2.EventEmitter();
        _this.actionComplete_output = new core_2.EventEmitter();
        _this.actionFailure_output = new core_2.EventEmitter();
        _this.change_output = new core_2.EventEmitter();
        _this.ejchange_output = new core_2.EventEmitter();
        _this.close_output = new core_2.EventEmitter();
        _this.create_output = new core_2.EventEmitter();
        _this.customValueSpecifier_output = new core_2.EventEmitter();
        _this.filtering_output = new core_2.EventEmitter();
        _this.focus_output = new core_2.EventEmitter();
        _this.open_output = new core_2.EventEmitter();
        _this.select_output = new core_2.EventEmitter();
        _this.onChange = noop;
        _this.onTouched = noop;
        return _this;
    }
    ComboBoxComponent.prototype.writeValue = function (value) {
        if (this.widget) {
            this.widget.option('model.value', value);
        }
        else {
            this.model.value = value;
        }
    };
    ComboBoxComponent.prototype.registerOnChange = function (fn) {
        this.onChange = fn;
    };
    ComboBoxComponent.prototype.registerOnTouched = function (fn) {
        this.onTouched = fn;
    };
    return ComboBoxComponent;
}(core_1.EJComponents));
ComboBoxComponent.decorators = [
    { type: core_2.Component, args: [{
                selector: '[ej-combobox]',
                template: '',
                host: { '(ejchange)': 'onChange($event.value)', '(change)': 'onChange($event.value)', '(focusOut)': 'onTouched()' },
                providers: [exports.ComboBoxValueAccessor]
            },] },
];
/** @nocollapse */
ComboBoxComponent.ctorParameters = function () { return [
    { type: core_2.ElementRef, },
    { type: core_2.ChangeDetectorRef, },
    { type: core_2.IterableDiffers, },
    { type: core_2.KeyValueDiffers, },
]; };
ComboBoxComponent.propDecorators = {
    'actionFailureTemplate_input': [{ type: core_2.Input, args: ['actionFailureTemplate',] },],
    'allowCustom_input': [{ type: core_2.Input, args: ['allowCustom',] },],
    'allowFiltering_input': [{ type: core_2.Input, args: ['allowFiltering',] },],
    'autofill_input': [{ type: core_2.Input, args: ['autofill',] },],
    'cssClass_input': [{ type: core_2.Input, args: ['cssClass',] },],
    'dataSource_input': [{ type: core_2.Input, args: ['dataSource',] },],
    'enableRtl_input': [{ type: core_2.Input, args: ['enableRtl',] },],
    'enabled_input': [{ type: core_2.Input, args: ['enabled',] },],
    'fields_input': [{ type: core_2.Input, args: ['fields',] },],
    'footerTemplate_input': [{ type: core_2.Input, args: ['footerTemplate',] },],
    'groupTemplate_input': [{ type: core_2.Input, args: ['groupTemplate',] },],
    'headerTemplate_input': [{ type: core_2.Input, args: ['headerTemplate',] },],
    'htmlAttributes_input': [{ type: core_2.Input, args: ['htmlAttributes',] },],
    'index_input': [{ type: core_2.Input, args: ['index',] },],
    'itemTemplate_input': [{ type: core_2.Input, args: ['itemTemplate',] },],
    'locale_input': [{ type: core_2.Input, args: ['locale',] },],
    'noRecordsTemplate_input': [{ type: core_2.Input, args: ['noRecordsTemplate',] },],
    'placeholder_input': [{ type: core_2.Input, args: ['placeholder',] },],
    'popupHeight_input': [{ type: core_2.Input, args: ['popupHeight',] },],
    'popupWidth_input': [{ type: core_2.Input, args: ['popupWidth',] },],
    'query_input': [{ type: core_2.Input, args: ['query',] },],
    'readonly_input': [{ type: core_2.Input, args: ['readonly',] },],
    'showClearButton_input': [{ type: core_2.Input, args: ['showClearButton',] },],
    'sortOrder_input': [{ type: core_2.Input, args: ['sortOrder',] },],
    'text_input': [{ type: core_2.Input, args: ['text',] },],
    'width_input': [{ type: core_2.Input, args: ['width',] },],
    'fields_groupBy_input': [{ type: core_2.Input, args: ['fields.groupBy',] },],
    'fields_iconCss_input': [{ type: core_2.Input, args: ['fields.iconCss',] },],
    'fields_value_input': [{ type: core_2.Input, args: ['fields.value',] },],
    'fields_text_input': [{ type: core_2.Input, args: ['fields.text',] },],
    'options': [{ type: core_2.Input, args: ['options',] },],
    'value_two': [{ type: core_2.Input, args: ['value',] },],
    'value_twoChange': [{ type: core_2.Output, args: ['valueChange',] },],
    'actionBegin_output': [{ type: core_2.Output, args: ['actionBegin',] },],
    'actionComplete_output': [{ type: core_2.Output, args: ['actionComplete',] },],
    'actionFailure_output': [{ type: core_2.Output, args: ['actionFailure',] },],
    'change_output': [{ type: core_2.Output, args: ['change',] },],
    'ejchange_output': [{ type: core_2.Output, args: ['ejchange',] },],
    'close_output': [{ type: core_2.Output, args: ['close',] },],
    'create_output': [{ type: core_2.Output, args: ['create',] },],
    'customValueSpecifier_output': [{ type: core_2.Output, args: ['customValueSpecifier',] },],
    'filtering_output': [{ type: core_2.Output, args: ['filtering',] },],
    'focus_output': [{ type: core_2.Output, args: ['focus',] },],
    'open_output': [{ type: core_2.Output, args: ['open',] },],
    'select_output': [{ type: core_2.Output, args: ['select',] },],
};
exports.ComboBoxComponent = ComboBoxComponent;
exports.EJ_COMBOBOX_COMPONENTS = [ComboBoxComponent
];
//# sourceMappingURL=combobox.component.js.map