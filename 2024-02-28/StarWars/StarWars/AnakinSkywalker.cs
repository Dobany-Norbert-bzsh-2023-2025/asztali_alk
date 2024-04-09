using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class AnakinSkywalker : Jedi, ISith
    {
        public AnakinSkywalker() : base(150, true)
        {

        }

        public void engeddElAHaragod()
        {
            Random rnd = new Random();
            this.ero += rnd.NextDouble() * 10;
        }

        public override bool megteremtiAzEgyensulyt()
        {
            return this.MekkoraAzEreje() > 1000;
        }

        public override string? ToString()
        {
            return $"Anakin ero: {this.ero} Anakin atallhate: {(this.atallhatE?"atallhat":"nem allhat at")}";
        }
    }
}
