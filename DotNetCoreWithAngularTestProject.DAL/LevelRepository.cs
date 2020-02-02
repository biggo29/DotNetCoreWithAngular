using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreWithAngularTestProject.DAL
{
    public class LevelRepository
    {
        public List<Level> GetList()
        {
            using (TestDbContext _context = new TestDbContext())
            {
                return _context.Level.ToList();
            }
        }

        public List<Level> GetListByTradeId(int Id)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                return _context.Level.Where(i => i.tradeId == Id).ToList();
            }
        }

        public Level GetById(int Id)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                Level level = new Level();
                level = _context.Level.FirstOrDefault(i => i.levelId == Id);

                return level;
            }
        }

        public Level Save(Level level)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                if (level.levelId == 0)
                {
                    _context.Add(level);
                }
                else
                {
                    _context.Update(level);
                }
                _context.SaveChanges();
                return level;
            }
        }

        public bool Iduplicate(Level level)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                if (_context.Level.Where(i => i.levelName == level.levelName && i.levelId != level.levelId).ToList().Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public bool Delete(int Id)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                var level = _context.Level.FirstOrDefault(i => i.levelId == Id);
                if (level != null)
                {
                    _context.Remove(level);
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
