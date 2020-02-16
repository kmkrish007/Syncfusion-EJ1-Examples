import { Component, OnInit, ViewEncapsulation, ViewChild } from '@angular/core';
import { FileManagerComponent, NavigationPaneService, DetailsViewService, ToolbarService as FileManagerToolbar } from '@syncfusion/ej2-angular-filemanager';
import { DocumentEditorContainerComponent } from "@syncfusion/ej2-angular-documenteditor";
import { SpreadsheetComponent } from '@syncfusion/ej2-angular-spreadsheet';
import {
  PdfViewerComponent, ToolbarService as PdfToolbar, LinkAnnotationService, BookmarkViewService, MagnificationService, ThumbnailViewService,
  NavigationService, TextSearchService, TextSelectionService, PrintService, AnnotationService, FormFieldsService
} from '@syncfusion/ej2-angular-pdfviewer';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css'],
  encapsulation: ViewEncapsulation.None,
  providers: [NavigationPaneService, DetailsViewService, FileManagerToolbar, PdfToolbar, LinkAnnotationService, BookmarkViewService, MagnificationService, ThumbnailViewService,
    NavigationService, TextSearchService, TextSelectionService, PrintService, AnnotationService, FormFieldsService]
})
export class AppComponent {
  @ViewChild("documenteditor_default")
  public container: DocumentEditorContainerComponent;
  @ViewChild('spreadsheet')
  public spreadsheetObj: SpreadsheetComponent;
  @ViewChild("pdfView")
  public pdfView: PdfViewerComponent;
  //File Manager proeprties initialized
  public ajaxSettings: object;
  //SpreatSheet URL
  public openUrl: string;
  public saveUrl: string;
  public service: string = 'https://ej2services.syncfusion.com/production/web-services/api/pdfviewer';
  public ngOnInit(): void {
    this.ajaxSettings = {
      url: 'api/SampleData/AzureFileOperations',
      getImageUrl: 'api/SampleData/AzureGetImage',
      uploadUrl: 'api/SampleData/AzureUpload',
      downloadUrl: 'api/SampleData/AzureDownload'
    };
    this.openUrl = "api/SampleData/OpenExcel";
    this.saveUrl = "api/SampleData/SaveExcel";
  }

  // File Manager File Open event
  fileOpen(args) {
    let fileName: string = args.fileDetails.name;
    let filePath: string = args.fileDetails.filterPath.replace(/\\/g, "/") + fileName;
    let fileType: string = args.fileDetails.type;

    if (fileType == ".docx" || fileType == ".txt" || fileType == ".html" || fileType == ".rtf" || fileType == ".xml") {
      this.showDocViewer(fileName);
      this.container.refresh();
      this.getFileStream(filePath, false)
    }
    // File type is excel
    else if (fileType == ".xlsx") {
      this.showExcelViewer(fileName);
      this.spreadsheetObj.refresh();
      // Open the file in spreadsheet.
      this.getBlob(fileName, filePath)
    }
    // File Type is pdf
    else if (fileType == ".pdf") {
      this.showPDFViewer(fileName);
      //this.pdfView.refresh();
      // Open the file in PDF viewer
      this.getFileStream(filePath, true);
      // this.load(filePath);
    }
  }

  //Shows the Document viewer 
  showDocViewer(name: string) {
    document.getElementsByClassName("doc-title")[0].innerHTML = name;
    (<HTMLElement>document.getElementsByClassName("file-container")[0]).style.display = "none";
    (<HTMLElement>document.getElementsByClassName("doc-container")[0]).style.display = "block";
  }

  //Shows the SpreadSheet viewer 
  showExcelViewer(name: string) {
    (<HTMLElement>document.getElementsByClassName("file-container")[0]).style.display = "none";
    (<HTMLElement>document.getElementsByClassName("excel-container")[0]).style.display = "block";
    document.getElementsByClassName("excel-title")[0].innerHTML = name;
  }

  //Shows the PDF viewer 
  showPDFViewer(name: string) {
    (<HTMLElement>document.getElementsByClassName("file-container")[0]).style.display = "none";
    (<HTMLElement>document.getElementsByClassName("pdf-container")[0]).style.display = "block";
    (<HTMLElement>document.getElementsByClassName("pdf-container")[0]).style.visibility = "visible";
    document.getElementsByClassName("pdf-title")[0].innerHTML = name;
  }

  //closes the viewers and open file manager
  onClicked() {
    (<HTMLElement>document.getElementsByClassName("file-container")[0]).style.display = "block";
    (<HTMLElement>document.getElementsByClassName("doc-container")[0]).style.display = "none";
    (<HTMLElement>document.getElementsByClassName("excel-container")[0]).style.display = "none";
    (<HTMLElement>document.getElementsByClassName("pdf-container")[0]).style.visibility = "hidden";
    (<HTMLElement>document.getElementsByClassName("pdf-container")[0]).style.display = "none";
  }

  // sends HTTPPost Request to read the file as fileStream.
  getFileStream(filePath: string, isPDF: boolean) {
    let ajax: XMLHttpRequest = new XMLHttpRequest();
    ajax.open("POST", "api/SampleData/GetDocument", true);
    ajax.setRequestHeader("content-type", "application/json");
    ajax.onreadystatechange = () => {
      if (ajax.readyState === 4) {
        if (ajax.status === 200 || ajax.status === 304) {
          if (!isPDF) {
            // open SFDT text in document editor
            this.container.documentEditor.open(ajax.responseText);
          } else {
            //opens the file in pdf viewer
            this.pdfView.load(ajax.responseText, null);
          }
        }
      }
    };
    ajax.send(JSON.stringify({ "FileName": filePath, "Action": (!isPDF ? "ImportFile" : "LoadPDF") }));
  }

  //Get the blob using HTTPGet and loads in spreadsheet
  getBlob(fileName: string, filePath: string) {
    let request: XMLHttpRequest = new XMLHttpRequest();
    request.responseType = "blob";
    request.onload = () => {
      let file: any = new File([request.response], fileName);
      this.spreadsheetObj.open({ file: file });
    }
    request.open("GET", "api/SampleData/GetExcel" + "?FileName=" + filePath);
    request.send();
  }
}
