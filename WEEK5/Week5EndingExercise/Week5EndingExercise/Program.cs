
using System;
using System.ComponentModel.Design;


namespace PatikaWeek5.EndingExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();    // Araba listesi olusturulur
            while (true)
            {
                Console.WriteLine("Merhabalar Programa Hos Geldiniz....");

            secimKontrol:    // Kullanicinin tercihi kontrol edilir
                Console.WriteLine("Araba Uretmek istiyor musunuz ? (EVET icin e, HAYIR icin h TUSLAYINIZ.....)");

                string secim = string.Empty;
                string secim2 = string.Empty;
                secim = Console.ReadLine()?.ToLower() ?? "";    // Kullanici girisi alinir ve kucuk harfe cevrilir


                while (secim != "e" && secim != "h")    // Gecerli giris kontrolu
                {
                    Console.WriteLine("Lutfen gecerli bir tercih yapiniz....");
                    goto secimKontrol;
                }

            productionPhase:    // Araba uretim asamasi
                if (secim == "e")
                {
                    Araba araba1 = new Araba();    // Yeni araba nesnesi olusturulur

                    Console.WriteLine("Lutfen arabanin Seri Numarasini giriniz:");
                    araba1.SerialNumber = Console.ReadLine();    // Seri no girisi

                    Console.WriteLine("Lutfen aracin markasini giriniz:");
                    araba1.Marka = Console.ReadLine();    // Marka girisi

                    Console.WriteLine("Lutfen aracin modelini giriniz:");
                    araba1.Model = Console.ReadLine();    // Model girisi

                    Console.WriteLine("Lutfen aracin rengini giriniz:");
                    araba1.Renk = Console.ReadLine();    // Renk girisi

                    bool kapiGecerliMi = false;
                    while (!kapiGecerliMi)    // Kapi sayisi kontrolu
                    {
                        Console.WriteLine("Lutfen aracin kapi sayisini giriniz:");
                        try
                        {
                            araba1.DoorNumber = Convert.ToInt32(Console.ReadLine());
                            kapiGecerliMi = true;
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Lutfen sayisal bir deger giriniz...");
                        }
                    }

                    arabalar.Add(araba1);    // Araba listeye eklenir

                secimKontrol2:    // Yeni araba uretimi kontrolu
                    Console.WriteLine(" Tekrardan araba uretmek istiyor musunuz ? (EVET icin e, HAYIR icin h TUSLAYINIZ.....)");
                    secim2 = Console.ReadLine()?.ToLower() ?? "";

                    while (secim2 != "e" && secim2 != "h")
                    {
                        Console.WriteLine("Lutfen gecerli bir tercih yapiniz....");
                        goto secimKontrol2;
                    }
                    if (secim2 == "e")
                    {
                        goto productionPhase;
                    }
                    else    // Uretilen arabalarin ozellikleri listelenir
                    {
                        Console.WriteLine("OLUSTURMUZ OLDUGUNUZ ARACIN OZELLIKLERI");
                        Console.WriteLine("----------------------------------------");

                        foreach (var i in arabalar)
                        {
                            Console.WriteLine($"Arabanizin uretim tarihi: {i.ProductionTime}");
                            Console.WriteLine($"Arabanizin seri numarasi: {i.SerialNumber}");
                            Console.WriteLine($"Arabanizin Markasi: {i.Marka}");
                            Console.WriteLine($"Arabanizin Modeli: {i.Model}");
                            Console.WriteLine($"Arabanizin Rengi: {i.Renk}");
                            Console.WriteLine($"Arabinizin Kapi Sayisi: {i.DoorNumber}");
                        }
                    }
                }
                if (secim == "h")    // Program sonlandirma kontrolu
                {
                    Console.WriteLine("Program yaptiginiz tercihe gore sonlandirilicaktir...");
                    Thread.Sleep(300);
                    break;
                }
            }
        }
    }

}