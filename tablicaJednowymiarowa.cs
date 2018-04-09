using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Stwórz tablicę jednowymiarową i wywołają ją
             * z zastosowaniem pętli.
             * Jak jeszcze można wypisać tablicę, przypisać dla niej wartości?
             */
            int[] tablica1 = new int[4];
            tablica1[0] = 0;
            tablica1[1] = 1;
            tablica1[2] = 2;
            tablica1[3] = 3;
            int suma = 0;
            for (int i = 0; i < tablica1.Length; i++)
            {
                suma += tablica1[i];
                Console.WriteLine(tablica1[i]);
            }
            Console.WriteLine("Długość tablicy 1 wynosi: " + tablica1.Length);
            Console.WriteLine("Suma {0}", suma);

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            int[] tablica2 = new int[4];
           
            tablica2[0] = a;
            tablica2[1] = b;
            tablica2[2] = c;
            tablica2[3] = d;
            for (int i = 0; i < tablica2.Length; i++)
            {
                suma += tablica2[i];
                Console.WriteLine(tablica2[i]);
            }
            Console.WriteLine("Długość tablicy 2 wynosi: " + tablica2.Length);
            Console.WriteLine("Suma {0}", suma);

            int e = 110;
            int f = 111;
            int g = 112;
            int h = 113;
            int[] tablica3 = { e, f, g, h };
            
            foreach (int element in tablica3)
            {
                suma += element;
                Console.WriteLine(element);
            }
            Console.WriteLine("Długość tablicy 3 wynosi: " + tablica3.Length);
            Console.WriteLine("Suma {0}", suma);
            Console.ReadKey();
        }
    }
}
