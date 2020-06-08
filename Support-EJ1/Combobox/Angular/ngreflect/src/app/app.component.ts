import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent {
 data: Array<Object> = [];
 fieldsvalues: Object;
 states: Array<any>;
 fields: Object;
 constructor() {
   // data source
  this.states = [
    { index: '1', countryName: 'Alabama' }, { index: '2', countryName: 'Alaska' },
    { index: '3', countryName: 'Arizona' }, { index: '4', countryName: 'Arkansas' },
    { index: '5', countryName: 'California' }, { index: '6', countryName: 'Colorado' },
    { index: '7', countryName: 'Connecticut' },
    { index: '8', countryName: 'Delaware' },
    { index: '9', countryName: 'Florida' },
    { index: '10', countryName: 'Georgia' }
];
    // autocomplete fields
    this.fields = { key: 'index', text: 'countryName' };
    // combobox fields
    this.fieldsvalues = { text: 'countryName', value: 'index' };

 }
onChange(args)
{
	console.log(args);
}
onBlur(args)
{
	console.log(args);
}
onClick(e)
{
	var obj = $("#comboDefault").data("ejComboBox");
	obj.setModel({value: "7"})
	
}
}
