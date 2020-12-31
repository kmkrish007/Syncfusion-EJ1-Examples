import { ViewContainerRef, ElementRef, TemplateRef } from '@angular/core';
export { ContentChild, Type, forwardRef } from '@angular/core';
export declare let ngTemplateid: any;
export declare class EJTemplateDirective {
    protected el: ElementRef;
    protected viewContainerRef: ViewContainerRef;
    protected templateRef: TemplateRef<any>;
    element: any;
    private childViews;
    private parentContext;
    constructor(el: ElementRef, viewContainerRef: ViewContainerRef, templateRef: TemplateRef<any>);
    ngOnInit(): void;
    ngAfterViewInit(): void;
    compileTempalte(): void;
    clearTempalte(): void;
    ngOnDestroy(): void;
}
export declare let ejtemplate: any;
