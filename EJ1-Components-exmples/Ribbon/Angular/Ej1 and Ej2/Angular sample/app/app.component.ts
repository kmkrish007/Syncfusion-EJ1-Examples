import { Component} from '@angular/core';

@Component({
    selector: 'app-container',
template: `<nav>
    <a routerLink="/first" routerLinkActive="active">Grid</a>
  </nav><router-outlet></router-outlet>`,
})
export class AppComponent{

}