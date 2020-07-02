import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {EJ_SPLITTER_COMPONENTS} from 'ej-angular2/src/ej/splitter.component';
import {EJ_DROPDOWNLIST_COMPONENTS} from 'ej-angular2/src/ej/dropdownlist.component';
import {EJ_TAB_COMPONENTS} from 'ej-angular2/src/ej/tab.component';
import {EJ_DIALOG_COMPONENTS} from 'ej-angular2/src/ej/dialog.component';

import {EJ_MENU_COMPONENTS} from 'ej-angular2/src/ej/menu.component';

import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent, EJ_SPLITTER_COMPONENTS, EJ_DROPDOWNLIST_COMPONENTS, EJ_MENU_COMPONENTS, EJ_TAB_COMPONENTS,
    EJ_DIALOG_COMPONENTS
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
