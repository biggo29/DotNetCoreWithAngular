import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {ListTable} from '../app/ListTable';
import {Trade} from '../app/Trade';
import {Level} from '../app/Level';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})

export class ListTableService {
    url = 'https://localhost:44359/api/ListTable';
    constructor(private http: HttpClient) { }

    getAllList(){
        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        //return 'TESTY'; 
        this.http.get<ListTable[]>(this.url);
        return this.http.get<ListTable[]>(this.url, httpOptions).pipe(
            map(response => {return <any> (response as unknown)})
        );
    }

    getAllTradeList(){
        //GetTradeList
        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        //return 'TESTY'; 
        //this.http.get<Trade[]>(this.url+'/'+'GetTradeList');
        return this.http.get<Trade[]>(this.url+'/'+'GetTradeList', httpOptions).pipe(
            map(response => {return <any> (response as unknown)})
        );
    }

    getLevelListByTradeId(tradeId: number){
        //GetLevelListByTradeId
        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        //this.http.get<Level[]>(this.url+'/'+'GetLevelListByTradeId'+tradeId);
        return this.http.get<Level[]>(this.url+'/'+'GetLevelListByTradeId/'+tradeId, httpOptions)
        .pipe(map(response => {return <any> (response as unknown)}));
    }

    getListTableById(listTableId: number){
        //GetListTableById
        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        //this.http.get<Level[]>(this.url+'/'+'GetLevelListByTradeId'+tradeId);
        return this.http.get<ListTable>(this.url+'/'+'GetListTableById'+'/'+listTableId, httpOptions)
        .pipe(map(response => {return <any> (response as unknown)}));
    }

    createListTable(listTable: ListTable){
        let body = {
            'text':listTable.manager
        };
        console.log('Data');
        console.log(listTable);

        let  form =new FormData();
        form.append("name",listTable.manager);
        form.append("text",'Hello');
        form.append("fSyllabus",listTable.fileSyllabus,listTable.fileSyllabus.name);
        form.append("fTestPlan",listTable.fileTestPlan,listTable.fileTestPlan.name); //ListTableForm.fileTestPlan
        this.http.post(this.url, form).subscribe(
            (response) => console.log(response),
            (error) => console.log(error)
        )
        alert("Submited");

        // const httpOptions = { headers: new HttpHeaders() };
        // return this.http.post(this.url+'/', body, httpOptions)
        // .pipe(map(response=>{return <any> (response as unknown)}));
    }
}
