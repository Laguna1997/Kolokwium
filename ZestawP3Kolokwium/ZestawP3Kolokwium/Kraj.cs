using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZestawP3Kolokwium
{
    public class Kraj:IComparable<Kraj>
    {
        private string nazwa;
        private int powierzchnia;
        public string NazwaKraju { get { return nazwa; } }
        private Kraj(string nazwaK, int powierzchniaK)
        {
            this.nazwa = nazwaK;
            this.powierzchnia = powierzchniaK;
        }
        public static Kraj UtworzKraj(string nazwaU,int powierzchniaU)
        {
            return new Kraj(nazwaU, powierzchniaU);
        }

        public int CompareTo(Kraj other)
        {
            if(this.powierzchnia==other.powierzchnia)
            {
                return this.nazwa.CompareTo(other.nazwa);
            }
            return other.powierzchnia.CompareTo(this.powierzchnia);
        }

        public override string ToString()
        {
            return "Kraj:" + this.nazwa + "," + " Powierzchnia:" + this.powierzchnia;
        }
    }
}
