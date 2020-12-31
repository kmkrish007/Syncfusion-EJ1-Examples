import 'syncfusion-javascript/Scripts/ej/web/ej.waitingpopup.min';
import { EJComponents } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class WaitingPopupComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    cssClass_input: any;
    htmlAttributes_input: any;
    showImage_input: any;
    showOnInit_input: any;
    target_input: any;
    appendTo_input: any;
    template_input: any;
    text_input: any;
    options: any;
    create_output: EventEmitter<{}>;
    destroy_output: EventEmitter<{}>;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_WAITINGPOPUP_COMPONENTS: Type<any>[];
