using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Interface
{
    public interface IListTableService
    {
        List<ListTable> GetList();
        List<Trade> GetTradeList();
        List<Level> GetLevelListByTradeId(int Id);
        ListTable GetById(int Id);
        ListTable Save(ListTable listTable);
        //bool Iduplicate(ListTable ListTable);
        bool Delete(int Id);
    }
}
