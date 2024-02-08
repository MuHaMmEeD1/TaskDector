using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDrectorModel.Entitys;

namespace TaskDrectorDataAccess.Contexts
{
    public class DrectorDb : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string strConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DrectorTaskDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(strConnection);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Debtor> Debtors { get; set; }

    }
}
