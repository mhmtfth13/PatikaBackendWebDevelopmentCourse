using System;
using System.Runtime.ExceptionServices;


namespace PatikaWeek2.Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}.Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            Console.WriteLine("-------------------------------");

            //2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            for (int j = 2; j<=19; j++)
            {
                Console.Write(j+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");

            //3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            for (int k = 2; k <= 19; k+=2)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("-------------------------------");
            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

            int sonuc = 0;
            for (int a = 51; a < 150; a++)
            {
                sonuc += a;
            }
            Console.WriteLine($"51'den 149'e kadar olan sayilarin toplami= {sonuc}");

            Console.WriteLine("-------------------------------");
            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. 
            int tekSonuc = 0;
            int ciftSonuc = 0;
            for (int b = 2; b < 120; b += 2)
            {

                ciftSonuc += b;
                tekSonuc += (b + 1);//Bu cozum yolunun daha performansli olacagini dusunuyorum...

                //Burada if-else mantigini da kullanabiliriz
                //if (b % 2 == 0)
                //{
                //    ciftSonuc += b;
                //}
                //else
                //{
                //    tekSonuc += b;
                //}
            }
            Console.WriteLine($"1 ile 120 arasindaki tek sayilarin toplami= {tekSonuc}\n1 ile 120 arasindaki cift sayilarin toplami= {ciftSonuc}");
            Console.ReadKey();// Kullanicidan girdi bekleterek ekrani acik tutuyorum...
        }           
    }

}
