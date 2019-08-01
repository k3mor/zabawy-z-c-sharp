using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachStart
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] liczby = { 1,2,3 };
            foreach (int liczba in liczby)
            {
                System.Console.Write(liczba);
            }
            Console.ReadLine();
        }
        
    }
}
