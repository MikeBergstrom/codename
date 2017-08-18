import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/Rx';

@Injectable()
export class ApiService {

  constructor(private _http: Http) { }
  getDeck() {
    console.log("in the service, printing the setId")
    return this._http.get(`/get_deck`).map(data=>data.json()).toPromise();
  }
}
