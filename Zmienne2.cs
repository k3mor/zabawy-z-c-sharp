using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zapis
            int jakasZmienna1 = 10;
            int jakasZmienna2 = 20;
            int suma = jakasZmienna1 + jakasZmienna2;
            Console.WriteLine(jakasZmienna1);
            Console.WriteLine("{0}", jakasZmienna1);
            Console.WriteLine("Zmienna \"jakasZmienna\" = {0}", jakasZmienna1);
            Console.WriteLine("{0},{1}",jakasZmienna1,jakasZmienna2);
            Console.WriteLine("Zmienna pierwsza = {0}, Zmienna druga={1}, suma={2}", jakasZmienna1,jakasZmienna2,suma);
            Console.WriteLine("Zmienna pierwsza = {0}\nZmienna druga={1}\nsuma={2}", jakasZmienna1, jakasZmienna2, suma);
            Console.WriteLine("Zmienna 1:{0, 8} Zmienna2:{1,10}, Suma wynosi: {2,10}", jakasZmienna1, jakasZmienna2, suma);
            Console.WriteLine("Zmienna 1={0, -8}Zmienna2={1,-10}Suma wynosi={2,-10}", jakasZmienna1, jakasZmienna2, suma);
            //Użycie specyfikatora - jest ich wiele
            Console.WriteLine("Zmienna 1={0, -8:F}Zmienna2={1,-10:F}Suma wynosi={2,-10:F}", jakasZmienna1, jakasZmienna2, suma);
            Console.WriteLine("Zmienna 1={0, -8:P}Zmienna2={1,-10:P}Suma wynosi={2,-10:P}", jakasZmienna1, jakasZmienna2, suma);
            //Ciekwawostka - kolejność wykonywania działań
            //Jaki jest wynik:
            int a = 6 / 2 * (2+1);

            //Jaki jest wynik: 6/2(2+1)?

            //Wykonaj wzór: 2(a+b)^2 + 2(b+c)^2 + 2(a+c)^2;
            double zm1 = 2;
            double zm2 = 3;
            double zm3 = 4;
            int potega = 2;
            double wynik1 = 2*(Math.Pow((zm1+zm2),potega)) + 2 *(Math.Pow((zm2 + zm3), potega)) + 2*(Math.Pow((zm1 + zm3), potega));
            Console.WriteLine(a);
            Console.WriteLine(wynik1);
            //Jaki będzie wynik
            int x = 1;
            int y = 1;
            //b = a;
            int wynik = x++ + 2 * ++y;
            Console.WriteLine(wynik);
            Console.ReadLine();
        }
    }
}
