using haziallatok.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haziallatok.Data
{
    public class PetContext: DbContext
    {

        string conn = "Server=127.0.0.1;User ID=root;Password=;Database=AllatkakDB;";
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public PetContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AllatkakDB;Trusted_Connection=True;");
        }
    }
}
