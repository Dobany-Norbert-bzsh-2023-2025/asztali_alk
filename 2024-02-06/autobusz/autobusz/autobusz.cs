using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallalat
{
    public class autobusz
    {
        private int szabadFer;
        public int SzabadFer
        {
            get {return szabadFer ;}
            set {szabadFer = value ;}
        }
        
        private int hatotav;
        public int Hatotav
        {
            get {return hatotav ;}
            set {hatotav = value ;}
        }
        
        private int ar;
        public int Ar
        {
            get {return ar ;}
            set {ar = value ;}
        }

        private int maxFer;
        public int MaxFer
        {
            get { return maxFer; }
           // set { maxFer = value ;}
        }

        public autobusz (int szabadFer,int hatotav, int ar)
        {
            SzabadFer = maxFer = szabadFer;
            Hatotav = hatotav ;
            Ar = ar ;
        }

        public autobusz() : this(-1, -1, -1)
        {}

        public bool UtasHozzad(int utasokSzama)
        {
            if (szabadFer < utasokSzama)
            {
                return false;
            }
            szabadFer -= utasokSzama;
            return true;
        }

        public override string ToString()
        {
            return $"{maxFer} férőhellyel - ebőől szabad {szabadFer} - {hatotav} km hatótávval - {ar} Ft áron.";
        }


    }
}
