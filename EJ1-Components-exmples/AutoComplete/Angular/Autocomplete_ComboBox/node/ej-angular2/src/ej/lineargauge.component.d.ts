import 'syncfusion-javascript/Scripts/ej/datavisualization/ej.lineargauge.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class LinearGaugeMarkerPointerDirective extends ComplexTagElement {
    backgroundColor: any;
    border: any;
    border_color: any;
    border_width: any;
    distanceFromScale: any;
    gradients: any;
    length: any;
    opacity: any;
    placement: any;
    type: any;
    value: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeMarkerPointersDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeBarPointerDirective extends ComplexTagElement {
    backgroundColor: any;
    border: any;
    border_color: any;
    border_width: any;
    distanceFromScale: any;
    gradients: any;
    opacity: any;
    value: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeBarPointersDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeRangeDirective extends ComplexTagElement {
    backgroundColor: any;
    border: any;
    border_color: any;
    border_width: any;
    distanceFromScale: any;
    endValue: any;
    endWidth: any;
    gradients: any;
    opacity: any;
    placement: any;
    startValue: any;
    startWidth: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeRangesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeTickDirective extends ComplexTagElement {
    angle: any;
    color: any;
    distanceFromScale: any;
    distanceFromScale_x: any;
    distanceFromScale_y: any;
    height: any;
    opacity: any;
    placement: any;
    type: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeTicksDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeStateRangeDirective extends ComplexTagElement {
    backgroundColor: any;
    borderColor: any;
    endValue: any;
    startValue: any;
    text: any;
    textColor: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeStateRangesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeIndicatorDirective extends ComplexTagElement {
    backgroundColor: any;
    border: any;
    border_color: any;
    border_width: any;
    font: any;
    font_fontFamily: any;
    font_fontStyle: any;
    font_size: any;
    height: any;
    opacity: any;
    position: any;
    position_x: any;
    position_y: any;
    stateRanges: any;
    textLocation: any;
    textLocation_x: any;
    textLocation_y: any;
    type: any;
    width: any;
    tag_stateRanges: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeIndicatorsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeLabelDirective extends ComplexTagElement {
    angle: any;
    distanceFromScale: any;
    distanceFromScale_x: any;
    distanceFromScale_y: any;
    font: any;
    font_fontFamily: any;
    font_fontStyle: any;
    font_size: any;
    includeFirstValue: any;
    opacity: any;
    placement: any;
    textColor: any;
    type: any;
    unitText: any;
    unitTextPlacement: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeLabelsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeScaleDirective extends ComplexTagElement {
    backgroundColor: any;
    barPointers: any;
    border: any;
    border_color: any;
    border_width: any;
    customLabels: any;
    direction: any;
    indicators: any;
    labels: any;
    length: any;
    majorIntervalValue: any;
    markerPointers: any;
    maximum: any;
    minimum: any;
    minorIntervalValue: any;
    opacity: any;
    position: any;
    position_x: any;
    position_y: any;
    ranges: any;
    shadowOffset: any;
    showBarPointers: any;
    showCustomLabels: any;
    showIndicators: any;
    showLabels: any;
    showMarkerPointers: any;
    showRanges: any;
    showTicks: any;
    ticks: any;
    type: any;
    width: any;
    tag_markerPointers: any;
    tag_barPointers: any;
    tag_ranges: any;
    tag_ticks: any;
    tag_indicators: any;
    tag_labels: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeScalesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class LinearGaugeComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    animationSpeed_input: any;
    backgroundColor_input: any;
    borderColor_input: any;
    enableAnimation_input: any;
    enableMarkerPointerAnimation_input: any;
    exportSettings_input: any;
    isResponsive_input: any;
    enableGroupSeparator_input: any;
    enableResize_input: any;
    frame_input: any;
    height_input: any;
    labelColor_input: any;
    locale_input: any;
    orientation_input: any;
    outerCustomLabelPosition_input: any;
    pointerGradient1_input: any;
    pointerGradient2_input: any;
    readOnly_input: any;
    theme_input: any;
    tickColor_input: any;
    tooltip_input: any;
    width_input: any;
    exportSettings_filename_input: any;
    exportSettings_type_input: any;
    exportSettings_action_input: any;
    exportSettings_mode_input: any;
    frame_backgroundImageUrl_input: any;
    frame_innerWidth_input: any;
    frame_outerWidth_input: any;
    tooltip_showCustomLabelTooltip_input: any;
    tooltip_showLabelTooltip_input: any;
    tooltip_templateID_input: any;
    scales_input: any;
    scales_indicators_stateRanges_input: any;
    options: any;
    value_two: any;
    value_twoChange: EventEmitter<any>;
    minimum_two: any;
    minimum_twoChange: EventEmitter<any>;
    maximum_two: any;
    maximum_twoChange: EventEmitter<any>;
    drawBarPointers_output: EventEmitter<{}>;
    drawCustomLabel_output: EventEmitter<{}>;
    drawIndicators_output: EventEmitter<{}>;
    drawLabels_output: EventEmitter<{}>;
    drawMarkerPointers_output: EventEmitter<{}>;
    drawRange_output: EventEmitter<{}>;
    drawTicks_output: EventEmitter<{}>;
    init_output: EventEmitter<{}>;
    load_output: EventEmitter<{}>;
    mouseClick_output: EventEmitter<{}>;
    mouseClickMove_output: EventEmitter<{}>;
    mouseClickUp_output: EventEmitter<{}>;
    renderComplete_output: EventEmitter<{}>;
    doubleClick_output: EventEmitter<{}>;
    rightClick_output: EventEmitter<{}>;
    tag_scales: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_LINEARGAUGE_COMPONENTS: Type<any>[];
