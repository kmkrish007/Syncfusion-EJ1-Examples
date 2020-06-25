import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';

class Exam {
  typeId: string;
}
class Datasources{
  examTypes: any;
}

const data = `[
  {
    "id": 0,
    "alias": "NONE",
    "shortString": "None"
  },
  {
    "id": 1,
    "alias": "CAROTID_ARTERY",
    "shortString": "Cerebrovascular Duplex Scan"
  },
  {
    "id": 2,
    "alias": "UPPER_EXTREMITY_ARTERIAL",
    "shortString": "UE Arterial Duplex Scan"
  },
  {
    "id": 3,
    "alias": "UPPER_EXTREMITY_VENOUS",
    "shortString": "UE Venous Duplex Scan"
  }
]`;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})

export class AppComponent {
  // @ViewChild("combo") ComboObj:EJComponents<ej.ComboBox, any>;
  public exam: Exam  = new Exam();
  public datasources: Datasources = new Datasources();
  fldsVal: any;
  // constructor(private patientService:PatientRecordService ) {
  constructor() {
    // combobox field
    this.fldsVal = { text: 'shortString', value: 'id' };
    this.datasources.examTypes = JSON.parse(data);
  }

  // onBlur(args) {
  // if((this.ComboObj as any).widget.inputElement.getAttribute("ng-reflect-model") == null)
  // {
  //  (this.ComboObj as any).widget.inputElement.setAttribute("ng-reflect-model",  (this.ComboObj as any).widget.value());
  // }
  //}
}
