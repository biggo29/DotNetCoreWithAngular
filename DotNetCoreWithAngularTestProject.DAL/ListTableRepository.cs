using DotNetCoreWithAngularTestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreWithAngularTestProject.DAL
{
    public class ListTableRepository
    {
        public List<ListTable> GetList()
        {
            using (TestDbContext _context = new TestDbContext())
            {
                return _context.ListTable.ToList();
            }
        }

        public List<Trade> GetTradeList()
        {
            using(TestDbContext _context = new TestDbContext())
            {
                return _context.Trade.ToList();
            }
        }
        public List<Level> GetLevelListByTradeId(int Id)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                return _context.Level.Where(i => i.tradeId == Id).ToList();
            }
        }

        public ListTable GetById(int Id)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                ListTable ListTable = new ListTable();
                ListTable = _context.ListTable.FirstOrDefault(i => i.listId == Id);

                return ListTable;
            }
        }

        public ListTable Save(ListTable ListTable)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                if (ListTable.listId == 0)
                {
                    _context.Add(ListTable);
                }
                else
                {
                    _context.Update(ListTable);
                }
                _context.SaveChanges();
                return ListTable;
            }
        }

        public bool Iduplicate(ListTable ListTable)
        {
            using (TestDbContext _context = new TestDbContext())
            {
                if (_context.ListTable.Where(i => i.syllabusName == ListTable.syllabusName && i.listId != ListTable.listId).ToList().Count > 0)
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
                var ListTable = _context.ListTable.FirstOrDefault(i => i.listId == Id);
                if (ListTable != null)
                {
                    _context.Remove(ListTable);
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
