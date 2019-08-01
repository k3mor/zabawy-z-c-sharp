using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pamiętajmy o : 0123456789101112131415161718192021222324
            string tekst1 = "Przykładowy tekst typu string tekst";
            //Przykładowe metody strimgowe
            //Substring - ucina częściowy łańcuch, dwie metody
            Console.WriteLine(tekst1.Substring(4));
            Console.WriteLine(tekst1.Substring(2,4));
            //Szukamy wystapienia fragmentu łańcucha, dwa typy
            Console.WriteLine(tekst1.IndexOf("tekst"));
            Console.WriteLine(tekst1.LastIndexOf("tekst"));
            //Zmiana znaków na duże litery
            Console.WriteLine(tekst1.ToUpper());
            string tekst2 = " tekst ze spacjami ";
            Console.WriteLine(tekst2.Trim());
            Console.WriteLine(tekst2);
            //Klasa string jest niezmienna
            //Dopisanie do tekstu jednej literki powoduje nowy przydział w pammięci 
            //Można to zmienić 
            //w klasie StringBuilder
            Console.ReadLine();
        }
    }
}
