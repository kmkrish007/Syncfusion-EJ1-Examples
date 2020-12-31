import 'syncfusion-javascript/Scripts/ej/datavisualization/ej.diagram.min';
import { EJComponents } from './core';
import { IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class OverviewComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    sourceID_input: any;
    height_input: any;
    width_input: any;
    options: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_OVERVIEW_COMPONENTS: Type<any>[];
