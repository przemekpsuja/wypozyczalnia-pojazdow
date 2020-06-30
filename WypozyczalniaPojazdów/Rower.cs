using System;

namespace WypozyczalniaPojazdów
{
    public class Rower : Pojazd, IObslugaWypozyczalni
    {
        private int IloscPrzezutek;
        private string RodzajRoweru;


        public Rower(string marka, string model, RodzajPojazdu rodzajPojazdu,
            string rodzajRoweru, int iloscPrzezutek) : base(marka, model, rodzajPojazdu)
        {
            RodzajRoweru = rodzajRoweru;
            IloscPrzezutek = iloscPrzezutek;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Id: {0}, {1}, {2}, {3}, {4}, {5}, " +
                              "Ilość przeżutek: {6}",
                Id, RodzajPojazdu, StanPojazdu, Marka, Model, RodzajRoweru, IloscPrzezutek);
        }

        public void Wypozycz(int i)
        {
            if (this.StanPojazdu1 == StanPojazdu.DOSTEPNY)
            {
                StanPojazdu1 = StanPojazdu.WYPOZYCZONY;
            }
            else
            {
                Console.WriteLine("Ten rower jest niedostępny!");
            }
        }

        public void Zwroc(int i)
        {
            if (this.StanPojazdu1 == StanPojazdu.WYPOZYCZONY)
            {
                StanPojazdu1 = StanPojazdu.DOSTEPNY;
                // Console.WriteLine("Zwróciłeś {0} ", this.WypiszInfo());
            }
            else
            {
                Console.WriteLine("Nie masz takiego roweru");
            }
        }
    }
}