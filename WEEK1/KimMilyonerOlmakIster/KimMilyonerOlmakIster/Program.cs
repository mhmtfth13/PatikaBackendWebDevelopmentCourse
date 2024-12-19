using System;
namespace MilyonerOlmak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak Ister Yarismasina Hos Geldiniz!!");
            Console.WriteLine("---------------------------------------------------");
            int CounterTrue = 0;
            string cevap;

            // Soru 1
            Console.WriteLine("Soru Geliyor.......");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"1-> 2024 Yili Dunya Satranc Sampiyonu Kimdir ?(Lutfen a veyahut b sikkini giriniz..)\na)Magnus Carlsen   b)Gukesh Dommaraju");
            cevap = Console.ReadLine().ToLower();
            if (cevap != "a" && cevap != "b")
            {
                Console.WriteLine("Gecersiz sik girdiniz. Lutfen a veya b giriniz.");
                return;
            }
            if (cevap == "b")
            {
                Console.WriteLine("Dogru Cevapladiniz...Tebrikler");
                CounterTrue += 1;
            }
            else
            {
                Console.WriteLine("Maalesef Soruyu Yanlis Cevapladiniz...");
            }

            // Soru 2
            Console.WriteLine("Siradaki Soru Geliyor.......");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("2-> Dunya Satranc Sampiyonu Gary Kasparov'un IBM tarafindan satranc oynamasi icin gelistirilen makinenin adi nedir ?(Lutfen a veyahut b sikkini giriniz..)\n a) Deep Blue    b) Eternal Blue");
            cevap = Console.ReadLine().ToLower();
            if (cevap != "a" && cevap != "b")
            {
                Console.WriteLine("Gecersiz sik girdiniz. Lutfen a veya b giriniz.");
                return;
            }
            if (cevap == "a")
            {
                Console.WriteLine("Dogru Cevapladiniz....");
                CounterTrue += 1;
            }
            else
            {
                Console.WriteLine("Maalesef Soruyu Yanlis Cevapladiniz....");
            }

            // İlk iki sorudan ikisi de yanlışsa 3. soruyu göstermeye gerek yok
            if (CounterTrue < 2 && CounterTrue > 0)
            {
                Console.WriteLine("Siradaki Soru Geliyor.......");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("3-> 2013 Dunya Satranc Sampiyonu olan Magnus Carlsen, sampiyona da karsilastigi rakibi kimdir?(Lutfen a veyahut b sikkini giriniz..)\na) Viswanathan Anand   b) Sergey Karjakin ");
                cevap = Console.ReadLine().ToLower();
                if (cevap != "a" && cevap != "b")
                {
                    Console.WriteLine("Gecersiz sik girdiniz. Lutfen a veya b giriniz.");
                    return;
                }
                if (cevap == "a")
                {
                    Console.WriteLine("Dogru Cevapladiniz....");
                    CounterTrue += 1;
                }
                else
                {
                    Console.WriteLine("Maalesef soruya yanlis cevap verdiniz.");
                }
            }

            // Final sonucu
            if (CounterTrue >= 2)
            {
                Console.WriteLine("<<<1 MILYON TL'LIK ODULU KAZANDINIZ TEBRIKLER>>>");
            }
            else
            {
                Console.WriteLine($"Toplam {CounterTrue} soruya dogru cevap verdiniz.\n<<<1 MILYON TL'LIK ODULU KAZANAMADINIZ>>>");
            }

            Console.WriteLine("OYUNDAN CIKMAK ICIN BIR TUSA BASINIZ....");
            Console.ReadKey();
        }
    }
}