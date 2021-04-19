"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var data_1 = require("./data");
var ej2_ng_grids_1 = require("@syncfusion/ej2-ng-grids");
var FirstComponent = (function () {
    function FirstComponent() {
    }
    FirstComponent.prototype.ngOnInit = function () {
        this.data = data_1.data;
    };
    return FirstComponent;
}());
__decorate([
    core_1.ViewChild('grid'),
    __metadata("design:type", ej2_ng_grids_1.GridComponent)
], FirstComponent.prototype, "grid", void 0);
FirstComponent = __decorate([
    core_1.Component({
        selector: 'app-container',
        template: "<ej-ribbon id=\"Default\" width=\"100%\" applicationTab.type=\"menu\" \n    applicationTab.menuItemID=\"menu\" applicationTab.menuSettings.openOnClick=\"false\">\n        <e-tabs>\n            <e-tab id=\"home\" text=\"\" [groups]=\"groups1\">\n            </e-tab>\n        </e-tabs>\n    </ej-ribbon>\n    <ul id=\"menu\">\n        <li>\n            <a>FILE</a>\n            <ul>\n                <li><a>New</a></li>\n                <li><a>Open</a></li>\n                <li><a>Save</a></li>\n                <li><a>Save As</a></li>\n            </ul>\n        </li>\n        <li>\n            <a>Insert</a>\n            <ul>\n                <li><a>Image</a></li>\n            </ul>\n        </li>\n        <li>\n            <a>Design</a>\n            <ul>\n                <li><a>shape</a></li>\n                <li><a>theme</a></li>\n                <li><a>color</a></li>\n            </ul>\n        </li>\n    </ul>\n    <ejs-grid #grid [dataSource]='data' height='200px' [enablePersistence]='true' [allowReordering]='true' [allowResizing]='true' [allowSorting]='true' [allowFiltering]='true'>\n        <e-columns>\n            <e-column field='OrderID' headerText='Order ID' textAlign='Right' width=120></e-column>\n            <e-column field='CustomerID' headerText='Customer ID' width=150></e-column>\n            <e-column field='OrderDate' headerText='OrderDate' editType='datepickeredit' width='170'></e-column>\n            <e-column field='ShipName' headerText='Ship Name' width=150></e-column>\n        </e-columns>\n    </ejs-grid>"
    })
], FirstComponent);
exports.FirstComponent = FirstComponent;
