using ButorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorModels2
{
    public class Butor
    {
        private int lapokSzama;
        private Butorlap[] butorlapok;

        public Butor()
        {
            this.butorlapok = new Butorlap[100];
            this.lapokSzama = 0;
        }

        public void lapHozzaad(Butorlap butorlap)
        {
            this.butorlapok[lapokSzama++] = butorlap;
            //lapokSzama++;

        }

        public double arSzamol()
        {
            double ar = 0;
            for (int i = 0; i < this.lapokSzama; i++)
            {
                ar += this.butorlapok[i].ArSzamlal();
            }
            return ar;
        }

        public override string? ToString()
        {
            return $"Bútorlapok: {this.lapokSzama} | Ar: {arSzamol()} ft";
        }
    }
}
