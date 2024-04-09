using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haziallatok.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Nev { get; set; }

        public ICollection<Pet> Pet { get;} = new List<Pet>();

        public Owner() { }

        public Owner(string nev)
        {
            Nev = nev;
        }

        public override string? ToString()
        {
            string s = Nev + ": (";
            foreach (var pet in Pet)
            {
                s += pet+", ";
            }

            return s+")";
        }
    }
}
