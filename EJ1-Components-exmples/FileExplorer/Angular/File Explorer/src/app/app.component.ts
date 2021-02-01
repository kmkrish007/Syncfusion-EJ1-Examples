import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  @ViewChild('file') fileObj: EJComponents<any, any>;
  ngAfterViewInit(){
    // for gridview
    if(this.fileObj.widget._gridObj){
      this.fileObj.widget._gridObj._scrollObject.setModel({ scrollerSize: 16 });
    }
    // for tile view
    if(this.fileObj.widget._tileScroll) {
      this.fileObj.widget._tileScroll.setModel({ scrollerSize: 16 });
    }
  }
  constructor() {
  };
}
