import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  @ViewChild('splitter') splitterObj: EJComponents<any, any>;
  proper: any;
  status: boolean;
  data: any;
  value: string;
  constructor() {
    // use panesize value in pecentage
    this.proper = [{ paneSize: '60%' }, { paneSize: '40%' }];
    this.data = ['250', '500', '750', '1000' ];
    this.value = '1000';
  }

  resize() {
    if (!this.status) {
      this.splitterObj.widget.collapse(0);
      this.status = true;
    } else {
      this.splitterObj.widget.expand(0);
      this.status = false;
    }
  }

  Select(args) {
    let spiltObj = $("#splitter").data("ejSplitter");
    spiltObj.setModel({width: args.value});
  }

  beforExpandCollapse(args){
    debugger;
  }

  Resize(args){
    debugger;
  }
}
