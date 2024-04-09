using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public abstract class Jedi : IEroErzekeny
    {
        public double ero;
        public bool atallhatE;

        protected Jedi(double ero, bool atallhatE)
        {
            this.ero = ero;
            this.atallhatE = atallhatE;
        }


        public abstract bool megteremtiAzEgyensulyt();

        public bool LegyoziE(IEroErzekeny o)
        {
            if ((o is Jedi))
            {
                if (((Jedi)o).atallhatE && ((Jedi)o).MekkoraAzEreje() < this.ero)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (((Uralkodo)o).MekkoraAzEreje()*2<this.ero)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public double MekkoraAzEreje()
        {
            return this.ero;
        }
    }
}
