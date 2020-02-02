using DotNetCoreWithAngularTestProject.DAL;
using DotNetCoreWithAngularTestProject.Interface;
using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Service
{
    public class ListTableService : IListTableService
    {
        public List<ListTable> GetList()
        {
            ListTableRepository repo = new ListTableRepository();
            return repo.GetList();
        }
        public List<Trade> GetTradeList()
        {
            TradeRepository repo = new TradeRepository();
            return repo.GetList();
        }
        public List<Level> GetLevelListByTradeId(int Id)
        {
            LevelRepository repo = new LevelRepository();
            return repo.GetListByTradeId(Id);
        }
        public ListTable GetById(int Id)
        {
            ListTableRepository repo = new ListTableRepository();
            return repo.GetById(Id);
        }
        public ListTable Save(ListTable listTable)
        {
            ListTableRepository repo = new ListTableRepository();
            if (repo.Iduplicate(listTable))
            {
                return new ListTable();
            }
            else
            {
                return repo.Save(listTable);
            }
        }
        public bool Delete(int Id)
        {
            ListTableRepository repo = new ListTableRepository();
            return repo.Delete(Id);
        }
    }
}
