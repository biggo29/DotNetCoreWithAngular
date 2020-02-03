import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Trade} from '../app/Trade';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class TradeService {
    url = 'https://localhost:44359/api/Trade';
    constructor(private http: HttpClient) { }

    getAllTrade(){
        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        //return 'TESTY'; 
        this.http.get<Trade[]>(this.url);
        return this.http.get<Trade[]>(this.url, httpOptions).pipe(
            map(response => {return <any> (response as unknown)})
        );
    }
}
