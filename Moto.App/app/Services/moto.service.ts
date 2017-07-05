import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { Motocykl } from '../Motocykle/Motocykl';

@Injectable()
export class MotoService {
    private _url: string = 'http://localhost:54549/api/Motocykle';
    private _headers = new Headers({ 'Content-Type': 'application/json' });

    constructor(private _http: Http) { }

    getAll(): Observable<Motocykl[]> {
        return this._http.get(this._url)
            .map((response: Response) => <Motocykl[]>response.json())
            .catch(this.handleError);
    }

    get(id: number): Observable<Motocykl> {
        const url = `${this._url}/${id}`;
        return this._http.get(url)
            .map((response: Response) => <Motocykl>response.json())
            .catch(this.handleError);
    }

    add(moto: Motocykl): Observable<string> {
        return this._http.post(this._url, JSON.stringify(moto), { headers: this._headers })
            .map((response: Response) => <string>response.json())
            .catch(this.handleError);
    }

    delete(id: number): Observable<string> {
        const url = `${this._url}/${id}`;
        return this._http.delete(url)
            .map((response: Response) => <string>response.json())
            .catch(this.handleError);
    }
    

    private handleError(error: Response) {
        console.log(error);
        return Observable.throw(error.json().error || 'Server error.');
    }
}