using System;
using System.Collections.Generic;


namespace PatikaWeek5.ListExercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> kahveGirdileri = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"Kahve {i + 1}: ");
                Console.ForegroundColor = ConsoleColor.Green;    // Kahve ismi için yeşil
                string kahveAdi = Console.ReadLine();
                kahveGirdileri.Add(kahveAdi);
            }
            Console.WriteLine();  // Boş satır
            Console.ForegroundColor = ConsoleColor.White;  // Başlık için beyaz
            Console.WriteLine("Girilen Kahve İsimleri:");
            foreach (string kahve in kahveGirdileri)
            {
                Console.ForegroundColor = ConsoleColor.Gray;  // Kahve isimleri için gri
                Console.WriteLine(kahve);
            }

            Console.ResetColor();
        }
    }
}