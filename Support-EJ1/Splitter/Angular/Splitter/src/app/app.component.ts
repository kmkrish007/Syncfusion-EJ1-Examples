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
  service: string;
  constructor() {
    this.proper = [{ paneSize: '50%' }, {}];
    this.data = ['25', '50', '75' ];
    this.value = '50';
    this.service = 'http://js.syncfusion.com/demos/ejservices/api/PdfViewer';
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
    this.splitterObj.model.properties[0].paneSize = args.value + "%";
    this.splitterObj.widget.refresh();
  }
}
