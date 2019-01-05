using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witaj_Swiecie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jak zapisujemy zmienne?

            //Wypisz tekst "Witaj Świecie" i zatrzymaj;
            Console.WriteLine("Witaj Świecie");
            //Console.ReadLine();

            //Wprowadzadź swoje imię, następnie nazwisko i przywitaj sie;

            //Imię
            Console.WriteLine("Podaj swoje imię:");
            string imie = Console.ReadLine();
            Console.WriteLine("Witaj"+ " " + imie);
            //Nazwisko
            Console.WriteLine("Podaj swoje nazwisko:");
            string nazwisko;
            nazwisko = Console.ReadLine();
            Console.WriteLine("Witaj" + " " + nazwisko);
            Console.WriteLine("Podaję Twoje imię i nazwisko: "+ imie + " " + nazwisko);
            Console.WriteLine("Witaj Łosiu w kursie c#");
            Console.ReadLine();
        }
    }
}
