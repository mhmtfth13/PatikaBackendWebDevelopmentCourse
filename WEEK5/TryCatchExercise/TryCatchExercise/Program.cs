using System;
using System.Collections.Generic;

namespace PatikaWeek5.TryCatchExercise
{
    public class Program
    {
        public static void Main (string[] args)
        {
            
            while (true)
            {

                try
                {
                    Console.WriteLine("Lutfen bir sayi giriniz: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x} sayisinin karesi = "+ SayiGir(x));

                }
                catch (Exception)
                {

                    Console.WriteLine("Gecersiz giris! Lutfen sayi giriniz!");
                    continue;
                }
            }

        }
        public static int SayiGir(int x )
        {
            return x * x;
        }
    }
}