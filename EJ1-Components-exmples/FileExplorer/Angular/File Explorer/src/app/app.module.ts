import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FileExplorerComponent } from 'ej-angular2/src/ej/fileexplorer.component';

import { EJAngular2Module } from 'ej-angular2';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,FileExplorerComponent,
  ],
  imports: [
    BrowserModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
