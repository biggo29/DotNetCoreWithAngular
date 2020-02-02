using DotNetCoreWithAngularTestProject.DAL;
using DotNetCoreWithAngularTestProject.Interface;
using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Service
{
    public class LevelService : ILevelService
    {
        public List<Level> GetList()
        {
            LevelRepository repo = new LevelRepository();
            return repo.GetList();
        }

        public List<Level> GetListByTradeId(int Id)
        {
            LevelRepository repo = new LevelRepository();
            return repo.GetListByTradeId(Id);
        }

        public Level GetById(int Id)
        {
            LevelRepository repo = new LevelRepository();
            return repo.GetById(Id);
        }

        public Level Save(Level level)
        {
            LevelRepository repo = new LevelRepository();
            if (repo.Iduplicate(level))
            {
                return new Level();
            }
            else
            {
                return repo.Save(level);
            }
        }

        public bool Delete(int Id)
        {
            LevelRepository repo = new LevelRepository();
            return repo.Delete(Id);
        }
    }
}
