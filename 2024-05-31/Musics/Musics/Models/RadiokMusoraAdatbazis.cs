using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.EntityFrameworkCore;

namespace Musics.Models
{
    public class RadiokMusoraAdatbazis
    {
        public DbSet<Adok> adok { get; set; }
        public DbSet<Eloado> eloadok { get; set; }
        public  DbSet<Szam> szamok { get; set; }
        
    }
}
