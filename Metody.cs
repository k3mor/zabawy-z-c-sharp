using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody1
{
    //************* Nowa klasa Szkolenia **********//
    class Szkolenie {
        public string tytulSzkolenia;
        public double Cena;
        public int godzinSzkolenia;
        public string kategoria;

        //**** Funkcja - wywołująca element obiektu //
        public void wyswietl_tytul() {
            Console.WriteLine("Tytuł szkolenia: " + tytulSzkolenia);
        }
    
        public void wyswietl_Cena()
        {
            Console.WriteLine("Cena szkolenia: " + Cena);
        }

        public void wyswietl_godzinSzkolenia()
        {
            Console.WriteLine("Liczba godzin: " + godzinSzkolenia);
        }

        public void wyswietl_kategoria()
        {
            Console.WriteLine("Kategoria szkolenia: " + kategoria);
        }

        //******** Pokaz wszystko ze szkolenia
        public void pokarz_szkolenie() {
            Console.WriteLine(tytulSzkolenia);
            Console.WriteLine(Cena);
            Console.WriteLine(godzinSzkolenia);
            Console.WriteLine(kategoria);
        }
    }
    

    //************* Nowa klasa radyPedagogiczne**********//
    class radyPedagogiczne {

    }
    class Program
    {
        static string alarm(string jakisString)
        {
            return "Hello Roma Zbroiński";
            //string imie = "Hello Roman Zbroiński";
            //return imie;
        }

         
        static void Main(string[] args)
        {
            //************* Tworzenie nowej instancji ***************//
            Szkolenie szkolenie_cSharp = new Szkolenie();
            szkolenie_cSharp.tytulSzkolenia = "Podstawy programowania w c#";
            szkolenie_cSharp.Cena = 250.00;
            szkolenie_cSharp.godzinSzkolenia = 25;
            szkolenie_cSharp.kategoria = "IT - programowanie dla nauczycieli";
            //Szkolenie szkolenie_dotNet = new Szkolenie();
            //Szkolenie szkolenie_cPhp = new Szkolenie();

            //************* Tworzenie nowej instancji ***************
            radyPedagogiczne rada_socialMedia = new radyPedagogiczne();
            radyPedagogiczne rada_pracaWchmurze = new radyPedagogiczne();
            radyPedagogiczne rada_webCMS = new radyPedagogiczne();

            //string imie = Program.alarm("");
            //string imie = alarm("");
            //Console.WriteLine(alarm(""));
            //Console.WriteLine(suma(2, 2));

            //************** Pomocniczea do wyświetlenia **************//
            string textTytul = "Tytuł szkolenia: ";
            string cenaTytul = "Cena szkolenia: ";
            string liczbaGodzinTytul = "Liczba godzin: ";
            string kategoriaTytul = "Kategoria szkolenia: ";

            Console.WriteLine(textTytul + szkolenie_cSharp.tytulSzkolenia);
            Console.WriteLine(cenaTytul + szkolenie_cSharp.Cena);
            Console.WriteLine(liczbaGodzinTytul + szkolenie_cSharp.godzinSzkolenia);
            Console.WriteLine(kategoriaTytul + szkolenie_cSharp.kategoria);

            //Wyświetlanie z użyciem funkcji wyswietl_tytul i inne elementy
            Console.WriteLine("\n" + "Inny sposób wyświetlenia tytułu:");
            szkolenie_cSharp.wyswietl_tytul();
            szkolenie_cSharp.wyswietl_Cena();
            szkolenie_cSharp.wyswietl_godzinSzkolenia();
            szkolenie_cSharp.wyswietl_kategoria();

            //Wyświetlenie całego szklenia
            Console.WriteLine("*****************");
            szkolenie_cSharp.pokarz_szkolenie();

            Console.ReadLine();
        }

    //static int suma(int liczba1, int liczba2)
    //{
    //    return liczba1 + liczba2;
    //}
}
}
