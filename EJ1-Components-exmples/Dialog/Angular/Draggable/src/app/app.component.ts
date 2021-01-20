import { Component } from '@angular/core';

@Component({
  selector: 'ej-app',
  templateUrl: './app.component.html',
})
export class AppComponent {
  showoninit: boolean;
  constructor() {
      this.showoninit = false;
  }
  onClick(event) {
      $("#basicDialog").ejDialog("open");
  }
  onClose(event) {
      $("#btnOpen").show();
  }
}