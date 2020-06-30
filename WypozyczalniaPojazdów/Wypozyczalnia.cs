using System;
using System.Collections.Generic;

namespace WypozyczalniaPojazdów
{
    public class Wypozyczalnia : IObslugaWypozyczalni
    {
        public List<Pojazd> ListaPojazdow;

        public Wypozyczalnia()
        {
            ListaPojazdow = new List<Pojazd>();
            ListaPojazdow.Add(new Samochód("Audi", "TT", RodzajPojazdu.SAMOCHÓD, "Coupe",
                "PB", 1787, 150));
            ListaPojazdow.Add(new Samochód("Fiat", "Punto", RodzajPojazdu.SAMOCHÓD, "Sedan",
                "ON", 1124, 60));
            ListaPojazdow.Add(new Rower("Merida", "Matts", RodzajPojazdu.ROWER, "Miejski",
                21));
            ListaPojazdow.Add(new Rower("Marin", "Jupiter Trail", RodzajPojazdu.ROWER, "Górski",
                27));
            ListaPojazdow.Add(new Hulajnoga("Xiaomi", "MiJia 365", RodzajPojazdu.HULAJNOGA,
                "Dwuosobowa", "40 km"));
            ListaPojazdow.Add(new Hulajnoga("Blaupunkt", "ESC808", RodzajPojazdu.HULAJNOGA,
                "Dziecięca", "15 km"));
            ListaPojazdow.Add(new Motocykl("Honda", "Hornet", RodzajPojazdu.MOTOCYKL, 6.0,
                "215 km/h"));
            ListaPojazdow.Add(new Motocykl("Piaggio", "X9", RodzajPojazdu.MOTOCYKL, 3.5,
                "170 km/h"));
        }

        public void WypiszPojazdy()
        {
            foreach (var pojazd in ListaPojazdow)
            {
                pojazd.WypiszInfo();
            }
        }

        public void Wypozycz(int i)
        {
            if (ListaPojazdow[i - 1].StanPojazdu1 == StanPojazdu.DOSTEPNY)
            {
                ListaPojazdow[i - 1].StanPojazdu1 = StanPojazdu.WYPOZYCZONY;
                Console.WriteLine("Wypożyczyłeś pojazd o Id: {0}", ListaPojazdow[i - 1].Id1);
            }
            else
            {
                Console.WriteLine("Pojazd on ID: {0} jest niedostępny", i);
            }
        }

        public void Zwroc(int i)
        {
            if (ListaPojazdow[i - 1].StanPojazdu1 == StanPojazdu.WYPOZYCZONY)
            {
                ListaPojazdow[i - 1].StanPojazdu1 = StanPojazdu.DOSTEPNY;
                Console.WriteLine("Zwróciłeś pojazd o Id: {0}", ListaPojazdow[i - 1].Id1);
            }
            else
            {
                Console.WriteLine("Pojazd on ID: {0} nie był wypożyczony", i);
            }
        }

        public void DodajNowyPojazd()
        {
            string marka, model, rodzajNadwozia, rodzajPaliwa, predkoscMax, rodzajRoweru, rodzajHulajnogi, zasieg;
            int pojemnoscSilnika, moc, iloscPrzezutek;
            double spalanie;
            Console.WriteLine("Jaki pojazd chcesz dodać? Wybierz: ");
            Console.WriteLine("a- Samochód, b- motocykl, c- rower, d hulajnoga");
            string wybranyPojazd = Console.ReadLine();
            switch (wybranyPojazd)
            {
                case "a":
                    Console.WriteLine("Podaj markę: ");
                    marka = Console.ReadLine();
                    Console.WriteLine("Podaj model: ");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj rodzaj nadwozia: ");
                    rodzajNadwozia = Console.ReadLine();
                    Console.WriteLine("Podaj rodzaj paliwa: ");
                    rodzajPaliwa = Console.ReadLine();
                    Console.WriteLine("Podaj pojemność silnika: ");
                    pojemnoscSilnika = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj moc silnika: ");
                    moc = Int32.Parse(Console.ReadLine());
                    Samochód samochód = new Samochód(marka, model, RodzajPojazdu.SAMOCHÓD, rodzajNadwozia, rodzajPaliwa, 
                        pojemnoscSilnika, moc);
                    ListaPojazdow.Add(samochód);
                    break;
                
                case "b":
                    Console.WriteLine("Podaj markę: ");
                    marka = Console.ReadLine();
                    Console.WriteLine("Podaj model: ");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj spalanie: ");
                    spalanie = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj prędkość max: ");
                    predkoscMax = Console.ReadLine();
                    Motocykl motocykl = new Motocykl(marka, model, RodzajPojazdu.MOTOCYKL, spalanie, predkoscMax);
                    ListaPojazdow.Add(motocykl);
                    break;
                
                case "c":
                    Console.WriteLine("Podaj markę: ");
                    marka = Console.ReadLine();
                    Console.WriteLine("Podaj model: ");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj rodzaj roweru: ");
                    rodzajRoweru = Console.ReadLine();
                    Console.WriteLine("Podaj ilość przeżutek: ");
                    iloscPrzezutek = Int32.Parse(Console.ReadLine());
                    Rower rower = new Rower(marka, model, RodzajPojazdu.ROWER, rodzajRoweru, iloscPrzezutek );
                    ListaPojazdow.Add(rower);
                    break;
                
                case "d":
                    Console.WriteLine("Podaj markę: ");
                    marka = Console.ReadLine();
                    Console.WriteLine("Podaj model: ");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj rodzaj hulajnogi: ");
                    rodzajHulajnogi = Console.ReadLine();
                    Console.WriteLine("Podaj zasięg: ");
                    zasieg = Console.ReadLine();
                    Hulajnoga hulajnoga = new Hulajnoga(marka, model, RodzajPojazdu.HULAJNOGA, rodzajHulajnogi, zasieg);
                    ListaPojazdow.Add(hulajnoga);
                    break;
            }
        }
    }
}