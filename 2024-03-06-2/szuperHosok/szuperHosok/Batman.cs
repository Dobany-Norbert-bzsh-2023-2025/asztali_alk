using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuperHosok
{
    public class Batman : ISzuperhos, IMilliardos
    {
        

        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public void kutyutKeszit()
        {
            this.lelemenyesseg += 50;
        }

        public bool legyoziE(ISzuperhos hos)
        {
            return hos.mekkoraAzEreje() < this.lelemenyesseg;
        }

        public double mekkoraAzEreje()
        {
            return lelemenyesseg * 2;
        }

        public override string? ToString()
        {
            return $"Batman lelemenyessge: {this.lelemenyesseg}";
        }
    }
}
