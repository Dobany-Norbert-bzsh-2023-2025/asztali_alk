using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuperHosok
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        public double Szuperero
        {
            get
            {
                return szuperero;
            }
            set
            {
                if (value >= 0)
                {
                    szuperero = value;
                }
            }
        }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            Szuperero = szuperero;
            VanEGyengesege = vanEGyengesege;

        }

        public abstract bool megmentiAVilagot();

        public double mekkoraAzEreje()
        {
            return this.Szuperero;
        }

        bool ISzuperhos.legyoziE(ISzuperhos hos)
        {
            if (hos is Bosszuallo)
            {
                return (((Bosszuallo)hos).mekkoraAzEreje() < this.mekkoraAzEreje() && ((Bosszuallo)hos).vanEGyengesege);           
            }
            else
            {
                return ((Batman)hos).mekkoraAzEreje() < this.mekkoraAzEreje() * 2;
            }
        }
        

        public override string? ToString()
        {
            return "bosszuallo";
        }
    }
}
