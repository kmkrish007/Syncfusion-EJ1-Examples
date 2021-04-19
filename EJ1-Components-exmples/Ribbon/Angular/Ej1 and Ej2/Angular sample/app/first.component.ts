import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { data } from './data';
import { ClickEventArgs } from '@syncfusion/ej2-navigations';
import { GridComponent } from '@syncfusion/ej2-ng-grids';

@Component({
    selector: 'app-container',
    template: `<ej-ribbon id="Default" width="100%" applicationTab.type="menu" 
    applicationTab.menuItemID="menu" applicationTab.menuSettings.openOnClick="false">
        <e-tabs>
            <e-tab id="home" text="" [groups]="groups1">
            </e-tab>
        </e-tabs>
    </ej-ribbon>
    <ul id="menu">
        <li>
            <a>FILE</a>
            <ul>
                <li><a>New</a></li>
                <li><a>Open</a></li>
                <li><a>Save</a></li>
                <li><a>Save As</a></li>
            </ul>
        </li>
        <li>
            <a>Insert</a>
            <ul>
                <li><a>Image</a></li>
            </ul>
        </li>
        <li>
            <a>Design</a>
            <ul>
                <li><a>shape</a></li>
                <li><a>theme</a></li>
                <li><a>color</a></li>
            </ul>
        </li>
    </ul>
    <ejs-grid #grid [dataSource]='data' height='200px' [enablePersistence]='true' [allowReordering]='true' [allowResizing]='true' [allowSorting]='true' [allowFiltering]='true'>
        <e-columns>
            <e-column field='OrderID' headerText='Order ID' textAlign='Right' width=120></e-column>
            <e-column field='CustomerID' headerText='Customer ID' width=150></e-column>
            <e-column field='OrderDate' headerText='OrderDate' editType='datepickeredit' width='170'></e-column>
            <e-column field='ShipName' headerText='Ship Name' width=150></e-column>
        </e-columns>
    </ejs-grid>`
})
export class FirstComponent implements OnInit {

    public data: Object[];
    public groupOptions: Object[];

    @ViewChild('grid')
    public grid: GridComponent;
    
    ngOnInit(): void {
        this.data = data;
    }
}