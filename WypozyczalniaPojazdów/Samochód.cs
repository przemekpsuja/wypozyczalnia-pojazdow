using System;

namespace WypozyczalniaPojazdów
{
    public class Samochód : Pojazd
    {
        private string RodzajNadwozia { set; get; }
        private string RodzajPaliwa { set; get; }
        private int PojemnoscSilnika { set; get; }
        private int Moc { set; get; }

        public Samochód(string marka, string model, RodzajPojazdu rodzajPojazdu, string rodzajNadwozia, 
            string rodzajPaliwa, int pojemnoscSilnika, int moc) : base(marka, model, rodzajPojazdu)
        {
            
            RodzajNadwozia = rodzajNadwozia;
            RodzajPaliwa = rodzajPaliwa;
            PojemnoscSilnika = pojemnoscSilnika;
            Moc = moc;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Id: {0}, {1}, {2}, {3}, {4}, {5}, Paliwo: {6}",
                Id, RodzajPojazdu, StanPojazdu, Marka, Model, RodzajNadwozia, RodzajPaliwa);
        }
    }
}