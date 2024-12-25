using System;

namespace PatikaWeek2.Metotlar.Ornek1
{

    class Program
    {
        static void Main(string[] args)
        {
            Ornek1(); // Ornek1 Metodunu çağırıyoruz.
            Ornek2(); // Ornek2 Metodunu çağırıyoruz.
            Console.WriteLine("Birinci sayıyı giriniz:"); 
            int a = Convert.ToInt32(Console.ReadLine()); // Ornek3 Metodu için veri alıyoruz.
            Console.WriteLine("İkinci sayıyı giriniz:");
            int b = Convert.ToInt32(Console.ReadLine()); // Ornek3 Metodu için veri alıyoruz.
            Ornek3(a, b); // Ornek 3 Metodunu Çağırıyoruz...
            Console.Write("Lutfen isminizi giriniz:"); 
            string isim = Console.ReadLine(); // Ornek4 Metodu için veri alıyoruz...
            Console.Write("Lutfen soyisminizi giriniz:");
            string soyisim = Console.ReadLine(); // Ornek4 Metodu için veri alıyoruz...
            Ornek4(isim,soyisim);

            Console.ReadKey();
        }
        //Geriye Değer Döndürmeyen Bir void metot.
        public static void Ornek1() // Ornek1 Metodu Tanimlama
        {
            Console.WriteLine("Stand up all the night and call the fight\nArmy of the Night/Powerwolf");
        }
        public static int Ornek2() // Ornek2 Metodu Tanimlama
        {
            Random rastgele = new Random();
            int i = rastgele.Next(1, 200); // Rastgele sayi tanimlama
            int sonuc = i % 2;
            Console.WriteLine($"Sonuc ={sonuc}");
            return sonuc;
        }
        public static int Ornek3(int a, int b) // Ornek3 Metodu Tanimlama
        {
            int sonuc1 = a * b;
            Console.WriteLine($"Sonuc = {sonuc1}");
            return sonuc1;
        }
        public static void Ornek4 (string isim, string soy) // Ornek4 Metodu Tanimlama
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soy}");
        }

        

    }
}
