import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  value: string;
  criterias: any;
  length: number = 1;
  constructor() {
    this.criterias = [ 'project' , 'cost' , 'location' , 'group' ];
    this.value = 'cost';
  }

  AddDropdown(args) {
    if(this.length < this.criterias.length){
      // create input element
      let ele = document.createElement('input');
      // adding id attribute
      ele.setAttribute("id", "Drop" + this.length);
      let cus = document.querySelector(".custom");
      // append to already created div element
      cus.appendChild(ele);
      // render input as dropdownlist
      $("#Drop" + this.length).ejDropDownList({
          dataSource: this.criterias,
      });
      this.length++;
    }
  }

}
