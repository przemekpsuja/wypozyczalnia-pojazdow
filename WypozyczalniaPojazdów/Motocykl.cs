using System;

namespace WypozyczalniaPojazdów
{
    public class Motocykl : Pojazd
    {
        private double Spalanie { set; get; }
        private string PredkoscMax { set; get; }

        public Motocykl(string marka, string model, RodzajPojazdu rodzajPojazdu, double spalanie, string predkoscMax) :
            base(marka, model, rodzajPojazdu)
        {
            Spalanie = spalanie;
            PredkoscMax = predkoscMax;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Id: {0}, {1}, {2}, {3}, {4}, Spalanie: {5}L/100km, V-max: {6}",
                Id, RodzajPojazdu, StanPojazdu, Marka, Model, Spalanie, PredkoscMax);
        }
    }
}