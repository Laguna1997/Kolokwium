using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZestawP3Kolokwium
{
    interface IOperacje
    {
        void Dodaj(string a, int b, string c, bool d);
        void Usun();
        void Usun(string g);
    }
}
