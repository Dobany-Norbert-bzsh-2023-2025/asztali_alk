using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace objects
{
    internal class macska
    {
        string nev;
        double suly;
        bool ehes;

        public string Nev { get => nev; }
        public double Suly { get => suly; set => suly = value; }
        public bool Ehes { get => ehes; }

        public macska() { }

        public macska(string nev, double suly, bool ehes) 
        {
            this.nev = nev;
            this.suly = suly;
            this.ehes = ehes;
        }

        public macska(string nev,double suly):this(nev,suly,true)
        { 
        }

        public bool Eszik(double etel)
        {
            if(this.ehes)
            {
                this.suly += etel;
                return true;
            }
            return false;

        }

        public void Futkos()
        {
            suly -= 0.1;
            ehes = true;
        }

        public override string ToString()
        {
            return $"Nev:{nev}, Suly:{suly}, {(ehes?"éhes":"jóllakott")}";
        }

    }
}
