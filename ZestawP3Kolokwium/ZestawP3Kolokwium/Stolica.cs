using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZestawP3Kolokwium
{
    public class Stolica
    {
        private string nazwa;
        private bool lotnisko;
        private string rezulat;
        public Stolica(string nazwaK,bool lotniskoK)
        {
            this.nazwa = nazwaK;
            this.lotnisko =lotniskoK;
            if(this.lotnisko==true)
            {
                rezulat = "tak";
            }
            else
            {
                rezulat = "nie";
            }
        }      
        
        public override string ToString()
        {
            return "Stolica:" + this.nazwa + " " + ", lotnisko:" + rezulat; 
        }
    }
}
