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
require("syncfusion-javascript/Scripts/ej/web/ej.pivotclient.min");
var core_1 = require("./core");
var core_2 = require("@angular/core");
var PivotClientComponent = (function (_super) {
    __extends(PivotClientComponent, _super);
    function PivotClientComponent(el, cdRef, _ejIterableDiffers, _ejkeyvaluediffers) {
        var _this = _super.call(this, 'PivotClient', el, cdRef, [], _ejIterableDiffers, _ejkeyvaluediffers) || this;
        _this.el = el;
        _this.cdRef = cdRef;
        _this._ejIterableDiffers = _ejIterableDiffers;
        _this._ejkeyvaluediffers = _ejkeyvaluediffers;
        _this.afterServiceInvoke_output = new core_2.EventEmitter();
        _this.beforeServiceInvoke_output = new core_2.EventEmitter();
        _this.saveReport_output = new core_2.EventEmitter();
        _this.loadReport_output = new core_2.EventEmitter();
        _this.fetchReport_output = new core_2.EventEmitter();
        _this.beforeExport_output = new core_2.EventEmitter();
        _this.chartLoad_output = new core_2.EventEmitter();
        _this.schemaLoad_output = new core_2.EventEmitter();
        _this.treeMapLoad_output = new core_2.EventEmitter();
        _this.valueCellHyperlinkClick_output = new core_2.EventEmitter();
        _this.cellClick_output = new core_2.EventEmitter();
        _this.pointRegionClick_output = new core_2.EventEmitter();
        _this.axesLabelRendering_output = new core_2.EventEmitter();
        _this.drillThrough_output = new core_2.EventEmitter();
        _this.load_output = new core_2.EventEmitter();
        _this.renderComplete_output = new core_2.EventEmitter();
        _this.renderFailure_output = new core_2.EventEmitter();
        _this.renderSuccess_output = new core_2.EventEmitter();
        return _this;
    }
    return PivotClientComponent;
}(core_1.EJComponents));
PivotClientComponent.decorators = [
    { type: core_2.Component, args: [{
                selector: 'ej-pivotclient',
                template: ''
            },] },
];
/** @nocollapse */
PivotClientComponent.ctorParameters = function () { return [
    { type: core_2.ElementRef, },
    { type: core_2.ChangeDetectorRef, },
    { type: core_2.IterableDiffers, },
    { type: core_2.KeyValueDiffers, },
]; };
PivotClientComponent.propDecorators = {
    'analysisMode_input': [{ type: core_2.Input, args: ['analysisMode',] },],
    'chartType_input': [{ type: core_2.Input, args: ['chartType',] },],
    'clientExportMode_input': [{ type: core_2.Input, args: ['clientExportMode',] },],
    'cssClass_input': [{ type: core_2.Input, args: ['cssClass',] },],
    'customObject_input': [{ type: core_2.Input, args: ['customObject',] },],
    'dataSource_input': [{ type: core_2.Input, args: ['dataSource',] },],
    'enableDrillThrough_input': [{ type: core_2.Input, args: ['enableDrillThrough',] },],
    'displaySettings_input': [{ type: core_2.Input, args: ['displaySettings',] },],
    'toolbarIconSettings_input': [{ type: core_2.Input, args: ['toolbarIconSettings',] },],
    'showUniqueNameOnPivotButton_input': [{ type: core_2.Input, args: ['showUniqueNameOnPivotButton',] },],
    'showReportCollection_input': [{ type: core_2.Input, args: ['showReportCollection',] },],
    'enableSplitter_input': [{ type: core_2.Input, args: ['enableSplitter',] },],
    'enableAdvancedFilter_input': [{ type: core_2.Input, args: ['enableAdvancedFilter',] },],
    'enableDeferUpdate_input': [{ type: core_2.Input, args: ['enableDeferUpdate',] },],
    'enableLocalStorage_input': [{ type: core_2.Input, args: ['enableLocalStorage',] },],
    'enablePaging_input': [{ type: core_2.Input, args: ['enablePaging',] },],
    'enablePivotTreeMap_input': [{ type: core_2.Input, args: ['enablePivotTreeMap',] },],
    'enableRTL_input': [{ type: core_2.Input, args: ['enableRTL',] },],
    'enableMeasureGroups_input': [{ type: core_2.Input, args: ['enableMeasureGroups',] },],
    'enableCellClick_input': [{ type: core_2.Input, args: ['enableCellClick',] },],
    'enableCellDoubleClick_input': [{ type: core_2.Input, args: ['enableCellDoubleClick',] },],
    'enableVirtualScrolling_input': [{ type: core_2.Input, args: ['enableVirtualScrolling',] },],
    'maxNodeLimitInMemberEditor_input': [{ type: core_2.Input, args: ['maxNodeLimitInMemberEditor',] },],
    'enableMemberEditorPaging_input': [{ type: core_2.Input, args: ['enableMemberEditorPaging',] },],
    'memberEditorPageSize_input': [{ type: core_2.Input, args: ['memberEditorPageSize',] },],
    'enableMemberEditorSorting_input': [{ type: core_2.Input, args: ['enableMemberEditorSorting',] },],
    'gridLayout_input': [{ type: core_2.Input, args: ['gridLayout',] },],
    'collapseCubeBrowserByDefault_input': [{ type: core_2.Input, args: ['collapseCubeBrowserByDefault',] },],
    'enableKPI_input': [{ type: core_2.Input, args: ['enableKPI',] },],
    'isResponsive_input': [{ type: core_2.Input, args: ['isResponsive',] },],
    'size_input': [{ type: core_2.Input, args: ['size',] },],
    'locale_input': [{ type: core_2.Input, args: ['locale',] },],
    'operationalMode_input': [{ type: core_2.Input, args: ['operationalMode',] },],
    'serviceMethodSettings_input': [{ type: core_2.Input, args: ['serviceMethodSettings',] },],
    'valueSortSettings_input': [{ type: core_2.Input, args: ['valueSortSettings',] },],
    'title_input': [{ type: core_2.Input, args: ['title',] },],
    'url_input': [{ type: core_2.Input, args: ['url',] },],
    'enableCompleteDataExport_input': [{ type: core_2.Input, args: ['enableCompleteDataExport',] },],
    'enableXHRCredentials_input': [{ type: core_2.Input, args: ['enableXHRCredentials',] },],
    'dataSource_cube_input': [{ type: core_2.Input, args: ['dataSource.cube',] },],
    'dataSource_sourceInfo_input': [{ type: core_2.Input, args: ['dataSource.sourceInfo',] },],
    'dataSource_providerName_input': [{ type: core_2.Input, args: ['dataSource.providerName',] },],
    'dataSource_data_input': [{ type: core_2.Input, args: ['dataSource.data',] },],
    'dataSource_catalog_input': [{ type: core_2.Input, args: ['dataSource.catalog',] },],
    'dataSource_enableAdvancedFilter_input': [{ type: core_2.Input, args: ['dataSource.enableAdvancedFilter',] },],
    'dataSource_reportName_input': [{ type: core_2.Input, args: ['dataSource.reportName',] },],
    'dataSource_pagerOptions_input': [{ type: core_2.Input, args: ['dataSource.pagerOptions',] },],
    'dataSource_pagerOptions_categoricalPageSize_input': [{ type: core_2.Input, args: ['dataSource.pagerOptions.categoricalPageSize',] },],
    'dataSource_pagerOptions_seriesPageSize_input': [{ type: core_2.Input, args: ['dataSource.pagerOptions.seriesPageSize',] },],
    'dataSource_pagerOptions_categoricalCurrentPage_input': [{ type: core_2.Input, args: ['dataSource.pagerOptions.categoricalCurrentPage',] },],
    'dataSource_pagerOptions_seriesCurrentPage_input': [{ type: core_2.Input, args: ['dataSource.pagerOptions.seriesCurrentPage',] },],
    'displaySettings_controlPlacement_input': [{ type: core_2.Input, args: ['displaySettings.controlPlacement',] },],
    'displaySettings_defaultView_input': [{ type: core_2.Input, args: ['displaySettings.defaultView',] },],
    'displaySettings_enableFullScreen_input': [{ type: core_2.Input, args: ['displaySettings.enableFullScreen',] },],
    'displaySettings_enableTogglePanel_input': [{ type: core_2.Input, args: ['displaySettings.enableTogglePanel',] },],
    'displaySettings_mode_input': [{ type: core_2.Input, args: ['displaySettings.mode',] },],
    'toolbarIconSettings_enableAddReport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableAddReport',] },],
    'toolbarIconSettings_enableNewReport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableNewReport',] },],
    'toolbarIconSettings_enableRenameReport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableRenameReport',] },],
    'toolbarIconSettings_enableDBManipulation_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableDBManipulation',] },],
    'toolbarIconSettings_enableWordExport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableWordExport',] },],
    'toolbarIconSettings_enableExcelExport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableExcelExport',] },],
    'toolbarIconSettings_enablePdfExport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enablePdfExport',] },],
    'toolbarIconSettings_enableMDXQuery_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableMDXQuery',] },],
    'toolbarIconSettings_enableDeferUpdate_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableDeferUpdate',] },],
    'toolbarIconSettings_enableFullScreen_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableFullScreen',] },],
    'toolbarIconSettings_enableSortOrFilterColumn_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableSortOrFilterColumn',] },],
    'toolbarIconSettings_enableSortOrFilterRow_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableSortOrFilterRow',] },],
    'toolbarIconSettings_enableToggleAxis_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableToggleAxis',] },],
    'toolbarIconSettings_enableChartTypes_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableChartTypes',] },],
    'toolbarIconSettings_enableRemoveReport_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableRemoveReport',] },],
    'toolbarIconSettings_enableCalculatedMember_input': [{ type: core_2.Input, args: ['toolbarIconSettings.enableCalculatedMember',] },],
    'serviceMethodSettings_cubeChanged_input': [{ type: core_2.Input, args: ['serviceMethodSettings.cubeChanged',] },],
    'serviceMethodSettings_exportPivotClient_input': [{ type: core_2.Input, args: ['serviceMethodSettings.exportPivotClient',] },],
    'serviceMethodSettings_fetchMemberTreeNodes_input': [{ type: core_2.Input, args: ['serviceMethodSettings.fetchMemberTreeNodes',] },],
    'serviceMethodSettings_fetchReportList_input': [{ type: core_2.Input, args: ['serviceMethodSettings.fetchReportList',] },],
    'serviceMethodSettings_filterElement_input': [{ type: core_2.Input, args: ['serviceMethodSettings.filterElement',] },],
    'serviceMethodSettings_initialize_input': [{ type: core_2.Input, args: ['serviceMethodSettings.initialize',] },],
    'serviceMethodSettings_loadReport_input': [{ type: core_2.Input, args: ['serviceMethodSettings.loadReport',] },],
    'serviceMethodSettings_removeDBReport_input': [{ type: core_2.Input, args: ['serviceMethodSettings.removeDBReport',] },],
    'serviceMethodSettings_renameDBReport_input': [{ type: core_2.Input, args: ['serviceMethodSettings.renameDBReport',] },],
    'serviceMethodSettings_mdxQuery_input': [{ type: core_2.Input, args: ['serviceMethodSettings.mdxQuery',] },],
    'serviceMethodSettings_measureGroupChanged_input': [{ type: core_2.Input, args: ['serviceMethodSettings.measureGroupChanged',] },],
    'serviceMethodSettings_memberExpand_input': [{ type: core_2.Input, args: ['serviceMethodSettings.memberExpand',] },],
    'serviceMethodSettings_nodeDropped_input': [{ type: core_2.Input, args: ['serviceMethodSettings.nodeDropped',] },],
    'serviceMethodSettings_removeSplitButton_input': [{ type: core_2.Input, args: ['serviceMethodSettings.removeSplitButton',] },],
    'serviceMethodSettings_saveReport_input': [{ type: core_2.Input, args: ['serviceMethodSettings.saveReport',] },],
    'serviceMethodSettings_toggleAxis_input': [{ type: core_2.Input, args: ['serviceMethodSettings.toggleAxis',] },],
    'serviceMethodSettings_toolbarServices_input': [{ type: core_2.Input, args: ['serviceMethodSettings.toolbarServices',] },],
    'serviceMethodSettings_updateReport_input': [{ type: core_2.Input, args: ['serviceMethodSettings.updateReport',] },],
    'serviceMethodSettings_paging_input': [{ type: core_2.Input, args: ['serviceMethodSettings.paging',] },],
    'serviceMethodSettings_calculatedMember_input': [{ type: core_2.Input, args: ['serviceMethodSettings.calculatedMember',] },],
    'serviceMethodSettings_valueSorting_input': [{ type: core_2.Input, args: ['serviceMethodSettings.valueSorting',] },],
    'serviceMethodSettings_drillThroughHierarchies_input': [{ type: core_2.Input, args: ['serviceMethodSettings.drillThroughHierarchies',] },],
    'serviceMethodSettings_drillThroughDataTable_input': [{ type: core_2.Input, args: ['serviceMethodSettings.drillThroughDataTable',] },],
    'valueSortSettings_headerText_input': [{ type: core_2.Input, args: ['valueSortSettings.headerText',] },],
    'valueSortSettings_headerDelimiters_input': [{ type: core_2.Input, args: ['valueSortSettings.headerDelimiters',] },],
    'valueSortSettings_sortOrder_input': [{ type: core_2.Input, args: ['valueSortSettings.sortOrder',] },],
    'dataSource_columns_input': [{ type: core_2.Input, args: ['dataSource.columns',] },],
    'dataSource_rows_input': [{ type: core_2.Input, args: ['dataSource.rows',] },],
    'dataSource_values_input': [{ type: core_2.Input, args: ['dataSource.values',] },],
    'dataSource_filters_input': [{ type: core_2.Input, args: ['dataSource.filters',] },],
    'options': [{ type: core_2.Input, args: ['options',] },],
    'afterServiceInvoke_output': [{ type: core_2.Output, args: ['afterServiceInvoke',] },],
    'beforeServiceInvoke_output': [{ type: core_2.Output, args: ['beforeServiceInvoke',] },],
    'saveReport_output': [{ type: core_2.Output, args: ['saveReport',] },],
    'loadReport_output': [{ type: core_2.Output, args: ['loadReport',] },],
    'fetchReport_output': [{ type: core_2.Output, args: ['fetchReport',] },],
    'beforeExport_output': [{ type: core_2.Output, args: ['beforeExport',] },],
    'chartLoad_output': [{ type: core_2.Output, args: ['chartLoad',] },],
    'schemaLoad_output': [{ type: core_2.Output, args: ['schemaLoad',] },],
    'treeMapLoad_output': [{ type: core_2.Output, args: ['treeMapLoad',] },],
    'valueCellHyperlinkClick_output': [{ type: core_2.Output, args: ['valueCellHyperlinkClick',] },],
    'cellClick_output': [{ type: core_2.Output, args: ['cellClick',] },],
    'pointRegionClick_output': [{ type: core_2.Output, args: ['pointRegionClick',] },],
    'axesLabelRendering_output': [{ type: core_2.Output, args: ['axesLabelRendering',] },],
    'drillThrough_output': [{ type: core_2.Output, args: ['drillThrough',] },],
    'load_output': [{ type: core_2.Output, args: ['load',] },],
    'renderComplete_output': [{ type: core_2.Output, args: ['renderComplete',] },],
    'renderFailure_output': [{ type: core_2.Output, args: ['renderFailure',] },],
    'renderSuccess_output': [{ type: core_2.Output, args: ['renderSuccess',] },],
};
exports.PivotClientComponent = PivotClientComponent;
exports.EJ_PIVOTCLIENT_COMPONENTS = [PivotClientComponent
];
//# sourceMappingURL=pivotclient.component.js.map