using System;

namespace WypozyczalniaPojazdów
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wypozyczalnia w = new Wypozyczalnia();
     
            char c;

            do
            {
                c = Menu();
                switch (c)
                {
                    case 'a':
                    case 'A':
                        w.DodajNowyPojazd();
                        Console.ReadLine();
                        break;
                    case 'b':
                    case 'B':
                        w.WypiszPojazdy();
                        Console.WriteLine("Podaj ID pojazdu który chcesz wypożyczyć.");
                        int i = Int32.Parse(Console.ReadLine());
                        w.Wypozycz(i);
                        Console.ReadLine();
                        break;
                    case 'c':
                    case 'C':
                        w.WypiszPojazdy();
                        Console.WriteLine("Podaj ID pojazdu który chcesz zwrócić.");
                        int j = Int32.Parse(Console.ReadLine());
                        w.Zwroc(j);
                        Console.ReadLine();
                        break;
                    case 'd':
                    case 'D':
                        w.WypiszPojazdy();
                        Console.ReadLine();
                        break;
                }
            } while (!(c == 'k' || c == 'K'));
        }

        public static char Menu()
        {
            Console.Clear();
            Console.WriteLine("A - Dodaj pojazd");
            Console.WriteLine("B - Wypożycz pojazd");
            Console.WriteLine("C - Zwróć pojazd");
            Console.WriteLine("D - Wypisz wszystkie pojazdy");
            Console.WriteLine("K - Koniec");
            return Console.ReadKey().KeyChar;
        }
    }
}