using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class szamitogep
    {
        double szabad;
        bool kapcs;

        public double Szabad { get => szabad; }
        public bool Kapcs { get => kapcs; }

        public szamitogep() { }
        public szamitogep(double szabad, bool kapcs)
        {
            this.szabad = szabad;
            this.kapcs = kapcs;
        }

        public void Kapcsol()
        {
            this.kapcs = !this.kapcs;
        }

        public override string ToString()
        {
            return $"A szamitogep szabad memoriaja {szabad}"        
        }


    }
}
