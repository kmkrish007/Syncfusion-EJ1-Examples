import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {EJ_DATETIMEPICKER_COMPONENTS} from 'ej-angular2/src/ej/datetimepicker.component';
import {EJ_DATEPICKER_COMPONENTS} from 'ej-angular2/src/ej/datepicker.component';
import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent, EJ_DATETIMEPICKER_COMPONENTS, EJ_DATEPICKER_COMPONENTS
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
