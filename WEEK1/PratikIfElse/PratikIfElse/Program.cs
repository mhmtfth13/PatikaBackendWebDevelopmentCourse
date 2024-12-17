using System;

namespace ThirdProject

{
    class Program
    {
        static void Main(string[] args)        
        {
            int num1;
            Console.Write("Lutfen bir sayi giriniz:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 10)
            {
                Console.WriteLine("Girilen Sayi 10'a esittir.");
            }
            else if (num1 > 10)
            {
                Console.WriteLine("Girilen Sayi 10'dan buyuktur.");
            }
            else {
                Console.WriteLine("Girilen Sayi 10' dan kucuktur.");
            }
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Girilen Sayi Cifttir.");
            }
            else 
            {
                Console.WriteLine("Girilen sayi tektir.");
            }

            Console.ReadKey();
        }
    
    }


}
