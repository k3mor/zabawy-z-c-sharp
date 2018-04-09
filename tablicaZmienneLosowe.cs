using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Stwórz tablicę 3 x 4 z losowo generowanymi liczbami.
             */
            int[,] tablica3x4 = new int[3, 4];
            Random rand = new Random();
            for (int i = 0; i < tablica3x4.GetLength(0); i++)
                {
                for (int j = 0; j < tablica3x4.GetLength(0); j++)
                {
                    tablica3x4[i,j] = rand.Next(100);
                    Console.Write("{0,4}", tablica3x4[i, j]);
                }
                Console.WriteLine();
                }
            Console.ReadKey();
        }
    }
}
