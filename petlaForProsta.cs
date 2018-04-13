using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wypisz liczby od 1 do 10 w jednym wierszu
            Console.WriteLine("Liczby w jednym wierszu: ");
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("Liczby w jednej kolumnie: ");
            //Wypisz liczby od 1 do 10 w kolumnie
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + ", ");
            }

            //Tabliczka mnożnia prez 8 - w jednym wierszu
            Console.WriteLine("Wyświetlenie liczby z tabliczki mnożenie 8 obok siebie po przecinku: ");
            const int liczba8 = 8;
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i*liczba8 + ", ");
            }
            Console.WriteLine("");
            //Tabliczka mnożnia prez 8 - w jednej kolumnie
            Console.WriteLine("Wyświetlenie liczby z tabliczki mnożenia 8 liczba pod liczbą - kolumna: ");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * liczba8 + ", ");
            }
            //Tabliczka mnożenia
            Console.WriteLine("Wyświetl tabliczkę mnożenia: ");
            const int liczba10 = 10;
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j <=liczba10; j++)
                {
                    Console.Write("{0,3}", i*j);
                }
                Console.WriteLine();
            }
            //Wyświetl trójkat z gwiazdek od jednej gwiadki do 10 gwiazdek
            Console.WriteLine("Trójkąt z gwiazdek od jednej gwiazdki do 10 gwiazdek: ");
            int gwiazdka = 10;
            for (int i = 1; i <= gwiazdka; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
