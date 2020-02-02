using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreWithAngularTestProject.DAL
{
    public class TradeRepository
    {
        //Get all the trade list
        public List<Trade> GetList()
        {
            using (TestDbContext _context = new TestDbContext())
            {
                return _context.Trade.ToList();
            }
        }

        public Trade GetById(int Id)
        {
            using(TestDbContext _context = new TestDbContext())
            {
                Trade trade = new Trade();
                trade = _context.Trade.FirstOrDefault(i => i.tradeId == Id);

                return trade;
            }
        }

        public Trade Save(Trade trade)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                if (trade.tradeId == 0)
                {
                    _context.Add(trade);
                }
                else
                {
                    _context.Update(trade);
                }
                _context.SaveChanges();
                return trade;
            }
        }

        public bool Iduplicate(Trade trade)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                if(_context.Trade.Where(i=>i.tradeName == trade.tradeName && i.tradeId != trade.tradeId).ToList().Count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                var trade = _context.Trade.FirstOrDefault(i => i.tradeId ==
               id);
                if (trade != null)
                {
                    _context.Remove(trade);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
