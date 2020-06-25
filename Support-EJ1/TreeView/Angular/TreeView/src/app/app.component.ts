import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  public localData : any = [

    { id: 1, name: "Local Disk(C:)", hasChild: true, expanded: true, htmlAttr: {class: "blue-text"} },
    { id: 2, name: "Local Disk(D:)", hasChild: true },
    { id: 4, parentId: 1, name: "Folder 1", htmlAttr: {class: "green-text"} },
    { id: 5, parentId: 1, name: "Folder 2", htmlAttr: {class: "red-text"} },
    { id: 6, parentId: 1, name: "Folder 3", htmlAttr: {class: "blue-text"} },
    { id: 7, parentId: 2, name: "Folder 4", htmlAttr: {class: "blue-text"} },
    { id: 8, parentId: 2, name: "Folder 5", htmlAttr: {class: "green-text"} },
    { id: 9, parentId: 2, name: "Folder 6", htmlAttr: {class: "red-text"} }
];

public fields:any = { dataSource: this.localData, id: "id", parentId: "parentId", text: "name", hasChild: "hasChild", expanded: "expanded", htmlAttribute: "htmlAttr" }
  constructor() {
  }

}
