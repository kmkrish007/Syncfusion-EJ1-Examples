import { Component } from '@angular/core';
declare var ej: any;
@Component({
    selector: 'ej-app',
    templateUrl: './home.component.html',
})
export class HomeComponent {
    // data: any;
    // fields: Object;
    // query: any;
    // customAdaptor : any;
    // dataManager:any;

    public data: any = [
        { skill: "ASP.NET" }, { skill: "ActionScript" }, { skill: "Basic" },
        { skill: "C++" }, { skill: "C#" }, { skill: "dBase" }, { skill: "Delphi" },
        { skill: "ESPOL" }, { skill: "F#" }, { skill: "FoxPro" }, { skill: "Java" },
        { skill: "J#" }, { skill: "Lisp" }, { skill: "Logo" }, { skill: "PHP" }
      ];
  
      public fieldList: any = { 
        dataSource:this.data, text:"skill"
      };
    constructor() {
    //  let customAdaptor = new ej.WebApiAdaptor().extend({
    //       processResponse: function (data, ds, query, xhr, request, changes) {
    //       debugger
    //       return data.Data;
    //     },
    //     });
    //     let dataManager = new ej.DataManager({
    //         url: "http://localhost:63127/api/Projects/5",
    //         crossDomain: true,
    //         adaptor: new customAdaptor() 
    //     });
    //     this.data = dataManager;
    //     this.fields = { value: "Id", text: "text" }
    
    }
}
