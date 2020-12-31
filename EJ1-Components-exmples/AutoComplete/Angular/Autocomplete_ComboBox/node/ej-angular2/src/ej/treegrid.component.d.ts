import 'syncfusion-javascript/Scripts/ej/web/ej.treegrid.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class TreeGridColumnDirective extends ComplexTagElement {
    allowCellSelection: any;
    allowEditing: any;
    allowFiltering: any;
    allowFilteringBlankContent: any;
    allowFreezing: any;
    allowSorting: any;
    angularTemplate: any;
    clipMode: any;
    commands: any;
    displayAsCheckbox: any;
    dropdownData: any;
    editParams: any;
    editTemplate: any;
    editType: any;
    field: any;
    filterEditType: any;
    filterType: any;
    format: any;
    headerTemplateID: any;
    headerText: any;
    headerTextAlign: any;
    headerTooltip: any;
    isFrozen: any;
    isTemplateColumn: any;
    priority: any;
    showCheckbox: any;
    showInColumnChooser: any;
    template: any;
    templateID: any;
    textAlign: any;
    tooltip: any;
    validationRules: any;
    visible: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class TreeGridColumnsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class TreeGridComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    allowColumnReordering_input: any;
    allowColumnResize_input: any;
    allowDragAndDrop_input: any;
    allowFiltering_input: any;
    allowKeyboardNavigation_input: any;
    allowMultiSorting_input: any;
    allowPaging_input: any;
    allowSearching_input: any;
    allowSelection_input: any;
    allowSorting_input: any;
    allowTextWrap_input: any;
    altRowTemplateID_input: any;
    cellTooltipTemplate_input: any;
    childMapping_input: any;
    collapsibleTotalSummary_input: any;
    columnDialogFields_input: any;
    columnResizeSettings_input: any;
    commonWidth_input: any;
    contextMenuSettings_input: any;
    cssClass_input: any;
    detailsTemplate_input: any;
    detailsRowHeight_input: any;
    dragTooltip_input: any;
    editSettings_input: any;
    enableAltRow_input: any;
    enableCollapseAll_input: any;
    enableLoadOnDemand_input: any;
    enableResize_input: any;
    enableVirtualization_input: any;
    expandStateMapping_input: any;
    filterSettings_input: any;
    headerTextOverflow_input: any;
    idMapping_input: any;
    isResponsive_input: any;
    locale_input: any;
    pageSettings_input: any;
    parentIdMapping_input: any;
    parseRowTemplate_input: any;
    query_input: any;
    rowHeight_input: any;
    rowTemplateID_input: any;
    searchSettings_input: any;
    selectionSettings_input: any;
    showColumnChooser_input: any;
    showColumnOptions_input: any;
    showDetailsRow_input: any;
    showDetailsRowInfoColumn_input: any;
    showGridCellTooltip_input: any;
    showGridExpandCellTooltip_input: any;
    showStackedHeader_input: any;
    showSummaryRow_input: any;
    showTotalSummary_input: any;
    sizeSettings_input: any;
    sortSettings_input: any;
    toolbarSettings_input: any;
    totalSummaryHeight_input: any;
    treeColumnIndex_input: any;
    columnResizeSettings_columnResizeMode_input: any;
    contextMenuSettings_contextMenuItems_input: any;
    contextMenuSettings_showContextMenu_input: any;
    dragTooltip_showTooltip_input: any;
    dragTooltip_tooltipItems_input: any;
    dragTooltip_tooltipTemplate_input: any;
    editSettings_allowAdding_input: any;
    editSettings_allowDeleting_input: any;
    editSettings_allowEditing_input: any;
    editSettings_batchEditSettings_input: any;
    editSettings_batchEditSettings_editMode_input: any;
    editSettings_beginEditAction_input: any;
    editSettings_dialogEditorTemplateID_input: any;
    editSettings_editMode_input: any;
    editSettings_rowPosition_input: any;
    editSettings_showDeleteConfirmDialog_input: any;
    filterSettings_enableCaseSensitivity_input: any;
    filterSettings_enableComplexBlankFilter_input: any;
    filterSettings_filterBarMode_input: any;
    filterSettings_filterHierarchyMode_input: any;
    filterSettings_filterType_input: any;
    filterSettings_maxFilterChoices_input: any;
    pageSettings_currentPage_input: any;
    pageSettings_pageCount_input: any;
    pageSettings_pageSize_input: any;
    pageSettings_pageSizeMode_input: any;
    pageSettings_printMode_input: any;
    pageSettings_template_input: any;
    pageSettings_totalRecordsCount_input: any;
    searchSettings_fields_input: any;
    searchSettings_ignoreCase_input: any;
    searchSettings_key_input: any;
    searchSettings_operator_input: any;
    searchSettings_searchHierarchyMode_input: any;
    selectionSettings_enableHierarchySelection_input: any;
    selectionSettings_enableSelectAll_input: any;
    selectionSettings_selectionMode_input: any;
    selectionSettings_selectionType_input: any;
    sizeSettings_height_input: any;
    sizeSettings_width_input: any;
    toolbarSettings_showToolbar_input: any;
    toolbarSettings_toolbarItems_input: any;
    columns_input: any;
    selectedCellIndexes_input: any;
    stackedHeaderRows_input: any;
    summaryRows_input: any;
    filterSettings_filteredColumns_input: any;
    sortSettings_sortedColumns_input: any;
    toolbarSettings_customToolbarItems_input: any;
    options: any;
    dataSource_two: any;
    dataSource_twoChange: EventEmitter<any>;
    selectedRowIndex_two: any;
    selectedRowIndex_twoChange: EventEmitter<any>;
    actionBegin_output: EventEmitter<{}>;
    actionComplete_output: EventEmitter<{}>;
    beforePrint_output: EventEmitter<{}>;
    beginEdit_output: EventEmitter<{}>;
    cellSelected_output: EventEmitter<{}>;
    cellSelecting_output: EventEmitter<{}>;
    collapsed_output: EventEmitter<{}>;
    collapsing_output: EventEmitter<{}>;
    columnDrag_output: EventEmitter<{}>;
    columnDragStart_output: EventEmitter<{}>;
    columnDrop_output: EventEmitter<{}>;
    columnResizeEnd_output: EventEmitter<{}>;
    columnResizeStart_output: EventEmitter<{}>;
    columnResized_output: EventEmitter<{}>;
    contextMenuOpen_output: EventEmitter<{}>;
    create_output: EventEmitter<{}>;
    detailsDataBound_output: EventEmitter<{}>;
    detailsHidden_output: EventEmitter<{}>;
    detailsShown_output: EventEmitter<{}>;
    endEdit_output: EventEmitter<{}>;
    expanded_output: EventEmitter<{}>;
    expanding_output: EventEmitter<{}>;
    load_output: EventEmitter<{}>;
    queryCellInfo_output: EventEmitter<{}>;
    recordClick_output: EventEmitter<{}>;
    recordDoubleClick_output: EventEmitter<{}>;
    rowDataBound_output: EventEmitter<{}>;
    rowDrag_output: EventEmitter<{}>;
    rowDragStart_output: EventEmitter<{}>;
    rowDragStop_output: EventEmitter<{}>;
    rowDropActionBegin_output: EventEmitter<{}>;
    rowSelected_output: EventEmitter<{}>;
    rowSelecting_output: EventEmitter<{}>;
    toolbarClick_output: EventEmitter<{}>;
    tag_columns: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_TREEGRID_COMPONENTS: Type<any>[];