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
require("syncfusion-javascript/Scripts/ej/web/ej.treegrid.min");
var core_1 = require("./core");
var core_2 = require("@angular/core");
var TreeGridColumnDirective = (function (_super) {
    __extends(TreeGridColumnDirective, _super);
    function TreeGridColumnDirective(widget) {
        var _this = _super.call(this, []) || this;
        _this.parent = widget;
        return _this;
    }
    return TreeGridColumnDirective;
}(core_1.ComplexTagElement));
TreeGridColumnDirective.decorators = [
    { type: core_2.Directive, args: [{
                selector: 'e-treegrid-columns>e-treegrid-column',
            },] },
];
/** @nocollapse */
TreeGridColumnDirective.ctorParameters = function () { return [
    { type: core_1.EJComponents, decorators: [{ type: core_2.Inject, args: [core_2.forwardRef(function () { return TreeGridComponent; }),] },] },
]; };
TreeGridColumnDirective.propDecorators = {
    'allowCellSelection': [{ type: core_2.Input, args: ['allowCellSelection',] },],
    'allowEditing': [{ type: core_2.Input, args: ['allowEditing',] },],
    'allowFiltering': [{ type: core_2.Input, args: ['allowFiltering',] },],
    'allowFilteringBlankContent': [{ type: core_2.Input, args: ['allowFilteringBlankContent',] },],
    'allowFreezing': [{ type: core_2.Input, args: ['allowFreezing',] },],
    'allowSorting': [{ type: core_2.Input, args: ['allowSorting',] },],
    'angularTemplate': [{ type: core_2.Input, args: ['angularTemplate',] },],
    'clipMode': [{ type: core_2.Input, args: ['clipMode',] },],
    'commands': [{ type: core_2.Input, args: ['commands',] },],
    'displayAsCheckbox': [{ type: core_2.Input, args: ['displayAsCheckbox',] },],
    'dropdownData': [{ type: core_2.Input, args: ['dropdownData',] },],
    'editParams': [{ type: core_2.Input, args: ['editParams',] },],
    'editTemplate': [{ type: core_2.Input, args: ['editTemplate',] },],
    'editType': [{ type: core_2.Input, args: ['editType',] },],
    'field': [{ type: core_2.Input, args: ['field',] },],
    'filterEditType': [{ type: core_2.Input, args: ['filterEditType',] },],
    'filterType': [{ type: core_2.Input, args: ['filterType',] },],
    'format': [{ type: core_2.Input, args: ['format',] },],
    'headerTemplateID': [{ type: core_2.Input, args: ['headerTemplateID',] },],
    'headerText': [{ type: core_2.Input, args: ['headerText',] },],
    'headerTextAlign': [{ type: core_2.Input, args: ['headerTextAlign',] },],
    'headerTooltip': [{ type: core_2.Input, args: ['headerTooltip',] },],
    'isFrozen': [{ type: core_2.Input, args: ['isFrozen',] },],
    'isTemplateColumn': [{ type: core_2.Input, args: ['isTemplateColumn',] },],
    'priority': [{ type: core_2.Input, args: ['priority',] },],
    'showCheckbox': [{ type: core_2.Input, args: ['showCheckbox',] },],
    'showInColumnChooser': [{ type: core_2.Input, args: ['showInColumnChooser',] },],
    'template': [{ type: core_2.Input, args: ['template',] },],
    'templateID': [{ type: core_2.Input, args: ['templateID',] },],
    'textAlign': [{ type: core_2.Input, args: ['textAlign',] },],
    'tooltip': [{ type: core_2.Input, args: ['tooltip',] },],
    'validationRules': [{ type: core_2.Input, args: ['validationRules',] },],
    'visible': [{ type: core_2.Input, args: ['visible',] },],
    'width': [{ type: core_2.Input, args: ['width',] },],
};
exports.TreeGridColumnDirective = TreeGridColumnDirective;
var TreeGridColumnsDirective = (function (_super) {
    __extends(TreeGridColumnsDirective, _super);
    function TreeGridColumnsDirective(widget) {
        return _super.call(this, 'columns') || this;
    }
    return TreeGridColumnsDirective;
}(core_1.ArrayTagElement));
TreeGridColumnsDirective.decorators = [
    { type: core_2.Directive, args: [{
                selector: 'ej-treegrid>e-treegrid-columns',
                queries: {
                    children: new core_2.ContentChildren(TreeGridColumnDirective)
                }
            },] },
];
/** @nocollapse */
TreeGridColumnsDirective.ctorParameters = function () { return [
    { type: core_1.EJComponents, decorators: [{ type: core_2.Inject, args: [core_2.forwardRef(function () { return TreeGridComponent; }),] },] },
]; };
exports.TreeGridColumnsDirective = TreeGridColumnsDirective;
var TreeGridComponent = (function (_super) {
    __extends(TreeGridComponent, _super);
    function TreeGridComponent(el, cdRef, _ejIterableDiffers, _ejkeyvaluediffers) {
        var _this = _super.call(this, 'TreeGrid', el, cdRef, ['columns'], _ejIterableDiffers, _ejkeyvaluediffers) || this;
        _this.el = el;
        _this.cdRef = cdRef;
        _this._ejIterableDiffers = _ejIterableDiffers;
        _this._ejkeyvaluediffers = _ejkeyvaluediffers;
        _this.dataSource_twoChange = new core_2.EventEmitter();
        _this.selectedRowIndex_twoChange = new core_2.EventEmitter();
        _this.actionBegin_output = new core_2.EventEmitter();
        _this.actionComplete_output = new core_2.EventEmitter();
        _this.beforePrint_output = new core_2.EventEmitter();
        _this.beginEdit_output = new core_2.EventEmitter();
        _this.cellSelected_output = new core_2.EventEmitter();
        _this.cellSelecting_output = new core_2.EventEmitter();
        _this.collapsed_output = new core_2.EventEmitter();
        _this.collapsing_output = new core_2.EventEmitter();
        _this.columnDrag_output = new core_2.EventEmitter();
        _this.columnDragStart_output = new core_2.EventEmitter();
        _this.columnDrop_output = new core_2.EventEmitter();
        _this.columnResizeEnd_output = new core_2.EventEmitter();
        _this.columnResizeStart_output = new core_2.EventEmitter();
        _this.columnResized_output = new core_2.EventEmitter();
        _this.contextMenuOpen_output = new core_2.EventEmitter();
        _this.create_output = new core_2.EventEmitter();
        _this.detailsDataBound_output = new core_2.EventEmitter();
        _this.detailsHidden_output = new core_2.EventEmitter();
        _this.detailsShown_output = new core_2.EventEmitter();
        _this.endEdit_output = new core_2.EventEmitter();
        _this.expanded_output = new core_2.EventEmitter();
        _this.expanding_output = new core_2.EventEmitter();
        _this.load_output = new core_2.EventEmitter();
        _this.queryCellInfo_output = new core_2.EventEmitter();
        _this.recordClick_output = new core_2.EventEmitter();
        _this.recordDoubleClick_output = new core_2.EventEmitter();
        _this.rowDataBound_output = new core_2.EventEmitter();
        _this.rowDrag_output = new core_2.EventEmitter();
        _this.rowDragStart_output = new core_2.EventEmitter();
        _this.rowDragStop_output = new core_2.EventEmitter();
        _this.rowDropActionBegin_output = new core_2.EventEmitter();
        _this.rowSelected_output = new core_2.EventEmitter();
        _this.rowSelecting_output = new core_2.EventEmitter();
        _this.toolbarClick_output = new core_2.EventEmitter();
        return _this;
    }
    return TreeGridComponent;
}(core_1.EJComponents));
TreeGridComponent.decorators = [
    { type: core_2.Component, args: [{
                selector: 'ej-treegrid',
                template: ''
            },] },
];
/** @nocollapse */
TreeGridComponent.ctorParameters = function () { return [
    { type: core_2.ElementRef, },
    { type: core_2.ChangeDetectorRef, },
    { type: core_2.IterableDiffers, },
    { type: core_2.KeyValueDiffers, },
]; };
TreeGridComponent.propDecorators = {
    'allowColumnReordering_input': [{ type: core_2.Input, args: ['allowColumnReordering',] },],
    'allowColumnResize_input': [{ type: core_2.Input, args: ['allowColumnResize',] },],
    'allowDragAndDrop_input': [{ type: core_2.Input, args: ['allowDragAndDrop',] },],
    'allowFiltering_input': [{ type: core_2.Input, args: ['allowFiltering',] },],
    'allowKeyboardNavigation_input': [{ type: core_2.Input, args: ['allowKeyboardNavigation',] },],
    'allowMultiSorting_input': [{ type: core_2.Input, args: ['allowMultiSorting',] },],
    'allowPaging_input': [{ type: core_2.Input, args: ['allowPaging',] },],
    'allowSearching_input': [{ type: core_2.Input, args: ['allowSearching',] },],
    'allowSelection_input': [{ type: core_2.Input, args: ['allowSelection',] },],
    'allowSorting_input': [{ type: core_2.Input, args: ['allowSorting',] },],
    'allowTextWrap_input': [{ type: core_2.Input, args: ['allowTextWrap',] },],
    'altRowTemplateID_input': [{ type: core_2.Input, args: ['altRowTemplateID',] },],
    'cellTooltipTemplate_input': [{ type: core_2.Input, args: ['cellTooltipTemplate',] },],
    'childMapping_input': [{ type: core_2.Input, args: ['childMapping',] },],
    'collapsibleTotalSummary_input': [{ type: core_2.Input, args: ['collapsibleTotalSummary',] },],
    'columnDialogFields_input': [{ type: core_2.Input, args: ['columnDialogFields',] },],
    'columnResizeSettings_input': [{ type: core_2.Input, args: ['columnResizeSettings',] },],
    'commonWidth_input': [{ type: core_2.Input, args: ['commonWidth',] },],
    'contextMenuSettings_input': [{ type: core_2.Input, args: ['contextMenuSettings',] },],
    'cssClass_input': [{ type: core_2.Input, args: ['cssClass',] },],
    'detailsTemplate_input': [{ type: core_2.Input, args: ['detailsTemplate',] },],
    'detailsRowHeight_input': [{ type: core_2.Input, args: ['detailsRowHeight',] },],
    'dragTooltip_input': [{ type: core_2.Input, args: ['dragTooltip',] },],
    'editSettings_input': [{ type: core_2.Input, args: ['editSettings',] },],
    'enableAltRow_input': [{ type: core_2.Input, args: ['enableAltRow',] },],
    'enableCollapseAll_input': [{ type: core_2.Input, args: ['enableCollapseAll',] },],
    'enableLoadOnDemand_input': [{ type: core_2.Input, args: ['enableLoadOnDemand',] },],
    'enableResize_input': [{ type: core_2.Input, args: ['enableResize',] },],
    'enableVirtualization_input': [{ type: core_2.Input, args: ['enableVirtualization',] },],
    'expandStateMapping_input': [{ type: core_2.Input, args: ['expandStateMapping',] },],
    'filterSettings_input': [{ type: core_2.Input, args: ['filterSettings',] },],
    'headerTextOverflow_input': [{ type: core_2.Input, args: ['headerTextOverflow',] },],
    'idMapping_input': [{ type: core_2.Input, args: ['idMapping',] },],
    'isResponsive_input': [{ type: core_2.Input, args: ['isResponsive',] },],
    'locale_input': [{ type: core_2.Input, args: ['locale',] },],
    'pageSettings_input': [{ type: core_2.Input, args: ['pageSettings',] },],
    'parentIdMapping_input': [{ type: core_2.Input, args: ['parentIdMapping',] },],
    'parseRowTemplate_input': [{ type: core_2.Input, args: ['parseRowTemplate',] },],
    'query_input': [{ type: core_2.Input, args: ['query',] },],
    'rowHeight_input': [{ type: core_2.Input, args: ['rowHeight',] },],
    'rowTemplateID_input': [{ type: core_2.Input, args: ['rowTemplateID',] },],
    'searchSettings_input': [{ type: core_2.Input, args: ['searchSettings',] },],
    'selectionSettings_input': [{ type: core_2.Input, args: ['selectionSettings',] },],
    'showColumnChooser_input': [{ type: core_2.Input, args: ['showColumnChooser',] },],
    'showColumnOptions_input': [{ type: core_2.Input, args: ['showColumnOptions',] },],
    'showDetailsRow_input': [{ type: core_2.Input, args: ['showDetailsRow',] },],
    'showDetailsRowInfoColumn_input': [{ type: core_2.Input, args: ['showDetailsRowInfoColumn',] },],
    'showGridCellTooltip_input': [{ type: core_2.Input, args: ['showGridCellTooltip',] },],
    'showGridExpandCellTooltip_input': [{ type: core_2.Input, args: ['showGridExpandCellTooltip',] },],
    'showStackedHeader_input': [{ type: core_2.Input, args: ['showStackedHeader',] },],
    'showSummaryRow_input': [{ type: core_2.Input, args: ['showSummaryRow',] },],
    'showTotalSummary_input': [{ type: core_2.Input, args: ['showTotalSummary',] },],
    'sizeSettings_input': [{ type: core_2.Input, args: ['sizeSettings',] },],
    'sortSettings_input': [{ type: core_2.Input, args: ['sortSettings',] },],
    'toolbarSettings_input': [{ type: core_2.Input, args: ['toolbarSettings',] },],
    'totalSummaryHeight_input': [{ type: core_2.Input, args: ['totalSummaryHeight',] },],
    'treeColumnIndex_input': [{ type: core_2.Input, args: ['treeColumnIndex',] },],
    'columnResizeSettings_columnResizeMode_input': [{ type: core_2.Input, args: ['columnResizeSettings.columnResizeMode',] },],
    'contextMenuSettings_contextMenuItems_input': [{ type: core_2.Input, args: ['contextMenuSettings.contextMenuItems',] },],
    'contextMenuSettings_showContextMenu_input': [{ type: core_2.Input, args: ['contextMenuSettings.showContextMenu',] },],
    'dragTooltip_showTooltip_input': [{ type: core_2.Input, args: ['dragTooltip.showTooltip',] },],
    'dragTooltip_tooltipItems_input': [{ type: core_2.Input, args: ['dragTooltip.tooltipItems',] },],
    'dragTooltip_tooltipTemplate_input': [{ type: core_2.Input, args: ['dragTooltip.tooltipTemplate',] },],
    'editSettings_allowAdding_input': [{ type: core_2.Input, args: ['editSettings.allowAdding',] },],
    'editSettings_allowDeleting_input': [{ type: core_2.Input, args: ['editSettings.allowDeleting',] },],
    'editSettings_allowEditing_input': [{ type: core_2.Input, args: ['editSettings.allowEditing',] },],
    'editSettings_batchEditSettings_input': [{ type: core_2.Input, args: ['editSettings.batchEditSettings',] },],
    'editSettings_batchEditSettings_editMode_input': [{ type: core_2.Input, args: ['editSettings.batchEditSettings.editMode',] },],
    'editSettings_beginEditAction_input': [{ type: core_2.Input, args: ['editSettings.beginEditAction',] },],
    'editSettings_dialogEditorTemplateID_input': [{ type: core_2.Input, args: ['editSettings.dialogEditorTemplateID',] },],
    'editSettings_editMode_input': [{ type: core_2.Input, args: ['editSettings.editMode',] },],
    'editSettings_rowPosition_input': [{ type: core_2.Input, args: ['editSettings.rowPosition',] },],
    'editSettings_showDeleteConfirmDialog_input': [{ type: core_2.Input, args: ['editSettings.showDeleteConfirmDialog',] },],
    'filterSettings_enableCaseSensitivity_input': [{ type: core_2.Input, args: ['filterSettings.enableCaseSensitivity',] },],
    'filterSettings_enableComplexBlankFilter_input': [{ type: core_2.Input, args: ['filterSettings.enableComplexBlankFilter',] },],
    'filterSettings_filterBarMode_input': [{ type: core_2.Input, args: ['filterSettings.filterBarMode',] },],
    'filterSettings_filterHierarchyMode_input': [{ type: core_2.Input, args: ['filterSettings.filterHierarchyMode',] },],
    'filterSettings_filterType_input': [{ type: core_2.Input, args: ['filterSettings.filterType',] },],
    'filterSettings_maxFilterChoices_input': [{ type: core_2.Input, args: ['filterSettings.maxFilterChoices',] },],
    'pageSettings_currentPage_input': [{ type: core_2.Input, args: ['pageSettings.currentPage',] },],
    'pageSettings_pageCount_input': [{ type: core_2.Input, args: ['pageSettings.pageCount',] },],
    'pageSettings_pageSize_input': [{ type: core_2.Input, args: ['pageSettings.pageSize',] },],
    'pageSettings_pageSizeMode_input': [{ type: core_2.Input, args: ['pageSettings.pageSizeMode',] },],
    'pageSettings_printMode_input': [{ type: core_2.Input, args: ['pageSettings.printMode',] },],
    'pageSettings_template_input': [{ type: core_2.Input, args: ['pageSettings.template',] },],
    'pageSettings_totalRecordsCount_input': [{ type: core_2.Input, args: ['pageSettings.totalRecordsCount',] },],
    'searchSettings_fields_input': [{ type: core_2.Input, args: ['searchSettings.fields',] },],
    'searchSettings_ignoreCase_input': [{ type: core_2.Input, args: ['searchSettings.ignoreCase',] },],
    'searchSettings_key_input': [{ type: core_2.Input, args: ['searchSettings.key',] },],
    'searchSettings_operator_input': [{ type: core_2.Input, args: ['searchSettings.operator',] },],
    'searchSettings_searchHierarchyMode_input': [{ type: core_2.Input, args: ['searchSettings.searchHierarchyMode',] },],
    'selectionSettings_enableHierarchySelection_input': [{ type: core_2.Input, args: ['selectionSettings.enableHierarchySelection',] },],
    'selectionSettings_enableSelectAll_input': [{ type: core_2.Input, args: ['selectionSettings.enableSelectAll',] },],
    'selectionSettings_selectionMode_input': [{ type: core_2.Input, args: ['selectionSettings.selectionMode',] },],
    'selectionSettings_selectionType_input': [{ type: core_2.Input, args: ['selectionSettings.selectionType',] },],
    'sizeSettings_height_input': [{ type: core_2.Input, args: ['sizeSettings.height',] },],
    'sizeSettings_width_input': [{ type: core_2.Input, args: ['sizeSettings.width',] },],
    'toolbarSettings_showToolbar_input': [{ type: core_2.Input, args: ['toolbarSettings.showToolbar',] },],
    'toolbarSettings_toolbarItems_input': [{ type: core_2.Input, args: ['toolbarSettings.toolbarItems',] },],
    'columns_input': [{ type: core_2.Input, args: ['columns',] },],
    'selectedCellIndexes_input': [{ type: core_2.Input, args: ['selectedCellIndexes',] },],
    'stackedHeaderRows_input': [{ type: core_2.Input, args: ['stackedHeaderRows',] },],
    'summaryRows_input': [{ type: core_2.Input, args: ['summaryRows',] },],
    'filterSettings_filteredColumns_input': [{ type: core_2.Input, args: ['filterSettings.filteredColumns',] },],
    'sortSettings_sortedColumns_input': [{ type: core_2.Input, args: ['sortSettings.sortedColumns',] },],
    'toolbarSettings_customToolbarItems_input': [{ type: core_2.Input, args: ['toolbarSettings.customToolbarItems',] },],
    'options': [{ type: core_2.Input, args: ['options',] },],
    'dataSource_two': [{ type: core_2.Input, args: ['dataSource',] },],
    'dataSource_twoChange': [{ type: core_2.Output, args: ['dataSourceChange',] },],
    'selectedRowIndex_two': [{ type: core_2.Input, args: ['selectedRowIndex',] },],
    'selectedRowIndex_twoChange': [{ type: core_2.Output, args: ['selectedRowIndexChange',] },],
    'actionBegin_output': [{ type: core_2.Output, args: ['actionBegin',] },],
    'actionComplete_output': [{ type: core_2.Output, args: ['actionComplete',] },],
    'beforePrint_output': [{ type: core_2.Output, args: ['beforePrint',] },],
    'beginEdit_output': [{ type: core_2.Output, args: ['beginEdit',] },],
    'cellSelected_output': [{ type: core_2.Output, args: ['cellSelected',] },],
    'cellSelecting_output': [{ type: core_2.Output, args: ['cellSelecting',] },],
    'collapsed_output': [{ type: core_2.Output, args: ['collapsed',] },],
    'collapsing_output': [{ type: core_2.Output, args: ['collapsing',] },],
    'columnDrag_output': [{ type: core_2.Output, args: ['columnDrag',] },],
    'columnDragStart_output': [{ type: core_2.Output, args: ['columnDragStart',] },],
    'columnDrop_output': [{ type: core_2.Output, args: ['columnDrop',] },],
    'columnResizeEnd_output': [{ type: core_2.Output, args: ['columnResizeEnd',] },],
    'columnResizeStart_output': [{ type: core_2.Output, args: ['columnResizeStart',] },],
    'columnResized_output': [{ type: core_2.Output, args: ['columnResized',] },],
    'contextMenuOpen_output': [{ type: core_2.Output, args: ['contextMenuOpen',] },],
    'create_output': [{ type: core_2.Output, args: ['create',] },],
    'detailsDataBound_output': [{ type: core_2.Output, args: ['detailsDataBound',] },],
    'detailsHidden_output': [{ type: core_2.Output, args: ['detailsHidden',] },],
    'detailsShown_output': [{ type: core_2.Output, args: ['detailsShown',] },],
    'endEdit_output': [{ type: core_2.Output, args: ['endEdit',] },],
    'expanded_output': [{ type: core_2.Output, args: ['expanded',] },],
    'expanding_output': [{ type: core_2.Output, args: ['expanding',] },],
    'load_output': [{ type: core_2.Output, args: ['load',] },],
    'queryCellInfo_output': [{ type: core_2.Output, args: ['queryCellInfo',] },],
    'recordClick_output': [{ type: core_2.Output, args: ['recordClick',] },],
    'recordDoubleClick_output': [{ type: core_2.Output, args: ['recordDoubleClick',] },],
    'rowDataBound_output': [{ type: core_2.Output, args: ['rowDataBound',] },],
    'rowDrag_output': [{ type: core_2.Output, args: ['rowDrag',] },],
    'rowDragStart_output': [{ type: core_2.Output, args: ['rowDragStart',] },],
    'rowDragStop_output': [{ type: core_2.Output, args: ['rowDragStop',] },],
    'rowDropActionBegin_output': [{ type: core_2.Output, args: ['rowDropActionBegin',] },],
    'rowSelected_output': [{ type: core_2.Output, args: ['rowSelected',] },],
    'rowSelecting_output': [{ type: core_2.Output, args: ['rowSelecting',] },],
    'toolbarClick_output': [{ type: core_2.Output, args: ['toolbarClick',] },],
    'tag_columns': [{ type: core_2.ContentChild, args: [TreeGridColumnsDirective,] },],
};
exports.TreeGridComponent = TreeGridComponent;
exports.EJ_TREEGRID_COMPONENTS = [TreeGridComponent,
    TreeGridColumnsDirective, TreeGridColumnDirective];
//# sourceMappingURL=treegrid.component.js.map