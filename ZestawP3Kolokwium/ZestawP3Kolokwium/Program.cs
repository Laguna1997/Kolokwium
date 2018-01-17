using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZestawP3Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            string nazwaKraju, nazwaStolicy;
            int powierzchniaKraju;
            bool czyJestLotnisko;
            int lotnisko;
            Europa nowe = new Europa();
            do
            {
                Console.WriteLine("1.DODAJ POZYCJE");
                Console.WriteLine("2.USUN POZYCJE PIERWSZA");
                Console.WriteLine("3.POKAZ KRAJE");
                Console.WriteLine("4.POKAZ STOLICE");
                Console.WriteLine("5.SPRAWDZ");
                Console.WriteLine("6.USUN POZYCJE O DANEJ NAZWIE");
                Console.WriteLine("7.WYJSCIE Z APLIKACJI");
                wybor = int.Parse(Console.ReadLine());
                switch(wybor)
                {
                    case 1:
                        Console.WriteLine("NAZWA KRAJU:");
                        nazwaKraju = Console.ReadLine();
                        pozycja1Label:
                        Console.WriteLine("POWIERZCHNIA KRAJU:");
                        try
                        {
                            powierzchniaKraju = int.Parse(Console.ReadLine());
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                            goto pozycja1Label;
                        }
                        Console.WriteLine("NAZWA STOLICY:");
                        nazwaStolicy = Console.ReadLine();
                        pozycja2Label:
                        Console.WriteLine("LOTNISKO:(WCISNIJ 1(TAK), 0(NIE))");
                        try
                        {
                            lotnisko = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            goto pozycja2Label;
                        }
                        if(lotnisko==1)
                        {
                            czyJestLotnisko = true;
                        }
                        else
                        {
                            czyJestLotnisko = false;
                        }
                        nowe.Dodaj(nazwaKraju, powierzchniaKraju, nazwaStolicy, czyJestLotnisko);
                        break;
                    case 2:
                        nowe.Usun();
                        Console.WriteLine("USUNALEM PIERWSZA POZYCJE");
                        break;
                    case 3:
                        Console.WriteLine(nowe.Kraje());
                        break;
                    case 4:
                        Console.WriteLine(nowe.Stolice());
                        break;
                    case 5:
                        Console.WriteLine("NAZWA STOLICY:");
                        nazwaStolicy = Console.ReadLine();
                        nowe.Sprawdz(nazwaStolicy);
                        break;
                    case 6:
                        Console.WriteLine("NAZWA KRAJU:");
                        nazwaKraju = Console.ReadLine();
                        nowe.Usun(nazwaKraju);
                        break;
                    case 7:
                        Console.WriteLine("WYJSCIE Z APLIKACJI");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("PODALES ZLA LICZBE PRZY WYBORZE ;(");
                        break;
                     
                }
            }
            while (wybor != 7);
        


            Console.ReadKey();
        }
    }
}
