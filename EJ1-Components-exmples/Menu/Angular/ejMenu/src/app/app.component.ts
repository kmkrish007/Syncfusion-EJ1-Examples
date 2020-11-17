import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  type: any;
  data: any;
  target: any;
  constructor() {
      this.type = ej.MenuType.ContextMenu;
      this.data = [
          { id: 1, text: "Cut" },
          { id: 2, text: "Copy" },
          { id: 3, text: "Paste" },
          { id: 4, text: "Comments" },
          { id: 5, text: "Links" },
          { id: 6, text: "Clear Formatting" }
      ];
      this.target = "#target";
  }
}
