import { ElementRef, ViewContainerRef, TemplateRef, Injector } from '@angular/core';
import { EJTemplateDirective } from './../template';
export declare class GridSummaryTemplateDirective extends EJTemplateDirective {
    protected el: ElementRef;
    protected viewContainerRef: ViewContainerRef;
    protected templateRef: TemplateRef<any>;
    protected injector: Injector;
    referenceObj: any;
    constructor(el: ElementRef, viewContainerRef: ViewContainerRef, templateRef: TemplateRef<any>, injector: Injector);
    ngOnInit(): void;
    ngAfterViewChecked(): void;
}
