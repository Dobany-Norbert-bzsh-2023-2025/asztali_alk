namespace torta
{
    internal class Torta
    {
        public int Emelet;
        public bool Kenve;

        public Torta(int emelet, bool kenve)
        {
            Emelet = emelet;
            Kenve = kenve;

        }

        public Torta() : this(1, false) { }

        public void ujEmelet()
        {
            this.Emelet++;
        }

        public bool kremmelMegken()
        {
            if(this.Kenve==false)
            {
                return this.Kenve = true;
            }
            return false;
        }

        public int mennyiKaloria()
        {
            int Kaloria = this.Emelet * 1000;
            if(this.Kenve)
            {
                Kaloria = Kaloria * 2;
            }
            return Kaloria;
        }

        public override string ToString()
        {
            return $"Emelet: {Emelet}, Kenve?: {(Kenve ? "krémmel":"krém nélkül")}, Kaloria: {(this.mennyiKaloria())}";
        }







    }
}
