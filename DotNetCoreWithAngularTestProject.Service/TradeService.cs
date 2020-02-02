using DotNetCoreWithAngularTestProject.DAL;
using DotNetCoreWithAngularTestProject.Interface;
using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Service
{
    public class TradeService : ITradeService
    {
        public List<Trade> GetList()
        {
            TradeRepository repo = new TradeRepository();
            return repo.GetList();
        }

        public Trade GetById(int Id)
        {
            TradeRepository repo = new TradeRepository();
            return repo.GetById(Id);
        }

        public Trade Save(Trade trade)
        {
            TradeRepository repo = new TradeRepository();
            if(repo.Iduplicate(trade))
            {
                return new Trade();
            }
            else
            {
                return repo.Save(trade);
            }
        }

        public bool Delete(int Id)
        {
            TradeRepository repo = new TradeRepository();
            return repo.Delete(Id);
        }
    }
}
