using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termekek
{
    public class Salata : Termek
    {
        private int darab;


        public Salata(int darab, int egysegar) : base("salata", egysegar)
        {
            this.darab = darab;
        }

        public override int mennyibeKerul()
        {
            return this.darab * this.egysegar;
        }

        public override string? ToString()
        {
            return $"{darab} db salata - {mennyibeKerul()}Ft";
        }
    }
}
