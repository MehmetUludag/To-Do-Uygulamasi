namespace to_do_uygulaması
{
    public class Kart
    {
        public string baslik;
        public string icerik;
        public int id;
        public string size;
        public Kart(string baslik, string icerik, int id, string size)
        {
            this.baslik = baslik;
            this.icerik = icerik;
            this.id = id;
            this.size = size;
        }
    }
    public enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}