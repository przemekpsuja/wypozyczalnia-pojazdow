namespace WypozyczalniaPojazdów
{
    public abstract class Pojazd
    {
        protected long Id = 0;
        protected string Marka { set; get; }
        protected string Model { set; get; }
        protected RodzajPojazdu RodzajPojazdu { set; get; }

        protected Pojazd(string marka, string model, RodzajPojazdu rodzajPojazdu)
        {
            Id++;
            Marka = marka;
            Model = model;
            RodzajPojazdu = rodzajPojazdu;
        }

        public abstract string WypiszInfo();
    }
}