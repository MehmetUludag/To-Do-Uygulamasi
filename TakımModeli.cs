namespace to_do_uygulaması
{
    public static class Takim
    {
        public static List<TakimModeli> TakimListesi = new List<TakimModeli>();
    }
    public class TakimModeli
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public TakimModeli(int id, string username)
        {
            this.Id = id;
            this.UserName = username;
        }
    }
}