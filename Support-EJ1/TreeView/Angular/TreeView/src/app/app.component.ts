import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})

export class AppComponent {
  @ViewChild('tree') treeObj: EJComponents<any, any>;
  public localData : any = [
    { id: 1, name: "Local Disk(C:)", hasChild: true, expanded: true },
    { id: 2, name: "Local Disk(D:)", hasChild: true },
    { id: 4, parentId: 1, name: "Folder 1" },
    { id: 5, parentId: 1, name: "Folder 2" },
    { id: 6, parentId: 1, name: "Folder 3" },
    { id: 7, parentId: 2, name: "Folder 4" },
    { id: 8, parentId: 2, name: "Folder 5" },
    { id: 9, parentId: 2, name: "Folder 6" }
];

public fields:any = { dataSource: this.localData, id: "id", parentId: "parentId", text: "name", hasChild: "hasChild", expanded: "expanded" }
  constructor() {
  }

  add() {
    this.treeObj.widget.addNode("NodeNew", "1");
  }

}
