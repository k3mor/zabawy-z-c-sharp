using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyZargumentami
{

    class Szkolenia {
        public string TytulSzkolenia;
        public double Cena;
        public int LiczbaGodzin;
        public string Kategoria;

        public void nazwa_Szkolenia(string tytul_kursu) {
            TytulSzkolenia = tytul_kursu;
            Console.WriteLine("Tytuł szkolenia: " + TytulSzkolenia);
        }

        public void Cena_Szkolenia(double cena_kursu)
        {
            Cena = cena_kursu;
            Console.WriteLine("Cena Szkolenia: " + (Cena)+"zł");
        }

        public void Czas_Szkolenia(int czas_kursu)
        {
            LiczbaGodzin = czas_kursu;
            Console.WriteLine("Liczba godzin: " + LiczbaGodzin);
        }

        public void Kategoria_Szkolenia(string kategoria_kursu)
        {
            Kategoria = kategoria_kursu;
            Console.WriteLine("Kategoria szkolenia: " + Kategoria);
        }

        //*********** Wszystko wyświela ***************//
        public void InformacjeOszkoleniach(string tytul_kursu, double cena_kursu, int czas_kursu, string kategoria_kursu) {
            TytulSzkolenia = tytul_kursu;
            Console.WriteLine("Tytuł szkolenia: " + TytulSzkolenia);
            Cena = cena_kursu;
            Console.WriteLine("Cena Szkolenia: " + Cena);
            LiczbaGodzin = czas_kursu;
            Console.WriteLine("Liczba godzin: " + LiczbaGodzin);
            Kategoria = kategoria_kursu;
            Console.WriteLine("Kategoria szkolenia: " + Kategoria);
        }
        //Wskaźnik THIS
        
    }
    class RadyPedagogiczne {
        public string tytul_rady;
        public double cena_rady;
        public int czas_rady;
        public string kategoria_rady;
        //Metoda klasy
        public void info_Rady(string tytul_rady, double cena_rady, int czas_rady, string kategoria_rady) {
            this.tytul_rady = tytul_rady;
            Console.WriteLine("Tytuł Rady Pedagogicznej: " + tytul_rady);
            this.cena_rady = cena_rady;
            Console.WriteLine("Cena Rady Pedagogicznej: " + cena_rady);
            this.czas_rady = czas_rady;
            Console.WriteLine("Czas Rady Pedagogicznej: " + czas_rady);
            this.kategoria_rady = kategoria_rady;
            Console.WriteLine("Kategoria Rady Pedagogicznej: " + kategoria_rady);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Szkolenia kurs_csharp = new Szkolenia();
            Szkolenia kurs_Dot_Net = new Szkolenia();
            Console.WriteLine("***********************");
            kurs_csharp.nazwa_Szkolenia("Programowanie w c# i .NET");
            kurs_csharp.Cena_Szkolenia(200);
            kurs_csharp.Czas_Szkolenia(40);
            kurs_csharp.Kategoria_Szkolenia("IT - programowanie");

            Console.WriteLine("***********************");
            kurs_csharp.InformacjeOszkoleniach("Programowanie w c#",200.00,40,"IT - programowanie");
            Console.WriteLine("***********************");
            kurs_Dot_Net.InformacjeOszkoleniach("Programowanie w .NET", 200.00, 40, "IT - programowanie");

            Console.WriteLine("***********************");
            RadyPedagogiczne nowa_ocena = new RadyPedagogiczne();
            nowa_ocena.info_Rady("Nowa ocena nauczyciela", 150.55, 20, "Awans zawodowy nauczyciela");

            Console.ReadLine();
        }
    }
}
