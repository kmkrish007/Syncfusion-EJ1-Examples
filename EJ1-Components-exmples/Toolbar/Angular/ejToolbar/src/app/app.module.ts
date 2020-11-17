import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {EJ_DROPDOWNLIST_COMPONENTS} from 'ej-angular2/src/ej/dropdownlist.component';
import {EJ_RADIOBUTTON_COMPONENTS} from 'ej-angular2/src/ej/radiobutton.component';
import {EJ_TOOLBAR_COMPONENTS} from 'ej-angular2/src/ej/toolbar.component';
import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent, EJ_DROPDOWNLIST_COMPONENTS, EJ_RADIOBUTTON_COMPONENTS, EJ_TOOLBAR_COMPONENTS
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
