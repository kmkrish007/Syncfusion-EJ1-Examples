import 'syncfusion-javascript/Scripts/ej/web/ej.signature.min';
import { EJComponents } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class SignatureComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    backgroundColor_input: any;
    backgroundImage_input: any;
    enabled_input: any;
    height_input: any;
    isResponsive_input: any;
    saveImageFormat_input: any;
    saveWithBackground_input: any;
    showRoundedCorner_input: any;
    strokeColor_input: any;
    strokeWidth_input: any;
    width_input: any;
    options: any;
    change_output: EventEmitter<{}>;
    ejchange_output: EventEmitter<{}>;
    mouseDown_output: EventEmitter<{}>;
    mouseMove_output: EventEmitter<{}>;
    mouseUp_output: EventEmitter<{}>;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_SIGNATURE_COMPONENTS: Type<any>[];
