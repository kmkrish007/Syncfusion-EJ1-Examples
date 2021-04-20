import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {EJ_LISTBOX_COMPONENTS} from 'ej-angular2/src/ej/listbox.component';
import {EJ_TREEVIEW_COMPONENTS} from 'ej-angular2/src/ej/treeview.component';
import {EJ_SPLITTER_COMPONENTS} from 'ej-angular2/src/ej/splitter.component';
import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent, EJ_LISTBOX_COMPONENTS,EJ_TREEVIEW_COMPONENTS, EJ_SPLITTER_COMPONENTS
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
