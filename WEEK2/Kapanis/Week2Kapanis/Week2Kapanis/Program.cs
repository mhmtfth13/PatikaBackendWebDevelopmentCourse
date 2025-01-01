using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace PatikaWeek2.KapanisEgzersiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Aşağıdaki çıktıyı yazan bir program.

            //Merhaba
            //Nasılsın ?
            //İyiyim
            //Sen nasılsın ?
            Console.WriteLine("Soru-1)");
            Console.WriteLine("Merhaba\nNasilsin?\nIyiyim\nSen nasilsin ?");

            Console.WriteLine("---------------------------------------------------------");

            //2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.Bunların değerlerini atayıp , ekrana yazdırınız.
            Console.WriteLine("Soru-2)");
            int sayi1;
            string kelime1;

            Console.Write("Lutfen sayiyi giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("lutfen girmek isteginiz kelimeyi giriniz:");
            kelime1 = Console.ReadLine();
            Console.WriteLine($"Atanan Integer Deger: {sayi1}, Atanan String Deger:{kelime1}");
            Console.WriteLine("---------------------------------------------------------");

            //3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            Console.WriteLine("Soru-3)");
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 100_000);
            Console.WriteLine($"Rastgele sayi= {rastgeleSayi}");
            Console.WriteLine("---------------------------------------------------------");

            //4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            Console.WriteLine("Soru-4)");
            Random rnd = new Random();
            int rastgeleSayi1 = rnd.Next(1, 100_000);
            Console.WriteLine($"Rastgele sayinin 3'e bolumunden kalan deger= {rastgeleSayi1%3}");
            Console.WriteLine("---------------------------------------------------------");

            //5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            Console.WriteLine("Soru-5)");
            Console.Write("Lutfen yasinizi girebilir misiniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yas > 18 ? "+" : "-"); // Ternary olarak if - else kullanimi yapilmistir.
            Console.WriteLine("---------------------------------------------------------");

            //6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            Console.WriteLine("Soru-6)");
            for (int i = 1; i <11;i++)
            {
                Console.WriteLine($"{i}.Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }
            Console.WriteLine("---------------------------------------------------------");

            //7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            string isim1, isim2;
            Console.WriteLine("Lutfen metinsel bir ifade giriniz...:");
            isim1 = Console.ReadLine();

            if (string.IsNullOrEmpty(isim1) || string.IsNullOrWhiteSpace(isim1))
            {
                Console.WriteLine("Lutfen metinsel bir ifade giriniz...:");
                isim1 = Console.ReadLine();
            }
            Console.WriteLine("Lutfen ikinci metinsel ifadeyi giriniz...:");
            isim2 = Console.ReadLine();

            if (string.IsNullOrEmpty(isim2) || string.IsNullOrWhiteSpace(isim2))
            {
                Console.WriteLine("Lutfen metinsel bir ifade giriniz...:");
                isim2 = Console.ReadLine();
            }
            isimDegistirme(ref isim1, ref isim2);
            static void isimDegistirme(ref string isim1, ref string isim2)
            {
                isim1 = "Gulse Birsel";
                isim2 = "Demet Evgar";
                Console.WriteLine($"{isim1}\n{isim2}");
            }

            //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            BenDegerDondurmem();
            void BenDegerDondurmem()
            {
                Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
            }

            //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

            Console.WriteLine("Lutfen bir sayi giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen bir sayi giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            Metot9(a, b);
            int Metot9(int a, int b)
            {
                Console.WriteLine(a + b);
                return a + b;
            }


            //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            Console.WriteLine("Lutfen True/False degeri giriniz..:");

            bool deger2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(deger2.GetType());
            string sonuc = Metot10(deger2);
            Console.WriteLine(sonuc.ToString());
            Console.WriteLine(sonuc.GetType());
            static string Metot10(bool deger2)
            {
                string sonuc = deger2.ToString();
                return deger2.ToString();
            }


            // 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            int yas1, yas2, yas3;
            Console.WriteLine("Lutfen 1.Kisinin yasini giriniz:");
            yas1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen 2.Kisinin yasini giriniz:");
            yas2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen 3.Kisinin yasini giriniz:");
            yas3 = Convert.ToInt32(Console.ReadLine());
            int yasSonuc = yasHesaplama(yas1, yas2, yas3);
            Console.WriteLine($"Uc kisinin yas ortlamasi={yasSonuc}");
            static int yasHesaplama(int yas1, int yas2, int yas3)
            {

                return (yas1 + yas2 + yas3)/3;
            }

            //12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.



            //13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.



            //14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini(true / false) dönen bir metot.



            //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.



            //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.



            //17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.


            //18 - "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            Console.ReadKey();
        }
    }
    

}