using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreWithAngularTestProject.Model
{
    public class TestDbContext : DbContext
    {
        public static string ConnectionString { get; set; }
        public TestDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public virtual DbSet<Trade> Trade { get; set; }
    }
}
