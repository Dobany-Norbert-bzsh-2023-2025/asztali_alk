using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public class Uralkodo : IEroErzekeny, ISith
    {

        private double gondoszsag;

        public Uralkodo()
        {
            this.gondoszsag = 100;
        }

        public void engeddElAHaragod()
        {
            this.gondoszsag += 50;
        }

        public bool LegyoziE(IEroErzekeny o)
        {
            return o.MekkoraAzEreje() < this.gondoszsag;
        }

        public double MekkoraAzEreje()
        {
            return this.gondoszsag*2;
        }

        public override string? ToString()
        {
            return $"Uralkodo gonoszság: {this.gondoszsag}";
        }
    }
}
