import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  contextMenuSettings: Object;
  @ViewChild('file') fileObj: EJComponents<any, any>;
  constructor() {
    this.contextMenuSettings = {
      // define the ContextMenu items
      items: {
          // removed the 'NewFolder' item from NavigationPane ContextMenu
          navbar: ['Custom', 'Upload', '|', 'Delete', 'Rename', '|', 'Cut', 'Copy', 'Paste', '|', 'Getinfo'],
          // added the custom ContextMenu item (View) to Current working directory ContextMenu
          cwd: ['Refresh', 'Paste', '|', 'SortBy', '|', 'NewFolder', 'Upload', '|', 'Getinfo'],
          // removed 'Upload' item from Selected files/ folder's ContextMenu
          files: ['Custom','Open', 'Download', '|', 'Delete', 'Rename', '|', 'Cut', 'Copy', 'Paste', '|','OpenFolderLocation', 'Getinfo']
      },
      // added the custom ContextMenu item's (View) functionality
      customMenuFields: [
      {
          id: 'Custom',
          text: 'Get Path',
          spriteCssClass: 'custom-grid'
      }, ]
  };

  }
  onMenuClick(args) {
    if(args.text == "Get Path")
      console.log("Path :" + this.fileObj.widget._originalPath + this.fileObj.widget._selectedItems[0]);
    }
}
