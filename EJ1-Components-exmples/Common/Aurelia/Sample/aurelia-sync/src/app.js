export class App {
  constructor() {
    document.addEventListener('aurelia-composed', () => {
      // finished loading?
      // Extend ej namespace with Syncfusion
       $.extend(ej, Syncfusion);
      var calendar = new ej.calendars.Calendar();
      calendar.appendTo('#element');
  });
  }
}