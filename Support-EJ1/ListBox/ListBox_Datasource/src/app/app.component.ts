import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent {
 @ViewChild('treeObj') treeObj: EJComponents<any, any>;
 data: Array<any>;
 newdata: Array<any>;
    fieldList: object;
    value: string;
    constructor() {
    this.data = [
        { employeeId: "cr1", text: "Dodge Avenger", value: "Dodge Avenger" },
        { employeeId: "cr2", text: "Chrysler 200", value: "Chrysler 200" },
        { employeeId: "cr3", text: "Ford Focus", value: "Ford Focus" },
        { employeeId: "cr4", text: "Ford Taurus", value: "Ford Taurus" },
        { employeeId: "cr5", text: "Dazzler", value: "Dazzler" },
        { employeeId: "cr6", text: "Chevy Spark", value: "Chevy Spark" },
        { employeeId: "cr7", text: "Chevy Volt", value: "Chevy Volt" },
        { employeeId: "cr8", text: "Honda Fit", value: "Honda Fit" },
        { employeeId: "cr9", text: "Honda Cross tour", value: "Honda Cross tour" },
        { employeeId: "cr10", text: "Hyundai Elantra", value: "Hyundai Elantra" },
        { employeeId: "cr11", text: "Mazda3", value: "Mazda3" }
    ];
    this.newdata = [
      { empid: "bk1", text: "Aache RTR" },
      { empid: "bk2", text: "CBR 150-R" },
      { empid: "bk3", text: "CBZ Xtreme" },
      { empid: "bk4", text: "Discover" },
      { empid: "bk5", text: "Dazzler" },
      { empid: "bk6", text: "Flame" },
      { empid: "bk7", text: "Fazzer" },
      { empid: "bk8", text: "FZ-S" },
      { empid: "bk9", text: "Pulsar" },
      { empid: "bk10", text: "Shine" },
      { empid: "bk11", text: "R15" },
      { empid: "bk12", text: "Unicorn" }
    ];
    this.fieldList = {dataSource: this.data, text: "text", value: "value"};
    }

  change() {
    let listbox = $("#listbox").data('ejListBox');
    // set empty data for listbox
   listbox.setModel({dataSource: null});
    // set new data for listbox
    //listbox.setModel({dataSource: this.newdata});
  }

  create(args){
    debugger;
    $('#listbox').keypress(function(event){
      debugger
    });
  }
}
