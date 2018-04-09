using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaDwuwymiarowa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Stwórz prostą tablicę dwuwymiarową
             * i wywołaj ją.
             *Czy możesz, podobnie jak w tablicy jednowymiarowej
             * użyć wcześniej zadeklarowanych zmiennych?
             */
            int[,] TabDwuwymiarowa = { {1,2}, {13,14}, {130,140} };
            for (int i = 0; i < TabDwuwymiarowa.GetLength(0); i++)
            {
                for (int j = 0; j < TabDwuwymiarowa.GetLength(1); j++)
                {
                    Console.WriteLine("{0,3}", TabDwuwymiarowa[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
    }
}
