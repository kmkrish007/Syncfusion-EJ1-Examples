export class App {
  message = 'Hello World!';
  constructor(){

    var cssFile = document.createElement("link");
    cssFile.href = "http://cdn.syncfusion.com/ej2/material.css";
    cssFile.rel = "stylesheet";
    cssFile.type = "text/css";
    document.querySelector('head').appendChild(cssFile);

    var scriptElement = document.createElement("script");
    scriptElement.src = "http://cdn.syncfusion.com/ej2/dist/ej2.min.js";
    document.querySelector('head').appendChild(scriptElement);

    document.addEventListener('aurelia-composed', () => {
      // finished loading?
      var button = new ej.buttons.Button();

      // Render initialized button.
      button.appendTo('#element');

      var hostUrl = 'https://ej2-aspcore-service.azurewebsites.net/';
              // initialize File Manager component
              var filemanagerInstance = new ej.filemanager.FileManager({
                  ajaxSettings: {
                      url: hostUrl + 'api/FileManager/FileOperations'
                  }
              });
              // append with filemanager id
              //filemanagerInstance.appendTo('#filemanager');
              // append with filemanager element
              // filemanagerInstance.appendTo(document.getElementById("filemanager"));
              filemanagerInstance.appendTo(document.getElementsByClassName("file")[0]);

    });
  }
}
