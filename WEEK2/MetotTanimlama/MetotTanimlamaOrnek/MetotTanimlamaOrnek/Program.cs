using System;

namespace PatikaWeek2.Metotlar.Ornek1
{

    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Ornek2();
            Console.WriteLine("Birinci sayıyı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            Ornek3(a, b);
            Console.Write("Lutfen isminizi giriniz:");
            string isim = Console.ReadLine();
            Console.Write("Lutfen soyisminizi giriniz:");
            string soyisim = Console.ReadLine();
            Ornek4(isim,soyisim);

            Console.ReadKey();
        }
        //Geriye Değer Döndürmeyen Bir void metot.
        public static void Ornek1()
        {
            Console.WriteLine("Stand up all the night and call the fight\nArmy of the Night/Powerwolf");
        }
        public static int Ornek2()
        {
            Random rastgele = new Random();
            int i = rastgele.Next(1, 200);
            int sonuc = i % 2;
            Console.WriteLine($"Sonuc ={sonuc}");
            return sonuc;
        }
        public static int Ornek3(int a, int b)
        {
            int sonuc1 = a * b;
            Console.WriteLine($"Sonuc = {sonuc1}");
            return sonuc1;
        }
        public static void Ornek4 (string isim, string soy)
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soy}");
        }

        

    }
}