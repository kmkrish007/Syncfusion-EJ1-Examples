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
var core_1 = require("@angular/core");
var template_1 = require("./../template");
var TreeGridHeaderTemplateDirective = (function (_super) {
    __extends(TreeGridHeaderTemplateDirective, _super);
    function TreeGridHeaderTemplateDirective(el, viewContainerRef, templateRef, injector) {
        var _this = _super.call(this, el, viewContainerRef, templateRef) || this;
        _this.el = el;
        _this.viewContainerRef = viewContainerRef;
        _this.templateRef = templateRef;
        _this.injector = injector;
        _this.referenceObj = {};
        return _this;
    }
    TreeGridHeaderTemplateDirective.prototype.ngOnInit = function () {
        var template = this.viewContainerRef.createEmbeddedView(this.templateRef, { '$implicit': [] });
        var templID = ej.getGuid('angulartmplstr');
        var tempEle = ej.buildTag('div#' + templID);
        $(tempEle).append(template.rootNodes);
        ej.createObject('headerTemplateID', $($(tempEle).append(template.rootNodes)).html(), this.element);
        this.element.headerTemplateID = $($(tempEle).append(template.rootNodes)).html();
        Object.defineProperty(this.element, '_treegridtemplateRef', {
            enumerable: false,
            writable: true,
            value: this.templateRef
        });
        Object.defineProperty(this.element, '_treegridviewRef', {
            enumerable: false,
            writable: true,
            value: this.viewContainerRef
        });
        this.element['_key'] = $(tempEle).attr("id");
        $(tempEle).remove();
    };
    TreeGridHeaderTemplateDirective.prototype.ngAfterViewInit = function () {
        var _this = this;
        this.element.parent.model["ngTemplateId"] = template_1.ngTemplateid;
        window.setTimeout(function () {
            _this.compileCurrentTemplate(_this.element);
            var parentWidget = _this.element.parent.widget || _this.element.widget;
            parentWidget.element.off(parentWidget.pluginName + 'headerRefresh');
            parentWidget.element.on(parentWidget.pluginName + 'headerRefresh', function () {
                if (parentWidget.headerAngularTemplate) {
                    _this.compileTemplate();
                }
            });
        });
    };
    TreeGridHeaderTemplateDirective.prototype.compileTemplate = function () {
        var widget = this.element.parent.widget || this.element.widget;
        var element = widget.element;
        var childView;
        var templates = $(element).find('.ej-angular-treegrid-header-template');
        var templateObject = widget.headerAngularTemplate;
        for (var template in templateObject) {
            var tmplElement = templates.filter('.' + template);
            if (tmplElement.length) {
                for (var i = 0; i < tmplElement.length; i++) {
                    if (jQuery(tmplElement[i]).hasClass("embeddedview")) {
                        jQuery(tmplElement[i]).removeClass("embeddedview");
                        var index = parseInt($(tmplElement[i]).attr('ej-prop'));
                        childView = templateObject[template].viewRef[index].createEmbeddedView(templateObject[template].templateRef[index], { '$implicit': templateObject[template].itemData[index] });
                        $(tmplElement[i]).empty().append(childView.rootNodes);
                    }
                }
            }
            else {
                delete templateObject[template];
            }
        }
    };
    TreeGridHeaderTemplateDirective.prototype.compileCurrentTemplate = function (tempElement) {
        var widget = this.element.parent.widget || this.element.widget;
        var element = widget.element;
        var childView;
        var templates = $(element).find('.ej-angular-treegrid-header-template');
        var templateObject = widget.headerAngularTemplate[tempElement._key];
        var tmplElement = templates.filter('.' + tempElement._key);
        if (templateObject && tmplElement.length) {
            for (var i = 0; i < tmplElement.length; i++) {
                if (jQuery(tmplElement[i]).hasClass("embeddedview")) {
                    jQuery(tmplElement[i]).removeClass("embeddedview");
                    var index = parseInt($(tmplElement[i]).attr('ej-prop'));
                    childView = templateObject.viewRef[index].createEmbeddedView(templateObject.templateRef[index], { '$implicit': templateObject.itemData[index] });
                    $(tmplElement[i]).empty().append(childView.rootNodes);
                }
            }
        }
        else {
            delete widget.headerAngularTemplate[tempElement._key];
        }
    };
    TreeGridHeaderTemplateDirective.prototype.clearTempalte = function () {
        var templateObject = this.element.parent.widget.headerAngularTemplate;
        if (templateObject && Object.keys(templateObject).length) {
            for (var tmpl in templateObject) {
                delete templateObject[tmpl];
            }
        }
        this.viewContainerRef.remove();
    };
    TreeGridHeaderTemplateDirective.prototype.ngOnDestroy = function () {
        this.clearTempalte();
    };
    return TreeGridHeaderTemplateDirective;
}(template_1.EJTemplateDirective));
TreeGridHeaderTemplateDirective.decorators = [
    { type: core_1.Directive, args: [{
                selector: "[e-treegridheader-template]"
            },] },
];
/** @nocollapse */
TreeGridHeaderTemplateDirective.ctorParameters = function () { return [
    { type: core_1.ElementRef, },
    { type: core_1.ViewContainerRef, },
    { type: core_1.TemplateRef, },
    { type: core_1.Injector, },
]; };
exports.TreeGridHeaderTemplateDirective = TreeGridHeaderTemplateDirective;
ej.template['text/x-treegridheadertemplate'] = function (self, selector, data, index, prop) {
    var templateObject = self.headerAngularTemplate;
    if (!templateObject || !templateObject[data._key]) {
        templateObject = templateObject || {};
        templateObject[data._key] = { key: ej.getGuid('angulartmpl'), itemData: [], viewRef: [], templateRef: [] };
        self.headerAngularTemplate = templateObject;
    }
    var scope = templateObject[data._key];
    if (!ej.isNullOrUndefined(index)) {
        if (!scope.itemData) {
            scope.itemData = [];
        }
        scope.itemData[index] = data;
        scope.viewRef[index] = prop._treegridviewRef;
        scope.templateRef[index] = prop._treegridtemplateRef;
    }
    else {
        if (data.length > 1) {
            for (var i = 0; i < data.length; i++) {
                scope.itemData[i] = data[i];
                scope.viewRef[i] = prop._treegridviewRef;
                scope.templateRef[i] = prop._treegridtemplateRef;
            }
        }
        else {
            scope.itemData = [data];
            scope.viewRef = [prop._treegridviewRef];
            scope.templateRef = [prop._treegridtemplateRef];
        }
    }
    var actElement = '';
    if (selector.startsWith('#'))
        actElement = $(selector).html() || '';
    else
        actElement = selector;
    var tempElement = '';
    tempElement = tempElement + '<div ej-prop=\'' + index + '\' class=\'' + " embeddedview " + data._key + ' ej-angular-treegrid-header-template\'>' + actElement + ' </div>';
    return tempElement;
};
//# sourceMappingURL=treegrid.header.template.js.map