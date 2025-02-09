using PatikaFlix;
using System;

namespace PatikaWeek7.PatikaFlixConsoleAppProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar Patikaflix' e hosgeldiniz...");

            List<Dizi> Diziler = new List<Dizi>();

            dongu:
            while (true)
            {
                string cevap = string.Empty;
                Dizi dizi = new Dizi();
                Console.WriteLine("Lutfen eklemek istediginiz dizileri olusturunuz..");

                Console.WriteLine("Lutfen Eklemek istediginiz dizinin adini giriniz:");
                dizi.SeriesName = Console.ReadLine();
                Console.WriteLine("Lutfen eklemek istediginiz dizinin yapim yilini giriniz:");
                dizi.ProductionDate = Convert.ToDateTime (Console.ReadLine());
                Console.WriteLine("Lutfen eklemek istediginiz dizinin turunu giriniz:");
                dizi.Genre = Console.ReadLine();
                Console.WriteLine("Lutfen eklemek istediginiz dizinin yayina baslama tarihini giriniz:");
                dizi.StartingTime = Convert.ToDateTime (Console.ReadLine());
                Console.WriteLine("Lutfen eklemek istediginiz dizinin yonetmeninin adini giriniz:");
                dizi.DirectorName = Console.ReadLine();
                Console.WriteLine("Lutfen eklemek istediginiz dizinin yayinlandigi kanali giriniz:");
                dizi.ChannelName = Console.ReadLine();
                Diziler.Add(dizi);
                Console.WriteLine($"{dizi.SeriesName} basariyla eklendi...");
                Console.WriteLine("Baska dizi eklemek ister misiniz ?(E/H)");
                cevap = Console.ReadLine().ToUpper();

                if (cevap != "E")
                {
                    
                    break;
                }
                else
                {
                    goto dongu;
                }

            }
            var komediDizileri = Diziler
                .Where(d => d.Genre.ToLower() == "komedi")  
                .Select(d => new KomediDizi
                {
                    SeriesName = d.SeriesName,
                    Genre = d.Genre,
                    DirectorName = d.DirectorName
                })
                .ToList();

            var adaGoreSiraliKomediDizileri = komediDizileri.OrderBy(x => x.SeriesName).ThenBy(x => x.DirectorName).ToList();


            Console.WriteLine("\nKomedi Dizileri (Dizi adina ve yonetmene gore siralanmis):");
            foreach (var komediDizi in adaGoreSiraliKomediDizileri)
            {
                Console.WriteLine($"Dizi: {komediDizi.SeriesName}, " +
                    $"Tür: {komediDizi.Genre}, " +
                    $"Yönetmen: {komediDizi.DirectorName}");
            }
        }
    }
}