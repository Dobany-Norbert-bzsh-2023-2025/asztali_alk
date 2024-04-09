using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyek
{
    public class hegy
    {
      

        public string csucsNev { get; set; }
        public string hegyseg { get; set; }
        public int magassag { get; set; }

        public hegy()
        {

        }

        public hegy(string sor)
        {
            var h = sor.Split(";");
            csucsNev = h[0];
            hegyseg = h[1];
            magassag = Convert.ToInt32(h[2]);
        }

        public override string? ToString()
        {
            return $"Csucs: {this.csucsNev} | Hegyseg: {this.hegyseg} | Magassag: {this.magassag}m";
        }
    }
}
