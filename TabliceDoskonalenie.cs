using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaDoskonalenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad.1. Prosta tablica i jej wyświetlenie.
            double[] tab1 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            for (var i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine(tab1[i]);
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadKey();
            //Zad.2. Tablica dwuwymiarowa i jej wyświetlenie.
            int[,] tab2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (var j = 0; j < tab2.GetLength(0); j++)
            {
                for (var k = 0; k < tab2.GetLength(1); k++)
                {
                    Console.Write("{0,1}", tab2[j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadKey();
            //Zad.3. Tablica dwuwymiarowa ze zmiennymi losowymi. 
            int[,] tabLos = new int[3, 4];
            Random los = new Random();
            for (var z = 0; z < tabLos.GetLength(0); z++)
            {
                for (var v = 0; v < tabLos.GetLength(1); v++)
                {
                    tabLos[z, v] = los.Next(100);
                    Console.Write("{0,4}", tabLos[z, v]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadKey();
            /*
               Zad.4. Tablica dwówymiarowa z wyświetlaniem zawartości: co jest w tablicy i na którym miejscu
                       oraz przekazanie wartości tablicy do tablicy.
            */
            double[] pierwszaZmnp = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] drugaZmnp = new double[pierwszaZmnp.Length];
            Console.WriteLine("Liczba elementów tablicy: {0}", pierwszaZmnp.Length);
            Console.WriteLine("Zawartość elementu : {0}{1}{2}", pierwszaZmnp[0], " Pozycja w tabeli: ", Array.IndexOf(pierwszaZmnp, pierwszaZmnp[0]));
            Console.WriteLine("Zawartość elementu : {0}{1}{2}", pierwszaZmnp[1], " Pozycja w tabeli: ", Array.IndexOf(pierwszaZmnp, pierwszaZmnp[1]));
            Console.WriteLine("Zawartość elementu : {0}{1}{2}", pierwszaZmnp[2], " Pozycja w tabeli: ", Array.IndexOf(pierwszaZmnp, pierwszaZmnp[2]));
            Console.WriteLine("Zawartość elementu : {0}{1}{2}", pierwszaZmnp[3], " Pozycja w tabeli: ", Array.IndexOf(pierwszaZmnp, pierwszaZmnp[3]));
            Console.WriteLine("Zawartość elementu : {0}{1}{2}", pierwszaZmnp[4], " Pozycja w tabeli: ", Array.IndexOf(pierwszaZmnp, pierwszaZmnp[4]));
            Array.Copy(pierwszaZmnp, drugaZmnp, 5);
            foreach (double elementTablicy in drugaZmnp)
            {
                Console.WriteLine("{0,4}", elementTablicy);
            }
            Console.ReadKey();
            //Zadanie dodatkowe
            string[][] imiona = {
                new string[] {"Ala", "Tomek", "Jasiu"},
                new string[] {"Ola", "Romek", "Jasiu", "Maciej"},
                new string[] {"Tosia", "Tomek"}
        };
            for (int i = 0; i < imiona.Length; i++)
            {
                for (int j = 0; j < imiona[i].Length; j++)
                {
                    Console.Write("{0,-8}", imiona[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
