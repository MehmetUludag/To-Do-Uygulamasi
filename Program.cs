using System.Collections.Generic;
namespace to_do_uygulaması
{
    class Program
    {
        public static void Main(string[] args)
        {
            Takim.TakimListesi.Add(new TakimModeli(1,"Mehmet"));
            Takim.TakimListesi.Add(new TakimModeli(2,"Ayşe"));
            Takim.TakimListesi.Add(new TakimModeli(3,"Kadir"));
            Takim.TakimListesi.Add(new TakimModeli(4,"Arif"));
            Takim.TakimListesi.Add(new TakimModeli(5,"Emine"));

            TodoLine.TodoLineList.Add(new Kart("c#", ".Net", 1, Size.M.ToString()));
            TodoLine.TodoLineList.Add(new Kart("java", "spring", 2, Size.S.ToString()));  

            BoardModel.BoardModelDict.Add("TODO Line", TodoLine.TodoLineList);
            BoardModel.BoardModelDict.Add("IN PROGRESS", InProgress.InProgressList);
            BoardModel.BoardModelDict.Add("DONE Line", Done.DoneList);

            StartPrint();

            int select = int.Parse(Console.ReadLine());
            int control = Islemler.ControlFunction(select);
            while (control == 0)
            {
                Islemler.CallFunction(select);
                Islemler.PrintBoard();
                StartPrint();
                select = int.Parse(Console.ReadLine());
                control = Islemler.ControlFunction(select);
            }
            Console.WriteLine("1-4 Aralığı Dışında bir Sayı Girildi, Çıkılıyor...");
            Console.WriteLine("Programı Sonlandırmak için Bir Tuşa Basınız...");
            Console.ReadKey();
        }
        public static void StartPrint()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }
    }
}