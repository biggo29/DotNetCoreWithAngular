using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Interface
{
    public interface ILevelService
    {
        List<Level> GetList();
        List<Level> GetListByTradeId(int Id);
        Level GetById(int Id);
        Level Save(Level level);
        //bool Iduplicate(Trade trade);
        bool Delete(int Id);
    }
}
