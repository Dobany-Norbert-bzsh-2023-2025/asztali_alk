using System.Threading.Channels;

namespace ButorModels
{
    public enum type
    {
        Tartolap, Hatlap
    }
    public class Butorlap
    {
        
        
        private double szelesseg;
        private double hossz;
        private type Type;

        private int tartolapAr = 5000;
        private int hatlapAr = 500;

        public Butorlap(int szelesseg, int hossz, type type)
        {
            this.szelesseg = szelesseg /100.0;
            this.hossz = hossz /100.0;
            this.Type = type;
        }

        public double ArSzamlal()
        {
            return Math.Round(this.hossz * this.szelesseg *
            (this.Type == type.Tartolap ? this.tartolapAr : this.hatlapAr),2);
        }

        public override string? ToString()
        {
            return $"{this.hossz}m * {this.szelesseg}m nagysagu | tipus:{this.Type} | ar:{this.ArSzamlal()} ft";
        }
    }
}