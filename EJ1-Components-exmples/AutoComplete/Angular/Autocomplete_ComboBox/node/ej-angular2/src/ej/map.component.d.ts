import 'syncfusion-javascript/Scripts/ej/datavisualization/ej.map.min';
import { EJComponents, ArrayTagElement, ComplexTagElement } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class MapLayerDirective extends ComplexTagElement {
    bingMapType: any;
    bubbleSettings: any;
    bubbleSettings_bubbleOpacity: any;
    bubbleSettings_color: any;
    bubbleSettings_colorMappings: any;
    bubbleSettings_colorMappings_rangeColorMapping: any;
    bubbleSettings_colorValuePath: any;
    bubbleSettings_maxValue: any;
    bubbleSettings_minValue: any;
    bubbleSettings_showBubble: any;
    bubbleSettings_showTooltip: any;
    bubbleSettings_tooltipTemplate: any;
    bubbleSettings_valuePath: any;
    dataSource: any;
    shapeDataPath: any;
    shapePropertyPath: any;
    enableMouseHover: any;
    enableSelection: any;
    key: any;
    labelSettings: any;
    labelSettings_enableSmartLabel: any;
    labelSettings_labelLength: any;
    labelSettings_labelPath: any;
    labelSettings_showLabels: any;
    labelSettings_smartLabelSize: any;
    labelSettings_font: any;
    labelSettings_font_fontFamily: any;
    labelSettings_font_fontStyle: any;
    labelSettings_font_fontWeight: any;
    labelSettings_font_opacity: any;
    labelSettings_font_color: any;
    labelSettings_font_size: any;
    geometryType: any;
    layerType: any;
    legendSettings: any;
    legendSettings_dockOnMap: any;
    legendSettings_dockPosition: any;
    legendSettings_height: any;
    legendSettings_icon: any;
    legendSettings_iconHeight: any;
    legendSettings_iconWidth: any;
    legendSettings_labelOrientation: any;
    legendSettings_leftLabel: any;
    legendSettings_textPath: any;
    legendSettings_mode: any;
    legendSettings_position: any;
    legendSettings_positionX: any;
    legendSettings_positionY: any;
    legendSettings_rightLabel: any;
    legendSettings_showLabels: any;
    legendSettings_showLegend: any;
    legendSettings_toggleVisibility: any;
    legendSettings_title: any;
    legendSettings_type: any;
    legendSettings_width: any;
    mapItemsTemplate: any;
    markers: any;
    markerTemplate: any;
    selectedMapShapes: any;
    selectionMode: any;
    shapeData: any;
    shapeSettings: any;
    shapeSettings_autoFill: any;
    shapeSettings_colorMappings: any;
    shapeSettings_colorMappings_rangeColorMapping: any;
    shapeSettings_colorMappings_equalColorMapping: any;
    shapeSettings_colorPalette: any;
    shapeSettings_colorValuePath: any;
    shapeSettings_colorPath: any;
    shapeSettings_enableGradient: any;
    shapeSettings_fill: any;
    shapeSettings_highlightBorderWidth: any;
    shapeSettings_highlightColor: any;
    shapeSettings_highlightStroke: any;
    shapeSettings_selectionColor: any;
    shapeSettings_selectionStroke: any;
    shapeSettings_selectionStrokeWidth: any;
    shapeSettings_stroke: any;
    shapeSettings_strokeThickness: any;
    shapeSettings_valuePath: any;
    showMapItems: any;
    showTooltip: any;
    tooltipTemplate: any;
    urlTemplate: any;
    subLayers: any;
    constructor(widget: EJComponents<any, any>);
}
export declare class MapLayersDirective extends ArrayTagElement<ComplexTagElement> {
    constructor(widget: EJComponents<any, any>);
}
export declare class MapComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    background_input: any;
    centerPosition_input: any;
    draggingOnSelection_input: any;
    enableRTL_input: any;
    enableLayerChangeAnimation_input: any;
    isResponsive_input: any;
    zoomSettings_input: any;
    navigationControl_input: any;
    locale_input: any;
    zoomSettings_animationDuration_input: any;
    zoomSettings_enableMouseWheelZoom_input: any;
    navigationControl_content_input: any;
    layers_input: any;
    layers_bubbleSettings_colorMappings_rangeColorMapping_input: any;
    layers_shapeSettings_colorMappings_rangeColorMapping_input: any;
    layers_shapeSettings_colorMappings_equalColorMapping_input: any;
    layers_subLayers_bubbleSettings_colorMappings_rangeColorMapping_input: any;
    layers_subLayers_shapeSettings_colorMappings_rangeColorMapping_input: any;
    layers_subLayers_shapeSettings_colorMappings_equalColorMapping_input: any;
    options: any;
    baseMapIndex_two: any;
    baseMapIndex_twoChange: EventEmitter<any>;
    enablePan_two: any;
    enablePan_twoChange: EventEmitter<any>;
    enableResize_two: any;
    enableResize_twoChange: EventEmitter<any>;
    enableAnimation_two: any;
    enableAnimation_twoChange: EventEmitter<any>;
    zoomSettings_level_two: any;
    zoomSettings_level_twoChange: EventEmitter<any>;
    zoomSettings_minValue_two: any;
    zoomSettings_minValue_twoChange: EventEmitter<any>;
    zoomSettings_maxValue_two: any;
    zoomSettings_maxValue_twoChange: EventEmitter<any>;
    zoomSettings_factor_two: any;
    zoomSettings_factor_twoChange: EventEmitter<any>;
    zoomSettings_enableZoom_two: any;
    zoomSettings_enableZoom_twoChange: EventEmitter<any>;
    zoomSettings_enableZoomOnSelection_two: any;
    zoomSettings_enableZoomOnSelection_twoChange: EventEmitter<any>;
    navigationControl_enableNavigation_two: any;
    navigationControl_enableNavigation_twoChange: EventEmitter<any>;
    navigationControl_orientation_two: any;
    navigationControl_orientation_twoChange: EventEmitter<any>;
    navigationControl_absolutePosition_two: any;
    navigationControl_absolutePosition_twoChange: EventEmitter<any>;
    navigationControl_dockPosition_two: any;
    navigationControl_dockPosition_twoChange: EventEmitter<any>;
    markerSelected_output: EventEmitter<{}>;
    legendItemRendering_output: EventEmitter<{}>;
    bubbleRendering_output: EventEmitter<{}>;
    shapeRendering_output: EventEmitter<{}>;
    mouseleave_output: EventEmitter<{}>;
    mouseover_output: EventEmitter<{}>;
    onRenderComplete_output: EventEmitter<{}>;
    panned_output: EventEmitter<{}>;
    shapeSelected_output: EventEmitter<{}>;
    zoomedIn_output: EventEmitter<{}>;
    zoomedOut_output: EventEmitter<{}>;
    Click_output: EventEmitter<{}>;
    legendItemClick_output: EventEmitter<{}>;
    doubleClick_output: EventEmitter<{}>;
    rightClick_output: EventEmitter<{}>;
    onLoad_output: EventEmitter<{}>;
    markerEnter_output: EventEmitter<{}>;
    markerLeave_output: EventEmitter<{}>;
    refreshed_output: EventEmitter<{}>;
    displayTextRendering_output: EventEmitter<{}>;
    tag_layers: any;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_MAP_COMPONENTS: Type<any>[];