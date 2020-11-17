import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent {
 constructor() {
   // data source
 }

 // input event
    onSearchChange(event) {
      console.log(event.target.value);
    }

    focusIn(event){
      console.log("focusedIn");
    }

    onDateChange(event){
      console.log("changed");
    }

}
