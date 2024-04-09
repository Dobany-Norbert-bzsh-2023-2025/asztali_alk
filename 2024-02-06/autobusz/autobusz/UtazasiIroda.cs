using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vallalat
{
    public class UtazasiIroda
    {
        private autobusz[] buszok;
        private int szabadBuszokSzama;
        
        public UtazasiIroda(int maxBuszSzam) 
        {
            szabadBuszokSzama = 0;
            buszok = new autobusz[maxBuszSzam];
        }

        public bool BuszHozzad(autobusz busz)
        {
            if (szabadBuszokSzama == buszok.Length) 
            {
                return false;
            }
            buszok[szabadBuszokSzama++] = busz;
            return true;
        }

        public autobusz BuszBerel(int km, int fo)
        {
            autobusz joBusz = new autobusz();
            for (int i = 0; i < buszok.Length; i++)
            {
                if (busz.Hatotav>=km && busz.SzabadFer>=fo && busz.Ar<joBusz.Ar || joBusz.Ar==-1)
                {
                    joBusz = busz;
                }
            }
            return joBusz;
        }
    }
}
