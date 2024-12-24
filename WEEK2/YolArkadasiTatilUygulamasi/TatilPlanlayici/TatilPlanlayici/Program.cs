using System;
using System.Threading.Channels;


namespace PatikaWeek2.Donguler.TatilPlanlamaUygulamasi
{

    class Program
    {
        static void Main(string[] args)
        {
            string tekrarSecim;

            do // Ana program
            {
                // Degiskenlerin tanimlanmasi
                string lokasyon;
                int kisiSayisi;
                string ulasimSecimi;
                double toplamFiyat = 0;
                bool gecerliLokasyon = false;

                // Tatil seceneklerinin gosterilmesi
                do
                {
                    Console.WriteLine("====================Hosgeldiniz!====================\nLütfen gitmek istediğiniz lokasyonu seçiniz:");
                    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
                    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
                    Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");

                    lokasyon = Console.ReadLine().ToLower(); // Kucuk harfe cevirme islemi

                    // Lokasyon Kontrolu
                    while (!gecerliLokasyon)
                    {
                        if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme" ||
                            lokasyon == "cesme") // ç harfi için alternatif
                        {
                            gecerliLokasyon = true;
                            switch (lokasyon)
                            {
                                case "bodrum":
                                    toplamFiyat = 4000;
                                    break;
                                case "marmaris":
                                    toplamFiyat = 3000;
                                    break;
                                case "çeşme":
                                case "cesme":
                                    toplamFiyat = 5000;
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı lokasyon! Lutfen Bodrum, Marmaris veya Çeşme seçeneklerinden birini giriniz:");
                            lokasyon = Console.ReadLine().ToLower();
                        }
                    }

                    // Kisi sayisi alma
                    Console.WriteLine("Kac Kisi için tatil planlamak istiyorsunuz?");
                    while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
                    {
                        Console.WriteLine("Lütfen geçerli bir Kisi sayısı giriniz:");
                    }

                    // Lokasyon bilgisi gosterme
                    Console.WriteLine($"\n{char.ToUpper(lokasyon[0]) + lokasyon.Substring(1)} için tatil özeti:"); // Lokasyon bilgisinin ilk harfinin buyuk yapilmasi ve sonrasinin kucuk harflerle alinmasi islemi
                    switch (lokasyon)
                    {
                        case "bodrum":
                            Console.WriteLine("Bodrum'da muhteşem plajlar, tekne turları ve eğlence mekanları sizi bekliyor!");
                            break;
                        case "marmaris":
                            Console.WriteLine("Marmaris'te doğa yürüyüşleri, su sporları ve tarihi yerler keşfedebilirsiniz!");
                            break;
                        case "çeşme":
                        case "cesme":
                            Console.WriteLine("Çeşme'de rüzgar sörfü, termal tesisler ve butik oteller bulunmaktadır!");
                            break;
                    }

                    // Ulasim Secenekleri
                    do
                    {
                        Console.WriteLine("\nUlaşım tercihinizi yapınız:");
                        Console.WriteLine("1 - Kara yolu (Kisi başı gidiş-dönüş 1500 TL)");
                        Console.WriteLine("2 - Hava yolu (Kisi başı gidiş-dönüş 4000 TL)");

                        ulasimSecimi = Console.ReadLine();
                        if (ulasimSecimi != "1" && ulasimSecimi != "2")
                        {
                            Console.WriteLine("Hatalı secim! Lütfen 1 veya 2 giriniz.");
                            continue;
                        }
                        break;

                    } while (true);

                    // Toplam fiyat hesaplama
                    int ulasimFiyati = ulasimSecimi == "1" ? 1500 : 4000;
                    toplamFiyat = (toplamFiyat * kisiSayisi) + (ulasimFiyati * kisiSayisi);

                    // SSonuc Gosterme
                    Console.WriteLine($"\nToplam tatil maliyetiniz: {toplamFiyat}");
                    Console.WriteLine($"Kisi basi maliyet: {(toplamFiyat / kisiSayisi)}");

                } while (!gecerliLokasyon);

                // Tekrar sorgusu
                Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır)");
                tekrarSecim = Console.ReadLine().ToLower();

            } while (tekrarSecim == "evet" || tekrarSecim == "e");

            Console.WriteLine("İyi günler dileriz!");
            Console.WriteLine("\nProgram kapatılıyor...");
            Thread.Sleep(2000);
        }
    }
}