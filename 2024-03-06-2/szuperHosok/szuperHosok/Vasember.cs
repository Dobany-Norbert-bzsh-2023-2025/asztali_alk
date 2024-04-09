using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuperHosok
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        public Vasember() : base(150, true) { }

        public void kutyutKeszit()
        {
            Random rnd = new Random();
            this.Szuperero += rnd.NextDouble() * 10;
        }

        public override bool megmentiAVilagot()
        {
            return (this.mekkoraAzEreje() > 1000);
        }

        public void Feltamad()
        {
            this.Szuperero += 100;
        }
        public override string? ToString()
        {
            return $"vasember";
        }
    }
}
