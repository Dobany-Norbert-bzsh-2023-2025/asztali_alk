using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryWpf.Models;

namespace LotteryWpf.Context
{
    public class Context:DbContext
    {
        public DbSet<Sorsolas> Sorsolasok { get; set; }
        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AllatkakDB;Trusted_Connection=True;");
        }
    }
}
