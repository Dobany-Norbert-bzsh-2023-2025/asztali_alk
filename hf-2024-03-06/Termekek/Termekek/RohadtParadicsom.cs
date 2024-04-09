using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termekek
{
    internal class RohadtParadicsom : Termek, IAkciozhato
    {
        private double tomeg;
        public RohadtParadicsom(double tomeg, int egysegar) : base("rohadt paradicsom", egysegar)
        {
            this.tomeg = tomeg;
        }

        public int akcioAr()
        {
            throw new NotImplementedException();
        }

        public override int mennyibeKerul()
        {
            return Math.Round((this.tomeg * this.egysegar),0);
        }
    }
}
