import 'syncfusion-javascript/Scripts/ej/web/ej.ribbon.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class RibbonPageDirective extends ComplexTagElement {
    id: any;
    text: any;
    itemType: any;
    contentID: any;
    enableSeparator: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonApplicationTabBackstageSettingsPagesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonContentGroupDirective extends ComplexTagElement {
    isMobileOnly: any;
    buttonSettings: any;
    columns: any;
    contentID: any;
    cssClass: any;
    customGalleryItems: any;
    customToolTip: any;
    customToolTip_content: any;
    customToolTip_prefixIcon: any;
    customToolTip_title: any;
    dropdownSettings: any;
    enableSeparator: any;
    expandedColumns: any;
    galleryItems: any;
    id: any;
    isBig: any;
    itemHeight: any;
    itemWidth: any;
    splitButtonSettings: any;
    text: any;
    toggleButtonSettings: any;
    toolTip: any;
    quickAccessMode: any;
    type: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonContentGroupsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonContentDirective extends ComplexTagElement {
    defaults: any;
    defaults_height: any;
    defaults_width: any;
    defaults_type: any;
    defaults_isBig: any;
    groups: any;
    tag_groups: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonContentsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonGroupDirective extends ComplexTagElement {
    alignType: any;
    content: any;
    contentID: any;
    customContent: any;
    enableGroupExpander: any;
    groupExpanderSettings: any;
    groupExpanderSettings_toolTip: any;
    groupExpanderSettings_customToolTip: any;
    text: any;
    type: any;
    tag_content: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonGroupsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonTabDirective extends ComplexTagElement {
    groups: any;
    id: any;
    text: any;
    tag_groups: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonTabsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class RibbonComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    allowResizing_input: any;
    isResponsive_input: any;
    buttonDefaults_input: any;
    showQAT_input: any;
    cssClass_input: any;
    collapsePinSettings_input: any;
    enableOnDemand_input: any;
    collapsible_input: any;
    enableRTL_input: any;
    expandPinSettings_input: any;
    applicationTab_input: any;
    disabledItemIndex_input: any;
    enabledItemIndex_input: any;
    selectedItemIndex_input: any;
    locale_input: any;
    width_input: any;
    collapsePinSettings_toolTip_input: any;
    collapsePinSettings_customToolTip_input: any;
    expandPinSettings_toolTip_input: any;
    expandPinSettings_customToolTip_input: any;
    applicationTab_backstageSettings_input: any;
    applicationTab_backstageSettings_text_input: any;
    applicationTab_backstageSettings_height_input: any;
    applicationTab_backstageSettings_width_input: any;
    applicationTab_backstageSettings_headerWidth_input: any;
    applicationTab_menuItemID_input: any;
    applicationTab_menuSettings_input: any;
    applicationTab_type_input: any;
    contextualTabs_input: any;
    tabs_input: any;
    applicationTab_backstageSettings_pages_input: any;
    tabs_groups_content_input: any;
    tabs_groups_content_groups_customGalleryItems_input: any;
    tabs_groups_content_groups_galleryItems_input: any;
    options: any;
    beforeTabRemove_output: EventEmitter<{}>;
    create_output: EventEmitter<{}>;
    destroy_output: EventEmitter<{}>;
    groupClick_output: EventEmitter<{}>;
    groupExpand_output: EventEmitter<{}>;
    galleryItemClick_output: EventEmitter<{}>;
    backstageItemClick_output: EventEmitter<{}>;
    collapse_output: EventEmitter<{}>;
    expand_output: EventEmitter<{}>;
    load_output: EventEmitter<{}>;
    tabAdd_output: EventEmitter<{}>;
    tabClick_output: EventEmitter<{}>;
    tabCreate_output: EventEmitter<{}>;
    tabRemove_output: EventEmitter<{}>;
    tabSelect_output: EventEmitter<{}>;
    toggleButtonClick_output: EventEmitter<{}>;
    qatMenuItemClick_output: EventEmitter<{}>;
    tag_applicationTab_backstageSettings_pages: any;
    tag_tabs: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_RIBBON_COMPONENTS: Type<any>[];
