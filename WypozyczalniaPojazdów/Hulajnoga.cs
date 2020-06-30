using System;

namespace WypozyczalniaPojazdów
{
    public class Hulajnoga : Pojazd
    {
        private string Zasieg { set; get; }
        private string RodzajHulajnogi { set; get; }


        public Hulajnoga(string marka, string model, RodzajPojazdu rodzajPojazdu,
            string rodzajHulajnogi, string zasieg) : base(marka, model, rodzajPojazdu)
        {
            RodzajHulajnogi = rodzajHulajnogi;
            Zasieg = zasieg;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Id: {0}, {1}, {2}, {3}, {4}, {5}, Zasięg: {6}km",
                Id, RodzajPojazdu, StanPojazdu, Marka, Model, RodzajHulajnogi, Zasieg);
        }
    }
}