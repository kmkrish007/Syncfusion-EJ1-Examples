import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {EJ_AUTOCOMPLETE_COMPONENTS} from 'ej-angular2/src/ej/autocomplete.component';
import {EJ_COMBOBOX_COMPONENTS} from 'ej-angular2/src/ej/combobox.component';
import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent, EJ_AUTOCOMPLETE_COMPONENTS, EJ_COMBOBOX_COMPONENTS
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
