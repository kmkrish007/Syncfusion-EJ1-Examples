import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { GridModule, GroupService, FilterService, EditSettingsModel, ToolbarItems, PageService, SortService, EditService, ToolbarService } from '@syncfusion/ej2-ng-grids';
import { ToolbarModule } from '@syncfusion/ej2-ng-navigations';
import { DateTimePickerModule } from '@syncfusion/ej2-ng-calendars';
import { AppComponent } from './app.component';
import { FirstComponent } from './first.component';
import { RouterModule, Routes } from '@angular/router';
import { EJ_RIBBON_COMPONENTS } from 'ej-angular2/src/ej/ribbon.component'; 

const appRoutes: Routes = [
  { path: 'first', component: FirstComponent },
  {
    path: '',
    redirectTo: '/first',
    pathMatch: 'full'
  }
];

/**
 * Module
 */
@NgModule({
  imports: [
    BrowserModule,
    GridModule,
    ToolbarModule,
    CommonModule,
    DateTimePickerModule,

    RouterModule.forRoot(
      appRoutes,
      { useHash: true } // <-- debugging purposes only
    )
  ],
  declarations: [AppComponent, FirstComponent,EJ_RIBBON_COMPONENTS],
  bootstrap: [AppComponent],
  providers: [GroupService, EditService, FilterService, PageService, SortService, ToolbarService]
})
export class AppModule { }