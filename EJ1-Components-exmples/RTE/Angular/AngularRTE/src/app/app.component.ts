import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})

export class AppComponent {
  target: string;
  text: string;
  constructor() {
    this.target = "#rte";
    this.text="Loading... Please wait...";
  }
  beforeActive(args) {
    let waitingPopupObj = $("#popup").data("ejWaitingPopup");
    //Show WaitingPopup
    waitingPopupObj.show();
    setTimeout(function() {
      let obj = $("#popup").data("ejWaitingPopup");
      obj.hide();
    }, 100);
  }
}
