namespace WypozyczalniaPojazdów
{
    public class Samochód : Pojazd
    {
        private RodzajNadwozia RodzajNadwozia { set; get; }
        private RodzajPaliwa RodzajPaliwa { set; get; }
        private int PojemnoscSilnika { set; get; }
        private int Moc { set; get; }

        public Samochód(string marka, string model, RodzajPojazdu rodzajPojazdu, RodzajNadwozia rodzajNadwozia, 
            RodzajPaliwa rodzajPaliwa, int pojemnoscSilnika, int moc) : base(marka, model, rodzajPojazdu)
        {
            RodzajNadwozia = rodzajNadwozia;
            RodzajPaliwa = rodzajPaliwa;
            PojemnoscSilnika = pojemnoscSilnika;
            Moc = moc;
        }

        public override string WypiszInfo()
        {
            return ("{0} {1} {2} {3} {4} {5} {6} {7} {8}", Id, Marka, Model, RodzajPojazdu, RodzajNadwozia,
                RodzajPaliwa, PojemnoscSilnika, Moc).ToString();
        }
    }
}