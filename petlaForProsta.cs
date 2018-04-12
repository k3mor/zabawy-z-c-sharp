using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wypisz liczby od 1 do 10 z użyciem pętli for
            int a = 1;
            for (int i = a; i < 11; i++)
            {
                
                Console.WriteLine(i);
                
            }
            //Wypisz w jednej kolumny liczby do 11 a w drugiej liczby o 1 wiekszą
            Console.WriteLine("{0,8}{1,15}", "Liczba", "Dodaj 1");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0,8}{1,15}", i, i + 1);

            }
            //Zwiększ liczbę o samą siebie
            Console.WriteLine("{0,8}{1,15}", "Liczba", "Zwiększ");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0,8}{1,15}", i, i + i);

            }
            //Pomnóż liczbę przez samą siebie
            Console.WriteLine("{0,8}{1,15}", "Liczba", "Pomnóż");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0,8}{1,15}", i, i * i);

            }

            Console.ReadKey();
        }
    }
}
