import 'syncfusion-javascript/Scripts/ej/web/ej.tile.min';
import { EJComponents } from './core';
import { EventEmitter, IterableDiffers, KeyValueDiffers, Type, ElementRef, ChangeDetectorRef } from '@angular/core';
export declare class TileComponent extends EJComponents<any, any> {
    el: ElementRef;
    cdRef: ChangeDetectorRef;
    private _ejIterableDiffers;
    private _ejkeyvaluediffers;
    badge_input: any;
    caption_input: any;
    cssClass_input: any;
    enablePersistence_input: any;
    height_input: any;
    imageClass_input: any;
    imagePosition_input: any;
    imageTemplateId_input: any;
    imageUrl_input: any;
    locale_input: any;
    liveTile_input: any;
    tileSize_input: any;
    width_input: any;
    showRoundedCorner_input: any;
    allowSelection_input: any;
    backgroundColor_input: any;
    badge_maxValue_input: any;
    badge_minValue_input: any;
    caption_enabled_input: any;
    caption_alignment_input: any;
    caption_position_input: any;
    caption_icon_input: any;
    liveTile_enabled_input: any;
    liveTile_imageClass_input: any;
    liveTile_imageTemplateId_input: any;
    liveTile_imageUrl_input: any;
    liveTile_type_input: any;
    liveTile_updateInterval_input: any;
    liveTile_text_input: any;
    options: any;
    badge_value_two: any;
    badge_value_twoChange: EventEmitter<any>;
    badge_enabled_two: any;
    badge_enabled_twoChange: EventEmitter<any>;
    badge_text_two: any;
    badge_text_twoChange: EventEmitter<any>;
    badge_position_two: any;
    badge_position_twoChange: EventEmitter<any>;
    caption_text_two: any;
    caption_text_twoChange: EventEmitter<any>;
    mouseDown_output: EventEmitter<{}>;
    mouseUp_output: EventEmitter<{}>;
    constructor(el: ElementRef, cdRef: ChangeDetectorRef, _ejIterableDiffers: IterableDiffers, _ejkeyvaluediffers: KeyValueDiffers);
}
export declare var EJ_TILE_COMPONENTS: Type<any>[];