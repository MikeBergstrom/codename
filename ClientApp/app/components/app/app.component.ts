import { Component } from '@angular/core';
import {ApiService} from './api.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    deck;

    constructor(
        private _apiService: ApiService,
      ){
          this.deck = this._apiService.getDeck();
          console.log(this.deck)
    }
}
