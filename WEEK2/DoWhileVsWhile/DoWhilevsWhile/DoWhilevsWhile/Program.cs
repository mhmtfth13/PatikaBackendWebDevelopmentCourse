using System;

namespace PatikaWeek2.Donguler.DoWhileVsWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

            ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

            Örnek inputlar : 10 ve -5*/

            // While örneği
            int limit;
            int sayac = 0;

            Console.Write("Lutfen bir limit degeri belirleyiniz: ");
            limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhile döngüsü ile:");
            while (sayac <= limit)
            {
                Console.WriteLine($"{sayac}. Ben bir Patika'lıyım");
                sayac++;
            }

            // Do-While örneği
            Console.WriteLine("\nDo-While döngüsü ile:");
            sayac = 0; // Sayacı sıfırlıyoruz
            do
            {
                Console.WriteLine($"{sayac}. Ben bir Patika'lıyım");
                sayac++;
            } while (sayac <= limit);
            // While Dongusu hic calismaz cunku 0 <= -5 kosulu bastan yanlistir.
            // Do-While dongusu bir kez calisir cunku kodu calistirip sonra kosulu kontrol eder.

            Console.ReadKey();//Kullanicidan girdi bekleyerek ekrani acik tutuyorum...
        }

    }

}