import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})

export class AppComponent {
  public localData: any = [
    { id: 1, name: "Local Disk(C:)", hasChild: true },
    { id: 2, name: "Local Disk(D:)", hasChild: true },
    { id: 3, name: "Local Disk(E:)", hasChild: true },
    { id: 4, parentId: 1, name: "Folder 1", hasChild: true },
    { id: 5, parentId: 1, name: "Folder 2" },
    { id: 6, parentId: 1, name: "Folder 3" },
    { id: 7, parentId: 2, name: "Folder 4" },
    { id: 8, parentId: 2, name: "Folder 5", hasChild: true },
    { id: 9, parentId: 2, name: "Folder 6" },
    { id: 10, parentId: 3, name: "Folder 7" },
    { id: 11, parentId: 3, name: "Folder 8" },
    { id: 12, parentId: 3, name: "Folder 9", hasChild: true },
    { id: 13, parentId: 4, name: "File 1" },
    { id: 14, parentId: 4, name: "File 2" },
    { id: 15, parentId: 4, name: "File 3" },
    { id: 16, parentId: 8, name: "File 4" },
    { id: 17, parentId: 8, name: "File 5" },
    { id: 18, parentId: 8, name: "File 6" },
    { id: 19, parentId: 12, name: "File 7" },
    { id: 20, parentId: 12, name: "File 8" },
    { id: 21, parentId: 12, name: "File 9" }
  ];
  public TreeField: any = { dataSource: this.localData, id: "id", parentId: "parentId", text: "name", hasChild: "hasChild" }
  constructor() {
  }
}
