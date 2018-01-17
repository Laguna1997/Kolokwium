using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZestawP3Kolokwium
{
    public class Europa:ISprawdzanie,IOperacje
    {
        private SortedList<Kraj, Stolica> panstwa = new SortedList<Kraj, Stolica>();
        public void Dodaj(string nazwaK,int powierzchnia,string nazwaS,bool lotnisko)
        {
            panstwa.Add(Kraj.UtworzKraj(nazwaK,powierzchnia), new Stolica(nazwaS, lotnisko));
        }
        public bool Sprawdz(string a)
        {
            int ileRazy = 0;
            foreach (string element in panstwa.Values.OfType<string>())
            {
                if (element == a)
                {
                    ileRazy++;
                }
            }
            if (ileRazy == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void Usun()
        {
            if(panstwa.First().Value!=null)
            {
                panstwa.RemoveAt(0);
            }
        }

        public void Usun(string g) //Dokonczyc
        {
            
        }
        public string Kraje()
        {
            ICollection<Kraj> kraje = panstwa.Keys;
            foreach(var element in panstwa)
            {
                Console.WriteLine(element.Key);
            }
            return kraje.ToString();
        }
        public string Stolice()
        {
            ICollection<Stolica> stolice = panstwa.Values;
           foreach(var element in panstwa)
            {
                Console.WriteLine(element.Value);
                
            }
            return stolice.ToString();
        }
       

    }
}
