using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne_rozne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** Podstawy podstaw zmiennych **************");
            //Prost azmienna liczbowa całkowita
            int a = 1;
            int b;
            b = 2;
            int c = 3;
            string tekst1 = "Roman";
            string tekst2 = "Zbroiński";
            string nic = "";
            string spacja = " ";

            Console.WriteLine("Zmienna a wynosi: " + a);
            Console.WriteLine("Zmienna b wynosi: " + b);
            Console.WriteLine("Zmienna c wynosi: " + c);
            Console.WriteLine("Moje imię, to "+ tekst1);
            Console.WriteLine("Moje nazwisko, to " + tekst2);
            Console.WriteLine("Moje imię i nazwisko, to"+spacja + tekst1 + spacja + tekst2 + nic);
            //Console.ReadLine();

            //Karetka - enter lin'wy
            Console.WriteLine("\n");

            Console.WriteLine("************** Zmienne i proste operatory **************");

            int dodaj;
            dodaj = a + b;
            Console.WriteLine("Dodawanie (a+b): " + dodaj);

            int odejmij;
            odejmij = a - b;
            Console.WriteLine("Odejmowanie (a-b): " + odejmij);


            int pomnoz;
            pomnoz = a * b;
            Console.WriteLine("Mnożenie: " + pomnoz);


            int podziel;
            podziel = a / b;
            Console.WriteLine("Dzielenie (a*b): " + podziel);


            int potega;
            potega = c^2;
            Console.WriteLine("Potęgowanie, C^2: " + potega);

            int modulo;
            modulo = c%b;
            Console.WriteLine("Modulo b z c: " + modulo);

            //Karetka - enter lin'wy
            Console.WriteLine("\n");

            Console.WriteLine("************** Przypisanie zmiennych **************");

            //Przydatny skrócony zapis
            int zmienna1 = 10;
            int zmienna2 = 7;
            int suma1 = zmienna1 + zmienna2;
            Console.WriteLine("Gdy zmienna1=10 a zmienna2=7, to ich suma w zapisie: suma1 = zmienna1 + zmienna2 wynosi:");
            Console.WriteLine(suma1);

            //int zmienna3 = 10;
            zmienna1 += zmienna2;
            int suma2 = zmienna1;

            Console.WriteLine("Gdy skrócimy zapis: zmienna1 += zmienna2, to suma2 także wynosi:");
            Console.WriteLine(suma2);
            //Sprawdz inne zapisy z mnożeiem, dzieleniem, itd.
            Console.WriteLine("\n");

            Console.WriteLine("************** Nie mieszać typów zmiennych **************");
            Console.WriteLine("Gdy dzielimy 5/10, to otrzymujemy: ");
            double zmiennaInteger = 5/10;
            Console.WriteLine(zmiennaInteger);
            Console.WriteLine("Stosujemy więc Modyfikator typu czyli: 5d/10, otrzymując");
            double zmiennaInteger2 = 5d / 10;
            Console.WriteLine(zmiennaInteger2);
            Console.ReadLine();

        }
    }
}
