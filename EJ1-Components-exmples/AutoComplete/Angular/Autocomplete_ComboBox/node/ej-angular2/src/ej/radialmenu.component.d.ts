import 'syncfusion-javascript/Scripts/ej/web/ej.radialmenu.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class RadialMenuItemDirective extends ComplexTagElement {
    imageUrl: any;
    prependTo: any;
    text: any;
    enabled: any;
    click: any;
    badge: any;
    badge_enabled: any;
    badge_value: any;
    type: any;
    sliderSettings: any;
    sliderSettings_ticks: any;
    sliderSettings_strokeWidth: any;
    sliderSettings_labelSpace: any;
    items: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class RadialMenuItemsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class RadialMenuComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    autoOpen_input: any;
    backImageClass_input: any;
    cssClass_input: any;
    enableAnimation_input: any;
    imageClass_input: any;
    radius_input: any;
    targetElementId_input: any;
    position_input: any;
    items_input: any;
    options: any;
    click_output: EventEmitter<{}>;
    ejclick_output: EventEmitter<{}>;
    open_output: EventEmitter<{}>;
    close_output: EventEmitter<{}>;
    tag_items: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_RADIALMENU_COMPONENTS: Type<any>[];
