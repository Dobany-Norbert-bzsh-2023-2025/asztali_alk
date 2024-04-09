using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3
{
    internal class Hallgato
    {
        string azonosito;
        int evfolyam;
        int kredit;

        public string Azonosito { get => azonosito; }
        public int Evfolyam { get => evfolyam; }
        public int Kredit { get => kredit; }

        public Hallgato() { }

        public Hallgato(string azonosito,int evfolyam, int kredit)
        {
            this.azonosito = azonosito;
            this.evfolyam = evfolyam;
            this.kredit = kredit;
        }

        public Hallgato(string azonosito) : this(azonosito, 1, 0) { }

        public void targyFelvesz(int targyKredit)
        {
            kredit += targyKredit;
        }

        public bool vizsgazik()
        {
            if(kredit>0)
            {
                Console.WriteLine("Sikeres, kovetkezo evfolyamba lep");
                kredit = 0;
                evfolyam++;
                return true;
            }
            else
            {
                Console.WriteLine("Sikertelen");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Azon: {azonosito}, Evfoly: {evfolyam}, Kredit: {kredit}";
        }
    }
}
