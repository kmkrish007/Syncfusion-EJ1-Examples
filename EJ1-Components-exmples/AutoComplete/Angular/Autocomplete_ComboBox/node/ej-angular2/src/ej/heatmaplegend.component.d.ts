import 'syncfusion-javascript/Scripts/ej/datavisualization/ej.heatmap.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class HeatMapLegendLegendcolorMappingDirective extends ComplexTagElement {
    color: any;
    value: any;
    label: any;
    label_bold: any;
    label_italic: any;
    label_text: any;
    label_textDecoration: any;
    label_fontSize: any;
    label_fontFamily: any;
    label_fontColor: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class HeatMapLegendLegendcolorMappingsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class HeatMapLegendComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    width_input: any;
    height_input: any;
    isResponsive_input: any;
    showLabel_input: any;
    orientation_input: any;
    legendMode_input: any;
    colorMappingCollection_input: any;
    options: any;
    tag_colorMappingCollection: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_HEATMAPLEGEND_COMPONENTS: Type<any>[];
