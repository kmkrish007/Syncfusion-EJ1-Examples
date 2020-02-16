import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { FileManagerAllModule } from '@syncfusion/ej2-angular-filemanager';
import { AppComponent } from './app.component';
import { SpreadsheetAllModule } from '@syncfusion/ej2-angular-spreadsheet';
import { DocumentEditorAllModule, DocumentEditorContainerAllModule } from '@syncfusion/ej2-angular-documenteditor';
import { PdfViewerModule } from '@syncfusion/ej2-angular-pdfviewer';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
      HttpModule,
    FileManagerAllModule,
    DocumentEditorAllModule, DocumentEditorContainerAllModule,
    SpreadsheetAllModule,
    PdfViewerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
