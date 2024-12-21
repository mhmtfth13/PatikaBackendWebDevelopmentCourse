using System;

namespace PatikaWeek2.Donguler.WhileExercise {
    class Program {
        static void Main(string[] args)
        {
            //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

            int a = 1;

            while(a !=11)
            {
                Console.WriteLine($"{a}. Kendime inanıyorum, ben bu yazılım işini hallederim!");
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            //2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            int b = 2;
            while(b !=20)
            {

                Console.Write($"{b}, ");
                b++;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            //3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

            int c = 2;
            while (c != 20)
            {

                Console.Write($"{c}, ");
                c+=2;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int d = 51;
            int sonuc = 0;
            while (d != 150)
            {

                sonuc += d;
                d ++;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı= {sonuc}");

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            int e = 2;
            int tekSonuc = 0;
            int ciftSonuc = 0;
            while (e != 120)
            {
                if (e % 2 == 0)
                {
                    ciftSonuc += e;
                }
                else
                {
                    tekSonuc += e;
                }
                e++;
            }
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamları= {tekSonuc}");
            Console.WriteLine($"1 ile 120 arasındaki cift sayıların toplamları= {ciftSonuc}");

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            Console.ReadKey();
        }    
    }

}
