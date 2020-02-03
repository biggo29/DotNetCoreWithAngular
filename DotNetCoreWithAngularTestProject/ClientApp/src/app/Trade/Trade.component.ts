import { Component, OnInit } from '@angular/core';
import {TradeService} from '../Trade.service';
import {Trade} from '../Trade'

@Component({
  selector: 'trade',
  templateUrl: './Trade.component.html',
  styleUrls: ['./Trade.component.css']
})
export class TradeComponent implements OnInit {
  new: boolean = false;
  trade: Trade=new Trade();
  tradeList: Trade[]=[];
  //private tradeService: TradeService = new TradeService();
  constructor(private tradeService: TradeService) { }
  ngOnInit() {
    this.loadAllTrades();
  }

  loadAllTrades(){
    // alert(this.tradeService.getAllTrade());
    this.tradeService.getAllTrade().subscribe(
      res=>{this.tradeList = res;
        // alert("Component Hit");
        console.log(res);
      });
  }

}
