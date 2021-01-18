// regenerator-runtime is to support async/await syntax in ESNext.
// If you target latest browsers (have native support), or don't use async/await, you can remove regenerator-runtime.
import 'regenerator-runtime/runtime';
import * as environment from '../config/environment.json';
import {PLATFORM} from 'aurelia-pal';
import 'syncfusion-javascript/Scripts/ej/web/ej.web.all.min';
import '@syncfusion/ej2/dist/ej2.min.js';


Promise.config({
  warnings: {
    wForgottenReturn: false
  }
});

export function configure(aurelia) {
  aurelia.use
    .standardConfiguration()
    .feature(PLATFORM.moduleName('resources/index'))
    //register aurelia-syncfusion-bridge plugin here
    .plugin(PLATFORM.moduleName('aurelia-syncfusion-bridge'), (syncfusion) => syncfusion.useAll());
    //.plugin('aurelia-syncfusion-bridge', (syncfusion) => syncfusion.useAll());

  aurelia.use.developmentLogging(environment.debug ? 'debug' : 'warn');

  if (environment.testing) {
    aurelia.use.plugin(PLATFORM.moduleName('aurelia-testing'));
  }



  aurelia.start().then(() => aurelia.setRoot(PLATFORM.moduleName('app')));
}
document.addEventListener('aurelia-composed', () => {
  // document.write('<script src="http://cdn.syncfusion.com/ej2/dist/ej2.min.js"><\/script>');
  // finished loading?
  // Extend ej namespace with Syncfusion
   $.extend(ej, Syncfusion);
  var calendar = new ej.calendars.Calendar();
  calendar.appendTo('#element');
});
