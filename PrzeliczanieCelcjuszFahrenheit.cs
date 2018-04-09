using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Zabawa 1: stwórz prosty kalkulator w lini poleceń,
             * który przelicza stopnie Celcjusza na Fahranheta i odwrotnie,
             * bez sprawdzania błedów. 
             */ 
            //Przeliczenie z Fahrenheita na Celcjusza
            Console.WriteLine("STOSUJ PRZECINEK A NIE ZKROPKĘ");
            Console.WriteLine("PRZELICZANIE Z FAHRENHEITA NA CELCJUSZA (np:41)");
            double Fah, Cel;
            Console.WriteLine("Podaj temp. w stopniach Fahrenheita: ");
            Fah = double.Parse(Console.ReadLine());
            Cel = 5/9d * (Fah-32);
            Console.WriteLine(Cel);
            //Przeliczenie z Celcjusza na Fahrenheita
            Console.WriteLine("PRZELICZANIE Z CELCJUSZA NA FAHRENHEITA (np:36.6)");
            Console.WriteLine("Podaj temp. w stopniach Celcjusza ");
            Cel = double.Parse(Console.ReadLine());
            Fah = (Cel * 9 / 5) + 32;
            Console.WriteLine(Fah);
            Console.ReadLine();
        }
    }
}
