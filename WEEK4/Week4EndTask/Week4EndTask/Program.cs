using System;
using Week4EndTask.Abstract;
using Week4EndTask.Concerete;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("<<<MERHABALAR UYGULAMAMA HOS GELDINIZ>>>");
            Console.WriteLine("Telefon uretmek icin 1, Bilgisayar uretmek icin 2 basiniz...");

            string secim;
            secim = Console.ReadLine();

            while (secim != "1" && secim != "2")
            {
                Console.WriteLine("Lutfen gecerli bir secim yapiniz (1 veya 2):");
                secim = Console.ReadLine();
            }

            if (secim == "1")
            {
                Telefon telefon = new Telefon();

                Console.Write("Seri Numarasi giriniz: ");
                telefon.SeriNumarasi = Console.ReadLine();

                Console.Write("Urun adini giriniz: ");
                telefon.Name = Console.ReadLine();

                Console.Write("Aciklama giriniz: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("Isletim sistemini giriniz: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisansi var mi? (E/H): ");
                telefon.LisansDurumuBelirle(Console.ReadLine());

                telefon.UrunAdiGetir(telefon.Name);
                telefon.BilgileriYazdir();
            }
            else
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Seri Numarasi giriniz: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();

                Console.Write("Urun adini giriniz: ");
                bilgisayar.Name = Console.ReadLine();

                Console.Write("Aciklama giriniz: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("Isletim sistemini giriniz: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB giris sayisini giriniz (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bluetooth var mi? (E/H): ");
                bilgisayar.IsBluetoothDurumBelirleme(Console.ReadLine());

                bilgisayar.UrunAdiGetir(bilgisayar.Name);
                bilgisayar.BilgileriYazdir();
            }

            Console.WriteLine("\nBaska bir urun uretmek ister misiniz? (E/H)");
            string devam = Console.ReadLine().ToLower();

            while (devam != "e" && devam != "h")
            {
                Console.WriteLine("Lutfen gecerli bir secenek giriniz (E/H):");
                devam = Console.ReadLine().ToLower();
            }

            if (devam == "h")
            {
                Console.WriteLine("Iyi gunler dileriz!");
                break;
            }
            Console.Clear();
        }
    }
}