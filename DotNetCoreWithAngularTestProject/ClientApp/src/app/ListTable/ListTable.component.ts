import { Component, OnInit } from '@angular/core';
import {ListTableService} from '../ListTable.service';
import {ListTable} from '../ListTable';
import { Trade } from '../Trade';
import {NgSelectModule, NgOption} from '@ng-select/ng-select';
import { Level } from '../Level';

@Component({
  selector: 'app-ListTable',
  templateUrl: './ListTable.component.html',
  styleUrls: ['./ListTable.component.css']
})
export class ListTableComponent implements OnInit {
  new: boolean = false;
  listTable: ListTable=new ListTable();
  listTableList: ListTable[]=[];
  listOfTrades : Trade[] = [];
  listOfLevelByTradeId : Level[] = [];
  test=['1','2','3'];
 public ListTableForm=new ListTable();

  constructor(private listTableService: ListTableService) { }

  ngOnInit() {
    this.loadAllListTable();
    this.loadTradeList();
  }
  loadAllListTable(){
    this.listTableService.getAllList().subscribe(
      res => {this.listTableList = res;
        //alert("Component Hit");
        console.log(res);});
  }

  loadTradeList(){
    this.listTableService.getAllTradeList().subscribe(
      res => {this.listOfTrades = res;}
    );
  }

  loadGLevelListByTradeId(){
    this.listOfLevelByTradeId = null;
    //alert(this.ListTableForm.tradeId)
    this.listTableService.getLevelListByTradeId(this.ListTableForm.tradeId).subscribe(
      
      res => {
        console.log(res);
        this.listOfLevelByTradeId = res;}
    );
  }

  SyllabusFile(res)
  {
    this.ListTableForm.fileSyllabus = res[0];
  }

  TestPlanFile(res)
  {
    this.ListTableForm.fileTestPlan = res[0];
  }

  addData(){
    //alert("submit works");
 
     this.listTableService.createListTable(this.ListTableForm);
  }

}
