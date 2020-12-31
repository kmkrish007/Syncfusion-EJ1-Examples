import 'syncfusion-javascript/Scripts/ej/datavisualization/ej.diagram.min';
import { EJComponents } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class SymbolPaletteComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    allowDrag_input: any;
    cssClass_input: any;
    defaultSettings_input: any;
    diagramId_input: any;
    headerHeight_input: any;
    height_input: any;
    paletteItemHeight_input: any;
    paletteItemWidth_input: any;
    previewHeight_input: any;
    previewOffset_input: any;
    previewWidth_input: any;
    showPaletteItemText_input: any;
    width_input: any;
    defaultSettings_node_input: any;
    defaultSettings_connector_input: any;
    palettes_input: any;
    options: any;
    selectionChange_output: EventEmitter<{}>;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_SYMBOLPALETTE_COMPONENTS: Type<any>[];
