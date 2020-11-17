import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { EJ_LISTBOX_COMPONENTS} from 'ej-angular2/src/ej/listbox.component';
import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent, EJ_LISTBOX_COMPONENTS
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
