import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  @ViewChild('list') listObj: EJComponents<any, any>;
 skillSet: Array<any>;
    fields: object;
  constructor() {
    this.fields = { text: 'skill' };
        this.skillSet = [
            { skill: 'ASP.NET' }, { skill: 'ActionScript' }, { skill: 'Basic' },
            { skill: 'C++' }, { skill: 'C#' }, { skill: 'dBase' }, { skill: 'Delphi' },
            { skill: 'ESPOL' }, { skill: 'F#' }, { skill: 'FoxPro' }, { skill: 'Java' },
            { skill: 'J#' }, { skill: 'Lisp' }, { skill: 'Logo' }, { skill: 'PHP' }
        ];
  }

  add() {
    this.listObj.widget.removeAll();
    this.listObj.widget.addItem("Audi R8", 1);
  }
}
