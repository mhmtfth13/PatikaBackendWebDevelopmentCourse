using System;
using System.Numerics;
using System.Threading.Channels;

namespace PatikaWeek7.LINQExercise_1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(-100, 100);
                numbers.Add(rastgeleSayi);
            }

            //Console.WriteLine("=========================");

            // Lambda ile List olusturma mantigi bu sekilde oluyor....
            //List<int> testNumber = Enumerable.Range(1,10)
            //                       .Select (x => new Random().Next(1,1000000))
            //                       .ToList();



            var ciftSayilar = numbers.Where(x => x % 2 == 0).ToList();
            var tekSayilar = numbers.Where(x => x % 2 != 0).ToList();
            var negatifSayilar = numbers.Where(x => x < 0).ToList();
            var pozitifSayilar = numbers.Where(x => x > 0).ToList();
            var filter1 = numbers.Where(x => x > 16 && x < 22).ToList();
            // List<int> newList = numbers.Select(x => x * x ).ToList();
            // Yukaridaki tanim yerine var ile kullanmak daha mantikli zaten sag taraf liste olarak verecek bu tanimlama gereksiz oldu ama olsun...
            var newList = numbers.Select(x => x * x ).ToList();


            Console.WriteLine("Çift olan sayılar:");
            foreach (var x in ciftSayilar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Tek olan sayılar:");
            foreach (var x in tekSayilar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Negatif olan sayılar:");
            foreach (var x in negatifSayilar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Pozitif olan sayılar:");
            foreach (var x in pozitifSayilar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("15'ten buyuk ve 22'den kucuk  olan sayılar:");
            foreach (var x in filter1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Listedki butun sayilarinin karesini almasi:");
            foreach (var x in newList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++");





        }
    }
}