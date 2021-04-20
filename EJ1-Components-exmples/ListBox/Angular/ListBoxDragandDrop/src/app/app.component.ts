import { Component, ViewEncapsulation, ViewChild} from '@angular/core';
import { EJComponents } from 'ej-angular2/src/ej/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})


export class AppComponent {
  //data: any;
 // fieldList:object;
 skillSet: Array<any>;
    fields: object;
  // public localData = [
  //   { id: 1, name: 'Discover Music', hasChild: true, expanded: false },
  //   { id: 2, pid: 1, name: 'Hot Singles' },
  //   { id: 3, pid: 1, name: 'Rising Artists' },
  //   { id: 4, pid: 1, name: 'Live Music' },
  //   { id: 6, pid: 1, name: 'Best of 2013 So Far' },
  //   { id: 7, name: 'Sales and Events', hasChild: true, expanded: false },
  //   { id: 8, pid: 7, name: '100 Albums - $5 Each' },
  //   { id: 9, pid: 7, name: 'Hip-Hop and R&B Sale' },
  //   { id: 10, pid: 7, name: 'CD Deals' },
  //   { id: 11, name: 'Categories', hasChild: true },
  //   { id: 12, pid: 11, name: 'Songs' },
  //   { id: 13, pid: 11, name: 'Bestselling Albums' },
  //   { id: 14, pid: 11, name: 'New Releases' },
  //   { id: 15, pid: 11, name: 'Bestselling Songs' },
  //   { id: 16, name: 'MP3 Albums', hasChild: true },
  //   { id: 17, pid: 16, name: 'Rock' },
  //   { id: 18, pid: 16, name: 'Gospel' },
  //   { id: 19, pid: 16, name: 'Latin Music' },
  //   { id: 20, pid: 16, name: 'Jazz' },
  //   { id: 21, name: 'More in Music', hasChild: true },
  //   { id: 22, pid: 21, name: 'Music Trade-In' },
  //   { id: 23, pid: 21, name: 'Redeem a Gift Card' },
  //   { id: 24, pid: 21, name: 'Band T-Shirts' },
  //   { id: 25, pid: 21, name: 'Mobile MVC' }];

  //   public fields: any = { dataSource: this.localData, id: 'id', parentId: 'pid', text: 'name' };

  //   public data: any = [
  //     { skill: 'ASP.NET' }, { skill: 'ActionScript' }, { skill: 'Basic' },
  //     { skill: 'C++' }, { skill: 'C#' }, { skill: 'dBase' }, { skill: 'Delphi' },
  //     { skill: 'ESPOL' }, { skill: 'F#' }, { skill: 'FoxPro' }, { skill: 'Java' },
  //     { skill: 'J#' }, { skill: 'Lisp' }, { skill: 'Logo' }, { skill: 'PHP' }
  //   ];

  //   public fieldList: any = {
  //     dataSource: this.data, text: 'skill'
  //   };
  constructor() {
    this.fields = { text: 'skill' };
        this.skillSet = [
            { skill: 'ASP.NET' }, { skill: 'ActionScript' }, { skill: 'Basic' },
            { skill: 'C++' }, { skill: 'C#' }, { skill: 'dBase' }, { skill: 'Delphi' },
            { skill: 'ESPOL' }, { skill: 'F#' }, { skill: 'FoxPro' }, { skill: 'Java' },
            { skill: 'J#' }, { skill: 'Lisp' }, { skill: 'Logo' }, { skill: 'PHP' }
        ];
  }

  // onlistdragged(args) {
  //   if (args.target.className.endsWith('e-node-hover')) {
  //     let treeObj = $('#treeview').data('ejTreeView');
  //     let treeid = args.target.parentElement.parentElement.id;
  //     treeObj.expandNode($('#' + treeid));
  //  }
  // }
  // onlistdropped(args) {
  //   let treeObj = $('#treeview').data('ejTreeView');
  //   let treeid = args.dropTarget[0].parentElement.parentElement.id;
  //    if (treeid) {
  //      treeObj.addNode(args.items[0].text, treeid, true);
  //      $('#list').ejListBox('removeItemByText',args.items[0].text);
  //    }
  // }
}
