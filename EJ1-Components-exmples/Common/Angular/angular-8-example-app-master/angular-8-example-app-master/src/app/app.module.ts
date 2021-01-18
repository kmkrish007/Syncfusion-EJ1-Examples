import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppComponent} from './app.component';
import {EJ_TREEVIEW_COMPONENTS} from 'ej-angular2/src/ej/treeview.component';
import { EJAngular2Module } from 'ej-angular2';

@NgModule({
  bootstrap: [AppComponent],
  declarations: [AppComponent, EJ_TREEVIEW_COMPONENTS],
  imports: [
    BrowserModule
  ]
})

export class AppModule {
}
