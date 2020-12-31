import 'syncfusion-javascript/Scripts/ej/web/ej.pivotpager.min';
import { EJComponents } from './core';
import { IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class PivotPagerComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    categoricalCurrentPage_input: any;
    categoricalPageCount_input: any;
    locale_input: any;
    mode_input: any;
    seriesCurrentPage_input: any;
    seriesPageCount_input: any;
    targetControlID_input: any;
    options: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_PIVOTPAGER_COMPONENTS: Type<any>[];
