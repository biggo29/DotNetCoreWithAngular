using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Interface
{
    public interface ITradeService
    {
        List<Trade> GetList();
        Trade GetById(int Id);
        Trade Save(Trade trade);
        //bool Iduplicate(Trade trade);
        bool Delete(int Id);
    }
}
