namespace WypozyczalniaPojazdów
{
    public abstract class Pojazd
    {
        private static long id_counter;
        protected long Id;
        protected string Marka;
        protected string Model;
        protected RodzajPojazdu RodzajPojazdu;
        protected StanPojazdu StanPojazdu;

        protected Pojazd(string marka, string model, RodzajPojazdu rodzajPojazdu)
        {
            this.Id = System.Threading.Interlocked.Increment(ref id_counter);
            StanPojazdu = StanPojazdu.DOSTEPNY;
            Marka = marka;
            Model = model;
            RodzajPojazdu = rodzajPojazdu;
        }

        public abstract void WypiszInfo();

        public long Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Marka1
        {
            get => Marka;
            set => Marka = value;
        }

        public string Model1
        {
            get => Model;
            set => Model = value;
        }

        public RodzajPojazdu RodzajPojazdu1
        {
            get => RodzajPojazdu;
            set => RodzajPojazdu = value;
        }

        public StanPojazdu StanPojazdu1
        {
            get => StanPojazdu;
            set => StanPojazdu = value;
        }
    }
}