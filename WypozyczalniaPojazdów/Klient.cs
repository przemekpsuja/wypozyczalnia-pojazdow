namespace WypozyczalniaPojazdów
{
    public class Klient
    {
        private string Imie { set; get; }
        private string Nazwisko { set; get; }
        private string NumerTelefonu { set; get; }

        public string WypiszInfo()
        {
            return ("{0} {1} {2}", Imie, Nazwisko, NumerTelefonu).ToString();
        }
    }
}