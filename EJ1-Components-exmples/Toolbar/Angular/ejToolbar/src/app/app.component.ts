import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})

export class AppComponent {
  fieldsvalues: Object;
    data: Array<Object>;
    constructor() {
        this.data = [
          { id: "1", text: "movetofolder" },
          { id: "2", text: "categorize" },
          { id: "3", text: "flag"    },
          { id: "4", text: "forward" },
          { id: "5", text: "newmail" }
        ];
        this.fieldsvalues = { id: "id", text: "text" };
    }

}
