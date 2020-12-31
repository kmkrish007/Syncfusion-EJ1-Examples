import 'syncfusion-javascript/Scripts/ej/datavisualization/ej.circulargauge.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class CircularGaugePointerDirective extends ComplexTagElement {
    backgroundColor: any;
    backNeedleLength: any;
    border: any;
    border_color: any;
    border_width: any;
    distanceFromScale: any;
    gradients: any;
    imageUrl: any;
    length: any;
    markerType: any;
    needleType: any;
    opacity: any;
    radius: any;
    placement: any;
    pointerValueText: any;
    pointerValueText_angle: any;
    pointerValueText_autoAngle: any;
    pointerValueText_color: any;
    pointerValueText_distance: any;
    pointerValueText_font: any;
    pointerValueText_font_fontFamily: any;
    pointerValueText_font_fontStyle: any;
    pointerValueText_font_size: any;
    pointerValueText_opacity: any;
    pointerValueText_showValue: any;
    showBackNeedle: any;
    type: any;
    value: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugePointersDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeLabelDirective extends ComplexTagElement {
    angle: any;
    autoAngle: any;
    color: any;
    distanceFromScale: any;
    font: any;
    font_fontFamily: any;
    font_fontStyle: any;
    font_size: any;
    includeFirstValue: any;
    opacity: any;
    placement: any;
    type: any;
    unitText: any;
    unitTextPosition: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeLabelsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeTickDirective extends ComplexTagElement {
    angle: any;
    color: any;
    distanceFromScale: any;
    height: any;
    placement: any;
    type: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeTicksDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeRangeDirective extends ComplexTagElement {
    backgroundColor: any;
    legendText: any;
    border: any;
    border_color: any;
    border_width: any;
    distanceFromScale: any;
    endValue: any;
    endWidth: any;
    gradients: any;
    opacity: any;
    placement: any;
    size: any;
    startValue: any;
    startWidth: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeRangesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeStateRangeDirective extends ComplexTagElement {
    backgroundColor: any;
    borderColor: any;
    endValue: any;
    font: any;
    startValue: any;
    text: any;
    textColor: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeStateRangesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeIndicatorDirective extends ComplexTagElement {
    height: any;
    imageUrl: any;
    position: any;
    position_x: any;
    position_y: any;
    stateRanges: any;
    type: any;
    width: any;
    tag_stateRanges: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeIndicatorsDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeSubGaugeDirective extends ComplexTagElement {
    height: any;
    position: any;
    position_x: any;
    position_y: any;
    width: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeSubGaugesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeScaleDirective extends ComplexTagElement {
    backgroundColor: any;
    border: any;
    border_color: any;
    border_width: any;
    direction: any;
    customLabels: any;
    indicators: any;
    labels: any;
    majorIntervalValue: any;
    maximum: any;
    minimum: any;
    minorIntervalValue: any;
    opacity: any;
    pointerCap: any;
    pointerCap_backgroundColor: any;
    pointerCap_borderColor: any;
    pointerCap_borderWidth: any;
    pointerCap_interiorGradient: any;
    pointerCap_radius: any;
    pointers: any;
    radius: any;
    ranges: any;
    shadowOffset: any;
    showIndicators: any;
    showLabels: any;
    showPointers: any;
    showRanges: any;
    showScaleBar: any;
    showTicks: any;
    size: any;
    startAngle: any;
    subGauges: any;
    sweepAngle: any;
    ticks: any;
    tag_pointers: any;
    tag_labels: any;
    tag_ticks: any;
    tag_ranges: any;
    tag_indicators: any;
    tag_subGauges: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeScalesDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class CircularGaugeComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    animationSpeed_input: any;
    backgroundColor_input: any;
    distanceFromCorner_input: any;
    rangeZOrder_input: any;
    enableAnimation_input: any;
    enableGroupSeparator_input: any;
    enableResize_input: any;
    exportSettings_input: any;
    frame_input: any;
    gaugePosition_input: any;
    height_input: any;
    interiorGradient_input: any;
    isRadialGradient_input: any;
    isResponsive_input: any;
    locale_input: any;
    outerCustomLabelPosition_input: any;
    radius_input: any;
    readOnly_input: any;
    theme_input: any;
    legend_input: any;
    tooltip_input: any;
    width_input: any;
    exportSettings_filename_input: any;
    exportSettings_type_input: any;
    exportSettings_action_input: any;
    exportSettings_mode_input: any;
    frame_backgroundImageUrl_input: any;
    frame_frameType_input: any;
    frame_halfCircleFrameEndAngle_input: any;
    frame_halfCircleFrameStartAngle_input: any;
    legend_visible_input: any;
    legend_toggleVisibility_input: any;
    legend_alignment_input: any;
    legend_border_input: any;
    legend_border_color_input: any;
    legend_border_width_input: any;
    legend_fill_input: any;
    legend_itemPadding_input: any;
    legend_itemStyle_input: any;
    legend_itemStyle_border_input: any;
    legend_itemStyle_height_input: any;
    legend_itemStyle_width_input: any;
    legend_opacity_input: any;
    legend_position_input: any;
    legend_shape_input: any;
    legend_size_input: any;
    legend_size_height_input: any;
    legend_size_width_input: any;
    legend_font_input: any;
    legend_font_fontFamily_input: any;
    legend_font_fontStyle_input: any;
    legend_font_fontWeight_input: any;
    legend_font_size_input: any;
    legend_font_color_input: any;
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
    legendItemRender_output: EventEmitter<{}>;
    legendItemClick_output: EventEmitter<{}>;
    rangeMouseMove_output: EventEmitter<{}>;
    drawCustomLabel_output: EventEmitter<{}>;
    drawIndicators_output: EventEmitter<{}>;
    drawLabels_output: EventEmitter<{}>;
    drawPointerCap_output: EventEmitter<{}>;
    drawPointers_output: EventEmitter<{}>;
    drawRange_output: EventEmitter<{}>;
    drawTicks_output: EventEmitter<{}>;
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
export declare var EJ_CIRCULARGAUGE_COMPONENTS: Type<any>[];
